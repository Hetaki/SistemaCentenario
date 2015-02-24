Imports CE = capaEntidad
Imports System.Data.SqlClient
''' -----------------------------------------------
'''  Project: 
'''  Class: DetallePedidoDAO
''' -----------------------------------------------
''' <summary>
'''  En esta clase se hace todo lo referenciado al Detalle_Pedido
'''  {Registrar, listado}
''' </summary>
''' <remarks>
'''  Esta clase es heredado de la clase Conexion  
''' </remarks>
''' <history>
'''  [Javier Huaman] 22/02/2015 Created
''' </history>
Public Class DetallePedidoDAO
    Inherits Conexion
    Public Sub registraDetalle_Pedido(objDetalPed As CE.DetallePedido)
        conectado()
        Using tr As SqlTransaction = cn.BeginTransaction(IsolationLevel.Serializable)
            Using cmd As New SqlCommand("InsertarDetalle_Pedido", cn)
                cmd.CommandType = CommandType.StoredProcedure
                With cmd.Parameters
                    .Add("@cantidad", SqlDbType.Decimal).Value = objDetalPed.cantidad
                    .Add("@PedID", SqlDbType.Int).Value = objDetalPed.idPed
                    .Add("@prodID", SqlDbType.Int).Value = objDetalPed.idProd
                    .Add("@punit", SqlDbType.Decimal).Value = objDetalPed.precioU
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
    Public Function listaDetalle_Pedido(codigo As Integer) As DataSet
        conectado()
        Using da As New SqlDataAdapter("ConsultarDetalle_Pedido", cn)
            da.SelectCommand.CommandType = CommandType.StoredProcedure
            da.SelectCommand.Parameters.Add("@PedID", SqlDbType.Int).Value = codigo
            Dim ds As New DataSet
            da.Fill(ds, "DetallePedidos")
            Return ds
        End Using
    End Function

End Class
