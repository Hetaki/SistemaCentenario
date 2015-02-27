Imports CE = capaEntidad
Imports capaNegocio
Public Class frmConsultaFactura
    Dim objDao As New FacturaCN
    Private Sub frmConsultaFactura_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        llenaTabla()
    End Sub
    Sub llenaTabla()
        Dim dt As New DataTable
        Try
            dt = objDao.listaFactura.Tables("Facturas")

            If dt.Rows.Count <> 0 Then
                dgFactura.DataSource = dt
                dgFactura.ColumnHeadersVisible = True
                lblNoexiste.Visible = False
                lblEncontrados.Text = dgFactura.RowCount.ToString + " Registro(s) Encontrado(s)."
            Else
                dgFactura.DataSource = Nothing
                dgFactura.ColumnHeadersVisible = False
                lblNoexiste.Visible = True
                lblEncontrados.Text = "No se encontro ningun Registro"
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub dgFactura_DoubleClick(sender As Object, e As EventArgs) Handles dgFactura.DoubleClick
        Dim ChildForm As New frmConsultaDetalleFactura
        ChildForm.MdiParent = frmWelcome
        ChildForm.codigo = dgFactura.CurrentRow.Cells(0).Value
        ChildForm.Show()
    End Sub
End Class