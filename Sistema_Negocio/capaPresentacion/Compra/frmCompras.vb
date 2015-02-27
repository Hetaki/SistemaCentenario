Imports CE = capaEntidad
Imports capaNegocio
Imports utilitarios
Public Class frmCompras
    Dim ProvDao As New ProveedorCN
    Dim compDao As New CompraCN
    Dim detalleDao As New DetalleCompraCN
    Dim ProDao As New ProductoCN
    Dim fila As Integer = -1
    Dim util As New util
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
        Dim fecha2$ = Date.Now.ToString("dd - MMMM - yyyy")
        lblFechaSistema.Text = fecha2
        generaCodigo()
        compratotal()

    End Sub
    Sub generaCodigo()
        lblCodigo.Text = compDao.generaCodigo.ToString("0000000000")
    End Sub
    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Dim ChildForm As New frmConProductoAdd(Me)
        ChildForm.MdiParent = frmWelcome
        ChildForm.Show()

    End Sub
    Sub sumardes()
        Dim destotal As Double = 0
        For Each fila2 As DataGridViewRow In dgDetalle.Rows
            destotal += Convert.ToDouble(fila2.Cells(6).Value)
        Next
        lbldes.Text = Format(destotal, "#,##0.00")
    End Sub

    Sub fSumar()
        Dim total As Double = 0
        For Each fila As DataGridViewRow In dgDetalle.Rows
            total += Convert.ToDouble(fila.Cells(7).Value)
        Next
        lblimporte.Text = Format(total, "#,##0.00")
    End Sub


    Sub limpiar()
        txtCantidad.Clear()
        txtDescripcion.Clear()
        txtidPro.Clear()
        txtPrecio.Clear()
        txtpreciovn.Clear()
        btnAgregar.Visible = True
    End Sub
    Sub compratotal()
        Dim valorimpo As Double = 0
        Dim valordes As Double = 0
        Dim valortotal As Double = 0
        valorimpo = Val(lblimporte.Text)
        valordes = Val(lbldes.Text)
        valortotal = valorimpo - valordes
        lblotal.Text = valortotal
    End Sub

    Private Sub btnAgregarProd_Click(sender As Object, e As EventArgs) Handles btnAgregarProd.Click
        If txtidPro.Text <> String.Empty Then
            Dim idPro% = txtidPro.Text
            Dim desc$ = txtDescripcion.Text
            Dim cant% = txtCantidad.Text
            Dim precio# = txtPrecio.Text
            Dim preven = txtpreciovn.Text
            Dim descuento# = txtdescuento.Text
            Dim importe# = cant * precio



            dgDetalle.Rows.Add(Nothing, idPro, desc, cant, precio, preven, descuento, importe)
            limpiar()
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
                dgDetalle.Rows.RemoveAt(row.Index)
                ProDao.disminuir_stock(onekey, cant)
            End If
        Next
    End Sub
    Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click
        fSumar()
        sumardes()
        compratotal()

    End Sub


    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        util.Limpiar(Me)
    End Sub

    Private Sub btnGrabar_Click(sender As Object, e As EventArgs) Handles btnGrabar.Click
        If txtDocumento.Text <> "" And dgDetalle.RowCount <> 0 Then
            Dim objCom As New CE.Compra
            objCom.compID = lblCodigo.Text
            objCom.provID = txtCodigo.Text
            objCom.compTotal = lblotal.Text
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
                MsgBox(objDetalle.compID)
                detalleDao.registraDetalle_Compra(objDetalle)
            Next
            generaCodigo()
            util.Limpiar(Me)
        Else
            MsgBox("Ingrese todos los datos")
        End If

    End Sub



    Private Sub rbporciento_Click(sender As Object, e As EventArgs) Handles rbporciento.Click
        txtdescuento.Text = ""
    End Sub

    Private Sub Rbnormal_CheckedChanged(sender As Object, e As EventArgs) Handles Rbnormal.CheckedChanged
        txtdescuento.Text = "numero normal aqui"
    End Sub



End Class