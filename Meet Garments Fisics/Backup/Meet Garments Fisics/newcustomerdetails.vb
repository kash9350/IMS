Imports System.Data
Imports System.Data.OleDb
Imports System.Text.RegularExpressions
Public Class newcustomerdetails

    Private Sub newcustomerdetails_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim idno As Integer
        Dim cmd As OleDbCommand
        'Try
        con.Open()
        cmd = New OleDbCommand("SELECT MAX(Customer_id) as ID from Customer_details", con)
        If cmd.ExecuteScalar Is DBNull.Value Then
            idno = 1
        Else
            idno = cmd.ExecuteScalar() + 1
        End If
        CstID.Text = idno.ToString()
        'fill combobox city
        cmd1.Connection = con
        adp1.SelectCommand = cmd1
        cmd1.CommandText = "SELECT * from City"
        adp1.Fill(ds2, "City")
        con.Close()
        cstCityddl.DataSource = ds2.Tables("City")
        cstCityddl.ValueMember = "City_id"
        cstCityddl.DisplayMember = "City_name"
        'Catch ex As Exception
        'MessageBox.Show(ex.Message)
        'End Try
        'If idno Is DBNull.Value Then
        '    idno = 1
        'Else
        '    idno = idno + 1
        'End If
        Me.MdiParent = FisicsHome
    End Sub

    Private Sub instCustomer_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles instCustomer.Click
        If CstName.Text = "" Then
            nameValidator.Text = "Please Enter Customer Name"
            nameValidator.Visible = True
        ElseIf CstAddress.Text = "" Then
            addValidator.Text = "Please Enter Address"
            addValidator.Visible = True
        ElseIf CstPincode.Text = "" Then
            pincodeValidator.Text = "Please Enter Pincode"
            pincodeValidator.Visible = True
        ElseIf CstContact.Text = "" Then
            ContactValid.Text = "Please Enter Contact No"
            ContactValid.Visible = True
        Else
            con.Open()
            cmd2.Connection = con
            cmd2.CommandText = "INSERT INTO Customer_details VALUES('" & CstID.Text & "','" & CstName.Text & "','" & CstAddress.Text & "','" & cstCityddl.SelectedValue.ToString & "','" & CstPincode.Text & "','" & CstContact.Text & "','" & CstEmail.Text & "','" & CSTNo.Text & "')"
            cmd2.ExecuteNonQuery()
            MsgBox("Inserted")
            con.Close()
            Me.Close()
        End If
       
    End Sub

    Private Sub CstName_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CstName.TextChanged
        Dim regu_name As New Regex("^([A-Z]?[a-z])")
        If regu_name.IsMatch(CstName.Text) = True Then
            nameValidator.Visible = False
        Else
            nameValidator.Text = "Enter Characters"
            nameValidator.Visible = True
        End If

    End Sub

    Private Sub CstAddress_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CstAddress.TextChanged
        

        addValidator.Visible = False

    End Sub

    Private Sub CstPincode_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CstPincode.TextChanged
        Dim regu_name As New Regex("^([0-9]{6}|[0-9]{3}\s[0-9]{3})")
        If regu_name.IsMatch(CstPincode.Text) Then
            pincodeValidator.Visible = False
        Else

            pincodeValidator.Text = "Enter Proper Pincode"
            pincodeValidator.Visible = True
        End If

    End Sub

    Private Sub CstContact_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CstContact.TextChanged
        Dim regu_name As New Regex("^([0-9]{10})")
        If regu_name.IsMatch(CstContact.Text) = True Then
            
            ContactValid.Visible = False
        Else
            ContactValid.Text = "Enter Proper Contact No"
            ContactValid.Visible = True

        End If

    End Sub
End Class