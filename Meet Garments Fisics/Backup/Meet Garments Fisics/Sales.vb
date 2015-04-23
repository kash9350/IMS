Public Class Sales
    Dim i As Integer = 1

    Private Sub Sales_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.MdiParent = FisicsHome
        Dim id As Integer
        con.Open()
        cmd1.Connection = con
        cmd1.CommandText = "SELECT MAX(Sales_Id) from Sales"
        If cmd1.ExecuteScalar Is DBNull.Value Then
            id = 1
        Else
            id = cmd1.ExecuteScalar() + 1
        End If
        Sales_id.Text = id.ToString
        con.Close()
        con.Open()
        If Order_id.Text = 0 Then
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
            ds5.Clear()
            adp5.Fill(ds5, "Customer_details")
            With Cust_name
                .DataSource = ds5.Tables("Customer_details")
                .DisplayMember = "Customer_name"
                .ValueMember = "Customer_id"
            End With
        Else
            Csttxt.Visible = True
            Button1.Visible = False
            cmd6.Connection = con
            adp6.SelectCommand = cmd6
            cmd6.CommandText = "SELECT Order_details.Item_id, Sales_item_details.Item_name FROM Sales_item_details INNER JOIN Order_details ON Sales_item_details.Sales_item_id = Order_details.Item_id WHERE (((Order_details.Order_id)=" & Order_id.Text & "))"
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
        End If
        con.Close()

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        newcustomerdetails.Show()
        Me.Close()
    End Sub

    Private Sub SalesBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalesBtn.Click
        Dim y As Integer = 0
        Dim Qty, Rol As Integer
        con.Open()
        cmd2.Connection = con
        adp2.InsertCommand = cmd2
        If totalamt.Text = 0 Then
            MsgBox("Sales Details Not Mentioned")
            GoTo lineend
        End If
        If Order_id.Text = 0 Then
            cmd2.CommandText = "INSERT INTO Sales Values(" & Sales_id.Text & "," & Order_id.Text & "," & Cust_name.SelectedValue & ",'" & Sale_date.Text & "','" & totalamt.Text & "')"
            cmd2.ExecuteNonQuery()
        Else
            cmd2.CommandText = "INSERT INTO Sales Values(" & Sales_id.Text & "," & Order_id.Text & "," & custId.Text & ",'" & Sale_date.Text & "','" & totalamt.Text & "')"
            cmd2.ExecuteNonQuery()
        End If
        While y < DataGridView2.Rows.Count - 1
            cmd3.Connection = con
            adp3.InsertCommand = cmd3
            cmd3.CommandText = "INSERT INTO Sales_details Values(" & Sales_id.Text & ",'" & DataGridView2.Rows(y).Cells(1).Value & "','" & Convert.ToDouble(DataGridView2.Rows(y).Cells(2).Value) & "','" & Convert.ToDouble(DataGridView2.Rows(y).Cells(3).Value) & "','" & Convert.ToDouble(DataGridView2.Rows(y).Cells(4).Value) & "')"
            cmd4.Connection = con
            adp4.SelectCommand = cmd4
            cmd4.CommandText = "SELECT Item_remaining,Re_order_level FROM Sales_item_details where Sales_item_id=" & DataGridView2.Rows(y).Cells(1).Value
            Dim dt As New DataTable
            adp4.Fill(dt)

            If dt.Rows.Count = 0 Then
                MsgBox("Product not available")
            Else
                Qty = dt.Rows(0).Item(0)
                Rol = dt.Rows(0).Item(1)
                If (Qty - Convert.ToDouble(DataGridView2.Rows(y).Cells(2).Value)) < Rol Then
                    MsgBox("Sorry Stock is less")
                    GoTo lineend
                Else
                    Qty = Qty - Convert.ToDouble(DataGridView2.Rows(y).Cells(2).Value)
                End If
            End If
            cmd.Connection = con
            cmd.CommandText = "UPDATE Sales_item_details SET Item_remaining=" & Qty & " where Sales_item_id= " & DataGridView2.Rows(y).Cells(1).Value
            If Order_id.Text > 0 Then
                cmd7.Connection = con
                cmd7.CommandText = "UPDATE Order_master SET Status='Dispatch' WHERE Order_id=" & Order_id.Text
                cmd7.ExecuteNonQuery()
            End If
            cmd3.ExecuteNonQuery()
            cmd.ExecuteNonQuery()
            y += 1
        End While

        MsgBox("Inserted")
lineend:
        con.Close()
    End Sub

    Private Sub DataGridView2_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView2.CellEndEdit
        DataGridView2.Rows(e.RowIndex).ErrorText = String.Empty
    End Sub

    Private Sub DataGridView2_CellValidating(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellValidatingEventArgs) Handles DataGridView2.CellValidating
        Dim headerText As String = DataGridView2.Columns(e.ColumnIndex).HeaderText
        Dim Qty, Rol As Integer
        If headerText.Equals("Quantity") Then
            cmd4.Connection = con
            adp4.SelectCommand = cmd4
            cmd4.CommandText = "SELECT Item_remaining,Re_order_level FROM Sales_item_details where Sales_item_id=" & DataGridView2.Rows(e.RowIndex).Cells(1).Value
            Dim dt As New DataTable
            adp4.Fill(dt)
            Qty = dt.Rows(0).Item(0)
            Rol = dt.Rows(0).Item(1)
            '' Confirm that the cell is not empty. 
            If (String.IsNullOrEmpty(e.FormattedValue.ToString())) Then
                DataGridView2.Rows(e.RowIndex).ErrorText = "Quantity should not be Empty"
                e.Cancel = True
            ElseIf Qty - e.FormattedValue.ToString < Rol Then
                MsgBox("Quantity is More Than Re-Order Level")
                DataGridView2.Rows(e.RowIndex).ErrorText = "Quantity is More Than Re-Order Level"
                e.Cancel = True
            End If

        ElseIf headerText.Equals("Rate") Then

            If (String.IsNullOrEmpty(e.FormattedValue.ToString())) Then
                DataGridView2.Rows(e.RowIndex).ErrorText = "Rate Should not be Empty"
                e.Cancel = True
            End If
        End If
    End Sub

    Private Sub DataGridView2_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGridView2.CurrentCellChanged
        Dim x As Integer = 0
        Dim total As Integer
        DataGridView2.CurrentRow.Cells(4).Value = DataGridView2.CurrentRow.Cells(2).Value * DataGridView2.CurrentRow.Cells(3).Value
        If Order_id.Text = 0 Then
            While x < DataGridView2.Rows.Count - 1
                total += DataGridView2.Rows(x).Cells(4).Value
                x += 1
            End While
        Else
            If Not DataGridView2.CurrentRow.Cells(1).Value = 0 Then
                While x < DataGridView2.Rows.Count - 1
                    total += DataGridView2.Rows(x).Cells(4).Value
                    con.Open()
                    cmd4.Connection = con
                    adp4.SelectCommand = cmd4
                    cmd4.CommandText = "SELECT Order_details.Qty FROM(Order_details) WHERE (((Order_details.Order_id)=" & Order_id.Text & ") AND ((Order_details.Item_id)=" & DataGridView2.CurrentRow.Cells(1).Value & "))"
                    If cmd4.ExecuteScalar Is Nothing Then
                        MsgBox("Product not available")
                    Else
                        ds4.Clear()
                        adp4.Fill(ds4, "Sales_details")
                        'MsgBox(ds4.Tables("Sales_details").Rows(0)(0).ToString)
                        'MsgBox(ds4.Tables("Sales_details").Rows(0)(2).ToString)
                        DataGridView2.CurrentRow.Cells(2).Value = ds4.Tables("Sales_details").Rows(0)(0).ToString
                    End If
                    con.Close()
                    x += 1
                End While
            End If
        End If
        totalamt.Text = total.ToString
    End Sub

    Private Sub DataGridView2_UserAddedRow(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowEventArgs) Handles DataGridView2.UserAddedRow
        DataGridView2.CurrentRow.Cells(0).Value = i
        i += 1
    End Sub
End Class