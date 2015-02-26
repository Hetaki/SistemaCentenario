Imports capaDatos
Imports CE = capaEntidad
Public Class ProductoDesconectadoCN
    Dim objDao As New ProductoDesconectadoDAO
    Public Function listaProductoDesconectado() As DataSet
        Return objDao.listaProductoDesconectado()
    End Function
    Public Function buscaProducto(ObjPro As CE.Producto) As DataRow
        Return objDao.buscaProducto(ObjPro)
    End Function
    Public Sub disminuyeStockDesconectado(codigo As Integer, cantidad As Integer)
        objDao.disminuyeStockDesconectado(codigo, cantidad)
    End Sub
    Public Sub aumentarStockDesconectado(codigo As Integer, cantidad As Integer)
        objDao.aumentarStockDesconectado(codigo, cantidad)
    End Sub
    Public Function buscaStock(codigo As Integer) As Integer
        Return objDao.buscaStock(codigo)
    End Function
End Class
