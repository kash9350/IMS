Public Class FisicsHome
    Dim today As System.DateTime
    Private Sub HmLoginBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HmLoginBtn.Click
        If HmLoginBtn.Visible = True Then
            HmLoginBtn.Text = "Login"
            MenuStrip1.Enabled = False
            Login.Show()
        Else
            MenuStrip1.Enabled = True

        End If
    End Sub

    Private Sub FisicsHome_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If MsgBox("Do You want to Exit?", MsgBoxStyle.YesNo, "Meet Garments") = MsgBoxResult.No Then
            e.Cancel() = True
        End If
    End Sub

    Private Sub FisicsHome_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Login.Show()
        Login.Focus()
        If HmLoginBtn.Text = "Login" Then
            MenuStrip1.Enabled = False
        End If
        Timer1.Start()
    End Sub

    Private Sub NewPurchaseToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewPurchaseToolStripMenuItem.Click
        Dim pur As New Purchase
        pur.MdiParent = Me
        Purchase.Show()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Dim milsecond As Integer = System.DateTime.Now.Millisecond
        Dim second As Integer = System.DateTime.Now.Second
        Dim minute As Integer = System.DateTime.Now.Minute
        Dim hour As Integer = System.DateTime.Now.Hour
        If milsecond = 60 Then
            second += 1
            If second = 60 Then
                minute += 1
                If minute = 60 Then
                    hour += 1
                End If
            End If
        End If
        ToolStripStatusLabel1.Text = hour & ":" & minute & ":" & second & " " & System.DateTime.Now.Date
    End Sub

    Private Sub ViewItemsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim vitem As New View_Item
        vitem.MdiParent = Me
        View_Item.Show()
    End Sub

    Private Sub NewSalesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewSalesToolStripMenuItem.Click
        Dim sal As New Sales
        sal.MdiParent = Me
        Sales.Show()
    End Sub

    Private Sub AboutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutToolStripMenuItem.Click
        Dim abt As New Meetgarments
        abt.MdiParent = Me
        Meetgarments.Show()
    End Sub

    Private Sub ViewPurchasesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ViewPurchasesToolStripMenuItem.Click
        Dim vPur As New View_Purchase
        vPur.MdiParent = Me
        View_Purchase.Show()
    End Sub

    Private Sub SaleStockDetailsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaleStockDetailsToolStripMenuItem.Click
        Dim SaleSR As New SaleStockReport
        SaleSR.MdiParent = Me
        SaleStockReport.Show()
    End Sub

    Private Sub ViewSalesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ViewSalesToolStripMenuItem.Click
        Dim viwSales As New View_sales
        viwSales.MdiParent = Me
        View_sales.Show()
    End Sub

    Private Sub NewOrderToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewOrderToolStripMenuItem.Click
        Dim sale_order As New Sales_order
        sale_order.MdiParent = Me
        Sales_order.Show()
    End Sub

    Private Sub ItemQuantityWiseToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ItemQuantityWiseToolStripMenuItem.Click
        Dim SIW As New SalesItemWise
        SIW.MdiParent = Me
        SalesItemWise.Show()
    End Sub

    Private Sub ViewOrderToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ViewOrderToolStripMenuItem.Click
        Dim ViewOrder As New View_Order
        ViewOrder.MdiParent = Me
        View_Order.Show()
    End Sub

    Private Sub ViewReturnToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ViewReturnToolStripMenuItem.Click
        Dim PReturn As New PurchaseReturnView
        PReturn.MdiParent = Me
        PurchaseReturnView.Show()
    End Sub

    Private Sub ViewReturnToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ViewReturnToolStripMenuItem1.Click
        Dim Returnviw As New SalesReturnView
        Returnviw.MdiParent = Me
        SalesReturnView.Show()
    End Sub

    Private Sub AddToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddToolStripMenuItem.Click
        Dim nwsupp As New newsupplierdetails
        nwsupp.MdiParent = Me
        newsupplierdetails.Show()
    End Sub

    Private Sub ViewSupplierToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ViewSupplierToolStripMenuItem1.Click
        Dim vsupp As New ViewSupplier
        vsupp.MdiParent = Me
        ViewSupplier.Show()
    End Sub

    Private Sub AddCustomerToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddCustomerToolStripMenuItem1.Click
        Dim nwcust As New newcustomerdetails
        nwcust.MdiParent = Me
        newcustomerdetails.Show()
    End Sub

    Private Sub ViewCustomerToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ViewCustomerToolStripMenuItem.Click
        Dim vcust As New ViewCustomer
        vcust.MdiParent = Me
        ViewCustomer.Show()
    End Sub

    Private Sub AddToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddToolStripMenuItem1.Click
        Dim aditem As New salesitem
        aditem.MdiParent = Me
        salesitem.Show()
    End Sub

    Private Sub ViewToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ViewToolStripMenuItem.Click
        Dim VItem As New View_Item
        VItem.MdiParent = Me
        View_Item.Show()
    End Sub

    Private Sub LogoutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LogoutToolStripMenuItem.Click
        HmLoginBtn.Visible = True
        MenuStrip1.Enabled = False
    End Sub

    Private Sub ChangePasswordToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChangePasswordToolStripMenuItem.Click
        Dim chngepwd As New Changepassword
        chngepwd.MdiParent = Me
        Changepassword.Show()
    End Sub

    Private Sub AddToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddToolStripMenuItem2.Click
        Dim P_item_add As New Purchase_item_add()
        P_item_add.MdiParent = Me
        Purchase_item_add.Show()
    End Sub

    Private Sub ViewToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ViewToolStripMenuItem1.Click
        Dim p_item_view As New Purchase_item_view
        p_item_view.MdiParent = Me
        Purchase_item_view.Show()
    End Sub

    Private Sub NoOFCustomersToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NoOFCustomersToolStripMenuItem.Click
        Dim custrprt As New CustomerReport
        custrprt.MdiParent = Me
        CustomerReport.Show()
    End Sub

    Private Sub NoOfSuppliersToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NoOfSuppliersToolStripMenuItem.Click
        Dim supprprt As New SupplierReport
        supprprt.MdiParent = Me
        SupplierReport.Show()
    End Sub

    Private Sub SalesToCustomerToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalesToCustomerToolStripMenuItem.Click
        Dim supprprt As New SalesToCustomerViewr
        supprprt.MdiParent = Me
        SalesToCustomerViewr.Show()
    End Sub

    Private Sub PurFromSuppliersToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PurFromSuppliersToolStripMenuItem.Click
        Dim supprprt As New PurFromSupplierView
        supprprt.MdiParent = Me
        PurFromSupplierView.Show()
    End Sub

    Private Sub AllOrderToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AllOrderToolStripMenuItem.Click
        Dim orderDetails As New OrderDetailsView
        orderDetails.MdiParent = Me
        OrderDetailsView.Show()
    End Sub

    Private Sub InBetweenDatesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InBetweenDatesToolStripMenuItem.Click
        Dim INBetweenDates As New OrderInBetweenDates
        INBetweenDates.MdiParent = Me
        OrderInBetweenDates.Show()
    End Sub
End Class
