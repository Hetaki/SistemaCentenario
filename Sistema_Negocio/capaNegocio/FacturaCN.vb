Imports CE = capaEntidad
Imports capaDatos
Public Class FacturaCN
    Dim objDao As New FacturaDAO
    Public Function generaCodigo() As Integer
        Return objDao.generaCodigo
    End Function
    Public Sub registraFactura(objFac As CE.Factura)
        objDao.registraFactura(objFac)
    End Sub
    Public Function listaFactura() As DataSet
        Return objDao.listaFactura
    End Function
End Class
