Imports System.Text.RegularExpressions

Public Class View_Order

    Private Sub BtnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnClose.Click
        Me.Close()
    End Sub

    Private Sub Refresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Refresh.Click
        con.Open()
        cmd.Connection = con
        adp.SelectCommand = cmd
        cmd.CommandText = "SELECT Order_master.Order_id, Customer_details.Customer_name, Order_master.Date, Order_master.Status FROM Customer_details INNER JOIN Order_master ON Customer_details.Customer_id = Order_master.Customer_id"
        ds.Clear()
        adp.Fill(ds, "Order")
        GridOrder.DataSource = ds.Tables("Order")
        With GridOrder
            .RowHeadersVisible = False
            .Columns(0).HeaderCell.Value = "Order Id"
            .Columns(1).HeaderCell.Value = "Customer Name"
            .Columns(2).HeaderCell.Value = "Order Date"
            .Columns(3).HeaderCell.Value = "Status"
        End With
        con.Close()
    End Sub

    Private Sub View_Order_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        con.Open()
        cmd.Connection = con
        adp.SelectCommand = cmd
        cmd.CommandText = "SELECT Order_master.Order_id, Customer_details.Customer_name, Order_master.Date, Order_master.Status FROM Customer_details INNER JOIN Order_master ON Customer_details.Customer_id = Order_master.Customer_id"
        ds.Clear()
        adp.Fill(ds, "Order")
        GridOrder.DataSource = ds.Tables("Order")
        With GridOrder
            .RowHeadersVisible = False
            .Columns(0).HeaderCell.Value = "Order Id"
            .Columns(1).HeaderCell.Value = "Customer Name"
            .Columns(2).HeaderCell.Value = "Order Date"
            .Columns(3).HeaderCell.Value = "Status"
        End With
        con.Close()
        Me.MdiParent = FisicsHome
    End Sub

    Private Sub VItems_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VItems.Click
        If GridOrder.Rows.Count = 0 Then
            MsgBox("No order is Selected")
        Else
            con.Open()
            cmd4.Connection = con
            adp4.SelectCommand = cmd4
            cmd4.CommandText = "SELECT Sales_item_details.Item_name, Order_details.Qty FROM Sales_item_details INNER JOIN (Order_master INNER JOIN Order_details ON Order_master.Order_id = Order_details.Order_id) ON Sales_item_details.Sales_item_id = Order_details.Item_id where(Order_details.Order_id = " & GridOrder.CurrentRow.Cells(0).Value & ")"
            ds4.Clear()
            adp4.Fill(ds4, "Order_details")
            GridOrderdetails.DataSource = ds4.Tables("Order_details")
            With GridOrderdetails
                .RowHeadersVisible = False
                .Columns(0).HeaderCell.Value = "Item Name"
                .Columns(1).HeaderCell.Value = "Quantity"
            End With
            con.Close()
        End If
        
    End Sub

    Private Sub SearchOrd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SearchOrd.Click
        If Search.Text = "" Then
            eror.Visible = True
            eror.Text = "Please Enter Order ID or Customer Name"
            eror.ForeColor = Color.Red
        Else
            If RDid.Checked = True Then
                Search.Enabled = True
                Dim regu_name As New Regex("^([0-9])")
                If regu_name.IsMatch(Search.Text) = True Then
                    eror.Visible = False
                    Dim i As Integer = 0
                    con.Open()
                    cmd3.Connection = con
                    adp3.SelectCommand = cmd3
                    cmd3.CommandText = "SELECT Order_master.Order_id, Customer_details.Customer_name, Order_master.Date, Order_master.Status FROM Customer_details INNER JOIN Order_master ON Customer_details.Customer_id = Order_master.Customer_id where Order_master.Order_id=" & Search.Text
                    ds3.Clear()
                    adp3.Fill(ds3, "Order")
                    If ds3.Tables("Order").Rows.Count > 0 Then
                        eror.Visible = False
                        While i < ds3.Tables("Order").Rows.Count
                            GridOrder.DataSource = ds3.Tables("Order")
                            With GridOrder
                                .RowHeadersVisible = False
                                .Columns(0).HeaderCell.Value = "Order Id"
                                .Columns(1).HeaderCell.Value = "Customer Name"
                                .Columns(2).HeaderCell.Value = "Order Date"
                                .Columns(3).HeaderCell.Value = "Status"
                            End With
                            i += 1
                        End While
                    Else
                        eror.Visible = True
                        eror.Text = "Order ID not found"
                        eror.ForeColor = Color.Red
                    End If
                    con.Close()
                Else
                    eror.Visible = True
                    eror.Text = "Please Specify Order Id"
                End If
            ElseIf RdOrder.Checked = True Then
                Search.Enabled = True
                Dim regu_name As New Regex("^([a-z]?[A-Z])")
                If regu_name.IsMatch(Search.Text) = True Then
                    eror.Visible = False
                    Dim i As Integer = 0
                    con.Open()
                    cmd3.Connection = con
                    adp3.SelectCommand = cmd3
                    cmd3.CommandText = "SELECT Order_master.Order_id, Customer_details.Customer_name, Order_master.Date, Order_master.Status FROM Customer_details INNER JOIN Order_master ON Customer_details.Customer_id = Order_master.Customer_id where Customer_details.Customer_name='" & Search.Text & "'"
                    ds3.Clear()
                    adp3.Fill(ds3, "Order")
                    If ds3.Tables("Order").Rows.Count > 0 Then
                        eror.Visible = False
                        While i < ds3.Tables("Order").Rows.Count
                            GridOrder.DataSource = ds3.Tables("Order")
                            With GridOrder
                                .RowHeadersVisible = False
                                .Columns(0).HeaderCell.Value = "Order Id"
                                .Columns(1).HeaderCell.Value = "Customer Name"
                                .Columns(2).HeaderCell.Value = "Order Date"
                                .Columns(3).HeaderCell.Value = "Status"
                            End With
                            i += 1
                        End While
                    Else
                        eror.Visible = True
                        eror.Text = "No Order of this Customer"
                        eror.ForeColor = Color.Red
                    End If
                    con.Close()
                Else
                    eror.Visible = True
                    eror.Text = "Please Specify Customer Name"
                End If
            End If
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If GridOrder.Rows.Count = 0 Then
            MsgBox("No Order is There")
        Else
            Sales.Order_id.Text = GridOrder.CurrentRow.Cells(0).Value
            Sales.Csttxt.Text = GridOrder.CurrentRow.Cells(1).Value
            con.Open()
            cmd1.Connection = con
            cmd1.CommandText = "Select Customer_id from Customer_details where Customer_name='" & GridOrder.CurrentRow.Cells(1).Value & "'"
            Sales.custId.Text = cmd1.ExecuteScalar()
            Sales.custId.Visible = False
            con.Close()
            Sales.Show()
            Me.Close()
        End If

        
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If GridOrder.Rows.Count = 0 Then
            MsgBox("No Order is There")
        Else
            Dim orderDetails As New OrderReport
            orderDetails.MdiParent = FisicsHome
            OrderReport.Show()
        End If

    End Sub
End Class