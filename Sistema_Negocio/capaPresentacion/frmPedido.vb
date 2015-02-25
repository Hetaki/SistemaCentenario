Public Class frmPedido

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
       
    End Sub

    Private Sub txtDocumento_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDocumento.KeyPress
        If (Not Char.IsNumber(e.KeyChar) And e.KeyChar <> Microsoft.VisualBasic.ChrW(8)) Then
            e.Handled = True
            Beep()
        End If
    End Sub

End Class