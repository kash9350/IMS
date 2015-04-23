Public Class Sales_return
    Dim i As Integer = 1
    Private Sub Sales_return_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.MdiParent = FisicsHome
        Dim idno As Integer
        con.Open()
        cmd.Connection = con
        cmd.CommandText = "SELECT MAX(Sales_ret_id) from Sales_return"
        cmd.ExecuteScalar()
        If cmd.ExecuteScalar Is DBNull.Value Then
            idno = 1
        Else
            idno = cmd.ExecuteScalar() + 1
        End If
        S_return_id.Text = idno.ToString()
        cmd6.Connection = con
        adp6.SelectCommand = cmd6
        cmd6.CommandText = "SELECT Sales_details.Item_id, Sales_item_details.Item_name FROM Sales_item_details INNER JOIN (Sales INNER JOIN Sales_details ON Sales.Sales_Id = Sales_details.Sales_id) ON Sales_item_details.Sales_item_id = Sales_details.Item_id WHERE (((Sales_details.Sales_id)=" & Sales_id.Text & "))"
        Dim dt As New DataTable
        adp6.Fill(dt)
        Dim cb As New DataGridViewComboBoxColumn
        With cb
            .HeaderText = "Name of Item"
            .DataPropertyName = "item"
            .DataSource = dt
            .DisplayMember = dt.Columns(1).ColumnName
            .ValueMember = dt.Columns(0).ColumnName
            .Width = 240
        End With
        DataGridView1.Columns.Insert(1, cb)
        con.Close()
    End Sub

    Private Sub BtnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnClose.Click
        Me.Close()
    End Sub

    Private Sub DataGridView1_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellEndEdit
        DataGridView1.Rows(e.RowIndex).ErrorText = String.Empty
    End Sub

    Private Sub DataGridView1_CellValidating(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellValidatingEventArgs) Handles DataGridView1.CellValidating
        Dim headerText As String = DataGridView1.Columns(e.ColumnIndex).HeaderText

        ' Abort validation if cell is not in the CompanyName column. 
        If headerText.Equals("Quantity") Then
            If (String.IsNullOrEmpty(e.FormattedValue.ToString())) Then
                DataGridView1.Rows(e.RowIndex).ErrorText = "Quantity Should not be Empty"
                e.Cancel = True
            End If
        End If
    End Sub

    Private Sub DataGridView1_CellValueChanged(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellValueChanged
       
        'Dim count As New Integer
        'count = DataGridView1.Rows.Count
        'For a As Integer = 0 To count - 1
        '    If DataGridView1.CurrentRow.Cells(1).Value = DataGridView1.Rows(a).Cells(1).Value Then
        '        MsgBox("Product should not be duplicated in list", MsgBoxStyle.Critical, "Meet Garments")
        '    End If
        'Next



    End Sub

    Private Sub DataGridView1_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGridView1.CurrentCellChanged
        Dim i As Integer = 0
        Dim rcdQty, RtnQty As Integer
        Dim total As Integer
        con.Open()
        cmd4.Connection = con
        adp4.SelectCommand = cmd4

        DataGridView1.CurrentRow.Cells(5).Value = DataGridView1.CurrentRow.Cells(3).Value * DataGridView1.CurrentRow.Cells(4).Value
        If Not DataGridView1.CurrentRow.Cells(1).Value = 0 Then
            While i < DataGridView1.Rows.Count - 1
                total += DataGridView1.Rows(i).Cells(5).Value
                cmd4.CommandText = "SELECT Sales_details.Qty, Sales_details.Rate FROM Sales_details Where((Sales_Details.Item_id = " & DataGridView1.CurrentRow.Cells(1).Value() & ") AND Sales_Details.Sales_id=" & Sales_id.Text & ")"
                If cmd4.ExecuteScalar Is Nothing Then
                    MsgBox("Product not available")
                Else
                    ds4.Clear()
                    adp4.Fill(ds4, "Sales_details")
                    'MsgBox(ds4.Tables("Sales_details").Rows(0)(0).ToString)
                    'MsgBox(ds4.Tables("Sales_details").Rows(0)(1).ToString)
                    DataGridView1.CurrentRow.Cells(2).Value = ds4.Tables("Sales_details").Rows(0)(0).ToString
                    DataGridView1.CurrentRow.Cells(4).Value = ds4.Tables("Sales_details").Rows(0)(1).ToString
                    rcdQty = CInt(DataGridView1.CurrentRow.Cells(2).Value)
                    RtnQty = CInt(DataGridView1.CurrentRow.Cells(3).Value)
                    If (rcdQty < RtnQty) Then
                        MsgBox("Sales Return Qty is not proper")
                    End If
                    End If
                    i += 1
            End While
        End If
        con.Close()
        totalamt.Text = total.ToString
    End Sub

    Private Sub DataGridView1_UserAddedRow(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowEventArgs) Handles DataGridView1.UserAddedRow
        DataGridView1.CurrentRow.Cells(0).Value = i
        i += 1
    End Sub

    Private Sub purchaseBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles purchaseBtn.Click
        Dim i As Integer = 0
        con.Open()
        cmd2.Connection = con
        adp2.InsertCommand = cmd2
        cmd2.CommandText = "INSERT INTO Sales_return Values('" & S_return_id.Text & "','" & Sales_id.Text & "','" & Sal_r_date.Text & "','" & totalamt.Text & "','" & Desc.Text & "')"
        cmd2.ExecuteNonQuery()
        While i < DataGridView1.Rows.Count - 1
            cmd.Connection = con
            adp.SelectCommand = cmd
            'cmd.CommandText = "SELECT * FROM Purchase_item_details WHERE Item_name='" & DataGridView1.Rows(i).Cells(1). & "'"
            'adp.Fill(ds, "Purchase_item_details")
            cmd3.Connection = con
            adp3.InsertCommand = cmd3
            'MsgBox(ds.Tables("Purchase_item_details").Rows(0).Item(0))
            cmd3.CommandText = "INSERT INTO Sales_return_details Values('" & S_return_id.Text & "','" & DataGridView1.Rows(i).Cells(1).Value & "','" & Convert.ToDouble(DataGridView1.Rows(i).Cells(3).Value) & "','" & Convert.ToDouble(DataGridView1.Rows(i).Cells(4).Value) & "','" & Convert.ToDouble(DataGridView1.Rows(i).Cells(5).Value) & "')"
            cmd5.Connection = con
            cmd5.CommandText = "SELECT Item_remaining FROM Sales_item_details where Sales_item_id=" & DataGridView1.Rows(i).Cells(1).Value
            Dim qty As Integer
            qty = Convert.ToDouble(cmd5.ExecuteScalar)
            If cmd5.ExecuteScalar Is DBNull.Value Then
                MsgBox("Product not available")
                GoTo lineend
            Else
                If Convert.ToDouble(DataGridView1.Rows(i).Cells(3).Value) > qty Then
                    MsgBox("Sorry Stock is less")
                    GoTo lineend
                Else
                    qty = qty - Convert.ToDouble(DataGridView1.Rows(i).Cells(3).Value)
                End If
            End If
            cmd.Connection = con
            cmd.CommandText = "UPDATE Sales_item_details SET Item_remaining=" & qty & " where Sales_item_id= " & DataGridView1.Rows(i).Cells(1).Value
            cmd.ExecuteNonQuery()
            cmd3.ExecuteNonQuery()
            i += 1
        End While

        MsgBox("Return Successfull")
lineend:
        con.Close()
    End Sub
End Class