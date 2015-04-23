<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Changepassword
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.password = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.username = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.confirmpassword = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.err = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.loginbtn = New System.Windows.Forms.Button
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'password
        '
        Me.password.Location = New System.Drawing.Point(271, 125)
        Me.password.MaxLength = 12
        Me.password.Name = "password"
        Me.password.Size = New System.Drawing.Size(240, 20)
        Me.password.TabIndex = 7
        Me.password.UseSystemPasswordChar = True
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label2.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(126, 125)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(139, 18)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "New Password:*"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'username
        '
        Me.username.Enabled = False
        Me.username.Location = New System.Drawing.Point(271, 89)
        Me.username.Name = "username"
        Me.username.Size = New System.Drawing.Size(240, 20)
        Me.username.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(126, 89)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(139, 18)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "User Name:*"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Meet_Garments_Fisics.My.Resources.Resources.mailarray_logo
        Me.PictureBox1.Location = New System.Drawing.Point(12, 78)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(108, 117)
        Me.PictureBox1.TabIndex = 8
        Me.PictureBox1.TabStop = False
        '
        'confirmpassword
        '
        Me.confirmpassword.Location = New System.Drawing.Point(271, 160)
        Me.confirmpassword.MaxLength = 12
        Me.confirmpassword.Name = "confirmpassword"
        Me.confirmpassword.Size = New System.Drawing.Size(240, 20)
        Me.confirmpassword.TabIndex = 10
        Me.confirmpassword.UseSystemPasswordChar = True
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label3.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(126, 160)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(139, 18)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Confirm Password:*"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'err
        '
        Me.err.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.err.ForeColor = System.Drawing.Color.Red
        Me.err.Location = New System.Drawing.Point(148, 193)
        Me.err.Name = "err"
        Me.err.Size = New System.Drawing.Size(334, 23)
        Me.err.TabIndex = 11
        Me.err.Text = "Label4"
        Me.err.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.err.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("MS Reference Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label4.Location = New System.Drawing.Point(175, 39)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(193, 24)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Change Password"
        '
        'loginbtn
        '
        Me.loginbtn.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.loginbtn.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.loginbtn.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.loginbtn.Location = New System.Drawing.Point(208, 219)
        Me.loginbtn.Name = "loginbtn"
        Me.loginbtn.Size = New System.Drawing.Size(150, 32)
        Me.loginbtn.TabIndex = 13
        Me.loginbtn.Text = "Change Password"
        Me.loginbtn.UseVisualStyleBackColor = False
        '
        'Changepassword
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(543, 292)
        Me.Controls.Add(Me.loginbtn)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.err)
        Me.Controls.Add(Me.confirmpassword)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.password)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.username)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Changepassword"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Changepassword"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents password As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents username As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents confirmpassword As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents err As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents loginbtn As System.Windows.Forms.Button
End Class
