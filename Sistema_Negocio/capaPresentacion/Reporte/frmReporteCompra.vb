Imports capaNegocio
Public Class frmReporteCompra

    Public idCli As Integer = 0
    Dim objNeg As New ReporteCN
    Private Sub frmReporteCompra_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim rp As New crReporteCompra
        rp.SetDataSource(objNeg.listaReporteCompra(idCli).Tables("Reporte_Compra"))
        CrystalReportViewer1.ReportSource = rp
    End Sub
End Class