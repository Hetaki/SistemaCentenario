Imports CE = capaEntidad
Imports capaDatos
Public Class CompraCN
    Dim objdao As New CompraDAO
    Public Function generaCodigo() As Integer
        Return objdao.generaCodigo
    End Function
    Public Sub registraCompra(objCom As CE.Compra)
        objdao.registraCompra(objCom)
    End Sub
    Public Function listaCompra() As DataSet
        Return objdao.listaCompra
    End Function
End Class
