<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmListaCliente
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
        Me.dgLista = New System.Windows.Forms.DataGridView()
        Me.lblNoexiste = New System.Windows.Forms.LinkLabel()
        Me.txtFlag = New System.Windows.Forms.TextBox()
        Me.chkBoleta = New System.Windows.Forms.CheckBox()
        Me.chkFactura = New System.Windows.Forms.CheckBox()
        Me.chkPedido = New System.Windows.Forms.CheckBox()
        CType(Me.dgLista, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgLista
        '
        Me.dgLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgLista.Location = New System.Drawing.Point(12, 90)
        Me.dgLista.Name = "dgLista"
        Me.dgLista.Size = New System.Drawing.Size(738, 373)
        Me.dgLista.TabIndex = 0
        '
        'lblNoexiste
        '
        Me.lblNoexiste.AutoSize = True
        Me.lblNoexiste.Location = New System.Drawing.Point(335, 231)
        Me.lblNoexiste.Name = "lblNoexiste"
        Me.lblNoexiste.Size = New System.Drawing.Size(93, 13)
        Me.lblNoexiste.TabIndex = 38
        Me.lblNoexiste.TabStop = True
        Me.lblNoexiste.Text = "Datos inexistentes"
        '
        'txtFlag
        '
        Me.txtFlag.Location = New System.Drawing.Point(621, 27)
        Me.txtFlag.Name = "txtFlag"
        Me.txtFlag.Size = New System.Drawing.Size(100, 20)
        Me.txtFlag.TabIndex = 40
        Me.txtFlag.Text = "0"
        '
        'chkBoleta
        '
        Me.chkBoleta.AutoSize = True
        Me.chkBoleta.Location = New System.Drawing.Point(241, 30)
        Me.chkBoleta.Name = "chkBoleta"
        Me.chkBoleta.Size = New System.Drawing.Size(141, 17)
        Me.chkBoleta.TabIndex = 45
        Me.chkBoleta.Text = "REPORTE DE BOLETA"
        Me.chkBoleta.UseVisualStyleBackColor = True
        '
        'chkFactura
        '
        Me.chkFactura.AutoSize = True
        Me.chkFactura.Location = New System.Drawing.Point(45, 30)
        Me.chkFactura.Name = "chkFactura"
        Me.chkFactura.Size = New System.Drawing.Size(149, 17)
        Me.chkFactura.TabIndex = 46
        Me.chkFactura.Text = "REPORTE DE FACTURA"
        Me.chkFactura.UseVisualStyleBackColor = True
        '
        'chkPedido
        '
        Me.chkPedido.AutoSize = True
        Me.chkPedido.Location = New System.Drawing.Point(423, 30)
        Me.chkPedido.Name = "chkPedido"
        Me.chkPedido.Size = New System.Drawing.Size(140, 17)
        Me.chkPedido.TabIndex = 45
        Me.chkPedido.Text = "REPORTE DE PEDIDO"
        Me.chkPedido.UseVisualStyleBackColor = True
        '
        'frmListaCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(762, 475)
        Me.Controls.Add(Me.chkPedido)
        Me.Controls.Add(Me.chkBoleta)
        Me.Controls.Add(Me.chkFactura)
        Me.Controls.Add(Me.txtFlag)
        Me.Controls.Add(Me.lblNoexiste)
        Me.Controls.Add(Me.dgLista)
        Me.Name = "frmListaCliente"
        Me.Text = "frmListaCliente"
        CType(Me.dgLista, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgLista As System.Windows.Forms.DataGridView
    Friend WithEvents lblNoexiste As System.Windows.Forms.LinkLabel
    Friend WithEvents txtFlag As System.Windows.Forms.TextBox
    Friend WithEvents chkBoleta As System.Windows.Forms.CheckBox
    Friend WithEvents chkFactura As System.Windows.Forms.CheckBox
    Friend WithEvents chkPedido As System.Windows.Forms.CheckBox
End Class
