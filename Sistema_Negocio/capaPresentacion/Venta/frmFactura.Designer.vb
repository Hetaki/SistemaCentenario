﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFactura
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmFactura))
        Me.btnCalcular = New System.Windows.Forms.Button()
        Me.btnAgregarProd = New System.Windows.Forms.Button()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.chkRUC = New System.Windows.Forms.CheckBox()
        Me.chkDNI = New System.Windows.Forms.CheckBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lblSubtotal = New System.Windows.Forms.Label()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.btnQuitarProducto = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnGrabar = New System.Windows.Forms.Button()
        Me.txtVendedor = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.dgDetalle = New System.Windows.Forms.DataGridView()
        Me.Eliminar = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.codPro = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.descripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.punit = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.importe = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lblFechaSistema = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtReferencia = New System.Windows.Forms.MaskedTextBox()
        Me.txtDireccion = New System.Windows.Forms.MaskedTextBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtPrecio = New System.Windows.Forms.TextBox()
        Me.txtCantidad = New System.Windows.Forms.TextBox()
        Me.txtDescripcion = New System.Windows.Forms.TextBox()
        Me.txtidPro = New System.Windows.Forms.TextBox()
        Me.txtDocumento = New System.Windows.Forms.TextBox()
        Me.lblCodigo = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblIGV = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.cantIGV = New System.Windows.Forms.Label()
        Me.lblStk = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        CType(Me.dgDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnCalcular
        '
        Me.btnCalcular.Location = New System.Drawing.Point(525, 606)
        Me.btnCalcular.Name = "btnCalcular"
        Me.btnCalcular.Size = New System.Drawing.Size(75, 23)
        Me.btnCalcular.TabIndex = 9
        Me.btnCalcular.Text = "CALCULAR"
        Me.btnCalcular.UseVisualStyleBackColor = True
        '
        'btnAgregarProd
        '
        Me.btnAgregarProd.Location = New System.Drawing.Point(770, 317)
        Me.btnAgregarProd.Name = "btnAgregarProd"
        Me.btnAgregarProd.Size = New System.Drawing.Size(89, 40)
        Me.btnAgregarProd.TabIndex = 8
        Me.btnAgregarProd.Text = "AGREGAR PRODUCTO"
        Me.btnAgregarProd.UseVisualStyleBackColor = True
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(173, 294)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(61, 13)
        Me.Label13.TabIndex = 74
        Me.Label13.Text = "descripcion"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(618, 293)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(37, 13)
        Me.Label14.TabIndex = 73
        Me.Label14.Text = "Precio"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(406, 293)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(48, 13)
        Me.Label12.TabIndex = 72
        Me.Label12.Text = "cantidad"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(50, 294)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(41, 13)
        Me.Label11.TabIndex = 71
        Me.Label11.Text = "codPro"
        '
        'chkRUC
        '
        Me.chkRUC.AutoSize = True
        Me.chkRUC.Location = New System.Drawing.Point(320, 88)
        Me.chkRUC.Name = "chkRUC"
        Me.chkRUC.Size = New System.Drawing.Size(49, 17)
        Me.chkRUC.TabIndex = 2
        Me.chkRUC.Text = "RUC"
        Me.chkRUC.UseVisualStyleBackColor = True
        '
        'chkDNI
        '
        Me.chkDNI.AutoSize = True
        Me.chkDNI.Location = New System.Drawing.Point(258, 89)
        Me.chkDNI.Name = "chkDNI"
        Me.chkDNI.Size = New System.Drawing.Size(45, 17)
        Me.chkDNI.TabIndex = 1
        Me.chkDNI.Text = "DNI"
        Me.chkDNI.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(618, 554)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(64, 13)
        Me.Label10.TabIndex = 68
        Me.Label10.Text = "SUBTOTAL"
        '
        'lblSubtotal
        '
        Me.lblSubtotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblSubtotal.Location = New System.Drawing.Point(688, 550)
        Me.lblSubtotal.Name = "lblSubtotal"
        Me.lblSubtotal.Size = New System.Drawing.Size(76, 21)
        Me.lblSubtotal.TabIndex = 67
        Me.lblSubtotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnAgregar
        '
        Me.btnAgregar.Image = CType(resources.GetObject("btnAgregar.Image"), System.Drawing.Image)
        Me.btnAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAgregar.Location = New System.Drawing.Point(741, 272)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(79, 41)
        Me.btnAgregar.TabIndex = 5
        Me.btnAgregar.Text = "Buscar Producto"
        Me.btnAgregar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'btnQuitarProducto
        '
        Me.btnQuitarProducto.Location = New System.Drawing.Point(767, 363)
        Me.btnQuitarProducto.Name = "btnQuitarProducto"
        Me.btnQuitarProducto.Size = New System.Drawing.Size(92, 39)
        Me.btnQuitarProducto.TabIndex = 64
        Me.btnQuitarProducto.Text = "QUITAR PRODUCTO"
        Me.btnQuitarProducto.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(767, 508)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(89, 31)
        Me.btnCancelar.TabIndex = 63
        Me.btnCancelar.Text = "CANCELAR"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnGrabar
        '
        Me.btnGrabar.Location = New System.Drawing.Point(767, 461)
        Me.btnGrabar.Name = "btnGrabar"
        Me.btnGrabar.Size = New System.Drawing.Size(89, 41)
        Me.btnGrabar.TabIndex = 10
        Me.btnGrabar.Text = "GRABAR FACTURA"
        Me.btnGrabar.UseVisualStyleBackColor = True
        '
        'txtVendedor
        '
        Me.txtVendedor.Location = New System.Drawing.Point(151, 256)
        Me.txtVendedor.Name = "txtVendedor"
        Me.txtVendedor.Size = New System.Drawing.Size(326, 20)
        Me.txtVendedor.TabIndex = 4
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(70, 256)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(68, 13)
        Me.Label5.TabIndex = 61
        Me.Label5.Text = "VENDEDOR"
        '
        'dgDetalle
        '
        Me.dgDetalle.AllowUserToAddRows = False
        Me.dgDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgDetalle.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Eliminar, Me.codPro, Me.descripcion, Me.cantidad, Me.punit, Me.importe})
        Me.dgDetalle.Location = New System.Drawing.Point(51, 316)
        Me.dgDetalle.Name = "dgDetalle"
        Me.dgDetalle.Size = New System.Drawing.Size(713, 222)
        Me.dgDetalle.TabIndex = 60
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
        Me.descripcion.HeaderText = "descripcion"
        Me.descripcion.Name = "descripcion"
        Me.descripcion.Width = 170
        '
        'cantidad
        '
        Me.cantidad.HeaderText = "cantidad"
        Me.cantidad.Name = "cantidad"
        '
        'punit
        '
        Me.punit.HeaderText = "Precio Unitario"
        Me.punit.Name = "punit"
        '
        'importe
        '
        Me.importe.HeaderText = "importe"
        Me.importe.Name = "importe"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lblFechaSistema)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Location = New System.Drawing.Point(502, 175)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(291, 67)
        Me.GroupBox2.TabIndex = 59
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Fecha"
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
        'btnBuscar
        '
        Me.btnBuscar.Location = New System.Drawing.Point(383, 84)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(75, 23)
        Me.btnBuscar.TabIndex = 3
        Me.btnBuscar.Text = "OBTENER"
        Me.btnBuscar.UseVisualStyleBackColor = True
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
        Me.GroupBox1.Location = New System.Drawing.Point(66, 112)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(430, 130)
        Me.GroupBox1.TabIndex = 57
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos del Cliente"
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
        Me.Label7.Location = New System.Drawing.Point(4, 97)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(75, 13)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "REFERENCIA"
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
        Me.txtReferencia.Size = New System.Drawing.Size(216, 20)
        Me.txtReferencia.TabIndex = 4
        '
        'txtDireccion
        '
        Me.txtDireccion.Enabled = False
        Me.txtDireccion.Location = New System.Drawing.Point(85, 64)
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.Size = New System.Drawing.Size(326, 20)
        Me.txtDireccion.TabIndex = 5
        Me.txtDireccion.ValidatingType = GetType(Integer)
        '
        'txtNombre
        '
        Me.txtNombre.Enabled = False
        Me.txtNombre.Location = New System.Drawing.Point(85, 30)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(335, 20)
        Me.txtNombre.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(63, 88)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 13)
        Me.Label1.TabIndex = 56
        Me.Label1.Text = "DOCUMENTO"
        '
        'txtPrecio
        '
        Me.txtPrecio.Enabled = False
        Me.txtPrecio.Location = New System.Drawing.Point(665, 291)
        Me.txtPrecio.Name = "txtPrecio"
        Me.txtPrecio.Size = New System.Drawing.Size(70, 20)
        Me.txtPrecio.TabIndex = 7
        '
        'txtCantidad
        '
        Me.txtCantidad.Enabled = False
        Me.txtCantidad.Location = New System.Drawing.Point(460, 290)
        Me.txtCantidad.Name = "txtCantidad"
        Me.txtCantidad.Size = New System.Drawing.Size(70, 20)
        Me.txtCantidad.TabIndex = 6
        '
        'txtDescripcion
        '
        Me.txtDescripcion.Enabled = False
        Me.txtDescripcion.Location = New System.Drawing.Point(240, 291)
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(160, 20)
        Me.txtDescripcion.TabIndex = 53
        '
        'txtidPro
        '
        Me.txtidPro.Enabled = False
        Me.txtidPro.Location = New System.Drawing.Point(100, 291)
        Me.txtidPro.Name = "txtidPro"
        Me.txtidPro.Size = New System.Drawing.Size(67, 20)
        Me.txtidPro.TabIndex = 52
        '
        'txtDocumento
        '
        Me.txtDocumento.Location = New System.Drawing.Point(146, 87)
        Me.txtDocumento.Name = "txtDocumento"
        Me.txtDocumento.Size = New System.Drawing.Size(106, 20)
        Me.txtDocumento.TabIndex = 0
        '
        'lblCodigo
        '
        Me.lblCodigo.AutoSize = True
        Me.lblCodigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCodigo.Location = New System.Drawing.Point(603, 122)
        Me.lblCodigo.Name = "lblCodigo"
        Me.lblCodigo.Size = New System.Drawing.Size(90, 24)
        Me.lblCodigo.TabIndex = 50
        Me.lblCodigo.Text = "CODIGO"
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Blue
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label3.Location = New System.Drawing.Point(521, 92)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(286, 24)
        Me.Label3.TabIndex = 49
        Me.Label3.Text = "FACTURA"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(554, 68)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(197, 24)
        Me.Label2.TabIndex = 48
        Me.Label2.Text = "R.U.C. 10762769536"
        '
        'lblIGV
        '
        Me.lblIGV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblIGV.Location = New System.Drawing.Point(688, 578)
        Me.lblIGV.Name = "lblIGV"
        Me.lblIGV.Size = New System.Drawing.Size(76, 21)
        Me.lblIGV.TabIndex = 67
        Me.lblIGV.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(648, 586)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(25, 13)
        Me.Label15.TabIndex = 68
        Me.Label15.Text = "IGV"
        '
        'lblTotal
        '
        Me.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTotal.Location = New System.Drawing.Point(688, 607)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(76, 21)
        Me.lblTotal.TabIndex = 67
        Me.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(613, 615)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(60, 13)
        Me.Label17.TabIndex = 68
        Me.Label17.Text = "TOTAL S/."
        '
        'cantIGV
        '
        Me.cantIGV.AutoSize = True
        Me.cantIGV.Location = New System.Drawing.Point(705, 582)
        Me.cantIGV.Name = "cantIGV"
        Me.cantIGV.Size = New System.Drawing.Size(39, 13)
        Me.cantIGV.TabIndex = 77
        Me.cantIGV.Text = "Label9"
        Me.cantIGV.Visible = False
        '
        'lblStk
        '
        Me.lblStk.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblStk.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStk.Location = New System.Drawing.Point(544, 288)
        Me.lblStk.Name = "lblStk"
        Me.lblStk.Size = New System.Drawing.Size(68, 23)
        Me.lblStk.TabIndex = 78
        Me.lblStk.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(540, 272)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(80, 13)
        Me.Label9.TabIndex = 79
        Me.Label9.Text = "Stock Actual"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(305, 21)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(322, 24)
        Me.Label16.TabIndex = 80
        Me.Label16.Text = "GENERAR FACTURA DE VENTA"
        '
        'frmFactura
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(956, 659)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.lblStk)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.cantIGV)
        Me.Controls.Add(Me.btnCalcular)
        Me.Controls.Add(Me.btnAgregarProd)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.chkRUC)
        Me.Controls.Add(Me.chkDNI)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.lblIGV)
        Me.Controls.Add(Me.lblSubtotal)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.btnQuitarProducto)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnGrabar)
        Me.Controls.Add(Me.txtVendedor)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.dgDetalle)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtPrecio)
        Me.Controls.Add(Me.txtCantidad)
        Me.Controls.Add(Me.txtDescripcion)
        Me.Controls.Add(Me.txtidPro)
        Me.Controls.Add(Me.txtDocumento)
        Me.Controls.Add(Me.lblCodigo)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Name = "frmFactura"
        Me.Text = "frmFactura"
        CType(Me.dgDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnCalcular As System.Windows.Forms.Button
    Friend WithEvents btnAgregarProd As System.Windows.Forms.Button
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents chkRUC As System.Windows.Forms.CheckBox
    Friend WithEvents chkDNI As System.Windows.Forms.CheckBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents lblSubtotal As System.Windows.Forms.Label
    Public WithEvents btnAgregar As System.Windows.Forms.Button
    Friend WithEvents btnQuitarProducto As System.Windows.Forms.Button
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents btnGrabar As System.Windows.Forms.Button
    Friend WithEvents txtVendedor As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents dgDetalle As System.Windows.Forms.DataGridView
    Friend WithEvents Eliminar As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents codPro As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents descripcion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cantidad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents punit As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents importe As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents lblFechaSistema As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents btnBuscar As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtCodigo As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtReferencia As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtDireccion As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtPrecio As System.Windows.Forms.TextBox
    Friend WithEvents txtCantidad As System.Windows.Forms.TextBox
    Friend WithEvents txtDescripcion As System.Windows.Forms.TextBox
    Friend WithEvents txtidPro As System.Windows.Forms.TextBox
    Friend WithEvents txtDocumento As System.Windows.Forms.TextBox
    Friend WithEvents lblCodigo As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblIGV As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents lblTotal As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents cantIGV As System.Windows.Forms.Label
    Friend WithEvents lblStk As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
End Class
