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
    Private Sub DataGridView1_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgLista.CellContentDoubleClick
        Dim objForm As New frmReporteBoleta()
        idcli = dgLista.CurrentRow.Cells(0).Value.ToString()
        'objForm.IdCliente = idcli
        objForm.ShowDialog()
    End Sub
End Class