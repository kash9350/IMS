<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FisicsHome
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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FisicsHome))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.PurchaseMenu = New System.Windows.Forms.ToolStripMenuItem
        Me.NewPurchaseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ViewPurchasesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ViewReturnToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.SalesMenu = New System.Windows.Forms.ToolStripMenuItem
        Me.SalesOrderToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.NewOrderToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ViewOrderToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.NewSalesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ViewSalesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ViewReturnToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.MastersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.SupplierToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AddToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ViewSupplierToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.CustomerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AddCustomerToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.ViewCustomerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ItemToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AddProductToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AddToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.ViewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ViewProductStockToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AddToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem
        Me.ViewToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.ReportsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.OrderDetailsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AllOrderToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.InBetweenDatesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.CustomerDetailsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.NoOFCustomersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.SalesToCustomerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.SupplierDetailsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.NoOfSuppliersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.PurFromSuppliersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.SaleStockDetailsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ItemQuantityWiseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AccountToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ChangePasswordToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.LogoutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.HmLoginBtn = New System.Windows.Forms.Button
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel
        Me.MenuStrip1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PurchaseMenu, Me.SalesMenu, Me.MastersToolStripMenuItem, Me.ItemToolStripMenuItem, Me.ReportsToolStripMenuItem, Me.AboutToolStripMenuItem, Me.AccountToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(991, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'PurchaseMenu
        '
        Me.PurchaseMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewPurchaseToolStripMenuItem, Me.ViewPurchasesToolStripMenuItem, Me.ViewReturnToolStripMenuItem})
        Me.PurchaseMenu.Name = "PurchaseMenu"
        Me.PurchaseMenu.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.P), System.Windows.Forms.Keys)
        Me.PurchaseMenu.Size = New System.Drawing.Size(67, 20)
        Me.PurchaseMenu.Text = "Purchase"
        '
        'NewPurchaseToolStripMenuItem
        '
        Me.NewPurchaseToolStripMenuItem.Name = "NewPurchaseToolStripMenuItem"
        Me.NewPurchaseToolStripMenuItem.Size = New System.Drawing.Size(155, 22)
        Me.NewPurchaseToolStripMenuItem.Text = "New Purchase"
        '
        'ViewPurchasesToolStripMenuItem
        '
        Me.ViewPurchasesToolStripMenuItem.Name = "ViewPurchasesToolStripMenuItem"
        Me.ViewPurchasesToolStripMenuItem.Size = New System.Drawing.Size(155, 22)
        Me.ViewPurchasesToolStripMenuItem.Text = "View purchases"
        '
        'ViewReturnToolStripMenuItem
        '
        Me.ViewReturnToolStripMenuItem.Name = "ViewReturnToolStripMenuItem"
        Me.ViewReturnToolStripMenuItem.Size = New System.Drawing.Size(155, 22)
        Me.ViewReturnToolStripMenuItem.Text = "View Return"
        '
        'SalesMenu
        '
        Me.SalesMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SalesOrderToolStripMenuItem, Me.NewSalesToolStripMenuItem, Me.ViewSalesToolStripMenuItem, Me.ViewReturnToolStripMenuItem1})
        Me.SalesMenu.Name = "SalesMenu"
        Me.SalesMenu.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.SalesMenu.Size = New System.Drawing.Size(45, 20)
        Me.SalesMenu.Text = "Sales"
        '
        'SalesOrderToolStripMenuItem
        '
        Me.SalesOrderToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewOrderToolStripMenuItem, Me.ViewOrderToolStripMenuItem})
        Me.SalesOrderToolStripMenuItem.Name = "SalesOrderToolStripMenuItem"
        Me.SalesOrderToolStripMenuItem.Size = New System.Drawing.Size(137, 22)
        Me.SalesOrderToolStripMenuItem.Text = "Sales Order"
        '
        'NewOrderToolStripMenuItem
        '
        Me.NewOrderToolStripMenuItem.Name = "NewOrderToolStripMenuItem"
        Me.NewOrderToolStripMenuItem.Size = New System.Drawing.Size(132, 22)
        Me.NewOrderToolStripMenuItem.Text = "New Order"
        '
        'ViewOrderToolStripMenuItem
        '
        Me.ViewOrderToolStripMenuItem.Name = "ViewOrderToolStripMenuItem"
        Me.ViewOrderToolStripMenuItem.Size = New System.Drawing.Size(132, 22)
        Me.ViewOrderToolStripMenuItem.Text = "View Order"
        '
        'NewSalesToolStripMenuItem
        '
        Me.NewSalesToolStripMenuItem.Name = "NewSalesToolStripMenuItem"
        Me.NewSalesToolStripMenuItem.Size = New System.Drawing.Size(137, 22)
        Me.NewSalesToolStripMenuItem.Text = "New Sales"
        '
        'ViewSalesToolStripMenuItem
        '
        Me.ViewSalesToolStripMenuItem.Name = "ViewSalesToolStripMenuItem"
        Me.ViewSalesToolStripMenuItem.Size = New System.Drawing.Size(137, 22)
        Me.ViewSalesToolStripMenuItem.Text = "View Sales"
        '
        'ViewReturnToolStripMenuItem1
        '
        Me.ViewReturnToolStripMenuItem1.Name = "ViewReturnToolStripMenuItem1"
        Me.ViewReturnToolStripMenuItem1.Size = New System.Drawing.Size(137, 22)
        Me.ViewReturnToolStripMenuItem1.Text = "View Return"
        '
        'MastersToolStripMenuItem
        '
        Me.MastersToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SupplierToolStripMenuItem, Me.CustomerToolStripMenuItem})
        Me.MastersToolStripMenuItem.Name = "MastersToolStripMenuItem"
        Me.MastersToolStripMenuItem.Size = New System.Drawing.Size(60, 20)
        Me.MastersToolStripMenuItem.Text = "Masters"
        '
        'SupplierToolStripMenuItem
        '
        Me.SupplierToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddToolStripMenuItem, Me.ViewSupplierToolStripMenuItem1})
        Me.SupplierToolStripMenuItem.Name = "SupplierToolStripMenuItem"
        Me.SupplierToolStripMenuItem.Size = New System.Drawing.Size(131, 22)
        Me.SupplierToolStripMenuItem.Text = "Supplier"
        '
        'AddToolStripMenuItem
        '
        Me.AddToolStripMenuItem.Name = "AddToolStripMenuItem"
        Me.AddToolStripMenuItem.Size = New System.Drawing.Size(145, 22)
        Me.AddToolStripMenuItem.Text = " Add Supplier"
        '
        'ViewSupplierToolStripMenuItem1
        '
        Me.ViewSupplierToolStripMenuItem1.Name = "ViewSupplierToolStripMenuItem1"
        Me.ViewSupplierToolStripMenuItem1.Size = New System.Drawing.Size(145, 22)
        Me.ViewSupplierToolStripMenuItem1.Text = "View Supplier"
        '
        'CustomerToolStripMenuItem
        '
        Me.CustomerToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddCustomerToolStripMenuItem1, Me.ViewCustomerToolStripMenuItem})
        Me.CustomerToolStripMenuItem.Name = "CustomerToolStripMenuItem"
        Me.CustomerToolStripMenuItem.Size = New System.Drawing.Size(131, 22)
        Me.CustomerToolStripMenuItem.Text = "Customers"
        '
        'AddCustomerToolStripMenuItem1
        '
        Me.AddCustomerToolStripMenuItem1.Name = "AddCustomerToolStripMenuItem1"
        Me.AddCustomerToolStripMenuItem1.Size = New System.Drawing.Size(154, 22)
        Me.AddCustomerToolStripMenuItem1.Text = "Add Customer"
        '
        'ViewCustomerToolStripMenuItem
        '
        Me.ViewCustomerToolStripMenuItem.Name = "ViewCustomerToolStripMenuItem"
        Me.ViewCustomerToolStripMenuItem.Size = New System.Drawing.Size(154, 22)
        Me.ViewCustomerToolStripMenuItem.Text = "View Customer"
        '
        'ItemToolStripMenuItem
        '
        Me.ItemToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddProductToolStripMenuItem, Me.ViewProductStockToolStripMenuItem})
        Me.ItemToolStripMenuItem.Name = "ItemToolStripMenuItem"
        Me.ItemToolStripMenuItem.Size = New System.Drawing.Size(66, 20)
        Me.ItemToolStripMenuItem.Text = "Products"
        '
        'AddProductToolStripMenuItem
        '
        Me.AddProductToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddToolStripMenuItem1, Me.ViewToolStripMenuItem})
        Me.AddProductToolStripMenuItem.Name = "AddProductToolStripMenuItem"
        Me.AddProductToolStripMenuItem.Size = New System.Drawing.Size(167, 22)
        Me.AddProductToolStripMenuItem.Text = "Sales Product"
        '
        'AddToolStripMenuItem1
        '
        Me.AddToolStripMenuItem1.Name = "AddToolStripMenuItem1"
        Me.AddToolStripMenuItem1.Size = New System.Drawing.Size(99, 22)
        Me.AddToolStripMenuItem1.Text = "Add"
        '
        'ViewToolStripMenuItem
        '
        Me.ViewToolStripMenuItem.Name = "ViewToolStripMenuItem"
        Me.ViewToolStripMenuItem.Size = New System.Drawing.Size(99, 22)
        Me.ViewToolStripMenuItem.Text = "View"
        '
        'ViewProductStockToolStripMenuItem
        '
        Me.ViewProductStockToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddToolStripMenuItem2, Me.ViewToolStripMenuItem1})
        Me.ViewProductStockToolStripMenuItem.Name = "ViewProductStockToolStripMenuItem"
        Me.ViewProductStockToolStripMenuItem.Size = New System.Drawing.Size(167, 22)
        Me.ViewProductStockToolStripMenuItem.Text = "Purchase Product"
        '
        'AddToolStripMenuItem2
        '
        Me.AddToolStripMenuItem2.Name = "AddToolStripMenuItem2"
        Me.AddToolStripMenuItem2.Size = New System.Drawing.Size(99, 22)
        Me.AddToolStripMenuItem2.Text = "Add"
        '
        'ViewToolStripMenuItem1
        '
        Me.ViewToolStripMenuItem1.Name = "ViewToolStripMenuItem1"
        Me.ViewToolStripMenuItem1.Size = New System.Drawing.Size(99, 22)
        Me.ViewToolStripMenuItem1.Text = "View"
        '
        'ReportsToolStripMenuItem
        '
        Me.ReportsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OrderDetailsToolStripMenuItem, Me.CustomerDetailsToolStripMenuItem, Me.SupplierDetailsToolStripMenuItem, Me.SaleStockDetailsToolStripMenuItem, Me.ItemQuantityWiseToolStripMenuItem})
        Me.ReportsToolStripMenuItem.Name = "ReportsToolStripMenuItem"
        Me.ReportsToolStripMenuItem.Size = New System.Drawing.Size(59, 20)
        Me.ReportsToolStripMenuItem.Text = "Reports"
        '
        'OrderDetailsToolStripMenuItem
        '
        Me.OrderDetailsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AllOrderToolStripMenuItem, Me.InBetweenDatesToolStripMenuItem})
        Me.OrderDetailsToolStripMenuItem.Name = "OrderDetailsToolStripMenuItem"
        Me.OrderDetailsToolStripMenuItem.Size = New System.Drawing.Size(175, 22)
        Me.OrderDetailsToolStripMenuItem.Text = "Orders"
        '
        'AllOrderToolStripMenuItem
        '
        Me.AllOrderToolStripMenuItem.Name = "AllOrderToolStripMenuItem"
        Me.AllOrderToolStripMenuItem.Size = New System.Drawing.Size(164, 22)
        Me.AllOrderToolStripMenuItem.Text = "All Order"
        '
        'InBetweenDatesToolStripMenuItem
        '
        Me.InBetweenDatesToolStripMenuItem.Name = "InBetweenDatesToolStripMenuItem"
        Me.InBetweenDatesToolStripMenuItem.Size = New System.Drawing.Size(164, 22)
        Me.InBetweenDatesToolStripMenuItem.Text = "In Between Dates"
        '
        'CustomerDetailsToolStripMenuItem
        '
        Me.CustomerDetailsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NoOFCustomersToolStripMenuItem, Me.SalesToCustomerToolStripMenuItem})
        Me.CustomerDetailsToolStripMenuItem.Name = "CustomerDetailsToolStripMenuItem"
        Me.CustomerDetailsToolStripMenuItem.Size = New System.Drawing.Size(175, 22)
        Me.CustomerDetailsToolStripMenuItem.Text = "Customer"
        '
        'NoOFCustomersToolStripMenuItem
        '
        Me.NoOFCustomersToolStripMenuItem.Name = "NoOFCustomersToolStripMenuItem"
        Me.NoOFCustomersToolStripMenuItem.Size = New System.Drawing.Size(169, 22)
        Me.NoOFCustomersToolStripMenuItem.Text = "No of Customers"
        '
        'SalesToCustomerToolStripMenuItem
        '
        Me.SalesToCustomerToolStripMenuItem.Name = "SalesToCustomerToolStripMenuItem"
        Me.SalesToCustomerToolStripMenuItem.Size = New System.Drawing.Size(169, 22)
        Me.SalesToCustomerToolStripMenuItem.Text = "Sales to Customer"
        '
        'SupplierDetailsToolStripMenuItem
        '
        Me.SupplierDetailsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NoOfSuppliersToolStripMenuItem, Me.PurFromSuppliersToolStripMenuItem})
        Me.SupplierDetailsToolStripMenuItem.Name = "SupplierDetailsToolStripMenuItem"
        Me.SupplierDetailsToolStripMenuItem.Size = New System.Drawing.Size(175, 22)
        Me.SupplierDetailsToolStripMenuItem.Text = "Supplier Details"
        '
        'NoOfSuppliersToolStripMenuItem
        '
        Me.NoOfSuppliersToolStripMenuItem.Name = "NoOfSuppliersToolStripMenuItem"
        Me.NoOfSuppliersToolStripMenuItem.Size = New System.Drawing.Size(177, 22)
        Me.NoOfSuppliersToolStripMenuItem.Text = "No Of Suppliers"
        '
        'PurFromSuppliersToolStripMenuItem
        '
        Me.PurFromSuppliersToolStripMenuItem.Name = "PurFromSuppliersToolStripMenuItem"
        Me.PurFromSuppliersToolStripMenuItem.Size = New System.Drawing.Size(177, 22)
        Me.PurFromSuppliersToolStripMenuItem.Text = "Pur From Suppliers "
        '
        'SaleStockDetailsToolStripMenuItem
        '
        Me.SaleStockDetailsToolStripMenuItem.Name = "SaleStockDetailsToolStripMenuItem"
        Me.SaleStockDetailsToolStripMenuItem.Size = New System.Drawing.Size(175, 22)
        Me.SaleStockDetailsToolStripMenuItem.Text = "Sale Stock Details"
        '
        'ItemQuantityWiseToolStripMenuItem
        '
        Me.ItemQuantityWiseToolStripMenuItem.Name = "ItemQuantityWiseToolStripMenuItem"
        Me.ItemQuantityWiseToolStripMenuItem.Size = New System.Drawing.Size(175, 22)
        Me.ItemQuantityWiseToolStripMenuItem.Text = "Item Quantity Wise"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(52, 20)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'AccountToolStripMenuItem
        '
        Me.AccountToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.AccountToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ChangePasswordToolStripMenuItem, Me.LogoutToolStripMenuItem})
        Me.AccountToolStripMenuItem.Name = "AccountToolStripMenuItem"
        Me.AccountToolStripMenuItem.Size = New System.Drawing.Size(64, 20)
        Me.AccountToolStripMenuItem.Text = "Account"
        '
        'ChangePasswordToolStripMenuItem
        '
        Me.ChangePasswordToolStripMenuItem.Name = "ChangePasswordToolStripMenuItem"
        Me.ChangePasswordToolStripMenuItem.Size = New System.Drawing.Size(168, 22)
        Me.ChangePasswordToolStripMenuItem.Text = "Change Password"
        '
        'LogoutToolStripMenuItem
        '
        Me.LogoutToolStripMenuItem.Name = "LogoutToolStripMenuItem"
        Me.LogoutToolStripMenuItem.Size = New System.Drawing.Size(168, 22)
        Me.LogoutToolStripMenuItem.Text = "Logout"
        '
        'HmLoginBtn
        '
        Me.HmLoginBtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.HmLoginBtn.Location = New System.Drawing.Point(916, 1)
        Me.HmLoginBtn.Name = "HmLoginBtn"
        Me.HmLoginBtn.Size = New System.Drawing.Size(75, 23)
        Me.HmLoginBtn.TabIndex = 1
        Me.HmLoginBtn.Text = "Login"
        Me.HmLoginBtn.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 407)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(991, 22)
        Me.StatusStrip1.TabIndex = 0
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripStatusLabel1.Margin = New System.Windows.Forms.Padding(600, 3, 0, 2)
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(0, 17)
        '
        'FisicsHome
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BackgroundImage = Global.Meet_Garments_Fisics.My.Resources.Resources.IMG_20140221_WA0005
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(991, 429)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.HmLoginBtn)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "FisicsHome"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Meet Garments"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents PurchaseMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NewPurchaseToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SalesMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NewSalesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ViewPurchasesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ViewSalesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HmLoginBtn As System.Windows.Forms.Button
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ReportsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CustomerDetailsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SupplierDetailsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ItemToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddProductToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SaleStockDetailsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SalesOrderToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NewOrderToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ViewOrderToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ItemQuantityWiseToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ViewProductStockToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ViewReturnToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ViewReturnToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OrderDetailsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MastersToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SupplierToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ViewSupplierToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CustomerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddCustomerToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ViewCustomerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ViewToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ViewToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AccountToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ChangePasswordToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LogoutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NoOFCustomersToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SalesToCustomerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NoOfSuppliersToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PurFromSuppliersToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AllOrderToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents InBetweenDatesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
