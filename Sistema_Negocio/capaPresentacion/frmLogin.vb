﻿Imports CE = capaEntidad
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
            util.Limpiar(Me)
        Else
            Me.Hide()
            txtPassword.Text = String.Empty
            txtUsuario.Text = String.Empty
            txtUsuario.Focus()
            frmWelcome.rol = objUsu.cargo
            frmWelcome.nombre = objUsu.nomCargo
            frmWelcome.Show()
        End If
    End Sub
    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        util.Limpiar(Me)
        Me.Close()
        frmInicio.Close()
    End Sub
   
End Class
