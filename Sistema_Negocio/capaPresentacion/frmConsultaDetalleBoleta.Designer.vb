﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConsultaDetalleBoleta
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
        Me.dgDetalleBoleta = New System.Windows.Forms.DataGridView()
        Me.lblNoexiste = New System.Windows.Forms.LinkLabel()
        Me.lblEncontrados = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblIDBoleta = New System.Windows.Forms.Label()
        CType(Me.dgDetalleBoleta, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgDetalleBoleta
        '
        Me.dgDetalleBoleta.AllowUserToAddRows = False
        Me.dgDetalleBoleta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgDetalleBoleta.Location = New System.Drawing.Point(12, 124)
        Me.dgDetalleBoleta.Name = "dgDetalleBoleta"
        Me.dgDetalleBoleta.Size = New System.Drawing.Size(739, 319)
        Me.dgDetalleBoleta.TabIndex = 0
        '
        'lblNoexiste
        '
        Me.lblNoexiste.AutoSize = True
        Me.lblNoexiste.Location = New System.Drawing.Point(349, 270)
        Me.lblNoexiste.Name = "lblNoexiste"
        Me.lblNoexiste.Size = New System.Drawing.Size(93, 13)
        Me.lblNoexiste.TabIndex = 37
        Me.lblNoexiste.TabStop = True
        Me.lblNoexiste.Text = "Datos inexistentes"
        '
        'lblEncontrados
        '
        Me.lblEncontrados.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblEncontrados.Location = New System.Drawing.Point(12, 456)
        Me.lblEncontrados.Name = "lblEncontrados"
        Me.lblEncontrados.Size = New System.Drawing.Size(739, 23)
        Me.lblEncontrados.TabIndex = 36
        Me.lblEncontrados.Text = "Label3"
        Me.lblEncontrados.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(251, 9)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(318, 24)
        Me.Label8.TabIndex = 38
        Me.Label8.Text = "CONSULTAR DETALLE BOLETA"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 76)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(199, 20)
        Me.Label1.TabIndex = 39
        Me.Label1.Text = "CODIGO DE BOLETA : "
        '
        'lblIDBoleta
        '
        Me.lblIDBoleta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblIDBoleta.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIDBoleta.Location = New System.Drawing.Point(237, 72)
        Me.lblIDBoleta.Name = "lblIDBoleta"
        Me.lblIDBoleta.Size = New System.Drawing.Size(143, 29)
        Me.lblIDBoleta.TabIndex = 39
        Me.lblIDBoleta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmConsultaDetalleBoleta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(786, 515)
        Me.Controls.Add(Me.lblIDBoleta)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.lblNoexiste)
        Me.Controls.Add(Me.lblEncontrados)
        Me.Controls.Add(Me.dgDetalleBoleta)
        Me.Name = "frmConsultaDetalleBoleta"
        Me.Text = "frmConsultaDetalleBoleta"
        CType(Me.dgDetalleBoleta, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgDetalleBoleta As System.Windows.Forms.DataGridView
    Friend WithEvents lblNoexiste As System.Windows.Forms.LinkLabel
    Friend WithEvents lblEncontrados As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblIDBoleta As System.Windows.Forms.Label
End Class
