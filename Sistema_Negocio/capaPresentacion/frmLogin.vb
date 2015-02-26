Imports CE = capaEntidad
Imports capaNegocio
Imports utilitarios
Public Class frmLogin
    Dim util As New util
    Dim objNeg As New UsuarioCN
    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        Dim objUsu As New CE.Usuario
        objUsu = objNeg.validaUsuario(txtUsuario.Text, txtPassword.Text)
        If objUsu Is Nothing Then
            MsgBox("No existe usuario")
        Else
            Me.Hide()
            frmWelcome.Show()
        End If
    End Sub
    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        util.Limpiar(Me)
        Me.Close()
    End Sub
   
End Class
