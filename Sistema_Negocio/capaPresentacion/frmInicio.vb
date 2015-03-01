Public NotInheritable Class frmInicio
    Public CONTADOR As Integer
   
    Private Sub pgrBarra_Click(sender As Object, e As EventArgs) Handles pgrBarra.Click
        pgrBarra.Value = 0.0
        pgrBarra.Maximum = 100
        tmr.Interval = 40
        tmr.Enabled = True
    End Sub

    Private Sub tmr_Tick(sender As Object, e As EventArgs) Handles tmr.Tick
        If CONTADOR < 100 Then
            pgrBarra.Value = CONTADOR
            CONTADOR += 1
        Else
            tmr.Enabled = False
            Me.Hide()
            frmLogin.Show()
        End If
    End Sub
End Class
