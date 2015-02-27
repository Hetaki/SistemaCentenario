Imports System.Data.SqlClient

Public Class ReporteDAO
    Inherits Conexion

    Public Function listaReporteBoleta(cliID As Integer) As DataSet
        conectado()

        Using cmd As New SqlCommand("Consulta_Boleta_Cliente", cn)
            cmd.CommandType = CommandType.StoredProcedure
            With cmd.Parameters
                .Add("@clienteID", SqlDbType.VarChar).Value = cliID
            End With
            Using da As New SqlDataAdapter
                da.SelectCommand = cmd
                Dim ds As New DataSet
                da.Fill(ds, "Reporte_Boleta")
                Return ds
            End Using
        End Using
    End Function

End Class
