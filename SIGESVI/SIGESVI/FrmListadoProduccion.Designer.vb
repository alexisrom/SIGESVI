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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmListadoProduccion))
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
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
        Me.BtnEliminar.AccessibleDescription = Nothing
        Me.BtnEliminar.AccessibleName = Nothing
        resources.ApplyResources(Me.BtnEliminar, "BtnEliminar")
        Me.BtnEliminar.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(161, Byte), Integer))
        Me.BtnEliminar.BackgroundImage = Nothing
        Me.BtnEliminar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnEliminar.FlatAppearance.BorderSize = 0
        Me.BtnEliminar.Font = Nothing
        Me.BtnEliminar.ForeColor = System.Drawing.Color.White
        Me.BtnEliminar.Name = "BtnEliminar"
        Me.BtnEliminar.UseVisualStyleBackColor = False
        '
        'BtnEditar
        '
        Me.BtnEditar.AccessibleDescription = Nothing
        Me.BtnEditar.AccessibleName = Nothing
        resources.ApplyResources(Me.BtnEditar, "BtnEditar")
        Me.BtnEditar.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(161, Byte), Integer))
        Me.BtnEditar.BackgroundImage = Nothing
        Me.BtnEditar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnEditar.FlatAppearance.BorderSize = 0
        Me.BtnEditar.Font = Nothing
        Me.BtnEditar.ForeColor = System.Drawing.Color.White
        Me.BtnEditar.Name = "BtnEditar"
        Me.BtnEditar.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AccessibleDescription = Nothing
        Me.Label1.AccessibleName = Nothing
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(172, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.Label1.Name = "Label1"
        '
        'BtnNueva
        '
        Me.BtnNueva.AccessibleDescription = Nothing
        Me.BtnNueva.AccessibleName = Nothing
        resources.ApplyResources(Me.BtnNueva, "BtnNueva")
        Me.BtnNueva.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(161, Byte), Integer))
        Me.BtnNueva.BackgroundImage = Nothing
        Me.BtnNueva.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnNueva.FlatAppearance.BorderSize = 0
        Me.BtnNueva.Font = Nothing
        Me.BtnNueva.ForeColor = System.Drawing.Color.White
        Me.BtnNueva.Name = "BtnNueva"
        Me.BtnNueva.UseVisualStyleBackColor = False
        '
        'DgvProduccion
        '
        Me.DgvProduccion.AccessibleDescription = Nothing
        Me.DgvProduccion.AccessibleName = Nothing
        resources.ApplyResources(Me.DgvProduccion, "DgvProduccion")
        Me.DgvProduccion.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(149, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.DgvProduccion.BackgroundImage = Nothing
        Me.DgvProduccion.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DgvProduccion.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(161, Byte), Integer))
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(211, Byte), Integer))
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgvProduccion.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle9
        Me.DgvProduccion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(149, Byte), Integer), CType(CType(167, Byte), Integer))
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DgvProduccion.DefaultCellStyle = DataGridViewCellStyle10
        Me.DgvProduccion.EnableHeadersVisualStyles = False
        Me.DgvProduccion.Font = Nothing
        Me.DgvProduccion.GridColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.DgvProduccion.MultiSelect = False
        Me.DgvProduccion.Name = "DgvProduccion"
        Me.DgvProduccion.ReadOnly = True
        Me.DgvProduccion.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(149, Byte), Integer), CType(CType(167, Byte), Integer))
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle11.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(211, Byte), Integer))
        DataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgvProduccion.RowHeadersDefaultCellStyle = DataGridViewCellStyle11
        DataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(149, Byte), Integer), CType(CType(167, Byte), Integer))
        DataGridViewCellStyle12.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle12.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.DgvProduccion.RowsDefaultCellStyle = DataGridViewCellStyle12
        Me.DgvProduccion.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(149, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.DgvProduccion.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White
        Me.DgvProduccion.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.DgvProduccion.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DgvProduccion.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        '
        'BtnTrazabilidad
        '
        Me.BtnTrazabilidad.AccessibleDescription = Nothing
        Me.BtnTrazabilidad.AccessibleName = Nothing
        resources.ApplyResources(Me.BtnTrazabilidad, "BtnTrazabilidad")
        Me.BtnTrazabilidad.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(161, Byte), Integer))
        Me.BtnTrazabilidad.BackgroundImage = Nothing
        Me.BtnTrazabilidad.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnTrazabilidad.FlatAppearance.BorderSize = 0
        Me.BtnTrazabilidad.Font = Nothing
        Me.BtnTrazabilidad.ForeColor = System.Drawing.Color.White
        Me.BtnTrazabilidad.Name = "BtnTrazabilidad"
        Me.BtnTrazabilidad.UseVisualStyleBackColor = False
        '
        'FrmListadoProduccion
        '
        Me.AccessibleDescription = Nothing
        Me.AccessibleName = Nothing
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.BackgroundImage = Nothing
        Me.Controls.Add(Me.BtnTrazabilidad)
        Me.Controls.Add(Me.BtnEliminar)
        Me.Controls.Add(Me.BtnEditar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtnNueva)
        Me.Controls.Add(Me.DgvProduccion)
        Me.Font = Nothing
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = Nothing
        Me.Name = "FrmListadoProduccion"
        CType(Me.DgvProduccion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BtnEliminar As System.Windows.Forms.Button
    Friend WithEvents BtnEditar As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents BtnNueva As System.Windows.Forms.Button
    Friend WithEvents DgvProduccion As System.Windows.Forms.DataGridView
    Friend WithEvents BtnTrazabilidad As System.Windows.Forms.Button
End Class
