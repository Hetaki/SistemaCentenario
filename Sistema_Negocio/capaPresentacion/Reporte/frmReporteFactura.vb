Imports capaNegocio
Public Class frmReporteFactura
    Public idCli As Integer = 0
    Dim objNeg As New ReporteCN
    Private Sub frmReporteFactura_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim rp As New crReporteFactura
        rp.SetDataSource(objNeg.listaReporteFactura(idCli).Tables("Reporte_Factura"))
        CrystalReportViewer1.ReportSource = rp
    End Sub
End Class