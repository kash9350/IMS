Public Class SupplierReport

    Private Sub SupplierReport_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.MdiParent = FisicsHome
        con.Open()
        cmd.Connection = con
        adp.SelectCommand = cmd
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "Select * from Supplier_details"
        ds.Clear()
        adp.Fill(ds, "Supplier_details")
        cmd2.Connection = con
        adp2.SelectCommand = cmd2
        cmd2.CommandType = CommandType.Text
        cmd2.CommandText = "Select * from City"
        adp2.Fill(ds, "City")
        con.Close()
        Dim rpt As CrystalDecisions.CrystalReports.Engine.ReportDocument
        rpt = New SupplierDetails
        rpt.SetDataSource(ds)
        CrystalReportViewer1.ReportSource = rpt
        con.Close()
    End Sub
End Class