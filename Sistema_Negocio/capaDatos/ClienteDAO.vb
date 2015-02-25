Imports CE = capaEntidad
Imports System.Data.SqlClient
''' -----------------------------------------------
'''  Project: 
'''  Class: ClienteDAO
''' -----------------------------------------------
''' <summary>
'''  En esta clase se hace todo lo referenciado al
''' mantenimiento del Cliente
'''  {Registrar, Modificar, Eliminar, Buscar, Consultar}
''' </summary>
''' <remarks>
'''  Esta clase es heredado de la clase Conexion  
''' </remarks>
''' <history>
'''  [Javier Huaman] 21/02/2015 Created
''' </history>
Public Class ClienteDAO
    Inherits Conexion
    Public Sub registraCliente(objCli As CE.Cliente)
        conectado()
        Using tr As SqlTransaction = cn.BeginTransaction(IsolationLevel.Serializable)
            Using cmd As New SqlCommand("InsertarCliente", cn)
                cmd.CommandType = CommandType.StoredProcedure
                With cmd.Parameters
                    .Add("@cliCEl", SqlDbType.Char).Value = objCli.celular
                    .Add("@cliDir", SqlDbType.VarChar).Value = objCli.direccion
                    .Add("@cliDNI", SqlDbType.Char).Value = objCli.dni
                    .Add("@cliNomAp", SqlDbType.VarChar).Value = objCli.nombre
                    .Add("@cliDirRef", SqlDbType.VarChar).Value = objCli.referencia
                    .Add("@cliRUC", SqlDbType.Char).Value = objCli.ruc
                    .Add("@cliTelf", SqlDbType.Char).Value = objCli.telefono
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
    Public Sub modificarCliente(objCli As CE.Cliente)
        conectado()
        Using tr As SqlTransaction = cn.BeginTransaction(IsolationLevel.Serializable)
            Using cmd As New SqlCommand("modificarCliente", cn)
                cmd.CommandType = CommandType.StoredProcedure
                With cmd.Parameters
                    .Add("@cliID", SqlDbType.Int).Value = objCli.codCli
                    .Add("@cliCEl", SqlDbType.Char).Value = objCli.celular
                    .Add("@cliDir", SqlDbType.VarChar).Value = objCli.direccion
                    .Add("@cliDNI", SqlDbType.Char).Value = objCli.dni
                    .Add("@cliNomAp", SqlDbType.VarChar).Value = objCli.nombre
                    .Add("@cliDirRef", SqlDbType.VarChar).Value = objCli.referencia
                    .Add("@cliRUC", SqlDbType.Char).Value = objCli.ruc
                    .Add("@cliTelf", SqlDbType.Char).Value = objCli.telefono
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
    Public Function listaCliente() As DataSet
        conectado()
        Using da As New SqlDataAdapter("ConsultarCliente", cn)
            Dim ds As New DataSet
            da.Fill(ds, "Clientes")
            Return ds
        End Using
    End Function
    Public Sub eliminaCliente(ObjCli As CE.Cliente)
        conectado()
        Using tr As SqlTransaction = cn.BeginTransaction(IsolationLevel.Serializable)
            Using cmd As New SqlCommand("EliminarCliente", cn)
                cmd.CommandType = CommandType.StoredProcedure
                With cmd.Parameters
                    .Add("@cliID", SqlDbType.Int).Value = ObjCli.codCli
                End With
                cmd.Transaction = tr
                Try
                    cmd.ExecuteNonQuery()
                    tr.Commit()
                Catch ex As Exception
                    MsgBox("No se puede eliminar porque esta siendo usado en Boleta /Pedido /Factura")
                    tr.Rollback()
                Finally
                    desconectado()
                End Try
            End Using
        End Using
    End Sub
    Public Function buscaClientexDNI(dni As String) As CE.Cliente
        Dim objCli As New CE.Cliente
        conectado()
        Using cmd As New SqlCommand("BuscarClientexDNI", cn)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add("@cliDNI", SqlDbType.Char).Value = dni
            Try
                Dim dr As SqlDataReader = cmd.ExecuteReader()
                If dr.HasRows Then
                    Do While dr.Read()
                        objCli.codCli = dr.GetInt32(0)
                        objCli.dni = dr.GetString(1)
                        objCli.ruc = dr.GetString(2)
                        objCli.nombre = dr.GetString(3)
                        objCli.celular = dr.GetString(4)
                        objCli.telefono = dr.GetString(5)
                        objCli.direccion = dr.GetString(6)
                        objCli.referencia = dr.GetString(7)
                    Loop
                    Return objCli
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
    Public Function buscaClientexRUC(ruc As String) As CE.Cliente
        Dim objCli As New CE.Cliente
        conectado()
        Using cmd As New SqlCommand("BuscarClientexRUC", cn)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add("@cliRUC", SqlDbType.Char).Value = ruc
            Try
                Dim dr As SqlDataReader = cmd.ExecuteReader()
                If dr.HasRows Then
                    Do While dr.Read()
                        objCli.codCli = dr.GetInt32(0)
                        objCli.dni = dr.GetString(1)
                        objCli.ruc = dr.GetString(2)
                        objCli.nombre = dr.GetString(3)
                        objCli.celular = dr.GetString(4)
                        objCli.telefono = dr.GetString(5)
                        objCli.direccion = dr.GetString(6)
                        objCli.referencia = dr.GetString(7)
                    Loop
                    Return objCli
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
End Class
