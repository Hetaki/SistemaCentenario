Imports System.Windows.Forms
Public Class frmWelcome
    Private Sub mnuUsuario_Click(sender As Object, e As EventArgs) Handles mnuUsuario.Click
        For Each ChildForm1 As Form In Me.MdiChildren
            ChildForm1.Close()
        Next
        Dim ChildForm As New frmUsuario
        ChildForm.MdiParent = Me
        ChildForm.Show()
    End Sub

    Private Sub mnuProducto_Click(sender As Object, e As EventArgs) Handles mnuProducto.Click
        For Each ChildForm1 As Form In Me.MdiChildren
            ChildForm1.Close()
        Next
        Dim ChildForm As New frmProducto
        ChildForm.MdiParent = Me
        ChildForm.Show()
    End Sub

    Private Sub mnuCliente_Click(sender As Object, e As EventArgs) Handles mnuCliente.Click
        For Each ChildForm1 As Form In Me.MdiChildren
            ChildForm1.Close()
        Next
        Dim ChildForm As New frmCliente
        ChildForm.MdiParent = Me
        ChildForm.Show()
    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        Me.Close()
        frmLogin.Close()
    End Sub

    Private Sub mnuProveedor_Click(sender As Object, e As EventArgs) Handles mnuProveedor.Click
        For Each ChildForm1 As Form In Me.MdiChildren
            ChildForm1.Close()
        Next
        Dim ChildForm As New frmProveedor
        ChildForm.MdiParent = Me
        ChildForm.Show()
    End Sub

    Private Sub frmWelcome_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        frmLogin.Close()
    End Sub

    Private Sub mnuBoleta_Click(sender As Object, e As EventArgs) Handles mnuBoleta.Click
        For Each ChildForm1 As Form In Me.MdiChildren
            ChildForm1.Close()
        Next
        Dim ChildForm As New frmBoleta
        ChildForm.MdiParent = Me
        ChildForm.Show()
    End Sub
    Private Sub mnuConsultaBoleta_Click(sender As Object, e As EventArgs) Handles mnuConsultaBoleta.Click
        For Each ChildForm1 As Form In Me.MdiChildren
            ChildForm1.Close()
        Next
        Dim ChildForm As New frmConsultaBoleta
        ChildForm.MdiParent = Me
        ChildForm.Show()
    End Sub

    Private Sub mnuFactura_Click(sender As Object, e As EventArgs) Handles mnuFactura.Click
        For Each ChildForm1 As Form In Me.MdiChildren
            ChildForm1.Close()
        Next
        Dim ChildForm As New frmFactura
        ChildForm.MdiParent = Me
        ChildForm.Show()
    End Sub

    Private Sub mnuPedido_Click(sender As Object, e As EventArgs) Handles mnuPedido.Click
        For Each ChildForm1 As Form In Me.MdiChildren
            ChildForm1.Close()
        Next
        Dim ChildForm As New frmPedido
        ChildForm.MdiParent = Me
        ChildForm.Show()
    End Sub

    Private Sub mnuConsultaFactura_Click(sender As Object, e As EventArgs) Handles mnuConsultaFactura.Click
        For Each ChildForm1 As Form In Me.MdiChildren
            ChildForm1.Close()
        Next
        Dim ChildForm As New frmConsultaFactura
        ChildForm.MdiParent = Me
        ChildForm.Show()
    End Sub

    Private Sub mnuConsultaPedido_Click(sender As Object, e As EventArgs) Handles mnuConsultaPedido.Click
        For Each ChildForm1 As Form In Me.MdiChildren
            ChildForm1.Close()
        Next
        Dim ChildForm As New frmConsultaPedido
        ChildForm.MdiParent = Me
        ChildForm.Show()
    End Sub

    Private Sub mnuCompras_Click(sender As Object, e As EventArgs) Handles mnuCompras.Click
        For Each ChildForm1 As Form In Me.MdiChildren
            ChildForm1.Close()
        Next
        Dim ChildForm As New frmCompras
        ChildForm.MdiParent = Me
        ChildForm.Show()
    End Sub

    Private Sub mnurpVenta_Click(sender As Object, e As EventArgs) Handles mnurpVenta.Click
        For Each ChildForm1 As Form In Me.MdiChildren
            ChildForm1.Close()
        Next
        Dim ChildForm As New frmListaCliente
        ChildForm.MdiParent = Me
        ChildForm.Show()
    End Sub

  
    Private Sub mnrReporteCompra_Click(sender As Object, e As EventArgs) Handles mnrReporteCompra.Click
        For Each ChildForm1 As Form In Me.MdiChildren
            ChildForm1.Close()
        Next
        Dim ChildForm As New frmListaProveedor
        ChildForm.MdiParent = Me
        ChildForm.Show()
    End Sub

    Private Sub ReportePorFechaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReportePorFechaToolStripMenuItem.Click
        For Each ChildForm1 As Form In Me.MdiChildren
            ChildForm1.Close()
        Next
        Dim ChildForm As New frmReportexFecha
        ChildForm.MdiParent = Me
        ChildForm.Show()
    End Sub

    Private Sub VentasPorFechaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VentasPorFechaToolStripMenuItem.Click
        For Each ChildForm1 As Form In Me.MdiChildren
            ChildForm1.Close()
        Next
        Dim ChildForm As New frmListaVentas
        ChildForm.MdiParent = Me
        ChildForm.Show()
    End Sub

    Private Sub ProductosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProductosToolStripMenuItem.Click
        For Each ChildForm1 As Form In Me.MdiChildren
            ChildForm1.Close()
        Next
        Dim ChildForm As New frmConsultaGeneral
        ChildForm.MdiParent = Me
        ChildForm.Show()
    End Sub
End Class
