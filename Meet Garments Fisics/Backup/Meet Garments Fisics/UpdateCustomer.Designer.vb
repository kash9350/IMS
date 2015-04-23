<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UpdateCustomer
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.updateCst = New System.Windows.Forms.Button
        Me.cstCityddl = New System.Windows.Forms.ComboBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.CstID = New System.Windows.Forms.TextBox
        Me.CSTNo = New System.Windows.Forms.TextBox
        Me.CstEmail = New System.Windows.Forms.TextBox
        Me.CstContact = New System.Windows.Forms.TextBox
        Me.CstPincode = New System.Windows.Forms.TextBox
        Me.CstAddress = New System.Windows.Forms.TextBox
        Me.CstName = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GroupBox1.Controls.Add(Me.updateCst)
        Me.GroupBox1.Controls.Add(Me.cstCityddl)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.CstID)
        Me.GroupBox1.Controls.Add(Me.CSTNo)
        Me.GroupBox1.Controls.Add(Me.CstEmail)
        Me.GroupBox1.Controls.Add(Me.CstContact)
        Me.GroupBox1.Controls.Add(Me.CstPincode)
        Me.GroupBox1.Controls.Add(Me.CstAddress)
        Me.GroupBox1.Controls.Add(Me.CstName)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(517, 349)
        Me.GroupBox1.TabIndex = 36
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Update Customer Details"
        '
        'updateCst
        '
        Me.updateCst.Location = New System.Drawing.Point(213, 307)
        Me.updateCst.Name = "updateCst"
        Me.updateCst.Size = New System.Drawing.Size(106, 30)
        Me.updateCst.TabIndex = 52
        Me.updateCst.Text = "Update"
        Me.updateCst.UseVisualStyleBackColor = True
        '
        'cstCityddl
        '
        Me.cstCityddl.FormattingEnabled = True
        Me.cstCityddl.Location = New System.Drawing.Point(200, 147)
        Me.cstCityddl.Name = "cstCityddl"
        Me.cstCityddl.Size = New System.Drawing.Size(240, 22)
        Me.cstCityddl.TabIndex = 51
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(85, 17)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(109, 20)
        Me.Label9.TabIndex = 50
        Me.Label9.Text = "Customer Id:"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'CstID
        '
        Me.CstID.Enabled = False
        Me.CstID.Location = New System.Drawing.Point(200, 16)
        Me.CstID.Name = "CstID"
        Me.CstID.Size = New System.Drawing.Size(240, 21)
        Me.CstID.TabIndex = 49
        '
        'CSTNo
        '
        Me.CSTNo.Location = New System.Drawing.Point(200, 280)
        Me.CSTNo.Name = "CSTNo"
        Me.CSTNo.Size = New System.Drawing.Size(240, 21)
        Me.CSTNo.TabIndex = 40
        Me.CSTNo.Text = "0"
        '
        'CstEmail
        '
        Me.CstEmail.Location = New System.Drawing.Point(200, 247)
        Me.CstEmail.Name = "CstEmail"
        Me.CstEmail.Size = New System.Drawing.Size(240, 21)
        Me.CstEmail.TabIndex = 39
        '
        'CstContact
        '
        Me.CstContact.Location = New System.Drawing.Point(200, 214)
        Me.CstContact.Name = "CstContact"
        Me.CstContact.Size = New System.Drawing.Size(240, 21)
        Me.CstContact.TabIndex = 38
        '
        'CstPincode
        '
        Me.CstPincode.Location = New System.Drawing.Point(200, 181)
        Me.CstPincode.Name = "CstPincode"
        Me.CstPincode.Size = New System.Drawing.Size(240, 21)
        Me.CstPincode.TabIndex = 37
        '
        'CstAddress
        '
        Me.CstAddress.Location = New System.Drawing.Point(200, 82)
        Me.CstAddress.Multiline = True
        Me.CstAddress.Name = "CstAddress"
        Me.CstAddress.Size = New System.Drawing.Size(240, 59)
        Me.CstAddress.TabIndex = 36
        '
        'CstName
        '
        Me.CstName.Location = New System.Drawing.Point(200, 49)
        Me.CstName.Name = "CstName"
        Me.CstName.Size = New System.Drawing.Size(240, 21)
        Me.CstName.TabIndex = 35
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(85, 280)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(109, 20)
        Me.Label7.TabIndex = 48
        Me.Label7.Text = "CST No:"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(85, 247)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(109, 20)
        Me.Label6.TabIndex = 47
        Me.Label6.Text = "Email:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(85, 214)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(109, 20)
        Me.Label5.TabIndex = 46
        Me.Label5.Text = "Contact No:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(85, 181)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(109, 20)
        Me.Label4.TabIndex = 45
        Me.Label4.Text = "Pincode:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(85, 148)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(109, 20)
        Me.Label3.TabIndex = 44
        Me.Label3.Text = "City:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(85, 83)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(109, 20)
        Me.Label2.TabIndex = 43
        Me.Label2.Text = "Address:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(85, 50)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(109, 20)
        Me.Label1.TabIndex = 42
        Me.Label1.Text = "Customer Name:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'UpdateCustomer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(541, 373)
        Me.Controls.Add(Me.GroupBox1)
        Me.MaximizeBox = False
        Me.Name = "UpdateCustomer"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "UpdateCustomer"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cstCityddl As System.Windows.Forms.ComboBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents CstID As System.Windows.Forms.TextBox
    Friend WithEvents CSTNo As System.Windows.Forms.TextBox
    Friend WithEvents CstEmail As System.Windows.Forms.TextBox
    Friend WithEvents CstContact As System.Windows.Forms.TextBox
    Friend WithEvents CstPincode As System.Windows.Forms.TextBox
    Friend WithEvents CstAddress As System.Windows.Forms.TextBox
    Friend WithEvents CstName As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents updateCst As System.Windows.Forms.Button
End Class
