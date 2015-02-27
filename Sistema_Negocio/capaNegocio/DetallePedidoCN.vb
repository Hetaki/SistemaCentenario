Imports CE = capaEntidad
Imports capaDatos
Public Class DetallePedidoCN
    Dim objDao As New DetallePedidoDAO
    Public Sub registraDetalle_Pedido(objDetalPed As CE.DetallePedido)
        objDao.registraDetalle_Pedido(objDetalPed)
    End Sub
    Public Function listaDetalle_Pedido(codigo As Integer) As DataSet
        Return objDao.listaDetalle_Pedido(codigo)
    End Function
End Class
