﻿Imports CE = capaEntidad
Imports capaNegocio
Public Class frmConsultaProductoPedido
    Private _frmPedido As frmPedido
    Sub New(frmReceptor As Form)
        _frmPedido = frmReceptor
        InitializeComponent()
    End Sub
    Sub New()
        Me.New(Nothing)
    End Sub

    Private Sub frmConsultaProducto_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub dgProducto_DoubleClick(sender As Object, e As EventArgs) Handles dgProducto.DoubleClick
        Dim idProd% = dgProducto.CurrentRow.Cells(0).Value
        Dim stock% = dgProducto.CurrentRow.Cells(2).Value
        If stock <> 0 Then
            With _frmPedido
                .txtidPro.Text = idProd
                .txtDescripcion.Text = dgProducto.CurrentRow.Cells(1).Value
                .txtCantidad.Text = 1
                .txtPrecio.Text = dgProducto.CurrentRow.Cells(4).Value
                .txtPrecio.Enabled = True
                .txtCantidad.Enabled = True
                .btnAgregar.Visible = False
            End With
            Me.Hide()
        Else
            MsgBox("Stock del Producto insuficiente, Busque a su proveedor", MsgBoxStyle.Information)
        End If
       
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Hide()
    End Sub
End Class