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
        Me.lblEncontrados = New System.Windows.Forms.Label()
        Me.dgLista = New System.Windows.Forms.DataGridView()
        Me.dglista2 = New System.Windows.Forms.DataGridView()
        Me.dglista3 = New System.Windows.Forms.DataGridView()
        CType(Me.dgLista, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dglista2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dglista3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(289, 47)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(216, 24)
        Me.Label8.TabIndex = 40
        Me.Label8.Text = "Lista Ventas por fecha"
        '
        'lblNoexiste
        '
        Me.lblNoexiste.AutoSize = True
        Me.lblNoexiste.Location = New System.Drawing.Point(205, 194)
        Me.lblNoexiste.Name = "lblNoexiste"
        Me.lblNoexiste.Size = New System.Drawing.Size(93, 13)
        Me.lblNoexiste.TabIndex = 39
        Me.lblNoexiste.TabStop = True
        Me.lblNoexiste.Text = "Datos inexistentes"
        '
        'lblEncontrados
        '
        Me.lblEncontrados.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblEncontrados.Location = New System.Drawing.Point(28, 426)
        Me.lblEncontrados.Name = "lblEncontrados"
        Me.lblEncontrados.Size = New System.Drawing.Size(353, 23)
        Me.lblEncontrados.TabIndex = 38
        Me.lblEncontrados.Text = "Label3"
        Me.lblEncontrados.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'dgLista
        '
        Me.dgLista.AllowUserToAddRows = False
        Me.dgLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgLista.Location = New System.Drawing.Point(12, 86)
        Me.dgLista.Name = "dgLista"
        Me.dgLista.Size = New System.Drawing.Size(523, 297)
        Me.dgLista.TabIndex = 37
        '
        'dglista2
        '
        Me.dglista2.AllowUserToAddRows = False
        Me.dglista2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dglista2.Location = New System.Drawing.Point(28, 418)
        Me.dglista2.Name = "dglista2"
        Me.dglista2.Size = New System.Drawing.Size(553, 301)
        Me.dglista2.TabIndex = 41
        '
        'dglista3
        '
        Me.dglista3.AllowUserToAddRows = False
        Me.dglista3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dglista3.Location = New System.Drawing.Point(638, 86)
        Me.dglista3.Name = "dglista3"
        Me.dglista3.Size = New System.Drawing.Size(570, 273)
        Me.dglista3.TabIndex = 42
        '
        'frmListaVentas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1359, 750)
        Me.Controls.Add(Me.dglista3)
        Me.Controls.Add(Me.dglista2)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.lblNoexiste)
        Me.Controls.Add(Me.lblEncontrados)
        Me.Controls.Add(Me.dgLista)
        Me.Name = "frmListaVentas"
        Me.Text = "frmListaVentas"
        CType(Me.dgLista, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dglista2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dglista3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents lblNoexiste As System.Windows.Forms.LinkLabel
    Friend WithEvents lblEncontrados As System.Windows.Forms.Label
    Friend WithEvents dgLista As System.Windows.Forms.DataGridView
    Friend WithEvents dglista2 As System.Windows.Forms.DataGridView
    Friend WithEvents dglista3 As System.Windows.Forms.DataGridView
End Class
