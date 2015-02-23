Imports System.Data.SqlClient
Imports System.Configuration.ConfigurationManager
''' -----------------------------------------------
'''  Project: 
'''  Class: Conexion
''' -----------------------------------------------
''' <summary>
'''  La clase Conexion contiene una funcion
''' </summary>
''' <remarks>
'''  Si necesitas la clase Conexion se tiene que referenciar
'''  con su respectiva funcion
''' </remarks>
''' <history>
'''  [Javier Huaman] 20/02/2015 Created
''' </history>
Public Class Conexion
    Protected cn As New SqlConnection
    ''' ----------------------------------
    ''' <summary>
    '''  Se conecta a la base de datos
    ''' </summary>
    ''' <returns>
    '''  Retorna Boolean {False or True}
    ''' </returns>
    ''' <remarks></remarks>
    ''' <history>
    '''  [Javier Huaman] 20/02/2015 Created
    ''' </history>
    ''' ----------------------------------
    Protected Function conectado()
        Try
            cn = New SqlConnection(ConnectionStrings("cn").ConnectionString)
            cn.Open()
            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function
    ''' ----------------------------------
    ''' <summary>
    '''  Se desconecta de la base de datos
    ''' </summary>
    ''' <returns>
    '''  Retorna Boolean {False or True}
    ''' </returns>
    ''' <remarks></remarks>
    ''' <history>
    '''  [Javier Huaman] 20/02/2015 Created
    ''' </history>
    ''' --------------------------------    
    Protected Function desconectado()
        Try
            If cn.State = ConnectionState.Open Then
                cn.Close()
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function
End Class
