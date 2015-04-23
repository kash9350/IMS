<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Purchase_item_add
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
        Me.QtyValid = New System.Windows.Forms.Label
        Me.InameValid = New System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button
        Me.pur_item_qty = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.pur_item_name = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.pur_item_id = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'QtyValid
        '
        Me.QtyValid.AutoSize = True
        Me.QtyValid.ForeColor = System.Drawing.Color.Red
        Me.QtyValid.Location = New System.Drawing.Point(339, 103)
        Me.QtyValid.Name = "QtyValid"
        Me.QtyValid.Size = New System.Drawing.Size(39, 13)
        Me.QtyValid.TabIndex = 24
        Me.QtyValid.Text = "Label5"
        Me.QtyValid.Visible = False
        '
        'InameValid
        '
        Me.InameValid.AutoSize = True
        Me.InameValid.ForeColor = System.Drawing.Color.Red
        Me.InameValid.Location = New System.Drawing.Point(339, 71)
        Me.InameValid.Name = "InameValid"
        Me.InameValid.Size = New System.Drawing.Size(39, 13)
        Me.InameValid.TabIndex = 23
        Me.InameValid.Text = "Label5"
        Me.InameValid.Visible = False
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(163, 142)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 29)
        Me.Button1.TabIndex = 18
        Me.Button1.Text = "Add"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'pur_item_qty
        '
        Me.pur_item_qty.Location = New System.Drawing.Point(154, 100)
        Me.pur_item_qty.Name = "pur_item_qty"
        Me.pur_item_qty.Size = New System.Drawing.Size(179, 20)
        Me.pur_item_qty.TabIndex = 17
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label4.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(40, 102)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(108, 18)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "Item Qty:*"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'pur_item_name
        '
        Me.pur_item_name.Location = New System.Drawing.Point(154, 67)
        Me.pur_item_name.Name = "pur_item_name"
        Me.pur_item_name.Size = New System.Drawing.Size(179, 20)
        Me.pur_item_name.TabIndex = 16
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label2.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(40, 69)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(108, 18)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "Item Name:*"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'pur_item_id
        '
        Me.pur_item_id.Enabled = False
        Me.pur_item_id.Location = New System.Drawing.Point(154, 37)
        Me.pur_item_id.Name = "pur_item_id"
        Me.pur_item_id.Size = New System.Drawing.Size(179, 20)
        Me.pur_item_id.TabIndex = 15
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(40, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(108, 18)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Item Id:*"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Purchase_item_add
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(474, 215)
        Me.Controls.Add(Me.QtyValid)
        Me.Controls.Add(Me.InameValid)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.pur_item_qty)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.pur_item_name)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.pur_item_id)
        Me.Controls.Add(Me.Label1)
        Me.MaximizeBox = False
        Me.Name = "Purchase_item_add"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Add New purchase Item"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents QtyValid As System.Windows.Forms.Label
    Friend WithEvents InameValid As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents pur_item_qty As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents pur_item_name As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents pur_item_id As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
