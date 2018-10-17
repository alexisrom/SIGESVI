<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMateriaPrima
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
        Me.Button1 = New System.Windows.Forms.Button
        Me.BtnSeleccionarImagen = New System.Windows.Forms.Button
        Me.CboCepas = New System.Windows.Forms.ComboBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.PbFoto = New System.Windows.Forms.PictureBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.TxtDescripcion_REQ = New System.Windows.Forms.TextBox
        Me.BtnGuardar = New System.Windows.Forms.Button
        Me.Label18 = New System.Windows.Forms.Label
        Me.TxtID = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.TxtPrecio_NUM_REQ = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.TxtNombre_REQ = New System.Windows.Forms.TextBox
        CType(Me.PbFoto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(263, 310)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(85, 38)
        Me.Button1.TabIndex = 148
        Me.Button1.Text = "Cancelar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'BtnSeleccionarImagen
        '
        Me.BtnSeleccionarImagen.Location = New System.Drawing.Point(507, 128)
        Me.BtnSeleccionarImagen.Name = "BtnSeleccionarImagen"
        Me.BtnSeleccionarImagen.Size = New System.Drawing.Size(88, 23)
        Me.BtnSeleccionarImagen.TabIndex = 144
        Me.BtnSeleccionarImagen.Text = "Seleccionar"
        Me.BtnSeleccionarImagen.UseVisualStyleBackColor = True
        '
        'CboCepas
        '
        Me.CboCepas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboCepas.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboCepas.FormattingEnabled = True
        Me.CboCepas.Location = New System.Drawing.Point(287, 189)
        Me.CboCepas.Name = "CboCepas"
        Me.CboCepas.Size = New System.Drawing.Size(178, 26)
        Me.CboCepas.TabIndex = 134
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(197, 196)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 13)
        Me.Label3.TabIndex = 135
        Me.Label3.Text = "Tipo de Cepa"
        '
        'PbFoto
        '
        Me.PbFoto.BackColor = System.Drawing.SystemColors.ControlDark
        Me.PbFoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PbFoto.Location = New System.Drawing.Point(507, 49)
        Me.PbFoto.Name = "PbFoto"
        Me.PbFoto.Size = New System.Drawing.Size(88, 73)
        Me.PbFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PbFoto.TabIndex = 133
        Me.PbFoto.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(81, 86)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 13)
        Me.Label1.TabIndex = 132
        Me.Label1.Text = "Descripción"
        '
        'TxtDescripcion_REQ
        '
        Me.TxtDescripcion_REQ.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDescripcion_REQ.Location = New System.Drawing.Point(162, 79)
        Me.TxtDescripcion_REQ.Multiline = True
        Me.TxtDescripcion_REQ.Name = "TxtDescripcion_REQ"
        Me.TxtDescripcion_REQ.Size = New System.Drawing.Size(303, 91)
        Me.TxtDescripcion_REQ.TabIndex = 131
        '
        'BtnGuardar
        '
        Me.BtnGuardar.Location = New System.Drawing.Point(161, 310)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(85, 38)
        Me.BtnGuardar.TabIndex = 130
        Me.BtnGuardar.Text = "Guardar"
        Me.BtnGuardar.UseVisualStyleBackColor = True
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(159, 33)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(18, 13)
        Me.Label18.TabIndex = 154
        Me.Label18.Text = "ID"
        '
        'TxtID
        '
        Me.TxtID.Location = New System.Drawing.Point(162, 49)
        Me.TxtID.Name = "TxtID"
        Me.TxtID.ReadOnly = True
        Me.TxtID.Size = New System.Drawing.Size(32, 20)
        Me.TxtID.TabIndex = 153
        Me.TxtID.Text = "0"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(408, 33)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(37, 13)
        Me.Label5.TabIndex = 152
        Me.Label5.Text = "Precio"
        '
        'TxtPrecio_NUM_REQ
        '
        Me.TxtPrecio_NUM_REQ.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPrecio_NUM_REQ.Location = New System.Drawing.Point(401, 49)
        Me.TxtPrecio_NUM_REQ.Name = "TxtPrecio_NUM_REQ"
        Me.TxtPrecio_NUM_REQ.Size = New System.Drawing.Size(64, 24)
        Me.TxtPrecio_NUM_REQ.TabIndex = 151
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(214, 33)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(44, 13)
        Me.Label8.TabIndex = 150
        Me.Label8.Text = "Nombre"
        '
        'TxtNombre_REQ
        '
        Me.TxtNombre_REQ.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNombre_REQ.Location = New System.Drawing.Point(207, 49)
        Me.TxtNombre_REQ.Name = "TxtNombre_REQ"
        Me.TxtNombre_REQ.Size = New System.Drawing.Size(178, 24)
        Me.TxtNombre_REQ.TabIndex = 149
        '
        'FrmMateriaPrima
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(805, 381)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.TxtID)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TxtPrecio_NUM_REQ)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.TxtNombre_REQ)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.BtnSeleccionarImagen)
        Me.Controls.Add(Me.CboCepas)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.PbFoto)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxtDescripcion_REQ)
        Me.Controls.Add(Me.BtnGuardar)
        Me.Name = "FrmMateriaPrima"
        Me.Text = "FrmMateriaPrima"
        CType(Me.PbFoto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents BtnSeleccionarImagen As System.Windows.Forms.Button
    Friend WithEvents CboCepas As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents PbFoto As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TxtDescripcion_REQ As System.Windows.Forms.TextBox
    Friend WithEvents BtnGuardar As System.Windows.Forms.Button
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TxtPrecio_NUM_REQ As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents TxtNombre_REQ As System.Windows.Forms.TextBox
    Public WithEvents TxtID As System.Windows.Forms.TextBox
End Class
