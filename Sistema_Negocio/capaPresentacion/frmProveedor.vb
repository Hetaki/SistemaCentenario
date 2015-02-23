Imports utilitarios
Imports capaNegocio
Imports CE = capaEntidad
Public Class frmProveedor
    Dim util As New util
    Dim objNeg As New ProveedorCN
    Private Sub frmProveedor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        util.Bloquear(Me)
        util.bloquearButton(Me, False)
        listaTabla()
    End Sub
    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        util.Bloquear(Me)
        util.Limpiar(Me)
        util.cambiarEstado(btnRegistrar, btnNuevo)
        util.bloquearButton(Me, False)
    End Sub
    Sub listaTabla()
        Dim dt As New DataTable
        Try
            dt = objNeg.listaProveedor.Tables("Proveedores")
            dgProveedor.Columns.Item("Eliminar").Visible = False

            If dt.Rows.Count <> 0 Then
                dgProveedor.DataSource = dt
                dgProveedor.ColumnHeadersVisible = True
                lblNoexiste.Visible = False
                dgProveedor.Columns.Item(1).Visible = False
            Else
                dgProveedor.DataSource = Nothing
                dgProveedor.ColumnHeadersVisible = False
                lblNoexiste.Visible = True
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        'TODO: Modificar el metodo en Utils
        util.Desbloquear(Me)
        util.cambiarEstado(btnNuevo, btnRegistrar)
    End Sub
    Private Sub btnRegistrar_Click(sender As Object, e As EventArgs) Handles btnRegistrar.Click
        Dim objProv As New CE.Proveedor
        objProv.correo = txtCorreo.Text
        objProv.direccion = txtDireccion.Text
        objProv.dni = txtDNI.Text
        objProv.nombre = txtNombre.Text
        objProv.ruc = txtRUC.Text
        objProv.telefono = txtTelefono.Text
        objNeg.registraProveedor(objProv)
        MsgBox("Se registro correctamente")
        util.Limpiar(Me)
        util.Bloquear(Me)
        util.cambiarEstado(btnRegistrar, btnNuevo)
        listaTabla()
    End Sub
    Private Sub dgProveedor_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgProveedor.CellDoubleClick
        util.Desbloquear(Me)
        util.bloquearButton(Me, True)
        txtCodigo.Text = dgProveedor.CurrentRow.Cells(1).Value
        txtRUC.Text = dgProveedor.CurrentRow.Cells(2).Value
        txtDNI.Text = dgProveedor.CurrentRow.Cells(3).Value
        txtNombre.Text = dgProveedor.CurrentRow.Cells(4).Value
        txtDireccion.Text = dgProveedor.CurrentRow.Cells(5).Value
        txtTelefono.Text = dgProveedor.CurrentRow.Cells(6).Value
        txtCorreo.Text = dgProveedor.CurrentRow.Cells(7).Value
    End Sub
    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        Dim objProv As New CE.Proveedor
        objProv.codProv = txtCodigo.Text
        objProv.correo = txtCorreo.Text
        objProv.direccion = txtDireccion.Text
        objProv.dni = txtDNI.Text
        objProv.nombre = txtNombre.Text
        objProv.ruc = txtRUC.Text
        objProv.telefono = txtTelefono.Text
        objNeg.modificarProveedor(objProv)
        MsgBox("Se modifico correctamente")
        util.Limpiar(Me)
        util.Bloquear(Me)
        util.bloquearButton(Me, False)
        listaTabla()
    End Sub
    'TODO: Falta hacer el eliminar
    'TODO: Falta evaluar los campos

    Private Sub dgProveedor_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgProveedor.CellContentClick
        If e.ColumnIndex = Me.dgProveedor.Columns.Item("Eliminar").Index Then
            Dim chkCell As DataGridViewCheckBoxCell = Me.dgProveedor.Rows(e.RowIndex).Cells("Eliminar")
            chkCell.Value = Not chkCell.Value
        End If
    End Sub

    Private Sub cbEliminar_CheckedChanged(sender As Object, e As EventArgs) Handles cbEliminar.CheckedChanged
        If cbEliminar.CheckState = CheckState.Checked Then
            btnEliminar.Enabled = True
            dgProveedor.Columns.Item("Eliminar").Visible = True
        Else
            btnEliminar.Enabled = False
            dgProveedor.Columns.Item("Eliminar").Visible = False
        End If
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Dim result As DialogResult

        result = MessageBox.Show("Realmente desea eliminar los productos seleccionados?", "Eliminando", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)

        If result = DialogResult.OK Then
            Try
                For Each row As DataGridViewRow In dgProveedor.Rows
                    Dim marcado As Boolean = Convert.ToBoolean(row.Cells("Eliminar").Value)

                    If marcado Then
                        Dim onekey% = Convert.ToInt32(row.Cells(1).Value)
                        Dim objProv As New CE.Proveedor
                        objProv.codProv = onekey
                        objNeg.eliminaProveedor(objProv)
                    End If
                Next
                cbEliminar.Checked = False
                listaTabla()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Else
            MessageBox.Show("Cancelando eliminacion de Proveedores?", "Eliminando", MessageBoxButtons.OK, MessageBoxIcon.Information)
            listaTabla()
        End If
    End Sub

    Private Sub chkDNI_CheckedChanged(sender As Object, e As EventArgs) Handles chkDNI.CheckedChanged
        If chkDNI.CheckState = CheckState.Checked Then
            txtDNI.Enabled = False
            chkRUC.Checked = False
        Else
            txtDNI.Enabled = True
        End If
    End Sub

    Private Sub chkRUC_CheckedChanged(sender As Object, e As EventArgs) Handles chkRUC.CheckedChanged
        If chkRUC.CheckState = CheckState.Checked Then
            txtRUC.Enabled = False
            chkDNI.Checked = False
        Else
            txtRUC.Enabled = True
        End If
    End Sub
End Class