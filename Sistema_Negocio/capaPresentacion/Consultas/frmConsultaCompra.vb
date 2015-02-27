Imports CE = capaEntidad
Imports capaNegocio
Public Class frmConsultaCompra
    Dim objDao As New CompraCN
    Private Sub frmConsultaCompra_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        llenaTabla()
    End Sub

    Sub llenaTabla()
        Dim dt As New DataTable
        Try
            dt = objDao.listaCompra.Tables("Compras")

            If dt.Rows.Count <> 0 Then
                dgCompra.DataSource = dt
                dgCompra.ColumnHeadersVisible = True
                lblNoexiste.Visible = False
                lblEncontrados.Text = dgCompra.RowCount.ToString + " Registro(s) Encontrado(s)."
            Else
                dgCompra.DataSource = Nothing
                dgCompra.ColumnHeadersVisible = False
                lblNoexiste.Visible = True
                lblEncontrados.Text = "No se encontro ningun Registro"
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub dgCompra_DoubleClick(sender As Object, e As EventArgs) Handles dgCompra.DoubleClick
        Dim ChildForm As New frmConsultaDetalleCompra
        ChildForm.MdiParent = frmWelcome
        ChildForm.codigo = dgCompra.CurrentRow.Cells(0).Value
        ChildForm.Show()
    End Sub
End Class