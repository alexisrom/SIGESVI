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
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Lbl_Infosucursal = New System.Windows.Forms.GroupBox
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.Btn_Borrar = New System.Windows.Forms.Button
        Me.Btn_AgregarTel = New System.Windows.Forms.Button
        Me.Lbl_Telefono = New System.Windows.Forms.Label
        Me.LblMensaje = New System.Windows.Forms.Label
        Me.Lbl_Dirección = New System.Windows.Forms.Label
        Me.Lbl_Departamento = New System.Windows.Forms.Label
        Me.Lbl_Nombre = New System.Windows.Forms.Label
        Me.Lbl_ID = New System.Windows.Forms.Label
        Me.FlowLayoutPanel2 = New System.Windows.Forms.FlowLayoutPanel
        Me.Txt_ID = New System.Windows.Forms.TextBox
        Me.Txt_Nombre = New System.Windows.Forms.TextBox
        Me.Txt_Depart = New System.Windows.Forms.TextBox
        Me.Txt_Direccion = New System.Windows.Forms.TextBox
        Me.Txt_Telefono = New System.Windows.Forms.TextBox
        Me.LblTelefonos = New System.Windows.Forms.ListBox
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel
        Me.BtnAgregar = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.Button3 = New System.Windows.Forms.Button
        Me.Button4 = New System.Windows.Forms.Button
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.Lbl_IDBusq = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.ID = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Nombre = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Departamento = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Direccion = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.User = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Txt_Busqueda = New System.Windows.Forms.TextBox
        Me.EpErrores = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Panel1.SuspendLayout()
        Me.Lbl_Infosucursal.SuspendLayout()
        Me.Panel3.SuspendLayout()
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
        Me.Panel1.Controls.Add(Me.Lbl_Infosucursal)
        Me.Panel1.Controls.Add(Me.FlowLayoutPanel1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(440, 386)
        Me.Panel1.TabIndex = 10
        '
        'Lbl_Infosucursal
        '
        Me.Lbl_Infosucursal.Controls.Add(Me.Panel3)
        Me.Lbl_Infosucursal.Controls.Add(Me.Lbl_Telefono)
        Me.Lbl_Infosucursal.Controls.Add(Me.LblMensaje)
        Me.Lbl_Infosucursal.Controls.Add(Me.Lbl_Dirección)
        Me.Lbl_Infosucursal.Controls.Add(Me.Lbl_Departamento)
        Me.Lbl_Infosucursal.Controls.Add(Me.Lbl_Nombre)
        Me.Lbl_Infosucursal.Controls.Add(Me.Lbl_ID)
        Me.Lbl_Infosucursal.Controls.Add(Me.FlowLayoutPanel2)
        Me.Lbl_Infosucursal.Location = New System.Drawing.Point(12, 21)
        Me.Lbl_Infosucursal.Name = "Lbl_Infosucursal"
        Me.Lbl_Infosucursal.Size = New System.Drawing.Size(332, 305)
        Me.Lbl_Infosucursal.TabIndex = 0
        Me.Lbl_Infosucursal.TabStop = False
        Me.Lbl_Infosucursal.Text = "Información de Sucursal"
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.Btn_Borrar)
        Me.Panel3.Controls.Add(Me.Btn_AgregarTel)
        Me.Panel3.Location = New System.Drawing.Point(106, 244)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(202, 28)
        Me.Panel3.TabIndex = 6
        '
        'Btn_Borrar
        '
        Me.Btn_Borrar.Location = New System.Drawing.Point(121, 2)
        Me.Btn_Borrar.Name = "Btn_Borrar"
        Me.Btn_Borrar.Size = New System.Drawing.Size(78, 23)
        Me.Btn_Borrar.TabIndex = 1
        Me.Btn_Borrar.Text = "Borrar"
        Me.Btn_Borrar.UseVisualStyleBackColor = True
        '
        'Btn_AgregarTel
        '
        Me.Btn_AgregarTel.Location = New System.Drawing.Point(3, 2)
        Me.Btn_AgregarTel.Name = "Btn_AgregarTel"
        Me.Btn_AgregarTel.Size = New System.Drawing.Size(75, 23)
        Me.Btn_AgregarTel.TabIndex = 0
        Me.Btn_AgregarTel.Text = "Agregar "
        Me.Btn_AgregarTel.UseVisualStyleBackColor = True
        '
        'Lbl_Telefono
        '
        Me.Lbl_Telefono.AutoSize = True
        Me.Lbl_Telefono.Location = New System.Drawing.Point(22, 151)
        Me.Lbl_Telefono.Name = "Lbl_Telefono"
        Me.Lbl_Telefono.Size = New System.Drawing.Size(49, 13)
        Me.Lbl_Telefono.TabIndex = 5
        Me.Lbl_Telefono.Text = "Teléfono"
        '
        'LblMensaje
        '
        Me.LblMensaje.AutoSize = True
        Me.LblMensaje.Location = New System.Drawing.Point(120, 222)
        Me.LblMensaje.Name = "LblMensaje"
        Me.LblMensaje.Size = New System.Drawing.Size(0, 13)
        Me.LblMensaje.TabIndex = 3
        '
        'Lbl_Dirección
        '
        Me.Lbl_Dirección.AutoSize = True
        Me.Lbl_Dirección.Location = New System.Drawing.Point(22, 125)
        Me.Lbl_Dirección.Name = "Lbl_Dirección"
        Me.Lbl_Dirección.Size = New System.Drawing.Size(52, 13)
        Me.Lbl_Dirección.TabIndex = 4
        Me.Lbl_Dirección.Text = "Dirección"
        '
        'Lbl_Departamento
        '
        Me.Lbl_Departamento.AutoSize = True
        Me.Lbl_Departamento.Location = New System.Drawing.Point(22, 99)
        Me.Lbl_Departamento.Name = "Lbl_Departamento"
        Me.Lbl_Departamento.Size = New System.Drawing.Size(74, 13)
        Me.Lbl_Departamento.TabIndex = 3
        Me.Lbl_Departamento.Text = "Departamento"
        '
        'Lbl_Nombre
        '
        Me.Lbl_Nombre.AutoSize = True
        Me.Lbl_Nombre.Location = New System.Drawing.Point(22, 73)
        Me.Lbl_Nombre.Name = "Lbl_Nombre"
        Me.Lbl_Nombre.Size = New System.Drawing.Size(44, 13)
        Me.Lbl_Nombre.TabIndex = 2
        Me.Lbl_Nombre.Text = "Nombre"
        '
        'Lbl_ID
        '
        Me.Lbl_ID.AutoSize = True
        Me.Lbl_ID.Location = New System.Drawing.Point(22, 47)
        Me.Lbl_ID.Name = "Lbl_ID"
        Me.Lbl_ID.Size = New System.Drawing.Size(18, 13)
        Me.Lbl_ID.TabIndex = 1
        Me.Lbl_ID.Text = "ID"
        '
        'FlowLayoutPanel2
        '
        Me.FlowLayoutPanel2.Controls.Add(Me.Txt_ID)
        Me.FlowLayoutPanel2.Controls.Add(Me.Txt_Nombre)
        Me.FlowLayoutPanel2.Controls.Add(Me.Txt_Depart)
        Me.FlowLayoutPanel2.Controls.Add(Me.Txt_Direccion)
        Me.FlowLayoutPanel2.Controls.Add(Me.Txt_Telefono)
        Me.FlowLayoutPanel2.Controls.Add(Me.LblTelefonos)
        Me.FlowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.FlowLayoutPanel2.Location = New System.Drawing.Point(106, 41)
        Me.FlowLayoutPanel2.Name = "FlowLayoutPanel2"
        Me.FlowLayoutPanel2.Size = New System.Drawing.Size(220, 194)
        Me.FlowLayoutPanel2.TabIndex = 0
        '
        'Txt_ID
        '
        Me.Txt_ID.Location = New System.Drawing.Point(3, 3)
        Me.Txt_ID.Name = "Txt_ID"
        Me.Txt_ID.Size = New System.Drawing.Size(196, 20)
        Me.Txt_ID.TabIndex = 1
        '
        'Txt_Nombre
        '
        Me.Txt_Nombre.Location = New System.Drawing.Point(3, 29)
        Me.Txt_Nombre.Name = "Txt_Nombre"
        Me.Txt_Nombre.Size = New System.Drawing.Size(196, 20)
        Me.Txt_Nombre.TabIndex = 2
        '
        'Txt_Depart
        '
        Me.Txt_Depart.Location = New System.Drawing.Point(3, 55)
        Me.Txt_Depart.Name = "Txt_Depart"
        Me.Txt_Depart.Size = New System.Drawing.Size(196, 20)
        Me.Txt_Depart.TabIndex = 3
        '
        'Txt_Direccion
        '
        Me.Txt_Direccion.Location = New System.Drawing.Point(3, 81)
        Me.Txt_Direccion.Name = "Txt_Direccion"
        Me.Txt_Direccion.Size = New System.Drawing.Size(196, 20)
        Me.Txt_Direccion.TabIndex = 4
        '
        'Txt_Telefono
        '
        Me.Txt_Telefono.Location = New System.Drawing.Point(3, 107)
        Me.Txt_Telefono.Name = "Txt_Telefono"
        Me.Txt_Telefono.Size = New System.Drawing.Size(196, 20)
        Me.Txt_Telefono.TabIndex = 5
        '
        'LblTelefonos
        '
        Me.LblTelefonos.FormattingEnabled = True
        Me.LblTelefonos.Location = New System.Drawing.Point(3, 133)
        Me.LblTelefonos.Name = "LblTelefonos"
        Me.LblTelefonos.Size = New System.Drawing.Size(196, 56)
        Me.LblTelefonos.TabIndex = 6
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Controls.Add(Me.BtnAgregar)
        Me.FlowLayoutPanel1.Controls.Add(Me.Button2)
        Me.FlowLayoutPanel1.Controls.Add(Me.Button3)
        Me.FlowLayoutPanel1.Controls.Add(Me.Button4)
        Me.FlowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(350, 30)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(84, 229)
        Me.FlowLayoutPanel1.TabIndex = 2
        '
        'BtnAgregar
        '
        Me.BtnAgregar.Location = New System.Drawing.Point(3, 3)
        Me.BtnAgregar.Name = "BtnAgregar"
        Me.BtnAgregar.Size = New System.Drawing.Size(75, 23)
        Me.BtnAgregar.TabIndex = 0
        Me.BtnAgregar.Text = "Agregar"
        Me.BtnAgregar.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(3, 32)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Modificar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(3, 61)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "Eliminar"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(3, 90)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 23)
        Me.Button4.TabIndex = 3
        Me.Button4.Text = "Limpiar"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Lbl_IDBusq)
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Controls.Add(Me.DataGridView1)
        Me.Panel2.Controls.Add(Me.Txt_Busqueda)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel2.Location = New System.Drawing.Point(446, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(752, 386)
        Me.Panel2.TabIndex = 11
        '
        'Lbl_IDBusq
        '
        Me.Lbl_IDBusq.AutoSize = True
        Me.Lbl_IDBusq.Location = New System.Drawing.Point(34, 40)
        Me.Lbl_IDBusq.Name = "Lbl_IDBusq"
        Me.Lbl_IDBusq.Size = New System.Drawing.Size(18, 13)
        Me.Lbl_IDBusq.TabIndex = 11
        Me.Lbl_IDBusq.Text = "ID"
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
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID, Me.Nombre, Me.Departamento, Me.Direccion, Me.User})
        Me.DataGridView1.Location = New System.Drawing.Point(37, 106)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(544, 150)
        Me.DataGridView1.TabIndex = 9
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
        'Txt_Busqueda
        '
        Me.Txt_Busqueda.Location = New System.Drawing.Point(37, 55)
        Me.Txt_Busqueda.Name = "Txt_Busqueda"
        Me.Txt_Busqueda.Size = New System.Drawing.Size(159, 20)
        Me.Txt_Busqueda.TabIndex = 10
        '
        'EpErrores
        '
        Me.EpErrores.ContainerControl = Me
        '
        'FrmSucursales
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1198, 386)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "FrmSucursales"
        Me.Text = "Sucursales"
        Me.Panel1.ResumeLayout(False)
        Me.Lbl_Infosucursal.ResumeLayout(False)
        Me.Lbl_Infosucursal.PerformLayout()
        Me.Panel3.ResumeLayout(False)
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
    Friend WithEvents Lbl_Infosucursal As System.Windows.Forms.GroupBox
    Friend WithEvents LblMensaje As System.Windows.Forms.Label
    Friend WithEvents Lbl_Dirección As System.Windows.Forms.Label
    Friend WithEvents Lbl_Departamento As System.Windows.Forms.Label
    Friend WithEvents Lbl_Nombre As System.Windows.Forms.Label
    Friend WithEvents Lbl_ID As System.Windows.Forms.Label
    Friend WithEvents FlowLayoutPanel2 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents Txt_ID As System.Windows.Forms.TextBox
    Friend WithEvents Txt_Nombre As System.Windows.Forms.TextBox
    Friend WithEvents Txt_Depart As System.Windows.Forms.TextBox
    Friend WithEvents Txt_Direccion As System.Windows.Forms.TextBox
    Friend WithEvents FlowLayoutPanel1 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents BtnAgregar As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Lbl_IDBusq As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Txt_Busqueda As System.Windows.Forms.TextBox
    Friend WithEvents EpErrores As System.Windows.Forms.ErrorProvider
    Friend WithEvents Lbl_Telefono As System.Windows.Forms.Label
    Friend WithEvents Txt_Telefono As System.Windows.Forms.TextBox
    Friend WithEvents LblTelefonos As System.Windows.Forms.ListBox
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Btn_Borrar As System.Windows.Forms.Button
    Friend WithEvents Btn_AgregarTel As System.Windows.Forms.Button
    Friend WithEvents ID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Nombre As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Departamento As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Direccion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents User As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
