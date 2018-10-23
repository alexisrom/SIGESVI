<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmFuncionarios
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
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.BtnCancelar = New System.Windows.Forms.Button
        Me.Label11 = New System.Windows.Forms.Label
        Me.CboSucursales_REQ = New System.Windows.Forms.ComboBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.TxtUser_REQ = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.TxtApellido_LET_REQ = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.CboCargo_REQ = New System.Windows.Forms.ComboBox
        Me.BtnGuardar = New System.Windows.Forms.Button
        Me.TxtTelefono_NUM_REQ = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.TxtDireccion_REQ = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.TxtPass_REQ = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.TxtID_NUM_REQ = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.TxtNombre_LET_REQ = New System.Windows.Forms.TextBox
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.DgvFuncionarios = New System.Windows.Forms.DataGridView
        Me.Label3 = New System.Windows.Forms.Label
        Me.BtnEliminar = New System.Windows.Forms.Button
        Me.BtnEditar = New System.Windows.Forms.Button
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.DgvFuncionarios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(149, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.Panel1.Controls.Add(Me.BtnCancelar)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.CboSucursales_REQ)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.TxtUser_REQ)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.TxtApellido_LET_REQ)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.CboCargo_REQ)
        Me.Panel1.Controls.Add(Me.BtnGuardar)
        Me.Panel1.Controls.Add(Me.TxtTelefono_NUM_REQ)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.TxtDireccion_REQ)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.TxtPass_REQ)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.TxtID_NUM_REQ)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.TxtNombre_LET_REQ)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel1.Location = New System.Drawing.Point(647, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(437, 610)
        Me.Panel1.TabIndex = 1
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
        Me.BtnCancelar.Location = New System.Drawing.Point(212, 513)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(131, 28)
        Me.BtnCancelar.TabIndex = 32
        Me.BtnCancelar.Text = "CANCELAR"
        Me.BtnCancelar.UseVisualStyleBackColor = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.Label11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.Label11.Location = New System.Drawing.Point(63, 419)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(80, 20)
        Me.Label11.TabIndex = 46
        Me.Label11.Text = "SUCURSAL"
        '
        'CboSucursales_REQ
        '
        Me.CboSucursales_REQ.BackColor = System.Drawing.Color.White
        Me.CboSucursales_REQ.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboSucursales_REQ.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CboSucursales_REQ.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.CboSucursales_REQ.FormattingEnabled = True
        Me.CboSucursales_REQ.Location = New System.Drawing.Point(160, 416)
        Me.CboSucursales_REQ.Name = "CboSucursales_REQ"
        Me.CboSucursales_REQ.Size = New System.Drawing.Size(237, 28)
        Me.CboSucursales_REQ.TabIndex = 45
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.Label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.Label10.Location = New System.Drawing.Point(72, 250)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(71, 20)
        Me.Label10.TabIndex = 44
        Me.Label10.Text = "USUARIO"
        '
        'TxtUser_REQ
        '
        Me.TxtUser_REQ.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.TxtUser_REQ.Location = New System.Drawing.Point(160, 246)
        Me.TxtUser_REQ.Name = "TxtUser_REQ"
        Me.TxtUser_REQ.Size = New System.Drawing.Size(237, 27)
        Me.TxtUser_REQ.TabIndex = 43
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(68, 166)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(75, 20)
        Me.Label9.TabIndex = 42
        Me.Label9.Text = "APELLIDO"
        '
        'TxtApellido_LET_REQ
        '
        Me.TxtApellido_LET_REQ.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.TxtApellido_LET_REQ.Location = New System.Drawing.Point(160, 164)
        Me.TxtApellido_LET_REQ.Name = "TxtApellido_LET_REQ"
        Me.TxtApellido_LET_REQ.Size = New System.Drawing.Size(237, 27)
        Me.TxtApellido_LET_REQ.TabIndex = 41
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(85, 376)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(58, 20)
        Me.Label8.TabIndex = 40
        Me.Label8.Text = "CARGO"
        '
        'CboCargo_REQ
        '
        Me.CboCargo_REQ.BackColor = System.Drawing.Color.White
        Me.CboCargo_REQ.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboCargo_REQ.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CboCargo_REQ.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.CboCargo_REQ.FormattingEnabled = True
        Me.CboCargo_REQ.Items.AddRange(New Object() {"Administrativo", "Asesor Profesional", "Enologo", "Gerente General", "Gerente Sucursal"})
        Me.CboCargo_REQ.Location = New System.Drawing.Point(160, 369)
        Me.CboCargo_REQ.Name = "CboCargo_REQ"
        Me.CboCargo_REQ.Size = New System.Drawing.Size(237, 28)
        Me.CboCargo_REQ.TabIndex = 39
        '
        'BtnGuardar
        '
        Me.BtnGuardar.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.BtnGuardar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnGuardar.FlatAppearance.BorderSize = 0
        Me.BtnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnGuardar.ForeColor = System.Drawing.Color.White
        Me.BtnGuardar.Location = New System.Drawing.Point(160, 462)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(237, 34)
        Me.BtnGuardar.TabIndex = 38
        Me.BtnGuardar.Text = "GUARDAR"
        Me.BtnGuardar.UseVisualStyleBackColor = False
        '
        'TxtTelefono_NUM_REQ
        '
        Me.TxtTelefono_NUM_REQ.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.TxtTelefono_NUM_REQ.Location = New System.Drawing.Point(160, 328)
        Me.TxtTelefono_NUM_REQ.Name = "TxtTelefono_NUM_REQ"
        Me.TxtTelefono_NUM_REQ.Size = New System.Drawing.Size(237, 27)
        Me.TxtTelefono_NUM_REQ.TabIndex = 36
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(63, 334)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(80, 20)
        Me.Label7.TabIndex = 34
        Me.Label7.Text = "TELÉFONO"
        '
        'TxtDireccion_REQ
        '
        Me.TxtDireccion_REQ.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.TxtDireccion_REQ.Location = New System.Drawing.Point(160, 205)
        Me.TxtDireccion_REQ.Name = "TxtDireccion_REQ"
        Me.TxtDireccion_REQ.Size = New System.Drawing.Size(237, 27)
        Me.TxtDireccion_REQ.TabIndex = 32
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(58, 208)
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
        Me.Label6.Location = New System.Drawing.Point(39, 292)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(104, 20)
        Me.Label6.TabIndex = 30
        Me.Label6.Text = "CONTRASEÑA"
        '
        'TxtPass_REQ
        '
        Me.TxtPass_REQ.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.TxtPass_REQ.Location = New System.Drawing.Point(160, 287)
        Me.TxtPass_REQ.Name = "TxtPass_REQ"
        Me.TxtPass_REQ.Size = New System.Drawing.Size(237, 27)
        Me.TxtPass_REQ.TabIndex = 29
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(185, 21)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(212, 20)
        Me.Label2.TabIndex = 28
        Me.Label2.Text = "Mantenimiento de Funcionario"
        '
        'TxtID_NUM_REQ
        '
        Me.TxtID_NUM_REQ.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.TxtID_NUM_REQ.Location = New System.Drawing.Point(160, 82)
        Me.TxtID_NUM_REQ.Name = "TxtID_NUM_REQ"
        Me.TxtID_NUM_REQ.Size = New System.Drawing.Size(237, 27)
        Me.TxtID_NUM_REQ.TabIndex = 15
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(119, 82)
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
        Me.Label1.Location = New System.Drawing.Point(73, 124)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 20)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "NOMBRE"
        '
        'TxtNombre_LET_REQ
        '
        Me.TxtNombre_LET_REQ.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.TxtNombre_LET_REQ.Location = New System.Drawing.Point(160, 123)
        Me.TxtNombre_LET_REQ.Name = "TxtNombre_LET_REQ"
        Me.TxtNombre_LET_REQ.Size = New System.Drawing.Size(237, 27)
        Me.TxtNombre_LET_REQ.TabIndex = 12
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.Panel2.Controls.Add(Me.DgvFuncionarios)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.BtnEliminar)
        Me.Panel2.Controls.Add(Me.BtnEditar)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(647, 610)
        Me.Panel2.TabIndex = 3
        '
        'DgvFuncionarios
        '
        Me.DgvFuncionarios.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(149, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.DgvFuncionarios.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DgvFuncionarios.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(161, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(211, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgvFuncionarios.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DgvFuncionarios.ColumnHeadersHeight = 25
        Me.DgvFuncionarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(149, Byte), Integer), CType(CType(167, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DgvFuncionarios.DefaultCellStyle = DataGridViewCellStyle2
        Me.DgvFuncionarios.EnableHeadersVisualStyles = False
        Me.DgvFuncionarios.GridColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.DgvFuncionarios.Location = New System.Drawing.Point(83, 82)
        Me.DgvFuncionarios.MultiSelect = False
        Me.DgvFuncionarios.Name = "DgvFuncionarios"
        Me.DgvFuncionarios.ReadOnly = True
        Me.DgvFuncionarios.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(149, Byte), Integer), CType(CType(167, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(211, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgvFuncionarios.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(149, Byte), Integer), CType(CType(167, Byte), Integer))
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.DgvFuncionarios.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.DgvFuncionarios.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(149, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.DgvFuncionarios.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White
        Me.DgvFuncionarios.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.DgvFuncionarios.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DgvFuncionarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvFuncionarios.Size = New System.Drawing.Size(480, 362)
        Me.DgvFuncionarios.TabIndex = 32
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 16.0!)
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(172, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(212, 21)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(170, 30)
        Me.Label3.TabIndex = 31
        Me.Label3.Text = "FUNCIONARIOS"
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
        Me.BtnEliminar.Location = New System.Drawing.Point(432, 462)
        Me.BtnEliminar.Name = "BtnEliminar"
        Me.BtnEliminar.Size = New System.Drawing.Size(131, 28)
        Me.BtnEliminar.TabIndex = 30
        Me.BtnEliminar.Text = "ELIMINAR FUNCIONARIO"
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
        Me.BtnEditar.Location = New System.Drawing.Point(83, 462)
        Me.BtnEditar.Name = "BtnEditar"
        Me.BtnEditar.Size = New System.Drawing.Size(122, 28)
        Me.BtnEditar.TabIndex = 29
        Me.BtnEditar.Text = "EDITAR FUNCIONARIO"
        Me.BtnEditar.UseVisualStyleBackColor = False
        '
        'FrmFuncionarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1084, 610)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmFuncionarios"
        Me.Text = "FrmFuncionarios"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.DgvFuncionarios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents BtnGuardar As System.Windows.Forms.Button
    Friend WithEvents TxtTelefono_NUM_REQ As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents TxtDireccion_REQ As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TxtPass_REQ As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TxtID_NUM_REQ As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TxtNombre_LET_REQ As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents CboCargo_REQ As System.Windows.Forms.ComboBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents TxtUser_REQ As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents TxtApellido_LET_REQ As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents CboSucursales_REQ As System.Windows.Forms.ComboBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents BtnEliminar As System.Windows.Forms.Button
    Friend WithEvents BtnEditar As System.Windows.Forms.Button
    Friend WithEvents BtnCancelar As System.Windows.Forms.Button
    Friend WithEvents DgvFuncionarios As System.Windows.Forms.DataGridView
End Class
