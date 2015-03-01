<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSpReporteFactura
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
        Me.crBoletas = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.btnfiltrar = New System.Windows.Forms.Button()
        Me.txtHasta = New System.Windows.Forms.DateTimePicker()
        Me.txtDesde = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'crBoletas
        '
        Me.crBoletas.ActiveViewIndex = -1
        Me.crBoletas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.crBoletas.Cursor = System.Windows.Forms.Cursors.Default
        Me.crBoletas.Location = New System.Drawing.Point(102, 146)
        Me.crBoletas.Name = "crBoletas"
        Me.crBoletas.Size = New System.Drawing.Size(630, 349)
        Me.crBoletas.TabIndex = 61
        Me.crBoletas.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'btnfiltrar
        '
        Me.btnfiltrar.Location = New System.Drawing.Point(562, 70)
        Me.btnfiltrar.Name = "btnfiltrar"
        Me.btnfiltrar.Size = New System.Drawing.Size(124, 25)
        Me.btnfiltrar.TabIndex = 57
        Me.btnfiltrar.Text = "Filtrar"
        Me.btnfiltrar.UseVisualStyleBackColor = True
        '
        'txtHasta
        '
        Me.txtHasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txtHasta.Location = New System.Drawing.Point(414, 71)
        Me.txtHasta.Name = "txtHasta"
        Me.txtHasta.Size = New System.Drawing.Size(112, 20)
        Me.txtHasta.TabIndex = 56
        '
        'txtDesde
        '
        Me.txtDesde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txtDesde.Location = New System.Drawing.Point(197, 71)
        Me.txtDesde.Name = "txtDesde"
        Me.txtDesde.Size = New System.Drawing.Size(112, 20)
        Me.txtDesde.TabIndex = 55
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(356, 76)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 13)
        Me.Label2.TabIndex = 59
        Me.Label2.Text = "Hasta :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(142, 77)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 60
        Me.Label1.Text = "Desde :"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(323, 24)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(222, 24)
        Me.Label8.TabIndex = 58
        Me.Label8.Text = "Lista Factura por fecha"
        '
        'frmSpReporteFactura
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(835, 576)
        Me.Controls.Add(Me.crBoletas)
        Me.Controls.Add(Me.btnfiltrar)
        Me.Controls.Add(Me.txtHasta)
        Me.Controls.Add(Me.txtDesde)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label8)
        Me.Name = "frmSpReporteFactura"
        Me.Text = "frmSpReporteFactura"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents crBoletas As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents btnfiltrar As System.Windows.Forms.Button
    Friend WithEvents txtHasta As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtDesde As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
End Class
