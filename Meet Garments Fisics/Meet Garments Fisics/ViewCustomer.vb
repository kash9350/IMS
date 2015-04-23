Imports System.Data.OleDb
Public Class ViewCustomer

    Private Sub ViewCustomer_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SDPdatabaseDataSet6.City' table. You can move, or remove it, as needed.
        Me.CityTableAdapter.Fill(Me.SDPdatabaseDataSet6.City)
        'TODO: This line of code loads data into the 'Supplier_city.City' table. You can move, or remove it, as needed.

        Try
            con.Open()
            Dim cmd As New OleDbCommand("SELECT Customer_details.Customer_id, Customer_details.Customer_name, Customer_details.Address, City.City_name, Customer_details.Pincode, Customer_details.Contact, Customer_details.Email, Customer_details.Cst_no FROM City INNER JOIN Customer_details ON City.City_id = Customer_details.City_id", con)
            Dim adp As New OleDbDataAdapter(cmd)
            Dim ds As New DataSet
            ds.Clear()
            adp.Fill(ds, "Customer_details")
            CstGridView.DataSource = ds.Tables("Customer_details")
            With CstGridView
                .RowHeadersVisible = False
                .Columns(0).HeaderCell.Value = "Customer Id"
                .Columns(1).HeaderCell.Value = "Customer Name"
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

    Private Sub Cls_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cls.Click
        Me.Close()
    End Sub

    Private Sub dltCst_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dltCst.Click, CstGridView.AllowUserToDeleteRowsChanged
        If MsgBox("Do You Want to Delete Customer Data?", MsgBoxStyle.YesNoCancel, "Meet Garments") = MsgBoxResult.Yes Then
            Dim i As Integer
            i = CstGridView.CurrentRow.Cells(0).Value
            con.Open()
            cmd1.Connection = con
            cmd1.CommandText = "DELETE FROM Customer_details where Customer_id=" & i
            adp1.DeleteCommand = cmd1
            cmd1.ExecuteNonQuery()
            cmd2.Connection = con
            cmd2.CommandText = "SELECT Customer_details.Customer_id, Customer_details.Customer_name, Customer_details.Address, City.City_name, Customer_details.Pincode, Customer_details.Contact, Customer_details.Email, Customer_details.Cst_no FROM City INNER JOIN Customer_details ON City.City_id = Customer_details.City_id"
            adp2.SelectCommand = cmd2
            ds2.Clear()
            adp2.Fill(ds2, "Customer_details")
            CstGridView.DataSource = ds2.Tables("Customer_details")
            With CstGridView
                .RowHeadersVisible = False
                .Columns(0).HeaderCell.Value = "Customer Id"
                .Columns(1).HeaderCell.Value = "Customer Name"
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

    Private Sub updtCst_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles updtCst.Click
        If MsgBox("Do You Want to Update Customer Data?", MsgBoxStyle.YesNoCancel, "Meet Garments") = MsgBoxResult.Yes Then
            UpdateCustomer.CstID.Text = CstGridView.CurrentRow.Cells(0).Value
            UpdateCustomer.CstName.Text = CstGridView.CurrentRow.Cells(1).Value
            UpdateCustomer.CstAddress.Text = CstGridView.CurrentRow.Cells(2).Value
            'updateCustomer.cstCityddl.Text = CstGridView.CurrentRow.Cells(3).Value
            UpdateCustomer.CstPincode.Text = CstGridView.CurrentRow.Cells(4).Value
            UpdateCustomer.CstContact.Text = CstGridView.CurrentRow.Cells(5).Value
            UpdateCustomer.CstEmail.Text = CstGridView.CurrentRow.Cells(6).Value
            UpdateCustomer.CSTNo.Text = CstGridView.CurrentRow.Cells(7).Value
            Me.Close()
            UpdateCustomer.Show()
        End If
    End Sub

    Private Sub searchbtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles searchbtn.Click
       
        If (NameCheck.Checked = True) Then
            If searchTxtbox.Text = "" Then
                MessageBox.Show("Please Enter the Customer name")
            Else
                Dim i As Integer = 0
                con.Open()
                cmd3.Connection = con
                adp3.SelectCommand = cmd3
                cmd3.CommandText = "SELECT Customer_details.Customer_id, Customer_details.Customer_name, Customer_details.Address, City.City_name, Customer_details.Pincode, Customer_details.Contact, Customer_details.Email, Customer_details.Cst_no FROM City INNER JOIN Customer_details ON City.City_id = Customer_details.City_id where Customer_details.Customer_name='" & searchTxtbox.Text & "'"
                ds3.Clear()
                adp3.Fill(ds3, "Customer_details")
                If ds3.Tables("Customer_details").Rows.Count > 0 Then
                    eror2.Visible = False
                    While i < ds3.Tables("Customer_details").Rows.Count
                        CstGridView.DataSource = ds3.Tables("Customer_details")
                        With CstGridView
                            .RowHeadersVisible = False
                            .Columns(0).HeaderCell.Value = "Customer Id"
                            .Columns(1).HeaderCell.Value = "Customer Name"
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
                    eror2.Visible = True
                    eror2.Text = "No Customer found"
                    eror2.ForeColor = Color.Red

                End If
                con.Close()
            End If
        ElseIf (NameCheck.Checked = True And CityCheck.Checked = True) Then
            Dim i As Integer = 0
            con.Open()
            cmd4.Connection = con
            adp4.SelectCommand = cmd4
            cmd4.CommandText = "SELECT Customer_details.Customer_id, Customer_details.Customer_name, Customer_details.Address, City.City_name, Customer_details.Pincode, Customer_details.Contact, Customer_details.Email, Customer_details.Cst_no FROM City INNER JOIN Customer_details ON City.City_id = Customer_details.City_id where Customer_details.Customer_name='" & searchTxtbox.Text & "' and Customer_details.City_id='" & CityDdl.SelectedValue & "'"
            ds4.Clear()
            adp4.Fill(ds4, "Customer_details")
            If ds4.Tables("Customer_details").Rows.Count > 0 Then
                eror2.Visible = False
                While i < ds4.Tables("Customer_details").Rows.Count
                    CstGridView.DataSource = ds4.Tables("Customer_details")
                    With CstGridView
                        .RowHeadersVisible = False
                        .Columns(0).HeaderCell.Value = "Customer Id"
                        .Columns(1).HeaderCell.Value = "Customer Name"
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
                eror2.Visible = True
                eror2.Text = "No Customer found"
                eror2.ForeColor = Color.Red
            End If
            con.Close()
        ElseIf (CityCheck.Checked = True) Then
            Dim i As Integer = 0
            Dim city_id As Integer = CityDdl.SelectedValue
            'MsgBox(CityDDL.SelectedValue)
            con.Open()
            cmd2.Connection = con
            adp2.SelectCommand = cmd2
            cmd2.CommandText = "SELECT Customer_details.Customer_id, Customer_details.Customer_name, Customer_details.Address, City.City_name, Customer_details.Pincode, Customer_details.Contact, Customer_details.Email, Customer_details.Cst_no FROM City INNER JOIN Customer_details ON City.City_id = Customer_details.City_id where Customer_details.City_id=" & city_id
            ds2.Clear()
            adp2.Fill(ds2, "Customer_details")
            If ds2.Tables("Customer_details").Rows.Count > 0 Then
                eror2.Visible = False
                While i < ds2.Tables("Customer_details").Rows.Count
                    CstGridView.DataSource = ds2.Tables("Customer_details")
                    With CstGridView
                        .RowHeadersVisible = False
                        .Columns(0).HeaderCell.Value = "Customer Id"
                        .Columns(1).HeaderCell.Value = "Customer Name"
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
                eror2.Visible = True
                eror2.Text = "No Customer found"
                eror2.ForeColor = Color.Red
            End If
            con.Close()
        End If
    End Sub

    Private Sub NameCheck_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NameCheck.CheckedChanged
        If (NameCheck.Checked = True) Then
            searchTxtbox.Enabled = True
        Else
            searchTxtbox.Enabled = False
        End If
    End Sub

    Private Sub CityCheck_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CityCheck.CheckedChanged
        If (CityCheck.Checked = True) Then
            CityDdl.Enabled = True
        Else
            CityDdl.Enabled = False
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        eror2.Visible = False
        con.Open()
        Dim cmd As New OleDbCommand("SELECT Customer_details.Customer_id, Customer_details.Customer_name, Customer_details.Address, City.City_name, Customer_details.Pincode, Customer_details.Contact, Customer_details.Email, Customer_details.Cst_no FROM City INNER JOIN Customer_details ON City.City_id = Customer_details.City_id", con)
        Dim adp As New OleDbDataAdapter(cmd)
        Dim ds As New DataSet
        ds.Clear()
        adp.Fill(ds, "Customer_details")
        CstGridView.DataSource = ds.Tables("Customer_details")
        With CstGridView
            .RowHeadersVisible = False
            .Columns(0).HeaderCell.Value = "Customer Id"
            .Columns(1).HeaderCell.Value = "Customer Name"
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