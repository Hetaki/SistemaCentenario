Imports capaNegocio
Imports CE = capaEntidad
Public Class frmListaCliente
    Dim idcli As Integer
    Dim objNeg As New ClienteCN
    Private Sub frmListaCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        listaTabla()
    End Sub
    Sub listaTabla()
        Dim dt As New DataTable
        Try
            dt = objNeg.listaCliente.Tables("Clientes")

            If dt.Rows.Count <> 0 Then
                dgLista.DataSource = dt
                dgLista.ColumnHeadersVisible = True
                lblNoexiste.Visible = False
            Else
                dgLista.DataSource = Nothing
                dgLista.ColumnHeadersVisible = False
                lblNoexiste.Visible = True
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub dgLista_DoubleClick(sender As Object, e As EventArgs) Handles dgLista.DoubleClick
        If txtFlag.Text.Equals("factura") Then
            Dim ChildForm As New frmReporteFactura
            ChildForm.idCli = dgLista.CurrentRow.Cells(0).Value.ToString()
            ChildForm.MdiParent = frmWelcome
            ChildForm.Show()
        End If
        If txtFlag.Text.Equals("boleta") Then
            Dim ChildForm As New frmReporteBoleta
            ChildForm.idCli = dgLista.CurrentRow.Cells(0).Value.ToString()
            ChildForm.MdiParent = frmWelcome
            ChildForm.Show()
        End If
        If txtFlag.Text.Equals("pedido") Then
            Dim ChildForm As New frmReportePedido
            ChildForm.idCli = dgLista.CurrentRow.Cells(0).Value.ToString()
            ChildForm.MdiParent = frmWelcome
            ChildForm.Show()
        End If
        If txtFlag.Text.Equals("0") Then
            MsgBox("Seleccione una opcion", MsgBoxStyle.Information)
        End If
        
    End Sub


    Private Sub chkFactura_CheckedChanged(sender As Object, e As EventArgs) Handles chkFactura.CheckedChanged
        If chkFactura.CheckState = CheckState.Checked Then
            chkPedido.Checked = False
            chkBoleta.Checked = False
            txtFlag.Text = "factura"
        Else
            txtFlag.Text = "0"
        End If
    End Sub

    Private Sub chkBoleta_CheckedChanged(sender As Object, e As EventArgs) Handles chkBoleta.CheckedChanged
        If chkBoleta.CheckState = CheckState.Checked Then
            chkPedido.Checked = False
            chkFactura.Checked = False
            txtFlag.Text = "boleta"
        Else
            txtFlag.Text = "0"
        End If
    End Sub

    Private Sub chkPedido_CheckedChanged(sender As Object, e As EventArgs) Handles chkPedido.CheckedChanged
        If chkPedido.CheckState = CheckState.Checked Then
            chkBoleta.Checked = False
            chkFactura.Checked = False
            txtFlag.Text = "pedido"
        Else
            txtFlag.Text = "0"
        End If
    End Sub
End Class