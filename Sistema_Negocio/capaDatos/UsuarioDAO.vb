Imports CE = capaEntidad
Imports System.Data.SqlClient
''' -----------------------------------------------
'''  Project: 
'''  Class: UsuarioDAO
''' -----------------------------------------------
''' <summary>
'''  En esta clase se hace todo lo referenciado al
'''  mantenimiento del Usuario
'''  {Registrar, Modificar, Eliminar, Buscar, Consultar}
''' </summary>
''' <remarks>
'''  Esta clase es heredado de la clase Conexion  
''' </remarks>
''' <history>
'''  [Javier Huaman] 21/02/2015 Created
''' </history>
Public Class UsuarioDAO
    Inherits Conexion
    Public Sub registrarUsuario(ByVal objUsu As CE.Usuario)
        conectado()
        Using tr As SqlTransaction = cn.BeginTransaction(IsolationLevel.Serializable)
            Using cmd As New SqlCommand("InsertarUsuario", cn)
                cmd.CommandType = CommandType.StoredProcedure
                With cmd.Parameters
                    .Add("@usuNomAp", SqlDbType.VarChar).Value = objUsu.nombre
                    .Add("@usuCel", SqlDbType.Char).Value = objUsu.celular
                    .Add("@carID", SqlDbType.Int).Value = objUsu.cargo
                    .Add("@usuCorreo", SqlDbType.VarChar).Value = objUsu.correo
                    .Add("@usuDNI", SqlDbType.Char).Value = objUsu.nDNI
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
    Public Sub modificarUsuario(ByVal objUsu As CE.Usuario)
        conectado()
        Using tr As SqlTransaction = cn.BeginTransaction(IsolationLevel.Serializable)
            Using cmd As New SqlCommand("modificarUsuario", cn)
                cmd.CommandType = CommandType.StoredProcedure
                With cmd.Parameters
                    .Add("@usuID", SqlDbType.Int).Value = objUsu.idusuario
                    .Add("@usuNomAp", SqlDbType.VarChar).Value = objUsu.nombre
                    .Add("@usuCel", SqlDbType.Char).Value = objUsu.celular
                    .Add("@carID", SqlDbType.Int).Value = objUsu.cargo
                    .Add("@usuCorreo", SqlDbType.VarChar).Value = objUsu.correo
                    .Add("@usuDNI", SqlDbType.Char).Value = objUsu.nDNI
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
    Public Sub eliminaUsuario(objUsu As CE.Usuario)
        conectado()
        Using tr As SqlTransaction = cn.BeginTransaction(IsolationLevel.Serializable)
            Using cmd As New SqlCommand("EliminarUsuario", cn)
                cmd.CommandType = CommandType.StoredProcedure
                With cmd.Parameters
                    .Add("@usuID", SqlDbType.Int).Value = objUsu.idusuario
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
    Public Function listaCargo() As DataSet
        conectado()
        Using da As New SqlDataAdapter("ConsultarCargo", cn)
            Dim ds As New DataSet
            da.Fill(ds, "Cargos")
            Return ds
        End Using
    End Function
    Public Function listaUsuario() As DataSet
        conectado()
        Using da As New SqlDataAdapter("ConsultarUsuario", cn)
            Dim ds As New DataSet
            da.Fill(ds, "Usuarios")
            Return ds
        End Using
    End Function
    Public Function validaUsuario(usuario As String, password As String) As CE.Usuario
        Dim objUsuario As New CE.Usuario
        conectado()
        Using cmd As New SqlCommand("validaUsuario", cn)
            cmd.CommandType = CommandType.StoredProcedure
            With cmd.Parameters
                .Add("@usuario", SqlDbType.VarChar).Value = usuario
                .Add("@password", SqlDbType.VarChar).Value = password
            End With
            Try
                Dim dr As SqlDataReader = cmd.ExecuteReader()
                If dr.HasRows Then
                    Do While dr.Read()
                        objUsuario.idusuario = dr.GetInt32(0)
                        objUsuario.nDNI = dr.GetString(1)
                        objUsuario.nombre = dr.GetString(2)
                        objUsuario.correo = dr.GetString(3)
                        objUsuario.celular = dr.GetString(4)
                        objUsuario.usuario = dr.GetString(5)
                        objUsuario.password = dr.GetString(6)
                        objUsuario.cargo = dr.GetInt32(7)
                    Loop
                    Return objUsuario
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
