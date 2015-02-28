Imports CE = capaEntidad
Imports capaNegocio
Public Class frmConsultaProductoFactura
    Private _frmFactura As frmFactura
    Sub New(frmReceptor As Form)
        _frmFactura = frmReceptor
        InitializeComponent()
    End Sub
    Sub New()
        Me.New(Nothing)
    End Sub

    Private Sub frmConsultaProducto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblEncontrados.Text = dgProducto.RowCount.ToString + " Registro(s) Encontrado(s)"
    End Sub

    Private Sub dgProducto_DoubleClick(sender As Object, e As EventArgs) Handles dgProducto.DoubleClick
        Dim idProd% = dgProducto.CurrentRow.Cells(0).Value
        Dim stock% = dgProducto.CurrentRow.Cells(2).Value
        If stock <> 0 Then
            With _frmFactura
                .txtidPro.Text = idProd
                .txtDescripcion.Text = dgProducto.CurrentRow.Cells(1).Value
                .txtCantidad.Text = 1
                .lblStk.Text = stock
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
    Private Sub dgProducto_RowPrePaint(sender As Object, e As DataGridViewRowPrePaintEventArgs) Handles dgProducto.RowPrePaint
        If dgProducto.Rows(e.RowIndex).Cells(2).Value = 0 Then
            dgProducto.Rows(e.RowIndex).Cells(2).Style.ForeColor = Color.Red
        End If
    End Sub
End Class