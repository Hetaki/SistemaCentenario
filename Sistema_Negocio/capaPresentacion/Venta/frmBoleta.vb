Imports CE = capaEntidad
Imports capaNegocio
Imports utilitarios
Public Class frmBoleta
    Public _objNeg As New ProductoDesconectadoCN
    Dim CliDao As New ClienteCN
    Dim bolDao As New BoletaCN
    Dim detalleDao As New DetallBoletaCN
    Dim ProDao As New ProductoCN
    Dim util As New util
    Dim ChildForm As New frmConsultaProducto(Me)

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Dim dni$ = String.Empty
        Dim ruc$ = String.Empty
        Dim objCli As New CE.Cliente
        If chkDNI.CheckState = CheckState.Checked Then
            dni = txtDocumento.Text
            objCli = CliDao.buscaClientexDNI(dni)
        End If
        If chkRUC.CheckState = CheckState.Checked Then
            ruc = txtDocumento.Text
            objCli = CliDao.buscaClientexRUC(ruc)
        End If
        If objCli Is Nothing Then
            Dim result As DialogResult
            result = MessageBox.Show("No exite el Cliente, Desea Agregarlo?", "Eliminando", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
            If result = DialogResult.OK Then
                Dim ChildForm As New frmCliente
                ChildForm.MdiParent = frmWelcome
                ChildForm.Show()
            Else
                txtDocumento.Text = String.Empty
                chkDNI.Checked = False
                chkRUC.Checked = False
            End If
        Else
            llenaCliente(objCli)
        End If
    End Sub
    
    Sub llenaCliente(objCli As CE.Cliente)
        txtNombre.Text = objCli.nombre
        txtDireccion.Text = objCli.direccion
        txtReferencia.Text = objCli.referencia
        txtCodigo.Text = objCli.codCli
    End Sub
    Private Sub chkDNI_CheckedChanged(sender As Object, e As EventArgs) Handles chkDNI.CheckedChanged
        If chkDNI.CheckState = CheckState.Checked Then
            chkRUC.Checked = False
        End If
    End Sub

    Private Sub chkRUC_CheckedChanged(sender As Object, e As EventArgs) Handles chkRUC.CheckedChanged
        If chkRUC.CheckState = CheckState.Checked Then
            chkDNI.Checked = False
        End If
    End Sub
    Sub generaCodigo()
        lblCodigo.Text = bolDao.generaCodigo.ToString("0000000000")
    End Sub
    Private Sub frmBoleta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ChildForm.dgProducto.DataSource = _objNeg.listaProductoDesconectado.Tables("Productos")
        ChildForm.lblEncontrados.Text = ChildForm.dgProducto.RowCount.ToString + " Registro(s) Encontrado(s)."
        Dim fecha2$ = Date.Now.ToString("dd - MMMM - yyyy")
        lblFechaSistema.Text = fecha2
        generaCodigo()
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        ChildForm.MdiParent = frmWelcome
        ChildForm.Show()
    End Sub

    Sub fSumar()
        Dim total As Double = 0
        For Each fila As DataGridViewRow In dgDetalle.Rows
            total += Convert.ToDouble(fila.Cells(5).Value)
        Next
        lblTotal.Text = Format(total, "#,##0.00")
    End Sub
    Sub limpiar()
        txtCantidad.Clear()
        txtDescripcion.Clear()
        txtidPro.Clear()
        txtPrecio.Clear()
        txtCantidad.Enabled = False
        txtPrecio.Enabled = False
        btnAgregar.Visible = True
    End Sub
    Private Sub btnAgregarProd_Click(sender As Object, e As EventArgs) Handles btnAgregarProd.Click
        If txtidPro.Text <> String.Empty Then
            Dim idPro% = txtidPro.Text
            Dim desc$ = txtDescripcion.Text
            Dim cant% = txtCantidad.Text
            Dim precio# = txtPrecio.Text
            Dim importe# = cant * precio
            MsgBox(_objNeg.buscaStock(idPro))
            If cant > _objNeg.buscaStock(idPro) Then
                MsgBox("cantidad es mayor que el producto")
            Else
                _objNeg.disminuyeStockDesconectado(idPro, cant)
                If dgDetalle.RowCount <> 0 Then
                    Dim cantidad% = 0
                    Dim bol As Boolean = False
                    For i = 0 To dgDetalle.Rows.Count - 1
                        If dgDetalle.Rows(i).Cells(1).Value = idPro Then
                            cantidad = Convert.ToInt32(dgDetalle.Rows(i).Cells.Item("cantidad").Value)
                            MsgBox(dgDetalle.Rows(i).Cells.Item("codPro").Value)
                            cantidad += cant
                            dgDetalle.Rows(i).Cells.Item("cantidad").Value = cantidad
                            dgDetalle.Rows(i).Cells.Item("importe").Value = cantidad * precio
                            bol = True
                            Exit For
                        End If
                    Next
                    If Not bol = True Then
                        dgDetalle.Rows.Add(Nothing, idPro, desc, cant, precio, importe)
                    End If
                    limpiar()
                Else
                    dgDetalle.Rows.Add(Nothing, idPro, desc, cant, precio, importe)
                    limpiar()
                End If
            End If
        Else
            MsgBox("Necesita agregar un producto")
        End If
    End Sub
    ' TODO: Falta eliminar los productos
    Private Sub btnQuitarProducto_Click(sender As Object, e As EventArgs) Handles btnQuitarProducto.Click
        For Each row As DataGridViewRow In dgDetalle.Rows
            Dim marcado As Boolean = Convert.ToBoolean(row.Cells("Eliminar").Value)
            If marcado Then
                Dim onekey% = Convert.ToInt32(row.Cells(1).Value)
                Dim cant% = Convert.ToInt32(row.Cells(3).Value)
                _objNeg.aumentarStockDesconectado(onekey, cant)
                dgDetalle.Rows.RemoveAt(row.Index)
            End If
        Next
        lblTotal.Text = ""
    End Sub
    Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click
        fSumar()
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        txtCantidad.Enabled = False
        util.Limpiar(Me)
        dgDetalle.Rows.Clear()
        lblTotal.Text = ""
        MsgBox("Se ha cancelado la Boleta", MsgBoxStyle.Information)
        Me.Close()
    End Sub

    Private Sub btnGrabar_Click(sender As Object, e As EventArgs) Handles btnGrabar.Click
        If txtDocumento.Text <> "" And dgDetalle.RowCount <> 0 Then
            Dim objBol As New CE.Boleta
            objBol.codBol = lblCodigo.Text
            objBol.codCli = txtCodigo.Text
            objBol.fecha = Date.Now.ToString("dd/MMMM/yyyy")
            objBol.total = lblTotal.Text
            bolDao.registraBoleta(objBol)
            For Each row As DataGridViewRow In dgDetalle.Rows
                Dim objDetalle As New CE.DetalleBoleta
                objDetalle.idBol = lblCodigo.Text
                objDetalle.idProd = row.Cells(1).Value
                objDetalle.cantidad = row.Cells(3).Value
                objDetalle.precioU = row.Cells(4).Value
                If objDetalle.cantidad > ProDao.calculaStock(objDetalle.idProd) Then
                    MsgBox("Cantidad de Stock del producto " + objDetalle.idProd + " supera el stock actual", MsgBoxStyle.Information)
                Else
                    detalleDao.registraDetalle_Boleta(objDetalle)
                    ProDao.disminuir_stock(objDetalle.idProd, objDetalle.cantidad)
                End If
            Next
            MsgBox("Se registro la boleta con ID: " + txtCodigo.Text + " correctamente", MsgBoxStyle.Information)

            generaCodigo()
            util.Limpiar(Me)
            dgDetalle.Rows.Clear()
            lblTotal.Text = ""
        Else
            MsgBox("Ingrese todos los datos")
        End If

    End Sub

    Private Sub txtDocumento_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDocumento.KeyPress
        If (Not Char.IsNumber(e.KeyChar) And e.KeyChar <> Microsoft.VisualBasic.ChrW(8)) Then
            e.Handled = True
            Beep()
        End If
    End Sub

End Class