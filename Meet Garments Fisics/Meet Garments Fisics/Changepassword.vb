Public Class Changepassword

    Private Sub loginbtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles loginbtn.Click
        If password.Text = "" Or confirmpassword.Text = "" Then
            err.Visible = True
            err.Text = "Password Or Confirm password are not Entered."
        Else
            If password.TextLength < 6 Or confirmpassword.TextLength < 6 Then
                err.Visible = True
                err.Text = "password should not be less than 6"
            Else
                If password.Text.Equals(confirmpassword.Text) Then
                    con.Open()
                    cmd1.Connection = con
                    adp1.UpdateCommand = cmd1
                    cmd1.CommandText = "UPDATE Login SET Login.[password] = '" & confirmpassword.Text & "' WHERE (((Login.username)='" & username.Text & "'))"
                    cmd1.ExecuteNonQuery()
                    con.Close()
                    MsgBox("Password Updated")
                    Me.Close()
                Else
                    err.Visible = True
                    err.Text = "Please retype the password"
                End If

            End If

        End If
    End Sub

    Private Sub Changepassword_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.MdiParent = FisicsHome
        con.Open()
        cmd.Connection = con
        adp.SelectCommand = cmd
        cmd.CommandText = "Select username from Login"
        Dim dt As New DataTable
        adp.Fill(dt)
        username.Text = dt.Rows(0)(0).ToString()
        con.Close()
    End Sub
End Class