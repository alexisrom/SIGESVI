<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCompra
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
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.Label1 = New System.Windows.Forms.Label
        Me.BtnEliminarProducto = New System.Windows.Forms.Button
        Me.BtnAgregarProducto = New System.Windows.Forms.Button
        Me.DgvProductos = New System.Windows.Forms.DataGridView
        Me.DtpFechaInicio = New System.Windows.Forms.DateTimePicker
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.BtnGuardar = New System.Windows.Forms.Button
        Me.TxtCosto_NUM_REQ = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.TxtID = New System.Windows.Forms.TextBox
        Me.Panel2.SuspendLayout()
        CType(Me.DgvProductos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.BtnEliminarProducto)
        Me.Panel2.Controls.Add(Me.BtnAgregarProducto)
        Me.Panel2.Controls.Add(Me.DgvProductos)
        Me.Panel2.Controls.Add(Me.DtpFechaInicio)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.BtnGuardar)
        Me.Panel2.Controls.Add(Me.TxtCosto_NUM_REQ)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.TxtID)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1217, 476)
        Me.Panel2.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(149, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(970, 49)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(152, 20)
        Me.Label1.TabIndex = 44
        Me.Label1.Text = "Productos Adquiridos"
        '
        'BtnEliminarProducto
        '
        Me.BtnEliminarProducto.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnEliminarProducto.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(161, Byte), Integer))
        Me.BtnEliminarProducto.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnEliminarProducto.FlatAppearance.BorderSize = 0
        Me.BtnEliminarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnEliminarProducto.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEliminarProducto.ForeColor = System.Drawing.Color.White
        Me.BtnEliminarProducto.Location = New System.Drawing.Point(1004, 364)
        Me.BtnEliminarProducto.Name = "BtnEliminarProducto"
        Me.BtnEliminarProducto.Size = New System.Drawing.Size(118, 28)
        Me.BtnEliminarProducto.TabIndex = 43
        Me.BtnEliminarProducto.Text = "ELIMINAR PRODUCTO"
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
        Me.BtnAgregarProducto.Location = New System.Drawing.Point(603, 364)
        Me.BtnAgregarProducto.Name = "BtnAgregarProducto"
        Me.BtnAgregarProducto.Size = New System.Drawing.Size(126, 28)
        Me.BtnAgregarProducto.TabIndex = 42
        Me.BtnAgregarProducto.Text = "AGREGAR PRODUCTO"
        Me.BtnAgregarProducto.UseVisualStyleBackColor = False
        '
        'DgvProductos
        '
        Me.DgvProductos.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DgvProductos.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(149, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.DgvProductos.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvProductos.Location = New System.Drawing.Point(603, 96)
        Me.DgvProductos.Name = "DgvProductos"
        Me.DgvProductos.Size = New System.Drawing.Size(519, 249)
        Me.DgvProductos.TabIndex = 41
        '
        'DtpFechaInicio
        '
        Me.DtpFechaInicio.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DtpFechaInicio.Location = New System.Drawing.Point(269, 194)
        Me.DtpFechaInicio.Name = "DtpFechaInicio"
        Me.DtpFechaInicio.Size = New System.Drawing.Size(237, 24)
        Me.DtpFechaInicio.TabIndex = 40
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 16.0!)
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(172, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(264, 30)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(218, 30)
        Me.Label3.TabIndex = 31
        Me.Label3.Text = "REGISTRAR COMPRA"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(149, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(178, 260)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(56, 20)
        Me.Label6.TabIndex = 30
        Me.Label6.Text = "COSTO"
        '
        'BtnGuardar
        '
        Me.BtnGuardar.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.BtnGuardar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnGuardar.FlatAppearance.BorderSize = 0
        Me.BtnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnGuardar.ForeColor = System.Drawing.Color.White
        Me.BtnGuardar.Location = New System.Drawing.Point(269, 331)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(237, 34)
        Me.BtnGuardar.TabIndex = 38
        Me.BtnGuardar.Text = "GUARDAR"
        Me.BtnGuardar.UseVisualStyleBackColor = False
        '
        'TxtCosto_NUM_REQ
        '
        Me.TxtCosto_NUM_REQ.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.TxtCosto_NUM_REQ.Location = New System.Drawing.Point(269, 253)
        Me.TxtCosto_NUM_REQ.Name = "TxtCosto_NUM_REQ"
        Me.TxtCosto_NUM_REQ.Size = New System.Drawing.Size(237, 27)
        Me.TxtCosto_NUM_REQ.TabIndex = 29
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(149, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(210, 146)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(24, 20)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "ID"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(149, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(133, 205)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(101, 20)
        Me.Label4.TabIndex = 31
        Me.Label4.Text = "FECHA/HORA"
        '
        'TxtID
        '
        Me.TxtID.Enabled = False
        Me.TxtID.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.TxtID.Location = New System.Drawing.Point(269, 139)
        Me.TxtID.Name = "TxtID"
        Me.TxtID.Size = New System.Drawing.Size(237, 27)
        Me.TxtID.TabIndex = 15
        '
        'FrmCompra
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1217, 476)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmCompra"
        Me.Text = "FrmCompra"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.DgvProductos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents BtnEliminarProducto As System.Windows.Forms.Button
    Friend WithEvents BtnAgregarProducto As System.Windows.Forms.Button
    Friend WithEvents DgvProductos As System.Windows.Forms.DataGridView
    Friend WithEvents DtpFechaInicio As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents BtnGuardar As System.Windows.Forms.Button
    Friend WithEvents TxtCosto_NUM_REQ As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TxtID As System.Windows.Forms.TextBox
End Class
