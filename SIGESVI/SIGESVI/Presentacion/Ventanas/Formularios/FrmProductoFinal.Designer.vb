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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.Label18 = New System.Windows.Forms.Label
        Me.TxtID = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.TxtPrecio_NUM_REQ = New System.Windows.Forms.TextBox
        Me.Label17 = New System.Windows.Forms.Label
        Me.TxtTextoGuia = New System.Windows.Forms.TextBox
        Me.CboEmbotellamiento = New System.Windows.Forms.ComboBox
        Me.Label16 = New System.Windows.Forms.Label
        Me.CboCrianza = New System.Windows.Forms.ComboBox
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.TxtDescripcion_REQ = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.TxtNombre_REQ = New System.Windows.Forms.TextBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.BtnGuardar = New System.Windows.Forms.Button
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel
        Me.LbNuevaEtapa = New System.Windows.Forms.LinkLabel
        Me.Label4 = New System.Windows.Forms.Label
        Me.DgvEtapasElaboracion = New System.Windows.Forms.DataGridView
        Me.UCSelectorImagen = New SIGESVI.SelectorImagen
        CType(Me.DgvEtapasElaboracion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(122, 58)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(18, 13)
        Me.Label18.TabIndex = 144
        Me.Label18.Text = "ID"
        '
        'TxtID
        '
        Me.TxtID.Location = New System.Drawing.Point(125, 74)
        Me.TxtID.Name = "TxtID"
        Me.TxtID.ReadOnly = True
        Me.TxtID.Size = New System.Drawing.Size(32, 20)
        Me.TxtID.TabIndex = 143
        Me.TxtID.Text = "0"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(371, 58)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(37, 13)
        Me.Label5.TabIndex = 142
        Me.Label5.Text = "Precio"
        '
        'TxtPrecio_NUM_REQ
        '
        Me.TxtPrecio_NUM_REQ.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPrecio_NUM_REQ.Location = New System.Drawing.Point(364, 74)
        Me.TxtPrecio_NUM_REQ.Name = "TxtPrecio_NUM_REQ"
        Me.TxtPrecio_NUM_REQ.Size = New System.Drawing.Size(64, 24)
        Me.TxtPrecio_NUM_REQ.TabIndex = 141
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(2, 218)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(117, 13)
        Me.Label17.TabIndex = 139
        Me.Label17.Text = "Texto de guia al cliente"
        '
        'TxtTextoGuia
        '
        Me.TxtTextoGuia.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTextoGuia.Location = New System.Drawing.Point(125, 218)
        Me.TxtTextoGuia.Multiline = True
        Me.TxtTextoGuia.Name = "TxtTextoGuia"
        Me.TxtTextoGuia.Size = New System.Drawing.Size(303, 98)
        Me.TxtTextoGuia.TabIndex = 138
        '
        'CboEmbotellamiento
        '
        Me.CboEmbotellamiento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboEmbotellamiento.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboEmbotellamiento.FormattingEnabled = True
        Me.CboEmbotellamiento.Items.AddRange(New Object() {"5", "3", "2", "1.5", "1", "3/4", "1/2"})
        Me.CboEmbotellamiento.Location = New System.Drawing.Point(383, 378)
        Me.CboEmbotellamiento.Name = "CboEmbotellamiento"
        Me.CboEmbotellamiento.Size = New System.Drawing.Size(45, 26)
        Me.CboEmbotellamiento.TabIndex = 137
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(160, 378)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(99, 13)
        Me.Label16.TabIndex = 136
        Me.Label16.Text = "Embotellamiento (L)"
        '
        'CboCrianza
        '
        Me.CboCrianza.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboCrianza.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboCrianza.FormattingEnabled = True
        Me.CboCrianza.Items.AddRange(New Object() {"Roble Americano", "Roble Frances"})
        Me.CboCrianza.Location = New System.Drawing.Point(250, 335)
        Me.CboCrianza.Name = "CboCrianza"
        Me.CboCrianza.Size = New System.Drawing.Size(178, 26)
        Me.CboCrianza.TabIndex = 135
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(160, 335)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(42, 13)
        Me.Label15.TabIndex = 134
        Me.Label15.Text = "Crianza"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(44, 121)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 13)
        Me.Label1.TabIndex = 127
        Me.Label1.Text = "Descripción"
        '
        'TxtDescripcion_REQ
        '
        Me.TxtDescripcion_REQ.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDescripcion_REQ.Location = New System.Drawing.Point(125, 114)
        Me.TxtDescripcion_REQ.Multiline = True
        Me.TxtDescripcion_REQ.Name = "TxtDescripcion_REQ"
        Me.TxtDescripcion_REQ.Size = New System.Drawing.Size(303, 91)
        Me.TxtDescripcion_REQ.TabIndex = 126
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(177, 58)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(44, 13)
        Me.Label8.TabIndex = 125
        Me.Label8.Text = "Nombre"
        '
        'TxtNombre_REQ
        '
        Me.TxtNombre_REQ.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNombre_REQ.Location = New System.Drawing.Point(170, 74)
        Me.TxtNombre_REQ.Name = "TxtNombre_REQ"
        Me.TxtNombre_REQ.Size = New System.Drawing.Size(178, 24)
        Me.TxtNombre_REQ.TabIndex = 124
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(150, 497)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(85, 38)
        Me.Button1.TabIndex = 146
        Me.Button1.Text = "Cancelar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'BtnGuardar
        '
        Me.BtnGuardar.Location = New System.Drawing.Point(34, 497)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(85, 38)
        Me.BtnGuardar.TabIndex = 145
        Me.BtnGuardar.Text = "Guardar"
        Me.BtnGuardar.UseVisualStyleBackColor = True
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(1014, 246)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(73, 13)
        Me.LinkLabel1.TabIndex = 150
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Eliminar etapa"
        '
        'LbNuevaEtapa
        '
        Me.LbNuevaEtapa.AutoSize = True
        Me.LbNuevaEtapa.Location = New System.Drawing.Point(597, 246)
        Me.LbNuevaEtapa.Name = "LbNuevaEtapa"
        Me.LbNuevaEtapa.Size = New System.Drawing.Size(107, 13)
        Me.LbNuevaEtapa.TabIndex = 149
        Me.LbNuevaEtapa.TabStop = True
        Me.LbNuevaEtapa.Text = "Agregar nueva etapa"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(478, 246)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(113, 13)
        Me.Label4.TabIndex = 148
        Me.Label4.Text = "Etapas de elaboración"
        '
        'DgvEtapasElaboracion
        '
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgvEtapasElaboracion.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.DgvEtapasElaboracion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DgvEtapasElaboracion.DefaultCellStyle = DataGridViewCellStyle5
        Me.DgvEtapasElaboracion.Location = New System.Drawing.Point(519, 262)
        Me.DgvEtapasElaboracion.Name = "DgvEtapasElaboracion"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgvEtapasElaboracion.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.DgvEtapasElaboracion.Size = New System.Drawing.Size(568, 212)
        Me.DgvEtapasElaboracion.TabIndex = 147
        '
        'UCSelectorImagen
        '
        Me.UCSelectorImagen.Location = New System.Drawing.Point(496, 55)
        Me.UCSelectorImagen.Name = "UCSelectorImagen"
        Me.UCSelectorImagen.Size = New System.Drawing.Size(150, 150)
        Me.UCSelectorImagen.TabIndex = 151
        '
        'FrmProductoFinal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1142, 547)
        Me.Controls.Add(Me.UCSelectorImagen)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.LbNuevaEtapa)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.DgvEtapasElaboracion)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.BtnGuardar)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.TxtID)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TxtPrecio_NUM_REQ)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.TxtTextoGuia)
        Me.Controls.Add(Me.CboEmbotellamiento)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.CboCrianza)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxtDescripcion_REQ)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.TxtNombre_REQ)
        Me.Name = "FrmProductoFinal"
        Me.Text = "FrmProductoFinal"
        CType(Me.DgvEtapasElaboracion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents TxtID As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TxtPrecio_NUM_REQ As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents TxtTextoGuia As System.Windows.Forms.TextBox
    Friend WithEvents CboEmbotellamiento As System.Windows.Forms.ComboBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents CboCrianza As System.Windows.Forms.ComboBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TxtDescripcion_REQ As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents TxtNombre_REQ As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents BtnGuardar As System.Windows.Forms.Button
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
    Friend WithEvents LbNuevaEtapa As System.Windows.Forms.LinkLabel
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Public WithEvents DgvEtapasElaboracion As System.Windows.Forms.DataGridView
    Friend WithEvents UCSelectorImagen As SIGESVI.SelectorImagen
End Class
