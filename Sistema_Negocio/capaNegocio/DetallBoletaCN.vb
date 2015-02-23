Imports CE = capaEntidad
Imports capaDatos
Public Class DetallBoletaCN
    Dim objDao As New DetalleBoletaDAO
    Public Sub registraDetalle_Boleta(objDetalBol As CE.DetalleBoleta)
        objDao.registraDetalle_Boleta(objDetalBol)
    End Sub
    Public Function listaDetalle_Boleta(codigo As Integer) As DataSet
        Return objDao.listaDetalle_Boleta(codigo)
    End Function
End Class
