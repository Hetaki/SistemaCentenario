Imports CE = capaEntidad
Imports System.Data.SqlClient
''' -----------------------------------------------
'''  Project: 
'''  Class: PedidoDAO
''' -----------------------------------------------
''' <summary>
'''  En esta clase se hace todo lo referenciado a la Pedido
'''  {Registrar, generarCodigo, listado}
''' </summary>
''' <remarks>
'''  Esta clase es heredado de la clase Conexion  
''' </remarks>
''' <history>
'''  [Javier Huaman] 22/02/2015 Created
''' </history>
Public Class PedidoDAO
    Inherits Conexion
    Public Function generaCodigo() As Integer
        conectado()
        Using cmd As New SqlCommand("generaCodigoPedido", cn)
            Return cmd.ExecuteScalar + 1
        End Using
    End Function
    Public Sub registraPedido(objPed As CE.Pedido)
        conectado()
        Using tr As SqlTransaction = cn.BeginTransaction(IsolationLevel.Serializable)
            Using cmd As New SqlCommand("InsertarPedido", cn)
                cmd.CommandType = CommandType.StoredProcedure
                With cmd.Parameters
                    .Add("@PedFecha", SqlDbType.Date).Value = objPed.fecha
                    .Add("@PedID", SqlDbType.Int).Value = objPed.codPed
                    .Add("@cliID", SqlDbType.VarChar).Value = objPed.codCli
                    .Add("@PedTotal", SqlDbType.Decimal).Value = objPed.total
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
    Public Function listaPedido() As DataSet
        conectado()
        Using da As New SqlDataAdapter("ConsultarPedido", cn)
            Dim ds As New DataSet
            da.Fill(ds, "Pedidos")
            Return ds
        End Using
    End Function
End Class
