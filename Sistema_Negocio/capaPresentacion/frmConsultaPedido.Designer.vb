<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConsultaPedido
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
        Me.lblEncontrados = New System.Windows.Forms.Label()
        Me.dgPedido = New System.Windows.Forms.DataGridView()
        CType(Me.dgPedido, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(231, 31)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(216, 24)
        Me.Label8.TabIndex = 44
        Me.Label8.Text = "CONSULTAR PEDIDO"
        '
        'lblNoexiste
        '
        Me.lblNoexiste.AutoSize = True
        Me.lblNoexiste.Location = New System.Drawing.Point(316, 220)
        Me.lblNoexiste.Name = "lblNoexiste"
        Me.lblNoexiste.Size = New System.Drawing.Size(93, 13)
        Me.lblNoexiste.TabIndex = 43
        Me.lblNoexiste.TabStop = True
        Me.lblNoexiste.Text = "Datos inexistentes"
        '
        'lblEncontrados
        '
        Me.lblEncontrados.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblEncontrados.Location = New System.Drawing.Point(12, 429)
        Me.lblEncontrados.Name = "lblEncontrados"
        Me.lblEncontrados.Size = New System.Drawing.Size(739, 23)
        Me.lblEncontrados.TabIndex = 42
        Me.lblEncontrados.Text = "Label3"
        Me.lblEncontrados.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'dgPedido
        '
        Me.dgPedido.AllowUserToAddRows = False
        Me.dgPedido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgPedido.Location = New System.Drawing.Point(12, 86)
        Me.dgPedido.Name = "dgPedido"
        Me.dgPedido.Size = New System.Drawing.Size(739, 326)
        Me.dgPedido.TabIndex = 41
        '
        'frmConsultaPedido
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(762, 482)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.lblNoexiste)
        Me.Controls.Add(Me.lblEncontrados)
        Me.Controls.Add(Me.dgPedido)
        Me.Name = "frmConsultaPedido"
        Me.Text = "frmConsultaPedido"
        CType(Me.dgPedido, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents lblNoexiste As System.Windows.Forms.LinkLabel
    Friend WithEvents lblEncontrados As System.Windows.Forms.Label
    Friend WithEvents dgPedido As System.Windows.Forms.DataGridView
End Class
