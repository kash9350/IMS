Public Class Sales_order
    Dim i As Integer = 1
    Private Sub Sales_order_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.MdiParent = FisicsHome
        Dim id As Integer
        con.Open()
        cmd1.Connection = con
        cmd1.CommandText = "SELECT MAX(Order_Id) from Order_master"
        If cmd1.ExecuteScalar Is DBNull.Value Then
            id = 1
        Else
            id = cmd1.ExecuteScalar() + 1
        End If
        Order_id.Text = id.ToString
        cmd6.Connection = con
        adp6.SelectCommand = cmd6
        cmd6.CommandText = "SELECT Sales_item_details.Sales_item_id, Sales_item_details.Item_name FROM Sales_item_details"
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
        DataGridView2.Columns.Insert(1, cb)
        cmd5.Connection = con
        adp5.SelectCommand = cmd5
        cmd5.CommandText = "Select Customer_id,Customer_name from Customer_details"
        adp5.Fill(ds5, "Customer_details")
        With Cust_name
            .DataSource = ds5.Tables("Customer_details")
            .DisplayMember = "Customer_name"
            .ValueMember = "Customer_id"
        End With
        con.Close()

    End Sub

    Private Sub DataGridView2_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView2.CellEndEdit
        DataGridView2.Rows(e.RowIndex).ErrorText = String.Empty
    End Sub

    Private Sub DataGridView2_CellValidating(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellValidatingEventArgs) Handles DataGridView2.CellValidating
        Dim headerText As String = DataGridView2.Columns(e.ColumnIndex).HeaderText

        ' Abort validation if cell is not in the CompanyName column. 
        If headerText.Equals("Quantity") Then
            If (String.IsNullOrEmpty(e.FormattedValue.ToString())) Then
                DataGridView2.Rows(e.RowIndex).ErrorText = "Quantity Should not be Empty"
                e.Cancel = True
            End If
        End If
    End Sub

    Private Sub DataGridView2_UserAddedRow(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowEventArgs) Handles DataGridView2.UserAddedRow
        DataGridView2.CurrentRow.Cells(0).Value = i
        i += 1
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        newcustomerdetails.Show()
        Me.Close()
    End Sub

    Private Sub OrderBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OrderBtn.Click
        If DataGridView2.Rows.Count = 1 Then
            MsgBox(DataGridView2.Rows.Count)
        Else
            Dim i As Integer = 0
            Dim stat As String
            stat = "Pending"
            con.Open()
            cmd2.Connection = con
            adp2.InsertCommand = cmd2
            cmd2.CommandText = "INSERT INTO Order_master Values('" & Order_id.Text & "','" & Cust_name.SelectedValue.ToString & "','" & Sale_date.Text & "','" & stat & "')"
            cmd2.ExecuteNonQuery()
            While i < DataGridView2.Rows.Count - 1
                If DataGridView2.Rows(i).Cells(2).Value Is Nothing Then
                    MsgBox("Please Enter Quantity")
                    GoTo lineend
                End If
                cmd3.Connection = con
                adp3.InsertCommand = cmd3
                cmd3.CommandText = "INSERT INTO Order_details Values('" & Order_id.Text & "','" & DataGridView2.Rows(i).Cells(1).Value & "','" & Convert.ToDouble(DataGridView2.Rows(i).Cells(2).Value) & "')"
                cmd3.ExecuteNonQuery()
                i += 1
            End While
            MsgBox("Order Accepted")
lineend:
            con.Close()
            Me.Close()
            Me.Show()
        End If

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class