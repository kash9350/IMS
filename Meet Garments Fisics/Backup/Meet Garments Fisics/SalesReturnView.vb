Imports System.Text.RegularExpressions
Public Class SalesReturnView

    Private Sub SalesReturnView_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        con.Open()
        cmd.Connection = con
        adp.SelectCommand = cmd
        cmd.CommandText = "SELECT Sales_return.Sales_ret_id, Sales_return.Sales_id, Sales_return.Sales_return_date, Sales_return.Total, Sales_return.Return_desc FROM Sales_return"
        ds.Clear()
        adp.Fill(ds, "Sales_return")
        GridReturn.DataSource = ds.Tables("Sales_return")
        With GridReturn
            .RowHeadersVisible = False
            .Columns(0).HeaderCell.Value = "Sales Return Id"
            .Columns(1).HeaderCell.Value = "Sales Id"
            .Columns(2).HeaderCell.Value = "Sales Return Date"
            .Columns(3).HeaderCell.Value = "Total Amount(₹)"
            .Columns(4).HeaderCell.Value = "Return Description"
        End With
        con.Close()
        Me.MdiParent = FisicsHome
    End Sub

    Private Sub Refresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Refresh.Click
        con.Open()
        cmd.Connection = con
        adp.SelectCommand = cmd
        cmd.CommandText = "SELECT Sales_return.Sales_ret_id, Sales_return.Sales_id, Sales_return.Sales_return_date, Sales_return.Total, Sales_return.Return_desc FROM Sales_return"
        ds.Clear()
        adp.Fill(ds, "Sales_return")
        GridReturn.DataSource = ds.Tables("Sales_return")
        With GridReturn
            .RowHeadersVisible = False
            .Columns(0).HeaderCell.Value = "Sales Return Id"
            .Columns(1).HeaderCell.Value = "Sales Id"
            .Columns(2).HeaderCell.Value = "Sales Return Date"
            .Columns(3).HeaderCell.Value = "Total Amount(₹)"
            .Columns(4).HeaderCell.Value = "Return Description"
        End With
        con.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If GridReturn.Rows.Count = 0 Then
            MsgBox("No Sales Return is There")
        Else
            con.Open()
            cmd4.Connection = con
            adp4.SelectCommand = cmd4
            cmd4.CommandText = "SELECT Sales_item_details.Item_name, Sales_return_details.Qty, Sales_return_details.Rate, Sales_return_details.Amount FROM Sales_item_details INNER JOIN Sales_return_details ON Sales_item_details.Sales_item_id = Sales_return_details.Item_id WHERE (((Sales_return_details.Return_id)=" & GridReturn.CurrentRow.Cells(0).Value & "));"
            ds4.Clear()
            adp4.Fill(ds4, "Return_details")
            GridReturnDetails.DataSource = ds4.Tables("Return_details")
            With GridReturnDetails
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

    Private Sub SearchPur_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SearchPur.Click
        If Search.Text = "" Then
            eror.Visible = True
            eror.Text = "Please Enter Sales Return ID or Customer Name"
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
                    cmd3.CommandText = "SELECT Sales_return.Sales_ret_id, Sales_return.Sales_id, Sales_return.Sales_return_date, Sales_return.Total, Sales_return.Return_desc FROM Sales_return WHERE Sales_return.Sales_ret_id= " & Search.Text
                    ds3.Clear()
                    adp3.Fill(ds3, "Sales_return")
                    If ds3.Tables("Sales_return").Rows.Count > 0 Then
                        eror.Visible = False
                        While i < ds3.Tables("Sales_return").Rows.Count
                            GridReturn.DataSource = ds3.Tables("Sales_return")
                            With GridReturn
                                .RowHeadersVisible = False
                                .Columns(0).HeaderCell.Value = "Sales Return Id"
                                .Columns(1).HeaderCell.Value = "Sales Id"
                                .Columns(2).HeaderCell.Value = "Sales Return Date"
                                .Columns(3).HeaderCell.Value = "Total Amount(₹)"
                                .Columns(4).HeaderCell.Value = "Return Description"
                            End With
                            i += 1
                        End While
                    Else
                        eror.Visible = True
                        eror.Text = "Sales return ID not found"
                        eror.ForeColor = Color.Red
                    End If
                    con.Close()
                Else
                    eror.Visible = True
                    eror.Text = "Please Enter Numbers"
                End If


            ElseIf RdCst.Checked = True Then
                Dim regu_name As New Regex("^([0-9])")
                If regu_name.IsMatch(Search.Text) = True Then
                    eror.Visible = False
                    Dim i As Integer = 0
                    con.Open()
                    cmd3.Connection = con
                    adp3.SelectCommand = cmd3
                    cmd3.CommandText = "SELECT Sales_return.Sales_ret_id, Sales_return.Sales_id, Sales_return.Sales_return_date, Sales_return.Total, Sales_return.Return_desc FROM Sales_return WHERE Sales_return.Sales_id=" & Search.Text
                    ds3.Clear()
                    adp3.Fill(ds3, "Sales_return")
                    If ds3.Tables("Sales_return").Rows.Count > 0 Then
                        eror.Visible = False
                        While i < ds3.Tables("Sales_return").Rows.Count
                            GridReturn.DataSource = ds3.Tables("Sales_return")
                            With GridReturn
                                .RowHeadersVisible = False
                                .Columns(0).HeaderCell.Value = "Sales Return Id"
                                .Columns(1).HeaderCell.Value = "Sales Id"
                                .Columns(2).HeaderCell.Value = "Sales Return Date"
                                .Columns(3).HeaderCell.Value = "Total Amount(₹)"
                                .Columns(4).HeaderCell.Value = "Return Description"
                            End With
                            i += 1
                        End While
                    Else
                        eror.Visible = True
                        eror.Text = "No Return of this Sales"
                        eror.ForeColor = Color.Red
                    End If
                    con.Close()
                Else
                    eror.Visible = True
                    eror.Text = "Please Enter Numbers"
                End If

            End If

        End If
    End Sub
End Class