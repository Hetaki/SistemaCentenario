<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmWelcome
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub


    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.MenuStrip = New System.Windows.Forms.MenuStrip()
        Me.mnuMantenimiento = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuUsuario = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuProducto = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuCliente = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuProveedor = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.VentasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuBoleta = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuFactura = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuPedido = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuConsultaBoleta = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuConsultaFactura = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuConsultaPedido = New System.Windows.Forms.ToolStripMenuItem()
        Me.VentasPorFechaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ComprasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuCompras = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReporteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnurpVenta = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnrReporteCompra = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportePorFechaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.ProductosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip
        '
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuMantenimiento, Me.VentasToolStripMenuItem, Me.ConsultasToolStripMenuItem, Me.ComprasToolStripMenuItem, Me.ReporteToolStripMenuItem})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Size = New System.Drawing.Size(632, 24)
        Me.MenuStrip.TabIndex = 5
        Me.MenuStrip.Text = "MenuStrip"
        '
        'mnuMantenimiento
        '
        Me.mnuMantenimiento.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuUsuario, Me.mnuProducto, Me.mnuCliente, Me.mnuProveedor, Me.ToolStripSeparator1, Me.ToolStripMenuItem1})
        Me.mnuMantenimiento.ImageTransparentColor = System.Drawing.SystemColors.ActiveBorder
        Me.mnuMantenimiento.Name = "mnuMantenimiento"
        Me.mnuMantenimiento.Size = New System.Drawing.Size(101, 20)
        Me.mnuMantenimiento.Text = "Mantenimiento"
        '
        'mnuUsuario
        '
        Me.mnuUsuario.ImageTransparentColor = System.Drawing.Color.Black
        Me.mnuUsuario.Name = "mnuUsuario"
        Me.mnuUsuario.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.N), System.Windows.Forms.Keys)
        Me.mnuUsuario.Size = New System.Drawing.Size(166, 22)
        Me.mnuUsuario.Text = "Usuario"
        '
        'mnuProducto
        '
        Me.mnuProducto.ImageTransparentColor = System.Drawing.Color.Black
        Me.mnuProducto.Name = "mnuProducto"
        Me.mnuProducto.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.O), System.Windows.Forms.Keys)
        Me.mnuProducto.Size = New System.Drawing.Size(166, 22)
        Me.mnuProducto.Text = "Producto"
        '
        'mnuCliente
        '
        Me.mnuCliente.ImageTransparentColor = System.Drawing.Color.Black
        Me.mnuCliente.Name = "mnuCliente"
        Me.mnuCliente.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.mnuCliente.Size = New System.Drawing.Size(166, 22)
        Me.mnuCliente.Text = "Cliente"
        '
        'mnuProveedor
        '
        Me.mnuProveedor.Name = "mnuProveedor"
        Me.mnuProveedor.Size = New System.Drawing.Size(166, 22)
        Me.mnuProveedor.Text = "Proveedor"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(163, 6)
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(166, 22)
        Me.ToolStripMenuItem1.Text = "Salir"
        '
        'VentasToolStripMenuItem
        '
        Me.VentasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuBoleta, Me.mnuFactura, Me.mnuPedido})
        Me.VentasToolStripMenuItem.Name = "VentasToolStripMenuItem"
        Me.VentasToolStripMenuItem.Size = New System.Drawing.Size(54, 20)
        Me.VentasToolStripMenuItem.Text = "Ventas"
        '
        'mnuBoleta
        '
        Me.mnuBoleta.Name = "mnuBoleta"
        Me.mnuBoleta.Size = New System.Drawing.Size(157, 22)
        Me.mnuBoleta.Text = "Generar Boleta"
        '
        'mnuFactura
        '
        Me.mnuFactura.Name = "mnuFactura"
        Me.mnuFactura.Size = New System.Drawing.Size(157, 22)
        Me.mnuFactura.Text = "Generar Factura"
        '
        'mnuPedido
        '
        Me.mnuPedido.Name = "mnuPedido"
        Me.mnuPedido.Size = New System.Drawing.Size(157, 22)
        Me.mnuPedido.Text = "Generar Pedido"
        '
        'ConsultasToolStripMenuItem
        '
        Me.ConsultasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuConsultaBoleta, Me.mnuConsultaFactura, Me.mnuConsultaPedido, Me.VentasPorFechaToolStripMenuItem, Me.ProductosToolStripMenuItem})
        Me.ConsultasToolStripMenuItem.Name = "ConsultasToolStripMenuItem"
        Me.ConsultasToolStripMenuItem.Size = New System.Drawing.Size(71, 20)
        Me.ConsultasToolStripMenuItem.Text = "Consultas"
        '
        'mnuConsultaBoleta
        '
        Me.mnuConsultaBoleta.Name = "mnuConsultaBoleta"
        Me.mnuConsultaBoleta.Size = New System.Drawing.Size(164, 22)
        Me.mnuConsultaBoleta.Text = "Boleta"
        '
        'mnuConsultaFactura
        '
        Me.mnuConsultaFactura.Name = "mnuConsultaFactura"
        Me.mnuConsultaFactura.Size = New System.Drawing.Size(164, 22)
        Me.mnuConsultaFactura.Text = "Factura"
        '
        'mnuConsultaPedido
        '
        Me.mnuConsultaPedido.Name = "mnuConsultaPedido"
        Me.mnuConsultaPedido.Size = New System.Drawing.Size(164, 22)
        Me.mnuConsultaPedido.Text = "Pedido"
        '
        'VentasPorFechaToolStripMenuItem
        '
        Me.VentasPorFechaToolStripMenuItem.Name = "VentasPorFechaToolStripMenuItem"
        Me.VentasPorFechaToolStripMenuItem.Size = New System.Drawing.Size(164, 22)
        Me.VentasPorFechaToolStripMenuItem.Text = "Ventas Por Fecha"
        '
        'ComprasToolStripMenuItem
        '
        Me.ComprasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuCompras})
        Me.ComprasToolStripMenuItem.Name = "ComprasToolStripMenuItem"
        Me.ComprasToolStripMenuItem.Size = New System.Drawing.Size(67, 20)
        Me.ComprasToolStripMenuItem.Text = "Compras"
        '
        'mnuCompras
        '
        Me.mnuCompras.Name = "mnuCompras"
        Me.mnuCompras.Size = New System.Drawing.Size(161, 22)
        Me.mnuCompras.Text = "Generar Compra"
        '
        'ReporteToolStripMenuItem
        '
        Me.ReporteToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnurpVenta, Me.mnrReporteCompra, Me.ReportePorFechaToolStripMenuItem})
        Me.ReporteToolStripMenuItem.Name = "ReporteToolStripMenuItem"
        Me.ReporteToolStripMenuItem.Size = New System.Drawing.Size(60, 20)
        Me.ReporteToolStripMenuItem.Text = "Reporte"
        '
        'mnurpVenta
        '
        Me.mnurpVenta.Name = "mnurpVenta"
        Me.mnurpVenta.Size = New System.Drawing.Size(168, 22)
        Me.mnurpVenta.Text = "reporte Venta"
        '
        'mnrReporteCompra
        '
        Me.mnrReporteCompra.Name = "mnrReporteCompra"
        Me.mnrReporteCompra.Size = New System.Drawing.Size(168, 22)
        Me.mnrReporteCompra.Text = "Reporte Compra"
        '
        'ReportePorFechaToolStripMenuItem
        '
        Me.ReportePorFechaToolStripMenuItem.Name = "ReportePorFechaToolStripMenuItem"
        Me.ReportePorFechaToolStripMenuItem.Size = New System.Drawing.Size(168, 22)
        Me.ReportePorFechaToolStripMenuItem.Text = "Reporte por fecha"
        '
        'ProductosToolStripMenuItem
        '
        Me.ProductosToolStripMenuItem.Name = "ProductosToolStripMenuItem"
        Me.ProductosToolStripMenuItem.Size = New System.Drawing.Size(164, 22)
        Me.ProductosToolStripMenuItem.Text = "Productos"
        '
        'frmWelcome
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(632, 453)
        Me.Controls.Add(Me.MenuStrip)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip
        Me.Name = "frmWelcome"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmWelcome"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents mnuUsuario As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuMantenimiento As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuProducto As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuCliente As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuProveedor As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VentasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuBoleta As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConsultasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuConsultaBoleta As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuFactura As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuPedido As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuConsultaFactura As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuConsultaPedido As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ComprasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuCompras As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReporteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnurpVenta As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnrReporteCompra As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReportePorFechaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VentasPorFechaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ProductosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
