Imports CE = capaEntidad
Imports capaDatos
Public Class BoletaCN
    Dim objDao As New BoletaDAO
    Public Function generaCodigo() As Integer
        Return objDao.generaCodigo
    End Function
    Public Sub registraBoleta(objBol As CE.Boleta)
        objDao.registraBoleta(objBol)
    End Sub
    Public Function listaBoleta() As DataSet
        Return objDao.listaBoleta
    End Function
End Class
