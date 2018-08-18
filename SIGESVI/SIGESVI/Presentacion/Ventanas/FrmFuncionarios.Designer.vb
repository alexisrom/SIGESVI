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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmFuncionarios))
        Me.Lbl_IDBusq = New System.Windows.Forms.Label
        Me.Txt_Busqueda = New System.Windows.Forms.TextBox
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.CI = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Nombre = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Apellido = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Telefono = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.User = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Pass = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker
        Me.Label6 = New System.Windows.Forms.Label
        Me.Cbo_cargo = New System.Windows.Forms.ComboBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Txt_pass = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Txt_user = New System.Windows.Forms.TextBox
        Me.Button2 = New System.Windows.Forms.Button
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.LblMensaje = New System.Windows.Forms.Label
        Me.lblDireccion = New System.Windows.Forms.Label
        Me.lbltelefono = New System.Windows.Forms.Label
        Me.lblApellido = New System.Windows.Forms.Label
        Me.Label_Nombre = New System.Windows.Forms.Label
        Me.Label_cedula = New System.Windows.Forms.Label
        Me.FlowLayoutPanel2 = New System.Windows.Forms.FlowLayoutPanel
        Me.Txt_Ci = New System.Windows.Forms.TextBox
        Me.Txt_Nombre = New System.Windows.Forms.TextBox
        Me.Txt_Apellido = New System.Windows.Forms.TextBox
        Me.Txt_Direccion = New System.Windows.Forms.TextBox
        Me.Txt_Telefono = New System.Windows.Forms.TextBox
        Me.LblTelefonos = New System.Windows.Forms.ListBox
        Me.Btn_AñadirTel = New System.Windows.Forms.Button
        Me.Btn_QuitarTel = New System.Windows.Forms.Button
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton
        Me.ToolStripButton3 = New System.Windows.Forms.ToolStripButton
        Me.ToolStripButton4 = New System.Windows.Forms.ToolStripButton
        Me.Label1 = New System.Windows.Forms.Label
        Me.errordedireccion = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.errordeapellido = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.errordenombre = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.errordecedula = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Errortelefono = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Txt_Idsucursal = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FlowLayoutPanel2.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.errordedireccion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.errordeapellido, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.errordenombre, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.errordecedula, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Errortelefono, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Lbl_IDBusq
        '
        Me.Lbl_IDBusq.AutoSize = True
        Me.Lbl_IDBusq.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_IDBusq.Location = New System.Drawing.Point(664, 23)
        Me.Lbl_IDBusq.Name = "Lbl_IDBusq"
        Me.Lbl_IDBusq.Size = New System.Drawing.Size(50, 17)
        Me.Lbl_IDBusq.TabIndex = 25
        Me.Lbl_IDBusq.Text = "Cédula"
        '
        'Txt_Busqueda
        '
        Me.Txt_Busqueda.Location = New System.Drawing.Point(667, 43)
        Me.Txt_Busqueda.Name = "Txt_Busqueda"
        Me.Txt_Busqueda.Size = New System.Drawing.Size(159, 20)
        Me.Txt_Busqueda.TabIndex = 24
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CI, Me.Nombre, Me.Apellido, Me.Telefono, Me.User, Me.Pass})
        Me.DataGridView1.Location = New System.Drawing.Point(667, 69)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(644, 284)
        Me.DataGridView1.TabIndex = 23
        '
        'CI
        '
        Me.CI.HeaderText = "Cédula"
        Me.CI.Name = "CI"
        Me.CI.ReadOnly = True
        '
        'Nombre
        '
        Me.Nombre.HeaderText = "Nombre"
        Me.Nombre.Name = "Nombre"
        Me.Nombre.ReadOnly = True
        '
        'Apellido
        '
        Me.Apellido.HeaderText = "Apellido"
        Me.Apellido.Name = "Apellido"
        Me.Apellido.ReadOnly = True
        '
        'Telefono
        '
        Me.Telefono.HeaderText = "Teléfono"
        Me.Telefono.Name = "Telefono"
        Me.Telefono.ReadOnly = True
        '
        'User
        '
        Me.User.HeaderText = "Usuario"
        Me.User.Name = "User"
        Me.User.ReadOnly = True
        '
        'Pass
        '
        Me.Pass.HeaderText = "Contraseña"
        Me.Pass.Name = "Pass"
        Me.Pass.ReadOnly = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.DateTimePicker1)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Cbo_cargo)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Txt_pass)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Txt_user)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.PictureBox2)
        Me.GroupBox1.Controls.Add(Me.LblMensaje)
        Me.GroupBox1.Controls.Add(Me.lblDireccion)
        Me.GroupBox1.Controls.Add(Me.lbltelefono)
        Me.GroupBox1.Controls.Add(Me.lblApellido)
        Me.GroupBox1.Controls.Add(Me.Label_Nombre)
        Me.GroupBox1.Controls.Add(Me.Label_cedula)
        Me.GroupBox1.Controls.Add(Me.FlowLayoutPanel2)
        Me.GroupBox1.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(52, 37)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(579, 339)
        Me.GroupBox1.TabIndex = 22
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Información Personal"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(350, 305)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(178, 25)
        Me.DateTimePicker1.TabIndex = 60
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(347, 288)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(137, 17)
        Me.Label6.TabIndex = 59
        Me.Label6.Text = "Fecha de Nacimiento"
        '
        'Cbo_cargo
        '
        Me.Cbo_cargo.FormattingEnabled = True
        Me.Cbo_cargo.Items.AddRange(New Object() {"Administrativo", "Gerente Sucursal", "Asesor Profesional"})
        Me.Cbo_cargo.Location = New System.Drawing.Point(356, 260)
        Me.Cbo_cargo.Name = "Cbo_cargo"
        Me.Cbo_cargo.Size = New System.Drawing.Size(175, 25)
        Me.Cbo_cargo.TabIndex = 58
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(353, 246)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(44, 17)
        Me.Label4.TabIndex = 57
        Me.Label4.Text = "Cargo"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(350, 200)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(78, 17)
        Me.Label3.TabIndex = 56
        Me.Label3.Text = "Contraseña"
        '
        'Txt_pass
        '
        Me.Txt_pass.Location = New System.Drawing.Point(350, 214)
        Me.Txt_pass.Name = "Txt_pass"
        Me.Txt_pass.Size = New System.Drawing.Size(181, 25)
        Me.Txt_pass.TabIndex = 55
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(350, 149)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(127, 17)
        Me.Label2.TabIndex = 54
        Me.Label2.Text = "Nombre de usuario"
        '
        'Txt_user
        '
        Me.Txt_user.Location = New System.Drawing.Point(350, 163)
        Me.Txt_user.Name = "Txt_user"
        Me.Txt_user.Size = New System.Drawing.Size(181, 25)
        Me.Txt_user.TabIndex = 53
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(384, 115)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(112, 23)
        Me.Button2.TabIndex = 52
        Me.Button2.Text = "Cambiar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'PictureBox2
        '
        Me.PictureBox2.Location = New System.Drawing.Point(384, 24)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(112, 85)
        Me.PictureBox2.TabIndex = 51
        Me.PictureBox2.TabStop = False
        '
        'LblMensaje
        '
        Me.LblMensaje.AutoSize = True
        Me.LblMensaje.Location = New System.Drawing.Point(120, 222)
        Me.LblMensaje.Name = "LblMensaje"
        Me.LblMensaje.Size = New System.Drawing.Size(0, 17)
        Me.LblMensaje.TabIndex = 3
        '
        'lblDireccion
        '
        Me.lblDireccion.AutoSize = True
        Me.lblDireccion.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDireccion.Location = New System.Drawing.Point(37, 140)
        Me.lblDireccion.Name = "lblDireccion"
        Me.lblDireccion.Size = New System.Drawing.Size(69, 17)
        Me.lblDireccion.TabIndex = 5
        Me.lblDireccion.Text = "Dirección"
        '
        'lbltelefono
        '
        Me.lbltelefono.AutoSize = True
        Me.lbltelefono.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltelefono.Location = New System.Drawing.Point(37, 171)
        Me.lbltelefono.Name = "lbltelefono"
        Me.lbltelefono.Size = New System.Drawing.Size(63, 17)
        Me.lbltelefono.TabIndex = 4
        Me.lbltelefono.Text = "Teléfono"
        '
        'lblApellido
        '
        Me.lblApellido.AutoSize = True
        Me.lblApellido.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblApellido.Location = New System.Drawing.Point(44, 109)
        Me.lblApellido.Name = "lblApellido"
        Me.lblApellido.Size = New System.Drawing.Size(60, 17)
        Me.lblApellido.TabIndex = 3
        Me.lblApellido.Text = "Apellido"
        '
        'Label_Nombre
        '
        Me.Label_Nombre.AutoSize = True
        Me.Label_Nombre.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Nombre.Location = New System.Drawing.Point(45, 78)
        Me.Label_Nombre.Name = "Label_Nombre"
        Me.Label_Nombre.Size = New System.Drawing.Size(59, 17)
        Me.Label_Nombre.TabIndex = 2
        Me.Label_Nombre.Text = "Nombre"
        '
        'Label_cedula
        '
        Me.Label_cedula.AutoSize = True
        Me.Label_cedula.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_cedula.Location = New System.Drawing.Point(50, 47)
        Me.Label_cedula.Name = "Label_cedula"
        Me.Label_cedula.Size = New System.Drawing.Size(50, 17)
        Me.Label_cedula.TabIndex = 1
        Me.Label_cedula.Text = "Cédula"
        '
        'FlowLayoutPanel2
        '
        Me.FlowLayoutPanel2.Controls.Add(Me.Txt_Ci)
        Me.FlowLayoutPanel2.Controls.Add(Me.Txt_Nombre)
        Me.FlowLayoutPanel2.Controls.Add(Me.Txt_Apellido)
        Me.FlowLayoutPanel2.Controls.Add(Me.Txt_Direccion)
        Me.FlowLayoutPanel2.Controls.Add(Me.Txt_Telefono)
        Me.FlowLayoutPanel2.Controls.Add(Me.LblTelefonos)
        Me.FlowLayoutPanel2.Controls.Add(Me.Btn_AñadirTel)
        Me.FlowLayoutPanel2.Controls.Add(Me.Btn_QuitarTel)
        Me.FlowLayoutPanel2.Location = New System.Drawing.Point(106, 41)
        Me.FlowLayoutPanel2.Name = "FlowLayoutPanel2"
        Me.FlowLayoutPanel2.Size = New System.Drawing.Size(218, 258)
        Me.FlowLayoutPanel2.TabIndex = 0
        '
        'Txt_Ci
        '
        Me.Txt_Ci.Location = New System.Drawing.Point(3, 3)
        Me.Txt_Ci.Name = "Txt_Ci"
        Me.Txt_Ci.Size = New System.Drawing.Size(173, 25)
        Me.Txt_Ci.TabIndex = 1
        '
        'Txt_Nombre
        '
        Me.Txt_Nombre.Location = New System.Drawing.Point(3, 34)
        Me.Txt_Nombre.Name = "Txt_Nombre"
        Me.Txt_Nombre.Size = New System.Drawing.Size(173, 25)
        Me.Txt_Nombre.TabIndex = 2
        '
        'Txt_Apellido
        '
        Me.Txt_Apellido.Location = New System.Drawing.Point(3, 65)
        Me.Txt_Apellido.Name = "Txt_Apellido"
        Me.Txt_Apellido.Size = New System.Drawing.Size(173, 25)
        Me.Txt_Apellido.TabIndex = 3
        '
        'Txt_Direccion
        '
        Me.Txt_Direccion.Location = New System.Drawing.Point(3, 96)
        Me.Txt_Direccion.Name = "Txt_Direccion"
        Me.Txt_Direccion.Size = New System.Drawing.Size(173, 25)
        Me.Txt_Direccion.TabIndex = 5
        '
        'Txt_Telefono
        '
        Me.Txt_Telefono.Location = New System.Drawing.Point(3, 127)
        Me.Txt_Telefono.Name = "Txt_Telefono"
        Me.Txt_Telefono.Size = New System.Drawing.Size(173, 25)
        Me.Txt_Telefono.TabIndex = 4
        '
        'LblTelefonos
        '
        Me.LblTelefonos.FormattingEnabled = True
        Me.LblTelefonos.ItemHeight = 17
        Me.LblTelefonos.Location = New System.Drawing.Point(3, 158)
        Me.LblTelefonos.Name = "LblTelefonos"
        Me.LblTelefonos.Size = New System.Drawing.Size(173, 55)
        Me.LblTelefonos.TabIndex = 6
        '
        'Btn_AñadirTel
        '
        Me.Btn_AñadirTel.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_AñadirTel.Location = New System.Drawing.Point(3, 219)
        Me.Btn_AñadirTel.Name = "Btn_AñadirTel"
        Me.Btn_AñadirTel.Size = New System.Drawing.Size(75, 23)
        Me.Btn_AñadirTel.TabIndex = 8
        Me.Btn_AñadirTel.Text = "Añadir Tel"
        Me.Btn_AñadirTel.UseVisualStyleBackColor = True
        '
        'Btn_QuitarTel
        '
        Me.Btn_QuitarTel.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_QuitarTel.Location = New System.Drawing.Point(84, 219)
        Me.Btn_QuitarTel.Name = "Btn_QuitarTel"
        Me.Btn_QuitarTel.Size = New System.Drawing.Size(75, 23)
        Me.Btn_QuitarTel.TabIndex = 7
        Me.Btn_QuitarTel.Text = "Quitar Tel"
        Me.Btn_QuitarTel.UseVisualStyleBackColor = True
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton1, Me.ToolStripButton2, Me.ToolStripButton3, Me.ToolStripButton4})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1358, 25)
        Me.ToolStrip1.TabIndex = 27
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton1.Text = "Agregar"
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton2.Image = CType(resources.GetObject("ToolStripButton2.Image"), System.Drawing.Image)
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton2.Text = "Guardar"
        '
        'ToolStripButton3
        '
        Me.ToolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton3.Image = CType(resources.GetObject("ToolStripButton3.Image"), System.Drawing.Image)
        Me.ToolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton3.Name = "ToolStripButton3"
        Me.ToolStripButton3.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton3.Text = "Eliminar"
        '
        'ToolStripButton4
        '
        Me.ToolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton4.Image = CType(resources.GetObject("ToolStripButton4.Image"), System.Drawing.Image)
        Me.ToolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton4.Name = "ToolStripButton4"
        Me.ToolStripButton4.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton4.Text = "Limpiar"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(105, 379)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(270, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Sueldo Neto, Sueldo Liquido, Descuenctos, Sucursal??"
        '
        'errordedireccion
        '
        Me.errordedireccion.ContainerControl = Me
        '
        'errordeapellido
        '
        Me.errordeapellido.ContainerControl = Me
        '
        'errordenombre
        '
        Me.errordenombre.ContainerControl = Me
        '
        'errordecedula
        '
        Me.errordecedula.ContainerControl = Me
        '
        'Errortelefono
        '
        Me.Errortelefono.ContainerControl = Me
        '
        'PictureBox1
        '
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(832, 38)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(25, 25)
        Me.PictureBox1.TabIndex = 26
        Me.PictureBox1.TabStop = False
        '
        'Txt_Idsucursal
        '
        Me.Txt_Idsucursal.Location = New System.Drawing.Point(333, 411)
        Me.Txt_Idsucursal.Name = "Txt_Idsucursal"
        Me.Txt_Idsucursal.Size = New System.Drawing.Size(173, 20)
        Me.Txt_Idsucursal.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(254, 411)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(79, 17)
        Me.Label5.TabIndex = 61
        Me.Label5.Text = "ID Sucursal"
        '
        'FrmFuncionarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(1358, 459)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.Lbl_IDBusq)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Txt_Busqueda)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Txt_Idsucursal)
        Me.Location = New System.Drawing.Point(42, 30)
        Me.Name = "FrmFuncionarios"
        Me.Text = "Funcionarios"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FlowLayoutPanel2.ResumeLayout(False)
        Me.FlowLayoutPanel2.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.errordedireccion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.errordeapellido, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.errordenombre, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.errordecedula, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Errortelefono, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Lbl_IDBusq As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Txt_Busqueda As System.Windows.Forms.TextBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents CI As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Nombre As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Apellido As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Telefono As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents User As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Pass As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents LblMensaje As System.Windows.Forms.Label
    Friend WithEvents lblDireccion As System.Windows.Forms.Label
    Friend WithEvents lbltelefono As System.Windows.Forms.Label
    Friend WithEvents lblApellido As System.Windows.Forms.Label
    Friend WithEvents Label_Nombre As System.Windows.Forms.Label
    Friend WithEvents Label_cedula As System.Windows.Forms.Label
    Friend WithEvents FlowLayoutPanel2 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents Txt_Ci As System.Windows.Forms.TextBox
    Friend WithEvents Txt_Nombre As System.Windows.Forms.TextBox
    Friend WithEvents Txt_Apellido As System.Windows.Forms.TextBox
    Friend WithEvents Txt_Direccion As System.Windows.Forms.TextBox
    Friend WithEvents Txt_Telefono As System.Windows.Forms.TextBox
    Friend WithEvents LblTelefonos As System.Windows.Forms.ListBox
    Friend WithEvents Btn_AñadirTel As System.Windows.Forms.Button
    Friend WithEvents Btn_QuitarTel As System.Windows.Forms.Button
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton2 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton3 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton4 As System.Windows.Forms.ToolStripButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents errordedireccion As System.Windows.Forms.ErrorProvider
    Friend WithEvents errordeapellido As System.Windows.Forms.ErrorProvider
    Friend WithEvents errordenombre As System.Windows.Forms.ErrorProvider
    Friend WithEvents errordecedula As System.Windows.Forms.ErrorProvider
    Friend WithEvents Errortelefono As System.Windows.Forms.ErrorProvider
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Cbo_cargo As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Txt_pass As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Txt_user As System.Windows.Forms.TextBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Txt_Idsucursal As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
End Class
