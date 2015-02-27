<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConsultaDetalleFactura
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
        Me.lblIDFactura = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lblNoexiste = New System.Windows.Forms.LinkLabel()
        Me.lblEncontrados = New System.Windows.Forms.Label()
        Me.dgDetalleFactura = New System.Windows.Forms.DataGridView()
        CType(Me.dgDetalleFactura, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblIDFactura
        '
        Me.lblIDFactura.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblIDFactura.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIDFactura.Location = New System.Drawing.Point(247, 75)
        Me.lblIDFactura.Name = "lblIDFactura"
        Me.lblIDFactura.Size = New System.Drawing.Size(143, 29)
        Me.lblIDFactura.TabIndex = 44
        Me.lblIDFactura.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(22, 79)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(213, 20)
        Me.Label1.TabIndex = 45
        Me.Label1.Text = "CODIGO DE FACTURA : "
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(261, 12)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(333, 24)
        Me.Label8.TabIndex = 43
        Me.Label8.Text = "CONSULTAR DETALLE FACTURA"
        '
        'lblNoexiste
        '
        Me.lblNoexiste.AutoSize = True
        Me.lblNoexiste.Location = New System.Drawing.Point(359, 273)
        Me.lblNoexiste.Name = "lblNoexiste"
        Me.lblNoexiste.Size = New System.Drawing.Size(93, 13)
        Me.lblNoexiste.TabIndex = 42
        Me.lblNoexiste.TabStop = True
        Me.lblNoexiste.Text = "Datos inexistentes"
        '
        'lblEncontrados
        '
        Me.lblEncontrados.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblEncontrados.Location = New System.Drawing.Point(22, 459)
        Me.lblEncontrados.Name = "lblEncontrados"
        Me.lblEncontrados.Size = New System.Drawing.Size(739, 23)
        Me.lblEncontrados.TabIndex = 41
        Me.lblEncontrados.Text = "Label3"
        Me.lblEncontrados.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'dgDetalleFactura
        '
        Me.dgDetalleFactura.AllowUserToAddRows = False
        Me.dgDetalleFactura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgDetalleFactura.Location = New System.Drawing.Point(22, 127)
        Me.dgDetalleFactura.Name = "dgDetalleFactura"
        Me.dgDetalleFactura.Size = New System.Drawing.Size(739, 319)
        Me.dgDetalleFactura.TabIndex = 40
        '
        'frmConsultaDetalleFactura
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(783, 495)
        Me.Controls.Add(Me.lblIDFactura)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.lblNoexiste)
        Me.Controls.Add(Me.lblEncontrados)
        Me.Controls.Add(Me.dgDetalleFactura)
        Me.Name = "frmConsultaDetalleFactura"
        Me.Text = "frmConsultaDetalleFactura"
        CType(Me.dgDetalleFactura, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblIDFactura As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents lblNoexiste As System.Windows.Forms.LinkLabel
    Friend WithEvents lblEncontrados As System.Windows.Forms.Label
    Friend WithEvents dgDetalleFactura As System.Windows.Forms.DataGridView
End Class
