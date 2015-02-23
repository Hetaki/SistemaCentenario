Imports capaDatos
Imports CE = capaEntidad
Public Class UsuarioCN
    Dim objDao As New UsuarioDAO
    Public Sub registrarUsuario(ByVal objUsu As CE.Usuario)
        objDao.registrarUsuario(objUsu)
    End Sub
    Public Sub modificarUsuario(ByVal objUsu As CE.Usuario)
        objDao.modificarUsuario(objUsu)
    End Sub
    Public Sub eliminaUsuario(objUsu As CE.Usuario)
        objDao.eliminaUsuario(objUsu)
    End Sub
    Public Function listaCargo() As DataSet
        Return objDao.listaCargo
    End Function
    Public Function listaUsuario() As DataSet
        Return objDao.listaUsuario
    End Function
    Public Function validaUsuario(usuario As String, password As String) As CE.Usuario
        Return objDao.validaUsuario(usuario, password)
    End Function
End Class
