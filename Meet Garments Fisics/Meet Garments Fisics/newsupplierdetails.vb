Imports System.Data.OleDb
Imports System.Text.RegularExpressions
Public Class newsupplierdetails

    Private Sub newsupplierdetails_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.MdiParent = FisicsHome
        Dim idno As Integer
        con.Open()
        cmd.Connection = con
        cmd.CommandText = "SELECT MAX(Supplier_id) as ID from Supplier_details"
        If cmd.ExecuteScalar Is DBNull.Value Then
            idno = 1
        Else
            idno = cmd.ExecuteScalar() + 1
        End If
        con.Close()
        con.Open()
        cmd1.Connection = con
        adp1.SelectCommand = cmd1
        cmd1.CommandText = "SELECT * from City"
        adp1.Fill(ds2, "City")
        con.Close()
        SuppCityddl.DataSource = ds2.Tables("City")
        SuppCityddl.ValueMember = "City_id"
        SuppCityddl.DisplayMember = "City_name"
        
        SupID.Text = idno.ToString()
    End Sub

    Private Sub instSupplier_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles instSupplier.Click
        If SupName.Text = "" Then
            nameValidator.Text = "Please Enter Supplier Name"
            nameValidator.Visible = True
        ElseIf SupAddress.Text = "" Then
            addValidator.Text = "Please Enter Address"
            addValidator.Visible = True
        ElseIf SupPincode.Text = "" Then
            pincodeValidator.Text = "Please Enter Pincode"
            pincodeValidator.Visible = True
        ElseIf SupContact.Text = "" Or SupContact.TextLength <> 10 Then
            ContactValid.Text = "Please Enter Contact No"
            ContactValid.Visible = True
        Else
            con.Open()
            Dim cmd As New OleDbCommand("INSERT INTO Supplier_details VALUES('" & SupID.Text & "','" & SupName.Text & "','" & SupAddress.Text & "','" & SuppCityddl.SelectedValue.ToString & "','" & SupPincode.Text & "','" & SupContact.Text & "','" & SupEmail.Text & "','" & SupCST_no.Text & "')", con)
            cmd.ExecuteNonQuery()
            MsgBox("Inserted")
            con.Close()
            Me.Hide()
        End If
        

    End Sub

    Private Sub SupName_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SupName.TextChanged
        Dim regu_name As New Regex("^([A-Z]?[a-z])")
        If regu_name.IsMatch(SupName.Text) = True Then
            nameValidator.Visible = False
        Else
            nameValidator.Text = "Enter Characters"
            nameValidator.Visible = True
        End If
    End Sub

    Private Sub SupAddress_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SupAddress.TextChanged
        addValidator.Visible = False
    End Sub

    Private Sub SupPincode_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SupPincode.TextChanged
        Dim regu_name As New Regex("^([0-9]{6}|[0-9]{3}\s[0-9]{3})")
        If regu_name.IsMatch(SupPincode.Text) Then
            pincodeValidator.Visible = False
        Else

            pincodeValidator.Text = "Enter Proper Pincode"
            pincodeValidator.Visible = True
        End If
    End Sub

    Private Sub SupContact_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SupContact.TextChanged
        Dim regu_name As New Regex("^([0-9]{10})")
        If regu_name.IsMatch(SupContact.Text) = True Then

            ContactValid.Visible = False
        Else
            ContactValid.Text = "Enter Proper Contact No"
            ContactValid.Visible = True


        End If

    End Sub
End Class