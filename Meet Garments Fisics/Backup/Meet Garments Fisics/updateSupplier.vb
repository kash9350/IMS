Public Class updateSupplier

    Private Sub updateSupplier_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        con.Open()
        cmd1.Connection = con
        adp1.SelectCommand = cmd1
        cmd1.CommandText = "SELECT * from City"
        adp1.Fill(ds2, "City")
        con.Close()
        SuppCityddl.DataSource = ds2.Tables("City")
        SuppCityddl.ValueMember = "City_id"
        SuppCityddl.DisplayMember = "City_name"
        Me.MdiParent = FisicsHome
    End Sub

    Private Sub updateSup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles updateSup.Click
        con.Open()
        cmd2.Connection = con
        cmd2.CommandText = "UPDATE Supplier_details SET Supplier_name='" & SupName.Text & "', Address='" & SupAddress.Text & "', City_id='" & SuppCityddl.SelectedValue & "', Pincode='" & SupPincode.Text & "', Contact='" & SupContact.Text & "', Email='" & SupEmail.Text & "', Cst_no='" & SupCST_no.Text & "' Where Supplier_id=" & SupID.Text
        cmd2.ExecuteNonQuery()
        MsgBox("Record Updated successfully")
        con.Close()
        Me.Close()
        ViewSupplier.Show()
    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label5.Click

    End Sub

    Private Sub Label6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label6.Click

    End Sub

    Private Sub Label7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label7.Click

    End Sub

    Private Sub SupName_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SupName.TextChanged

    End Sub

    Private Sub SupAddress_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SupAddress.TextChanged

    End Sub

    Private Sub SupContact_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SupContact.TextChanged

    End Sub

    Private Sub SupEmail_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SupEmail.TextChanged

    End Sub

    Private Sub SupCST_no_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SupCST_no.TextChanged

    End Sub

    Private Sub SupID_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SupID.TextChanged

    End Sub

    Private Sub Label9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label9.Click

    End Sub

    Private Sub SupPincode_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SupPincode.TextChanged

    End Sub

    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label4.Click

    End Sub

    Private Sub SuppCityddl_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SuppCityddl.SelectedIndexChanged

    End Sub

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.Click

    End Sub
End Class