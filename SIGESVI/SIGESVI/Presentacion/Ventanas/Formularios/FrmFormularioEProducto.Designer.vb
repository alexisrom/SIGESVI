<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmFormularioEProducto
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
        Me.LbNuevaEtapa = New System.Windows.Forms.LinkLabel
        Me.Label4 = New System.Windows.Forms.Label
        Me.DgvEtapasElaboracion = New System.Windows.Forms.DataGridView
        Me.Label18 = New System.Windows.Forms.Label
        Me.TxtID_NUM_REQ = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.TxtPrecio_NUM_REQ = New System.Windows.Forms.TextBox
        Me.BtnSeleccionarImagen = New System.Windows.Forms.Button
        Me.Label17 = New System.Windows.Forms.Label
        Me.TxtTextoGuia = New System.Windows.Forms.TextBox
        Me.CboEmbotellamiento = New System.Windows.Forms.ComboBox
        Me.Label16 = New System.Windows.Forms.Label
        Me.CboCrianza = New System.Windows.Forms.ComboBox
        Me.Label15 = New System.Windows.Forms.Label
        Me.CboCalidad = New System.Windows.Forms.ComboBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.CboCepas = New System.Windows.Forms.ComboBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.PbFoto = New System.Windows.Forms.PictureBox
        Me.CboTipoProducto = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.TxtDescripcion_REQ = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.TxtNombre_REQ = New System.Windows.Forms.TextBox
        Me.BtnGuardar = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.OfdSeleccionarImagen = New System.Windows.Forms.OpenFileDialog
        CType(Me.DgvEtapasElaboracion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PbFoto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LbNuevaEtapa
        '
        Me.LbNuevaEtapa.AutoSize = True
        Me.LbNuevaEtapa.Location = New System.Drawing.Point(254, 373)
        Me.LbNuevaEtapa.Name = "LbNuevaEtapa"
        Me.LbNuevaEtapa.Size = New System.Drawing.Size(107, 13)
        Me.LbNuevaEtapa.TabIndex = 126
        Me.LbNuevaEtapa.TabStop = True
        Me.LbNuevaEtapa.Text = "Agregar nueva etapa"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(135, 373)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(113, 13)
        Me.Label4.TabIndex = 125
        Me.Label4.Text = "Etapas de elaboración"
        '
        'DgvEtapasElaboracion
        '
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgvEtapasElaboracion.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DgvEtapasElaboracion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DgvEtapasElaboracion.DefaultCellStyle = DataGridViewCellStyle2
        Me.DgvEtapasElaboracion.Location = New System.Drawing.Point(138, 389)
        Me.DgvEtapasElaboracion.Name = "DgvEtapasElaboracion"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgvEtapasElaboracion.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.DgvEtapasElaboracion.Size = New System.Drawing.Size(837, 212)
        Me.DgvEtapasElaboracion.TabIndex = 124
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(135, 91)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(18, 13)
        Me.Label18.TabIndex = 123
        Me.Label18.Text = "ID"
        '
        'TxtID_NUM_REQ
        '
        Me.TxtID_NUM_REQ.Location = New System.Drawing.Point(138, 107)
        Me.TxtID_NUM_REQ.Name = "TxtID_NUM_REQ"
        Me.TxtID_NUM_REQ.ReadOnly = True
        Me.TxtID_NUM_REQ.Size = New System.Drawing.Size(32, 20)
        Me.TxtID_NUM_REQ.TabIndex = 122
        Me.TxtID_NUM_REQ.Text = "0"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(384, 91)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(37, 13)
        Me.Label5.TabIndex = 119
        Me.Label5.Text = "Precio"
        '
        'TxtPrecio_NUM_REQ
        '
        Me.TxtPrecio_NUM_REQ.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPrecio_NUM_REQ.Location = New System.Drawing.Point(377, 107)
        Me.TxtPrecio_NUM_REQ.Name = "TxtPrecio_NUM_REQ"
        Me.TxtPrecio_NUM_REQ.Size = New System.Drawing.Size(64, 24)
        Me.TxtPrecio_NUM_REQ.TabIndex = 118
        '
        'BtnSeleccionarImagen
        '
        Me.BtnSeleccionarImagen.Location = New System.Drawing.Point(887, 186)
        Me.BtnSeleccionarImagen.Name = "BtnSeleccionarImagen"
        Me.BtnSeleccionarImagen.Size = New System.Drawing.Size(88, 23)
        Me.BtnSeleccionarImagen.TabIndex = 117
        Me.BtnSeleccionarImagen.Text = "Seleccionar"
        Me.BtnSeleccionarImagen.UseVisualStyleBackColor = True
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(15, 251)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(117, 13)
        Me.Label17.TabIndex = 116
        Me.Label17.Text = "Texto de guia al cliente"
        '
        'TxtTextoGuia
        '
        Me.TxtTextoGuia.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTextoGuia.Location = New System.Drawing.Point(138, 251)
        Me.TxtTextoGuia.Multiline = True
        Me.TxtTextoGuia.Name = "TxtTextoGuia"
        Me.TxtTextoGuia.Size = New System.Drawing.Size(303, 98)
        Me.TxtTextoGuia.TabIndex = 115
        '
        'CboEmbotellamiento
        '
        Me.CboEmbotellamiento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboEmbotellamiento.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboEmbotellamiento.FormattingEnabled = True
        Me.CboEmbotellamiento.Items.AddRange(New Object() {"2", "1.5", "1", "3/4", "1/2"})
        Me.CboEmbotellamiento.Location = New System.Drawing.Point(704, 270)
        Me.CboEmbotellamiento.Name = "CboEmbotellamiento"
        Me.CboEmbotellamiento.Size = New System.Drawing.Size(45, 26)
        Me.CboEmbotellamiento.TabIndex = 114
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(481, 270)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(99, 13)
        Me.Label16.TabIndex = 113
        Me.Label16.Text = "Embotellamiento (L)"
        '
        'CboCrianza
        '
        Me.CboCrianza.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboCrianza.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboCrianza.FormattingEnabled = True
        Me.CboCrianza.Items.AddRange(New Object() {"Roble Americano", "Roble Frances"})
        Me.CboCrianza.Location = New System.Drawing.Point(571, 227)
        Me.CboCrianza.Name = "CboCrianza"
        Me.CboCrianza.Size = New System.Drawing.Size(178, 26)
        Me.CboCrianza.TabIndex = 112
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(481, 227)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(42, 13)
        Me.Label15.TabIndex = 111
        Me.Label15.Text = "Crianza"
        '
        'CboCalidad
        '
        Me.CboCalidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboCalidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboCalidad.FormattingEnabled = True
        Me.CboCalidad.Items.AddRange(New Object() {"Yema", "Lagrima"})
        Me.CboCalidad.Location = New System.Drawing.Point(641, 185)
        Me.CboCalidad.Name = "CboCalidad"
        Me.CboCalidad.Size = New System.Drawing.Size(108, 26)
        Me.CboCalidad.TabIndex = 109
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(481, 185)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(42, 13)
        Me.Label9.TabIndex = 110
        Me.Label9.Text = "Calidad"
        '
        'CboCepas
        '
        Me.CboCepas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboCepas.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboCepas.FormattingEnabled = True
        Me.CboCepas.Items.AddRange(New Object() {"Cabernet Sauvignon", "Cabernet", "Tannat", "Chardonnay"})
        Me.CboCepas.Location = New System.Drawing.Point(571, 145)
        Me.CboCepas.Name = "CboCepas"
        Me.CboCepas.Size = New System.Drawing.Size(178, 26)
        Me.CboCepas.TabIndex = 107
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(481, 152)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 13)
        Me.Label3.TabIndex = 108
        Me.Label3.Text = "Tipo de Cepa"
        '
        'PbFoto
        '
        Me.PbFoto.BackColor = System.Drawing.SystemColors.ControlDark
        Me.PbFoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PbFoto.Location = New System.Drawing.Point(887, 107)
        Me.PbFoto.Name = "PbFoto"
        Me.PbFoto.Size = New System.Drawing.Size(88, 73)
        Me.PbFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PbFoto.TabIndex = 106
        Me.PbFoto.TabStop = False
        '
        'CboTipoProducto
        '
        Me.CboTipoProducto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboTipoProducto.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboTipoProducto.FormattingEnabled = True
        Me.CboTipoProducto.Items.AddRange(New Object() {"Materia Prima", "Producto Intermedio", "Producto Final"})
        Me.CboTipoProducto.Location = New System.Drawing.Point(571, 107)
        Me.CboTipoProducto.Name = "CboTipoProducto"
        Me.CboTipoProducto.Size = New System.Drawing.Size(178, 26)
        Me.CboTipoProducto.TabIndex = 103
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(57, 154)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 13)
        Me.Label1.TabIndex = 102
        Me.Label1.Text = "Descripción"
        '
        'TxtDescripcion_REQ
        '
        Me.TxtDescripcion_REQ.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDescripcion_REQ.Location = New System.Drawing.Point(138, 147)
        Me.TxtDescripcion_REQ.Multiline = True
        Me.TxtDescripcion_REQ.Name = "TxtDescripcion_REQ"
        Me.TxtDescripcion_REQ.Size = New System.Drawing.Size(303, 91)
        Me.TxtDescripcion_REQ.TabIndex = 101
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(190, 91)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(44, 13)
        Me.Label8.TabIndex = 100
        Me.Label8.Text = "Nombre"
        '
        'TxtNombre_REQ
        '
        Me.TxtNombre_REQ.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNombre_REQ.Location = New System.Drawing.Point(183, 107)
        Me.TxtNombre_REQ.Name = "TxtNombre_REQ"
        Me.TxtNombre_REQ.Size = New System.Drawing.Size(178, 24)
        Me.TxtNombre_REQ.TabIndex = 99
        '
        'BtnGuardar
        '
        Me.BtnGuardar.Location = New System.Drawing.Point(138, 616)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(85, 38)
        Me.BtnGuardar.TabIndex = 96
        Me.BtnGuardar.Text = "Guardar"
        Me.BtnGuardar.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(254, 616)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(85, 38)
        Me.Button1.TabIndex = 127
        Me.Button1.Text = "Cancelar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(367, 616)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(85, 38)
        Me.Button2.TabIndex = 128
        Me.Button2.Text = "Limpiar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'OfdSeleccionarImagen
        '
        Me.OfdSeleccionarImagen.Filter = "JPEG|*.JPG|PNG|*.PNG"
        Me.OfdSeleccionarImagen.Title = "Seleccionar imagen de Producto"
        '
        'FrmFormularioEProducto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1122, 677)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.LbNuevaEtapa)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.DgvEtapasElaboracion)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.TxtID_NUM_REQ)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TxtPrecio_NUM_REQ)
        Me.Controls.Add(Me.BtnSeleccionarImagen)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.TxtTextoGuia)
        Me.Controls.Add(Me.CboEmbotellamiento)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.CboCrianza)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.CboCalidad)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.CboCepas)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.PbFoto)
        Me.Controls.Add(Me.CboTipoProducto)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxtDescripcion_REQ)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.TxtNombre_REQ)
        Me.Controls.Add(Me.BtnGuardar)
        Me.Name = "FrmFormularioEProducto"
        Me.Text = "FrmFormularioEProducto"
        CType(Me.DgvEtapasElaboracion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PbFoto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LbNuevaEtapa As System.Windows.Forms.LinkLabel
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents TxtID_NUM_REQ As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TxtPrecio_NUM_REQ As System.Windows.Forms.TextBox
    Friend WithEvents BtnSeleccionarImagen As System.Windows.Forms.Button
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents TxtTextoGuia As System.Windows.Forms.TextBox
    Friend WithEvents CboEmbotellamiento As System.Windows.Forms.ComboBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents CboCrianza As System.Windows.Forms.ComboBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents CboCalidad As System.Windows.Forms.ComboBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents CboCepas As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents PbFoto As System.Windows.Forms.PictureBox
    Friend WithEvents CboTipoProducto As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TxtDescripcion_REQ As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents TxtNombre_REQ As System.Windows.Forms.TextBox
    Friend WithEvents BtnGuardar As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents OfdSeleccionarImagen As System.Windows.Forms.OpenFileDialog
    Public WithEvents DgvEtapasElaboracion As System.Windows.Forms.DataGridView
End Class
