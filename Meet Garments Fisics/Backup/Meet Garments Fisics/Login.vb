Public Class Login


    Private Sub loginbtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles loginbtn.Click, loginbtn.Enter
        If username.Text = "" Or password.Text = "" Then
            err.Visible = True
            err.Text = "Username Or Password are not Entered."
        Else
            con.Open()
            cmd.Connection = con
            adp.SelectCommand = cmd
            cmd.CommandText = "SELECT * from Login"
            ds.Clear()
            adp.Fill(ds, "Login")
            Dim cnt As New Integer
            cnt = 0
            While cnt < ds.Tables("Login").Rows.Count

                If String.Compare(ds.Tables("Login").Rows(cnt)(0).ToString, username.Text) = 0 And String.Compare(ds.Tables("Login").Rows(cnt)(1).ToString, password.Text) = 0 Then
                    MsgBox(String.Concat("Welcome ", username.Text))
                    Me.Close()
                    FisicsHome.HmLoginBtn.Visible = False
                    FisicsHome.MenuStrip1.Enabled = True
                Else
                    err.Visible = True
                    err.Text = "Invalid Username or Password"
                End If
                cnt += 1
            End While
            con.Close()
        End If
    End Sub

    Private Sub Login_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        FisicsHome.MenuStrip1.Enabled = False
        Me.MdiParent = FisicsHome
    End Sub
End Class