<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmProductoFinal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmProductoFinal))
        Me.TxtNombre_REQ = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.TxtDescripcion_REQ = New System.Windows.Forms.TextBox
        Me.BtnGuardar = New System.Windows.Forms.Button
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.TxtID = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.TxtPrecio_NUM_REQ = New System.Windows.Forms.TextBox
        Me.CboCategoria_REQ = New System.Windows.Forms.ComboBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.BtnSeleccionarFoto = New System.Windows.Forms.Button
        Me.DgvEtapas = New System.Windows.Forms.DataGridView
        Me.Numero = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ID = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Nombre = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Descripcion = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Duracion = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Label8 = New System.Windows.Forms.Label
        Me.CboCrianza = New System.Windows.Forms.ComboBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.CboEmbotellamiento = New System.Windows.Forms.ComboBox
        Me.BtnAgregarEtapa = New System.Windows.Forms.Button
        Me.BtnEliminarEtapa = New System.Windows.Forms.Button
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.BtnVolver = New System.Windows.Forms.PictureBox
        Me.PicFoto = New System.Windows.Forms.PictureBox
        Me.OfdImagen = New System.Windows.Forms.OpenFileDialog
        CType(Me.DgvEtapas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnVolver, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicFoto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TxtNombre_REQ
        '
        Me.TxtNombre_REQ.AccessibleDescription = Nothing
        Me.TxtNombre_REQ.AccessibleName = Nothing
        resources.ApplyResources(Me.TxtNombre_REQ, "TxtNombre_REQ")
        Me.TxtNombre_REQ.BackgroundImage = Nothing
        Me.TxtNombre_REQ.Name = "TxtNombre_REQ"
        '
        'Label1
        '
        Me.Label1.AccessibleDescription = Nothing
        Me.Label1.AccessibleName = Nothing
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.Name = "Label1"
        '
        'Label2
        '
        Me.Label2.AccessibleDescription = Nothing
        Me.Label2.AccessibleName = Nothing
        resources.ApplyResources(Me.Label2, "Label2")
        Me.Label2.Name = "Label2"
        '
        'TxtDescripcion_REQ
        '
        Me.TxtDescripcion_REQ.AccessibleDescription = Nothing
        Me.TxtDescripcion_REQ.AccessibleName = Nothing
        resources.ApplyResources(Me.TxtDescripcion_REQ, "TxtDescripcion_REQ")
        Me.TxtDescripcion_REQ.BackgroundImage = Nothing
        Me.TxtDescripcion_REQ.Name = "TxtDescripcion_REQ"
        '
        'BtnGuardar
        '
        Me.BtnGuardar.AccessibleDescription = Nothing
        Me.BtnGuardar.AccessibleName = Nothing
        resources.ApplyResources(Me.BtnGuardar, "BtnGuardar")
        Me.BtnGuardar.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.BtnGuardar.BackgroundImage = Nothing
        Me.BtnGuardar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnGuardar.FlatAppearance.BorderSize = 0
        Me.BtnGuardar.Font = Nothing
        Me.BtnGuardar.ForeColor = System.Drawing.Color.White
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AccessibleDescription = Nothing
        Me.Label3.AccessibleName = Nothing
        resources.ApplyResources(Me.Label3, "Label3")
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(172, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.Label3.Name = "Label3"
        '
        'Label5
        '
        Me.Label5.AccessibleDescription = Nothing
        Me.Label5.AccessibleName = Nothing
        resources.ApplyResources(Me.Label5, "Label5")
        Me.Label5.Name = "Label5"
        '
        'TxtID
        '
        Me.TxtID.AccessibleDescription = Nothing
        Me.TxtID.AccessibleName = Nothing
        resources.ApplyResources(Me.TxtID, "TxtID")
        Me.TxtID.BackgroundImage = Nothing
        Me.TxtID.Name = "TxtID"
        Me.TxtID.ReadOnly = True
        '
        'Label6
        '
        Me.Label6.AccessibleDescription = Nothing
        Me.Label6.AccessibleName = Nothing
        resources.ApplyResources(Me.Label6, "Label6")
        Me.Label6.Name = "Label6"
        '
        'TxtPrecio_NUM_REQ
        '
        Me.TxtPrecio_NUM_REQ.AccessibleDescription = Nothing
        Me.TxtPrecio_NUM_REQ.AccessibleName = Nothing
        resources.ApplyResources(Me.TxtPrecio_NUM_REQ, "TxtPrecio_NUM_REQ")
        Me.TxtPrecio_NUM_REQ.BackgroundImage = Nothing
        Me.TxtPrecio_NUM_REQ.Name = "TxtPrecio_NUM_REQ"
        '
        'CboCategoria_REQ
        '
        Me.CboCategoria_REQ.AccessibleDescription = Nothing
        Me.CboCategoria_REQ.AccessibleName = Nothing
        resources.ApplyResources(Me.CboCategoria_REQ, "CboCategoria_REQ")
        Me.CboCategoria_REQ.BackColor = System.Drawing.Color.White
        Me.CboCategoria_REQ.BackgroundImage = Nothing
        Me.CboCategoria_REQ.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboCategoria_REQ.FormattingEnabled = True
        Me.CboCategoria_REQ.Items.AddRange(New Object() {resources.GetString("CboCategoria_REQ.Items"), resources.GetString("CboCategoria_REQ.Items1"), resources.GetString("CboCategoria_REQ.Items2")})
        Me.CboCategoria_REQ.Name = "CboCategoria_REQ"
        '
        'Label7
        '
        Me.Label7.AccessibleDescription = Nothing
        Me.Label7.AccessibleName = Nothing
        resources.ApplyResources(Me.Label7, "Label7")
        Me.Label7.Name = "Label7"
        '
        'BtnSeleccionarFoto
        '
        Me.BtnSeleccionarFoto.AccessibleDescription = Nothing
        Me.BtnSeleccionarFoto.AccessibleName = Nothing
        resources.ApplyResources(Me.BtnSeleccionarFoto, "BtnSeleccionarFoto")
        Me.BtnSeleccionarFoto.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(161, Byte), Integer))
        Me.BtnSeleccionarFoto.BackgroundImage = Nothing
        Me.BtnSeleccionarFoto.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnSeleccionarFoto.FlatAppearance.BorderSize = 0
        Me.BtnSeleccionarFoto.ForeColor = System.Drawing.Color.White
        Me.BtnSeleccionarFoto.Name = "BtnSeleccionarFoto"
        Me.BtnSeleccionarFoto.UseVisualStyleBackColor = False
        '
        'DgvEtapas
        '
        Me.DgvEtapas.AccessibleDescription = Nothing
        Me.DgvEtapas.AccessibleName = Nothing
        Me.DgvEtapas.AllowUserToAddRows = False
        Me.DgvEtapas.AllowUserToDeleteRows = False
        resources.ApplyResources(Me.DgvEtapas, "DgvEtapas")
        Me.DgvEtapas.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(149, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.DgvEtapas.BackgroundImage = Nothing
        Me.DgvEtapas.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DgvEtapas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvEtapas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Numero, Me.ID, Me.Nombre, Me.Descripcion, Me.Duracion})
        Me.DgvEtapas.Font = Nothing
        Me.DgvEtapas.Name = "DgvEtapas"
        Me.DgvEtapas.ReadOnly = True
        '
        'Numero
        '
        Me.Numero.DataPropertyName = "Numero"
        resources.ApplyResources(Me.Numero, "Numero")
        Me.Numero.Name = "Numero"
        Me.Numero.ReadOnly = True
        '
        'ID
        '
        Me.ID.DataPropertyName = "ID"
        resources.ApplyResources(Me.ID, "ID")
        Me.ID.Name = "ID"
        Me.ID.ReadOnly = True
        '
        'Nombre
        '
        Me.Nombre.DataPropertyName = "Nombre"
        resources.ApplyResources(Me.Nombre, "Nombre")
        Me.Nombre.Name = "Nombre"
        Me.Nombre.ReadOnly = True
        '
        'Descripcion
        '
        Me.Descripcion.DataPropertyName = "Descripcion"
        resources.ApplyResources(Me.Descripcion, "Descripcion")
        Me.Descripcion.Name = "Descripcion"
        Me.Descripcion.ReadOnly = True
        '
        'Duracion
        '
        Me.Duracion.DataPropertyName = "Duracion"
        resources.ApplyResources(Me.Duracion, "Duracion")
        Me.Duracion.Name = "Duracion"
        Me.Duracion.ReadOnly = True
        '
        'Label8
        '
        Me.Label8.AccessibleDescription = Nothing
        Me.Label8.AccessibleName = Nothing
        resources.ApplyResources(Me.Label8, "Label8")
        Me.Label8.Name = "Label8"
        '
        'CboCrianza
        '
        Me.CboCrianza.AccessibleDescription = Nothing
        Me.CboCrianza.AccessibleName = Nothing
        resources.ApplyResources(Me.CboCrianza, "CboCrianza")
        Me.CboCrianza.BackColor = System.Drawing.Color.White
        Me.CboCrianza.BackgroundImage = Nothing
        Me.CboCrianza.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboCrianza.FormattingEnabled = True
        Me.CboCrianza.Items.AddRange(New Object() {resources.GetString("CboCrianza.Items"), resources.GetString("CboCrianza.Items1")})
        Me.CboCrianza.Name = "CboCrianza"
        '
        'Label9
        '
        Me.Label9.AccessibleDescription = Nothing
        Me.Label9.AccessibleName = Nothing
        resources.ApplyResources(Me.Label9, "Label9")
        Me.Label9.Name = "Label9"
        '
        'CboEmbotellamiento
        '
        Me.CboEmbotellamiento.AccessibleDescription = Nothing
        Me.CboEmbotellamiento.AccessibleName = Nothing
        resources.ApplyResources(Me.CboEmbotellamiento, "CboEmbotellamiento")
        Me.CboEmbotellamiento.BackColor = System.Drawing.Color.White
        Me.CboEmbotellamiento.BackgroundImage = Nothing
        Me.CboEmbotellamiento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboEmbotellamiento.FormattingEnabled = True
        Me.CboEmbotellamiento.Items.AddRange(New Object() {resources.GetString("CboEmbotellamiento.Items"), resources.GetString("CboEmbotellamiento.Items1"), resources.GetString("CboEmbotellamiento.Items2"), resources.GetString("CboEmbotellamiento.Items3"), resources.GetString("CboEmbotellamiento.Items4"), resources.GetString("CboEmbotellamiento.Items5"), resources.GetString("CboEmbotellamiento.Items6")})
        Me.CboEmbotellamiento.Name = "CboEmbotellamiento"
        '
        'BtnAgregarEtapa
        '
        Me.BtnAgregarEtapa.AccessibleDescription = Nothing
        Me.BtnAgregarEtapa.AccessibleName = Nothing
        resources.ApplyResources(Me.BtnAgregarEtapa, "BtnAgregarEtapa")
        Me.BtnAgregarEtapa.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(161, Byte), Integer))
        Me.BtnAgregarEtapa.BackgroundImage = Nothing
        Me.BtnAgregarEtapa.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnAgregarEtapa.FlatAppearance.BorderSize = 0
        Me.BtnAgregarEtapa.ForeColor = System.Drawing.Color.White
        Me.BtnAgregarEtapa.Name = "BtnAgregarEtapa"
        Me.BtnAgregarEtapa.UseVisualStyleBackColor = False
        '
        'BtnEliminarEtapa
        '
        Me.BtnEliminarEtapa.AccessibleDescription = Nothing
        Me.BtnEliminarEtapa.AccessibleName = Nothing
        resources.ApplyResources(Me.BtnEliminarEtapa, "BtnEliminarEtapa")
        Me.BtnEliminarEtapa.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(161, Byte), Integer))
        Me.BtnEliminarEtapa.BackgroundImage = Nothing
        Me.BtnEliminarEtapa.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnEliminarEtapa.FlatAppearance.BorderSize = 0
        Me.BtnEliminarEtapa.ForeColor = System.Drawing.Color.White
        Me.BtnEliminarEtapa.Name = "BtnEliminarEtapa"
        Me.BtnEliminarEtapa.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AccessibleDescription = Nothing
        Me.Label4.AccessibleName = Nothing
        resources.ApplyResources(Me.Label4, "Label4")
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(149, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.Label4.Name = "Label4"
        '
        'Label10
        '
        Me.Label10.AccessibleDescription = Nothing
        Me.Label10.AccessibleName = Nothing
        resources.ApplyResources(Me.Label10, "Label10")
        Me.Label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(149, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.Label10.Name = "Label10"
        '
        'BtnVolver
        '
        Me.BtnVolver.AccessibleDescription = Nothing
        Me.BtnVolver.AccessibleName = Nothing
        resources.ApplyResources(Me.BtnVolver, "BtnVolver")
        Me.BtnVolver.BackgroundImage = Nothing
        Me.BtnVolver.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnVolver.Font = Nothing
        Me.BtnVolver.Image = Global.SIGESVI.My.Resources.Resources.icons8_go_back_50__1_
        Me.BtnVolver.ImageLocation = Nothing
        Me.BtnVolver.Name = "BtnVolver"
        Me.BtnVolver.TabStop = False
        '
        'PicFoto
        '
        Me.PicFoto.AccessibleDescription = Nothing
        Me.PicFoto.AccessibleName = Nothing
        resources.ApplyResources(Me.PicFoto, "PicFoto")
        Me.PicFoto.BackColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(149, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.PicFoto.BackgroundImage = Nothing
        Me.PicFoto.Font = Nothing
        Me.PicFoto.ImageLocation = Nothing
        Me.PicFoto.Name = "PicFoto"
        Me.PicFoto.TabStop = False
        '
        'OfdImagen
        '
        resources.ApplyResources(Me.OfdImagen, "OfdImagen")
        '
        'FrmProductoFinal
        '
        Me.AccessibleDescription = Nothing
        Me.AccessibleName = Nothing
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.BackgroundImage = Nothing
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.BtnVolver)
        Me.Controls.Add(Me.BtnEliminarEtapa)
        Me.Controls.Add(Me.BtnAgregarEtapa)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.CboEmbotellamiento)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.CboCrianza)
        Me.Controls.Add(Me.DgvEtapas)
        Me.Controls.Add(Me.BtnSeleccionarFoto)
        Me.Controls.Add(Me.PicFoto)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.CboCategoria_REQ)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TxtPrecio_NUM_REQ)
        Me.Controls.Add(Me.TxtID)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.BtnGuardar)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TxtDescripcion_REQ)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxtNombre_REQ)
        Me.Font = Nothing
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = Nothing
        Me.Name = "FrmProductoFinal"
        CType(Me.DgvEtapas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnVolver, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicFoto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TxtNombre_REQ As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TxtDescripcion_REQ As System.Windows.Forms.TextBox
    Friend WithEvents BtnGuardar As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TxtID As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TxtPrecio_NUM_REQ As System.Windows.Forms.TextBox
    Friend WithEvents CboCategoria_REQ As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents PicFoto As System.Windows.Forms.PictureBox
    Friend WithEvents BtnSeleccionarFoto As System.Windows.Forms.Button
    Friend WithEvents DgvEtapas As System.Windows.Forms.DataGridView
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents CboCrianza As System.Windows.Forms.ComboBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents CboEmbotellamiento As System.Windows.Forms.ComboBox
    Friend WithEvents BtnAgregarEtapa As System.Windows.Forms.Button
    Friend WithEvents BtnEliminarEtapa As System.Windows.Forms.Button
    Friend WithEvents BtnVolver As System.Windows.Forms.PictureBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Numero As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Nombre As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Descripcion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Duracion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents OfdImagen As System.Windows.Forms.OpenFileDialog
End Class
