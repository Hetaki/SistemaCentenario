Imports CE = capaEntidad
Imports System.Data.SqlClient
''' -----------------------------------------------
'''  Project: 
'''  Class: DetalleBoletaDAO
''' -----------------------------------------------
''' <summary>
'''  En esta clase se hace todo lo referenciado al Detalle_Boleta
'''  {Registrar, listado}
''' </summary>
''' <remarks>
'''  Esta clase es heredado de la clase Conexion  
''' </remarks>
''' <history>
'''  [Javier Huaman] 22/02/2015 Created
''' </history>
Public Class DetalleBoletaDAO
    Inherits Conexion
    Public Sub registraDetalle_Boleta(objDetalBol As CE.DetalleBoleta)
        conectado()
        Using tr As SqlTransaction = cn.BeginTransaction(IsolationLevel.Serializable)
            Using cmd As New SqlCommand("InsertarDetalle_Boleta", cn)
                cmd.CommandType = CommandType.StoredProcedure
                With cmd.Parameters
                    .Add("@cantidad", SqlDbType.Decimal).Value = objDetalBol.cantidad
                    .Add("@bolID", SqlDbType.Int).Value = objDetalBol.idBol
                    .Add("@prodID", SqlDbType.Int).Value = objDetalBol.idProd
                    .Add("@punit", SqlDbType.Decimal).Value = objDetalBol.precioU
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
    Public Function listaDetalle_Boleta(codigo As Integer) As DataSet
        conectado()
        Using da As New SqlDataAdapter("ConsultarDetalle_Boleta", cn)
            da.SelectCommand.CommandType = CommandType.StoredProcedure
            da.SelectCommand.Parameters.Add("@bolID", SqlDbType.Int).Value = codigo
            Dim ds As New DataSet
            da.Fill(ds, "DetalleBoletas")
            Return ds
        End Using
    End Function


End Class
