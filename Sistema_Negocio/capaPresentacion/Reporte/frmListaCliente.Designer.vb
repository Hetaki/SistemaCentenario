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
        Me.rbFactura = New System.Windows.Forms.RadioButton()
        Me.rbBoleta = New System.Windows.Forms.RadioButton()
        Me.rbPedido = New System.Windows.Forms.RadioButton()
        CType(Me.dgLista, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgLista
        '
        Me.dgLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgLista.Location = New System.Drawing.Point(12, 67)
        Me.dgLista.Name = "dgLista"
        Me.dgLista.Size = New System.Drawing.Size(738, 396)
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
        'rbFactura
        '
        Me.rbFactura.AutoSize = True
        Me.rbFactura.Location = New System.Drawing.Point(55, 30)
        Me.rbFactura.Name = "rbFactura"
        Me.rbFactura.Size = New System.Drawing.Size(148, 17)
        Me.rbFactura.TabIndex = 39
        Me.rbFactura.TabStop = True
        Me.rbFactura.Text = "REPORTE DE FACTURA"
        Me.rbFactura.UseVisualStyleBackColor = True
        '
        'rbBoleta
        '
        Me.rbBoleta.AutoSize = True
        Me.rbBoleta.Location = New System.Drawing.Point(248, 30)
        Me.rbBoleta.Name = "rbBoleta"
        Me.rbBoleta.Size = New System.Drawing.Size(140, 17)
        Me.rbBoleta.TabIndex = 39
        Me.rbBoleta.TabStop = True
        Me.rbBoleta.Text = "REPORTE DE BOLETA"
        Me.rbBoleta.UseVisualStyleBackColor = True
        '
        'rbPedido
        '
        Me.rbPedido.AutoSize = True
        Me.rbPedido.Location = New System.Drawing.Point(430, 30)
        Me.rbPedido.Name = "rbPedido"
        Me.rbPedido.Size = New System.Drawing.Size(139, 17)
        Me.rbPedido.TabIndex = 39
        Me.rbPedido.TabStop = True
        Me.rbPedido.Text = "REPORTE DE PEDIDO"
        Me.rbPedido.UseVisualStyleBackColor = True
        '
        'frmListaCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(762, 475)
        Me.Controls.Add(Me.rbPedido)
        Me.Controls.Add(Me.rbBoleta)
        Me.Controls.Add(Me.rbFactura)
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
    Friend WithEvents rbFactura As System.Windows.Forms.RadioButton
    Friend WithEvents rbBoleta As System.Windows.Forms.RadioButton
    Friend WithEvents rbPedido As System.Windows.Forms.RadioButton
End Class
