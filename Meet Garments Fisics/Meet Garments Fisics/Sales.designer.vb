<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Sales
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.Button1 = New System.Windows.Forms.Button
        Me.Cust_name = New System.Windows.Forms.ComboBox
        Me.SalesBtn = New System.Windows.Forms.Button
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.totalamt = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.DataGridView2 = New System.Windows.Forms.DataGridView
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Sale_date = New System.Windows.Forms.DateTimePicker
        Me.Sales_id = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Order_id = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Csttxt = New System.Windows.Forms.TextBox
        Me.custId = New System.Windows.Forms.Label
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Qty = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Rate = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Amt = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Panel1.SuspendLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(405, 64)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(38, 21)
        Me.Button1.TabIndex = 20
        Me.Button1.Text = "Add"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Cust_name
        '
        Me.Cust_name.FormattingEnabled = True
        Me.Cust_name.Location = New System.Drawing.Point(159, 65)
        Me.Cust_name.Name = "Cust_name"
        Me.Cust_name.Size = New System.Drawing.Size(240, 21)
        Me.Cust_name.TabIndex = 19
        '
        'SalesBtn
        '
        Me.SalesBtn.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SalesBtn.Location = New System.Drawing.Point(25, 504)
        Me.SalesBtn.Name = "SalesBtn"
        Me.SalesBtn.Size = New System.Drawing.Size(117, 30)
        Me.SalesBtn.TabIndex = 18
        Me.SalesBtn.Text = "Sales"
        Me.SalesBtn.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.totalamt)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Location = New System.Drawing.Point(25, 457)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(667, 41)
        Me.Panel1.TabIndex = 17
        '
        'totalamt
        '
        Me.totalamt.Location = New System.Drawing.Point(504, 10)
        Me.totalamt.Name = "totalamt"
        Me.totalamt.Size = New System.Drawing.Size(160, 20)
        Me.totalamt.TabIndex = 1
        Me.totalamt.Text = "0"
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Label4.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(11, 10)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(487, 20)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Total:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'DataGridView2
        '
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Qty, Me.Rate, Me.Amt})
        Me.DataGridView2.GridColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.DataGridView2.Location = New System.Drawing.Point(25, 126)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.Size = New System.Drawing.Size(667, 323)
        Me.DataGridView2.TabIndex = 16
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label3.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(25, 95)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(128, 20)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Date:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label2.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(25, 65)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(128, 20)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Customer Name:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Sale_date
        '
        Me.Sale_date.Location = New System.Drawing.Point(159, 93)
        Me.Sale_date.Name = "Sale_date"
        Me.Sale_date.Size = New System.Drawing.Size(240, 20)
        Me.Sale_date.TabIndex = 13
        '
        'Sales_id
        '
        Me.Sales_id.Enabled = False
        Me.Sales_id.Location = New System.Drawing.Point(159, 12)
        Me.Sales_id.Name = "Sales_id"
        Me.Sales_id.Size = New System.Drawing.Size(240, 20)
        Me.Sales_id.TabIndex = 12
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(25, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(128, 20)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Sales Id:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Order_id
        '
        Me.Order_id.Enabled = False
        Me.Order_id.Location = New System.Drawing.Point(159, 39)
        Me.Order_id.Name = "Order_id"
        Me.Order_id.Size = New System.Drawing.Size(240, 20)
        Me.Order_id.TabIndex = 22
        Me.Order_id.Text = "0"
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label5.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(25, 38)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(128, 20)
        Me.Label5.TabIndex = 21
        Me.Label5.Text = "Order Id:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Csttxt
        '
        Me.Csttxt.Enabled = False
        Me.Csttxt.Location = New System.Drawing.Point(159, 65)
        Me.Csttxt.Name = "Csttxt"
        Me.Csttxt.Size = New System.Drawing.Size(240, 20)
        Me.Csttxt.TabIndex = 23
        Me.Csttxt.Visible = False
        '
        'custId
        '
        Me.custId.AutoSize = True
        Me.custId.Location = New System.Drawing.Point(449, 68)
        Me.custId.Name = "custId"
        Me.custId.Size = New System.Drawing.Size(0, 13)
        Me.custId.TabIndex = 24
        '
        'Column1
        '
        DataGridViewCellStyle1.Padding = New System.Windows.Forms.Padding(2)
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Column1.DefaultCellStyle = DataGridViewCellStyle1
        Me.Column1.HeaderText = "Sr no."
        Me.Column1.Name = "Column1"
        Me.Column1.Width = 50
        '
        'Qty
        '
        Me.Qty.HeaderText = "Quantity"
        Me.Qty.Name = "Qty"
        '
        'Rate
        '
        Me.Rate.HeaderText = "Rate (₹)"
        Me.Rate.Name = "Rate"
        Me.Rate.Width = 70
        '
        'Amt
        '
        Me.Amt.HeaderText = "Amount (₹)"
        Me.Amt.Name = "Amt"
        Me.Amt.Width = 160
        '
        'Sales
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(716, 552)
        Me.Controls.Add(Me.custId)
        Me.Controls.Add(Me.Csttxt)
        Me.Controls.Add(Me.Order_id)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Cust_name)
        Me.Controls.Add(Me.SalesBtn)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.DataGridView2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Sale_date)
        Me.Controls.Add(Me.Sales_id)
        Me.Controls.Add(Me.Label1)
        Me.MaximizeBox = False
        Me.Name = "Sales"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sales"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Cust_name As System.Windows.Forms.ComboBox
    Friend WithEvents SalesBtn As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents totalamt As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents DataGridView2 As System.Windows.Forms.DataGridView
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Sale_date As System.Windows.Forms.DateTimePicker
    Friend WithEvents Sales_id As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label


    Friend WithEvents Order_id As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Csttxt As System.Windows.Forms.TextBox
    Friend WithEvents custId As System.Windows.Forms.Label
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Qty As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Rate As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Amt As System.Windows.Forms.DataGridViewTextBoxColumn


End Class
