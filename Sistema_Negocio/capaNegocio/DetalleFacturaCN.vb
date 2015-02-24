Imports CE = capaEntidad
Imports capaDatos
Public Class DetalleFacturaCN
    Dim objDao As New DetalleFacturaDAO
    Public Sub registraDetalle_Factura(objDetalFac As CE.DetalleFactura)
        objDao.registraDetalle_Factura(objDetalFac)
    End Sub
    Public Function listaDetalle_Factura(codigo As Integer) As DataSet
        Return objDao.listaDetalle_Factura(codigo)
    End Function
End Class
