Imports System.Text.RegularExpressions
Public Class View_Item

    Private Sub View_Item_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.MdiParent = FisicsHome
        con.Open()
        cmd.Connection = con
        adp.SelectCommand = cmd
        cmd.CommandText = "SELECT Sales_item_details.Sales_item_id, Sales_item_details.Item_name, Sales_item_details.Item_remaining, Sales_item_details.Re_order_level FROM Sales_item_details"
        ds.Clear()
        adp.Fill(ds, "Item")
        GridItem.DataSource = ds.Tables("Item")
        With GridItem
            .RowHeadersVisible = False
            .Columns(0).HeaderCell.Value = "Item Id"
            .Columns(1).HeaderCell.Value = "Item Name"
            .Columns(2).HeaderCell.Value = "Quantity In Stock"
            .Columns(3).HeaderCell.Value = "Reorder Level"
        End With
        con.Close()
    End Sub

    Private Sub Refresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Refresh.Click
        con.Open()
        cmd.Connection = con
        adp.SelectCommand = cmd
        cmd.CommandText = "SELECT Sales_item_details.Sales_item_id, Sales_item_details.Item_name, Sales_item_details.Item_remaining, Sales_item_details.Re_order_level FROM Sales_item_details"
        ds.Clear()
        adp.Fill(ds, "Item")
        GridItem.DataSource = ds.Tables("Item")
        With GridItem
            .RowHeadersVisible = False
            .Columns(0).HeaderCell.Value = "Item Id"
            .Columns(1).HeaderCell.Value = "Item Name"
            .Columns(2).HeaderCell.Value = "Quantity In Stock"
            .Columns(3).HeaderCell.Value = "Reorder Level"
        End With
        con.Close()
    End Sub

    Private Sub SearchOrd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SearchOrd.Click
        If Search.Text = "" Then
            eror.Visible = True
            eror.Text = "Please Enter Item ID or Item Name"
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
                    cmd3.CommandText = "SELECT Sales_item_details.Sales_item_id, Sales_item_details.Item_name, Sales_item_details.Item_remaining, Sales_item_details.Re_order_level FROM Sales_item_details where Sales_item_id=" & Search.Text
                    ds3.Clear()
                    adp3.Fill(ds3, "Item")
                    If ds3.Tables("Item").Rows.Count > 0 Then
                        eror.Visible = False
                        While i < ds3.Tables("Item").Rows.Count
                            GridItem.DataSource = ds3.Tables("Item")
                            With GridItem
                                .RowHeadersVisible = False
                                .Columns(0).HeaderCell.Value = "Item Id"
                                .Columns(1).HeaderCell.Value = "Item Name"
                                .Columns(2).HeaderCell.Value = "Quantity In Stock"
                                .Columns(3).HeaderCell.Value = "Reorder Level"
                            End With
                            i += 1
                        End While
                    Else
                        eror.Visible = True
                        eror.Text = "Item ID not found"
                        eror.ForeColor = Color.Red
                    End If
                    con.Close()
                Else
                    eror.Visible = True
                    eror.Text = "Please Specify Item Id"
                    eror.ForeColor = Color.Red
                End If


            ElseIf RdItem.Checked = True Then
                Dim regu_name As New Regex("^([a-z]?[A-Z])")
                If regu_name.IsMatch(Search.Text) = True Then
                    eror.Visible = False
                    Dim i As Integer = 0
                    con.Open()
                    cmd3.Connection = con
                    adp3.SelectCommand = cmd3
                    cmd3.CommandText = "SELECT Sales_item_details.Sales_item_id, Sales_item_details.Item_name, Sales_item_details.Item_remaining, Sales_item_details.Re_order_level FROM Sales_item_details where Sales_item_details.Item_name='" & Search.Text & "'"
                    ds3.Clear()
                    adp3.Fill(ds3, "Item")
                    If ds3.Tables("Item").Rows.Count > 0 Then
                        eror.Visible = False
                        While i < ds3.Tables("Item").Rows.Count
                            GridItem.DataSource = ds3.Tables("Item")
                            With GridItem
                                .RowHeadersVisible = False
                                .Columns(0).HeaderCell.Value = "Item Id"
                                .Columns(1).HeaderCell.Value = "Item Name"
                                .Columns(2).HeaderCell.Value = "Quantity In Stock"
                                .Columns(3).HeaderCell.Value = "Reorder Level"
                            End With
                            i += 1
                        End While
                    Else
                        eror.Visible = True
                        eror.Text = "No Item of this Name"
                        eror.ForeColor = Color.Red
                    End If
                    con.Close()
                Else
                    eror.Visible = True
                    eror.Text = "Please Specify Item Name"
                    eror.ForeColor = Color.Red
                End If

            End If

        End If
    End Sub

    Private Sub BtnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnClose.Click
        Me.Close()
    End Sub
End Class