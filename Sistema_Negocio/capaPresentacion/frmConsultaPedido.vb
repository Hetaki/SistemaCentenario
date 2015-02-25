Imports CE = capaEntidad
Imports capaNegocio
Public Class frmConsultaPedido
    Dim objDao As New PedidoCN
    Private Sub frmConsultaPedido_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        llenaTabla()
    End Sub
    Sub llenaTabla()
        Dim dt As New DataTable
        Try
            dt = objDao.listaPedido.Tables("Pedidos")

            If dt.Rows.Count <> 0 Then
                dgPedido.DataSource = dt
                dgPedido.ColumnHeadersVisible = True
                lblNoexiste.Visible = False
                lblEncontrados.Text = dgPedido.RowCount.ToString + " Registro(s) Encontrado(s)."
            Else
                dgPedido.DataSource = Nothing
                dgPedido.ColumnHeadersVisible = False
                lblNoexiste.Visible = True
                lblEncontrados.Text = "No se encontro ningun Registro"
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub dgPedido_DoubleClick(sender As Object, e As EventArgs) Handles dgPedido.DoubleClick
        Dim ChildForm As New frmConsultaDetallePedido
        ChildForm.MdiParent = frmWelcome
        ChildForm.codigo = dgPedido.CurrentRow.Cells(0).Value
        ChildForm.Show()
    End Sub
End Class