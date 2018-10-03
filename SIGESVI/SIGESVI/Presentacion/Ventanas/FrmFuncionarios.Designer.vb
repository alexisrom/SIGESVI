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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmFuncionarios))
        Me.Lbl_IDBusq = New System.Windows.Forms.Label
        Me.Txt_Busqueda = New System.Windows.Forms.TextBox
        Me.DgvFuncionarios = New System.Windows.Forms.DataGridView
        Me.TxtContrasenaREQ = New System.Windows.Forms.TextBox
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.BtnEliminar = New System.Windows.Forms.Button
        Me.BtnGuardar = New System.Windows.Forms.Button
        Me.CboCargo = New System.Windows.Forms.ComboBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.TxtCiNUMREQ = New System.Windows.Forms.TextBox
        Me.Txt_NombreLETREQ = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Txt_ApellidoLETREQ = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.Button2 = New System.Windows.Forms.Button
        Me.Txt_DireccionREQ = New System.Windows.Forms.TextBox
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.LblMensaje = New System.Windows.Forms.Label
        Me.CboSucursalesREQ = New System.Windows.Forms.ComboBox
        Me.lblDireccion = New System.Windows.Forms.Label
        Me.lblApellido = New System.Windows.Forms.Label
        Me.TxtUsuarioREQ = New System.Windows.Forms.TextBox
        Me.Label_Nombre = New System.Windows.Forms.Label
        Me.Label_cedula = New System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button
        Me.Button3 = New System.Windows.Forms.Button
        Me.Label2 = New System.Windows.Forms.Label
        Me.NombreSucursal = New System.Windows.Forms.DataGridViewTextBoxColumn
        CType(Me.DgvFuncionarios, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Lbl_IDBusq
        '
        Me.Lbl_IDBusq.AutoSize = True
        Me.Lbl_IDBusq.Font = New System.Drawing.Font("Constantia", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_IDBusq.Location = New System.Drawing.Point(664, 34)
        Me.Lbl_IDBusq.Name = "Lbl_IDBusq"
        Me.Lbl_IDBusq.Size = New System.Drawing.Size(72, 18)
        Me.Lbl_IDBusq.TabIndex = 25
        Me.Lbl_IDBusq.Text = "Búsqueda"
        '
        'Txt_Busqueda
        '
        Me.Txt_Busqueda.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_Busqueda.Location = New System.Drawing.Point(667, 55)
        Me.Txt_Busqueda.Name = "Txt_Busqueda"
        Me.Txt_Busqueda.Size = New System.Drawing.Size(159, 24)
        Me.Txt_Busqueda.TabIndex = 24
        '
        'DgvFuncionarios
        '
        Me.DgvFuncionarios.AllowUserToAddRows = False
        Me.DgvFuncionarios.AllowUserToDeleteRows = False
        Me.DgvFuncionarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvFuncionarios.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NombreSucursal})
        Me.DgvFuncionarios.Location = New System.Drawing.Point(667, 86)
        Me.DgvFuncionarios.Name = "DgvFuncionarios"
        Me.DgvFuncionarios.ReadOnly = True
        Me.DgvFuncionarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvFuncionarios.Size = New System.Drawing.Size(553, 178)
        Me.DgvFuncionarios.TabIndex = 23
        '
        'TxtContrasenaREQ
        '
        Me.TxtContrasenaREQ.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtContrasenaREQ.Location = New System.Drawing.Point(224, 273)
        Me.TxtContrasenaREQ.Name = "TxtContrasenaREQ"
        Me.TxtContrasenaREQ.Size = New System.Drawing.Size(173, 24)
        Me.TxtContrasenaREQ.TabIndex = 8
        '
        'PictureBox1
        '
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(832, 55)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(25, 25)
        Me.PictureBox1.TabIndex = 26
        Me.PictureBox1.TabStop = False
        '
        'BtnEliminar
        '
        Me.BtnEliminar.Location = New System.Drawing.Point(1226, 205)
        Me.BtnEliminar.Name = "BtnEliminar"
        Me.BtnEliminar.Size = New System.Drawing.Size(97, 32)
        Me.BtnEliminar.TabIndex = 27
        Me.BtnEliminar.Text = "Eliminar"
        Me.BtnEliminar.UseVisualStyleBackColor = True
        '
        'BtnGuardar
        '
        Me.BtnGuardar.Location = New System.Drawing.Point(224, 355)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(173, 23)
        Me.BtnGuardar.TabIndex = 83
        Me.BtnGuardar.Text = "AGREGAR"
        Me.BtnGuardar.UseVisualStyleBackColor = True
        '
        'CboCargo
        '
        Me.CboCargo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboCargo.FormattingEnabled = True
        Me.CboCargo.Items.AddRange(New Object() {"Administrativo", "Enologo"})
        Me.CboCargo.Location = New System.Drawing.Point(224, 303)
        Me.CboCargo.Name = "CboCargo"
        Me.CboCargo.Size = New System.Drawing.Size(173, 21)
        Me.CboCargo.TabIndex = 84
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(129, 268)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(78, 17)
        Me.Label7.TabIndex = 82
        Me.Label7.Text = "Contraseña"
        '
        'TxtCiNUMREQ
        '
        Me.TxtCiNUMREQ.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCiNUMREQ.Location = New System.Drawing.Point(224, 92)
        Me.TxtCiNUMREQ.Name = "TxtCiNUMREQ"
        Me.TxtCiNUMREQ.Size = New System.Drawing.Size(173, 24)
        Me.TxtCiNUMREQ.TabIndex = 66
        '
        'Txt_NombreLETREQ
        '
        Me.Txt_NombreLETREQ.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_NombreLETREQ.Location = New System.Drawing.Point(224, 122)
        Me.Txt_NombreLETREQ.Name = "Txt_NombreLETREQ"
        Me.Txt_NombreLETREQ.Size = New System.Drawing.Size(173, 24)
        Me.Txt_NombreLETREQ.TabIndex = 68
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(129, 247)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(57, 17)
        Me.Label6.TabIndex = 80
        Me.Label6.Text = "Usuario"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(129, 218)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 17)
        Me.Label1.TabIndex = 79
        Me.Label1.Text = "Sucursal"
        '
        'Txt_ApellidoLETREQ
        '
        Me.Txt_ApellidoLETREQ.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_ApellidoLETREQ.Location = New System.Drawing.Point(224, 152)
        Me.Txt_ApellidoLETREQ.Name = "Txt_ApellidoLETREQ"
        Me.Txt_ApellidoLETREQ.Size = New System.Drawing.Size(173, 24)
        Me.Txt_ApellidoLETREQ.TabIndex = 70
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(129, 303)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(44, 17)
        Me.Label8.TabIndex = 81
        Me.Label8.Text = "Cargo"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(476, 210)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(112, 23)
        Me.Button2.TabIndex = 78
        Me.Button2.Text = "Cambiar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Txt_DireccionREQ
        '
        Me.Txt_DireccionREQ.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_DireccionREQ.Location = New System.Drawing.Point(224, 182)
        Me.Txt_DireccionREQ.Name = "Txt_DireccionREQ"
        Me.Txt_DireccionREQ.Size = New System.Drawing.Size(173, 24)
        Me.Txt_DireccionREQ.TabIndex = 73
        '
        'PictureBox2
        '
        Me.PictureBox2.Location = New System.Drawing.Point(476, 69)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(112, 85)
        Me.PictureBox2.TabIndex = 77
        Me.PictureBox2.TabStop = False
        '
        'LblMensaje
        '
        Me.LblMensaje.AutoSize = True
        Me.LblMensaje.Location = New System.Drawing.Point(212, 267)
        Me.LblMensaje.Name = "LblMensaje"
        Me.LblMensaje.Size = New System.Drawing.Size(0, 13)
        Me.LblMensaje.TabIndex = 71
        '
        'CboSucursalesREQ
        '
        Me.CboSucursalesREQ.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboSucursalesREQ.FormattingEnabled = True
        Me.CboSucursalesREQ.Location = New System.Drawing.Point(224, 212)
        Me.CboSucursalesREQ.Name = "CboSucursalesREQ"
        Me.CboSucursalesREQ.Size = New System.Drawing.Size(173, 21)
        Me.CboSucursalesREQ.TabIndex = 75
        '
        'lblDireccion
        '
        Me.lblDireccion.AutoSize = True
        Me.lblDireccion.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDireccion.Location = New System.Drawing.Point(129, 185)
        Me.lblDireccion.Name = "lblDireccion"
        Me.lblDireccion.Size = New System.Drawing.Size(69, 17)
        Me.lblDireccion.TabIndex = 74
        Me.lblDireccion.Text = "Dirección"
        '
        'lblApellido
        '
        Me.lblApellido.AutoSize = True
        Me.lblApellido.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblApellido.Location = New System.Drawing.Point(136, 154)
        Me.lblApellido.Name = "lblApellido"
        Me.lblApellido.Size = New System.Drawing.Size(60, 17)
        Me.lblApellido.TabIndex = 72
        Me.lblApellido.Text = "Apellido"
        '
        'TxtUsuarioREQ
        '
        Me.TxtUsuarioREQ.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtUsuarioREQ.Location = New System.Drawing.Point(224, 244)
        Me.TxtUsuarioREQ.Name = "TxtUsuarioREQ"
        Me.TxtUsuarioREQ.Size = New System.Drawing.Size(173, 24)
        Me.TxtUsuarioREQ.TabIndex = 76
        '
        'Label_Nombre
        '
        Me.Label_Nombre.AutoSize = True
        Me.Label_Nombre.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Nombre.Location = New System.Drawing.Point(137, 123)
        Me.Label_Nombre.Name = "Label_Nombre"
        Me.Label_Nombre.Size = New System.Drawing.Size(59, 17)
        Me.Label_Nombre.TabIndex = 69
        Me.Label_Nombre.Text = "Nombre"
        '
        'Label_cedula
        '
        Me.Label_cedula.AutoSize = True
        Me.Label_cedula.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_cedula.Location = New System.Drawing.Point(142, 92)
        Me.Label_cedula.Name = "Label_cedula"
        Me.Label_cedula.Size = New System.Drawing.Size(50, 17)
        Me.Label_cedula.TabIndex = 67
        Me.Label_cedula.Text = "Cédula"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(1226, 241)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(97, 23)
        Me.Button1.TabIndex = 85
        Me.Button1.Text = "Limpiar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(1226, 170)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(97, 32)
        Me.Button3.TabIndex = 86
        Me.Button3.Text = "editar"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(863, 62)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(224, 13)
        Me.Label2.TabIndex = 87
        Me.Label2.Text = "Ingrese algun texto para buscar coincidencias"
        '
        'NombreSucursal
        '
        Me.NombreSucursal.HeaderText = "NombreSucursal"
        Me.NombreSucursal.Name = "NombreSucursal"
        Me.NombreSucursal.ReadOnly = True
        '
        'FrmFuncionarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.CornflowerBlue
        Me.ClientSize = New System.Drawing.Size(1358, 459)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.BtnGuardar)
        Me.Controls.Add(Me.CboCargo)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.TxtCiNUMREQ)
        Me.Controls.Add(Me.Txt_NombreLETREQ)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Txt_ApellidoLETREQ)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Txt_DireccionREQ)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.LblMensaje)
        Me.Controls.Add(Me.CboSucursalesREQ)
        Me.Controls.Add(Me.lblDireccion)
        Me.Controls.Add(Me.lblApellido)
        Me.Controls.Add(Me.TxtUsuarioREQ)
        Me.Controls.Add(Me.Label_Nombre)
        Me.Controls.Add(Me.Label_cedula)
        Me.Controls.Add(Me.BtnEliminar)
        Me.Controls.Add(Me.Lbl_IDBusq)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Txt_Busqueda)
        Me.Controls.Add(Me.DgvFuncionarios)
        Me.Controls.Add(Me.TxtContrasenaREQ)
        Me.Location = New System.Drawing.Point(42, 30)
        Me.Name = "FrmFuncionarios"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Funcionarios"
        CType(Me.DgvFuncionarios, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Lbl_IDBusq As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Txt_Busqueda As System.Windows.Forms.TextBox
    Friend WithEvents TxtContrasenaREQ As System.Windows.Forms.TextBox
    Friend WithEvents BtnEliminar As System.Windows.Forms.Button
    Friend WithEvents BtnGuardar As System.Windows.Forms.Button
    Friend WithEvents CboCargo As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents TxtCiNUMREQ As System.Windows.Forms.TextBox
    Friend WithEvents Txt_NombreLETREQ As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Txt_ApellidoLETREQ As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Txt_DireccionREQ As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents LblMensaje As System.Windows.Forms.Label
    Friend WithEvents CboSucursalesREQ As System.Windows.Forms.ComboBox
    Friend WithEvents lblDireccion As System.Windows.Forms.Label
    Friend WithEvents lblApellido As System.Windows.Forms.Label
    Friend WithEvents TxtUsuarioREQ As System.Windows.Forms.TextBox
    Friend WithEvents Label_Nombre As System.Windows.Forms.Label
    Friend WithEvents Label_cedula As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents NombreSucursal As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DgvFuncionarios As System.Windows.Forms.DataGridView
End Class
