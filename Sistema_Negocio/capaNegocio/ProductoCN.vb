Imports capaDatos
Imports CE = capaEntidad
Public Class ProductoCN
    Dim objDao As New ProductoDAO
    Public Sub registraCategoria(descripcion As String)
        objDao.registraCategoria(descripcion)
    End Sub
    Public Sub registraProducto(objProd As CE.Producto)
        objDao.registraProducto(objProd)
    End Sub
    Public Sub modificarProducto(objProd As CE.Producto)
        objDao.modificarProducto(objProd)
    End Sub
    Public Function listaProductoxCategoria_Nombre(cat As Integer, descripcion As String) As DataSet
        Return objDao.listaProductoxCategoria_Nombre(cat, descripcion)
    End Function
    Public Function listaProductoxCategoria(id As Integer) As Integer
        Return objDao.listaProductoxCategoria(id)
    End Function
    Public Function listaCategoria() As DataSet
        Return objDao.listaCategoria
    End Function
    Public Function listaProducto() As DataSet
        Return objDao.listaProducto
    End Function
    Public Sub eliminaProducto(objProd As CE.Producto)
        objDao.eliminaProducto(objProd)
    End Sub
    Public Function buscaProducto(codProducto As Integer) As CE.Producto
        Return objDao.buscaProducto(codProducto)
    End Function
    Public Function disminuir_stock(idProd As Integer, cantidad As Integer) As Boolean
        Return objDao.disminuir_stock(idProd, cantidad)
    End Function
    Public Function aumentar_stock(idProd As Integer, cantidad As Integer) As Boolean
        Return objDao.aumentar_stock(idProd, cantidad)
    End Function
    Public Function calculaStock(codigo As Integer) As Integer
        Return objDao.calculaStock(codigo)
    End Function
End Class
