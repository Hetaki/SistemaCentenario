﻿Imports CE = capaEntidad
Imports capaNegocio
Public Class frmConsultaProducto
    Dim objNeg As New ProductoCN
    Private _frmBoleta As frmBoleta

    Sub New(frmReceptor As Form)
        _frmBoleta = frmReceptor
        InitializeComponent()
    End Sub
    Sub New()
        Me.New(Nothing)
    End Sub

    Private Sub frmConsultaProducto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        llenaCombo()
        llenaTabla()
    End Sub
    Sub llenaTabla()
        dgProducto.DataSource = objNeg.listaProducto.Tables("Productos")
        lblEncontrados.Text = dgProducto.RowCount.ToString + " Registro(s) Encontrado(s)."
    End Sub
    Sub llenaCombo()
        cboCategoria.DataSource = objNeg.listaCategoria.Tables("Categorias")
        cboCategoria.DisplayMember = "catDesc"
        cboCategoria.ValueMember = "catID"
    End Sub
    Private Sub cboCategoria_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cboCategoria.SelectionChangeCommitted
        Dim categoria = cboCategoria.SelectedValue
        Dim nombre = txtNombre.Text
        dgProducto.DataSource = objNeg.listaProductoxCategoria_Nombre(categoria, nombre).Tables("Productos_nombre")
        lblEncontrados.Text = dgProducto.RowCount.ToString + "Registros Encontrados."
    End Sub
    Private Sub txtNombre_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNombre.KeyPress
        Dim categoria = cboCategoria.SelectedValue
        Dim nombre = txtNombre.Text
        dgProducto.DataSource = objNeg.listaProductoxCategoria_Nombre(categoria, nombre).Tables("Productos_nombre")
        lblEncontrados.Text = dgProducto.RowCount.ToString + "Registros Encontrados."
    End Sub

    Private Sub btnRecuperarDatos_Click(sender As Object, e As EventArgs) Handles btnRecuperarDatos.Click
        Dim cant$ = InputBox("Ingrese el stock para la boleta", "Cantidad")
        Dim idProd% = dgProducto.CurrentRow.Cells(0).Value
        Dim stock% = dgProducto.CurrentRow.Cells(2).Value
        If cant <> String.Empty Then
            Dim cantidad% = Val(Convert.ToInt32(cant))
            If (cantidad < stock) Then
                objNeg.disminuir_stock(idProd, cantidad)
                With _frmBoleta
                    .txtidPro.Text = idProd
                    .txtDescripcion.Text = dgProducto.CurrentRow.Cells(1).Value
                    .txtCantidad.Text = cantidad
                    .txtPrecio.Text = dgProducto.CurrentRow.Cells(4).Value
                    .txtPrecio.Enabled = True
                    .btnAgregar.Visible = False
                End With
                Me.Hide()
            Else
                MsgBox("La cantidad es mayor que el stock")
            End If
        Else
            'El usuario pulsó cancelar y la variable está vacía...
            MsgBox("Se cancelo la operacion", vbInformation, "Pulsó cancelar")
        End If
    End Sub
End Class