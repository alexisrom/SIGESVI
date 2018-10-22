<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmProduccion
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
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.CboEspecificaciones = New System.Windows.Forms.ComboBox
        Me.BtnProgramar = New System.Windows.Forms.Button
        Me.DtpFechaInicio = New System.Windows.Forms.DateTimePicker
        Me.DtpFechaFin = New System.Windows.Forms.DateTimePicker
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.TxtCantidad_NUM_REQ = New System.Windows.Forms.TextBox
        Me.BtnVolver = New System.Windows.Forms.PictureBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.TxtID = New System.Windows.Forms.TextBox
        CType(Me.BtnVolver, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 16.0!)
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(172, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(507, 25)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(228, 30)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "NUEVA PRODUCCIÓN"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.Label9.Location = New System.Drawing.Point(390, 192)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(101, 20)
        Me.Label9.TabIndex = 29
        Me.Label9.Text = "FECHA INICIO"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.Label8.Location = New System.Drawing.Point(405, 145)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(86, 20)
        Me.Label8.TabIndex = 27
        Me.Label8.Text = "PRODUCTO"
        '
        'CboEspecificaciones
        '
        Me.CboEspecificaciones.BackColor = System.Drawing.Color.White
        Me.CboEspecificaciones.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboEspecificaciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CboEspecificaciones.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.CboEspecificaciones.FormattingEnabled = True
        Me.CboEspecificaciones.Items.AddRange(New Object() {"Roble Americano", "Roble Frances"})
        Me.CboEspecificaciones.Location = New System.Drawing.Point(512, 137)
        Me.CboEspecificaciones.Name = "CboEspecificaciones"
        Me.CboEspecificaciones.Size = New System.Drawing.Size(237, 28)
        Me.CboEspecificaciones.TabIndex = 26
        '
        'BtnProgramar
        '
        Me.BtnProgramar.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.BtnProgramar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnProgramar.FlatAppearance.BorderSize = 0
        Me.BtnProgramar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnProgramar.ForeColor = System.Drawing.Color.White
        Me.BtnProgramar.Location = New System.Drawing.Point(512, 354)
        Me.BtnProgramar.Name = "BtnProgramar"
        Me.BtnProgramar.Size = New System.Drawing.Size(237, 34)
        Me.BtnProgramar.TabIndex = 23
        Me.BtnProgramar.Text = "PROGRAMAR"
        Me.BtnProgramar.UseVisualStyleBackColor = False
        '
        'DtpFechaInicio
        '
        Me.DtpFechaInicio.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DtpFechaInicio.Location = New System.Drawing.Point(512, 188)
        Me.DtpFechaInicio.Name = "DtpFechaInicio"
        Me.DtpFechaInicio.Size = New System.Drawing.Size(237, 24)
        Me.DtpFechaInicio.TabIndex = 30
        '
        'DtpFechaFin
        '
        Me.DtpFechaFin.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DtpFechaFin.Location = New System.Drawing.Point(512, 229)
        Me.DtpFechaFin.Name = "DtpFechaFin"
        Me.DtpFechaFin.Size = New System.Drawing.Size(237, 24)
        Me.DtpFechaFin.TabIndex = 32
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.Label1.Location = New System.Drawing.Point(411, 230)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 20)
        Me.Label1.TabIndex = 31
        Me.Label1.Text = "FECHA FIN"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.Label2.Location = New System.Drawing.Point(408, 276)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(83, 20)
        Me.Label2.TabIndex = 34
        Me.Label2.Text = "CANTIDAD"
        '
        'TxtCantidad_NUM_REQ
        '
        Me.TxtCantidad_NUM_REQ.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.TxtCantidad_NUM_REQ.Location = New System.Drawing.Point(512, 273)
        Me.TxtCantidad_NUM_REQ.Name = "TxtCantidad_NUM_REQ"
        Me.TxtCantidad_NUM_REQ.Size = New System.Drawing.Size(237, 27)
        Me.TxtCantidad_NUM_REQ.TabIndex = 33
        '
        'BtnVolver
        '
        Me.BtnVolver.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnVolver.Image = Global.SIGESVI.My.Resources.Resources.icons8_go_back_50__1_
        Me.BtnVolver.Location = New System.Drawing.Point(49, 25)
        Me.BtnVolver.Name = "BtnVolver"
        Me.BtnVolver.Size = New System.Drawing.Size(40, 40)
        Me.BtnVolver.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BtnVolver.TabIndex = 35
        Me.BtnVolver.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.Label4.Location = New System.Drawing.Point(467, 99)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(24, 20)
        Me.Label4.TabIndex = 37
        Me.Label4.Text = "ID"
        '
        'TxtID
        '
        Me.TxtID.Enabled = False
        Me.TxtID.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.TxtID.Location = New System.Drawing.Point(512, 96)
        Me.TxtID.Name = "TxtID"
        Me.TxtID.Size = New System.Drawing.Size(237, 27)
        Me.TxtID.TabIndex = 38
        '
        'FrmProduccion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1445, 506)
        Me.Controls.Add(Me.TxtID)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.BtnVolver)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TxtCantidad_NUM_REQ)
        Me.Controls.Add(Me.DtpFechaFin)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DtpFechaInicio)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.CboEspecificaciones)
        Me.Controls.Add(Me.BtnProgramar)
        Me.Controls.Add(Me.Label3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmProduccion"
        Me.Text = "FrmProduccion"
        CType(Me.BtnVolver, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents CboEspecificaciones As System.Windows.Forms.ComboBox
    Friend WithEvents BtnProgramar As System.Windows.Forms.Button
    Friend WithEvents DtpFechaInicio As System.Windows.Forms.DateTimePicker
    Friend WithEvents DtpFechaFin As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TxtCantidad_NUM_REQ As System.Windows.Forms.TextBox
    Friend WithEvents BtnVolver As System.Windows.Forms.PictureBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TxtID As System.Windows.Forms.TextBox
End Class
