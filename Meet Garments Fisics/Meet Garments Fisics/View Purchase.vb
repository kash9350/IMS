Imports System.Text.RegularExpressions
Public Class View_Purchase

    Private Sub View_Purchase_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.MdiParent = FisicsHome
        con.Open()
        cmd.Connection = con
        adp.SelectCommand = cmd
        cmd.CommandText = "SELECT Purchase.Purchase_id, Supplier_details.Supplier_name, Purchase.Purchase_date, Purchase.Total_amount FROM Supplier_details INNER JOIN Purchase ON Supplier_details.Supplier_id = Purchase.Supplier_id"
        ds.Clear()
        adp.Fill(ds, "Purchase")
        GridPurchase.DataSource = ds.Tables("Purchase")
        With GridPurchase
            .RowHeadersVisible = False
            .Columns(0).HeaderCell.Value = "Purchase Id"
            .Columns(1).HeaderCell.Value = "Supplier Name"
            .Columns(2).HeaderCell.Value = "Purchase Date"
            .Columns(3).HeaderCell.Value = "Total Amount(₹)"
        End With
        con.Close()
    End Sub

    Private Sub Refresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Refresh.Click
        Search.Clear()
        con.Open()
        cmd.Connection = con
        adp.SelectCommand = cmd
        cmd.CommandText = "SELECT Purchase.Purchase_id, Supplier_details.Supplier_name, Purchase.Purchase_date, Purchase.Total_amount FROM Supplier_details INNER JOIN Purchase ON Supplier_details.Supplier_id = Purchase.Supplier_id"
        ds.Clear()
        adp.Fill(ds, "Purchase")
        GridPurchase.DataSource = ds.Tables("Purchase")
        With GridPurchase
            .RowHeadersVisible = False
            .Columns(0).HeaderCell.Value = "Purchase Id"
            .Columns(1).HeaderCell.Value = "Supplier Name"
            .Columns(2).HeaderCell.Value = "Purchase Date"
            .Columns(3).HeaderCell.Value = "Total Amount(₹)"
        End With
        con.Close()
    End Sub

    Private Sub SearchPur_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SearchPur.Click
        If Search.Text = "" Then
            eror.Visible = True
            eror.Text = "Please Enter Purchase ID or Supplier Name"
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
                    cmd3.CommandText = "SELECT Purchase.Purchase_id, Supplier_details.Supplier_name, Purchase.Purchase_date, Purchase.Total_amount FROM Supplier_details INNER JOIN Purchase ON Supplier_details.Supplier_id = Purchase.Supplier_id where Purchase_id=" & Search.Text
                    ds3.Clear()
                    adp3.Fill(ds3, "Purchase")
                    If ds3.Tables("Purchase").Rows.Count > 0 Then
                        eror.Visible = False
                        While i < ds3.Tables("Purchase").Rows.Count
                            GridPurchase.DataSource = ds3.Tables("Purchase")
                            With GridPurchase
                                .RowHeadersVisible = False
                                .Columns(0).HeaderCell.Value = "Purchase Id"
                                .Columns(1).HeaderCell.Value = "Supplier Name"
                                .Columns(2).HeaderCell.Value = "Purchase Date"
                                .Columns(3).HeaderCell.Value = "Total Amount(₹)"
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
                    eror.Text = "Please Specify Purchase Id"
                End If

                
            ElseIf RdSup.Checked = True Then
                Dim regu_name As New Regex("^([a-z]?[A-Z])")
                If regu_name.IsMatch(Search.Text) = True Then
                    eror.Visible = False
                    Dim i As Integer = 0
                    con.Open()
                    cmd3.Connection = con
                    adp3.SelectCommand = cmd3
                    cmd3.CommandText = "SELECT Purchase.Purchase_id, Supplier_details.Supplier_name, Purchase.Purchase_date, Purchase.Total_amount FROM Supplier_details INNER JOIN Purchase ON Supplier_details.Supplier_id = Purchase.Supplier_id where Supplier_details.Supplier_name='" & Search.Text & "'"
                    ds3.Clear()
                    adp3.Fill(ds3, "Purchase")
                    If ds3.Tables("Purchase").Rows.Count > 0 Then
                        eror.Visible = False
                        While i < ds3.Tables("Purchase").Rows.Count
                            GridPurchase.DataSource = ds3.Tables("Purchase")
                            With GridPurchase
                                .RowHeadersVisible = False
                                .Columns(0).HeaderCell.Value = "Purchase Id"
                                .Columns(1).HeaderCell.Value = "Supplier Name"
                                .Columns(2).HeaderCell.Value = "Purchase Date"
                                .Columns(3).HeaderCell.Value = "Total Amount(₹)"
                            End With
                            i += 1
                        End While
                    Else
                        eror.Visible = True
                        eror.Text = "No Purchase of this Supplier"
                        eror.ForeColor = Color.Red
                    End If
                    con.Close()
                Else
                    eror.Visible = True
                    eror.Text = "Please Specify Supplier Name"
                End If
                
            End If

        End If
    End Sub

    Private Sub BtnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnClose.Click
        Me.Close()
    End Sub

    Private Sub PurReturn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PurReturn.Click
        If GridPurchase.Rows.Count = 0 Then
            MsgBox("No Purchase is there")
        Else
            Dim preturn As New purchaseReturn
            preturn.MdiParent = FisicsHome
            purchaseReturn.pur_id.Text = GridPurchase.CurrentRow.Cells(0).Value
            purchaseReturn.Show()
            Me.Close()
        End If
        
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If GridPurchase.Rows.Count = 0 Then
            MsgBox("No purchase is Selected")
        Else
            con.Open()
            cmd4.Connection = con
            adp4.SelectCommand = cmd4
            cmd4.CommandText = "SELECT Purchase_item_details.Item_name, Purchase_Details.Qty, Purchase_Details.Rate, Purchase_Details.Amount FROM Purchase_item_details INNER JOIN Purchase_Details ON Purchase_item_details.P_Item_id = Purchase_Details.Item_id where Purchase_Details.Purchase_id=" & GridPurchase.CurrentRow.Cells(0).Value
            ds4.Clear()
            adp4.Fill(ds4, "Purchase_details")
            GridPurchaseDetails.DataSource = ds4.Tables("Purchase_details")
            With GridPurchaseDetails
                .RowHeadersVisible = False
                .Columns(0).HeaderCell.Value = "Item Name"
                .Columns(1).HeaderCell.Value = "Quantity"
                .Columns(2).HeaderCell.Value = "Rate(₹)"
                .Columns(3).HeaderCell.Value = "Amount(₹)"
            End With
            con.Close()
        End If
        
    End Sub
End Class