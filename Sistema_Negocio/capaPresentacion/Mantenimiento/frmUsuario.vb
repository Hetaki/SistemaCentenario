Imports utilitarios
Imports capaNegocio
Imports CE = capaEntidad
Public Class frmUsuario
    Dim objNeg As New UsuarioCN
    Dim util As New util
    Private Sub frmUsuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnEliminar.Enabled = False
        util.Bloquear(Me)
        util.bloquearButton(Me, False)
        listaTabla()
        listaCombo()
    End Sub
    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        util.Desbloquear(Me)
        util.cambiarEstado(btnNuevo, btnRegistrar)
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
            dt = objNeg.listaUsuario.Tables("Usuarios")
            dgUsuario.Columns.Item("Eliminar").Visible = False

            If dt.Rows.Count <> 0 Then
                dgUsuario.DataSource = dt
                dgUsuario.ColumnHeadersVisible = True
                lblNoexiste.Visible = False
                dgUsuario.Columns.Item(1).Visible = False
                dgUsuario.Columns.Item(8).Visible = False
            Else
                dgUsuario.DataSource = Nothing
                dgUsuario.ColumnHeadersVisible = False
                lblNoexiste.Visible = True
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Sub listaCombo()
        cboCargo.DataSource = objNeg.listaCargo.Tables("Cargos")
        cboCargo.DisplayMember = "carDes"
        cboCargo.ValueMember = "carID"
    End Sub
    Function validarDNI(codigo As String) As CE.Usuario
        Dim objCli As New CE.Usuario
        objCli = objNeg.validaxDNI(codigo)
        Return objCli
    End Function
    Function validarUsuario(nick As String) As CE.Usuario
        Dim objCli As New CE.Usuario
        objCli = objNeg.validaxNick(nick)
        Return objCli
    End Function
    Private Sub dgUsuario_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgUsuario.CellDoubleClick
        util.Desbloquear(Me)
        util.bloquearButton(Me, True)
        txtCodigo.Text = dgUsuario.CurrentRow.Cells(1).Value
        txtDNI.Text = dgUsuario.CurrentRow.Cells(2).Value
        txtNombre.Text = dgUsuario.CurrentRow.Cells(3).Value
        txtCorreo.Text = dgUsuario.CurrentRow.Cells(4).Value
        txtCelular.Text = dgUsuario.CurrentRow.Cells(5).Value
        txtNick.Text = dgUsuario.CurrentRow.Cells(6).Value
        txtPassword.Text = dgUsuario.CurrentRow.Cells(7).Value
        txtPassword1.Text = dgUsuario.CurrentRow.Cells(7).Value
        cboCargo.SelectedValue = dgUsuario.CurrentRow.Cells(8).Value
    End Sub

    Private Sub btnRegistrar_Click(sender As Object, e As EventArgs) Handles btnRegistrar.Click
        If Me.ValidateChildren = True And txtCelular.Text <> "" And txtCorreo.Text <> "" And txtDNI.Text <> "" And txtNick.Text <> "" And txtPassword.Text <> "" And txtPassword1.Text <> "" Then
            If txtPassword.Text.Equals(txtPassword1.Text) Then
                If validarDNI(txtDNI.Text) Is Nothing Then
                    If validarUsuario(txtNick.Text) Is Nothing Then
                        Dim objUsu As New CE.Usuario
                        objUsu.cargo = cboCargo.SelectedValue
                        objUsu.celular = txtCelular.Text
                        objUsu.correo = txtCorreo.Text
                        objUsu.nDNI = txtDNI.Text
                        objUsu.nombre = txtNombre.Text
                        objUsu.password = txtPassword1.Text
                        objUsu.usuario = txtNick.Text
                        objNeg.registrarUsuario(objUsu)
                        MsgBox("Se registro correctamente")
                        util.Limpiar(Me)
                        util.Bloquear(Me)
                        util.cambiarEstado(btnRegistrar, btnNuevo)
                        listaTabla()
                    Else
                        MsgBox("Usuario ya existe con ese nick", MsgBoxStyle.Information)
                        txtPassword.Clear()
                        txtPassword1.Clear()
                        txtNick.Clear()
                        txtNick.Focus()
                    End If
                Else
                    MsgBox("Usuario ya existe con ese DNI", MsgBoxStyle.Information)
                    util.Limpiar(Me)
                End If
                
            Else
                MsgBox("Las contraseñas deben ser iguales")
            End If
        Else
            MsgBox("Ingrese los Datos")
        End If
        
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        Dim objUsu As New CE.Usuario
        objUsu.idusuario = txtCodigo.Text
        objUsu.cargo = cboCargo.SelectedValue
        objUsu.celular = txtCelular.Text
        objUsu.correo = txtCorreo.Text
        objUsu.nDNI = txtDNI.Text
        objUsu.nombre = txtNombre.Text
        objUsu.password = txtPassword1.Text
        objUsu.usuario = txtNick.Text
        objNeg.modificarUsuario(objUsu)
        MsgBox("Se modifico correctamente")
        util.Limpiar(Me)
        util.Bloquear(Me)
        util.bloquearButton(Me, False)
        listaTabla()
    End Sub

    Private Sub cbEliminar_CheckedChanged(sender As Object, e As EventArgs) Handles cbEliminar.CheckedChanged
        If cbEliminar.CheckState = CheckState.Checked Then
            btnEliminar.Enabled = True
            dgUsuario.Columns.Item("Eliminar").Visible = True
        Else
            btnEliminar.Enabled = False
            dgUsuario.Columns.Item("Eliminar").Visible = False
        End If
    End Sub

    Private Sub dgUsuario_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgUsuario.CellContentClick
        If e.ColumnIndex = Me.dgUsuario.Columns.Item("Eliminar").Index Then
            Dim chkCell As DataGridViewCheckBoxCell = Me.dgUsuario.Rows(e.RowIndex).Cells("Eliminar")
            chkCell.Value = Not chkCell.Value
        End If
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Dim result As DialogResult

        result = MessageBox.Show("Realmente desea eliminar los productos seleccionados?", "Eliminando", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)

        If result = DialogResult.OK Then
            Try
                For Each row As DataGridViewRow In dgUsuario.Rows
                    Dim marcado As Boolean = Convert.ToBoolean(row.Cells("Eliminar").Value)

                    If marcado Then
                        Dim onekey% = Convert.ToInt32(row.Cells(1).Value)
                        Dim objUsu As New CE.Usuario
                        objUsu.idusuario = onekey
                        objNeg.eliminaUsuario(objUsu)
                    End If
                Next
                cbEliminar.Checked = False
                listaTabla()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Else
            MessageBox.Show("Cancelando eliminacion de Usuarios?", "Eliminando", MessageBoxButtons.OK, MessageBoxIcon.Information)
            listaTabla()
        End If
    End Sub
    Private Sub txtDNI_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtDNI.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.erroricono.SetError(sender, "")
        Else
            Me.erroricono.SetError(sender, "Ingrese el DNI del Usuario, este dato es Obligatorio")
        End If
    End Sub
    Private Sub txtNombre_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtNombre.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.erroricono.SetError(sender, "")
        Else
            Me.erroricono.SetError(sender, "Ingrese el nombre del Usuario, este dato es Obligatorio")
        End If
    End Sub
    Private Sub txtCelular_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtCelular.Validating
        If DirectCast(sender, MaskedTextBox).Text.Length > 0 Then
            Me.erroricono.SetError(sender, "")
        Else
            Me.erroricono.SetError(sender, "Ingrese el celular del Usuario, este dato es Obligatorio")
        End If
    End Sub
    Private Sub txtCorreo_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtCorreo.Validating
        If DirectCast(sender, MaskedTextBox).Text.Length > 0 Then
            Me.erroricono.SetError(sender, "")
        Else
            Me.erroricono.SetError(sender, "Ingrese el correo del Usuario, este dato es Obligatorio")
        End If
    End Sub

    Private Sub txtNick_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtNick.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.erroricono.SetError(sender, "")
        Else
            Me.erroricono.SetError(sender, "Ingrese el usuario del Usuario, este dato es Obligatorio")
        End If
    End Sub

    Private Sub txtPassword_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtPassword.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.erroricono.SetError(sender, "")
        Else
            Me.erroricono.SetError(sender, "Ingrese el nombre del Usuario, este dato es Obligatorio")
        End If
    End Sub
   
    Private Sub txtPassword1_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtPassword1.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.erroricono.SetError(sender, "")
        Else
            Me.erroricono.SetError(sender, "Ingrese el nombre del Usuario, este dato es Obligatorio")
        End If
    End Sub
    Private Sub txtDNI_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDNI.KeyPress
        If (Not Char.IsNumber(e.KeyChar) And e.KeyChar <> Microsoft.VisualBasic.ChrW(8)) Then
            e.Handled = True
            Beep()
        End If
    End Sub
End Class