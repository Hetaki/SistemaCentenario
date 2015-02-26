Imports CE = capaEntidad
Imports System.Data.SqlClient
''' -----------------------------------------------
'''  Project: 
'''  Class: DetalleFacturaDAO
''' -----------------------------------------------
''' <summary>
'''  En esta clase se hace todo lo referenciado al Detalle_Factura
'''  {Registrar, listado}
''' </summary>
''' <remarks>
'''  Esta clase es heredado de la clase Conexion  
''' </remarks>
''' <history>
'''  [Javier Huaman] 22/02/2015 Created
''' </history>
Public Class DetalleFacturaDAO
    Inherits Conexion
    Public Sub registraDetalle_Factura(objDetalFac As CE.DetalleFactura)
        conectado()
        Using tr As SqlTransaction = cn.BeginTransaction(IsolationLevel.Serializable)
            Using cmd As New SqlCommand("InsertarDetalle_Factura", cn)
                cmd.CommandType = CommandType.StoredProcedure
                With cmd.Parameters
                    .Add("@Cant", SqlDbType.Decimal).Value = objDetalFac.cantidad
                    .Add("@FacID", SqlDbType.Int).Value = objDetalFac.idFac
                    .Add("@prodID", SqlDbType.Int).Value = objDetalFac.idProd
                    .Add("@punit", SqlDbType.Decimal).Value = objDetalFac.precioU
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
    Public Function listaDetalle_Factura(codigo As Integer) As DataSet
        conectado()
        Using da As New SqlDataAdapter("ConsultarDetalle_Factura", cn)
            da.SelectCommand.CommandType = CommandType.StoredProcedure
            da.SelectCommand.Parameters.Add("@FacID", SqlDbType.Int).Value = codigo
            Dim ds As New DataSet
            da.Fill(ds, "DetalleFacturas")
            Return ds
        End Using
    End Function

End Class
