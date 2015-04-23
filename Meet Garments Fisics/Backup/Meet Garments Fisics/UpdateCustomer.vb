Public Class UpdateCustomer

    Private Sub UpdateCustomer_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        con.Open()
        cmd1.Connection = con
        adp1.SelectCommand = cmd1
        cmd1.CommandText = "SELECT * from City"
        ds2.Clear()
        adp1.Fill(ds2, "City")
        con.Close()
        cstCityddl.DataSource = ds2.Tables("City")
        cstCityddl.ValueMember = "City_id"
        cstCityddl.DisplayMember = "City_name"
        Me.MdiParent = FisicsHome
    End Sub

    Private Sub updateCst_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles updateCst.Click
        con.Open()
        cmd2.Connection = con
        cmd2.CommandText = "UPDATE Customer_details SET Customer_name='" & CstName.Text & "', Address='" & CstAddress.Text & "', City_id='" & cstCityddl.SelectedValue & "', Pincode='" & CstPincode.Text & "', Contact='" & CstContact.Text & "', Email='" & CstEmail.Text & "', Cst_no='" & CSTNo.Text & "' Where Customer_id=" & CstID.Text
        cmd2.ExecuteNonQuery()
        MsgBox("Record Updated successfully")
        con.Close()
        Me.Close()
        ViewCustomer.Show()
    End Sub
End Class