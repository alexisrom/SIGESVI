<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmListadoProduccion
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.BtnEliminar = New System.Windows.Forms.Button
        Me.BtnEditar = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.BtnNueva = New System.Windows.Forms.Button
        Me.DgvProduccion = New System.Windows.Forms.DataGridView
        Me.BtnTrazabilidad = New System.Windows.Forms.Button
        CType(Me.DgvProduccion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnEliminar
        '
        Me.BtnEliminar.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.BtnEliminar.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(161, Byte), Integer))
        Me.BtnEliminar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnEliminar.FlatAppearance.BorderSize = 0
        Me.BtnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnEliminar.ForeColor = System.Drawing.Color.White
        Me.BtnEliminar.Location = New System.Drawing.Point(1101, 132)
        Me.BtnEliminar.Name = "BtnEliminar"
        Me.BtnEliminar.Size = New System.Drawing.Size(96, 34)
        Me.BtnEliminar.TabIndex = 16
        Me.BtnEliminar.Text = "ELIMINAR"
        Me.BtnEliminar.UseVisualStyleBackColor = False
        '
        'BtnEditar
        '
        Me.BtnEditar.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.BtnEditar.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(161, Byte), Integer))
        Me.BtnEditar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnEditar.FlatAppearance.BorderSize = 0
        Me.BtnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnEditar.ForeColor = System.Drawing.Color.White
        Me.BtnEditar.Location = New System.Drawing.Point(1101, 82)
        Me.BtnEditar.Name = "BtnEditar"
        Me.BtnEditar.Size = New System.Drawing.Size(96, 34)
        Me.BtnEditar.TabIndex = 15
        Me.BtnEditar.Text = "EDITAR"
        Me.BtnEditar.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 16.0!)
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(172, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(558, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(296, 30)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "HISTORIAL DE PRODUCCIÓN"
        '
        'BtnNueva
        '
        Me.BtnNueva.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.BtnNueva.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(161, Byte), Integer))
        Me.BtnNueva.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnNueva.FlatAppearance.BorderSize = 0
        Me.BtnNueva.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnNueva.ForeColor = System.Drawing.Color.White
        Me.BtnNueva.Location = New System.Drawing.Point(249, 82)
        Me.BtnNueva.Name = "BtnNueva"
        Me.BtnNueva.Size = New System.Drawing.Size(96, 34)
        Me.BtnNueva.TabIndex = 13
        Me.BtnNueva.Text = "NUEVA"
        Me.BtnNueva.UseVisualStyleBackColor = False
        '
        'DgvProduccion
        '
        Me.DgvProduccion.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.DgvProduccion.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(149, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.DgvProduccion.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DgvProduccion.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(161, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(211, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgvProduccion.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DgvProduccion.ColumnHeadersHeight = 25
        Me.DgvProduccion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(149, Byte), Integer), CType(CType(167, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DgvProduccion.DefaultCellStyle = DataGridViewCellStyle2
        Me.DgvProduccion.EnableHeadersVisualStyles = False
        Me.DgvProduccion.GridColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.DgvProduccion.Location = New System.Drawing.Point(367, 82)
        Me.DgvProduccion.MultiSelect = False
        Me.DgvProduccion.Name = "DgvProduccion"
        Me.DgvProduccion.ReadOnly = True
        Me.DgvProduccion.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(149, Byte), Integer), CType(CType(167, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(211, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgvProduccion.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(149, Byte), Integer), CType(CType(167, Byte), Integer))
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.DgvProduccion.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.DgvProduccion.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(149, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.DgvProduccion.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White
        Me.DgvProduccion.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.DgvProduccion.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DgvProduccion.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvProduccion.Size = New System.Drawing.Size(710, 266)
        Me.DgvProduccion.TabIndex = 12
        '
        'BtnTrazabilidad
        '
        Me.BtnTrazabilidad.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.BtnTrazabilidad.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(161, Byte), Integer))
        Me.BtnTrazabilidad.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnTrazabilidad.FlatAppearance.BorderSize = 0
        Me.BtnTrazabilidad.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnTrazabilidad.ForeColor = System.Drawing.Color.White
        Me.BtnTrazabilidad.Location = New System.Drawing.Point(1101, 188)
        Me.BtnTrazabilidad.Name = "BtnTrazabilidad"
        Me.BtnTrazabilidad.Size = New System.Drawing.Size(96, 34)
        Me.BtnTrazabilidad.TabIndex = 20
        Me.BtnTrazabilidad.Text = "TRAZABILIDAD"
        Me.BtnTrazabilidad.UseVisualStyleBackColor = False
        '
        'FrmListadoProduccion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1446, 377)
        Me.Controls.Add(Me.BtnTrazabilidad)
        Me.Controls.Add(Me.BtnEliminar)
        Me.Controls.Add(Me.BtnEditar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtnNueva)
        Me.Controls.Add(Me.DgvProduccion)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmListadoProduccion"
        Me.Text = "FrmListadoProduccion"
        CType(Me.DgvProduccion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BtnEliminar As System.Windows.Forms.Button
    Friend WithEvents BtnEditar As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents BtnNueva As System.Windows.Forms.Button
    Friend WithEvents DgvProduccion As System.Windows.Forms.DataGridView
    Friend WithEvents BtnTrazabilidad As System.Windows.Forms.Button
End Class
