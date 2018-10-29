<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCompras
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmCompras))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.CboProveedores = New System.Windows.Forms.ComboBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.TxtCantidad_NUM = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.LstProductos_REQ = New System.Windows.Forms.ListBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.CboProductos = New System.Windows.Forms.ComboBox
        Me.BtnEliminarProducto = New System.Windows.Forms.Button
        Me.BtnAgregarProducto = New System.Windows.Forms.Button
        Me.BtnRegistrar = New System.Windows.Forms.Button
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.TxtCosto_NUM_REQ = New System.Windows.Forms.TextBox
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.Label3 = New System.Windows.Forms.Label
        Me.Button4 = New System.Windows.Forms.Button
        Me.BtnAgregarEtapa = New System.Windows.Forms.Button
        Me.DgvCompras = New System.Windows.Forms.DataGridView
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.DgvCompras, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.AccessibleDescription = Nothing
        Me.Panel1.AccessibleName = Nothing
        resources.ApplyResources(Me.Panel1, "Panel1")
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(149, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.Panel1.BackgroundImage = Nothing
        Me.Panel1.Controls.Add(Me.CboProveedores)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.TxtCantidad_NUM)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.LstProductos_REQ)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.CboProductos)
        Me.Panel1.Controls.Add(Me.BtnEliminarProducto)
        Me.Panel1.Controls.Add(Me.BtnAgregarProducto)
        Me.Panel1.Controls.Add(Me.BtnRegistrar)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.TxtCosto_NUM_REQ)
        Me.Panel1.Font = Nothing
        Me.Panel1.Name = "Panel1"
        '
        'CboProveedores
        '
        Me.CboProveedores.AccessibleDescription = Nothing
        Me.CboProveedores.AccessibleName = Nothing
        resources.ApplyResources(Me.CboProveedores, "CboProveedores")
        Me.CboProveedores.BackgroundImage = Nothing
        Me.CboProveedores.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboProveedores.FormattingEnabled = True
        Me.CboProveedores.Name = "CboProveedores"
        '
        'Label6
        '
        Me.Label6.AccessibleDescription = Nothing
        Me.Label6.AccessibleName = Nothing
        resources.ApplyResources(Me.Label6, "Label6")
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.Label6.Name = "Label6"
        '
        'Label4
        '
        Me.Label4.AccessibleDescription = Nothing
        Me.Label4.AccessibleName = Nothing
        resources.ApplyResources(Me.Label4, "Label4")
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.Label4.Name = "Label4"
        '
        'TxtCantidad_NUM
        '
        Me.TxtCantidad_NUM.AccessibleDescription = Nothing
        Me.TxtCantidad_NUM.AccessibleName = Nothing
        resources.ApplyResources(Me.TxtCantidad_NUM, "TxtCantidad_NUM")
        Me.TxtCantidad_NUM.BackgroundImage = Nothing
        Me.TxtCantidad_NUM.Name = "TxtCantidad_NUM"
        '
        'Label5
        '
        Me.Label5.AccessibleDescription = Nothing
        Me.Label5.AccessibleName = Nothing
        resources.ApplyResources(Me.Label5, "Label5")
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.Label5.Name = "Label5"
        '
        'LstProductos_REQ
        '
        Me.LstProductos_REQ.AccessibleDescription = Nothing
        Me.LstProductos_REQ.AccessibleName = Nothing
        resources.ApplyResources(Me.LstProductos_REQ, "LstProductos_REQ")
        Me.LstProductos_REQ.BackgroundImage = Nothing
        Me.LstProductos_REQ.FormattingEnabled = True
        Me.LstProductos_REQ.Name = "LstProductos_REQ"
        '
        'Label8
        '
        Me.Label8.AccessibleDescription = Nothing
        Me.Label8.AccessibleName = Nothing
        resources.ApplyResources(Me.Label8, "Label8")
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.Label8.Name = "Label8"
        '
        'CboProductos
        '
        Me.CboProductos.AccessibleDescription = Nothing
        Me.CboProductos.AccessibleName = Nothing
        resources.ApplyResources(Me.CboProductos, "CboProductos")
        Me.CboProductos.BackColor = System.Drawing.Color.White
        Me.CboProductos.BackgroundImage = Nothing
        Me.CboProductos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboProductos.FormattingEnabled = True
        Me.CboProductos.Name = "CboProductos"
        '
        'BtnEliminarProducto
        '
        Me.BtnEliminarProducto.AccessibleDescription = Nothing
        Me.BtnEliminarProducto.AccessibleName = Nothing
        resources.ApplyResources(Me.BtnEliminarProducto, "BtnEliminarProducto")
        Me.BtnEliminarProducto.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(161, Byte), Integer))
        Me.BtnEliminarProducto.BackgroundImage = Nothing
        Me.BtnEliminarProducto.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnEliminarProducto.FlatAppearance.BorderSize = 0
        Me.BtnEliminarProducto.ForeColor = System.Drawing.Color.White
        Me.BtnEliminarProducto.Name = "BtnEliminarProducto"
        Me.BtnEliminarProducto.UseVisualStyleBackColor = False
        '
        'BtnAgregarProducto
        '
        Me.BtnAgregarProducto.AccessibleDescription = Nothing
        Me.BtnAgregarProducto.AccessibleName = Nothing
        resources.ApplyResources(Me.BtnAgregarProducto, "BtnAgregarProducto")
        Me.BtnAgregarProducto.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(161, Byte), Integer))
        Me.BtnAgregarProducto.BackgroundImage = Nothing
        Me.BtnAgregarProducto.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnAgregarProducto.FlatAppearance.BorderSize = 0
        Me.BtnAgregarProducto.ForeColor = System.Drawing.Color.White
        Me.BtnAgregarProducto.Name = "BtnAgregarProducto"
        Me.BtnAgregarProducto.UseVisualStyleBackColor = False
        '
        'BtnRegistrar
        '
        Me.BtnRegistrar.AccessibleDescription = Nothing
        Me.BtnRegistrar.AccessibleName = Nothing
        resources.ApplyResources(Me.BtnRegistrar, "BtnRegistrar")
        Me.BtnRegistrar.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.BtnRegistrar.BackgroundImage = Nothing
        Me.BtnRegistrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnRegistrar.FlatAppearance.BorderSize = 0
        Me.BtnRegistrar.Font = Nothing
        Me.BtnRegistrar.ForeColor = System.Drawing.Color.White
        Me.BtnRegistrar.Name = "BtnRegistrar"
        Me.BtnRegistrar.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AccessibleDescription = Nothing
        Me.Label2.AccessibleName = Nothing
        resources.ApplyResources(Me.Label2, "Label2")
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.Label2.Name = "Label2"
        '
        'Label1
        '
        Me.Label1.AccessibleDescription = Nothing
        Me.Label1.AccessibleName = Nothing
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.Label1.Name = "Label1"
        '
        'TxtCosto_NUM_REQ
        '
        Me.TxtCosto_NUM_REQ.AccessibleDescription = Nothing
        Me.TxtCosto_NUM_REQ.AccessibleName = Nothing
        resources.ApplyResources(Me.TxtCosto_NUM_REQ, "TxtCosto_NUM_REQ")
        Me.TxtCosto_NUM_REQ.BackgroundImage = Nothing
        Me.TxtCosto_NUM_REQ.Name = "TxtCosto_NUM_REQ"
        '
        'Panel2
        '
        Me.Panel2.AccessibleDescription = Nothing
        Me.Panel2.AccessibleName = Nothing
        resources.ApplyResources(Me.Panel2, "Panel2")
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.Panel2.BackgroundImage = Nothing
        Me.Panel2.Controls.Add(Me.DgvCompras)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.Button4)
        Me.Panel2.Controls.Add(Me.BtnAgregarEtapa)
        Me.Panel2.Font = Nothing
        Me.Panel2.Name = "Panel2"
        '
        'Label3
        '
        Me.Label3.AccessibleDescription = Nothing
        Me.Label3.AccessibleName = Nothing
        resources.ApplyResources(Me.Label3, "Label3")
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(172, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.Label3.Name = "Label3"
        '
        'Button4
        '
        Me.Button4.AccessibleDescription = Nothing
        Me.Button4.AccessibleName = Nothing
        resources.ApplyResources(Me.Button4, "Button4")
        Me.Button4.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(161, Byte), Integer))
        Me.Button4.BackgroundImage = Nothing
        Me.Button4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button4.FlatAppearance.BorderSize = 0
        Me.Button4.ForeColor = System.Drawing.Color.White
        Me.Button4.Name = "Button4"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'BtnAgregarEtapa
        '
        Me.BtnAgregarEtapa.AccessibleDescription = Nothing
        Me.BtnAgregarEtapa.AccessibleName = Nothing
        resources.ApplyResources(Me.BtnAgregarEtapa, "BtnAgregarEtapa")
        Me.BtnAgregarEtapa.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(161, Byte), Integer))
        Me.BtnAgregarEtapa.BackgroundImage = Nothing
        Me.BtnAgregarEtapa.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnAgregarEtapa.FlatAppearance.BorderSize = 0
        Me.BtnAgregarEtapa.ForeColor = System.Drawing.Color.White
        Me.BtnAgregarEtapa.Name = "BtnAgregarEtapa"
        Me.BtnAgregarEtapa.UseVisualStyleBackColor = False
        '
        'DgvCompras
        '
        Me.DgvCompras.AccessibleDescription = Nothing
        Me.DgvCompras.AccessibleName = Nothing
        resources.ApplyResources(Me.DgvCompras, "DgvCompras")
        Me.DgvCompras.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(149, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.DgvCompras.BackgroundImage = Nothing
        Me.DgvCompras.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DgvCompras.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(161, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(211, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgvCompras.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DgvCompras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(149, Byte), Integer), CType(CType(167, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DgvCompras.DefaultCellStyle = DataGridViewCellStyle2
        Me.DgvCompras.EnableHeadersVisualStyles = False
        Me.DgvCompras.Font = Nothing
        Me.DgvCompras.GridColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.DgvCompras.MultiSelect = False
        Me.DgvCompras.Name = "DgvCompras"
        Me.DgvCompras.ReadOnly = True
        Me.DgvCompras.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(149, Byte), Integer), CType(CType(167, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(211, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgvCompras.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(149, Byte), Integer), CType(CType(167, Byte), Integer))
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.DgvCompras.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.DgvCompras.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(149, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.DgvCompras.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White
        Me.DgvCompras.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.DgvCompras.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DgvCompras.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        '
        'FrmCompras
        '
        Me.AccessibleDescription = Nothing
        Me.AccessibleName = Nothing
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Nothing
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Font = Nothing
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = Nothing
        Me.Name = "FrmCompras"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        CType(Me.DgvCompras, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents BtnRegistrar As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TxtCosto_NUM_REQ As System.Windows.Forms.TextBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents BtnAgregarEtapa As System.Windows.Forms.Button
    Friend WithEvents BtnEliminarProducto As System.Windows.Forms.Button
    Friend WithEvents BtnAgregarProducto As System.Windows.Forms.Button
    Friend WithEvents LstProductos_REQ As System.Windows.Forms.ListBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents CboProductos As System.Windows.Forms.ComboBox
    Friend WithEvents TxtCantidad_NUM As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents CboProveedores As System.Windows.Forms.ComboBox
    Friend WithEvents DgvCompras As System.Windows.Forms.DataGridView
End Class
