<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmListaVentas
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
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lblNoexiste = New System.Windows.Forms.LinkLabel()
        Me.dglistafactura = New System.Windows.Forms.DataGridView()
        Me.dglistapedido = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtDesde = New System.Windows.Forms.DateTimePicker()
        Me.txtHasta = New System.Windows.Forms.DateTimePicker()
        Me.btnfiltrar = New System.Windows.Forms.Button()
        Me.dgLista = New System.Windows.Forms.DataGridView()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblboleta = New System.Windows.Forms.Label()
        Me.lblfactura = New System.Windows.Forms.Label()
        Me.lblpedido = New System.Windows.Forms.Label()
        Me.lbltotalventa = New System.Windows.Forms.Label()
        Me.lblEncontrados = New System.Windows.Forms.Label()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.dgCompra = New System.Windows.Forms.DataGridView()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblCompra = New System.Windows.Forms.Label()
        Me.lblganancia = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.lblencFac = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.lblEncPed = New System.Windows.Forms.Label()
        Me.lblEnCompra = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        CType(Me.dglistafactura, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dglistapedido, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgLista, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgCompra, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(281, 18)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(216, 24)
        Me.Label8.TabIndex = 40
        Me.Label8.Text = "Lista Ventas por fecha"
        '
        'lblNoexiste
        '
        Me.lblNoexiste.AutoSize = True
        Me.lblNoexiste.Location = New System.Drawing.Point(76, 258)
        Me.lblNoexiste.Name = "lblNoexiste"
        Me.lblNoexiste.Size = New System.Drawing.Size(93, 13)
        Me.lblNoexiste.TabIndex = 39
        Me.lblNoexiste.TabStop = True
        Me.lblNoexiste.Text = "Datos inexistentes"
        '
        'dglistafactura
        '
        Me.dglistafactura.AllowUserToAddRows = False
        Me.dglistafactura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dglistafactura.Location = New System.Drawing.Point(280, 124)
        Me.dglistafactura.Name = "dglistafactura"
        Me.dglistafactura.Size = New System.Drawing.Size(241, 434)
        Me.dglistafactura.TabIndex = 42
        '
        'dglistapedido
        '
        Me.dglistapedido.AllowUserToAddRows = False
        Me.dglistapedido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dglistapedido.Location = New System.Drawing.Point(535, 124)
        Me.dglistapedido.Name = "dglistapedido"
        Me.dglistapedido.Size = New System.Drawing.Size(239, 434)
        Me.dglistapedido.TabIndex = 41
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(314, 70)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 13)
        Me.Label2.TabIndex = 46
        Me.Label2.Text = "Hasta :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(100, 71)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 47
        Me.Label1.Text = "Desde :"
        '
        'txtDesde
        '
        Me.txtDesde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txtDesde.Location = New System.Drawing.Point(155, 65)
        Me.txtDesde.Name = "txtDesde"
        Me.txtDesde.Size = New System.Drawing.Size(112, 20)
        Me.txtDesde.TabIndex = 0
        '
        'txtHasta
        '
        Me.txtHasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txtHasta.Location = New System.Drawing.Point(372, 65)
        Me.txtHasta.Name = "txtHasta"
        Me.txtHasta.Size = New System.Drawing.Size(112, 20)
        Me.txtHasta.TabIndex = 1
        '
        'btnfiltrar
        '
        Me.btnfiltrar.Location = New System.Drawing.Point(520, 64)
        Me.btnfiltrar.Name = "btnfiltrar"
        Me.btnfiltrar.Size = New System.Drawing.Size(124, 25)
        Me.btnfiltrar.TabIndex = 2
        Me.btnfiltrar.Text = "Filtrar"
        Me.btnfiltrar.UseVisualStyleBackColor = True
        '
        'dgLista
        '
        Me.dgLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgLista.Location = New System.Drawing.Point(27, 124)
        Me.dgLista.Name = "dgLista"
        Me.dgLista.Size = New System.Drawing.Size(240, 434)
        Me.dgLista.TabIndex = 51
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(118, 99)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(37, 13)
        Me.Label3.TabIndex = 52
        Me.Label3.Text = "Boleta"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(369, 99)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(43, 13)
        Me.Label4.TabIndex = 52
        Me.Label4.Text = "Factura"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(622, 99)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(40, 13)
        Me.Label5.TabIndex = 52
        Me.Label5.Text = "Pedido"
        '
        'lblboleta
        '
        Me.lblboleta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblboleta.Location = New System.Drawing.Point(153, 561)
        Me.lblboleta.Name = "lblboleta"
        Me.lblboleta.Size = New System.Drawing.Size(114, 23)
        Me.lblboleta.TabIndex = 54
        Me.lblboleta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblfactura
        '
        Me.lblfactura.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblfactura.Location = New System.Drawing.Point(403, 561)
        Me.lblfactura.Name = "lblfactura"
        Me.lblfactura.Size = New System.Drawing.Size(118, 23)
        Me.lblfactura.TabIndex = 55
        Me.lblfactura.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblpedido
        '
        Me.lblpedido.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblpedido.Location = New System.Drawing.Point(658, 561)
        Me.lblpedido.Name = "lblpedido"
        Me.lblpedido.Size = New System.Drawing.Size(116, 23)
        Me.lblpedido.TabIndex = 56
        Me.lblpedido.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbltotalventa
        '
        Me.lbltotalventa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbltotalventa.Location = New System.Drawing.Point(658, 648)
        Me.lbltotalventa.Name = "lbltotalventa"
        Me.lbltotalventa.Size = New System.Drawing.Size(116, 23)
        Me.lbltotalventa.TabIndex = 56
        Me.lbltotalventa.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblEncontrados
        '
        Me.lblEncontrados.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblEncontrados.Location = New System.Drawing.Point(153, 599)
        Me.lblEncontrados.Name = "lblEncontrados"
        Me.lblEncontrados.Size = New System.Drawing.Size(114, 23)
        Me.lblEncontrados.TabIndex = 57
        Me.lblEncontrados.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnLimpiar
        '
        Me.btnLimpiar.Location = New System.Drawing.Point(661, 64)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(113, 29)
        Me.btnLimpiar.TabIndex = 58
        Me.btnLimpiar.Text = "Limpiar"
        Me.btnLimpiar.UseVisualStyleBackColor = True
        '
        'dgCompra
        '
        Me.dgCompra.AllowUserToAddRows = False
        Me.dgCompra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgCompra.Location = New System.Drawing.Point(905, 124)
        Me.dgCompra.Name = "dgCompra"
        Me.dgCompra.Size = New System.Drawing.Size(239, 434)
        Me.dgCompra.TabIndex = 59
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(985, 99)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(43, 13)
        Me.Label6.TabIndex = 60
        Me.Label6.Text = "Compra"
        '
        'lblCompra
        '
        Me.lblCompra.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblCompra.Location = New System.Drawing.Point(1028, 561)
        Me.lblCompra.Name = "lblCompra"
        Me.lblCompra.Size = New System.Drawing.Size(116, 23)
        Me.lblCompra.TabIndex = 61
        Me.lblCompra.Text = "Label3"
        Me.lblCompra.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblganancia
        '
        Me.lblganancia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblganancia.Location = New System.Drawing.Point(1028, 648)
        Me.lblganancia.Name = "lblganancia"
        Me.lblganancia.Size = New System.Drawing.Size(116, 23)
        Me.lblganancia.TabIndex = 62
        Me.lblganancia.Text = "Label3"
        Me.lblganancia.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(36, 566)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(111, 13)
        Me.Label7.TabIndex = 63
        Me.Label7.Text = "Total Boletas Ventas :"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(285, 566)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(112, 13)
        Me.Label9.TabIndex = 64
        Me.Label9.Text = "Total Factura Ventas :"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(543, 566)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(109, 13)
        Me.Label10.TabIndex = 65
        Me.Label10.Text = "Total Pedido Ventas :"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(361, 653)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(283, 13)
        Me.Label11.TabIndex = 66
        Me.Label11.Text = "Total de ventas realizadas entre las fechas seleccionadas:"
        '
        'lblencFac
        '
        Me.lblencFac.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblencFac.Location = New System.Drawing.Point(407, 599)
        Me.lblencFac.Name = "lblencFac"
        Me.lblencFac.Size = New System.Drawing.Size(114, 23)
        Me.lblencFac.TabIndex = 67
        Me.lblencFac.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(36, 609)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(108, 13)
        Me.Label14.TabIndex = 69
        Me.Label14.Text = "Cantidad de Boletas :"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(289, 604)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(114, 13)
        Me.Label15.TabIndex = 70
        Me.Label15.Text = "Cantidad de Facturas :"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(547, 604)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(111, 13)
        Me.Label16.TabIndex = 71
        Me.Label16.Text = "Cantidad de Pedidos :"
        '
        'lblEncPed
        '
        Me.lblEncPed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblEncPed.Location = New System.Drawing.Point(658, 599)
        Me.lblEncPed.Name = "lblEncPed"
        Me.lblEncPed.Size = New System.Drawing.Size(114, 23)
        Me.lblEncPed.TabIndex = 72
        Me.lblEncPed.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblEnCompra
        '
        Me.lblEnCompra.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblEnCompra.Location = New System.Drawing.Point(1028, 599)
        Me.lblEnCompra.Name = "lblEnCompra"
        Me.lblEnCompra.Size = New System.Drawing.Size(114, 23)
        Me.lblEnCompra.TabIndex = 74
        Me.lblEnCompra.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(917, 604)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(114, 13)
        Me.Label13.TabIndex = 73
        Me.Label13.Text = "Cantidad de Compras :"
        '
        'frmListaVentas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1165, 750)
        Me.Controls.Add(Me.lblEnCompra)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.lblEncPed)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.lblencFac)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.lblganancia)
        Me.Controls.Add(Me.lblCompra)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.dgCompra)
        Me.Controls.Add(Me.btnLimpiar)
        Me.Controls.Add(Me.lblEncontrados)
        Me.Controls.Add(Me.lbltotalventa)
        Me.Controls.Add(Me.lblpedido)
        Me.Controls.Add(Me.lblfactura)
        Me.Controls.Add(Me.lblboleta)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.dgLista)
        Me.Controls.Add(Me.btnfiltrar)
        Me.Controls.Add(Me.txtHasta)
        Me.Controls.Add(Me.txtDesde)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dglistafactura)
        Me.Controls.Add(Me.dglistapedido)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.lblNoexiste)
        Me.Name = "frmListaVentas"
        Me.Text = "frmListaVentas"
        CType(Me.dglistafactura, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dglistapedido, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgLista, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgCompra, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents lblNoexiste As System.Windows.Forms.LinkLabel
    Friend WithEvents dglistafactura As System.Windows.Forms.DataGridView
    Friend WithEvents dglistapedido As System.Windows.Forms.DataGridView
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtDesde As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtHasta As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnfiltrar As System.Windows.Forms.Button
    Friend WithEvents dgLista As System.Windows.Forms.DataGridView
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lblboleta As System.Windows.Forms.Label
    Friend WithEvents lblfactura As System.Windows.Forms.Label
    Friend WithEvents lblpedido As System.Windows.Forms.Label
    Friend WithEvents lbltotalventa As System.Windows.Forms.Label
    Friend WithEvents lblEncontrados As System.Windows.Forms.Label
    Friend WithEvents btnLimpiar As System.Windows.Forms.Button
    Friend WithEvents dgCompra As System.Windows.Forms.DataGridView
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lblCompra As System.Windows.Forms.Label
    Friend WithEvents lblganancia As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents lblencFac As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents lblEncPed As System.Windows.Forms.Label
    Friend WithEvents lblEnCompra As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
End Class
