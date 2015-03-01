<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCompras
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
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.lblFechaSistema = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Eliminar = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.codPro = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.descripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.punit = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.preven = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.descuento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.importe = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtcondicionpago = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtpreciovn = New System.Windows.Forms.TextBox()
        Me.lblCodigo = New System.Windows.Forms.Label()
        Me.txtdescuento = New System.Windows.Forms.TextBox()
        Me.lblimporte = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.chkNormal = New System.Windows.Forms.CheckBox()
        Me.chkPorcentaje = New System.Windows.Forms.CheckBox()
        Me.txtfactura = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnCalcular = New System.Windows.Forms.Button()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.chkRUC = New System.Windows.Forms.CheckBox()
        Me.chkDNI = New System.Windows.Forms.CheckBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.btnQuitarProducto = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnGrabar = New System.Windows.Forms.Button()
        Me.txtVendedor = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtPrecio = New System.Windows.Forms.TextBox()
        Me.txtCantidad = New System.Windows.Forms.TextBox()
        Me.txtDescripcion = New System.Windows.Forms.TextBox()
        Me.txtidPro = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtReferencia = New System.Windows.Forms.MaskedTextBox()
        Me.txtDireccion = New System.Windows.Forms.MaskedTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtDocumento = New System.Windows.Forms.TextBox()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.dgDetalle = New System.Windows.Forms.DataGridView()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnAgregarProd = New System.Windows.Forms.Button()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtNombre
        '
        Me.txtNombre.Enabled = False
        Me.txtNombre.Location = New System.Drawing.Point(85, 30)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(378, 20)
        Me.txtNombre.TabIndex = 3
        '
        'lblFechaSistema
        '
        Me.lblFechaSistema.AutoSize = True
        Me.lblFechaSistema.Location = New System.Drawing.Point(65, 34)
        Me.lblFechaSistema.Name = "lblFechaSistema"
        Me.lblFechaSistema.Size = New System.Drawing.Size(92, 13)
        Me.lblFechaSistema.TabIndex = 1
        Me.lblFechaSistema.Text = "FECHA SISTEMA"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(15, 34)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(44, 13)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Huaral, "
        '
        'Eliminar
        '
        Me.Eliminar.HeaderText = "Eliminar"
        Me.Eliminar.Name = "Eliminar"
        '
        'codPro
        '
        Me.codPro.HeaderText = "codPro"
        Me.codPro.Name = "codPro"
        '
        'descripcion
        '
        Me.descripcion.FillWeight = 150.0!
        Me.descripcion.HeaderText = "Producto"
        Me.descripcion.Name = "descripcion"
        Me.descripcion.Width = 170
        '
        'cantidad
        '
        Me.cantidad.HeaderText = "Cantidad"
        Me.cantidad.Name = "cantidad"
        '
        'punit
        '
        Me.punit.HeaderText = "Precio Compra"
        Me.punit.Name = "punit"
        '
        'preven
        '
        Me.preven.HeaderText = "Precio Venta"
        Me.preven.Name = "preven"
        '
        'descuento
        '
        Me.descuento.HeaderText = "Descuento"
        Me.descuento.Name = "descuento"
        '
        'importe
        '
        Me.importe.HeaderText = "importe"
        Me.importe.Name = "importe"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(515, 234)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(97, 13)
        Me.Label15.TabIndex = 130
        Me.Label15.Text = "Condiciòn de Pago"
        '
        'txtcondicionpago
        '
        Me.txtcondicionpago.Enabled = False
        Me.txtcondicionpago.Location = New System.Drawing.Point(620, 230)
        Me.txtcondicionpago.Name = "txtcondicionpago"
        Me.txtcondicionpago.Size = New System.Drawing.Size(238, 20)
        Me.txtcondicionpago.TabIndex = 129
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(224, 320)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 13)
        Me.Label3.TabIndex = 124
        Me.Label3.Text = "Precio Venta"
        '
        'txtpreciovn
        '
        Me.txtpreciovn.Location = New System.Drawing.Point(298, 316)
        Me.txtpreciovn.Name = "txtpreciovn"
        Me.txtpreciovn.Size = New System.Drawing.Size(70, 20)
        Me.txtpreciovn.TabIndex = 123
        '
        'lblCodigo
        '
        Me.lblCodigo.AutoSize = True
        Me.lblCodigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCodigo.Location = New System.Drawing.Point(672, 56)
        Me.lblCodigo.Name = "lblCodigo"
        Me.lblCodigo.Size = New System.Drawing.Size(90, 24)
        Me.lblCodigo.TabIndex = 122
        Me.lblCodigo.Text = "CODIGO"
        '
        'txtdescuento
        '
        Me.txtdescuento.Location = New System.Drawing.Point(214, 16)
        Me.txtdescuento.Name = "txtdescuento"
        Me.txtdescuento.Size = New System.Drawing.Size(79, 20)
        Me.txtdescuento.TabIndex = 84
        '
        'lblimporte
        '
        Me.lblimporte.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblimporte.Location = New System.Drawing.Point(825, 613)
        Me.lblimporte.Name = "lblimporte"
        Me.lblimporte.Size = New System.Drawing.Size(76, 21)
        Me.lblimporte.TabIndex = 126
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.chkNormal)
        Me.GroupBox3.Controls.Add(Me.chkPorcentaje)
        Me.GroupBox3.Controls.Add(Me.txtdescuento)
        Me.GroupBox3.Location = New System.Drawing.Point(402, 299)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(304, 46)
        Me.GroupBox3.TabIndex = 125
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Tipo de descuento"
        '
        'chkNormal
        '
        Me.chkNormal.AutoSize = True
        Me.chkNormal.Location = New System.Drawing.Point(116, 21)
        Me.chkNormal.Name = "chkNormal"
        Me.chkNormal.Size = New System.Drawing.Size(80, 17)
        Me.chkNormal.TabIndex = 85
        Me.chkNormal.Text = "Normal(0,0)"
        Me.chkNormal.UseVisualStyleBackColor = True
        '
        'chkPorcentaje
        '
        Me.chkPorcentaje.AutoSize = True
        Me.chkPorcentaje.Location = New System.Drawing.Point(15, 21)
        Me.chkPorcentaje.Name = "chkPorcentaje"
        Me.chkPorcentaje.Size = New System.Drawing.Size(91, 17)
        Me.chkPorcentaje.TabIndex = 85
        Me.chkPorcentaje.Text = "Porcentaje(%)"
        Me.chkPorcentaje.UseVisualStyleBackColor = True
        '
        'txtfactura
        '
        Me.txtfactura.Location = New System.Drawing.Point(689, 102)
        Me.txtfactura.Name = "txtfactura"
        Me.txtfactura.Size = New System.Drawing.Size(165, 20)
        Me.txtfactura.TabIndex = 121
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(564, 105)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(121, 13)
        Me.Label2.TabIndex = 120
        Me.Label2.Text = "Ingrese Numero Factura"
        '
        'btnCalcular
        '
        Me.btnCalcular.Location = New System.Drawing.Point(711, 613)
        Me.btnCalcular.Name = "btnCalcular"
        Me.btnCalcular.Size = New System.Drawing.Size(75, 23)
        Me.btnCalcular.TabIndex = 119
        Me.btnCalcular.Text = "CALCULAR"
        Me.btnCalcular.UseVisualStyleBackColor = True
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(228, 277)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(53, 13)
        Me.Label13.TabIndex = 117
        Me.Label13.Text = "Producto "
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(65, 320)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(76, 13)
        Me.Label14.TabIndex = 116
        Me.Label14.Text = "Precio Compra"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(549, 277)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(49, 13)
        Me.Label12.TabIndex = 115
        Me.Label12.Text = "Cantidad"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(68, 276)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(41, 13)
        Me.Label11.TabIndex = 114
        Me.Label11.Text = "codPro"
        '
        'chkRUC
        '
        Me.chkRUC.AutoSize = True
        Me.chkRUC.Location = New System.Drawing.Point(316, 62)
        Me.chkRUC.Name = "chkRUC"
        Me.chkRUC.Size = New System.Drawing.Size(49, 17)
        Me.chkRUC.TabIndex = 112
        Me.chkRUC.Text = "RUC"
        Me.chkRUC.UseVisualStyleBackColor = True
        '
        'chkDNI
        '
        Me.chkDNI.AutoSize = True
        Me.chkDNI.Location = New System.Drawing.Point(254, 63)
        Me.chkDNI.Name = "chkDNI"
        Me.chkDNI.Size = New System.Drawing.Size(45, 17)
        Me.chkDNI.TabIndex = 113
        Me.chkDNI.Text = "DNI"
        Me.chkDNI.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(347, 618)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(338, 13)
        Me.Label10.TabIndex = 111
        Me.Label10.Text = "Seleccion la opcion calcular para ver el monto de descuento y importe"
        '
        'btnAgregar
        '
        Me.btnAgregar.Location = New System.Drawing.Point(750, 286)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(89, 34)
        Me.btnAgregar.TabIndex = 108
        Me.btnAgregar.Text = "Buscar Producto"
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'btnQuitarProducto
        '
        Me.btnQuitarProducto.Location = New System.Drawing.Point(906, 414)
        Me.btnQuitarProducto.Name = "btnQuitarProducto"
        Me.btnQuitarProducto.Size = New System.Drawing.Size(92, 39)
        Me.btnQuitarProducto.TabIndex = 107
        Me.btnQuitarProducto.Text = "QUITAR PRODUCTO"
        Me.btnQuitarProducto.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(906, 568)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(89, 31)
        Me.btnCancelar.TabIndex = 106
        Me.btnCancelar.Text = "CANCELAR"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnGrabar
        '
        Me.btnGrabar.Location = New System.Drawing.Point(906, 521)
        Me.btnGrabar.Name = "btnGrabar"
        Me.btnGrabar.Size = New System.Drawing.Size(89, 41)
        Me.btnGrabar.TabIndex = 109
        Me.btnGrabar.Text = "GUARDAR COMPRA"
        Me.btnGrabar.UseVisualStyleBackColor = True
        '
        'txtVendedor
        '
        Me.txtVendedor.Location = New System.Drawing.Point(199, 227)
        Me.txtVendedor.Name = "txtVendedor"
        Me.txtVendedor.Size = New System.Drawing.Size(255, 20)
        Me.txtVendedor.TabIndex = 105
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(66, 230)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(127, 13)
        Me.Label5.TabIndex = 104
        Me.Label5.Text = "NOMBRE COMPRADOR"
        '
        'txtPrecio
        '
        Me.txtPrecio.Location = New System.Drawing.Point(147, 317)
        Me.txtPrecio.Name = "txtPrecio"
        Me.txtPrecio.Size = New System.Drawing.Size(70, 20)
        Me.txtPrecio.TabIndex = 98
        '
        'txtCantidad
        '
        Me.txtCantidad.Enabled = False
        Me.txtCantidad.Location = New System.Drawing.Point(616, 273)
        Me.txtCantidad.Name = "txtCantidad"
        Me.txtCantidad.Size = New System.Drawing.Size(79, 20)
        Me.txtCantidad.TabIndex = 97
        '
        'txtDescripcion
        '
        Me.txtDescripcion.Enabled = False
        Me.txtDescripcion.Location = New System.Drawing.Point(287, 273)
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(238, 20)
        Me.txtDescripcion.TabIndex = 96
        '
        'txtidPro
        '
        Me.txtidPro.Enabled = False
        Me.txtidPro.Location = New System.Drawing.Point(116, 273)
        Me.txtidPro.Name = "txtidPro"
        Me.txtidPro.Size = New System.Drawing.Size(101, 20)
        Me.txtidPro.TabIndex = 95
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtCodigo)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtReferencia)
        Me.GroupBox1.Controls.Add(Me.txtDireccion)
        Me.GroupBox1.Controls.Add(Me.txtNombre)
        Me.GroupBox1.Location = New System.Drawing.Point(62, 86)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(482, 130)
        Me.GroupBox1.TabIndex = 100
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos Proveedor"
        '
        'txtCodigo
        '
        Me.txtCodigo.Location = New System.Drawing.Point(9, 30)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(16, 20)
        Me.txtCodigo.TabIndex = 48
        Me.txtCodigo.Visible = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(13, 100)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(64, 13)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "TELEFONO"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(13, 67)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(66, 13)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "DIRECCION"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(31, 33)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(48, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "SEÑOR "
        '
        'txtReferencia
        '
        Me.txtReferencia.Enabled = False
        Me.txtReferencia.Location = New System.Drawing.Point(85, 97)
        Me.txtReferencia.Name = "txtReferencia"
        Me.txtReferencia.Size = New System.Drawing.Size(378, 20)
        Me.txtReferencia.TabIndex = 4
        '
        'txtDireccion
        '
        Me.txtDireccion.Enabled = False
        Me.txtDireccion.Location = New System.Drawing.Point(85, 64)
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.Size = New System.Drawing.Size(378, 20)
        Me.txtDireccion.TabIndex = 5
        Me.txtDireccion.ValidatingType = GetType(Integer)
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(59, 62)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 13)
        Me.Label1.TabIndex = 99
        Me.Label1.Text = "DOCUMENTO"
        '
        'txtDocumento
        '
        Me.txtDocumento.Location = New System.Drawing.Point(142, 61)
        Me.txtDocumento.Name = "txtDocumento"
        Me.txtDocumento.Size = New System.Drawing.Size(106, 20)
        Me.txtDocumento.TabIndex = 94
        '
        'btnBuscar
        '
        Me.btnBuscar.Location = New System.Drawing.Point(379, 58)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(75, 23)
        Me.btnBuscar.TabIndex = 101
        Me.btnBuscar.Text = "OBTENER"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'dgDetalle
        '
        Me.dgDetalle.AllowUserToAddRows = False
        Me.dgDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgDetalle.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Eliminar, Me.codPro, Me.descripcion, Me.cantidad, Me.punit, Me.preven, Me.descuento, Me.importe})
        Me.dgDetalle.Location = New System.Drawing.Point(11, 351)
        Me.dgDetalle.Name = "dgDetalle"
        Me.dgDetalle.Size = New System.Drawing.Size(890, 251)
        Me.dgDetalle.TabIndex = 103
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lblFechaSistema)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Location = New System.Drawing.Point(567, 150)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(291, 67)
        Me.GroupBox2.TabIndex = 102
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Fecha"
        '
        'btnAgregarProd
        '
        Me.btnAgregarProd.Location = New System.Drawing.Point(906, 368)
        Me.btnAgregarProd.Name = "btnAgregarProd"
        Me.btnAgregarProd.Size = New System.Drawing.Size(89, 40)
        Me.btnAgregarProd.TabIndex = 118
        Me.btnAgregarProd.Text = "AGREGAR PRODUCTO"
        Me.btnAgregarProd.UseVisualStyleBackColor = True
        '
        'frmCompras
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1023, 696)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.txtcondicionpago)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtpreciovn)
        Me.Controls.Add(Me.lblCodigo)
        Me.Controls.Add(Me.lblimporte)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.txtfactura)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnCalcular)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.chkRUC)
        Me.Controls.Add(Me.chkDNI)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.btnQuitarProducto)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnGrabar)
        Me.Controls.Add(Me.txtVendedor)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtPrecio)
        Me.Controls.Add(Me.txtCantidad)
        Me.Controls.Add(Me.txtDescripcion)
        Me.Controls.Add(Me.txtidPro)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtDocumento)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.dgDetalle)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.btnAgregarProd)
        Me.Name = "frmCompras"
        Me.Text = "frmCompras"
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents lblFechaSistema As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Eliminar As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents codPro As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents descripcion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cantidad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents punit As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents preven As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents descuento As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents importe As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txtcondicionpago As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtpreciovn As System.Windows.Forms.TextBox
    Friend WithEvents lblCodigo As System.Windows.Forms.Label
    Friend WithEvents txtdescuento As System.Windows.Forms.TextBox
    Friend WithEvents lblimporte As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents txtfactura As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnCalcular As System.Windows.Forms.Button
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents chkRUC As System.Windows.Forms.CheckBox
    Friend WithEvents chkDNI As System.Windows.Forms.CheckBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Public WithEvents btnAgregar As System.Windows.Forms.Button
    Friend WithEvents btnQuitarProducto As System.Windows.Forms.Button
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents btnGrabar As System.Windows.Forms.Button
    Friend WithEvents txtVendedor As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtPrecio As System.Windows.Forms.TextBox
    Friend WithEvents txtCantidad As System.Windows.Forms.TextBox
    Friend WithEvents txtDescripcion As System.Windows.Forms.TextBox
    Friend WithEvents txtidPro As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtCodigo As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtReferencia As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtDireccion As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtDocumento As System.Windows.Forms.TextBox
    Friend WithEvents btnBuscar As System.Windows.Forms.Button
    Friend WithEvents dgDetalle As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btnAgregarProd As System.Windows.Forms.Button
    Friend WithEvents chkNormal As System.Windows.Forms.CheckBox
    Friend WithEvents chkPorcentaje As System.Windows.Forms.CheckBox
End Class
