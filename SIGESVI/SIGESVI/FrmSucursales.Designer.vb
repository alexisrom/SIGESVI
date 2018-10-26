<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmSucursales
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
        Me.BtnCancelar = New System.Windows.Forms.Button
        Me.BtnGuardar = New System.Windows.Forms.Button
        Me.BtnEliminarTelefono = New System.Windows.Forms.Button
        Me.BtnAgregarTelefono = New System.Windows.Forms.Button
        Me.TxtTelefono_NUM = New System.Windows.Forms.TextBox
        Me.LstTelefonos_REQ = New System.Windows.Forms.ListBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.TxtDireccion_REQ = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.TxtDepartamento_REQ = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.TxtID = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.TxtNombre_REQ = New System.Windows.Forms.TextBox
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.Label3 = New System.Windows.Forms.Label
        Me.BtnEliminar = New System.Windows.Forms.Button
        Me.BtnEditar = New System.Windows.Forms.Button
        Me.DgvSucursales = New System.Windows.Forms.DataGridView
        Me.CbProveedor = New System.Windows.Forms.CheckBox
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.DgvSucursales, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(149, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.Panel1.Controls.Add(Me.CbProveedor)
        Me.Panel1.Controls.Add(Me.BtnCancelar)
        Me.Panel1.Controls.Add(Me.BtnGuardar)
        Me.Panel1.Controls.Add(Me.BtnEliminarTelefono)
        Me.Panel1.Controls.Add(Me.BtnAgregarTelefono)
        Me.Panel1.Controls.Add(Me.TxtTelefono_NUM)
        Me.Panel1.Controls.Add(Me.LstTelefonos_REQ)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.TxtDireccion_REQ)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.TxtDepartamento_REQ)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.TxtID)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.TxtNombre_REQ)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel1.Location = New System.Drawing.Point(906, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(437, 495)
        Me.Panel1.TabIndex = 0
        '
        'BtnCancelar
        '
        Me.BtnCancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnCancelar.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(161, Byte), Integer))
        Me.BtnCancelar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnCancelar.FlatAppearance.BorderSize = 0
        Me.BtnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCancelar.ForeColor = System.Drawing.Color.White
        Me.BtnCancelar.Location = New System.Drawing.Point(212, 441)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(131, 28)
        Me.BtnCancelar.TabIndex = 39
        Me.BtnCancelar.Text = "CANCELAR"
        Me.BtnCancelar.UseVisualStyleBackColor = False
        '
        'BtnGuardar
        '
        Me.BtnGuardar.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.BtnGuardar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnGuardar.FlatAppearance.BorderSize = 0
        Me.BtnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnGuardar.ForeColor = System.Drawing.Color.White
        Me.BtnGuardar.Location = New System.Drawing.Point(160, 389)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(237, 34)
        Me.BtnGuardar.TabIndex = 38
        Me.BtnGuardar.Text = "GUARDAR"
        Me.BtnGuardar.UseVisualStyleBackColor = False
        '
        'BtnEliminarTelefono
        '
        Me.BtnEliminarTelefono.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(161, Byte), Integer))
        Me.BtnEliminarTelefono.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnEliminarTelefono.FlatAppearance.BorderSize = 0
        Me.BtnEliminarTelefono.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnEliminarTelefono.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEliminarTelefono.ForeColor = System.Drawing.Color.White
        Me.BtnEliminarTelefono.Location = New System.Drawing.Point(284, 268)
        Me.BtnEliminarTelefono.Name = "BtnEliminarTelefono"
        Me.BtnEliminarTelefono.Size = New System.Drawing.Size(113, 23)
        Me.BtnEliminarTelefono.TabIndex = 37
        Me.BtnEliminarTelefono.Text = "ELIMINAR"
        Me.BtnEliminarTelefono.UseVisualStyleBackColor = False
        '
        'BtnAgregarTelefono
        '
        Me.BtnAgregarTelefono.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(161, Byte), Integer))
        Me.BtnAgregarTelefono.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnAgregarTelefono.FlatAppearance.BorderSize = 0
        Me.BtnAgregarTelefono.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAgregarTelefono.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAgregarTelefono.ForeColor = System.Drawing.Color.White
        Me.BtnAgregarTelefono.Location = New System.Drawing.Point(160, 268)
        Me.BtnAgregarTelefono.Name = "BtnAgregarTelefono"
        Me.BtnAgregarTelefono.Size = New System.Drawing.Size(113, 23)
        Me.BtnAgregarTelefono.TabIndex = 28
        Me.BtnAgregarTelefono.Text = "AGREGAR"
        Me.BtnAgregarTelefono.UseVisualStyleBackColor = False
        '
        'TxtTelefono_NUM
        '
        Me.TxtTelefono_NUM.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.TxtTelefono_NUM.Location = New System.Drawing.Point(160, 235)
        Me.TxtTelefono_NUM.Name = "TxtTelefono_NUM"
        Me.TxtTelefono_NUM.Size = New System.Drawing.Size(237, 27)
        Me.TxtTelefono_NUM.TabIndex = 36
        '
        'LstTelefonos_REQ
        '
        Me.LstTelefonos_REQ.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LstTelefonos_REQ.FormattingEnabled = True
        Me.LstTelefonos_REQ.ItemHeight = 20
        Me.LstTelefonos_REQ.Location = New System.Drawing.Point(160, 297)
        Me.LstTelefonos_REQ.Name = "LstTelefonos_REQ"
        Me.LstTelefonos_REQ.Size = New System.Drawing.Size(237, 84)
        Me.LstTelefonos_REQ.TabIndex = 35
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(54, 238)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(88, 20)
        Me.Label7.TabIndex = 34
        Me.Label7.Text = "TELÉFONOS"
        '
        'TxtDireccion_REQ
        '
        Me.TxtDireccion_REQ.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.TxtDireccion_REQ.Location = New System.Drawing.Point(160, 158)
        Me.TxtDireccion_REQ.Name = "TxtDireccion_REQ"
        Me.TxtDireccion_REQ.Size = New System.Drawing.Size(237, 27)
        Me.TxtDireccion_REQ.TabIndex = 32
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(57, 160)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(85, 20)
        Me.Label4.TabIndex = 31
        Me.Label4.Text = "DIRECCIÓN"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(18, 199)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(124, 20)
        Me.Label6.TabIndex = 30
        Me.Label6.Text = "DEPARTAMENTO"
        '
        'TxtDepartamento_REQ
        '
        Me.TxtDepartamento_REQ.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.TxtDepartamento_REQ.Location = New System.Drawing.Point(160, 196)
        Me.TxtDepartamento_REQ.Name = "TxtDepartamento_REQ"
        Me.TxtDepartamento_REQ.Size = New System.Drawing.Size(237, 27)
        Me.TxtDepartamento_REQ.TabIndex = 29
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(208, 38)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(189, 20)
        Me.Label2.TabIndex = 28
        Me.Label2.Text = "Mantenimiento de Sucursal"
        '
        'TxtID
        '
        Me.TxtID.Enabled = False
        Me.TxtID.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.TxtID.Location = New System.Drawing.Point(160, 82)
        Me.TxtID.Name = "TxtID"
        Me.TxtID.Size = New System.Drawing.Size(113, 27)
        Me.TxtID.TabIndex = 15
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(118, 82)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(24, 20)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "ID"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(72, 121)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 20)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "NOMBRE"
        '
        'TxtNombre_REQ
        '
        Me.TxtNombre_REQ.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.TxtNombre_REQ.Location = New System.Drawing.Point(160, 120)
        Me.TxtNombre_REQ.Name = "TxtNombre_REQ"
        Me.TxtNombre_REQ.Size = New System.Drawing.Size(237, 27)
        Me.TxtNombre_REQ.TabIndex = 12
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.BtnEliminar)
        Me.Panel2.Controls.Add(Me.BtnEditar)
        Me.Panel2.Controls.Add(Me.DgvSucursales)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(906, 495)
        Me.Panel2.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 16.0!)
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(172, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(348, 38)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(141, 30)
        Me.Label3.TabIndex = 31
        Me.Label3.Text = "SUCURSALES"
        '
        'BtnEliminar
        '
        Me.BtnEliminar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnEliminar.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(161, Byte), Integer))
        Me.BtnEliminar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnEliminar.FlatAppearance.BorderSize = 0
        Me.BtnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnEliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEliminar.ForeColor = System.Drawing.Color.White
        Me.BtnEliminar.Location = New System.Drawing.Point(704, 429)
        Me.BtnEliminar.Name = "BtnEliminar"
        Me.BtnEliminar.Size = New System.Drawing.Size(118, 28)
        Me.BtnEliminar.TabIndex = 30
        Me.BtnEliminar.Text = "ELIMINAR SUCURSAL"
        Me.BtnEliminar.UseVisualStyleBackColor = False
        '
        'BtnEditar
        '
        Me.BtnEditar.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(161, Byte), Integer))
        Me.BtnEditar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnEditar.FlatAppearance.BorderSize = 0
        Me.BtnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnEditar.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEditar.ForeColor = System.Drawing.Color.White
        Me.BtnEditar.Location = New System.Drawing.Point(83, 429)
        Me.BtnEditar.Name = "BtnEditar"
        Me.BtnEditar.Size = New System.Drawing.Size(113, 28)
        Me.BtnEditar.TabIndex = 29
        Me.BtnEditar.Text = "EDITAR SUCURSAL"
        Me.BtnEditar.UseVisualStyleBackColor = False
        '
        'DgvSucursales
        '
        Me.DgvSucursales.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DgvSucursales.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(149, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.DgvSucursales.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DgvSucursales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvSucursales.Location = New System.Drawing.Point(83, 82)
        Me.DgvSucursales.Name = "DgvSucursales"
        Me.DgvSucursales.Size = New System.Drawing.Size(739, 341)
        Me.DgvSucursales.TabIndex = 28
        '
        'CbProveedor
        '
        Me.CbProveedor.AutoSize = True
        Me.CbProveedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CbProveedor.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbProveedor.ForeColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.CbProveedor.Location = New System.Drawing.Point(305, 85)
        Me.CbProveedor.Name = "CbProveedor"
        Me.CbProveedor.Size = New System.Drawing.Size(89, 19)
        Me.CbProveedor.TabIndex = 40
        Me.CbProveedor.Text = "PROVEEDOR"
        Me.CbProveedor.UseVisualStyleBackColor = True
        '
        'FrmSucursales
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1343, 495)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmSucursales"
        Me.Text = "FrmSucursales"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.DgvSucursales, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents TxtID As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TxtNombre_REQ As System.Windows.Forms.TextBox
    Friend WithEvents TxtDireccion_REQ As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TxtDepartamento_REQ As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents BtnEliminarTelefono As System.Windows.Forms.Button
    Friend WithEvents BtnAgregarTelefono As System.Windows.Forms.Button
    Friend WithEvents TxtTelefono_NUM As System.Windows.Forms.TextBox
    Friend WithEvents LstTelefonos_REQ As System.Windows.Forms.ListBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents BtnGuardar As System.Windows.Forms.Button
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents BtnEliminar As System.Windows.Forms.Button
    Friend WithEvents BtnEditar As System.Windows.Forms.Button
    Friend WithEvents DgvSucursales As System.Windows.Forms.DataGridView
    Friend WithEvents BtnCancelar As System.Windows.Forms.Button
    Friend WithEvents CbProveedor As System.Windows.Forms.CheckBox
End Class
