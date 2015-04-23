<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ChngeOrderStat
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
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.CstName = New System.Windows.Forms.Label
        Me.ordDate = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.pending = New System.Windows.Forms.RadioButton
        Me.Dispatch = New System.Windows.Forms.RadioButton
        Me.updt = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.OrderId = New System.Windows.Forms.Label
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label3.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(51, 93)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(128, 20)
        Me.Label3.TabIndex = 29
        Me.Label3.Text = "Date:*"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label2.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(51, 60)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(128, 20)
        Me.Label2.TabIndex = 28
        Me.Label2.Text = "Customer Name:*"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(51, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(128, 20)
        Me.Label1.TabIndex = 26
        Me.Label1.Text = "Sales Order Id:*"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'CstName
        '
        Me.CstName.AutoSize = True
        Me.CstName.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CstName.Location = New System.Drawing.Point(185, 63)
        Me.CstName.Name = "CstName"
        Me.CstName.Size = New System.Drawing.Size(51, 15)
        Me.CstName.TabIndex = 31
        Me.CstName.Text = "Label5"
        '
        'ordDate
        '
        Me.ordDate.AutoSize = True
        Me.ordDate.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ordDate.Location = New System.Drawing.Point(185, 96)
        Me.ordDate.Name = "ordDate"
        Me.ordDate.Size = New System.Drawing.Size(51, 15)
        Me.ordDate.TabIndex = 32
        Me.ordDate.Text = "Label6"
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label4.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(51, 127)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(128, 20)
        Me.Label4.TabIndex = 33
        Me.Label4.Text = "Status:*"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Dispatch)
        Me.GroupBox1.Controls.Add(Me.pending)
        Me.GroupBox1.Location = New System.Drawing.Point(188, 114)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(119, 62)
        Me.GroupBox1.TabIndex = 34
        Me.GroupBox1.TabStop = False
        '
        'pending
        '
        Me.pending.AutoSize = True
        Me.pending.Checked = True
        Me.pending.Location = New System.Drawing.Point(6, 13)
        Me.pending.Name = "pending"
        Me.pending.Size = New System.Drawing.Size(64, 17)
        Me.pending.TabIndex = 0
        Me.pending.TabStop = True
        Me.pending.Text = "Pending"
        Me.pending.UseVisualStyleBackColor = True
        '
        'Dispatch
        '
        Me.Dispatch.AutoSize = True
        Me.Dispatch.Location = New System.Drawing.Point(6, 36)
        Me.Dispatch.Name = "Dispatch"
        Me.Dispatch.Size = New System.Drawing.Size(79, 17)
        Me.Dispatch.TabIndex = 1
        Me.Dispatch.Text = "Dispatched"
        Me.Dispatch.UseVisualStyleBackColor = True
        '
        'updt
        '
        Me.updt.Location = New System.Drawing.Point(143, 193)
        Me.updt.Name = "updt"
        Me.updt.Size = New System.Drawing.Size(75, 23)
        Me.updt.TabIndex = 35
        Me.updt.Text = "Update"
        Me.updt.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(224, 193)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 36
        Me.Button2.Text = "Cancel"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'OrderId
        '
        Me.OrderId.AutoSize = True
        Me.OrderId.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OrderId.Location = New System.Drawing.Point(185, 30)
        Me.OrderId.Name = "OrderId"
        Me.OrderId.Size = New System.Drawing.Size(51, 15)
        Me.OrderId.TabIndex = 30
        Me.OrderId.Text = "Label4"
        '
        'ChngeOrderStat
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(443, 252)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.updt)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.ordDate)
        Me.Controls.Add(Me.CstName)
        Me.Controls.Add(Me.OrderId)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.MaximizeBox = False
        Me.Name = "ChngeOrderStat"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Order Ready"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents CstName As System.Windows.Forms.Label
    Friend WithEvents ordDate As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Dispatch As System.Windows.Forms.RadioButton
    Friend WithEvents pending As System.Windows.Forms.RadioButton
    Friend WithEvents updt As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents OrderId As System.Windows.Forms.Label
End Class
