Imports capaNegocio
Public Class frmReporteBoleta
    Public idCli As Integer = 0
    Dim objNeg As New ReporteCN
    Private Sub frmReporteBoleta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim rp As New crReporteBoleta
        rp.SetDataSource(objNeg.listaReporteBoleta(idCli).Tables("Reporte_Boleta"))
        CrystalReportViewer1.ReportSource = rp
    End Sub

End Class