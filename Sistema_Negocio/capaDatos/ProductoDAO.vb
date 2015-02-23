Imports CE = capaEntidad
Imports System.Data.SqlClient
''' -----------------------------------------------
'''  Project: 
'''  Class: ProductoDAO
''' -----------------------------------------------
''' <summary>
'''  En esta clase se hace todo lo referenciado al
'''  mantenimiento del Producto
'''  {Registrar, Modificar, Eliminar, Buscar, Consultar}
''' </summary>
''' <remarks>
'''  Esta clase es heredado de la clase Conexion  
''' </remarks>
''' <history>
'''  [Javier Huaman] 22/02/2015 Created
''' </history>
Public Class ProductoDAO
    Inherits Conexion
    Public Sub registraCategoria(descripcion As String)
        conectado()
        Using tr As SqlTransaction = cn.BeginTransaction(IsolationLevel.Serializable)
            Using cmd As New SqlCommand("InsertarCategoria", cn)
                cmd.CommandType = CommandType.StoredProcedure
                With cmd.Parameters
                    .Add("@catDesc", SqlDbType.VarChar).Value = descripcion
                End With
                cmd.Transaction = tr
                Try
                    cmd.ExecuteNonQuery()
                    tr.Commit()
                Catch ex As Exception
                    MsgBox(ex.Message)
                    tr.Rollback()
                Finally
                    desconectado()
                End Try
            End Using
        End Using
    End Sub
    Public Sub registraProducto(objProd As CE.Producto)
        conectado()
        Using tr As SqlTransaction = cn.BeginTransaction(IsolationLevel.Serializable)
            Using cmd As New SqlCommand("InsertarProducto", cn)
                cmd.CommandType = CommandType.StoredProcedure
                With cmd.Parameters
                    .Add("@fechaIng", SqlDbType.Date).Value = objProd.fecha
                    .Add("@prodID", SqlDbType.Int).Value = objProd.codPro
                    .Add("@prodNom", SqlDbType.VarChar).Value = objProd.nombre
                    .Add("@prodStock", SqlDbType.Decimal).Value = objProd.stock
                    .Add("@prodPreCom", SqlDbType.Decimal).Value = objProd.precioCompra
                    .Add("@prodPreVen", SqlDbType.Decimal).Value = objProd.precioVenta
                    .Add("@ubicacion", SqlDbType.VarChar).Value = objProd.ubicacion
                    .Add("@catID", SqlDbType.Int).Value = objProd.categoria
                End With
                cmd.Transaction = tr
                Try
                    cmd.ExecuteNonQuery()
                    tr.Commit()
                Catch ex As Exception
                    MsgBox(ex.Message)
                    tr.Rollback()
                Finally
                    desconectado()
                End Try
            End Using
        End Using
    End Sub
    Public Sub modificarProducto(objProd As CE.Producto)
        conectado()
        Using tr As SqlTransaction = cn.BeginTransaction(IsolationLevel.Serializable)
            Using cmd As New SqlCommand("modificarProducto", cn)
                cmd.CommandType = CommandType.StoredProcedure
                With cmd.Parameters
                    .Add("@fechaIng", SqlDbType.Date).Value = objProd.fecha
                    .Add("@prodID", SqlDbType.Int).Value = objProd.codPro
                    .Add("@prodNom", SqlDbType.VarChar).Value = objProd.nombre
                    .Add("@prodStock", SqlDbType.Decimal).Value = objProd.stock
                    .Add("@prodPreCom", SqlDbType.Decimal).Value = objProd.precioCompra
                    .Add("@prodPreVen", SqlDbType.Decimal).Value = objProd.precioVenta
                    .Add("@ubicacion", SqlDbType.VarChar).Value = objProd.ubicacion
                    .Add("@catID", SqlDbType.Int).Value = objProd.categoria
                End With
                cmd.Transaction = tr
                Try
                    cmd.ExecuteNonQuery()
                    tr.Commit()
                Catch ex As Exception
                    MsgBox(ex.Message)
                    tr.Rollback()
                Finally
                    desconectado()
                End Try
            End Using
        End Using
    End Sub
    Public Function listaCategoria() As DataSet
        conectado()
        Using da As New SqlDataAdapter("ConsultarCategoria", cn)
            Dim ds As New DataSet
            da.Fill(ds, "Categorias")
            Return ds
        End Using
    End Function
    Public Function listaProductoxCategoria(id As Integer) As Integer
        conectado()
        Using cmd As New SqlCommand("BuscarProductoxCategoria", cn)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add("@catID", SqlDbType.Int).Value = id
            Return cmd.ExecuteScalar
        End Using
    End Function
    Public Function listaProductoxCategoria_Nombre(cat As Integer, descripcion As String) As DataSet
        conectado()
        Using cmd As New SqlCommand("ConsultarProductoxCat_Nom", cn)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add("@catID", SqlDbType.Int).Value = cat
            cmd.Parameters.Add("@prodNom", SqlDbType.VarChar).Value = descripcion
            Using da As New SqlDataAdapter
                da.SelectCommand = cmd
                Dim ds As New DataSet
                da.Fill(ds, "Productos_nombre")
                Return ds
            End Using
        End Using
    End Function
    Public Function listaProducto() As DataSet
        conectado()
        Using da As New SqlDataAdapter("ConsultarProducto", cn)
            Dim ds As New DataSet
            da.Fill(ds, "Productos")
            Return ds
        End Using
    End Function
    Public Sub eliminaProducto(objProd As CE.Producto)
        conectado()
        Using tr As SqlTransaction = cn.BeginTransaction(IsolationLevel.Serializable)
            Using cmd As New SqlCommand("EliminarProducto", cn)
                cmd.CommandType = CommandType.StoredProcedure
                With cmd.Parameters
                    .Add("@provID", SqlDbType.Int).Value = objProd.codPro
                End With
                cmd.Transaction = tr
                Try
                    cmd.ExecuteNonQuery()
                    tr.Commit()
                Catch ex As Exception
                    tr.Rollback()
                Finally
                    desconectado()
                End Try
            End Using
        End Using
    End Sub
    Public Function buscaProducto(codProducto As Integer) As CE.Producto
        Dim objProd As New CE.Producto
        conectado()
        Using cmd As New SqlCommand("BuscarProducto", cn)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add("@provID", SqlDbType.Int).Value = codProducto
            Try
                Dim dr As SqlDataReader = cmd.ExecuteReader()
                If dr.HasRows Then
                    Do While dr.Read()
                        objProd.codPro = dr.GetInt32(0)
                        objProd.nombre = dr.GetString(1)
                        objProd.stock = dr.GetDecimal(2)
                        objProd.precioCompra = dr.GetDecimal(3)
                        objProd.precioVenta = dr.GetDecimal(4)
                        objProd.ubicacion = dr.GetString(5)
                        objProd.categoria = dr.GetInt32(6)
                    Loop
                    Return objProd
                Else
                    Return Nothing
                End If

            Catch ex As Exception
                MsgBox(ex.Message)
                Return Nothing
            Finally
                desconectado()
            End Try
        End Using
    End Function

    Public Function disminuir_stock(idProd As Integer, cantidad As Integer) As Boolean
        Try
            conectado()
            Using cmd As New SqlCommand("disminuir_stock", cn)
                cmd.CommandType = CommandType.StoredProcedure
                With cmd.Parameters
                    .Add("@prodID", SqlDbType.Int).Value = idProd
                    .Add("@cantidad", SqlDbType.Int).Value = cantidad
                End With
                If cmd.ExecuteNonQuery Then
                    Return True
                Else
                    Return False
                End If
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            desconectado()
        End Try
    End Function

    Public Function aumentar_stock(idProd As Integer, cantidad As Integer) As Boolean
        Try
            conectado()
            Using cmd As New SqlCommand("aumentar_stock", cn)
                cmd.CommandType = CommandType.StoredProcedure
                With cmd.Parameters
                    .Add("@prodID", SqlDbType.Int).Value = idProd
                    .Add("@cantidad", SqlDbType.Int).Value = cantidad
                End With
                If cmd.ExecuteNonQuery Then
                    Return True
                Else
                    Return False
                End If
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            desconectado()
        End Try
    End Function
End Class
