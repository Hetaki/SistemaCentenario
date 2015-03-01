Imports utilitarios
Imports capaNegocio
Imports CE = capaEntidad
Public Class frmCliente
    Dim util As New util
    Dim objNeg As New ClienteCN
    Private Sub frmCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnEliminar.Enabled = False
        util.Bloquear(Me)
        util.bloquearButton(Me, False)
        listaTabla()
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
            dt = objNeg.listaCliente.Tables("Clientes")
            dgCliente.Columns.Item("Eliminar").Visible = False

            If dt.Rows.Count <> 0 Then
                dgCliente.DataSource = dt
                dgCliente.ColumnHeadersVisible = True
                lblNoexiste.Visible = False
            Else
                dgCliente.DataSource = Nothing
                dgCliente.ColumnHeadersVisible = False
                lblNoexiste.Visible = True
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Function validarDNI(codigo As String) As CE.Cliente
        Dim objCli As New CE.Cliente
        objCli = objNeg.buscaClientexDNI(codigo)
        Return objCli
    End Function
    Function validarRUC(codigo As String) As CE.Cliente
        Dim objCli As New CE.Cliente
        objCli = objNeg.buscaClientexRUC(codigo)
        Return objCli
    End Function
    Private Sub dgCliente_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgCliente.CellDoubleClick
        util.Desbloquear(Me)
        util.bloquearButton(Me, True)
        txtCodigo.Text = dgCliente.CurrentRow.Cells(1).Value
        txtDNI.Text = dgCliente.CurrentRow.Cells(2).Value
        txtRUC.Text = dgCliente.CurrentRow.Cells(3).Value
        txtNombre.Text = dgCliente.CurrentRow.Cells(4).Value
        txtCelular.Text = dgCliente.CurrentRow.Cells(5).Value
        txtTelefono.Text = dgCliente.CurrentRow.Cells(6).Value
        txtDireccion.Text = dgCliente.CurrentRow.Cells(7).Value
        txtReferencia.Text = dgCliente.CurrentRow.Cells(8).Value
        If dgCliente.CurrentRow.Cells(2).Value = "" Then
            chkDNI.Checked = True
        ElseIf dgCliente.CurrentRow.Cells(3).Value = String.Empty Then
            chkRUC.Checked = True
        End If
    End Sub
  
    Private Sub btnRegistrar_Click(sender As Object, e As EventArgs) Handles btnRegistrar.Click
        If Me.ValidateChildren = True And txtNombre.Text <> "" And txtReferencia.Text <> "" And txtTelefono.Text <> "" And txtDireccion.Text <> "" Then
            Dim objCli As New CE.Cliente
            If txtRUC.Text.Equals("") Then
                If validarDNI(txtDNI.Text) Is Nothing Then
                    objCli.dni = txtDNI.Text
                    objCli.ruc = ""
                    objCli.nombre = txtNombre.Text
                    objCli.celular = txtCelular.Text
                    objCli.direccion = txtDireccion.Text
                    objCli.referencia = txtReferencia.Text
                    objCli.telefono = txtTelefono.Text
                    objNeg.registraCliente(objCli)
                    util.Limpiar(Me)
                    util.Bloquear(Me)
                    util.cambiarEstado(btnRegistrar, btnNuevo)
                    listaTabla()
                Else
                    MsgBox("No puede repetir DNI", MsgBoxStyle.Information)
                    util.Limpiar(Me)
                End If
            ElseIf txtDNI.Text.Equals("") Then
                If validarRUC(txtRUC.Text) Is Nothing Then
                    objCli.dni = ""
                    objCli.ruc = txtRUC.Text
                    objCli.nombre = txtNombre.Text
                    objCli.celular = txtCelular.Text
                    objCli.direccion = txtDireccion.Text
                    objCli.referencia = txtReferencia.Text
                    objCli.telefono = txtTelefono.Text
                    objNeg.registraCliente(objCli)
                    util.Limpiar(Me)
                    util.Bloquear(Me)
                    util.cambiarEstado(btnRegistrar, btnNuevo)
                    listaTabla()
                Else
                    MsgBox("No puede repetir RUC", MsgBoxStyle.Information)
                    util.Limpiar(Me)
                End If
            End If
            
        Else
            MsgBox("Datos incompletos")
        End If


    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        Dim objCli As New CE.Cliente
        objCli.codCli = txtCodigo.Text
        objCli.dni = txtDNI.Text
        objCli.ruc = txtRUC.Text
        objCli.nombre = txtNombre.Text
        objCli.celular = txtCelular.Text
        objCli.direccion = txtDireccion.Text
        objCli.referencia = txtReferencia.Text
        objCli.telefono = txtTelefono.Text
        objNeg.modificarCliente(objCli)
        util.Limpiar(Me)
        util.Bloquear(Me)
        util.bloquearButton(Me, False)
        listaTabla()
    End Sub

    Private Sub cbEliminar_CheckedChanged(sender As Object, e As EventArgs) Handles cbEliminar.CheckedChanged
        If cbEliminar.CheckState = CheckState.Checked Then
            btnEliminar.Enabled = True
            dgCliente.Columns.Item("Eliminar").Visible = True
        Else
            btnEliminar.Enabled = False
            dgCliente.Columns.Item("Eliminar").Visible = False
        End If
    End Sub

    Private Sub dgCliente_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgCliente.CellContentClick
        If e.ColumnIndex = Me.dgCliente.Columns.Item("Eliminar").Index Then
            Dim chkCell As DataGridViewCheckBoxCell = Me.dgCliente.Rows(e.RowIndex).Cells("Eliminar")
            chkCell.Value = Not chkCell.Value
        End If
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Dim result As DialogResult

        result = MessageBox.Show("Realmente desea eliminar los clientes seleccionados?", "Eliminando", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)

        If result = DialogResult.OK Then
            Try
                For Each row As DataGridViewRow In dgCliente.Rows
                    Dim marcado As Boolean = Convert.ToBoolean(row.Cells("Eliminar").Value)

                    If marcado Then
                        Dim onekey% = Convert.ToInt32(row.Cells(1).Value)
                        Dim objCli As New CE.Cliente
                        objCli.codCli = onekey
                        objNeg.eliminaCliente(objCli)
                    End If
                Next
                cbEliminar.Checked = False
                listaTabla()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Else
            MessageBox.Show("Cancelando eliminacion de Productos?", "Eliminando", MessageBoxButtons.OK, MessageBoxIcon.Information)
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

    Private Sub txtNombre_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtNombre.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.erroricono.SetError(sender, "")
        Else
            Me.erroricono.SetError(sender, "Ingrese el nombre del Proveedor, este dato es Obligatorio")
        End If
    End Sub
   
    Private Sub txtDireccion_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtDireccion.Validating
        If DirectCast(sender, MaskedTextBox).Text.Length > 0 Then
            Me.erroricono.SetError(sender, "")
        Else
            Me.erroricono.SetError(sender, "Ingrese la direccion del Cliente, este dato es Obligatorio")
        End If
    End Sub
    
    Private Sub txtReferencia_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtReferencia.Validating
        If DirectCast(sender, MaskedTextBox).Text.Length > 0 Then
            Me.erroricono.SetError(sender, "")
        Else
            Me.erroricono.SetError(sender, "Ingrese la referencia del Cliente, este dato es Obligatorio")
        End If
    End Sub

    Private Sub txtDNI_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDNI.KeyPress
        If (Not Char.IsNumber(e.KeyChar) And e.KeyChar <> Microsoft.VisualBasic.ChrW(8)) Then
            e.Handled = True
            Beep()
        End If
    End Sub

    Private Sub txtRUC_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtRUC.KeyPress
        If (Not Char.IsNumber(e.KeyChar) And e.KeyChar <> Microsoft.VisualBasic.ChrW(8)) Then
            e.Handled = True
            Beep()
        End If
    End Sub
End Class