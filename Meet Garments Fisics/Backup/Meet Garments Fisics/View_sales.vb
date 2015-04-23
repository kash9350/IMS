Imports System.Text.RegularExpressions
Public Class View_sales

    Private Sub Refresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Refresh.Click
        con.Open()
        cmd.Connection = con
        adp.SelectCommand = cmd
        cmd.CommandText = "SELECT Sales.Sales_Id, Customer_details.Customer_name, Sales.Sales_date, Sales.Total_amount FROM Customer_details INNER JOIN Sales ON Customer_details.Customer_id = Sales.Customer_id"
        ds.Clear()
        adp.Fill(ds, "Sales")
        GridSales.DataSource = ds.Tables("Sales")
        With GridSales
            .RowHeadersVisible = False
            .Columns(0).HeaderCell.Value = "Sales Id"
            .Columns(1).HeaderCell.Value = "Customer Name"
            .Columns(2).HeaderCell.Value = "Sales Date"
            .Columns(3).HeaderCell.Value = "Total Amount(₹)"
        End With
        con.Close()
    End Sub

    Private Sub PurReturn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PurReturn.Click
        If GridSales.Rows.Count = 0 Then
            MsgBox("No sales is Selected")
        Else
            Dim sreturn As New Sales_return
            sreturn.MdiParent = FisicsHome
            Sales_return.Sales_id.Text = GridSales.CurrentRow.Cells(0).Value
            Sales_return.Show()
            Me.Close()
        End If
        
    End Sub

    Private Sub View_sales_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        con.Open()
        cmd.Connection = con
        adp.SelectCommand = cmd
        cmd.CommandText = "SELECT Sales.Sales_Id, Customer_details.Customer_name, Sales.Sales_date, Sales.Total_amount FROM Customer_details INNER JOIN Sales ON Customer_details.Customer_id = Sales.Customer_id"
        ds.Clear()
        adp.Fill(ds, "Sales")
        GridSales.DataSource = ds.Tables("Sales")
        With GridSales
            .RowHeadersVisible = False
            .Columns(0).HeaderCell.Value = "Sales Id"
            .Columns(1).HeaderCell.Value = "Customer Name"
            .Columns(2).HeaderCell.Value = "Sales Date"
            .Columns(3).HeaderCell.Value = "Total Amount(₹)"
        End With
        con.Close()
        Me.MdiParent = FisicsHome
    End Sub

    Private Sub SearchSal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SearchSal.Click
        If Search.Text = "" Then
            eror.Visible = True
            eror.Text = "Please Enter Sales ID or Customer Name"
            eror.ForeColor = Color.Red
        Else
            If RDid.Checked = True Then
                Dim regu_name As New Regex("^([0-9])")
                If regu_name.IsMatch(Search.Text) = True Then
                    eror.Visible = False
                    Dim i As Integer = 0
                    con.Open()
                    cmd3.Connection = con
                    adp3.SelectCommand = cmd3
                    cmd3.CommandText = "SELECT Sales.Sales_Id, Customer_details.Customer_name, Sales.Sales_date, Sales.Total_amount FROM Customer_details INNER JOIN Sales ON Customer_details.Customer_id = Sales.Customer_id where Sales_id=" & Search.Text
                    ds3.Clear()
                    adp3.Fill(ds3, "Sales")
                    If ds3.Tables("Sales").Rows.Count > 0 Then
                        eror.Visible = False
                        While i < ds3.Tables("Sales").Rows.Count
                            GridSales.DataSource = ds3.Tables("Sales")
                            With GridSales
                                .RowHeadersVisible = False
                                .Columns(0).HeaderCell.Value = "Sales Id"
                                .Columns(1).HeaderCell.Value = "Customer Name"
                                .Columns(2).HeaderCell.Value = "Sales Date"
                                .Columns(3).HeaderCell.Value = "Total Amount(₹)"
                            End With
                            i += 1
                        End While
                    Else
                        eror.Visible = True
                        eror.Text = "Sales ID not found"
                        eror.ForeColor = Color.Red
                    End If
                    con.Close()
                Else
                    eror.Visible = True
                    eror.Text = "Please Specify Sales Id"
                End If


            ElseIf RdCustomer.Checked = True Then
                Dim regu_name As New Regex("^([a-z]?[A-Z])")
                If regu_name.IsMatch(Search.Text) = True Then
                    eror.Visible = False
                    Dim i As Integer = 0
                    con.Open()
                    cmd3.Connection = con
                    adp3.SelectCommand = cmd3
                    cmd3.CommandText = "SELECT Sales.Sales_Id, Customer_details.Customer_name, Sales.Sales_date, Sales.Total_amount FROM Customer_details INNER JOIN Sales ON Customer_details.Customer_id = Sales.Customer_id where Customer_details.Customer_name='" & Search.Text & "'"
                    ds3.Clear()
                    adp3.Fill(ds3, "Sales")
                    If ds3.Tables("Sales").Rows.Count > 0 Then
                        eror.Visible = False
                        While i < ds3.Tables("Sales").Rows.Count
                            GridSales.DataSource = ds3.Tables("Sales")
                            With GridSales
                                .RowHeadersVisible = False
                                .Columns(0).HeaderCell.Value = "Sales Id"
                                .Columns(1).HeaderCell.Value = "Customer Name"
                                .Columns(2).HeaderCell.Value = "Sales Date"
                                .Columns(3).HeaderCell.Value = "Total Amount(₹)"
                            End With
                            i += 1
                        End While
                    Else
                        eror.Visible = True
                        eror.Text = "No Sales of this Customer"
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

    Private Sub VItems_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VItems.Click
        If GridSales.Rows.Count = 0 Then
            MsgBox("No Sales is There")
        Else
            con.Open()
            cmd4.Connection = con
            adp4.SelectCommand = cmd4
            cmd4.CommandText = "SELECT Sales_item_details.Item_name, Sales_details.Qty, Sales_details.Rate, Sales_details.Amount FROM Sales_item_details INNER JOIN Sales_details ON Sales_item_details.Sales_item_id = Sales_details.Item_id where(Sales_details.Sales_id = " & GridSales.CurrentRow.Cells(0).Value & ")"
            ds4.Clear()
            adp4.Fill(ds4, "Sales_details")
            GridSalesdetails.DataSource = ds4.Tables("Sales_details")
            With GridSalesdetails
                .RowHeadersVisible = False
                .Columns(0).HeaderCell.Value = "Item Name"
                .Columns(1).HeaderCell.Value = "Quantity"
                .Columns(2).HeaderCell.Value = "Rate(₹)"
                .Columns(3).HeaderCell.Value = "Amount(₹)"
            End With
            con.Close()
        End If
        
    End Sub

    Private Sub BtnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnClose.Click
        Me.Close()
    End Sub
End Class