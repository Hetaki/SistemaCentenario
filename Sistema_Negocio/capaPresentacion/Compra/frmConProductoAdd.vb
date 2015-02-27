Imports CE = capaEntidad
Imports capaNegocio
Public Class frmConProductoAdd
    Dim objNeg As New ProductoCN

    Private _frmCompras As frmCompras


    Sub New(frmCompras As frmCompras)
        _frmCompras = frmCompras
        InitializeComponent()
    End Sub
    Sub New()
        Me.New(Nothing)
    End Sub
    Private Sub frmConProductoAdd_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        Dim cantidad% = InputBox("Ingrese el stock de compra", "Cantidad")
        Dim idProd% = dgProducto.CurrentRow.Cells(0).Value
        Dim stock% = dgProducto.CurrentRow.Cells(2).Value
        objNeg.aumentar_stock(idProd, cantidad)
        With _frmCompras
            .txtidPro.Text = idProd
            .txtDescripcion.Text = dgProducto.CurrentRow.Cells(1).Value
            .txtCantidad.Text = cantidad
            .txtPrecio.Text = dgProducto.CurrentRow.Cells(3).Value
            .txtpreciovn.Text = dgProducto.CurrentRow.Cells(4).Value
            .btnAgregar.Visible = False
        End With

        Me.Hide()

    End Sub
End Class