Imports capaNegocio
Public Class frmReportePedido
    Public idCli As Integer = 0
    Dim objNeg As New ReporteCN
    Private Sub frmReportePedido_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim rp As New crReportePedido
        rp.SetDataSource(objNeg.listaReportePedido(idCli).Tables("Reporte_Pedido"))
        CrystalReportViewer1.ReportSource = rp
    End Sub
End Class