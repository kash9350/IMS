Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Imports System.Data.DataSet
Public Class OrderInBetweenDates

    Private Sub OrderInBetweenDates_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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
        con.Close()
        Dim rpt As CrystalDecisions.CrystalReports.Engine.ReportDocument
        rpt = New InBetweenDates
        rpt.SetDataSource(ds)
        CrystalReportViewer1.ReportSource = rpt
        con.Close()


    End Sub
End Class