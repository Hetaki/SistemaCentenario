Imports utilitarios
Imports capaNegocio
Imports CE = capaEntidad
Public Class frmProducto
    Dim util As New util
    Dim objNeg As New ProductoCN
    
    Private Sub frmProducto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        objNeg.registraCategoria(descripcion)
        listaCombo()
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
        listaTabla()
    End Sub
    
End Class