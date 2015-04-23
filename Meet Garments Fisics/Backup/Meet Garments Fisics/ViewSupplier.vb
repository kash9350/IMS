Imports System.Data.OleDb
Public Class ViewSupplier

    Private Sub ViewSupplier_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Supplier_city.City' table. You can move, or remove it, as needed.
        Me.CityTableAdapter.Fill(Me.Supplier_city.City)
        
        Try
            con.Open()
            Dim cmd As New OleDbCommand("SELECT Supplier_details.Supplier_id, Supplier_details.Supplier_name, Supplier_details.Address, City.City_name, Supplier_details.Pincode, Supplier_details.Contact, Supplier_details.Email, Supplier_details.Cst_no FROM City INNER JOIN Supplier_details ON City.City_id = Supplier_details.City_id", con)
            Dim adp As New OleDbDataAdapter(cmd)
            Dim ds As New DataSet
            'Dim dr As DataRow
            ds3.Clear()
            adp.Fill(ds3, "Supplier_details")
            SupGridView.DataSource = ds3.Tables("Supplier_details")
            With SupGridView
                .RowHeadersVisible = False
                .Columns(0).HeaderCell.Value = "Supplier Id"
                .Columns(1).HeaderCell.Value = "Supplier Name"
                .Columns(2).HeaderCell.Value = "Address"
                .Columns(3).HeaderCell.Value = "City Name"
                .Columns(4).HeaderCell.Value = "Pincode"
                .Columns(5).HeaderCell.Value = "Contact"
                .Columns(6).HeaderCell.Value = "Email"
                .Columns(7).HeaderCell.Value = "Cst No"
            End With
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Me.MdiParent = FisicsHome
    End Sub

    Private Sub srchCst_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles srchCst.Click
        If (NameCheck.Checked = True) Then
            If searchTxtbox.Text = "" Then
                MessageBox.Show("Please Enter the Supplier name")
            Else
                Dim i As Integer = 0
                con.Open()
                cmd3.Connection = con
                adp3.SelectCommand = cmd3
                cmd3.CommandText = "SELECT Supplier_details.Supplier_id, Supplier_details.Supplier_name, Supplier_details.Address, City.City_name, Supplier_details.Pincode, Supplier_details.Contact, Supplier_details.Email, Supplier_details.Cst_no FROM City INNER JOIN Supplier_details ON City.City_id = Supplier_details.City_id where Supplier_details.Supplier_name='" & searchTxtbox.Text & "'"
                ds3.Clear()
                adp3.Fill(ds3, "Supplier_details")
                If ds3.Tables("Supplier_details").Rows.Count > 0 Then
                    eror.Visible = False
                    While i < ds3.Tables("Supplier_details").Rows.Count
                        SupGridView.DataSource = ds3.Tables("Supplier_details")
                        With SupGridView
                            .RowHeadersVisible = False
                            .Columns(0).HeaderCell.Value = "Supplier Id"
                            .Columns(1).HeaderCell.Value = "Supplier Name"
                            .Columns(2).HeaderCell.Value = "Address"
                            .Columns(3).HeaderCell.Value = "City Name"
                            .Columns(4).HeaderCell.Value = "Pincode"
                            .Columns(5).HeaderCell.Value = "Contact"
                            .Columns(6).HeaderCell.Value = "Email"
                            .Columns(7).HeaderCell.Value = "Cst No"
                        End With
                        i += 1
                    End While
                Else
                    eror.Visible = True
                    eror.Text = "No supplier found"
                    eror.ForeColor = Color.Red
                End If
                con.Close()
            End If

            
        ElseIf (NameCheck.Checked = True And CityCheck.Checked = True) Then
            Dim i As Integer = 0
            con.Open()
            cmd4.Connection = con
            adp4.SelectCommand = cmd4
            cmd4.CommandText = "SELECT Supplier_details.Supplier_id, Supplier_details.Supplier_name, Supplier_details.Address, City.City_name, Supplier_details.Pincode, Supplier_details.Contact, Supplier_details.Email, Supplier_details.Cst_no FROM City INNER JOIN Supplier_details ON City.City_id = Supplier_details.City_id where Supplier_details.Supplier_name=" & searchTxtbox.Text & "' and Supplier_details.City_id='" & CityDDL.SelectedValue & "'"
            ds4.Clear()
            adp4.Fill(ds4, "Supplier_details")
            If ds4.Tables("Supplier_details").Rows.Count > 0 Then
                eror.Visible = False
                While i < ds4.Tables("Supplier_details").Rows.Count
                    SupGridView.DataSource = ds4.Tables("Supplier_details")
                    With SupGridView
                        .RowHeadersVisible = False
                        .Columns(0).HeaderCell.Value = "Supplier Id"
                        .Columns(1).HeaderCell.Value = "Supplier Name"
                        .Columns(2).HeaderCell.Value = "Address"
                        .Columns(3).HeaderCell.Value = "City Name"
                        .Columns(4).HeaderCell.Value = "Pincode"
                        .Columns(5).HeaderCell.Value = "Contact"
                        .Columns(6).HeaderCell.Value = "Email"
                        .Columns(7).HeaderCell.Value = "Cst No"
                    End With
                    i += 1
                End While
            Else
                eror.Visible = True
                eror.Text = "No supplier found"
                eror.ForeColor = Color.Red
            End If
            con.Close()
        ElseIf (CityCheck.Checked = True) Then
            Dim i As Integer = 0
            Dim city_id As Integer = CityDDL.SelectedValue
            'MsgBox(CityDDL.SelectedValue)
            con.Open()
            cmd2.Connection = con
            adp2.SelectCommand = cmd2
            cmd2.CommandText = "SELECT Supplier_details.Supplier_id, Supplier_details.Supplier_name, Supplier_details.Address, City.City_name, Supplier_details.Pincode, Supplier_details.Contact, Supplier_details.Email, Supplier_details.Cst_no FROM City INNER JOIN Supplier_details ON City.City_id = Supplier_details.City_id where Supplier_details.City_id=" & city_id
            ds2.Clear()
            adp2.Fill(ds2, "Supplier_details")
            If ds2.Tables("Supplier_details").Rows.Count > 0 Then
                eror.Visible = False
                While i < ds2.Tables("Supplier_details").Rows.Count
                    SupGridView.DataSource = ds2.Tables("Supplier_details")
                    With SupGridView
                        .RowHeadersVisible = False
                        .Columns(0).HeaderCell.Value = "Supplier Id"
                        .Columns(1).HeaderCell.Value = "Supplier Name"
                        .Columns(2).HeaderCell.Value = "Address"
                        .Columns(3).HeaderCell.Value = "City Name"
                        .Columns(4).HeaderCell.Value = "Pincode"
                        .Columns(5).HeaderCell.Value = "Contact"
                        .Columns(6).HeaderCell.Value = "Email"
                        .Columns(7).HeaderCell.Value = "Cst No"
                    End With
                    i += 1
                End While
            Else
                eror.Visible = True
                eror.Text = "No supplier found"
                eror.ForeColor = Color.Red
            End If
            con.Close()
        End If

    End Sub

    Private Sub updtCst_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles updtCst.Click
        If MsgBox("Do You Want to Update Supplier Data?", MsgBoxStyle.YesNoCancel, "Meet Garments") = MsgBoxResult.Yes Then
            updateSupplier.SupID.Text = SupGridView.CurrentRow.Cells(0).Value
            updateSupplier.SupName.Text = SupGridView.CurrentRow.Cells(1).Value
            updateSupplier.SupAddress.Text = SupGridView.CurrentRow.Cells(2).Value
            'updateSupplier.SuppCityddl.Text = SupGridView.CurrentRow.Cells(3).Value
            updateSupplier.SupPincode.Text = SupGridView.CurrentRow.Cells(4).Value
            updateSupplier.SupContact.Text = SupGridView.CurrentRow.Cells(5).Value
            updateSupplier.SupEmail.Text = SupGridView.CurrentRow.Cells(6).Value
            updateSupplier.SupCST_no.Text = SupGridView.CurrentRow.Cells(7).Value
            Me.Close()
            updateSupplier.Show()
        End If
    End Sub

    Private Sub dltCst_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dltCst.Click
        If MsgBox("Do You Want to Delete Supplier Data?", MsgBoxStyle.YesNoCancel, "Meet Garments") = MsgBoxResult.Yes Then
            Dim i As Integer
            i = SupGridView.CurrentRow.Cells(0).Value()
            con.Open()
            cmd3.Connection = con
            cmd3.CommandText = "DELETE FROM Supplier_details where Supplier_id=" & i
            adp3.DeleteCommand = cmd3
            cmd3.ExecuteNonQuery()
            cmd4.Connection = con
            cmd4.CommandText = "SELECT Supplier_details.Supplier_id, Supplier_details.Supplier_name, Supplier_details.Address, City.City_name, Supplier_details.Pincode, Supplier_details.Contact, Supplier_details.Email, Supplier_details.Cst_no FROM City INNER JOIN Supplier_details ON City.City_id = Supplier_details.City_id"
            adp4.SelectCommand = cmd4
            ds3.Clear()
            adp4.Fill(ds3, "Supplier_details")
            SupGridView.DataSource = ds3.Tables("Supplier_details")
            With SupGridView
                .RowHeadersVisible = False
                .Columns(0).HeaderCell.Value = "Supplier Id"
                .Columns(1).HeaderCell.Value = "Supplier Name"
                .Columns(2).HeaderCell.Value = "Address"
                .Columns(3).HeaderCell.Value = "City Name"
                .Columns(4).HeaderCell.Value = "Pincode"
                .Columns(5).HeaderCell.Value = "Contact"
                .Columns(6).HeaderCell.Value = "Email"
                .Columns(7).HeaderCell.Value = "Cst No"
            End With
            con.Close()

        End If
    End Sub

    Private Sub Cls_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cls.Click
        Me.Close()
    End Sub

    Private Sub CityCheck_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CityCheck.CheckedChanged
        If (CityCheck.Checked = True) Then
            CityDDL.Enabled = True
        Else
            CityDDL.Enabled = False
        End If
    End Sub

    Private Sub NameCheck_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NameCheck.CheckedChanged
        If (NameCheck.Checked = True) Then
            searchTxtbox.Enabled = True
        Else
            searchTxtbox.Enabled = False
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        eror.Visible = False
        con.Open()
        Dim cmd As New OleDbCommand("SELECT Supplier_details.Supplier_id, Supplier_details.Supplier_name, Supplier_details.Address, City.City_name, Supplier_details.Pincode, Supplier_details.Contact, Supplier_details.Email, Supplier_details.Cst_no FROM City INNER JOIN Supplier_details ON City.City_id = Supplier_details.City_id", con)
        Dim adp As New OleDbDataAdapter(cmd)
        Dim ds As New DataSet
        'Dim dr As DataRow
        ds3.Clear()
        adp.Fill(ds3, "Supplier_details")
        SupGridView.DataSource = ds3.Tables("Supplier_details")
        With SupGridView
            .RowHeadersVisible = False
            .Columns(0).HeaderCell.Value = "Supplier Id"
            .Columns(1).HeaderCell.Value = "Supplier Name"
            .Columns(2).HeaderCell.Value = "Address"
            .Columns(3).HeaderCell.Value = "City Name"
            .Columns(4).HeaderCell.Value = "Pincode"
            .Columns(5).HeaderCell.Value = "Contact"
            .Columns(6).HeaderCell.Value = "Email"
            .Columns(7).HeaderCell.Value = "Cst No"
        End With
        con.Close()
    End Sub
End Class