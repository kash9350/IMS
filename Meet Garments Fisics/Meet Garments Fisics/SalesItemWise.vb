Public Class SalesItemWise

    Private Sub SalesItemWise_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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
        cmd2.CommandText = "Select * from Sales_details"
        adp2.Fill(ds, "Sales_details")
        cmd3.Connection = con
        adp3.SelectCommand = cmd3
        cmd3.CommandType = CommandType.Text
        cmd3.CommandText = "Select * from Sales_item_details"
        adp3.Fill(ds, "Sales_item_details")
        cmd4.Connection = con
        adp4.SelectCommand = cmd4
        cmd4.CommandType = CommandType.Text
        cmd4.CommandText = "Select * from Sales"
        adp4.Fill(ds, "Sales")
        con.Close()
        Dim rpt As CrystalDecisions.CrystalReports.Engine.ReportDocument
        rpt = New SalesByGroup
        rpt.SetDataSource(ds)
        CrystalReportViewer1.ReportSource = rpt
    End Sub
End Class