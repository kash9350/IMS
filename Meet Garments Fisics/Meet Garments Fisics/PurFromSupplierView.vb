Public Class PurFromSupplierView

    Private Sub PurFromSupplierView_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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
        cmd2.CommandText = "Select * from Purchase"
        adp2.Fill(ds, "Purchase")
        cmd5.Connection = con
        adp5.SelectCommand = cmd5
        cmd5.CommandText = "Select Supplier_id,Supplier_name from Supplier_details"
        ds5.Clear()
        adp5.Fill(ds5, "Supplier_details")
        With Supp_name
            .DataSource = ds5.Tables("Supplier_details")
            .DisplayMember = "Supplier_name"
            .ValueMember = "Supplier_id"
        End With
        con.Close()
        Dim rpt As CrystalDecisions.CrystalReports.Engine.ReportDocument
        rpt = New PurcFromSupplierR
        rpt.SetDataSource(ds)
        CrystalReportViewer1.ReportSource = rpt
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        con.Open()
        cmd.Connection = con
        adp.SelectCommand = cmd
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "Select * from Supplier_details where Supplier_name='" & Supp_name.Text & "'"
        ds.Clear()
        adp.Fill(ds, "Supplier_details")
        cmd2.Connection = con
        adp2.SelectCommand = cmd2
        cmd2.CommandType = CommandType.Text
        cmd2.CommandText = "Select * from Purchase"
        adp2.Fill(ds, "Purchase")
        con.Close()
        Dim rpt As CrystalDecisions.CrystalReports.Engine.ReportDocument
        rpt = New PurcFromSupplierR
        rpt.SetDataSource(ds)
        CrystalReportViewer1.ReportSource = rpt
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
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
        cmd2.CommandText = "Select * from Purchase"
        adp2.Fill(ds, "Purchase")
        con.Close()
        Dim rpt As CrystalDecisions.CrystalReports.Engine.ReportDocument
        rpt = New PurcFromSupplierR
        rpt.SetDataSource(ds)
        CrystalReportViewer1.ReportSource = rpt
    End Sub
End Class