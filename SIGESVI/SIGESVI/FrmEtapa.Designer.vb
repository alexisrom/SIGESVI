<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmEtapa
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
        Me.Label6 = New System.Windows.Forms.Label
        Me.TxtNumero_NUM_REQ = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.TxtDescripcion_REQ = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.TxtNombre_REQ = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.TxtDuracion_NUM_REQ = New System.Windows.Forms.TextBox
        Me.BtnAgregar = New System.Windows.Forms.Button
        Me.Label4 = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.BtnAgregarRecordatorio = New System.Windows.Forms.Button
        Me.LstRecordatorios = New System.Windows.Forms.ListBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.TxtDia = New System.Windows.Forms.TextBox
        Me.TxtMensaje = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.Label6.Location = New System.Drawing.Point(66, 210)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(71, 20)
        Me.Label6.TabIndex = 21
        Me.Label6.Text = "NÚMERO"
        '
        'TxtNumero_NUM_REQ
        '
        Me.TxtNumero_NUM_REQ.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.TxtNumero_NUM_REQ.Location = New System.Drawing.Point(153, 203)
        Me.TxtNumero_NUM_REQ.Name = "TxtNumero_NUM_REQ"
        Me.TxtNumero_NUM_REQ.Size = New System.Drawing.Size(237, 27)
        Me.TxtNumero_NUM_REQ.TabIndex = 20
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.Label2.Location = New System.Drawing.Point(36, 146)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(101, 20)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "DESCRIPCIÓN"
        '
        'TxtDescripcion_REQ
        '
        Me.TxtDescripcion_REQ.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.TxtDescripcion_REQ.Location = New System.Drawing.Point(153, 128)
        Me.TxtDescripcion_REQ.Multiline = True
        Me.TxtDescripcion_REQ.Name = "TxtDescripcion_REQ"
        Me.TxtDescripcion_REQ.Size = New System.Drawing.Size(237, 58)
        Me.TxtDescripcion_REQ.TabIndex = 16
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.Label1.Location = New System.Drawing.Point(67, 95)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 20)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "NOMBRE"
        '
        'TxtNombre_REQ
        '
        Me.TxtNombre_REQ.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.TxtNombre_REQ.Location = New System.Drawing.Point(153, 87)
        Me.TxtNombre_REQ.Name = "TxtNombre_REQ"
        Me.TxtNombre_REQ.Size = New System.Drawing.Size(237, 27)
        Me.TxtNombre_REQ.TabIndex = 14
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.Label3.Location = New System.Drawing.Point(53, 257)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(84, 20)
        Me.Label3.TabIndex = 23
        Me.Label3.Text = "DURACIÓN"
        '
        'TxtDuracion_NUM_REQ
        '
        Me.TxtDuracion_NUM_REQ.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.TxtDuracion_NUM_REQ.Location = New System.Drawing.Point(153, 250)
        Me.TxtDuracion_NUM_REQ.Name = "TxtDuracion_NUM_REQ"
        Me.TxtDuracion_NUM_REQ.Size = New System.Drawing.Size(237, 27)
        Me.TxtDuracion_NUM_REQ.TabIndex = 22
        '
        'BtnAgregar
        '
        Me.BtnAgregar.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.BtnAgregar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnAgregar.FlatAppearance.BorderSize = 0
        Me.BtnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAgregar.ForeColor = System.Drawing.Color.White
        Me.BtnAgregar.Location = New System.Drawing.Point(153, 294)
        Me.BtnAgregar.Name = "BtnAgregar"
        Me.BtnAgregar.Size = New System.Drawing.Size(237, 34)
        Me.BtnAgregar.TabIndex = 24
        Me.BtnAgregar.Text = "AGREGAR"
        Me.BtnAgregar.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 16.0!)
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(172, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(148, 23)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(253, 30)
        Me.Label4.TabIndex = 25
        Me.Label4.Text = "AGREGAR NUEVA ETAPA"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(149, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.Panel1.Controls.Add(Me.BtnAgregarRecordatorio)
        Me.Panel1.Controls.Add(Me.LstRecordatorios)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.TxtDia)
        Me.Panel1.Controls.Add(Me.TxtMensaje)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel1.Location = New System.Drawing.Point(463, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(312, 383)
        Me.Panel1.TabIndex = 26
        '
        'BtnAgregarRecordatorio
        '
        Me.BtnAgregarRecordatorio.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(161, Byte), Integer))
        Me.BtnAgregarRecordatorio.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnAgregarRecordatorio.FlatAppearance.BorderSize = 0
        Me.BtnAgregarRecordatorio.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAgregarRecordatorio.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAgregarRecordatorio.ForeColor = System.Drawing.Color.White
        Me.BtnAgregarRecordatorio.Location = New System.Drawing.Point(100, 198)
        Me.BtnAgregarRecordatorio.Name = "BtnAgregarRecordatorio"
        Me.BtnAgregarRecordatorio.Size = New System.Drawing.Size(190, 23)
        Me.BtnAgregarRecordatorio.TabIndex = 61
        Me.BtnAgregarRecordatorio.Text = "AGREGAR RECORDATORIO"
        Me.BtnAgregarRecordatorio.UseVisualStyleBackColor = False
        '
        'LstRecordatorios
        '
        Me.LstRecordatorios.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.LstRecordatorios.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LstRecordatorios.FormattingEnabled = True
        Me.LstRecordatorios.ItemHeight = 15
        Me.LstRecordatorios.Location = New System.Drawing.Point(100, 227)
        Me.LstRecordatorios.Name = "LstRecordatorios"
        Me.LstRecordatorios.Size = New System.Drawing.Size(190, 75)
        Me.LstRecordatorios.TabIndex = 60
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(171, 39)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(103, 15)
        Me.Label5.TabIndex = 55
        Me.Label5.Text = "RECORDATORIO"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(30, 152)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(64, 15)
        Me.Label8.TabIndex = 59
        Me.Label8.Text = "MENSAJE"
        '
        'TxtDia
        '
        Me.TxtDia.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDia.Location = New System.Drawing.Point(100, 93)
        Me.TxtDia.Multiline = True
        Me.TxtDia.Name = "TxtDia"
        Me.TxtDia.Size = New System.Drawing.Size(190, 28)
        Me.TxtDia.TabIndex = 56
        '
        'TxtMensaje
        '
        Me.TxtMensaje.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtMensaje.Location = New System.Drawing.Point(100, 136)
        Me.TxtMensaje.Multiline = True
        Me.TxtMensaje.Name = "TxtMensaje"
        Me.TxtMensaje.Size = New System.Drawing.Size(190, 56)
        Me.TxtMensaje.TabIndex = 58
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(10, 99)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(84, 15)
        Me.Label7.TabIndex = 57
        Me.Label7.Text = "DÍA DE INICIO"
        '
        'FrmEtapa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(775, 383)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.BtnAgregar)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TxtDuracion_NUM_REQ)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TxtNumero_NUM_REQ)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TxtDescripcion_REQ)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxtNombre_REQ)
        Me.Name = "FrmEtapa"
        Me.Text = "FrmEtapa"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TxtNumero_NUM_REQ As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TxtDescripcion_REQ As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TxtNombre_REQ As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TxtDuracion_NUM_REQ As System.Windows.Forms.TextBox
    Friend WithEvents BtnAgregar As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents BtnAgregarRecordatorio As System.Windows.Forms.Button
    Friend WithEvents LstRecordatorios As System.Windows.Forms.ListBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents TxtDia As System.Windows.Forms.TextBox
    Friend WithEvents TxtMensaje As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
End Class
