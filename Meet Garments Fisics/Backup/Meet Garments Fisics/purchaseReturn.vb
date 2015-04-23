Public Class purchaseReturn
    Dim i As Integer = 1
    Private Sub purchaseReturn_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.MdiParent = FisicsHome
        Dim idno As Integer
        con.Open()
        cmd1.Connection = con
        cmd1.CommandText = "SELECT MAX(Purchase_return_id) from Purchase_return"
        If cmd1.ExecuteScalar Is DBNull.Value Then
            idno = 1
        Else
            idno = cmd1.ExecuteScalar() + 1
        End If
        Return_id.Text = idno.ToString()
        cmd6.Connection = con
        adp6.SelectCommand = cmd6
        cmd6.CommandText = "SELECT Purchase_Details.Item_id, Purchase_item_details.Item_name FROM Purchase_item_details INNER JOIN (Purchase INNER JOIN Purchase_Details ON Purchase.Purchase_id = Purchase_Details.Purchase_id) ON Purchase_item_details.P_Item_id = Purchase_Details.Item_id WHERE (((Purchase_Details.Purchase_id)=" & pur_id.Text & "))"
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

    Private Sub purchaseBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles purchaseBtn.Click
        Dim i As Integer = 0
        con.Open()
        cmd2.Connection = con
        adp2.InsertCommand = cmd2
        cmd2.CommandText = "INSERT INTO Purchase_return Values('" & Return_id.Text & "','" & pur_id.Text & "','" & pur_date.Text & "','" & totalamt.Text & "','" & Desc.Text & "')"
        cmd2.ExecuteNonQuery()
        While i < DataGridView1.Rows.Count - 1
            cmd.Connection = con
            adp.SelectCommand = cmd
            'cmd.CommandText = "SELECT * FROM Purchase_item_details WHERE Item_name='" & DataGridView1.Rows(i).Cells(1). & "'"
            'adp.Fill(ds, "Purchase_item_details")
            cmd3.Connection = con
            adp3.InsertCommand = cmd3
            'MsgBox(ds.Tables("Purchase_item_details").Rows(0).Item(0))
            cmd3.CommandText = "INSERT INTO Purchase_return_details Values('" & Return_id.Text & "','" & DataGridView1.Rows(i).Cells(1).Value & "','" & Convert.ToDouble(DataGridView1.Rows(i).Cells(3).Value) & "','" & Convert.ToDouble(DataGridView1.Rows(i).Cells(4).Value) & "','" & Convert.ToDouble(DataGridView1.Rows(i).Cells(5).Value) & "')"
            cmd5.Connection = con
            cmd5.CommandText = "SELECT TotalQty FROM Purchase_item_details where P_Item_id=" & DataGridView1.Rows(i).Cells(1).Value
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
            cmd.CommandText = "UPDATE Purchase_item_details SET TotalQty=" & qty & " where P_Item_id= " & DataGridView1.Rows(i).Cells(1).Value
            cmd.ExecuteNonQuery()
            cmd3.ExecuteNonQuery()
            i += 1
        End While
        MsgBox("Return Successfull")
lineend:
        con.Close()
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

    Private Sub DataGridView1_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGridView1.CurrentCellChanged
        Dim i As Integer = 0
        Dim total As Integer
        Dim rcdQty, RtnQty As Integer
        con.Open()
        cmd4.Connection = con
        adp4.SelectCommand = cmd4
        
        DataGridView1.CurrentRow.Cells(5).Value = DataGridView1.CurrentRow.Cells(3).Value * DataGridView1.CurrentRow.Cells(4).Value
        If Not DataGridView1.CurrentRow.Cells(1).Value = 0 Then
            While i < DataGridView1.Rows.Count - 1
                total += DataGridView1.Rows(i).Cells(5).Value
                cmd4.CommandText = "SELECT Purchase_Details.Qty, Purchase_Details.Rate FROM(Purchase_Details) WHERE (((Purchase_Details.Item_id)=" & DataGridView1.CurrentRow.Cells(1).Value & ") AND ((Purchase_Details.Purchase_id)=" & pur_id.Text & "))"
                If cmd4.ExecuteScalar Is Nothing Then
                    MsgBox("Product not available")
                Else
                    ds4.Clear()
                    adp4.Fill(ds4, "Purchase_details")
                    'MsgBox(ds4.Tables("Purchase_details").Rows(0)(1).ToString)
                    'MsgBox(ds4.Tables("Purchase_details").Rows(0)(2).ToString)
                    DataGridView1.CurrentRow.Cells(2).Value = ds4.Tables("Purchase_details").Rows(0)(0).ToString
                    DataGridView1.CurrentRow.Cells(4).Value = ds4.Tables("Purchase_details").Rows(0)(1).ToString
                    rcdQty = CInt(DataGridView1.CurrentRow.Cells(2).Value)
                    RtnQty = CInt(DataGridView1.CurrentRow.Cells(3).Value)
                    If (rcdQty < RtnQty) Then
                        MsgBox("Purchase Qty is not proper")
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
End Class