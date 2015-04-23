Imports System.Text.RegularExpressions

Public Class PurchaseReturnView

    Private Sub SearchPur_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SearchPur.Click
        If Search.Text = "" Then
            eror.Visible = True
            eror.Text = "Please Enter Purchase Return ID or Purchase ID"
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
                    cmd3.CommandText = "SELECT Purchase_return.purchase_return_id, Purchase_return.Purchase_id, Purchase_return.Purch_return_date, Purchase_return.Total, Purchase_return.Return_desc FROM Purchase_return WHERE Purchase_return.purchase_return_id=" & Search.Text
                    ds3.Clear()
                    adp3.Fill(ds3, "return")
                    If ds3.Tables("return").Rows.Count > 0 Then
                        eror.Visible = False
                        While i < ds3.Tables("return").Rows.Count
                            GridReturn.DataSource = ds3.Tables("return")
                            With GridReturn
                                .RowHeadersVisible = False
                                .Columns(0).HeaderCell.Value = "Purchase Return Id"
                                .Columns(1).HeaderCell.Value = "Purchase Id"
                                .Columns(2).HeaderCell.Value = "Purchase Return Date"
                                .Columns(3).HeaderCell.Value = "Total Amount(₹)"
                                .Columns(4).HeaderCell.Value = "Return Description"
                            End With
                            i += 1
                        End While
                    Else
                        eror.Visible = True
                        eror.Text = "Purchase return ID not found"
                        eror.ForeColor = Color.Red
                    End If
                    con.Close()
                Else
                    eror.Visible = True
                    eror.Text = "Please Enter Numbers"
                End If
            ElseIf RdSup.Checked = True Then
                Dim regu_name As New Regex("^([0-9])")
                If regu_name.IsMatch(Search.Text) = True Then
                    eror.Visible = False
                    Dim i As Integer = 0
                    con.Open()
                    cmd3.Connection = con
                    adp3.SelectCommand = cmd3
                    cmd3.CommandText = "SELECT Purchase_return.purchase_return_id, Purchase_return.Purchase_id, Purchase_return.Purch_return_date, Purchase_return.Total, Purchase_return.Return_desc FROM Purchase_return WHERE Purchase_return.Purchase_id=" & Search.Text
                    ds3.Clear()
                    adp3.Fill(ds3, "return")
                    If ds3.Tables("return").Rows.Count > 0 Then
                        eror.Visible = False
                        While i < ds3.Tables("return").Rows.Count
                            GridReturn.DataSource = ds3.Tables("return")
                            With GridReturn
                                .RowHeadersVisible = False
                                .Columns(0).HeaderCell.Value = "Purchase Return Id"
                                .Columns(1).HeaderCell.Value = "Purchase Id"
                                .Columns(2).HeaderCell.Value = "Purchase Return Date"
                                .Columns(3).HeaderCell.Value = "Total Amount(₹)"
                                .Columns(4).HeaderCell.Value = "Return Description"
                            End With
                            i += 1
                        End While
                    Else
                        eror.Visible = True
                        eror.Text = "Purchase ID not found"
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

    Private Sub Refresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Refresh.Click
        con.Open()
        cmd.Connection = con
        adp.SelectCommand = cmd
        cmd.CommandText = "SELECT Purchase_return.purchase_return_id, Purchase_return.Purchase_id, Purchase_return.Purch_return_date, Purchase_return.Total, Purchase_return.Return_desc FROM Purchase_return"
        ds.Clear()
        adp.Fill(ds, "Return")
        GridReturn.DataSource = ds.Tables("Return")
        With GridReturn
            .RowHeadersVisible = False
            .Columns(0).HeaderCell.Value = "Purchase Return Id"
            .Columns(1).HeaderCell.Value = "Purchase Id"
            .Columns(2).HeaderCell.Value = "Purchase Return Date"
            .Columns(3).HeaderCell.Value = "Total Amount(₹)"
            .Columns(4).HeaderCell.Value = "Return Description"
        End With
        con.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If GridReturn.Rows.Count = 0 Then
            MsgBox("No Purchase Return is There")
        Else
            con.Open()
            cmd4.Connection = con
            adp4.SelectCommand = cmd4
            cmd4.CommandText = "SELECT Purchase_item_details.Item_name, Purchase_return_details.Qty, Purchase_return_details.Rate, Purchase_return_details.Amount FROM Purchase_item_details INNER JOIN Purchase_return_details ON Purchase_item_details.P_Item_id = Purchase_return_details.Item_id WHERE (((Purchase_return_details.Return_id)=" & GridReturn.CurrentRow.Cells(0).Value & "));"
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

    Private Sub PurchaseReturnView_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        con.Open()
        cmd.Connection = con
        adp.SelectCommand = cmd
        cmd.CommandText = "SELECT Purchase_return.purchase_return_id, Purchase_return.Purchase_id, Purchase_return.Purch_return_date, Purchase_return.Total, Purchase_return.Return_desc FROM Purchase_return"
        ds.Clear()
        adp.Fill(ds, "Return")
        GridReturn.DataSource = ds.Tables("Return")
        With GridReturn
            .RowHeadersVisible = False
            .Columns(0).HeaderCell.Value = "Purchase Return Id"
            .Columns(1).HeaderCell.Value = "Purchase Id"
            .Columns(2).HeaderCell.Value = "Purchase Return Date"
            .Columns(3).HeaderCell.Value = "Total Amount(₹)"
            .Columns(4).HeaderCell.Value = "Return Description"
        End With
        con.Close()
        Me.MdiParent = FisicsHome
    End Sub
End Class