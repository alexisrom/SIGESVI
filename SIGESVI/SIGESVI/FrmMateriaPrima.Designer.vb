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
        Me.Label7 = New System.Windows.Forms.Label
        Me.CboCepas = New System.Windows.Forms.ComboBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.TxtPrecio_NUM_REQ = New System.Windows.Forms.TextBox
        Me.TxtID = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.BtnGuardar = New System.Windows.Forms.Button
        Me.Label2 = New System.Windows.Forms.Label
        Me.TxtDescripcion_REQ = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.TxtNombre_REQ = New System.Windows.Forms.TextBox
        Me.BtnSeleccionarFoto = New System.Windows.Forms.Button
        Me.Label3 = New System.Windows.Forms.Label
        Me.PicVolver = New System.Windows.Forms.PictureBox
        Me.PicFoto = New System.Windows.Forms.PictureBox
        CType(Me.PicVolver, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicFoto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.Label7.Location = New System.Drawing.Point(318, 330)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(44, 20)
        Me.Label7.TabIndex = 33
        Me.Label7.Text = "CEPA"
        '
        'CboCepas
        '
        Me.CboCepas.BackColor = System.Drawing.Color.White
        Me.CboCepas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboCepas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CboCepas.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.CboCepas.FormattingEnabled = True
        Me.CboCepas.Items.AddRange(New Object() {"Tinto", "Rosado", "Blanco"})
        Me.CboCepas.Location = New System.Drawing.Point(378, 327)
        Me.CboCepas.Name = "CboCepas"
        Me.CboCepas.Size = New System.Drawing.Size(237, 28)
        Me.CboCepas.TabIndex = 32
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.Label6.Location = New System.Drawing.Point(304, 292)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(58, 20)
        Me.Label6.TabIndex = 31
        Me.Label6.Text = "PRECIO"
        '
        'TxtPrecio_NUM_REQ
        '
        Me.TxtPrecio_NUM_REQ.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.TxtPrecio_NUM_REQ.Location = New System.Drawing.Point(378, 286)
        Me.TxtPrecio_NUM_REQ.Name = "TxtPrecio_NUM_REQ"
        Me.TxtPrecio_NUM_REQ.Size = New System.Drawing.Size(237, 27)
        Me.TxtPrecio_NUM_REQ.TabIndex = 30
        '
        'TxtID
        '
        Me.TxtID.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.TxtID.Location = New System.Drawing.Point(378, 151)
        Me.TxtID.Name = "TxtID"
        Me.TxtID.Size = New System.Drawing.Size(237, 27)
        Me.TxtID.TabIndex = 29
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.Label5.Location = New System.Drawing.Point(338, 160)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(24, 20)
        Me.Label5.TabIndex = 28
        Me.Label5.Text = "ID"
        '
        'BtnGuardar
        '
        Me.BtnGuardar.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.BtnGuardar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnGuardar.FlatAppearance.BorderSize = 0
        Me.BtnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnGuardar.ForeColor = System.Drawing.Color.White
        Me.BtnGuardar.Location = New System.Drawing.Point(378, 382)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(237, 34)
        Me.BtnGuardar.TabIndex = 27
        Me.BtnGuardar.Text = "GUARDAR"
        Me.BtnGuardar.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.Label2.Location = New System.Drawing.Point(261, 240)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(101, 20)
        Me.Label2.TabIndex = 26
        Me.Label2.Text = "DESCRIPCIÓN"
        '
        'TxtDescripcion_REQ
        '
        Me.TxtDescripcion_REQ.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.TxtDescripcion_REQ.Location = New System.Drawing.Point(378, 233)
        Me.TxtDescripcion_REQ.Multiline = True
        Me.TxtDescripcion_REQ.Name = "TxtDescripcion_REQ"
        Me.TxtDescripcion_REQ.Size = New System.Drawing.Size(237, 36)
        Me.TxtDescripcion_REQ.TabIndex = 25
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.Label1.Location = New System.Drawing.Point(292, 200)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 20)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "NOMBRE"
        '
        'TxtNombre_REQ
        '
        Me.TxtNombre_REQ.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.TxtNombre_REQ.Location = New System.Drawing.Point(378, 192)
        Me.TxtNombre_REQ.Name = "TxtNombre_REQ"
        Me.TxtNombre_REQ.Size = New System.Drawing.Size(237, 27)
        Me.TxtNombre_REQ.TabIndex = 23
        '
        'BtnSeleccionarFoto
        '
        Me.BtnSeleccionarFoto.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(161, Byte), Integer))
        Me.BtnSeleccionarFoto.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnSeleccionarFoto.FlatAppearance.BorderSize = 0
        Me.BtnSeleccionarFoto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSeleccionarFoto.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSeleccionarFoto.ForeColor = System.Drawing.Color.White
        Me.BtnSeleccionarFoto.Location = New System.Drawing.Point(667, 259)
        Me.BtnSeleccionarFoto.Name = "BtnSeleccionarFoto"
        Me.BtnSeleccionarFoto.Size = New System.Drawing.Size(100, 28)
        Me.BtnSeleccionarFoto.TabIndex = 36
        Me.BtnSeleccionarFoto.Text = "SELECCIONAR"
        Me.BtnSeleccionarFoto.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 16.0!)
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(172, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(419, 19)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(275, 30)
        Me.Label3.TabIndex = 34
        Me.Label3.Text = "AGREGAR MATERIA PRIMA"
        '
        'PicVolver
        '
        Me.PicVolver.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PicVolver.Image = Global.SIGESVI.My.Resources.Resources.icons8_go_back_50__1_
        Me.PicVolver.Location = New System.Drawing.Point(27, 19)
        Me.PicVolver.Name = "PicVolver"
        Me.PicVolver.Size = New System.Drawing.Size(40, 40)
        Me.PicVolver.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PicVolver.TabIndex = 37
        Me.PicVolver.TabStop = False
        '
        'PicFoto
        '
        Me.PicFoto.BackColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(149, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.PicFoto.Location = New System.Drawing.Point(667, 151)
        Me.PicFoto.Name = "PicFoto"
        Me.PicFoto.Size = New System.Drawing.Size(100, 100)
        Me.PicFoto.TabIndex = 35
        Me.PicFoto.TabStop = False
        '
        'FrmMateriaPrima
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1095, 557)
        Me.Controls.Add(Me.PicVolver)
        Me.Controls.Add(Me.BtnSeleccionarFoto)
        Me.Controls.Add(Me.PicFoto)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.CboCepas)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TxtPrecio_NUM_REQ)
        Me.Controls.Add(Me.TxtID)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.BtnGuardar)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TxtDescripcion_REQ)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxtNombre_REQ)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmMateriaPrima"
        Me.Text = "FrmMateriaPrima"
        CType(Me.PicVolver, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicFoto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents CboCepas As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TxtPrecio_NUM_REQ As System.Windows.Forms.TextBox
    Friend WithEvents TxtID As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents BtnGuardar As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TxtDescripcion_REQ As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TxtNombre_REQ As System.Windows.Forms.TextBox
    Friend WithEvents BtnSeleccionarFoto As System.Windows.Forms.Button
    Friend WithEvents PicFoto As System.Windows.Forms.PictureBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents PicVolver As System.Windows.Forms.PictureBox
End Class
