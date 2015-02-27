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
        Dim ChildForm As New frmReporteBoleta
        ChildForm.idCli = dgLista.CurrentRow.Cells(0).Value.ToString()
        ChildForm.MdiParent = frmWelcome
        ChildForm.Show()
    End Sub

    Private Sub rbFactura_CheckedChanged(sender As Object, e As EventArgs) Handles rbFactura.CheckedChanged


    End Sub
End Class