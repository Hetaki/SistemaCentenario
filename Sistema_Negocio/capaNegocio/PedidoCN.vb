Imports CE = capaEntidad
Imports capaDatos
Public Class PedidoCN
    Dim objDao As New PedidoDAO
    Public Function generaCodigo() As Integer
        Return objDao.generaCodigo
    End Function
    Public Sub registraPedido(objPed As CE.Pedido)
        objDao.registraPedido(objPed)
    End Sub
    Public Function listaPedido() As DataSet
        Return objDao.listaPedido()
    End Function
End Class
