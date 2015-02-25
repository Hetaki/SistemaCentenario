Imports CE = capaEntidad
Imports capaNegocio
Imports utilitarios
Public Class frmFactura
    Dim CliDao As New ClienteCN
    Dim facDao As New FacturaCN
    Dim detalleFac As New DetalleFacturaCN
    Dim ProDao As New ProductoCN
    Dim util As New util
    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        
    End Sub
    Sub llenaCliente(objCli As CE.Cliente)
        txtNombre.Text = objCli.nombre
        txtDireccion.Text = objCli.direccion
        txtReferencia.Text = objCli.referencia
        txtCodigo.Text = objCli.codCli
    End Sub
    Sub limpiar()
        txtCantidad.Clear()
        txtDescripcion.Clear()
        txtidPro.Clear()
        txtPrecio.Clear()
        txtPrecio.Enabled = False
        btnAgregar.Visible = True
    End Sub
    Private Sub frmFactura_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim fecha2$ = Date.Now.ToString("dd - MMMM - yyyy")
        lblFechaSistema.Text = fecha2
        generaCodigo()
    End Sub
    Sub generaCodigo()
        lblCodigo.Text = facDao.generaCodigo.ToString("0000000000")
    End Sub

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

    Private Sub btnAgregarProd_Click(sender As Object, e As EventArgs) Handles btnAgregarProd.Click
        If txtidPro.Text <> String.Empty Then
            Dim idPro% = txtidPro.Text
            Dim desc$ = txtDescripcion.Text
            Dim cant% = txtCantidad.Text
            Dim precio# = txtPrecio.Text
            Dim importe# = cant * precio
            dgDetalle.Rows.Add(Nothing, idPro, desc, cant, precio, importe)
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
                ProDao.aumentar_stock(onekey, cant)
            End If
        Next
    End Sub

    Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click
        fSumar()
    End Sub
    Sub fSumar()
        Dim total As Double = 0
        For Each fila As DataGridViewRow In dgDetalle.Rows
            total += Convert.ToDouble(fila.Cells(5).Value)
        Next
        lblTotal.Text = Format(total, "#,##0.00")
    End Sub

    Private Sub btnGrabar_Click(sender As Object, e As EventArgs) Handles btnGrabar.Click
        If txtDocumento.Text <> "" And dgDetalle.RowCount <> 0 Then
            Dim objFac As New CE.Factura
            objFac.codFac = lblCodigo.Text
            objFac.codCli = txtCodigo.Text
            objFac.fecha = Date.Now.ToString("dd/MMMM/yyyy")
            objFac.total = lblTotal.Text
            facDao.registraFactura(objFac)
            For Each row As DataGridViewRow In dgDetalle.Rows
                Dim objDetalle As New CE.DetalleFactura
                objDetalle.idFac = lblCodigo.Text
                objDetalle.idProd = row.Cells(1).Value
                objDetalle.cantidad = row.Cells(3).Value
                objDetalle.precioU = row.Cells(4).Value
                detalleFac.registraDetalle_Factura(objDetalle)
            Next
            generaCodigo()
            util.Limpiar(Me)
            dgDetalle.Rows.Clear()
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