<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReportexFecha
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
        Me.btnFiltrar = New System.Windows.Forms.Button()
        Me.txtdesde = New System.Windows.Forms.MaskedTextBox()
        Me.txtHasta = New System.Windows.Forms.MaskedTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.crvPorFecha = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.SuspendLayout()
        '
        'btnFiltrar
        '
        Me.btnFiltrar.Location = New System.Drawing.Point(674, 56)
        Me.btnFiltrar.Name = "btnFiltrar"
        Me.btnFiltrar.Size = New System.Drawing.Size(75, 23)
        Me.btnFiltrar.TabIndex = 0
        Me.btnFiltrar.Text = "Filtrar"
        Me.btnFiltrar.UseVisualStyleBackColor = True
        '
        'txtdesde
        '
        Me.txtdesde.Location = New System.Drawing.Point(249, 58)
        Me.txtdesde.Mask = "0000/00/00"
        Me.txtdesde.Name = "txtdesde"
        Me.txtdesde.Size = New System.Drawing.Size(100, 20)
        Me.txtdesde.TabIndex = 1
        '
        'txtHasta
        '
        Me.txtHasta.Location = New System.Drawing.Point(466, 59)
        Me.txtHasta.Mask = "0000/00/00"
        Me.txtHasta.Name = "txtHasta"
        Me.txtHasta.Size = New System.Drawing.Size(100, 20)
        Me.txtHasta.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(191, 62)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Desde :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(405, 61)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Hasta :"
        '
        'crvPorFecha
        '
        Me.crvPorFecha.ActiveViewIndex = -1
        Me.crvPorFecha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.crvPorFecha.Cursor = System.Windows.Forms.Cursors.Default
        Me.crvPorFecha.Location = New System.Drawing.Point(52, 99)
        Me.crvPorFecha.Name = "crvPorFecha"
        Me.crvPorFecha.Size = New System.Drawing.Size(825, 468)
        Me.crvPorFecha.TabIndex = 3
        Me.crvPorFecha.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'frmReportexFecha
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(963, 607)
        Me.Controls.Add(Me.crvPorFecha)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtHasta)
        Me.Controls.Add(Me.txtdesde)
        Me.Controls.Add(Me.btnFiltrar)
        Me.Name = "frmReportexFecha"
        Me.Text = "frmReportexFecha"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnFiltrar As System.Windows.Forms.Button
    Friend WithEvents txtdesde As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtHasta As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents crvPorFecha As CrystalDecisions.Windows.Forms.CrystalReportViewer
End Class
