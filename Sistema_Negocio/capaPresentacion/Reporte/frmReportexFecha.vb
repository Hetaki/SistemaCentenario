Imports capaNegocio
Imports CE = capaEntidad
Public Class frmReportexFecha
    
    Dim objNeg As New ReporteCN

    Private Sub btnFiltrar_Click(sender As Object, e As EventArgs) Handles btnFiltrar.Click
        Dim des = txtdesde.Text
        Dim has = txtHasta.Text
        Dim rp As New crReporteBoletaPorFecha
        rp.SetDataSource(objNeg.listaReporteBoletaPorFecha(des, has).Tables("Reporte_BoletaFecha"))
        crvPorFecha.ReportSource = rp
        '        Dim ChildForm As New frmReporteBoleta
        'ChildForm.idCli = dgLista.CurrentRow.Cells(0).Value.ToString()
        'ChildForm.MdiParent = frmWelcome
        'ChildForm.Show()
    End Sub
End Class