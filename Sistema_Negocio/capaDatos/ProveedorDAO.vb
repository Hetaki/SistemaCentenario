Imports CE = capaEntidad
Imports System.Data.SqlClient
''' -----------------------------------------------
'''  Project: 
'''  Class: ProveedorDAO
''' -----------------------------------------------
''' <summary>
'''  En esta clase se hace todo lo referenciado al
'''  mantenimiento del Proveedor
'''  {Registrar, Modificar, Eliminar, Buscar, Consultar}
''' </summary>
''' <remarks>
'''  Esta clase es heredado de la clase Conexion  
''' </remarks>
''' <history>
'''  [Javier Huaman] 21/02/2015 Created
''' </history>
Public Class ProveedorDAO
    Inherits Conexion
    Public Sub registraProveedor(objProv As CE.Proveedor)
        conectado()
        Using tr As SqlTransaction = cn.BeginTransaction(IsolationLevel.Serializable)
            Using cmd As New SqlCommand("InsertarProveedor", cn)
                cmd.CommandType = CommandType.StoredProcedure
                With cmd.Parameters
                    .Add("@provDir", SqlDbType.Char).Value = objProv.direccion
                    .Add("@provDNI", SqlDbType.Char).Value = objProv.dni
                    .Add("@provNom", SqlDbType.Char).Value = objProv.nombre
                    .Add("@provCorreo", SqlDbType.Char).Value = objProv.correo
                    .Add("@provRuc", SqlDbType.Char).Value = objProv.ruc
                    .Add("@provTelf", SqlDbType.Char).Value = objProv.telefono
                End With
                cmd.Transaction = tr
                Try
                    cmd.ExecuteNonQuery()
                    tr.Commit()
                    MsgBox("Se registro Correctamente", MsgBoxStyle.Information)
                Catch ex As Exception
                    MsgBox(ex.Message)
                    tr.Rollback()
                Finally
                    desconectado()
                End Try
            End Using
        End Using
    End Sub
    Public Sub modificarProveedor(objProv As CE.Proveedor)
        conectado()
        Using tr As SqlTransaction = cn.BeginTransaction(IsolationLevel.Serializable)
            Using cmd As New SqlCommand("modificarProveedor", cn)
                cmd.CommandType = CommandType.StoredProcedure
                With cmd.Parameters
                    .Add("@provID", SqlDbType.Char).Value = objProv.codProv
                    .Add("@provDir", SqlDbType.Char).Value = objProv.direccion
                    .Add("@provDNI", SqlDbType.Char).Value = objProv.dni
                    .Add("@provNom", SqlDbType.Char).Value = objProv.nombre
                    .Add("@provCorreo", SqlDbType.Char).Value = objProv.correo
                    .Add("@provRuc", SqlDbType.Char).Value = objProv.ruc
                    .Add("@provTelf", SqlDbType.Char).Value = objProv.telefono
                End With
                cmd.Transaction = tr
                Try
                    cmd.ExecuteNonQuery()
                    tr.Commit()
                    MsgBox("Se modifico Correctamente", MsgBoxStyle.Information)
                Catch ex As Exception
                    MsgBox(ex.Message)
                    tr.Rollback()
                Finally
                    desconectado()
                End Try
            End Using
        End Using
    End Sub
    Public Function listaProveedor() As DataSet
        conectado()
        Using da As New SqlDataAdapter("ConsultarProveedor", cn)
            Dim ds As New DataSet
            da.Fill(ds, "Proveedores")
            Return ds
        End Using
    End Function
    Public Sub eliminaProveedor(objProv As CE.Proveedor)
        conectado()
        Using tr As SqlTransaction = cn.BeginTransaction(IsolationLevel.Serializable)
            Using cmd As New SqlCommand("EliminarProveedor", cn)
                cmd.CommandType = CommandType.StoredProcedure
                With cmd.Parameters
                    .Add("@provID", SqlDbType.Int).Value = objProv.codProv
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
    Public Function buscaProveedor(codProveedor As Integer) As CE.Proveedor
        Dim objProv As New CE.Proveedor
        conectado()
        Using cmd As New SqlCommand("BuscarProveedor", cn)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add("@provID", SqlDbType.Int).Value = codProveedor
            Try
                Dim dr As SqlDataReader = cmd.ExecuteReader()
                If dr.HasRows Then
                    Do While dr.Read()
                        objProv.codProv = dr.GetInt32(0)
                        objProv.ruc = dr.GetString(1)
                        objProv.dni = dr.GetInt32(2)
                        objProv.nombre = dr.GetString(3)
                        objProv.direccion = dr.GetString(4)
                        objProv.telefono = dr.GetString(5)
                        objProv.correo = dr.GetString(6)
                    Loop
                    Return objProv
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
    Public Function buscaProvxDNI(dni As String) As CE.Proveedor
        Dim objProv As New CE.Proveedor
        conectado()
        Using cmd As New SqlCommand("BuscarProveedorxDNI", cn)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add("@provDNI", SqlDbType.VarChar).Value = dni
            Try
                Dim dr As SqlDataReader = cmd.ExecuteReader()
                If dr.HasRows Then
                    Do While dr.Read()
                        objProv.codProv = dr.GetInt32(0)
                        objProv.dni = dr.GetString(1)
                        objProv.ruc = dr.GetString(2)
                        objProv.nombre = dr.GetString(3)
                        objProv.direccion = dr.GetString(4)
                        objProv.telefono = dr.GetString(5)
                        objProv.correo = dr.GetString(6)
                    Loop
                    Return objProv
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
    Public Function buscaProvxRUC(ruc As String) As CE.Proveedor
        Dim objProv As New CE.Proveedor
        conectado()
        Using cmd As New SqlCommand("BuscarProveedorxRUC", cn)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add("@ProvRUC", SqlDbType.Char).Value = ruc
            Try
                Dim dr As SqlDataReader = cmd.ExecuteReader()
                If dr.HasRows Then
                    Do While dr.Read()
                        objProv.codProv = dr.GetInt32(0)
                        objProv.dni = dr.GetString(1)
                        objProv.ruc = dr.GetString(2)
                        objProv.nombre = dr.GetString(3)
                        objProv.direccion = dr.GetString(4)
                        objProv.telefono = dr.GetString(5)
                        objProv.correo = dr.GetString(6)
                    Loop
                    Return objProv
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
