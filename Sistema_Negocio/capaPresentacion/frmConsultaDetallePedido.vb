Imports CE = capaEntidad
Imports capaNegocio
Public Class frmConsultaDetallePedido
    Public codigo As Integer
    Dim objDao As New DetallePedidoCN
    Private Sub frmConsultaDetallePedido_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblIDPedido.Text = codigo.ToString("0000000000")
        llenaTabla()
    End Sub
    Sub llenaTabla()
        Dim dt As New DataTable
        Try
            dt = objDao.listaDetalle_Pedido(codigo).Tables("DetallePedidos")

            If dt.Rows.Count <> 0 Then
                dgDetallePedido.DataSource = dt
                dgDetallePedido.ColumnHeadersVisible = True
                lblNoexiste.Visible = False
                lblEncontrados.Text = dgDetallePedido.RowCount.ToString + " Registro(s) Encontrado(s)."
            Else
                dgDetallePedido.DataSource = Nothing
                dgDetallePedido.ColumnHeadersVisible = False
                lblNoexiste.Visible = True
                lblEncontrados.Text = "No se encontro ningun Registro"
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class