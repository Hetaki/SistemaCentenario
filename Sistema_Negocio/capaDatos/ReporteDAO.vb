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
    Public Function listaReporteCompra(cliID As Integer) As DataSet
        conectado()

        Using cmd As New SqlCommand("Consulta_Compra_Proveedor", cn)
            cmd.CommandType = CommandType.StoredProcedure
            With cmd.Parameters
                .Add("@proveedorID", SqlDbType.Int).Value = cliID
            End With
            Using da As New SqlDataAdapter
                da.SelectCommand = cmd
                Dim ds As New DataSet
                da.Fill(ds, "Reporte_Compra")
                Return ds
            End Using
        End Using
    End Function
    'TODO: Se tiene que modificar el procedimiento.
    Public Function listaReporteBoletaPorFecha(desde As String, hasta As String) As DataSet
        conectado()
        Using cmd As New SqlCommand("Consulta_Compra_Proveedor", cn)
            cmd.CommandType = CommandType.StoredProcedure
            With cmd.Parameters
                .Add("@desde", SqlDbType.Date).Value = desde
                .Add("@hasta", SqlDbType.Date).Value = hasta
            End With
            Using da As New SqlDataAdapter
                da.SelectCommand = cmd
                Dim ds As New DataSet
                da.Fill(ds, "Reporte_BoletaFecha")
                Return ds
            End Using
        End Using
    End Function
    Public Function ReporteFechaBoleta(desde As String, hasta As String) As DataSet
        conectado()

        Using cmd As New SqlCommand("Reporte_Boleta_Fecha", cn)
            cmd.CommandType = CommandType.StoredProcedure
            With cmd.Parameters
                .Add("@desde", SqlDbType.Date).Value = desde
                .Add("@hasta", SqlDbType.Date).Value = hasta
            End With
            Using da As New SqlDataAdapter
                da.SelectCommand = cmd
                Dim ds As New DataSet
                da.Fill(ds, "ReporteBoletaFecha")
                Return ds
            End Using
        End Using
    End Function

    Public Function ReporteFechaFactura(desde As String, hasta As String) As DataSet
        conectado()

        Using cmd As New SqlCommand("Reporte_Factura_Fecha", cn)
            cmd.CommandType = CommandType.StoredProcedure
            With cmd.Parameters
                .Add("@desde", SqlDbType.Date).Value = desde
                .Add("@hasta", SqlDbType.Date).Value = hasta
            End With
            Using da As New SqlDataAdapter
                da.SelectCommand = cmd
                Dim ds As New DataSet
                da.Fill(ds, "ReporteFacturaFecha")
                Return ds
            End Using
        End Using
    End Function
    Public Function ReporteFechaPedido(desde As String, hasta As String) As DataSet
        conectado()

        Using cmd As New SqlCommand("Reporte_pedido_Fecha", cn)
            cmd.CommandType = CommandType.StoredProcedure
            With cmd.Parameters
                .Add("@desde", SqlDbType.Date).Value = desde
                .Add("@hasta", SqlDbType.Date).Value = hasta
            End With
            Using da As New SqlDataAdapter
                da.SelectCommand = cmd
                Dim ds As New DataSet
                da.Fill(ds, "ReportePedidoFecha")
                Return ds
            End Using
        End Using
    End Function
    Public Function ReporteFechaCompra(desde As String, hasta As String) As DataSet
        conectado()

        Using cmd As New SqlCommand("Reporte_Compra_Fecha", cn)
            cmd.CommandType = CommandType.StoredProcedure
            With cmd.Parameters
                .Add("@desde", SqlDbType.Date).Value = desde
                .Add("@hasta", SqlDbType.Date).Value = hasta
            End With
            Using da As New SqlDataAdapter
                da.SelectCommand = cmd
                Dim ds As New DataSet
                da.Fill(ds, "ReporteCompraFecha")
                Return ds
            End Using
        End Using
    End Function
End Class
