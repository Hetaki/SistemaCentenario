Imports CE = capaEntidad
Imports capaNegocio
Public Class frmConsultaDetalleFactura
    Public codigo As Integer
    Dim objDao As New DetalleFacturaCN
    Private Sub frmConsultaDetalleFactura_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblIDFactura.Text = codigo.ToString("0000000000")
        llenaTabla()
    End Sub
    Sub llenaTabla()
        Dim dt As New DataTable
        Try
            dt = objDao.listaDetalle_Factura(codigo).Tables("DetalleFacturas")

            If dt.Rows.Count <> 0 Then
                dgDetalleFactura.DataSource = dt
                dgDetalleFactura.ColumnHeadersVisible = True
                lblNoexiste.Visible = False
                lblEncontrados.Text = dgDetalleFactura.RowCount.ToString + " Registro(s) Encontrado(s)."
            Else
                dgDetalleFactura.DataSource = Nothing
                dgDetalleFactura.ColumnHeadersVisible = False
                lblNoexiste.Visible = True
                lblEncontrados.Text = "No se encontro ningun Registro"
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class