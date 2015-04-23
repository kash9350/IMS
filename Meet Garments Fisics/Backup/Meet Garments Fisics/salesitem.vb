Public Class salesitem

    Private Sub salesitem_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.MdiParent = FisicsHome
        Dim idno As Integer
        con.Open()
        cmd1.Connection = con
        cmd1.CommandText = "SELECT MAX(Sales_item_id) from Sales_item_details"
        If cmd1.ExecuteScalar Is DBNull.Value Then
            idno = 1
        Else
            idno = cmd1.ExecuteScalar() + 1
        End If
        sale_item_id.Text = idno.ToString()
        con.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If sales_item_name.Text = "" Then
            InameValid.Visible = True
            InameValid.Text = "Please Enter Name of Product"
        ElseIf sale_item_qty.Text = "" Then
            QtyValid.Visible = True
            InameValid.Text = "Please Enter Quantity of Product"
        ElseIf Re_or_level.Text = "" Then
            ReOrderValid.Visible = True
            InameValid.Text = "Please Enter ROL of Product"
        Else
            con.Open()
            cmd.Connection = con
            adp.InsertCommand = cmd
            cmd.CommandText = "INSERT INTO Sales_item_details VALUES('" & sale_item_id.Text & "','" & sales_item_name.Text & "','" & sale_item_qty.Text & "'," & Re_or_level.Text & ")"
            cmd.ExecuteNonQuery()
            con.Close()
            MsgBox("Stock Added")
            Me.Close()
        End If

    End Sub

    Private Sub sale_item_qty_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles sale_item_qty.KeyPress
        If Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub sale_item_qty_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles sale_item_qty.TextChanged
        QtyValid.Visible = False
    End Sub

    Private Sub Re_or_level_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Re_or_level.KeyPress
        If Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub Re_or_level_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Re_or_level.TextChanged
        ReOrderValid.Visible = False
    End Sub

    Private Sub sales_item_name_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles sales_item_name.TextChanged
        InameValid.Visible = False
    End Sub
End Class