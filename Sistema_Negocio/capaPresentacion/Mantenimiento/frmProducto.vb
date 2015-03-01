Imports utilitarios
Imports capaNegocio
Imports CE = capaEntidad
Public Class frmProducto
    Dim util As New util
    Dim objNeg As New ProductoCN
    
    Private Sub frmProducto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnEliminar.Enabled = False
        util.Bloquear(Me)
        util.bloquearButton(Me, False)
        listaCombo()
        listaTabla()
    End Sub
    Sub generaCodigo()
        txtCodigo.Text = objNeg.listaProductoxCategoria(cboCategoria.SelectedValue)
    End Sub
    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        util.Bloquear(Me)
        util.Limpiar(Me)
        util.cambiarEstado(btnRegistrar, btnNuevo)
        util.bloquearButton(Me, False)
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        generaCodigo()
        util.Desbloquear(Me)
        util.cambiarEstado(btnNuevo, btnRegistrar)
    End Sub
    Sub listaTabla()
        Dim dt As New DataTable
        Try
            dt = objNeg.listaProducto.Tables("Productos")
            dgProducto.Columns.Item("Eliminar").Visible = False

            If dt.Rows.Count <> 0 Then
                dgProducto.DataSource = dt
                dgProducto.ColumnHeadersVisible = True
                lblNoexiste.Visible = False
            Else
                dgProducto.DataSource = Nothing
                dgProducto.ColumnHeadersVisible = False
                lblNoexiste.Visible = True
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
    Sub listaCombo()
        cboCategoria.DataSource = objNeg.listaCategoria.Tables("Categorias")
        cboCategoria.DisplayMember = "catDesc"
        cboCategoria.ValueMember = "catID"
    End Sub

    Private Sub lnkAgregar_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnkAgregar.LinkClicked
        Dim descripcion$ = InputBox("Ingrese la descripcion de la Categoria : ", "Categoria")
        If descripcion <> String.Empty Then
            objNeg.registraCategoria(descripcion)
            listaCombo()
        Else
            'El usuario pulsó cancelar y la variable está vacía...
            MsgBox("Se cancelo la operacion", MsgBoxStyle.Information)
        End If
    End Sub

    Private Sub cbEliminar_CheckedChanged(sender As Object, e As EventArgs) Handles cbEliminar.CheckedChanged
        If cbEliminar.CheckState = CheckState.Checked Then
            btnEliminar.Enabled = True
            dgProducto.Columns.Item("Eliminar").Visible = True
        Else
            btnEliminar.Enabled = False
            dgProducto.Columns.Item("Eliminar").Visible = False
        End If
    End Sub

    Private Sub dgProducto_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgProducto.CellContentClick
        If e.ColumnIndex = Me.dgProducto.Columns.Item("Eliminar").Index Then
            Dim chkCell As DataGridViewCheckBoxCell = Me.dgProducto.Rows(e.RowIndex).Cells("Eliminar")
            chkCell.Value = Not chkCell.Value
        End If
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Dim result As DialogResult

        result = MessageBox.Show("Realmente desea eliminar los productos seleccionados?", "Eliminando", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)

        If result = DialogResult.OK Then
            Try
                For Each row As DataGridViewRow In dgProducto.Rows
                    Dim marcado As Boolean = Convert.ToBoolean(row.Cells("Eliminar").Value)

                    If marcado Then
                        Dim onekey% = Convert.ToInt32(row.Cells(1).Value)
                        Dim objProd As New CE.Producto
                        objProd.codPro = onekey
                        objNeg.eliminaProducto(objProd)
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
    Private Sub cboCategoria_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cboCategoria.SelectionChangeCommitted
        generaCodigo()
    End Sub
    Private Sub btnRegistrar_Click(sender As Object, e As EventArgs) Handles btnRegistrar.Click
        If Me.ValidateChildren = True And txtNombre.Text <> "" And txtUbicacion.Text <> "" And txtPrecioCompra.Text <> "" And txtPrecioVenta.Text <> "" And nudStock.Value <> 0 Then
            Dim objProd As New CE.Producto
            objProd.fecha = dtFecha.Text
            objProd.nombre = txtNombre.Text
            objProd.categoria = cboCategoria.SelectedValue
            objProd.codPro = txtCodigo.Text
            objProd.precioCompra = txtPrecioCompra.Text
            objProd.precioVenta = txtPrecioVenta.Text
            objProd.stock = nudStock.Value
            objProd.ubicacion = txtUbicacion.Text
            objNeg.registraProducto(objProd)
            MsgBox("Se registro correctamente")
            util.Limpiar(Me)
            util.Bloquear(Me)
            util.cambiarEstado(btnRegistrar, btnNuevo)
            listaTabla()
        Else
            MsgBox("Datos Incompletos")
        End If

      
    End Sub

    Private Sub dgProducto_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgProducto.CellDoubleClick
        util.Desbloquear(Me)
        util.bloquearButton(Me, True)
        txtCodigo.Text = dgProducto.CurrentRow.Cells(1).Value
        txtNombre.Text = dgProducto.CurrentRow.Cells(2).Value
        nudStock.Value = dgProducto.CurrentRow.Cells(3).Value
        txtPrecioCompra.Text = dgProducto.CurrentRow.Cells(4).Value
        txtPrecioVenta.Text = dgProducto.CurrentRow.Cells(5).Value
        txtUbicacion.Text = dgProducto.CurrentRow.Cells(6).Value
        dtFecha.Text = dgProducto.CurrentRow.Cells(7).Value
        cboCategoria.SelectedValue = dgProducto.CurrentRow.Cells(8).Value
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        Dim objProd As New CE.Producto
        objProd.fecha = dtFecha.Text
        objProd.nombre = txtNombre.Text
        objProd.categoria = cboCategoria.SelectedValue
        objProd.codPro = txtCodigo.Text
        objProd.precioCompra = txtPrecioCompra.Text
        objProd.precioVenta = txtPrecioVenta.Text
        objProd.stock = nudStock.Value
        objProd.ubicacion = txtUbicacion.Text
        objNeg.modificarProducto(objProd)
        MsgBox("Se modifico correctamente")
        util.Limpiar(Me)
        util.Bloquear(Me)
        util.cambiarEstado(btnRegistrar, btnNuevo)
        util.bloquearButton(Me, False)
        listaTabla()
    End Sub
    
    Private Sub txtNombre_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtNombre.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.erroricono.SetError(sender, "")
        Else
            Me.erroricono.SetError(sender, "Ingrese el nombre del Producto, este dato es Obligatorio")
        End If
    End Sub
    Private Sub txtUbicacion_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtUbicacion.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.erroricono.SetError(sender, "")
        Else
            Me.erroricono.SetError(sender, "Ingrese la ubicacion del Producto, este dato es Obligatorio")
        End If
    End Sub
    Private Sub txtPrecioCompra_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtPrecioCompra.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.erroricono.SetError(sender, "")
        Else
            Me.erroricono.SetError(sender, "Ingrese el precio de compra del Producto, este dato es Obligatorio")
        End If
    End Sub
   
    Private Sub txtPrecioVenta_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtPrecioVenta.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.erroricono.SetError(sender, "")
        Else
            Me.erroricono.SetError(sender, "Ingrese el precio de venta del Producto, este dato es Obligatorio")
        End If
    End Sub

    Private Sub dgProducto_RowPrePaint(sender As Object, e As DataGridViewRowPrePaintEventArgs) Handles dgProducto.RowPrePaint
        If dgProducto.RowCount <> 0 Then
            Exit Sub
        Else
            If dgProducto.Rows(e.RowIndex).Cells(3).Value = 0 Then
                dgProducto.Rows(e.RowIndex).Cells(3).Style.ForeColor = Color.Red
            End If
        End If
       
    End Sub
End Class