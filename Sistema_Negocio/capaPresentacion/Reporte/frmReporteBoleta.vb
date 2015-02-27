Imports capaNegocio
Public Class frmReporteBoleta
    Public id As Integer = 0
    Dim objNeg As New ReporteCN
    Private Sub frmReporteBoleta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Boleta objreporte = New Boleta()
        ' objreporte.setParameter()
        ' Dim objBoleta = New Boleta()
        'objBoleta.SetParameterValue("@clienteID", IdCliente)
        'CrystalReportViewer1.ReportSource = objBoleta
        Dim rp As New crBoleta
        rp.SetDataSource(objNeg.listaReporteBoleta(id).Tables("Reporte_Boleta"))
        CrystalReportViewer1.ReportSource = rp
    End Sub
End Class