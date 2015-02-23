Imports capaDatos
Imports CE = capaEntidad
Public Class ProveedorCN
    Dim objDao As New ProveedorDAO
    Public Sub registraProveedor(objProv As CE.Proveedor)
        objDao.registraProveedor(objProv)
    End Sub
    Public Sub modificarProveedor(objProv As CE.Proveedor)
        objDao.modificarProveedor(objProv)
    End Sub
    Public Function listaProveedor() As DataSet
        Return objDao.listaProveedor()
    End Function
    Public Sub eliminaProveedor(objProv As CE.Proveedor)
        objDao.eliminaProveedor(objProv)
    End Sub
    Public Function buscaProveedor(codProveedor As Integer) As CE.Proveedor
        Return objDao.buscaProveedor(codProveedor)
    End Function
End Class
