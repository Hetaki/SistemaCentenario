Imports CE = capaEntidad
Imports capaNegocio
Imports utilitarios
Public Class frmCompras
    Public _objNeg As New ProductoDesconectadoCN
    Dim ProvDao As New ProveedorCN
    Dim compDao As New CompraCN
    Dim detalleDao As New DetalleCompraCN
    Dim ProDao As New ProductoCN
    Dim fila As Integer = -1
    Dim util As New util
    Dim ChildForm As New frmConsultaProductoCompra(Me)
    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Dim dni$ = String.Empty
        Dim ruc$ = String.Empty
        Dim objProv As New CE.Proveedor
        If chkDNI.CheckState = CheckState.Checked Then
            dni = txtDocumento.Text
            objProv = ProvDao.buscaProvxDNI(dni)

        End If
        If chkRUC.CheckState = CheckState.Checked Then
            ruc = txtDocumento.Text
            objProv = ProvDao.buscaProvxRUC(ruc)
        End If
        If objProv Is Nothing Then
            Dim result As DialogResult
            result = MessageBox.Show("No exite el Proveedor, Desea Agregarlo?", "Eliminando", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
            If result = DialogResult.OK Then
                Dim ChildForm As New frmProveedor
                ChildForm.MdiParent = frmWelcome
                ChildForm.Show()
            Else
                txtDocumento.Text = String.Empty
                chkDNI.Checked = False
                chkRUC.Checked = False
            End If
        Else
            llenaProveedor(objProv)
        End If
    End Sub
    Sub llenaProveedor(objProv As CE.Proveedor)
        txtNombre.Text = objProv.nombre
        txtDireccion.Text = objProv.direccion
        txtReferencia.Text = objProv.telefono
        txtCodigo.Text = objProv.codProv
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

    Private Sub frmCompras_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ChildForm.dgProducto.DataSource = _objNeg.listaProductoDesconectado.Tables("Productos")
        Dim fecha2$ = Date.Now.ToString("dd - MMMM - yyyy")
        lblFechaSistema.Text = fecha2
        generaCodigo()
        compratotal()

    End Sub
    Sub generaCodigo()
        lblCodigo.Text = compDao.generaCodigo.ToString("0000000000")
    End Sub
    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        ChildForm.MdiParent = frmWelcome
        ChildForm.Show()

    End Sub
    Sub fSumar()
        Dim total As Decimal = 0
        For Each fila As DataGridViewRow In dgDetalle.Rows
            total += Convert.ToDouble(fila.Cells(7).Value)
        Next
        ' lblimporte.Text = Format(total, "#,##0.00")
        lblimporte.Text = total
    End Sub
    Sub limpiar()
        txtCantidad.Clear()
        txtDescripcion.Clear()
        txtidPro.Clear()
        txtPrecio.Clear()
        txtpreciovn.Clear()
        btnAgregar.Visible = True
        txtdescuento.Clear()
    End Sub
    Sub compratotal()
        Dim valorimpo As Decimal = 0
        Dim valortotal As Decimal = 0
        valorimpo = Val(lblimporte.Text)
        lblimporte.Text = valortotal
    End Sub
    Private Sub btnAgregarProd_Click(sender As Object, e As EventArgs) Handles btnAgregarProd.Click
        If txtidPro.Text <> String.Empty Then
            Dim idPro% = txtidPro.Text
            Dim desc$ = txtDescripcion.Text
            Dim cant% = txtCantidad.Text
            Dim precio# = txtPrecio.Text
            Dim preven = txtpreciovn.Text
            Dim importe# = 0
            Dim valor# = txtdescuento.Text
            Dim descuento# = 0
            If chkPorcentaje.CheckState = CheckState.Checked Then
                descuento = valor / 100
                importe = (cant * precio) - (cant * precio * descuento)
            End If
            If chkNormal.CheckState = CheckState.Checked Then
                descuento = valor
                importe = (cant * precio) - descuento
            End If
            _objNeg.aumentarStockDesconectado(idPro, cant)
            If dgDetalle.RowCount <> 0 Then
                Dim cantidad% = 0
                Dim bol As Boolean = False
                For i = 0 To dgDetalle.Rows.Count - 1
                    If dgDetalle.Rows(i).Cells(1).Value = idPro Then
                        MsgBox("No puedes registrar dos productos iguales !!!", MsgBoxStyle.Information)
                        bol = True
                        Exit For
                    End If
                Next
                If Not bol = True Then
                    dgDetalle.Rows.Add(Nothing, idPro, desc, cant, precio, preven, descuento, importe)
                End If
                limpiar()
            Else
                dgDetalle.Rows.Add(Nothing, idPro, desc, cant, precio, preven, descuento, importe)
                limpiar()
            End If
        Else
            MsgBox("Necesita agregar un producto")
        End If
    End Sub
    Private Sub btnQuitarProducto_Click(sender As Object, e As EventArgs) Handles btnQuitarProducto.Click
        For Each row As DataGridViewRow In dgDetalle.Rows
            Dim marcado As Boolean = Convert.ToBoolean(row.Cells("Eliminar").Value)
            If marcado Then
                Dim onekey% = Convert.ToInt32(row.Cells(1).Value)
                Dim cant% = Convert.ToInt32(row.Cells(3).Value)
                _objNeg.disminuyeStockDesconectado(onekey, cant)
                dgDetalle.Rows.RemoveAt(row.Index)
            End If
        Next
        lblimporte.Text = ""
    End Sub
    Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click
        fSumar()
        compratotal()
    End Sub
    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        txtCantidad.Enabled = False
        util.Limpiar(Me)
        dgDetalle.Rows.Clear()
        lblimporte.Text = ""
        MsgBox("Se ha cancelado la Compra", MsgBoxStyle.Information)
        Me.Close()
    End Sub

    Private Sub btnGrabar_Click(sender As Object, e As EventArgs) Handles btnGrabar.Click
        If txtDocumento.Text <> "" And dgDetalle.RowCount <> 0 Then
            Dim objCom As New CE.Compra
            objCom.compID = lblCodigo.Text
            objCom.provID = txtCodigo.Text
            objCom.compTotal = lblimporte.Text
            objCom.compfecha = Date.Now.ToString("dd/MMMM/yyyy")
            objCom.compCondicionPag = txtcondicionpago.Text
            objCom.compNumeroFactura = txtfactura.Text
            compDao.registraCompra(objCom)
            For Each row As DataGridViewRow In dgDetalle.Rows
                Dim objDetalle As New CE.DetalleComprar
                objDetalle.compID = lblCodigo.Text
                objDetalle.prodID = row.Cells(1).Value
                objDetalle.dComCantidad = row.Cells(3).Value
                objDetalle.dCompUnit = row.Cells(4).Value
                objDetalle.dCompDescuento = row.Cells(6).Value
                detalleDao.registraDetalle_Compra(objDetalle)
                ProDao.aumentar_stock(objDetalle.prodID, objDetalle.dComCantidad)
            Next
            MsgBox("Se registro la compra con ID: " + lblCodigo.Text + " correctamente", MsgBoxStyle.Information)

            generaCodigo()
            util.Limpiar(Me)
            dgDetalle.Rows.Clear()
            lblimporte.Text = ""
        Else
            MsgBox("Ingrese todos los datos")
        End If

    End Sub
    Private Sub chkPorcentaje_CheckedChanged(sender As Object, e As EventArgs) Handles chkPorcentaje.CheckedChanged
        If chkPorcentaje.CheckState = CheckState.Checked Then
            chkNormal.Checked = False
        End If
    End Sub

    Private Sub chkNormal_CheckedChanged(sender As Object, e As EventArgs) Handles chkNormal.CheckedChanged
        If chkNormal.CheckState = CheckState.Checked Then
            chkPorcentaje.Checked = False
        End If
    End Sub
End Class