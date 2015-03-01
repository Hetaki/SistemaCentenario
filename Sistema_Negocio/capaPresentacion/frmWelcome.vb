Imports System.Windows.Forms
Public Class frmWelcome
    Private Sub mnuUsuario_Click(sender As Object, e As EventArgs) Handles mnuUsuario.Click
        frmUsuario.MdiParent = Me
        frmUsuario.Show()
        frmUsuario.Activate()
    End Sub

    Private Sub mnuProducto_Click(sender As Object, e As EventArgs) Handles mnuProducto.Click
        frmProducto.MdiParent = Me
        frmProducto.Show()
        frmProducto.Activate()
    End Sub

    Private Sub mnuCliente_Click(sender As Object, e As EventArgs) Handles mnuCliente.Click
        frmCliente.MdiParent = Me
        frmCliente.Show()
        frmCliente.Activate()
    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        Me.Close()
        frmLogin.Close()
    End Sub

    Private Sub mnuProveedor_Click(sender As Object, e As EventArgs) Handles mnuProveedor.Click
        frmProveedor.MdiParent = Me
        frmProveedor.Show()
        frmProveedor.Activate()
    End Sub

    Private Sub frmWelcome_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        frmLogin.Close()
    End Sub

    Private Sub mnuBoleta_Click(sender As Object, e As EventArgs) Handles mnuBoleta.Click
        frmBoleta.MdiParent = Me
        frmBoleta.Show()
        frmBoleta.Activate()
    End Sub
    Private Sub mnuConsultaBoleta_Click(sender As Object, e As EventArgs) Handles mnuConsultaBoleta.Click
        frmConsultaBoleta.MdiParent = Me
        frmConsultaBoleta.Show()
        frmConsultaBoleta.Activate()
    End Sub

    Private Sub mnuFactura_Click(sender As Object, e As EventArgs) Handles mnuFactura.Click
        frmFactura.MdiParent = Me
        frmFactura.Show()
        frmFactura.Activate()
    End Sub

    Private Sub mnuPedido_Click(sender As Object, e As EventArgs) Handles mnuPedido.Click
        frmPedido.MdiParent = Me
        frmPedido.Show()
        frmPedido.Activate()
    End Sub

    Private Sub mnuConsultaFactura_Click(sender As Object, e As EventArgs) Handles mnuConsultaFactura.Click
        frmConsultaFactura.MdiParent = Me
        frmConsultaFactura.Show()
        frmConsultaFactura.Activate()
    End Sub

    Private Sub mnuConsultaPedido_Click(sender As Object, e As EventArgs) Handles mnuConsultaPedido.Click
        frmConsultaPedido.MdiParent = Me
        frmConsultaPedido.Show()
        frmConsultaPedido.Activate()
    End Sub

    Private Sub mnuCompras_Click(sender As Object, e As EventArgs) Handles mnuCompras.Click
        frmCompras.MdiParent = Me
        frmCompras.Show()
        frmCompras.Activate()
    End Sub

    Private Sub mnurpVenta_Click(sender As Object, e As EventArgs) Handles mnurpVenta.Click
        frmListaCliente.MdiParent = Me
        frmListaCliente.Show()
        frmListaCliente.Activate()
    End Sub
    Private Sub mnrReporteCompra_Click(sender As Object, e As EventArgs) Handles mnrReporteCompra.Click
        frmListaProveedor.MdiParent = Me
        frmListaProveedor.Show()
        frmListaProveedor.Activate()
    End Sub

    Private Sub ReportePorFechaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReportePorFechaToolStripMenuItem.Click
        frmReportexFecha.MdiParent = Me
        frmReportexFecha.Show()
        frmReportexFecha.Activate()
    End Sub

    Private Sub VentasPorFechaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VentasPorFechaToolStripMenuItem.Click
        frmListaVentas.MdiParent = Me
        frmListaVentas.Show()
        frmListaVentas.Activate()
    End Sub

    Private Sub ProductosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProductosToolStripMenuItem.Click
        frmConsultaGeneral.MdiParent = Me
        frmConsultaGeneral.Show()
        frmConsultaGeneral.Activate()
    End Sub
End Class
