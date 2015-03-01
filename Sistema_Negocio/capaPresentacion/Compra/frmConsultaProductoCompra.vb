Imports CE = capaEntidad
Imports capaNegocio
Public Class frmConsultaProductoCompra
    Dim objNeg As New ProductoCN
    Private _frmCompra As frmCompras
    Sub New(frmReceptor As Form)
        _frmCompra = frmReceptor
        InitializeComponent()
    End Sub
    Sub New()
        Me.New(Nothing)
    End Sub
    Private Sub dgProducto_DoubleClick(sender As Object, e As EventArgs) Handles dgProducto.DoubleClick
        Dim idProd% = dgProducto.CurrentRow.Cells(0).Value
        With _frmCompra
            .txtidPro.Text = idProd
            .txtDescripcion.Text = dgProducto.CurrentRow.Cells(1).Value
            .txtCantidad.Text = 1
            .txtPrecio.Text = dgProducto.CurrentRow.Cells(3).Value
            .txtpreciovn.Text = dgProducto.CurrentRow.Cells(4).Value
            .txtPrecio.Enabled = True
            .txtCantidad.Enabled = True
        End With
        Me.Hide()
    End Sub
    Sub llenaCombo()
        cboCategoria.DataSource = objNeg.listaCategoria.Tables("Categorias")
        cboCategoria.DisplayMember = "catDesc"
        cboCategoria.ValueMember = "catID"
    End Sub
    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Hide()
    End Sub

    Private Sub frmConsultaProducto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblEncontrados.Text = dgProducto.RowCount.ToString + " Registro(s) Encontrado(s)"
        llenaCombo()
    End Sub

    Private Sub dgProducto_RowPrePaint(sender As Object, e As DataGridViewRowPrePaintEventArgs) Handles dgProducto.RowPrePaint
        If dgProducto.Rows(e.RowIndex).Cells(2).Value = 0 Then
            dgProducto.Rows(e.RowIndex).Cells(2).Style.ForeColor = Color.Red
        End If
    End Sub
    Private Sub cboCategoria_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cboCategoria.SelectionChangeCommitted
        dgProducto.DataSource = _frmCompra._objNeg.filtrado(cboCategoria.SelectedValue)
    End Sub
End Class