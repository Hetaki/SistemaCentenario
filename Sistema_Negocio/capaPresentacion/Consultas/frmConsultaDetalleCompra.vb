Imports CE = capaEntidad
Imports capaNegocio
Public Class frmConsultaDetalleCompra
    Public codigo As Integer
    Dim objDao As New DetalleCompraCN
    Private Sub frmConsultaDetalleCompra_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblIDBoleta.Text = codigo.ToString("0000000000")
        llenaTabla()
    End Sub

    Sub llenaTabla()
        Dim dt As New DataTable
        Try
            dt = objDao.listaDetalle_Compra(codigo).Tables("DetalleCompra")

            If dt.Rows.Count <> 0 Then
                dgDetalleCompra.DataSource = dt
                dgDetalleCompra.ColumnHeadersVisible = True
                lblNoexiste.Visible = False
                lblEncontrados.Text = dgDetalleCompra.RowCount.ToString + " Registro(s) Encontrado(s)."
            Else
                dgDetalleCompra.DataSource = Nothing
                dgDetalleCompra.ColumnHeadersVisible = False
                lblNoexiste.Visible = True
                lblEncontrados.Text = "No se encontro ningun Registro"
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class