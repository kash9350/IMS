Public Class Purchase
    Dim sup_id As Integer
    Dim i As Integer = 1
    Shared str As ArrayList

    Private Sub Purchase_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        con.Open()
        cmd2.Connection = con
        adp1.SelectCommand = cmd2
        cmd2.CommandText = "SELECT * from Supplier_details"
        adp1.Fill(ds2, "Supplier_details")
        con.Close()
        Supp_name.DataSource = ds2.Tables("Supplier_details")
        Supp_name.ValueMember = "Supplier_id"
        Supp_name.DisplayMember = "Supplier_name"
    End Sub
    Private Sub Purchase_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.MdiParent = FisicsHome
        Dim idno As Integer
        con.Open()
        cmd1.Connection = con
        cmd1.CommandText = "SELECT MAX(Purchase_id) from Purchase"
        If cmd1.ExecuteScalar Is DBNull.Value Then
            idno = 1
        Else
            idno = cmd1.ExecuteScalar() + 1
        End If
        pur_id.Text = idno.ToString()
        con.Close()
        con.Open()
        cmd5.Connection = con
        adp5.SelectCommand = cmd5
        cmd5.CommandText = "SELECT Purchase_item_details.P_Item_id, Purchase_item_details.Item_name FROM Purchase_item_details"
        Dim dt As New DataTable
        adp5.Fill(dt)
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

    Private Sub purchaseBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles purchaseBtn.Click
        'Try
        'Dim y As Integer = 0
        'Dim qty As Integer
        'con.Open()
        'cmd2.Connection = con
        'adp2.InsertCommand = cmd2
        'If totalamt.Text = 0 Then
        '    MsgBox("Sales Details Not Mentioned")
        'End If
        'cmd2.CommandText = "INSERT INTO Purchase Values(" & pur_id.Text & "," & Supp_name.SelectedValue & ",'" & pur_date.Text & "','" & totalamt.Text & "')"
        'cmd2.ExecuteNonQuery()
        'While y < DataGridView1.Rows.Count - 1
        '    cmd.Connection = con
        '    adp.SelectCommand = cmd
        '    'MsgBox(DataGridView1.Rows(i).Cells(0).Value)
        '    cmd3.Connection = con
        '    adp3.InsertCommand = cmd3
        '    cmd3.CommandText = "INSERT INTO Purchase_Details Values('" & pur_id.Text & "','" & DataGridView1.Rows(y).Cells(1).Value & "','" & Convert.ToDouble(DataGridView1.Rows(y).Cells(2).Value) & "','" & Convert.ToDouble(DataGridView1.Rows(y).Cells(3).Value) & "','" & Convert.ToDouble(DataGridView1.Rows(y).Cells(4).Value) & "')"
        '    cmd5.Connection = con
        '    cmd5.CommandText = "SELECT TotalQty FROM Purchase_item_details where P_Item_id=" & DataGridView1.Rows(y).Cells(1).Value
        '    If cmd5.ExecuteScalar Is DBNull.Value Then
        '        qty = 0
        '    Else
        '        qty = cmd5.ExecuteScalar
        '        qty = qty + Convert.ToDouble(DataGridView1.Rows(y).Cells(2).Value)
        '    End If
        '    cmd.Connection = con
        '    cmd.CommandText = "UPDATE Purchase_item_details SET TotalQty=" & qty & " where P_Item_id= " & DataGridView1.Rows(y).Cells(1).Value
        '    cmd3.ExecuteNonQuery()
        '    cmd.ExecuteNonQuery()
        '    i += 1
        'End While
        'MsgBox("Inserted")
        'con.Close()
        ''Catch ex As Exception
        ''   MessageBox.Show(ex.Message)
        ''End Try
        Dim y As Integer = 0
        Dim Qty As Integer
        con.Open()
        cmd2.Connection = con
        adp2.InsertCommand = cmd2
        If totalamt.Text = 0 Then
            MsgBox("Purchase Details Not Mentioned")
            GoTo lineend
        End If
        cmd2.CommandText = "INSERT INTO Purchase Values(" & pur_id.Text & "," & Supp_name.SelectedValue & ",'" & pur_date.Text & "','" & totalamt.Text & "')"
        cmd2.ExecuteNonQuery()
        While y < DataGridView1.Rows.Count - 1
            cmd3.Connection = con
            adp3.InsertCommand = cmd3
            cmd3.CommandText = "INSERT INTO Purchase_Details Values(" & pur_id.Text & ",'" & DataGridView1.Rows(y).Cells(1).Value & "','" & Convert.ToDouble(DataGridView1.Rows(y).Cells(2).Value) & "','" & Convert.ToDouble(DataGridView1.Rows(y).Cells(3).Value) & "','" & Convert.ToDouble(DataGridView1.Rows(y).Cells(4).Value) & "')"
            cmd4.Connection = con
            cmd4.CommandText = "SELECT TotalQty FROM Purchase_item_details where P_Item_id=" & DataGridView1.Rows(y).Cells(1).Value
            Qty = CDbl(cmd4.ExecuteScalar)
            If cmd4.ExecuteScalar Is DBNull.Value Then
                MsgBox("Product not available")
                Qty = 0
            Else
                Qty = Qty + Convert.ToDouble(DataGridView1.Rows(y).Cells(2).Value)
            End If
            cmd.Connection = con
            cmd.CommandText = "UPDATE Purchase_item_details SET TotalQty=" & Qty & " where P_Item_id= " & DataGridView1.Rows(y).Cells(1).Value
            cmd3.ExecuteNonQuery()
            cmd.ExecuteNonQuery()
            y += 1
        End While

        MsgBox("Inserted")
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

            '' Confirm that the cell is not empty. 
            If (String.IsNullOrEmpty(e.FormattedValue.ToString())) Then
                DataGridView1.Rows(e.RowIndex).ErrorText = "Quantity should not be Empty"
                e.Cancel = True
            End If

        ElseIf headerText.Equals("Rate") Then

            If (String.IsNullOrEmpty(e.FormattedValue.ToString())) Then
                DataGridView1.Rows(e.RowIndex).ErrorText = "Rate Should not be Empty"
                e.Cancel = True
            End If
        End If

        'If e.ColumnIndex = 0 Then 'VALIDATE FIRST COLUMN

        '    For row As Integer = 0 To DataGridView1.Rows.Count - 1
        '        '

        '        If (DataGridView1.Rows(row).Cells(0).Value = Not Nothing And row = Not e.RowIndex And DataGridView1.Rows(row).Cells(0).Value.Equals(DataGridView1.Rows(e.RowIndex).Cells(e.ColumnIndex).Value)) Then 'and dataGridView1.Rows[row].Cells[0].Value.Equals(dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value) Then

        '            DataGridView1.Rows(e.RowIndex).ErrorText = "Product Should Not Be repeated"
        '            e.Cancel = True

        '            MessageBox.Show("Duplicate")

        '        Else


        '            ' //Add To datagridview



        '        End If
        '    Next
        'End If
    End Sub

    Private Sub DataGridView1_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGridView1.CurrentCellChanged
        Dim i As Integer = 0
        Dim total As Integer
        'Dim name As String = DataGridView1.CurrentRow.Cells(1).ToString
        'str.Add(name)
        DataGridView1.CurrentRow.Cells(4).Value = DataGridView1.CurrentRow.Cells(2).Value * DataGridView1.CurrentRow.Cells(3).Value
        While i < DataGridView1.Rows.Count - 1
            total += DataGridView1.Rows(i).Cells(4).Value
            i += 1
        End While
        totalamt.Text = total.ToString
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        newsupplierdetails.Show()
        Me.Close()
    End Sub

    
    Private Sub DataGridView1_UserAddedRow(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowEventArgs) Handles DataGridView1.UserAddedRow
        DataGridView1.CurrentRow.Cells(0).Value = i
        i += 1
    End Sub
End Class