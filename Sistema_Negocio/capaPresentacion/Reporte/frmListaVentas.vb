Imports CE = capaEntidad
Imports capaNegocio
Public Class frmListaVentas
    Dim objDao As New BoletaCN
    Dim objfac As New FacturaCN
    Dim objped As New PedidoCN
    Private Sub frmListaVentas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        llenaTablaBoleta()
        llenaTablaFactura()
        llenaTablaPedido()
    End Sub
    Sub llenaTablaBoleta()
        Dim dt As New DataTable
        Try
            dt = objDao.listaBoleta.Tables("Boletas")
            If dt.Rows.Count <> 0 Then
                dgLista.DataSource = dt
                dgLista.ColumnHeadersVisible = True
                lblNoexiste.Visible = False
                lblEncontrados.Text = dgLista.RowCount.ToString + " Registro(s) Encontrado(s)."
            Else
                dgLista.DataSource = Nothing
                dgLista.ColumnHeadersVisible = False
                lblNoexiste.Visible = True
                lblEncontrados.Text = "No se encontro ningun Registro"
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Sub llenaTablaFactura()
        Dim dt As New DataTable
        Try
            dt = objfac.listaFactura.Tables("Facturas")
            If dt.Rows.Count <> 0 Then
                dgLista.DataSource = dt
                dgLista.ColumnHeadersVisible = True
                lblNoexiste.Visible = False
                lblEncontrados.Text = dgLista.RowCount.ToString + " Registro(s) Encontrado(s)."
            Else
                dgLista.DataSource = Nothing
                dgLista.ColumnHeadersVisible = False
                lblNoexiste.Visible = True
                lblEncontrados.Text = "No se encontro ningun Registro"
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Sub llenaTablaPedido()
        Dim dt As New DataTable
        Try
            dt = objped.listaPedido.Tables("Pedidos")
            If dt.Rows.Count <> 0 Then
                dgLista.DataSource = dt
                dgLista.ColumnHeadersVisible = True
                lblNoexiste.Visible = False
                lblEncontrados.Text = dgLista.RowCount.ToString + " Registro(s) Encontrado(s)."
            Else
                dgLista.DataSource = Nothing
                dgLista.ColumnHeadersVisible = False
                lblNoexiste.Visible = True
                lblEncontrados.Text = "No se encontro ningun Registro"
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub dgBoleta_DoubleClick(sender As Object, e As EventArgs) Handles dgLista.DoubleClick
        Dim ChildForm As New frmConsultaDetalleBoleta
        ChildForm.MdiParent = frmWelcome
        ChildForm.codigo = dgLista.CurrentRow.Cells(0).Value
        ChildForm.Show()
    End Sub
End Class