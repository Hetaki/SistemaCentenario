Imports CE = capaEntidad
Imports System.Data.SqlClient
''' -----------------------------------------------
'''  Project: 
'''  Class: ProductoDesconectadoDAO
''' -----------------------------------------------
''' <summary>
'''  En esta clase se hace todo lo referenciado al
'''  mantenimiento del Producto modo desconectado
'''  {Registrar, Modificar, Eliminar, Buscar, Consultar}
''' </summary>
''' <remarks>
'''  Esta clase es heredado de la clase Conexion  
''' </remarks>
''' <history>
'''  [Javier Huaman] 25/02/2015 Created
''' </history>
Public Class ProductoDesconectadoDAO
    Inherits Conexion
    Dim ds As New DataSet
    Public Function listaProductoDesconectado() As DataSet
        conectado()
        Using da As New SqlDataAdapter("ConsultarProducto", cn)
            da.Fill(ds, "Productos")
            ds.Tables("Productos").PrimaryKey = New DataColumn() {ds.Tables("Productos").Columns(0)}
            Return ds
        End Using
    End Function
    Public Function buscaProducto(ObjPro As CE.Producto) As DataRow
        Dim dr As DataRow = ds.Tables("Productos").Rows.Find(ObjPro.nombre)
        If dr Is Nothing Then
            MsgBox("El codigo cliente NO EXISTE !", "Sistema")
            Return dr
        Else
            Return dr
        End If
    End Function
    Public Function buscaStock(codigo As Integer) As Integer
        Dim dr As DataRow = ds.Tables("Productos").Rows.Find(codigo)
        If Not dr Is Nothing Then
            Return dr("prodStock")
        Else
            MsgBox("El codigo cliente NO EXISTE !")
            Return Nothing
        End If
    End Function
    Public Sub disminuyeStockDesconectado(codigo As Integer, cantidad As Integer)
        Dim dr As DataRow = Nothing
        dr = ds.Tables("Productos").Rows.Find(codigo)
        If Not dr Is Nothing Then
            dr("prodStock") = dr("prodStock") - cantidad
        Else
            MsgBox("El cliente NO EXISTE !", "Sistema")
        End If
    End Sub
    Public Sub aumentarStockDesconectado(codigo As Integer, cantidad As Integer)
        Dim dr As DataRow = Nothing
        dr = ds.Tables("Productos").Rows.Find(codigo)
        If Not dr Is Nothing Then
            dr("prodStock") = dr("prodStock") + cantidad
        Else
            MsgBox("El cliente NO EXISTE !", "Sistema")
        End If
    End Sub
    Public Function filtrado(codigo As Integer) As DataView

        Dim dv As DataView = ds.Tables("Productos").DefaultView
        dv.RowFilter = String.Format("catID ={0}", codigo)
        Return dv
    End Function
End Class
