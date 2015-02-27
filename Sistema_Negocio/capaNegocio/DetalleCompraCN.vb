Imports CE = capaEntidad
Imports capaDatos

Public Class DetalleCompraCN
    Dim objdao As New DetalleCompraDAO
    Public Sub registraDetalle_Compra(objDetalComp As CE.DetalleComprar)
        objdao.registraDetalle_Compra(objDetalComp)
    End Sub
    Public Function listaDetalle_Compra(codigo As Integer) As DataSet
        Return objdao.listaDetalle_Compra(codigo)
    End Function

End Class
