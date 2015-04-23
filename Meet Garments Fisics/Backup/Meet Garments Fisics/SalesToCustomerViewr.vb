Public Class SalesToCustomerViewr

    Private Sub SalesToCustomerViewr_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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
        cmd2.CommandText = "Select * from Sales"
        adp2.Fill(ds, "Sales")
        cmd5.Connection = con
        adp5.SelectCommand = cmd5
        cmd5.CommandText = "Select Customer_id,Customer_name from Customer_details"
        ds5.Clear()
        adp5.Fill(ds5, "Customer_details")
        With Cust_name
            .DataSource = ds5.Tables("Customer_details")
            .DisplayMember = "Customer_name"
            .ValueMember = "Customer_id"
        End With
        con.Close()
        Dim rpt As CrystalDecisions.CrystalReports.Engine.ReportDocument
        rpt = New SalestoCustomerR
        rpt.SetDataSource(ds)
        CrystalReportViewer1.ReportSource = rpt
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
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
        cmd2.CommandText = "Select * from Sales"
        adp2.Fill(ds, "Sales")
        con.Close()
        Dim rpt As CrystalDecisions.CrystalReports.Engine.ReportDocument
        rpt = New SalestoCustomerR
        rpt.SetDataSource(ds)
        CrystalReportViewer1.ReportSource = rpt
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        con.Open()
        cmd.Connection = con
        adp.SelectCommand = cmd
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "Select * from Customer_details where Customer_name='" & Cust_name.Text & "'"
        ds.Clear()
        adp.Fill(ds, "Customer_details")
        cmd2.Connection = con
        adp2.SelectCommand = cmd2
        cmd2.CommandType = CommandType.Text
        cmd2.CommandText = "Select * from Sales"
        adp2.Fill(ds, "Sales")
        con.Close()
        Dim rpt As CrystalDecisions.CrystalReports.Engine.ReportDocument
        rpt = New SalestoCustomerR
        rpt.SetDataSource(ds)
        CrystalReportViewer1.ReportSource = rpt
    End Sub
End Class