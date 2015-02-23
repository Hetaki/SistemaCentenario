Imports CE = capaEntidad
Imports System.Data.SqlClient
Public Class DetalleBoletaDAO
    Inherits Conexion
    Public Sub registraDetalle_Boleta(objDetalBol As CE.DetalleBoleta)
        conectado()
        Using tr As SqlTransaction = cn.BeginTransaction(IsolationLevel.Serializable)
            Using cmd As New SqlCommand("Detalle_Boleta", cn)
                cmd.CommandType = CommandType.StoredProcedure
                With cmd.Parameters
                    .Add("@cantidad", SqlDbType.Date).Value = objDetalBol.cantidad
                    .Add("@bolID", SqlDbType.Int).Value = objDetalBol.idBol
                    .Add("@prodID", SqlDbType.VarChar).Value = objDetalBol.idProd
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
    Public Function listaDetalle_Boleta() As DataSet
        conectado()
        Using da As New SqlDataAdapter("ConsultarBoleta", cn)
            Dim ds As New DataSet
            da.Fill(ds, "DetalleBoletas")
            Return ds
        End Using
    End Function


End Class
