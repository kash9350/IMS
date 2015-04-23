Public Class Purchase_item_add

    Private Sub Purchase_item_add_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.MdiParent = FisicsHome
        Dim idno As Integer
        con.Open()
        cmd1.Connection = con
        cmd1.CommandText = "SELECT MAX(P_Item_id) from Purchase_item_details"
        If cmd1.ExecuteScalar Is DBNull.Value Then
            idno = 1
        Else
            idno = cmd1.ExecuteScalar() + 1
        End If
        pur_item_id.Text = idno.ToString()
        con.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If pur_item_name.Text = "" Then
            InameValid.Visible = True
            InameValid.Text = "Please Enter Name of Product"
        ElseIf pur_item_qty.Text = "" Then
            QtyValid.Visible = True
            InameValid.Text = "Please Enter Qty of Product"
        Else
            con.Open()
            cmd.Connection = con
            adp.InsertCommand = cmd
            cmd.CommandText = "INSERT INTO Purchase_item_details VALUES('" & pur_item_id.Text & "','" & pur_item_name.Text & "'," & pur_item_qty.Text & ")"
            cmd.ExecuteNonQuery()
            con.Close()
            MsgBox("Stock Added")
            Me.Close()
        End If
    End Sub

   

    

    Private Sub pur_item_name_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pur_item_name.TextChanged
        InameValid.Visible = False
    End Sub

    Private Sub pur_item_qty_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles pur_item_qty.KeyPress
        If Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub pur_item_qty_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pur_item_qty.TextChanged
        QtyValid.Visible = False
    End Sub

    
End Class