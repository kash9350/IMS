<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class salesitem
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
        Me.Label1 = New System.Windows.Forms.Label
        Me.sale_item_id = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.sales_item_name = New System.Windows.Forms.TextBox
        Me.sale_item_qty = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button
        Me.Re_or_level = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.InameValid = New System.Windows.Forms.Label
        Me.QtyValid = New System.Windows.Forms.Label
        Me.ReOrderValid = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(35, 46)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(108, 18)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Item Id:*"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'sale_item_id
        '
        Me.sale_item_id.Enabled = False
        Me.sale_item_id.Location = New System.Drawing.Point(149, 44)
        Me.sale_item_id.Name = "sale_item_id"
        Me.sale_item_id.Size = New System.Drawing.Size(179, 20)
        Me.sale_item_id.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label2.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(35, 76)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(108, 18)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Item Name:*"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'sales_item_name
        '
        Me.sales_item_name.Location = New System.Drawing.Point(149, 74)
        Me.sales_item_name.Name = "sales_item_name"
        Me.sales_item_name.Size = New System.Drawing.Size(179, 20)
        Me.sales_item_name.TabIndex = 2
        '
        'sale_item_qty
        '
        Me.sale_item_qty.Location = New System.Drawing.Point(149, 107)
        Me.sale_item_qty.Name = "sale_item_qty"
        Me.sale_item_qty.Size = New System.Drawing.Size(179, 20)
        Me.sale_item_qty.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label4.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(35, 109)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(108, 18)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Item Qty:*"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(159, 165)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 29)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Add"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Re_or_level
        '
        Me.Re_or_level.Location = New System.Drawing.Point(149, 137)
        Me.Re_or_level.Name = "Re_or_level"
        Me.Re_or_level.Size = New System.Drawing.Size(179, 20)
        Me.Re_or_level.TabIndex = 9
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label3.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(35, 139)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(108, 18)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Re-Order Level:*"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'InameValid
        '
        Me.InameValid.AutoSize = True
        Me.InameValid.ForeColor = System.Drawing.Color.Red
        Me.InameValid.Location = New System.Drawing.Point(334, 78)
        Me.InameValid.Name = "InameValid"
        Me.InameValid.Size = New System.Drawing.Size(39, 13)
        Me.InameValid.TabIndex = 11
        Me.InameValid.Text = "Label5"
        Me.InameValid.Visible = False
        '
        'QtyValid
        '
        Me.QtyValid.AutoSize = True
        Me.QtyValid.ForeColor = System.Drawing.Color.Red
        Me.QtyValid.Location = New System.Drawing.Point(334, 110)
        Me.QtyValid.Name = "QtyValid"
        Me.QtyValid.Size = New System.Drawing.Size(39, 13)
        Me.QtyValid.TabIndex = 12
        Me.QtyValid.Text = "Label5"
        Me.QtyValid.Visible = False
        '
        'ReOrderValid
        '
        Me.ReOrderValid.AutoSize = True
        Me.ReOrderValid.ForeColor = System.Drawing.Color.Red
        Me.ReOrderValid.Location = New System.Drawing.Point(334, 141)
        Me.ReOrderValid.Name = "ReOrderValid"
        Me.ReOrderValid.Size = New System.Drawing.Size(39, 13)
        Me.ReOrderValid.TabIndex = 13
        Me.ReOrderValid.Text = "Label5"
        Me.ReOrderValid.Visible = False
        '
        'salesitem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(474, 215)
        Me.Controls.Add(Me.ReOrderValid)
        Me.Controls.Add(Me.QtyValid)
        Me.Controls.Add(Me.InameValid)
        Me.Controls.Add(Me.Re_or_level)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.sale_item_qty)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.sales_item_name)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.sale_item_id)
        Me.Controls.Add(Me.Label1)
        Me.MaximizeBox = False
        Me.Name = "salesitem"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Add Item"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents sale_item_id As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents sales_item_name As System.Windows.Forms.TextBox
    Friend WithEvents sale_item_qty As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Re_or_level As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents InameValid As System.Windows.Forms.Label
    Friend WithEvents QtyValid As System.Windows.Forms.Label
    Friend WithEvents ReOrderValid As System.Windows.Forms.Label
End Class
