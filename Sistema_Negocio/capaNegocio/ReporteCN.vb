Imports capaDatos
Public Class ReporteCN
    Dim objDao As New ReporteDAO
    Public Function listaReporteBoleta(cliID As Integer) As DataSet
        Return objDao.listaReporteBoleta(cliID)
    End Function
    Public Function listaReporteFactura(cliID As Integer) As DataSet
        Return objDao.listaReporteFactura(cliID)
    End Function
    Public Function listaReportePedido(cliID As Integer) As DataSet
        Return objDao.listaReportePedido(cliID)
    End Function
    Public Function listaReporteCompra(cliID As Integer) As DataSet
        Return objDao.listaReporteCompra(cliID)
    End Function
    Public Function listaReporteBoletaPorFecha(desde As String, hasta As String) As DataSet
        Return objDao.listaReporteBoletaPorFecha(desde, hasta)
    End Function
    Public Function ReporteFechaBoleta(desde As String, hasta As String) As DataSet
        Return objDao.ReporteFechaBoleta(desde, hasta)
    End Function
    Public Function ReporteFechaFactura(desde As String, hasta As String) As DataSet
        Return objDao.ReporteFechaFactura(desde, hasta)
    End Function
    Public Function ReporteFechaPedido(desde As String, hasta As String) As DataSet
        Return objDao.ReporteFechaPedido(desde, hasta)
    End Function
    Public Function ReporteFechaCompra(desde As String, hasta As String) As DataSet
        Return objDao.ReporteFechaCompra(desde, hasta)
    End Function
End Class
