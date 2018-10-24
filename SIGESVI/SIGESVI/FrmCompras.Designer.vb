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
        Me.Panel1 = New System.Windows.Forms.Panel
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
        Me.Label6 = New System.Windows.Forms.Label
        Me.CboProveedores = New System.Windows.Forms.ComboBox
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.DgvCompras, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(149, Byte), Integer), CType(CType(167, Byte), Integer))
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
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel1.Location = New System.Drawing.Point(648, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(437, 488)
        Me.Panel1.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(50, 310)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(93, 20)
        Me.Label4.TabIndex = 47
        Me.Label4.Text = "PROVEEDOR"
        '
        'TxtCantidad_NUM
        '
        Me.TxtCantidad_NUM.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.TxtCantidad_NUM.Location = New System.Drawing.Point(149, 135)
        Me.TxtCantidad_NUM.Name = "TxtCantidad_NUM"
        Me.TxtCantidad_NUM.Size = New System.Drawing.Size(237, 27)
        Me.TxtCantidad_NUM.TabIndex = 45
        Me.TxtCantidad_NUM.Text = "1"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(46, 143)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(83, 20)
        Me.Label5.TabIndex = 44
        Me.Label5.Text = "CANTIDAD"
        '
        'LstProductos_REQ
        '
        Me.LstProductos_REQ.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LstProductos_REQ.FormattingEnabled = True
        Me.LstProductos_REQ.ItemHeight = 18
        Me.LstProductos_REQ.Location = New System.Drawing.Point(150, 218)
        Me.LstProductos_REQ.Name = "LstProductos_REQ"
        Me.LstProductos_REQ.Size = New System.Drawing.Size(237, 76)
        Me.LstProductos_REQ.TabIndex = 43
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(45, 98)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(86, 20)
        Me.Label8.TabIndex = 42
        Me.Label8.Text = "PRODUCTO"
        '
        'CboProductos
        '
        Me.CboProductos.BackColor = System.Drawing.Color.White
        Me.CboProductos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CboProductos.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.CboProductos.FormattingEnabled = True
        Me.CboProductos.Location = New System.Drawing.Point(150, 91)
        Me.CboProductos.Name = "CboProductos"
        Me.CboProductos.Size = New System.Drawing.Size(236, 28)
        Me.CboProductos.TabIndex = 41
        '
        'BtnEliminarProducto
        '
        Me.BtnEliminarProducto.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(161, Byte), Integer))
        Me.BtnEliminarProducto.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnEliminarProducto.FlatAppearance.BorderSize = 0
        Me.BtnEliminarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnEliminarProducto.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEliminarProducto.ForeColor = System.Drawing.Color.White
        Me.BtnEliminarProducto.Location = New System.Drawing.Point(274, 175)
        Me.BtnEliminarProducto.Name = "BtnEliminarProducto"
        Me.BtnEliminarProducto.Size = New System.Drawing.Size(114, 23)
        Me.BtnEliminarProducto.TabIndex = 40
        Me.BtnEliminarProducto.Text = "ELIMINAR"
        Me.BtnEliminarProducto.UseVisualStyleBackColor = False
        '
        'BtnAgregarProducto
        '
        Me.BtnAgregarProducto.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(161, Byte), Integer))
        Me.BtnAgregarProducto.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnAgregarProducto.FlatAppearance.BorderSize = 0
        Me.BtnAgregarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAgregarProducto.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAgregarProducto.ForeColor = System.Drawing.Color.White
        Me.BtnAgregarProducto.Location = New System.Drawing.Point(150, 175)
        Me.BtnAgregarProducto.Name = "BtnAgregarProducto"
        Me.BtnAgregarProducto.Size = New System.Drawing.Size(114, 23)
        Me.BtnAgregarProducto.TabIndex = 39
        Me.BtnAgregarProducto.Text = "AGREGAR"
        Me.BtnAgregarProducto.UseVisualStyleBackColor = False
        '
        'BtnRegistrar
        '
        Me.BtnRegistrar.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.BtnRegistrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnRegistrar.FlatAppearance.BorderSize = 0
        Me.BtnRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnRegistrar.ForeColor = System.Drawing.Color.White
        Me.BtnRegistrar.Location = New System.Drawing.Point(150, 392)
        Me.BtnRegistrar.Name = "BtnRegistrar"
        Me.BtnRegistrar.Size = New System.Drawing.Size(237, 34)
        Me.BtnRegistrar.TabIndex = 38
        Me.BtnRegistrar.Text = "REGISTRAR"
        Me.BtnRegistrar.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(199, 46)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(194, 20)
        Me.Label2.TabIndex = 28
        Me.Label2.Text = "Mantenimiento de Compras"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(39, 347)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(104, 20)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "COSTO TOTAL"
        '
        'TxtCosto_NUM_REQ
        '
        Me.TxtCosto_NUM_REQ.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.TxtCosto_NUM_REQ.Location = New System.Drawing.Point(149, 344)
        Me.TxtCosto_NUM_REQ.Name = "TxtCosto_NUM_REQ"
        Me.TxtCosto_NUM_REQ.Size = New System.Drawing.Size(237, 27)
        Me.TxtCosto_NUM_REQ.TabIndex = 12
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.Button4)
        Me.Panel2.Controls.Add(Me.BtnAgregarEtapa)
        Me.Panel2.Controls.Add(Me.DgvCompras)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(648, 488)
        Me.Panel2.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 16.0!)
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(172, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(262, 36)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(115, 30)
        Me.Label3.TabIndex = 31
        Me.Label3.Text = "COMPRAS"
        '
        'Button4
        '
        Me.Button4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button4.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(161, Byte), Integer))
        Me.Button4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button4.FlatAppearance.BorderSize = 0
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.Color.White
        Me.Button4.Location = New System.Drawing.Point(446, 398)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(118, 28)
        Me.Button4.TabIndex = 30
        Me.Button4.Text = "ELIMINAR COMPRA"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'BtnAgregarEtapa
        '
        Me.BtnAgregarEtapa.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(161, Byte), Integer))
        Me.BtnAgregarEtapa.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnAgregarEtapa.FlatAppearance.BorderSize = 0
        Me.BtnAgregarEtapa.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAgregarEtapa.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAgregarEtapa.ForeColor = System.Drawing.Color.White
        Me.BtnAgregarEtapa.Location = New System.Drawing.Point(83, 396)
        Me.BtnAgregarEtapa.Name = "BtnAgregarEtapa"
        Me.BtnAgregarEtapa.Size = New System.Drawing.Size(113, 28)
        Me.BtnAgregarEtapa.TabIndex = 29
        Me.BtnAgregarEtapa.Text = "EDITAR COMPRA"
        Me.BtnAgregarEtapa.UseVisualStyleBackColor = False
        '
        'DgvCompras
        '
        Me.DgvCompras.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DgvCompras.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(149, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.DgvCompras.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DgvCompras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvCompras.Location = New System.Drawing.Point(83, 82)
        Me.DgvCompras.Name = "DgvCompras"
        Me.DgvCompras.Size = New System.Drawing.Size(481, 289)
        Me.DgvCompras.TabIndex = 28
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(78, 238)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(51, 20)
        Me.Label6.TabIndex = 48
        Me.Label6.Text = "LOTES"
        '
        'CboProveedores
        '
        Me.CboProveedores.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboProveedores.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboProveedores.FormattingEnabled = True
        Me.CboProveedores.Location = New System.Drawing.Point(149, 307)
        Me.CboProveedores.Name = "CboProveedores"
        Me.CboProveedores.Size = New System.Drawing.Size(238, 28)
        Me.CboProveedores.TabIndex = 49
        '
        'FrmCompras
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1085, 488)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmCompras"
        Me.Text = "FrmCompras"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
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
    Friend WithEvents DgvCompras As System.Windows.Forms.DataGridView
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
End Class
