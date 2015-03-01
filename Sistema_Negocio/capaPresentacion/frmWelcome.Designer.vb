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
        Me.InicioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuNombre = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.CerrarSesiónToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuMantenimiento = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuUsuario = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuProducto = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuCliente = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuProveedor = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuVentas = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuBoleta = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuFactura = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuPedido = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuConsultas = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuConsultaBoleta = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuConsultaFactura = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuConsultaPedido = New System.Windows.Forms.ToolStripMenuItem()
        Me.VentasPorFechaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProductosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuCompraMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuCompras = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuReporte = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnurpVenta = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnrReporteCompra = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportePorFechaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BoletaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FacturaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FechaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.MenuStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip
        '
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InicioToolStripMenuItem, Me.mnuMantenimiento, Me.mnuVentas, Me.mnuConsultas, Me.mnuCompraMenu, Me.mnuReporte})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Size = New System.Drawing.Size(632, 24)
        Me.MenuStrip.TabIndex = 5
        Me.MenuStrip.Text = "MenuStrip"
        '
        'InicioToolStripMenuItem
        '
        Me.InicioToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuNombre, Me.ToolStripSeparator1, Me.CerrarSesiónToolStripMenuItem})
        Me.InicioToolStripMenuItem.Name = "InicioToolStripMenuItem"
        Me.InicioToolStripMenuItem.Size = New System.Drawing.Size(48, 20)
        Me.InicioToolStripMenuItem.Text = "Inicio"
        '
        'mnuNombre
        '
        Me.mnuNombre.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mnuNombre.Name = "mnuNombre"
        Me.mnuNombre.Size = New System.Drawing.Size(143, 24)
        Me.mnuNombre.Text = "Nombre"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(140, 6)
        '
        'CerrarSesiónToolStripMenuItem
        '
        Me.CerrarSesiónToolStripMenuItem.Name = "CerrarSesiónToolStripMenuItem"
        Me.CerrarSesiónToolStripMenuItem.Size = New System.Drawing.Size(143, 24)
        Me.CerrarSesiónToolStripMenuItem.Text = "Cerrar Sesión"
        '
        'mnuMantenimiento
        '
        Me.mnuMantenimiento.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuUsuario, Me.mnuProducto, Me.mnuCliente, Me.mnuProveedor})
        Me.mnuMantenimiento.ImageTransparentColor = System.Drawing.SystemColors.ActiveBorder
        Me.mnuMantenimiento.Name = "mnuMantenimiento"
        Me.mnuMantenimiento.Size = New System.Drawing.Size(101, 20)
        Me.mnuMantenimiento.Text = "Mantenimiento"
        '
        'mnuUsuario
        '
        Me.mnuUsuario.ImageTransparentColor = System.Drawing.Color.Black
        Me.mnuUsuario.Name = "mnuUsuario"
        Me.mnuUsuario.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.A), System.Windows.Forms.Keys)
        Me.mnuUsuario.Size = New System.Drawing.Size(168, 22)
        Me.mnuUsuario.Text = "Usuario"
        '
        'mnuProducto
        '
        Me.mnuProducto.ImageTransparentColor = System.Drawing.Color.Black
        Me.mnuProducto.Name = "mnuProducto"
        Me.mnuProducto.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.mnuProducto.Size = New System.Drawing.Size(168, 22)
        Me.mnuProducto.Text = "Producto"
        '
        'mnuCliente
        '
        Me.mnuCliente.ImageTransparentColor = System.Drawing.Color.Black
        Me.mnuCliente.Name = "mnuCliente"
        Me.mnuCliente.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.D), System.Windows.Forms.Keys)
        Me.mnuCliente.Size = New System.Drawing.Size(168, 22)
        Me.mnuCliente.Text = "Cliente"
        '
        'mnuProveedor
        '
        Me.mnuProveedor.Name = "mnuProveedor"
        Me.mnuProveedor.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.F), System.Windows.Forms.Keys)
        Me.mnuProveedor.Size = New System.Drawing.Size(168, 22)
        Me.mnuProveedor.Text = "Proveedor"
        '
        'mnuVentas
        '
        Me.mnuVentas.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuBoleta, Me.mnuFactura, Me.mnuPedido})
        Me.mnuVentas.Name = "mnuVentas"
        Me.mnuVentas.Size = New System.Drawing.Size(54, 20)
        Me.mnuVentas.Text = "Ventas"
        '
        'mnuBoleta
        '
        Me.mnuBoleta.Name = "mnuBoleta"
        Me.mnuBoleta.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.D1), System.Windows.Forms.Keys)
        Me.mnuBoleta.Size = New System.Drawing.Size(197, 22)
        Me.mnuBoleta.Text = "Generar Boleta"
        '
        'mnuFactura
        '
        Me.mnuFactura.Name = "mnuFactura"
        Me.mnuFactura.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.D2), System.Windows.Forms.Keys)
        Me.mnuFactura.Size = New System.Drawing.Size(197, 22)
        Me.mnuFactura.Text = "Generar Factura"
        '
        'mnuPedido
        '
        Me.mnuPedido.Name = "mnuPedido"
        Me.mnuPedido.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.D3), System.Windows.Forms.Keys)
        Me.mnuPedido.Size = New System.Drawing.Size(197, 22)
        Me.mnuPedido.Text = "Generar Pedido"
        '
        'mnuConsultas
        '
        Me.mnuConsultas.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuConsultaBoleta, Me.mnuConsultaFactura, Me.mnuConsultaPedido, Me.VentasPorFechaToolStripMenuItem, Me.ProductosToolStripMenuItem})
        Me.mnuConsultas.Name = "mnuConsultas"
        Me.mnuConsultas.Size = New System.Drawing.Size(71, 20)
        Me.mnuConsultas.Text = "Consultas"
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
        'ProductosToolStripMenuItem
        '
        Me.ProductosToolStripMenuItem.Name = "ProductosToolStripMenuItem"
        Me.ProductosToolStripMenuItem.Size = New System.Drawing.Size(164, 22)
        Me.ProductosToolStripMenuItem.Text = "Productos"
        '
        'mnuCompraMenu
        '
        Me.mnuCompraMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuCompras})
        Me.mnuCompraMenu.Name = "mnuCompraMenu"
        Me.mnuCompraMenu.Size = New System.Drawing.Size(67, 20)
        Me.mnuCompraMenu.Text = "Compras"
        '
        'mnuCompras
        '
        Me.mnuCompras.Name = "mnuCompras"
        Me.mnuCompras.Size = New System.Drawing.Size(161, 22)
        Me.mnuCompras.Text = "Generar Compra"
        '
        'mnuReporte
        '
        Me.mnuReporte.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnurpVenta, Me.mnrReporteCompra, Me.ReportePorFechaToolStripMenuItem})
        Me.mnuReporte.Name = "mnuReporte"
        Me.mnuReporte.Size = New System.Drawing.Size(60, 20)
        Me.mnuReporte.Text = "Reporte"
        '
        'mnurpVenta
        '
        Me.mnurpVenta.Name = "mnurpVenta"
        Me.mnurpVenta.Size = New System.Drawing.Size(168, 22)
        Me.mnurpVenta.Text = "Reporte Venta"
        '
        'mnrReporteCompra
        '
        Me.mnrReporteCompra.Name = "mnrReporteCompra"
        Me.mnrReporteCompra.Size = New System.Drawing.Size(168, 22)
        Me.mnrReporteCompra.Text = "Reporte Compra"
        '
        'ReportePorFechaToolStripMenuItem
        '
        Me.ReportePorFechaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BoletaToolStripMenuItem, Me.FacturaToolStripMenuItem, Me.FechaToolStripMenuItem})
        Me.ReportePorFechaToolStripMenuItem.Name = "ReportePorFechaToolStripMenuItem"
        Me.ReportePorFechaToolStripMenuItem.Size = New System.Drawing.Size(168, 22)
        Me.ReportePorFechaToolStripMenuItem.Text = "Reporte por fecha"
        '
        'BoletaToolStripMenuItem
        '
        Me.BoletaToolStripMenuItem.Name = "BoletaToolStripMenuItem"
        Me.BoletaToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.BoletaToolStripMenuItem.Text = "Boleta"
        '
        'FacturaToolStripMenuItem
        '
        Me.FacturaToolStripMenuItem.Name = "FacturaToolStripMenuItem"
        Me.FacturaToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.FacturaToolStripMenuItem.Text = "Factura"
        '
        'FechaToolStripMenuItem
        '
        Me.FechaToolStripMenuItem.Name = "FechaToolStripMenuItem"
        Me.FechaToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.FechaToolStripMenuItem.Text = "Pedido"
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
        Me.Text = "Construcent"
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
    Friend WithEvents mnuProveedor As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuVentas As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuBoleta As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuConsultas As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuConsultaBoleta As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuFactura As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuPedido As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuConsultaFactura As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuConsultaPedido As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuCompraMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuCompras As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuReporte As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnurpVenta As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnrReporteCompra As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReportePorFechaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VentasPorFechaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ProductosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents InicioToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CerrarSesiónToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuNombre As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BoletaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FacturaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FechaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
