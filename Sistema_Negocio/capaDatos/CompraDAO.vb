Imports CE = capaEntidad
Imports System.Data.SqlClient
''' -----------------------------------------------
'''  Project: 
'''  Class: CompraDAO
''' -----------------------------------------------
''' <summary>
'''  En esta clase se hace todo lo referenciado a la Compra
'''  {Registrar, generarCodigo(anular - de forma manual), listado}
''' </summary>
''' <remarks>
'''  Esta clase es heredado de la clase Conexion  
''' </remarks>
''' <history>
'''  [Jason Fuentes] 24/02/2015 Created
''' </history>
Public Class CompraDAO
    Inherits Conexion
    Public Function generaCodigo() As Integer
        conectado()
        Using cmd As New SqlCommand("generaCodigoCompra", cn)
            Return cmd.ExecuteScalar + 1
        End Using
    End Function
    Public Sub registraCompra(objCom As CE.Compra)
        conectado()
        Using tr As SqlTransaction = cn.BeginTransaction(IsolationLevel.Serializable)
            Using cmd As New SqlCommand("InsertarCompra", cn)
                cmd.CommandType = CommandType.StoredProcedure
                With cmd.Parameters
                    .Add("@compID", SqlDbType.Int).Value = objCom.compID
                    .Add("@compTotal", SqlDbType.Decimal).Value = objCom.compTotal
                    .Add("@compFecha", SqlDbType.Date).Value = objCom.compfecha
                    .Add("@compCondicionPag", SqlDbType.VarChar).Value = objCom.compCondicionPag
                    .Add("@compNumeroFactura", SqlDbType.VarChar).Value = objCom.compNumeroFactura
                    .Add("@provID ", SqlDbType.Int).Value = objCom.provID
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
    Public Function listaCompra() As DataSet
        conectado()
        Using da As New SqlDataAdapter("ConsultarCompra", cn)
            Dim ds As New DataSet
            da.Fill(ds, "Compras")
            Return ds
        End Using
    End Function
End Class
