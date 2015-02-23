Imports CE = capaEntidad
Imports System.Data.SqlClient
''' -----------------------------------------------
'''  Project: 
'''  Class: BoletaDAO
''' -----------------------------------------------
''' <summary>
'''  En esta clase se hace todo lo referenciado a la Boleta
'''  {Registrar, generarCodigo, listado}
''' </summary>
''' <remarks>
'''  Esta clase es heredado de la clase Conexion  
''' </remarks>
''' <history>
'''  [Javier Huaman] 22/02/2015 Created
''' </history>
Public Class BoletaDAO
    Inherits Conexion
    Public Function generaCodigo() As Integer
        conectado()
        Using cmd As New SqlCommand("generaCodigoBoleta", cn)
            Return cmd.ExecuteScalar + 1
        End Using
    End Function
    Public Sub registraBoleta(objBol As CE.Boleta)
        conectado()
        Using tr As SqlTransaction = cn.BeginTransaction(IsolationLevel.Serializable)
            Using cmd As New SqlCommand("InsertarBoleta", cn)
                cmd.CommandType = CommandType.StoredProcedure
                With cmd.Parameters
                    .Add("@bolFecha", SqlDbType.Date).Value = objBol.fecha
                    .Add("@bolID", SqlDbType.Int).Value = objBol.codBol
                    .Add("@cliID", SqlDbType.VarChar).Value = objBol.codCli
                    .Add("@bolTotal", SqlDbType.Decimal).Value = objBol.total
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
    Public Function listaBoleta() As DataSet
        conectado()
        Using da As New SqlDataAdapter("ConsultarBoleta", cn)
            Dim ds As New DataSet
            da.Fill(ds, "Boletas")
            Return ds
        End Using
    End Function
End Class
