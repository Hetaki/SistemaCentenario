Imports capaDatos
Imports CE = capaEntidad
Public Class ClienteCN
    Dim objDao As New ClienteDAO
    Public Sub registraCliente(objCli As CE.Cliente)
        objDao.registraCliente(objCli)
    End Sub
    Public Sub modificarCliente(objCli As CE.Cliente)
        objDao.modificarCliente(objCli)
    End Sub
    Public Function listaCliente() As DataSet
        Return objDao.listaCliente()
    End Function
    Public Sub eliminaCliente(ObjCli As CE.Cliente)
        objDao.eliminaCliente(ObjCli)
    End Sub
    Public Function buscaClientexDNI(dni As String) As CE.Cliente
        Return objDao.buscaClientexDNI(dni)
    End Function
    Public Function buscaClientexRUC(ruc As String) As CE.Cliente
        Return objDao.buscaClientexRUC(ruc)
    End Function
End Class
