Imports CE = capaEntidad
Imports System.Data.SqlClient
Public Class DetalleCompraDAO
    Inherits Conexion
    Public Sub registraDetalle_Compra(objDetalComp As CE.DetalleComprar)
        conectado()
        Using tr As SqlTransaction = cn.BeginTransaction(IsolationLevel.Serializable)
            Using cmd As New SqlCommand("InsertarDetalle_Compra", cn)
                cmd.CommandType = CommandType.StoredProcedure
                With cmd.Parameters
                    .Add("@compID", SqlDbType.Int).Value = objDetalComp.compID
                    .Add("@prodID", SqlDbType.Int).Value = objDetalComp.prodID
                    .Add("@dComCantidad", SqlDbType.Decimal).Value = objDetalComp.dComCantidad
                    .Add("@dCompUnit", SqlDbType.Decimal).Value = objDetalComp.dCompUnit
                    .Add("@dComDescuento", SqlDbType.Decimal).Value = objDetalComp.dCompDescuento
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
    Public Function listaDetalle_Compra(codigo As Integer) As DataSet
        conectado()
        Using da As New SqlDataAdapter("ConsultarDetalle_Compra", cn)
            da.SelectCommand.CommandType = CommandType.StoredProcedure
            da.SelectCommand.Parameters.Add("@comID", SqlDbType.Int).Value = codigo
            Dim ds As New DataSet
            da.Fill(ds, "DetalleCompras")
            Return ds
        End Using
    End Function

End Class
