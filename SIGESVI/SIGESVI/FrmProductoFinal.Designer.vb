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
        CType(Me.DgvEtapas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnVolver, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicFoto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TxtNombre_REQ
        '
        Me.TxtNombre_REQ.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.TxtNombre_REQ.Location = New System.Drawing.Point(195, 147)
        Me.TxtNombre_REQ.Name = "TxtNombre_REQ"
        Me.TxtNombre_REQ.Size = New System.Drawing.Size(237, 27)
        Me.TxtNombre_REQ.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.Label1.Location = New System.Drawing.Point(109, 155)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "NOMBRE"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.Label2.Location = New System.Drawing.Point(78, 195)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(101, 20)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "DESCRIPCIÓN"
        '
        'TxtDescripcion_REQ
        '
        Me.TxtDescripcion_REQ.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.TxtDescripcion_REQ.Location = New System.Drawing.Point(195, 188)
        Me.TxtDescripcion_REQ.Multiline = True
        Me.TxtDescripcion_REQ.Name = "TxtDescripcion_REQ"
        Me.TxtDescripcion_REQ.Size = New System.Drawing.Size(237, 36)
        Me.TxtDescripcion_REQ.TabIndex = 2
        '
        'BtnGuardar
        '
        Me.BtnGuardar.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.BtnGuardar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnGuardar.FlatAppearance.BorderSize = 0
        Me.BtnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnGuardar.ForeColor = System.Drawing.Color.White
        Me.BtnGuardar.Location = New System.Drawing.Point(195, 421)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(237, 34)
        Me.BtnGuardar.TabIndex = 4
        Me.BtnGuardar.Text = "GUARDAR"
        Me.BtnGuardar.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 16.0!)
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(172, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(368, 20)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(292, 30)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "AGREGAR PRODUCTO FINAL"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.Label5.Location = New System.Drawing.Point(155, 115)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(24, 20)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "ID"
        '
        'TxtID
        '
        Me.TxtID.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.TxtID.Location = New System.Drawing.Point(195, 106)
        Me.TxtID.Name = "TxtID"
        Me.TxtID.ReadOnly = True
        Me.TxtID.Size = New System.Drawing.Size(58, 27)
        Me.TxtID.TabIndex = 11
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.Label6.Location = New System.Drawing.Point(121, 247)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(58, 20)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "PRECIO"
        '
        'TxtPrecio_NUM_REQ
        '
        Me.TxtPrecio_NUM_REQ.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.TxtPrecio_NUM_REQ.Location = New System.Drawing.Point(195, 241)
        Me.TxtPrecio_NUM_REQ.Name = "TxtPrecio_NUM_REQ"
        Me.TxtPrecio_NUM_REQ.Size = New System.Drawing.Size(237, 27)
        Me.TxtPrecio_NUM_REQ.TabIndex = 12
        '
        'CboCategoria_REQ
        '
        Me.CboCategoria_REQ.BackColor = System.Drawing.Color.White
        Me.CboCategoria_REQ.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboCategoria_REQ.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CboCategoria_REQ.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.CboCategoria_REQ.FormattingEnabled = True
        Me.CboCategoria_REQ.Items.AddRange(New Object() {"Tinto", "Rosado", "Blanco"})
        Me.CboCategoria_REQ.Location = New System.Drawing.Point(195, 282)
        Me.CboCategoria_REQ.Name = "CboCategoria_REQ"
        Me.CboCategoria_REQ.Size = New System.Drawing.Size(237, 28)
        Me.CboCategoria_REQ.TabIndex = 14
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.Label7.Location = New System.Drawing.Point(91, 287)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(88, 20)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "CATEGORÍA"
        '
        'BtnSeleccionarFoto
        '
        Me.BtnSeleccionarFoto.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(161, Byte), Integer))
        Me.BtnSeleccionarFoto.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnSeleccionarFoto.FlatAppearance.BorderSize = 0
        Me.BtnSeleccionarFoto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSeleccionarFoto.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSeleccionarFoto.ForeColor = System.Drawing.Color.White
        Me.BtnSeleccionarFoto.Location = New System.Drawing.Point(471, 255)
        Me.BtnSeleccionarFoto.Name = "BtnSeleccionarFoto"
        Me.BtnSeleccionarFoto.Size = New System.Drawing.Size(100, 28)
        Me.BtnSeleccionarFoto.TabIndex = 17
        Me.BtnSeleccionarFoto.Text = "SELECCIONAR"
        Me.BtnSeleccionarFoto.UseVisualStyleBackColor = False
        '
        'DgvEtapas
        '
        Me.DgvEtapas.AllowUserToAddRows = False
        Me.DgvEtapas.AllowUserToDeleteRows = False
        Me.DgvEtapas.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(149, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.DgvEtapas.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DgvEtapas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvEtapas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Numero, Me.ID, Me.Nombre, Me.Descripcion, Me.Duracion})
        Me.DgvEtapas.Location = New System.Drawing.Point(623, 147)
        Me.DgvEtapas.Name = "DgvEtapas"
        Me.DgvEtapas.ReadOnly = True
        Me.DgvEtapas.Size = New System.Drawing.Size(328, 215)
        Me.DgvEtapas.TabIndex = 18
        '
        'Numero
        '
        Me.Numero.DataPropertyName = "Numero"
        Me.Numero.HeaderText = "NRO"
        Me.Numero.Name = "Numero"
        Me.Numero.ReadOnly = True
        '
        'ID
        '
        Me.ID.DataPropertyName = "ID"
        Me.ID.HeaderText = "ID"
        Me.ID.Name = "ID"
        Me.ID.ReadOnly = True
        Me.ID.Visible = False
        '
        'Nombre
        '
        Me.Nombre.DataPropertyName = "Nombre"
        Me.Nombre.HeaderText = "Nombre"
        Me.Nombre.Name = "Nombre"
        Me.Nombre.ReadOnly = True
        '
        'Descripcion
        '
        Me.Descripcion.DataPropertyName = "Descripcion"
        Me.Descripcion.HeaderText = "Descripcion"
        Me.Descripcion.Name = "Descripcion"
        Me.Descripcion.ReadOnly = True
        '
        'Duracion
        '
        Me.Duracion.DataPropertyName = "Duracion"
        Me.Duracion.HeaderText = "Duración"
        Me.Duracion.Name = "Duracion"
        Me.Duracion.ReadOnly = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.Label8.Location = New System.Drawing.Point(108, 332)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(53, 20)
        Me.Label8.TabIndex = 20
        Me.Label8.Text = "ROBLE"
        '
        'CboCrianza
        '
        Me.CboCrianza.BackColor = System.Drawing.Color.White
        Me.CboCrianza.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboCrianza.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CboCrianza.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.CboCrianza.FormattingEnabled = True
        Me.CboCrianza.Items.AddRange(New Object() {"Americano", "Frances"})
        Me.CboCrianza.Location = New System.Drawing.Point(195, 324)
        Me.CboCrianza.Name = "CboCrianza"
        Me.CboCrianza.Size = New System.Drawing.Size(237, 28)
        Me.CboCrianza.TabIndex = 19
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.Label9.Location = New System.Drawing.Point(34, 367)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(145, 20)
        Me.Label9.TabIndex = 22
        Me.Label9.Text = "EMBOTELLAMIENTO"
        '
        'CboEmbotellamiento
        '
        Me.CboEmbotellamiento.BackColor = System.Drawing.Color.White
        Me.CboEmbotellamiento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboEmbotellamiento.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CboEmbotellamiento.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.CboEmbotellamiento.FormattingEnabled = True
        Me.CboEmbotellamiento.Items.AddRange(New Object() {"5", "2.5", "2", "1.5", "1", "3/4", "1/2"})
        Me.CboEmbotellamiento.Location = New System.Drawing.Point(195, 366)
        Me.CboEmbotellamiento.Name = "CboEmbotellamiento"
        Me.CboEmbotellamiento.Size = New System.Drawing.Size(237, 28)
        Me.CboEmbotellamiento.TabIndex = 21
        '
        'BtnAgregarEtapa
        '
        Me.BtnAgregarEtapa.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(161, Byte), Integer))
        Me.BtnAgregarEtapa.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnAgregarEtapa.FlatAppearance.BorderSize = 0
        Me.BtnAgregarEtapa.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAgregarEtapa.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAgregarEtapa.ForeColor = System.Drawing.Color.White
        Me.BtnAgregarEtapa.Location = New System.Drawing.Point(623, 377)
        Me.BtnAgregarEtapa.Name = "BtnAgregarEtapa"
        Me.BtnAgregarEtapa.Size = New System.Drawing.Size(113, 28)
        Me.BtnAgregarEtapa.TabIndex = 23
        Me.BtnAgregarEtapa.Text = "AGREGAR ETAPA"
        Me.BtnAgregarEtapa.UseVisualStyleBackColor = False
        '
        'BtnEliminarEtapa
        '
        Me.BtnEliminarEtapa.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(161, Byte), Integer))
        Me.BtnEliminarEtapa.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnEliminarEtapa.FlatAppearance.BorderSize = 0
        Me.BtnEliminarEtapa.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnEliminarEtapa.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEliminarEtapa.ForeColor = System.Drawing.Color.White
        Me.BtnEliminarEtapa.Location = New System.Drawing.Point(838, 377)
        Me.BtnEliminarEtapa.Name = "BtnEliminarEtapa"
        Me.BtnEliminarEtapa.Size = New System.Drawing.Size(113, 28)
        Me.BtnEliminarEtapa.TabIndex = 24
        Me.BtnEliminarEtapa.Text = "ELIMINAR ETAPA"
        Me.BtnEliminarEtapa.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(149, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(619, 109)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(88, 20)
        Me.Label4.TabIndex = 26
        Me.Label4.Text = "Elaboración"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.Label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(149, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.Label10.Location = New System.Drawing.Point(467, 109)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(39, 20)
        Me.Label10.TabIndex = 27
        Me.Label10.Text = "Foto"
        '
        'BtnVolver
        '
        Me.BtnVolver.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnVolver.Image = Global.SIGESVI.My.Resources.Resources.icons8_go_back_50__1_
        Me.BtnVolver.Location = New System.Drawing.Point(38, 20)
        Me.BtnVolver.Name = "BtnVolver"
        Me.BtnVolver.Size = New System.Drawing.Size(40, 40)
        Me.BtnVolver.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BtnVolver.TabIndex = 25
        Me.BtnVolver.TabStop = False
        '
        'PicFoto
        '
        Me.PicFoto.BackColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(149, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.PicFoto.Location = New System.Drawing.Point(471, 147)
        Me.PicFoto.Name = "PicFoto"
        Me.PicFoto.Size = New System.Drawing.Size(100, 100)
        Me.PicFoto.TabIndex = 16
        Me.PicFoto.TabStop = False
        '
        'FrmProductoFinal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1000, 485)
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
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmProductoFinal"
        Me.Text = "FrmEProducto"
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
End Class
