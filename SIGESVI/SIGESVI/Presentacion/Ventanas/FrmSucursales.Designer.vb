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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmSucursales))
        Me.EpErrores = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Lbl_IdBusqueda = New System.Windows.Forms.Label
        Me.Lbl_Infosucursal = New System.Windows.Forms.GroupBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.CboDepartamentos = New System.Windows.Forms.ComboBox
        Me.Lbl_Departamento = New System.Windows.Forms.Label
        Me.Txt_ID = New System.Windows.Forms.TextBox
        Me.Txt_Nombre = New System.Windows.Forms.TextBox
        Me.Txt_Direccion = New System.Windows.Forms.TextBox
        Me.Txt_Telefono = New System.Windows.Forms.TextBox
        Me.LblTelefonos = New System.Windows.Forms.ListBox
        Me.Btn_Borrar = New System.Windows.Forms.Button
        Me.Lbl_Telefono = New System.Windows.Forms.Label
        Me.Btn_AgregarTel = New System.Windows.Forms.Button
        Me.LblMensaje = New System.Windows.Forms.Label
        Me.Lbl_Dirección = New System.Windows.Forms.Label
        Me.Lbl_Nombre = New System.Windows.Forms.Label
        Me.Lbl_ID = New System.Windows.Forms.Label
        Me.Txt_Busqueda = New System.Windows.Forms.TextBox
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.ID = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Nombre = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Departamento = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Direccion = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.User = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton
        Me.ToolStripButton3 = New System.Windows.Forms.ToolStripButton
        Me.ToolStripButton4 = New System.Windows.Forms.ToolStripButton
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        CType(Me.EpErrores, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Lbl_Infosucursal.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'EpErrores
        '
        Me.EpErrores.ContainerControl = Me
        '
        'Lbl_IdBusqueda
        '
        Me.Lbl_IdBusqueda.AutoSize = True
        Me.Lbl_IdBusqueda.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_IdBusqueda.Location = New System.Drawing.Point(409, 36)
        Me.Lbl_IdBusqueda.Name = "Lbl_IdBusqueda"
        Me.Lbl_IdBusqueda.Size = New System.Drawing.Size(23, 17)
        Me.Lbl_IdBusqueda.TabIndex = 17
        Me.Lbl_IdBusqueda.Text = "ID"
        '
        'Lbl_Infosucursal
        '
        Me.Lbl_Infosucursal.Controls.Add(Me.Button1)
        Me.Lbl_Infosucursal.Controls.Add(Me.TextBox1)
        Me.Lbl_Infosucursal.Controls.Add(Me.Label1)
        Me.Lbl_Infosucursal.Controls.Add(Me.CboDepartamentos)
        Me.Lbl_Infosucursal.Controls.Add(Me.Lbl_Departamento)
        Me.Lbl_Infosucursal.Controls.Add(Me.Txt_ID)
        Me.Lbl_Infosucursal.Controls.Add(Me.Txt_Nombre)
        Me.Lbl_Infosucursal.Controls.Add(Me.Txt_Direccion)
        Me.Lbl_Infosucursal.Controls.Add(Me.Txt_Telefono)
        Me.Lbl_Infosucursal.Controls.Add(Me.LblTelefonos)
        Me.Lbl_Infosucursal.Controls.Add(Me.Btn_Borrar)
        Me.Lbl_Infosucursal.Controls.Add(Me.Lbl_Telefono)
        Me.Lbl_Infosucursal.Controls.Add(Me.Btn_AgregarTel)
        Me.Lbl_Infosucursal.Controls.Add(Me.LblMensaje)
        Me.Lbl_Infosucursal.Controls.Add(Me.Lbl_Dirección)
        Me.Lbl_Infosucursal.Controls.Add(Me.Lbl_Nombre)
        Me.Lbl_Infosucursal.Controls.Add(Me.Lbl_ID)
        Me.Lbl_Infosucursal.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Infosucursal.Location = New System.Drawing.Point(36, 36)
        Me.Lbl_Infosucursal.Name = "Lbl_Infosucursal"
        Me.Lbl_Infosucursal.Size = New System.Drawing.Size(355, 334)
        Me.Lbl_Infosucursal.TabIndex = 13
        Me.Lbl_Infosucursal.TabStop = False
        Me.Lbl_Infosucursal.Text = "Información de Sucursal"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(259, 303)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(33, 23)
        Me.Button1.TabIndex = 17
        Me.Button1.Text = "..."
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(106, 303)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(147, 25)
        Me.TextBox1.TabIndex = 16
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(37, 303)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 17)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Gerente"
        '
        'CboDepartamentos
        '
        Me.CboDepartamentos.FormattingEnabled = True
        Me.CboDepartamentos.Items.AddRange(New Object() {"Canelones", "Montevideo"})
        Me.CboDepartamentos.Location = New System.Drawing.Point(106, 137)
        Me.CboDepartamentos.Name = "CboDepartamentos"
        Me.CboDepartamentos.Size = New System.Drawing.Size(196, 25)
        Me.CboDepartamentos.TabIndex = 14
        '
        'Lbl_Departamento
        '
        Me.Lbl_Departamento.AutoSize = True
        Me.Lbl_Departamento.Location = New System.Drawing.Point(2, 140)
        Me.Lbl_Departamento.Name = "Lbl_Departamento"
        Me.Lbl_Departamento.Size = New System.Drawing.Size(98, 17)
        Me.Lbl_Departamento.TabIndex = 13
        Me.Lbl_Departamento.Text = "Departamento"
        '
        'Txt_ID
        '
        Me.Txt_ID.Location = New System.Drawing.Point(106, 42)
        Me.Txt_ID.Name = "Txt_ID"
        Me.Txt_ID.Size = New System.Drawing.Size(196, 25)
        Me.Txt_ID.TabIndex = 7
        '
        'Txt_Nombre
        '
        Me.Txt_Nombre.Location = New System.Drawing.Point(106, 73)
        Me.Txt_Nombre.Name = "Txt_Nombre"
        Me.Txt_Nombre.Size = New System.Drawing.Size(196, 25)
        Me.Txt_Nombre.TabIndex = 8
        '
        'Txt_Direccion
        '
        Me.Txt_Direccion.Location = New System.Drawing.Point(106, 104)
        Me.Txt_Direccion.Name = "Txt_Direccion"
        Me.Txt_Direccion.Size = New System.Drawing.Size(196, 25)
        Me.Txt_Direccion.TabIndex = 10
        '
        'Txt_Telefono
        '
        Me.Txt_Telefono.Location = New System.Drawing.Point(106, 168)
        Me.Txt_Telefono.Name = "Txt_Telefono"
        Me.Txt_Telefono.Size = New System.Drawing.Size(196, 25)
        Me.Txt_Telefono.TabIndex = 11
        '
        'LblTelefonos
        '
        Me.LblTelefonos.FormattingEnabled = True
        Me.LblTelefonos.ItemHeight = 17
        Me.LblTelefonos.Location = New System.Drawing.Point(106, 199)
        Me.LblTelefonos.Name = "LblTelefonos"
        Me.LblTelefonos.Size = New System.Drawing.Size(196, 55)
        Me.LblTelefonos.TabIndex = 12
        '
        'Btn_Borrar
        '
        Me.Btn_Borrar.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Borrar.Location = New System.Drawing.Point(198, 260)
        Me.Btn_Borrar.Name = "Btn_Borrar"
        Me.Btn_Borrar.Size = New System.Drawing.Size(86, 25)
        Me.Btn_Borrar.TabIndex = 1
        Me.Btn_Borrar.Text = "Quitar Tel"
        Me.Btn_Borrar.UseVisualStyleBackColor = True
        '
        'Lbl_Telefono
        '
        Me.Lbl_Telefono.AutoSize = True
        Me.Lbl_Telefono.Location = New System.Drawing.Point(37, 171)
        Me.Lbl_Telefono.Name = "Lbl_Telefono"
        Me.Lbl_Telefono.Size = New System.Drawing.Size(63, 17)
        Me.Lbl_Telefono.TabIndex = 5
        Me.Lbl_Telefono.Text = "Teléfono"
        '
        'Btn_AgregarTel
        '
        Me.Btn_AgregarTel.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_AgregarTel.Location = New System.Drawing.Point(106, 260)
        Me.Btn_AgregarTel.Name = "Btn_AgregarTel"
        Me.Btn_AgregarTel.Size = New System.Drawing.Size(86, 26)
        Me.Btn_AgregarTel.TabIndex = 0
        Me.Btn_AgregarTel.Text = "Agregar Tel"
        Me.Btn_AgregarTel.UseVisualStyleBackColor = True
        '
        'LblMensaje
        '
        Me.LblMensaje.AutoSize = True
        Me.LblMensaje.Location = New System.Drawing.Point(120, 222)
        Me.LblMensaje.Name = "LblMensaje"
        Me.LblMensaje.Size = New System.Drawing.Size(0, 17)
        Me.LblMensaje.TabIndex = 3
        '
        'Lbl_Dirección
        '
        Me.Lbl_Dirección.AutoSize = True
        Me.Lbl_Dirección.Location = New System.Drawing.Point(31, 107)
        Me.Lbl_Dirección.Name = "Lbl_Dirección"
        Me.Lbl_Dirección.Size = New System.Drawing.Size(69, 17)
        Me.Lbl_Dirección.TabIndex = 4
        Me.Lbl_Dirección.Text = "Dirección"
        '
        'Lbl_Nombre
        '
        Me.Lbl_Nombre.AutoSize = True
        Me.Lbl_Nombre.Location = New System.Drawing.Point(41, 76)
        Me.Lbl_Nombre.Name = "Lbl_Nombre"
        Me.Lbl_Nombre.Size = New System.Drawing.Size(59, 17)
        Me.Lbl_Nombre.TabIndex = 2
        Me.Lbl_Nombre.Text = "Nombre"
        '
        'Lbl_ID
        '
        Me.Lbl_ID.AutoSize = True
        Me.Lbl_ID.Location = New System.Drawing.Point(77, 45)
        Me.Lbl_ID.Name = "Lbl_ID"
        Me.Lbl_ID.Size = New System.Drawing.Size(23, 17)
        Me.Lbl_ID.TabIndex = 1
        Me.Lbl_ID.Text = "ID"
        '
        'Txt_Busqueda
        '
        Me.Txt_Busqueda.Location = New System.Drawing.Point(412, 57)
        Me.Txt_Busqueda.Name = "Txt_Busqueda"
        Me.Txt_Busqueda.Size = New System.Drawing.Size(159, 20)
        Me.Txt_Busqueda.TabIndex = 16
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID, Me.Nombre, Me.Departamento, Me.Direccion, Me.User})
        Me.DataGridView1.Location = New System.Drawing.Point(412, 83)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(543, 258)
        Me.DataGridView1.TabIndex = 15
        '
        'ID
        '
        Me.ID.HeaderText = "ID"
        Me.ID.Name = "ID"
        Me.ID.ReadOnly = True
        '
        'Nombre
        '
        Me.Nombre.HeaderText = "Nombre"
        Me.Nombre.Name = "Nombre"
        Me.Nombre.ReadOnly = True
        '
        'Departamento
        '
        Me.Departamento.HeaderText = "Departamento"
        Me.Departamento.Name = "Departamento"
        Me.Departamento.ReadOnly = True
        '
        'Direccion
        '
        Me.Direccion.HeaderText = "Dirección"
        Me.Direccion.Name = "Direccion"
        Me.Direccion.ReadOnly = True
        '
        'User
        '
        Me.User.HeaderText = "Teléfono"
        Me.User.Name = "User"
        Me.User.ReadOnly = True
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton1, Me.ToolStripButton2, Me.ToolStripButton3, Me.ToolStripButton4})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1099, 25)
        Me.ToolStrip1.TabIndex = 19
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
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 484)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1099, 22)
        Me.StatusStrip1.TabIndex = 20
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(176, 17)
        Me.ToolStripStatusLabel1.Text = "Usuario agregado exitosamente."
        '
        'PictureBox1
        '
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(577, 52)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(25, 25)
        Me.PictureBox1.TabIndex = 18
        Me.PictureBox1.TabStop = False
        '
        'FrmSucursales
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(1099, 506)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.Lbl_IdBusqueda)
        Me.Controls.Add(Me.Lbl_Infosucursal)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Txt_Busqueda)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "FrmSucursales"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sucursales"
        CType(Me.EpErrores, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Lbl_Infosucursal.ResumeLayout(False)
        Me.Lbl_Infosucursal.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents EpErrores As System.Windows.Forms.ErrorProvider
    Friend WithEvents Lbl_IdBusqueda As System.Windows.Forms.Label
    Friend WithEvents Lbl_Infosucursal As System.Windows.Forms.GroupBox
    Friend WithEvents Btn_Borrar As System.Windows.Forms.Button
    Friend WithEvents Lbl_Telefono As System.Windows.Forms.Label
    Friend WithEvents Btn_AgregarTel As System.Windows.Forms.Button
    Friend WithEvents LblMensaje As System.Windows.Forms.Label
    Friend WithEvents Lbl_Dirección As System.Windows.Forms.Label
    Friend WithEvents Lbl_Nombre As System.Windows.Forms.Label
    Friend WithEvents Lbl_ID As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Txt_Busqueda As System.Windows.Forms.TextBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents ID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Nombre As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Departamento As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Direccion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents User As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Txt_ID As System.Windows.Forms.TextBox
    Friend WithEvents Txt_Nombre As System.Windows.Forms.TextBox
    Friend WithEvents Txt_Direccion As System.Windows.Forms.TextBox
    Friend WithEvents Txt_Telefono As System.Windows.Forms.TextBox
    Friend WithEvents LblTelefonos As System.Windows.Forms.ListBox
    Friend WithEvents CboDepartamentos As System.Windows.Forms.ComboBox
    Friend WithEvents Lbl_Departamento As System.Windows.Forms.Label
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton2 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton3 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton4 As System.Windows.Forms.ToolStripButton
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
End Class
