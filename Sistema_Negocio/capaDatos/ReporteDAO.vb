Imports System.Data.SqlClient

Public Class ReporteDAO
    Inherits Conexion

    Public Function listaReporteBoleta(cliID As Integer) As DataSet
        conectado()

        Using cmd As New SqlCommand("Consulta_Boleta_Cliente", cn)
            cmd.CommandType = CommandType.StoredProcedure
            With cmd.Parameters
                .Add("@clienteID", SqlDbType.Int).Value = cliID
            End With
            Using da As New SqlDataAdapter
                da.SelectCommand = cmd
                Dim ds As New DataSet
                da.Fill(ds, "Reporte_Boleta")
                Return ds
            End Using
        End Using
    End Function
    Public Function listaReporteFactura(cliID As Integer) As DataSet
        conectado()

        Using cmd As New SqlCommand("Consulta_Factura_Cliente", cn)
            cmd.CommandType = CommandType.StoredProcedure
            With cmd.Parameters
                .Add("@clienteID", SqlDbType.Int).Value = cliID
            End With
            Using da As New SqlDataAdapter
                da.SelectCommand = cmd
                Dim ds As New DataSet
                da.Fill(ds, "Reporte_Factura")
                Return ds
            End Using
        End Using
    End Function
    Public Function listaReportePedido(cliID As Integer) As DataSet
        conectado()

        Using cmd As New SqlCommand("Consulta_Pedido_Cliente", cn)
            cmd.CommandType = CommandType.StoredProcedure
            With cmd.Parameters
                .Add("@clienteID", SqlDbType.Int).Value = cliID
            End With
            Using da As New SqlDataAdapter
                da.SelectCommand = cmd
                Dim ds As New DataSet
                da.Fill(ds, "Reporte_Pedido")
                Return ds
            End Using
        End Using
    End Function
End Class
