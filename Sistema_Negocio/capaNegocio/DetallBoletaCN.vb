Imports CE = capaEntidad
Imports capaDatos
Public Class DetallBoletaCN
    Dim objDao As New DetalleBoletaDAO
    Public Sub registraDetalle_Boleta(objDetalBol As CE.DetalleBoleta)
        objDao.registraDetalle_Boleta(objDetalBol)
    End Sub
    Public Function listaDetalle_Boleta() As DataSet
        Return objDao.listaDetalle_Boleta()
    End Function
End Class
