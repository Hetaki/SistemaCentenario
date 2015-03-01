Imports CE = capaEntidad
Imports capaNegocio
Imports utilitarios
Public Class frmSpReporteNotaPedido
    Dim objDao As New BoletaCN
    Dim objreporte As New ReporteCN
    Dim util As New util

    Sub llenareporte()
        Dim des = txtDesde.Text
        Dim has = txtHasta.Text
        Dim rp As New spReporteFechaPedido
        rp.SetDataSource(objreporte.SP_ReporteBoleta(des, has).Tables("SPReportePedidoFecha"))
        crBoletas.ReportSource = rp
    End Sub
    Private Sub btnfiltrar_Click(sender As Object, e As EventArgs) Handles btnfiltrar.Click
        Call llenareporte()
    End Sub
End Class