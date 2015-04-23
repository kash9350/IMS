Public Class OrderReport
    Shared id As Integer
    Private Sub OrderReport_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.MdiParent = FisicsHome
        con.Open()
        cmd.Connection = con
        adp.SelectCommand = cmd
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "Select * from Customer_details"
        ds.Clear()
        adp.Fill(ds, "Customer_details")
        cmd2.Connection = con
        adp2.SelectCommand = cmd2
        cmd2.CommandType = CommandType.Text
        cmd2.CommandText = "Select * from Order_master"
        adp2.Fill(ds, "Order_master")
        cmd1.Connection = con
        adp1.SelectCommand = cmd1
        cmd1.CommandType = CommandType.Text
        cmd1.CommandText = "Select * from Sales_item_details"
        adp1.Fill(ds, "Sales_item_details")
        cmd3.Connection = con
        adp3.SelectCommand = cmd3
        cmd3.CommandType = CommandType.Text
        cmd3.CommandText = "Select * from Order_details"
        adp3.Fill(ds, "Order_details")

        con.Close()
        Dim rpt As CrystalDecisions.CrystalReports.Engine.ReportDocument
        rpt = New OrderDetails
        rpt.SetDataSource(ds)
        CrystalReportViewer1.ReportSource = rpt
        con.Close()
    End Sub
End Class