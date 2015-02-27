Imports CE = capaEntidad
Imports capaNegocio
Public Class frmConsultaBoleta
    'TODO: Falta Filtrar
    Dim objDao As New BoletaCN
    Private Sub frmConsultaBoleta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        llenaTabla()
    End Sub
    Sub llenaTabla()
        Dim dt As New DataTable
        Try
            dt = objDao.listaBoleta.Tables("Boletas")

            If dt.Rows.Count <> 0 Then
                dgBoleta.DataSource = dt
                dgBoleta.ColumnHeadersVisible = True
                lblNoexiste.Visible = False
                lblEncontrados.Text = dgBoleta.RowCount.ToString + " Registro(s) Encontrado(s)."
            Else
                dgBoleta.DataSource = Nothing
                dgBoleta.ColumnHeadersVisible = False
                lblNoexiste.Visible = True
                lblEncontrados.Text = "No se encontro ningun Registro"
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub dgBoleta_DoubleClick(sender As Object, e As EventArgs) Handles dgBoleta.DoubleClick
        Dim ChildForm As New frmConsultaDetalleBoleta
        ChildForm.MdiParent = frmWelcome
        ChildForm.codigo = dgBoleta.CurrentRow.Cells(0).Value
        ChildForm.Show()
    End Sub
End Class