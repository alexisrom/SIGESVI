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
        Me.DgvSucursales = New System.Windows.Forms.DataGridView
        Me.BtnEliminarSucursal = New System.Windows.Forms.Button
        Me.BtnEditarSucursal = New System.Windows.Forms.Button
        Me.BtnLimpiar = New System.Windows.Forms.Button
        Me.BtnGuardar = New System.Windows.Forms.Button
        Me.LbQuitarTelefono = New System.Windows.Forms.LinkLabel
        Me.LbAgregarTelefono = New System.Windows.Forms.LinkLabel
        Me.CboDepartamentosREQ = New System.Windows.Forms.ComboBox
        Me.Lbl_Departamento = New System.Windows.Forms.Label
        Me.Txt_NombreREQ = New System.Windows.Forms.TextBox
        Me.Txt_DireccionREQ = New System.Windows.Forms.TextBox
        Me.Txt_TelefonoNUM = New System.Windows.Forms.TextBox
        Me.LstTelefonosREQ = New System.Windows.Forms.ListBox
        Me.Lbl_Telefono = New System.Windows.Forms.Label
        Me.Lbl_Dirección = New System.Windows.Forms.Label
        Me.Lbl_Nombre = New System.Windows.Forms.Label
        CType(Me.DgvSucursales, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DgvSucursales
        '
        Me.DgvSucursales.AllowUserToAddRows = False
        Me.DgvSucursales.AllowUserToDeleteRows = False
        Me.DgvSucursales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvSucursales.Location = New System.Drawing.Point(412, 51)
        Me.DgvSucursales.MultiSelect = False
        Me.DgvSucursales.Name = "DgvSucursales"
        Me.DgvSucursales.ReadOnly = True
        Me.DgvSucursales.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvSucursales.Size = New System.Drawing.Size(523, 258)
        Me.DgvSucursales.TabIndex = 15
        '
        'BtnEliminarSucursal
        '
        Me.BtnEliminarSucursal.Location = New System.Drawing.Point(961, 112)
        Me.BtnEliminarSucursal.Name = "BtnEliminarSucursal"
        Me.BtnEliminarSucursal.Size = New System.Drawing.Size(75, 23)
        Me.BtnEliminarSucursal.TabIndex = 21
        Me.BtnEliminarSucursal.Text = "Eliminar"
        Me.BtnEliminarSucursal.UseVisualStyleBackColor = True
        '
        'BtnEditarSucursal
        '
        Me.BtnEditarSucursal.Location = New System.Drawing.Point(961, 143)
        Me.BtnEditarSucursal.Name = "BtnEditarSucursal"
        Me.BtnEditarSucursal.Size = New System.Drawing.Size(75, 23)
        Me.BtnEditarSucursal.TabIndex = 22
        Me.BtnEditarSucursal.Text = "Editar"
        Me.BtnEditarSucursal.UseVisualStyleBackColor = True
        '
        'BtnLimpiar
        '
        Me.BtnLimpiar.Location = New System.Drawing.Point(961, 176)
        Me.BtnLimpiar.Name = "BtnLimpiar"
        Me.BtnLimpiar.Size = New System.Drawing.Size(75, 23)
        Me.BtnLimpiar.TabIndex = 23
        Me.BtnLimpiar.Text = "Limpiar"
        Me.BtnLimpiar.UseVisualStyleBackColor = True
        '
        'BtnGuardar
        '
        Me.BtnGuardar.Location = New System.Drawing.Point(158, 298)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(195, 34)
        Me.BtnGuardar.TabIndex = 35
        Me.BtnGuardar.Text = "GUARDAR"
        Me.BtnGuardar.UseVisualStyleBackColor = True
        '
        'LbQuitarTelefono
        '
        Me.LbQuitarTelefono.AutoSize = True
        Me.LbQuitarTelefono.Location = New System.Drawing.Point(299, 185)
        Me.LbQuitarTelefono.Name = "LbQuitarTelefono"
        Me.LbQuitarTelefono.Size = New System.Drawing.Size(35, 13)
        Me.LbQuitarTelefono.TabIndex = 34
        Me.LbQuitarTelefono.TabStop = True
        Me.LbQuitarTelefono.Text = "Quitar"
        '
        'LbAgregarTelefono
        '
        Me.LbAgregarTelefono.AutoSize = True
        Me.LbAgregarTelefono.Location = New System.Drawing.Point(158, 185)
        Me.LbAgregarTelefono.Name = "LbAgregarTelefono"
        Me.LbAgregarTelefono.Size = New System.Drawing.Size(44, 13)
        Me.LbAgregarTelefono.TabIndex = 33
        Me.LbAgregarTelefono.TabStop = True
        Me.LbAgregarTelefono.Text = "Agregar"
        '
        'CboDepartamentosREQ
        '
        Me.CboDepartamentosREQ.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboDepartamentosREQ.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboDepartamentosREQ.FormattingEnabled = True
        Me.CboDepartamentosREQ.Location = New System.Drawing.Point(157, 118)
        Me.CboDepartamentosREQ.Name = "CboDepartamentosREQ"
        Me.CboDepartamentosREQ.Size = New System.Drawing.Size(196, 26)
        Me.CboDepartamentosREQ.TabIndex = 32
        '
        'Lbl_Departamento
        '
        Me.Lbl_Departamento.AutoSize = True
        Me.Lbl_Departamento.Location = New System.Drawing.Point(53, 121)
        Me.Lbl_Departamento.Name = "Lbl_Departamento"
        Me.Lbl_Departamento.Size = New System.Drawing.Size(74, 13)
        Me.Lbl_Departamento.TabIndex = 31
        Me.Lbl_Departamento.Text = "Departamento"
        '
        'Txt_NombreREQ
        '
        Me.Txt_NombreREQ.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_NombreREQ.Location = New System.Drawing.Point(157, 54)
        Me.Txt_NombreREQ.Name = "Txt_NombreREQ"
        Me.Txt_NombreREQ.Size = New System.Drawing.Size(196, 24)
        Me.Txt_NombreREQ.TabIndex = 27
        '
        'Txt_DireccionREQ
        '
        Me.Txt_DireccionREQ.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_DireccionREQ.Location = New System.Drawing.Point(157, 85)
        Me.Txt_DireccionREQ.Name = "Txt_DireccionREQ"
        Me.Txt_DireccionREQ.Size = New System.Drawing.Size(196, 24)
        Me.Txt_DireccionREQ.TabIndex = 28
        '
        'Txt_TelefonoNUM
        '
        Me.Txt_TelefonoNUM.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_TelefonoNUM.Location = New System.Drawing.Point(158, 152)
        Me.Txt_TelefonoNUM.Name = "Txt_TelefonoNUM"
        Me.Txt_TelefonoNUM.Size = New System.Drawing.Size(192, 24)
        Me.Txt_TelefonoNUM.TabIndex = 29
        '
        'LstTelefonosREQ
        '
        Me.LstTelefonosREQ.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LstTelefonosREQ.FormattingEnabled = True
        Me.LstTelefonosREQ.ItemHeight = 18
        Me.LstTelefonosREQ.Location = New System.Drawing.Point(157, 216)
        Me.LstTelefonosREQ.Name = "LstTelefonosREQ"
        Me.LstTelefonosREQ.Size = New System.Drawing.Size(196, 76)
        Me.LstTelefonosREQ.TabIndex = 30
        '
        'Lbl_Telefono
        '
        Me.Lbl_Telefono.AutoSize = True
        Me.Lbl_Telefono.Location = New System.Drawing.Point(88, 152)
        Me.Lbl_Telefono.Name = "Lbl_Telefono"
        Me.Lbl_Telefono.Size = New System.Drawing.Size(49, 13)
        Me.Lbl_Telefono.TabIndex = 26
        Me.Lbl_Telefono.Text = "Teléfono"
        '
        'Lbl_Dirección
        '
        Me.Lbl_Dirección.AutoSize = True
        Me.Lbl_Dirección.Location = New System.Drawing.Point(82, 88)
        Me.Lbl_Dirección.Name = "Lbl_Dirección"
        Me.Lbl_Dirección.Size = New System.Drawing.Size(52, 13)
        Me.Lbl_Dirección.TabIndex = 25
        Me.Lbl_Dirección.Text = "Dirección"
        '
        'Lbl_Nombre
        '
        Me.Lbl_Nombre.AutoSize = True
        Me.Lbl_Nombre.Location = New System.Drawing.Point(92, 57)
        Me.Lbl_Nombre.Name = "Lbl_Nombre"
        Me.Lbl_Nombre.Size = New System.Drawing.Size(44, 13)
        Me.Lbl_Nombre.TabIndex = 24
        Me.Lbl_Nombre.Text = "Nombre"
        '
        'FrmSucursales
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.CornflowerBlue
        Me.ClientSize = New System.Drawing.Size(1047, 404)
        Me.Controls.Add(Me.BtnGuardar)
        Me.Controls.Add(Me.LbQuitarTelefono)
        Me.Controls.Add(Me.LbAgregarTelefono)
        Me.Controls.Add(Me.CboDepartamentosREQ)
        Me.Controls.Add(Me.Lbl_Departamento)
        Me.Controls.Add(Me.Txt_NombreREQ)
        Me.Controls.Add(Me.Txt_DireccionREQ)
        Me.Controls.Add(Me.Txt_TelefonoNUM)
        Me.Controls.Add(Me.LstTelefonosREQ)
        Me.Controls.Add(Me.Lbl_Telefono)
        Me.Controls.Add(Me.Lbl_Dirección)
        Me.Controls.Add(Me.Lbl_Nombre)
        Me.Controls.Add(Me.BtnLimpiar)
        Me.Controls.Add(Me.BtnEditarSucursal)
        Me.Controls.Add(Me.BtnEliminarSucursal)
        Me.Controls.Add(Me.DgvSucursales)
        Me.Name = "FrmSucursales"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sucursales"
        CType(Me.DgvSucursales, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DgvSucursales As System.Windows.Forms.DataGridView
    Friend WithEvents BtnEditarSucursal As System.Windows.Forms.Button
    Friend WithEvents BtnEliminarSucursal As System.Windows.Forms.Button
    Friend WithEvents BtnLimpiar As System.Windows.Forms.Button
    Friend WithEvents BtnGuardar As System.Windows.Forms.Button
    Friend WithEvents LbQuitarTelefono As System.Windows.Forms.LinkLabel
    Friend WithEvents LbAgregarTelefono As System.Windows.Forms.LinkLabel
    Friend WithEvents CboDepartamentosREQ As System.Windows.Forms.ComboBox
    Friend WithEvents Lbl_Departamento As System.Windows.Forms.Label
    Friend WithEvents Txt_NombreREQ As System.Windows.Forms.TextBox
    Friend WithEvents Txt_DireccionREQ As System.Windows.Forms.TextBox
    Friend WithEvents Txt_TelefonoNUM As System.Windows.Forms.TextBox
    Friend WithEvents LstTelefonosREQ As System.Windows.Forms.ListBox
    Friend WithEvents Lbl_Telefono As System.Windows.Forms.Label
    Friend WithEvents Lbl_Dirección As System.Windows.Forms.Label
    Friend WithEvents Lbl_Nombre As System.Windows.Forms.Label
End Class
