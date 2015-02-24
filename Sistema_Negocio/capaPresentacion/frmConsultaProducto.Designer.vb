<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConsultaProducto
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
        Me.dgProducto = New System.Windows.Forms.DataGridView()
        Me.cboCategoria = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.btnRecuperarDatos = New System.Windows.Forms.Button()
        Me.lblEncontrados = New System.Windows.Forms.Label()
        Me.txtFlag = New System.Windows.Forms.TextBox()
        CType(Me.dgProducto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgProducto
        '
        Me.dgProducto.AllowUserToAddRows = False
        Me.dgProducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgProducto.Location = New System.Drawing.Point(12, 119)
        Me.dgProducto.Name = "dgProducto"
        Me.dgProducto.Size = New System.Drawing.Size(698, 266)
        Me.dgProducto.TabIndex = 0
        '
        'cboCategoria
        '
        Me.cboCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCategoria.FormattingEnabled = True
        Me.cboCategoria.Location = New System.Drawing.Point(100, 49)
        Me.cboCategoria.Name = "cboCategoria"
        Me.cboCategoria.Size = New System.Drawing.Size(179, 21)
        Me.cboCategoria.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 52)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "CATEGORIA"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(197, 9)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(274, 24)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "CONSULTA DE PRODUCTO"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 86)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "NOMBRE"
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(100, 83)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(248, 20)
        Me.txtNombre.TabIndex = 9
        '
        'btnRecuperarDatos
        '
        Me.btnRecuperarDatos.Location = New System.Drawing.Point(568, 81)
        Me.btnRecuperarDatos.Name = "btnRecuperarDatos"
        Me.btnRecuperarDatos.Size = New System.Drawing.Size(132, 23)
        Me.btnRecuperarDatos.TabIndex = 10
        Me.btnRecuperarDatos.Text = "RECUPERAR DATOS"
        Me.btnRecuperarDatos.UseVisualStyleBackColor = True
        '
        'lblEncontrados
        '
        Me.lblEncontrados.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblEncontrados.Location = New System.Drawing.Point(9, 401)
        Me.lblEncontrados.Name = "lblEncontrados"
        Me.lblEncontrados.Size = New System.Drawing.Size(701, 23)
        Me.lblEncontrados.TabIndex = 11
        Me.lblEncontrados.Text = "Label3"
        Me.lblEncontrados.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtFlag
        '
        Me.txtFlag.Location = New System.Drawing.Point(371, 52)
        Me.txtFlag.Name = "txtFlag"
        Me.txtFlag.Size = New System.Drawing.Size(100, 20)
        Me.txtFlag.TabIndex = 12
        Me.txtFlag.Text = "0"
        '
        'frmConsultaProducto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(725, 443)
        Me.Controls.Add(Me.txtFlag)
        Me.Controls.Add(Me.lblEncontrados)
        Me.Controls.Add(Me.btnRecuperarDatos)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cboCategoria)
        Me.Controls.Add(Me.dgProducto)
        Me.Name = "frmConsultaProducto"
        Me.Text = "frmConsultaProducto"
        CType(Me.dgProducto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgProducto As System.Windows.Forms.DataGridView
    Friend WithEvents cboCategoria As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents btnRecuperarDatos As System.Windows.Forms.Button
    Friend WithEvents lblEncontrados As System.Windows.Forms.Label
    Friend WithEvents txtFlag As System.Windows.Forms.TextBox
End Class
