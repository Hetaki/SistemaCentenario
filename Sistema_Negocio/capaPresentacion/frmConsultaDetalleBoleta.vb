Imports CE = capaEntidad
Imports capaNegocio
Public Class frmConsultaDetalleBoleta
    Public codigo As Integer
    Dim objDao As New DetallBoletaCN
    Private Sub frmConsultaDetalleBoleta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblIDBoleta.Text = codigo.ToString("0000000000")
        llenaTabla()
    End Sub
    Sub llenaTabla()
        Dim dt As New DataTable
        Try
            dt = objDao.listaDetalle_Boleta(codigo).Tables("DetalleBoletas")

            If dt.Rows.Count <> 0 Then
                dgDetalleBoleta.DataSource = dt
                dgDetalleBoleta.ColumnHeadersVisible = True
                lblNoexiste.Visible = False
                lblEncontrados.Text = dgDetalleBoleta.RowCount.ToString + " Registro(s) Encontrado(s)."
            Else
                dgDetalleBoleta.DataSource = Nothing
                dgDetalleBoleta.ColumnHeadersVisible = False
                lblNoexiste.Visible = True
                lblEncontrados.Text = "No se encontro ningun Registro"
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class