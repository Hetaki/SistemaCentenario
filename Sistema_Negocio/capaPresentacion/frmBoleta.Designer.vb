<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBoleta
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblCodigo = New System.Windows.Forms.Label()
        Me.txtDocumento = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtReferencia = New System.Windows.Forms.MaskedTextBox()
        Me.txtDireccion = New System.Windows.Forms.MaskedTextBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lblFechaSistema = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.dgDetalle = New System.Windows.Forms.DataGridView()
        Me.Eliminar = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.codPro = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.descripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.punit = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.importe = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtVendedor = New System.Windows.Forms.TextBox()
        Me.btnGrabar = New System.Windows.Forms.Button()
        Me.btnQuitarProducto = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.chkRUC = New System.Windows.Forms.CheckBox()
        Me.chkDNI = New System.Windows.Forms.CheckBox()
        Me.txtidPro = New System.Windows.Forms.TextBox()
        Me.txtDescripcion = New System.Windows.Forms.TextBox()
        Me.txtCantidad = New System.Windows.Forms.TextBox()
        Me.txtPrecio = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.btnAgregarProd = New System.Windows.Forms.Button()
        Me.btnCalcular = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(515, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(197, 24)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "R.U.C. 10762769536"
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Blue
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label3.Location = New System.Drawing.Point(482, 33)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(286, 24)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "BOLETA DE VENTA"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblCodigo
        '
        Me.lblCodigo.AutoSize = True
        Me.lblCodigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCodigo.Location = New System.Drawing.Point(564, 63)
        Me.lblCodigo.Name = "lblCodigo"
        Me.lblCodigo.Size = New System.Drawing.Size(90, 24)
        Me.lblCodigo.TabIndex = 3
        Me.lblCodigo.Text = "CODIGO"
        '
        'txtDocumento
        '
        Me.txtDocumento.Location = New System.Drawing.Point(107, 28)
        Me.txtDocumento.Name = "txtDocumento"
        Me.txtDocumento.Size = New System.Drawing.Size(106, 20)
        Me.txtDocumento.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(24, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "DOCUMENTO"
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
        Me.GroupBox1.Location = New System.Drawing.Point(27, 53)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(430, 130)
        Me.GroupBox1.TabIndex = 7
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
        'btnBuscar
        '
        Me.btnBuscar.Location = New System.Drawing.Point(344, 25)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(75, 23)
        Me.btnBuscar.TabIndex = 8
        Me.btnBuscar.Text = "OBTENER"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lblFechaSistema)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Location = New System.Drawing.Point(463, 116)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(291, 67)
        Me.GroupBox2.TabIndex = 9
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
        'dgDetalle
        '
        Me.dgDetalle.AllowUserToAddRows = False
        Me.dgDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgDetalle.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Eliminar, Me.codPro, Me.descripcion, Me.cantidad, Me.punit, Me.importe})
        Me.dgDetalle.Location = New System.Drawing.Point(12, 257)
        Me.dgDetalle.Name = "dgDetalle"
        Me.dgDetalle.Size = New System.Drawing.Size(713, 222)
        Me.dgDetalle.TabIndex = 10
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
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(31, 197)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(68, 13)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "VENDEDOR"
        '
        'txtVendedor
        '
        Me.txtVendedor.Location = New System.Drawing.Point(112, 197)
        Me.txtVendedor.Name = "txtVendedor"
        Me.txtVendedor.Size = New System.Drawing.Size(326, 20)
        Me.txtVendedor.TabIndex = 12
        '
        'btnGrabar
        '
        Me.btnGrabar.Location = New System.Drawing.Point(728, 402)
        Me.btnGrabar.Name = "btnGrabar"
        Me.btnGrabar.Size = New System.Drawing.Size(89, 41)
        Me.btnGrabar.TabIndex = 13
        Me.btnGrabar.Text = "GRABAR BOLETA"
        Me.btnGrabar.UseVisualStyleBackColor = True
        '
        'btnQuitarProducto
        '
        Me.btnQuitarProducto.Location = New System.Drawing.Point(728, 304)
        Me.btnQuitarProducto.Name = "btnQuitarProducto"
        Me.btnQuitarProducto.Size = New System.Drawing.Size(92, 39)
        Me.btnQuitarProducto.TabIndex = 13
        Me.btnQuitarProducto.Text = "QUITAR PRODUCTO"
        Me.btnQuitarProducto.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(728, 449)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(89, 31)
        Me.btnCancelar.TabIndex = 13
        Me.btnCancelar.Text = "CANCELAR"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'lblTotal
        '
        Me.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTotal.Location = New System.Drawing.Point(624, 498)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(76, 21)
        Me.lblTotal.TabIndex = 14
        Me.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(538, 506)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(60, 13)
        Me.Label10.TabIndex = 14
        Me.Label10.Text = "TOTAL S/."
        '
        'chkRUC
        '
        Me.chkRUC.AutoSize = True
        Me.chkRUC.Location = New System.Drawing.Point(281, 29)
        Me.chkRUC.Name = "chkRUC"
        Me.chkRUC.Size = New System.Drawing.Size(49, 17)
        Me.chkRUC.TabIndex = 43
        Me.chkRUC.Text = "RUC"
        Me.chkRUC.UseVisualStyleBackColor = True
        '
        'chkDNI
        '
        Me.chkDNI.AutoSize = True
        Me.chkDNI.Location = New System.Drawing.Point(219, 30)
        Me.chkDNI.Name = "chkDNI"
        Me.chkDNI.Size = New System.Drawing.Size(45, 17)
        Me.chkDNI.TabIndex = 44
        Me.chkDNI.Text = "DNI"
        Me.chkDNI.UseVisualStyleBackColor = True
        '
        'txtidPro
        '
        Me.txtidPro.Enabled = False
        Me.txtidPro.Location = New System.Drawing.Point(72, 231)
        Me.txtidPro.Name = "txtidPro"
        Me.txtidPro.Size = New System.Drawing.Size(67, 20)
        Me.txtidPro.TabIndex = 4
        '
        'txtDescripcion
        '
        Me.txtDescripcion.Enabled = False
        Me.txtDescripcion.Location = New System.Drawing.Point(219, 231)
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(186, 20)
        Me.txtDescripcion.TabIndex = 4
        '
        'txtCantidad
        '
        Me.txtCantidad.Enabled = False
        Me.txtCantidad.Location = New System.Drawing.Point(465, 231)
        Me.txtCantidad.Name = "txtCantidad"
        Me.txtCantidad.Size = New System.Drawing.Size(70, 20)
        Me.txtCantidad.TabIndex = 4
        '
        'txtPrecio
        '
        Me.txtPrecio.Enabled = False
        Me.txtPrecio.Location = New System.Drawing.Point(593, 232)
        Me.txtPrecio.Name = "txtPrecio"
        Me.txtPrecio.Size = New System.Drawing.Size(70, 20)
        Me.txtPrecio.TabIndex = 4
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(24, 234)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(41, 13)
        Me.Label11.TabIndex = 45
        Me.Label11.Text = "codPro"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(411, 235)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(48, 13)
        Me.Label12.TabIndex = 45
        Me.Label12.Text = "cantidad"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(152, 235)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(61, 13)
        Me.Label13.TabIndex = 45
        Me.Label13.Text = "descripcion"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(550, 235)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(37, 13)
        Me.Label14.TabIndex = 45
        Me.Label14.Text = "Precio"
        '
        'btnAgregar
        '
        Me.btnAgregar.Location = New System.Drawing.Point(669, 232)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(23, 20)
        Me.btnAgregar.TabIndex = 13
        Me.btnAgregar.Text = "+"
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'btnAgregarProd
        '
        Me.btnAgregarProd.Location = New System.Drawing.Point(731, 258)
        Me.btnAgregarProd.Name = "btnAgregarProd"
        Me.btnAgregarProd.Size = New System.Drawing.Size(89, 40)
        Me.btnAgregarProd.TabIndex = 46
        Me.btnAgregarProd.Text = "AGREGAR PRODUCTO"
        Me.btnAgregarProd.UseVisualStyleBackColor = True
        '
        'btnCalcular
        '
        Me.btnCalcular.Location = New System.Drawing.Point(457, 498)
        Me.btnCalcular.Name = "btnCalcular"
        Me.btnCalcular.Size = New System.Drawing.Size(75, 23)
        Me.btnCalcular.TabIndex = 47
        Me.btnCalcular.Text = "CALCULAR"
        Me.btnCalcular.UseVisualStyleBackColor = True
        '
        'frmBoleta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(832, 549)
        Me.Controls.Add(Me.btnCalcular)
        Me.Controls.Add(Me.btnAgregarProd)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.chkRUC)
        Me.Controls.Add(Me.chkDNI)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.lblTotal)
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
        Me.Name = "frmBoleta"
        Me.Text = "frmBoleta"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.dgDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblCodigo As System.Windows.Forms.Label
    Friend WithEvents txtDocumento As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtReferencia As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtDireccion As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents btnBuscar As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents lblFechaSistema As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents dgDetalle As System.Windows.Forms.DataGridView
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtVendedor As System.Windows.Forms.TextBox
    Friend WithEvents btnGrabar As System.Windows.Forms.Button
    Friend WithEvents btnQuitarProducto As System.Windows.Forms.Button
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents lblTotal As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents chkRUC As System.Windows.Forms.CheckBox
    Friend WithEvents chkDNI As System.Windows.Forms.CheckBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents btnAgregarProd As System.Windows.Forms.Button
    Public WithEvents btnAgregar As System.Windows.Forms.Button
    Friend WithEvents txtidPro As System.Windows.Forms.TextBox
    Friend WithEvents txtDescripcion As System.Windows.Forms.TextBox
    Friend WithEvents txtCantidad As System.Windows.Forms.TextBox
    Friend WithEvents txtPrecio As System.Windows.Forms.TextBox
    Friend WithEvents btnCalcular As System.Windows.Forms.Button
    Friend WithEvents Eliminar As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents codPro As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents descripcion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cantidad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents punit As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents importe As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txtCodigo As System.Windows.Forms.TextBox
End Class
