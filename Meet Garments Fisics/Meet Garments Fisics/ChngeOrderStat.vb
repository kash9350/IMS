Public Class ChngeOrderStat

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
        View_Order.Show()
    End Sub

    Private Sub updt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles updt.Click
        con.Open()
        cmd.Connection = con
        cmd.CommandText = "UPDATE Order_master SET Status='" & Dispatch.Text & "' WHERE Order_id=" & OrderId.Text
        cmd.ExecuteNonQuery()
        MsgBox("Updated")
        con.Close()
        Sales.Order_id.Text = OrderId.Text
        Sales.Show()
        Me.Close()
    End Sub

    Private Sub ChngeOrderStat_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.MdiParent = FisicsHome
    End Sub
End Class