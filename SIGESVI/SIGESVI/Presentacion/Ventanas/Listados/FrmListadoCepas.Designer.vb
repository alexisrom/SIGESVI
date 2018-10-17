<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmListadoCepas
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.DgvTiposCepas = New System.Windows.Forms.DataGridView
        Me.BtnNuevo = New System.Windows.Forms.Button
        Me.BtnEditar = New System.Windows.Forms.Button
        CType(Me.DgvTiposCepas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DgvTiposCepas
        '
        Me.DgvTiposCepas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvTiposCepas.Location = New System.Drawing.Point(34, 70)
        Me.DgvTiposCepas.Name = "DgvTiposCepas"
        Me.DgvTiposCepas.Size = New System.Drawing.Size(478, 268)
        Me.DgvTiposCepas.TabIndex = 0
        '
        'BtnNuevo
        '
        Me.BtnNuevo.Location = New System.Drawing.Point(533, 70)
        Me.BtnNuevo.Name = "BtnNuevo"
        Me.BtnNuevo.Size = New System.Drawing.Size(75, 23)
        Me.BtnNuevo.TabIndex = 1
        Me.BtnNuevo.Text = "Nuevo"
        Me.BtnNuevo.UseVisualStyleBackColor = True
        '
        'BtnEditar
        '
        Me.BtnEditar.Location = New System.Drawing.Point(533, 100)
        Me.BtnEditar.Name = "BtnEditar"
        Me.BtnEditar.Size = New System.Drawing.Size(75, 23)
        Me.BtnEditar.TabIndex = 2
        Me.BtnEditar.Text = "Editar"
        Me.BtnEditar.UseVisualStyleBackColor = True
        '
        'FrmListadoCepas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(647, 380)
        Me.Controls.Add(Me.BtnEditar)
        Me.Controls.Add(Me.BtnNuevo)
        Me.Controls.Add(Me.DgvTiposCepas)
        Me.Name = "FrmListadoCepas"
        Me.Text = "FrmListadoCepas"
        CType(Me.DgvTiposCepas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DgvTiposCepas As System.Windows.Forms.DataGridView
    Friend WithEvents BtnNuevo As System.Windows.Forms.Button
    Friend WithEvents BtnEditar As System.Windows.Forms.Button
End Class
