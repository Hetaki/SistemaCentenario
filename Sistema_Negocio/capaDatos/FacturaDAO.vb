Imports CE = capaEntidad
Imports System.Data.SqlClient
''' -----------------------------------------------
'''  Project: 
'''  Class: FacturaDAO
''' -----------------------------------------------
''' <summary>
'''  En esta clase se hace todo lo referenciado a la Factura
'''  {Registrar, generarCodigo, listado}
''' </summary>
''' <remarks>
'''  Esta clase es heredado de la clase Conexion  
''' </remarks>
''' <history>
'''  [Javier Huaman] 22/02/2015 Created
''' </history>
Public Class FacturaDAO
    Inherits Conexion
    Public Function generaCodigo() As Integer
        conectado()
        Using cmd As New SqlCommand("generaCodigoFactura", cn)
            Return cmd.ExecuteScalar + 1
        End Using
    End Function
    Public Sub registraFactura(objFac As CE.Factura)
        conectado()
        Using tr As SqlTransaction = cn.BeginTransaction(IsolationLevel.Serializable)
            Using cmd As New SqlCommand("InsertarFactura", cn)
                cmd.CommandType = CommandType.StoredProcedure
                With cmd.Parameters
                    .Add("@facFecha", SqlDbType.Date).Value = objFac.fecha
                    .Add("@facID", SqlDbType.Int).Value = objFac.codFac
                    .Add("@cliID", SqlDbType.VarChar).Value = objFac.codCli
                    .Add("@facSubTotal", SqlDbType.Decimal).Value = objFac.total
                    .Add("@facIGV", SqlDbType.Decimal).Value = objFac.igv
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
    Public Function listaFactura() As DataSet
        conectado()
        Using da As New SqlDataAdapter("ConsultarFactura", cn)
            Dim ds As New DataSet
            da.Fill(ds, "Facturas")
            Return ds
        End Using
    End Function
End Class
