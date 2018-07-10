<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCliente
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmCliente))
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
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
        Me.Btn_AgregarTel = New System.Windows.Forms.Button
        Me.Btn_Quitar = New System.Windows.Forms.Button
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel
        Me.Btn_Agregar = New System.Windows.Forms.Button
        Me.Btn_Modificar = New System.Windows.Forms.Button
        Me.Btn_Eliminar = New System.Windows.Forms.Button
        Me.Btn_Limpiar = New System.Windows.Forms.Button
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.Label7 = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.CI = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Nombre = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Apellido = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Telefono = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.User = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Pass = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Txt_Cedula = New System.Windows.Forms.TextBox
        Me.EpErrores = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.FlowLayoutPanel2.SuspendLayout()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EpErrores, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Controls.Add(Me.FlowLayoutPanel1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(440, 386)
        Me.Panel1.TabIndex = 10
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.LblMensaje)
        Me.GroupBox1.Controls.Add(Me.lblDireccion)
        Me.GroupBox1.Controls.Add(Me.lbltelefono)
        Me.GroupBox1.Controls.Add(Me.lblApellido)
        Me.GroupBox1.Controls.Add(Me.Label_Nombre)
        Me.GroupBox1.Controls.Add(Me.Label_cedula)
        Me.GroupBox1.Controls.Add(Me.FlowLayoutPanel2)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(332, 305)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Información Personal"
        '
        'LblMensaje
        '
        Me.LblMensaje.AutoSize = True
        Me.LblMensaje.Location = New System.Drawing.Point(120, 222)
        Me.LblMensaje.Name = "LblMensaje"
        Me.LblMensaje.Size = New System.Drawing.Size(0, 13)
        Me.LblMensaje.TabIndex = 3
        '
        'lblDireccion
        '
        Me.lblDireccion.AutoSize = True
        Me.lblDireccion.Location = New System.Drawing.Point(47, 129)
        Me.lblDireccion.Name = "lblDireccion"
        Me.lblDireccion.Size = New System.Drawing.Size(52, 13)
        Me.lblDireccion.TabIndex = 5
        Me.lblDireccion.Text = "Direccion"
        '
        'lbltelefono
        '
        Me.lbltelefono.AutoSize = True
        Me.lbltelefono.Location = New System.Drawing.Point(47, 155)
        Me.lbltelefono.Name = "lbltelefono"
        Me.lbltelefono.Size = New System.Drawing.Size(49, 13)
        Me.lbltelefono.TabIndex = 4
        Me.lbltelefono.Text = "Teléfono"
        '
        'lblApellido
        '
        Me.lblApellido.AutoSize = True
        Me.lblApellido.Location = New System.Drawing.Point(47, 103)
        Me.lblApellido.Name = "lblApellido"
        Me.lblApellido.Size = New System.Drawing.Size(44, 13)
        Me.lblApellido.TabIndex = 3
        Me.lblApellido.Text = "Apellido"
        '
        'Label_Nombre
        '
        Me.Label_Nombre.AutoSize = True
        Me.Label_Nombre.Location = New System.Drawing.Point(47, 73)
        Me.Label_Nombre.Name = "Label_Nombre"
        Me.Label_Nombre.Size = New System.Drawing.Size(44, 13)
        Me.Label_Nombre.TabIndex = 2
        Me.Label_Nombre.Text = "Nombre"
        '
        'Label_cedula
        '
        Me.Label_cedula.AutoSize = True
        Me.Label_cedula.Location = New System.Drawing.Point(51, 44)
        Me.Label_cedula.Name = "Label_cedula"
        Me.Label_cedula.Size = New System.Drawing.Size(40, 13)
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
        Me.FlowLayoutPanel2.Controls.Add(Me.Btn_AgregarTel)
        Me.FlowLayoutPanel2.Controls.Add(Me.Btn_Quitar)
        Me.FlowLayoutPanel2.Location = New System.Drawing.Point(106, 41)
        Me.FlowLayoutPanel2.Name = "FlowLayoutPanel2"
        Me.FlowLayoutPanel2.Size = New System.Drawing.Size(180, 222)
        Me.FlowLayoutPanel2.TabIndex = 0
        '
        'Txt_Ci
        '
        Me.Txt_Ci.Location = New System.Drawing.Point(3, 3)
        Me.Txt_Ci.Name = "Txt_Ci"
        Me.Txt_Ci.Size = New System.Drawing.Size(173, 20)
        Me.Txt_Ci.TabIndex = 1
        '
        'Txt_Nombre
        '
        Me.Txt_Nombre.Location = New System.Drawing.Point(3, 29)
        Me.Txt_Nombre.Name = "Txt_Nombre"
        Me.Txt_Nombre.Size = New System.Drawing.Size(173, 20)
        Me.Txt_Nombre.TabIndex = 2
        '
        'Txt_Apellido
        '
        Me.Txt_Apellido.Location = New System.Drawing.Point(3, 55)
        Me.Txt_Apellido.Name = "Txt_Apellido"
        Me.Txt_Apellido.Size = New System.Drawing.Size(173, 20)
        Me.Txt_Apellido.TabIndex = 3
        '
        'Txt_Direccion
        '
        Me.Txt_Direccion.Location = New System.Drawing.Point(3, 81)
        Me.Txt_Direccion.Name = "Txt_Direccion"
        Me.Txt_Direccion.Size = New System.Drawing.Size(173, 20)
        Me.Txt_Direccion.TabIndex = 5
        '
        'Txt_Telefono
        '
        Me.Txt_Telefono.Location = New System.Drawing.Point(3, 107)
        Me.Txt_Telefono.Name = "Txt_Telefono"
        Me.Txt_Telefono.Size = New System.Drawing.Size(173, 20)
        Me.Txt_Telefono.TabIndex = 4
        '
        'LblTelefonos
        '
        Me.LblTelefonos.FormattingEnabled = True
        Me.LblTelefonos.Location = New System.Drawing.Point(3, 133)
        Me.LblTelefonos.Name = "LblTelefonos"
        Me.LblTelefonos.Size = New System.Drawing.Size(173, 56)
        Me.LblTelefonos.TabIndex = 6
        '
        'Btn_AgregarTel
        '
        Me.Btn_AgregarTel.Location = New System.Drawing.Point(3, 195)
        Me.Btn_AgregarTel.Name = "Btn_AgregarTel"
        Me.Btn_AgregarTel.Size = New System.Drawing.Size(75, 23)
        Me.Btn_AgregarTel.TabIndex = 8
        Me.Btn_AgregarTel.Text = "Agregar"
        Me.Btn_AgregarTel.UseVisualStyleBackColor = True
        '
        'Btn_Quitar
        '
        Me.Btn_Quitar.Location = New System.Drawing.Point(84, 195)
        Me.Btn_Quitar.Name = "Btn_Quitar"
        Me.Btn_Quitar.Size = New System.Drawing.Size(75, 23)
        Me.Btn_Quitar.TabIndex = 7
        Me.Btn_Quitar.Text = "Quitar"
        Me.Btn_Quitar.UseVisualStyleBackColor = True
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Controls.Add(Me.Btn_Agregar)
        Me.FlowLayoutPanel1.Controls.Add(Me.Btn_Modificar)
        Me.FlowLayoutPanel1.Controls.Add(Me.Btn_Eliminar)
        Me.FlowLayoutPanel1.Controls.Add(Me.Btn_Limpiar)
        Me.FlowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(350, 30)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(84, 229)
        Me.FlowLayoutPanel1.TabIndex = 2
        '
        'Btn_Agregar
        '
        Me.Btn_Agregar.Location = New System.Drawing.Point(3, 3)
        Me.Btn_Agregar.Name = "Btn_Agregar"
        Me.Btn_Agregar.Size = New System.Drawing.Size(75, 23)
        Me.Btn_Agregar.TabIndex = 0
        Me.Btn_Agregar.Text = "Agregar"
        Me.Btn_Agregar.UseVisualStyleBackColor = True
        '
        'Btn_Modificar
        '
        Me.Btn_Modificar.Location = New System.Drawing.Point(3, 32)
        Me.Btn_Modificar.Name = "Btn_Modificar"
        Me.Btn_Modificar.Size = New System.Drawing.Size(75, 23)
        Me.Btn_Modificar.TabIndex = 1
        Me.Btn_Modificar.Text = "Modificar"
        Me.Btn_Modificar.UseVisualStyleBackColor = True
        '
        'Btn_Eliminar
        '
        Me.Btn_Eliminar.Location = New System.Drawing.Point(3, 61)
        Me.Btn_Eliminar.Name = "Btn_Eliminar"
        Me.Btn_Eliminar.Size = New System.Drawing.Size(75, 23)
        Me.Btn_Eliminar.TabIndex = 2
        Me.Btn_Eliminar.Text = "Eliminar"
        Me.Btn_Eliminar.UseVisualStyleBackColor = True
        '
        'Btn_Limpiar
        '
        Me.Btn_Limpiar.Location = New System.Drawing.Point(3, 90)
        Me.Btn_Limpiar.Name = "Btn_Limpiar"
        Me.Btn_Limpiar.Size = New System.Drawing.Size(75, 23)
        Me.Btn_Limpiar.TabIndex = 3
        Me.Btn_Limpiar.Text = "Limpiar"
        Me.Btn_Limpiar.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Controls.Add(Me.DataGridView1)
        Me.Panel2.Controls.Add(Me.Txt_Cedula)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel2.Location = New System.Drawing.Point(446, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(752, 386)
        Me.Panel2.TabIndex = 11
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(34, 40)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(40, 13)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "Cédula"
        '
        'PictureBox1
        '
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(202, 50)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(25, 25)
        Me.PictureBox1.TabIndex = 12
        Me.PictureBox1.TabStop = False
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CI, Me.Nombre, Me.Apellido, Me.Telefono, Me.User, Me.Pass})
        Me.DataGridView1.Location = New System.Drawing.Point(37, 106)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(644, 150)
        Me.DataGridView1.TabIndex = 9
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
        'Txt_Cedula
        '
        Me.Txt_Cedula.Location = New System.Drawing.Point(37, 55)
        Me.Txt_Cedula.Name = "Txt_Cedula"
        Me.Txt_Cedula.Size = New System.Drawing.Size(159, 20)
        Me.Txt_Cedula.TabIndex = 10
        '
        'EpErrores
        '
        Me.EpErrores.ContainerControl = Me
        '
        'FrmCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1198, 386)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "FrmCliente"
        Me.Text = "Cliente"
        Me.Panel1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.FlowLayoutPanel2.ResumeLayout(False)
        Me.FlowLayoutPanel2.PerformLayout()
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EpErrores, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
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
    Friend WithEvents Txt_Telefono As System.Windows.Forms.TextBox
    Friend WithEvents Txt_Direccion As System.Windows.Forms.TextBox
    Friend WithEvents FlowLayoutPanel1 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents Btn_Agregar As System.Windows.Forms.Button
    Friend WithEvents Btn_Modificar As System.Windows.Forms.Button
    Friend WithEvents Btn_Eliminar As System.Windows.Forms.Button
    Friend WithEvents Btn_Limpiar As System.Windows.Forms.Button
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents CI As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Nombre As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Apellido As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Telefono As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents User As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Pass As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Txt_Cedula As System.Windows.Forms.TextBox
    Friend WithEvents EpErrores As System.Windows.Forms.ErrorProvider
    Friend WithEvents LblTelefonos As System.Windows.Forms.ListBox
    Friend WithEvents Btn_AgregarTel As System.Windows.Forms.Button
    Friend WithEvents Btn_Quitar As System.Windows.Forms.Button
End Class
