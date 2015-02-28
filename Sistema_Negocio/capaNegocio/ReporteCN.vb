﻿Imports capaDatos
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
    Public Function listaReporteBoletaPorFecha(desde As Date, hasta As Date) As DataSet
        Return objDao.listaReporteBoletaPorFecha(desde, hasta)
    End Function
End Class
