﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmClientes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmClientes))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.LblMensaje = New System.Windows.Forms.Label
        Me.lblDireccion = New System.Windows.Forms.Label
        Me.lbltelefono = New System.Windows.Forms.Label
        Me.lblApellido = New System.Windows.Forms.Label
        Me.Label_Nombre = New System.Windows.Forms.Label
        Me.Label_cedula = New System.Windows.Forms.Label
        Me.FlowLayoutPanel2 = New System.Windows.Forms.FlowLayoutPanel
        Me.Txt_Ci = New System.Windows.Forms.TextBox
        Me.Txt_nombre = New System.Windows.Forms.TextBox
        Me.Txt_Apellido = New System.Windows.Forms.TextBox
        Me.Txt_Direccion = New System.Windows.Forms.TextBox
        Me.Txt_Telefono = New System.Windows.Forms.TextBox
        Me.LblTelefonos = New System.Windows.Forms.ListBox
        Me.Btn_AñadirTel = New System.Windows.Forms.Button
        Me.Btn_Quitartel = New System.Windows.Forms.Button
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.CI = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Nombre = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Apellido = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Telefono = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.User = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Pass = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Lbl_IDBusq = New System.Windows.Forms.Label
        Me.Txt_Busqueda = New System.Windows.Forms.TextBox
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton
        Me.ToolStripButton3 = New System.Windows.Forms.ToolStripButton
        Me.ToolStripButton4 = New System.Windows.Forms.ToolStripButton
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.errordecedula = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.errordenombre = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.errordeapellido = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.errordedireccion = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Errortelefono = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.GroupBox1.SuspendLayout()
        Me.FlowLayoutPanel2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.errordecedula, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.errordenombre, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.errordeapellido, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.errordedireccion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Errortelefono, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.GroupBox1.Location = New System.Drawing.Point(41, 32)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(332, 305)
        Me.GroupBox1.TabIndex = 1
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
        Me.FlowLayoutPanel2.Controls.Add(Me.Txt_nombre)
        Me.FlowLayoutPanel2.Controls.Add(Me.Txt_Apellido)
        Me.FlowLayoutPanel2.Controls.Add(Me.Txt_Direccion)
        Me.FlowLayoutPanel2.Controls.Add(Me.Txt_Telefono)
        Me.FlowLayoutPanel2.Controls.Add(Me.LblTelefonos)
        Me.FlowLayoutPanel2.Controls.Add(Me.Btn_AñadirTel)
        Me.FlowLayoutPanel2.Controls.Add(Me.Btn_Quitartel)
        Me.FlowLayoutPanel2.Location = New System.Drawing.Point(106, 41)
        Me.FlowLayoutPanel2.Name = "FlowLayoutPanel2"
        Me.FlowLayoutPanel2.Size = New System.Drawing.Size(220, 222)
        Me.FlowLayoutPanel2.TabIndex = 0
        '
        'Txt_Ci
        '
        Me.Txt_Ci.Location = New System.Drawing.Point(3, 3)
        Me.Txt_Ci.MaxLength = 8
        Me.Txt_Ci.Name = "Txt_Ci"
        Me.Txt_Ci.Size = New System.Drawing.Size(173, 20)
        Me.Txt_Ci.TabIndex = 1
        '
        'Txt_nombre
        '
        Me.Txt_nombre.Location = New System.Drawing.Point(3, 29)
        Me.Txt_nombre.Name = "Txt_nombre"
        Me.Txt_nombre.Size = New System.Drawing.Size(173, 20)
        Me.Txt_nombre.TabIndex = 2
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
        'Btn_AñadirTel
        '
        Me.Btn_AñadirTel.Location = New System.Drawing.Point(3, 195)
        Me.Btn_AñadirTel.Name = "Btn_AñadirTel"
        Me.Btn_AñadirTel.Size = New System.Drawing.Size(75, 23)
        Me.Btn_AñadirTel.TabIndex = 8
        Me.Btn_AñadirTel.Text = "Añadir Tel"
        Me.Btn_AñadirTel.UseVisualStyleBackColor = True
        '
        'Btn_Quitartel
        '
        Me.Btn_Quitartel.Location = New System.Drawing.Point(84, 195)
        Me.Btn_Quitartel.Name = "Btn_Quitartel"
        Me.Btn_Quitartel.Size = New System.Drawing.Size(75, 23)
        Me.Btn_Quitartel.TabIndex = 7
        Me.Btn_Quitartel.Text = "Quitar Tel"
        Me.Btn_Quitartel.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CI, Me.Nombre, Me.Apellido, Me.Telefono, Me.User, Me.Pass})
        Me.DataGridView1.Location = New System.Drawing.Point(400, 76)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(644, 261)
        Me.DataGridView1.TabIndex = 10
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
        'Lbl_IDBusq
        '
        Me.Lbl_IDBusq.AutoSize = True
        Me.Lbl_IDBusq.Location = New System.Drawing.Point(399, 34)
        Me.Lbl_IDBusq.Name = "Lbl_IDBusq"
        Me.Lbl_IDBusq.Size = New System.Drawing.Size(40, 13)
        Me.Lbl_IDBusq.TabIndex = 20
        Me.Lbl_IDBusq.Text = "Cédula"
        '
        'Txt_Busqueda
        '
        Me.Txt_Busqueda.Location = New System.Drawing.Point(400, 50)
        Me.Txt_Busqueda.Name = "Txt_Busqueda"
        Me.Txt_Busqueda.Size = New System.Drawing.Size(159, 20)
        Me.Txt_Busqueda.TabIndex = 19
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton1, Me.ToolStripButton2, Me.ToolStripButton3, Me.ToolStripButton4})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1109, 25)
        Me.ToolStrip1.TabIndex = 22
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
        'PictureBox1
        '
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(567, 45)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(25, 25)
        Me.PictureBox1.TabIndex = 21
        Me.PictureBox1.TabStop = False
        '
        'errordecedula
        '
        Me.errordecedula.ContainerControl = Me
        '
        'errordenombre
        '
        Me.errordenombre.ContainerControl = Me
        '
        'errordeapellido
        '
        Me.errordeapellido.ContainerControl = Me
        '
        'errordedireccion
        '
        Me.errordedireccion.ContainerControl = Me
        '
        'Errortelefono
        '
        Me.Errortelefono.ContainerControl = Me
        '
        'FrmClientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1109, 389)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.Lbl_IDBusq)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Txt_Busqueda)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "FrmClientes"
        Me.Text = "Mantenimiento de Clientes"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.FlowLayoutPanel2.ResumeLayout(False)
        Me.FlowLayoutPanel2.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.errordecedula, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.errordenombre, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.errordeapellido, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.errordedireccion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Errortelefono, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents LblMensaje As System.Windows.Forms.Label
    Friend WithEvents lblDireccion As System.Windows.Forms.Label
    Friend WithEvents lbltelefono As System.Windows.Forms.Label
    Friend WithEvents lblApellido As System.Windows.Forms.Label
    Friend WithEvents Label_Nombre As System.Windows.Forms.Label
    Friend WithEvents Label_cedula As System.Windows.Forms.Label
    Friend WithEvents FlowLayoutPanel2 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents Txt_Ci As System.Windows.Forms.TextBox
    Friend WithEvents Txt_nombre As System.Windows.Forms.TextBox
    Friend WithEvents Txt_Apellido As System.Windows.Forms.TextBox
    Friend WithEvents Txt_Direccion As System.Windows.Forms.TextBox
    Friend WithEvents Txt_Telefono As System.Windows.Forms.TextBox
    Friend WithEvents LblTelefonos As System.Windows.Forms.ListBox
    Friend WithEvents Btn_AñadirTel As System.Windows.Forms.Button
    Friend WithEvents Btn_Quitartel As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents CI As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Nombre As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Apellido As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Telefono As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents User As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Pass As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Lbl_IDBusq As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Txt_Busqueda As System.Windows.Forms.TextBox
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton2 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton3 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton4 As System.Windows.Forms.ToolStripButton
    Friend WithEvents errordecedula As System.Windows.Forms.ErrorProvider
    Friend WithEvents errordenombre As System.Windows.Forms.ErrorProvider
    Friend WithEvents errordeapellido As System.Windows.Forms.ErrorProvider
    Friend WithEvents errordedireccion As System.Windows.Forms.ErrorProvider
    Friend WithEvents Errortelefono As System.Windows.Forms.ErrorProvider
End Class
