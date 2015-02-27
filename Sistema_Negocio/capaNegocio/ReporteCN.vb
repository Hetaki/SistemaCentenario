Imports capaDatos
Public Class ReporteCN
    Dim objDao As New ReporteDAO
    Public Function listaReporteBoleta(cliID As Integer) As DataSet
        Return objDao.listaReporteBoleta(cliID)
    End Function
End Class
