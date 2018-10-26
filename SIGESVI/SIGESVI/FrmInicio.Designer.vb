<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmInicio
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
        Me.components = New System.ComponentModel.Container
        Me.TmrFechaHora = New System.Windows.Forms.Timer(Me.components)
        Me.Timerclima = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.PictureBox3 = New System.Windows.Forms.PictureBox
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.PnlRecordatorios = New System.Windows.Forms.FlowLayoutPanel
        Me.PnlAlarmas = New System.Windows.Forms.FlowLayoutPanel
        Me.WebBrowser1 = New System.Windows.Forms.WebBrowser
        Me.Labelhumedad = New System.Windows.Forms.Label
        Me.Labeltemp = New System.Windows.Forms.Label
        Me.pbclima = New System.Windows.Forms.PictureBox
        Me.LbCerrarSesion = New System.Windows.Forms.LinkLabel
        Me.LblCargo = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.LblHora = New System.Windows.Forms.Label
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbclima, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TmrFechaHora
        '
        Me.TmrFechaHora.Enabled = True
        '
        'Timerclima
        '
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.BackgroundImage = Global.SIGESVI.My.Resources.Resources.bmaurvhz
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.PnlRecordatorios)
        Me.Panel1.Controls.Add(Me.PnlAlarmas)
        Me.Panel1.Controls.Add(Me.WebBrowser1)
        Me.Panel1.Controls.Add(Me.Labelhumedad)
        Me.Panel1.Controls.Add(Me.Labeltemp)
        Me.Panel1.Controls.Add(Me.pbclima)
        Me.Panel1.Controls.Add(Me.LbCerrarSesion)
        Me.Panel1.Controls.Add(Me.LblCargo)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.LblHora)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1317, 636)
        Me.Panel1.TabIndex = 1
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Controls.Add(Me.Label4)
        Me.Panel3.Controls.Add(Me.PictureBox3)
        Me.Panel3.Location = New System.Drawing.Point(706, 33)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(117, 160)
        Me.Panel3.TabIndex = 23
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Label1.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(161, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(0, 130)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(117, 30)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "VER (10)"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(149, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label4.Font = New System.Drawing.Font("Roboto", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(0, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(117, 30)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "ALARMAS"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.White
        Me.PictureBox3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox3.Image = Global.SIGESVI.My.Resources.Resources.exclamancion
        Me.PictureBox3.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(117, 160)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox3.TabIndex = 21
        Me.PictureBox3.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.PictureBox2)
        Me.Panel2.Location = New System.Drawing.Point(534, 32)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(117, 160)
        Me.Panel2.TabIndex = 22
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Label3.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(0, 128)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(115, 30)
        Me.Label3.TabIndex = 22
        Me.Label3.Text = "VER (10)"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.DimGray
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label2.Font = New System.Drawing.Font("Roboto", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(0, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(115, 30)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "RECORDATORIOS"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox2
        '
        Me.PictureBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox2.Image = Global.SIGESVI.My.Resources.Resources.calendar_with_day_3
        Me.PictureBox2.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(115, 158)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox2.TabIndex = 21
        Me.PictureBox2.TabStop = False
        '
        'PnlRecordatorios
        '
        Me.PnlRecordatorios.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.PnlRecordatorios.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.PnlRecordatorios.Location = New System.Drawing.Point(39, 34)
        Me.PnlRecordatorios.Name = "PnlRecordatorios"
        Me.PnlRecordatorios.Size = New System.Drawing.Size(200, 521)
        Me.PnlRecordatorios.TabIndex = 19
        '
        'PnlAlarmas
        '
        Me.PnlAlarmas.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.PnlAlarmas.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.PnlAlarmas.Location = New System.Drawing.Point(259, 34)
        Me.PnlAlarmas.Name = "PnlAlarmas"
        Me.PnlAlarmas.Size = New System.Drawing.Size(200, 521)
        Me.PnlAlarmas.TabIndex = 18
        '
        'WebBrowser1
        '
        Me.WebBrowser1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.WebBrowser1.Location = New System.Drawing.Point(1085, 571)
        Me.WebBrowser1.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser1.Name = "WebBrowser1"
        Me.WebBrowser1.Size = New System.Drawing.Size(20, 20)
        Me.WebBrowser1.TabIndex = 17
        Me.WebBrowser1.Visible = False
        '
        'Labelhumedad
        '
        Me.Labelhumedad.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Labelhumedad.AutoSize = True
        Me.Labelhumedad.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Labelhumedad.ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.Labelhumedad.Location = New System.Drawing.Point(1139, 586)
        Me.Labelhumedad.Name = "Labelhumedad"
        Me.Labelhumedad.Size = New System.Drawing.Size(116, 21)
        Me.Labelhumedad.TabIndex = 16
        Me.Labelhumedad.Text = "Humedad: 00%"
        '
        'Labeltemp
        '
        Me.Labeltemp.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Labeltemp.AutoSize = True
        Me.Labeltemp.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Labeltemp.ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.Labeltemp.Location = New System.Drawing.Point(1139, 556)
        Me.Labeltemp.Name = "Labeltemp"
        Me.Labeltemp.Size = New System.Drawing.Size(148, 21)
        Me.Labeltemp.TabIndex = 14
        Me.Labeltemp.Text = "Temperatura : 00 °C"
        '
        'pbclima
        '
        Me.pbclima.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pbclima.Location = New System.Drawing.Point(1061, 547)
        Me.pbclima.Name = "pbclima"
        Me.pbclima.Size = New System.Drawing.Size(72, 71)
        Me.pbclima.TabIndex = 13
        Me.pbclima.TabStop = False
        '
        'LbCerrarSesion
        '
        Me.LbCerrarSesion.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LbCerrarSesion.AutoSize = True
        Me.LbCerrarSesion.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbCerrarSesion.Location = New System.Drawing.Point(1173, 159)
        Me.LbCerrarSesion.Name = "LbCerrarSesion"
        Me.LbCerrarSesion.Size = New System.Drawing.Size(96, 20)
        Me.LbCerrarSesion.TabIndex = 5
        Me.LbCerrarSesion.TabStop = True
        Me.LbCerrarSesion.Text = "Cerrar Sesión"
        '
        'LblCargo
        '
        Me.LblCargo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblCargo.AutoSize = True
        Me.LblCargo.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCargo.ForeColor = System.Drawing.Color.White
        Me.LblCargo.Location = New System.Drawing.Point(1197, 125)
        Me.LblCargo.Name = "LblCargo"
        Me.LblCargo.Size = New System.Drawing.Size(49, 20)
        Me.LblCargo.TabIndex = 3
        Me.LblCargo.Text = "Cargo"
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.BackColor = System.Drawing.Color.Silver
        Me.PictureBox1.Location = New System.Drawing.Point(1179, 32)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(90, 90)
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'LblHora
        '
        Me.LblHora.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LblHora.AutoSize = True
        Me.LblHora.BackColor = System.Drawing.Color.Transparent
        Me.LblHora.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblHora.ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.LblHora.Location = New System.Drawing.Point(32, 581)
        Me.LblHora.Name = "LblHora"
        Me.LblHora.Size = New System.Drawing.Size(296, 37)
        Me.LblHora.TabIndex = 1
        Me.LblHora.Text = "00/00/00 00:00 a.m"
        '
        'FrmInicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1317, 636)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmInicio"
        Me.Text = "Inicio"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbclima, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TmrFechaHora As System.Windows.Forms.Timer
    Friend WithEvents Timerclima As System.Windows.Forms.Timer
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents PnlRecordatorios As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents PnlAlarmas As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents WebBrowser1 As System.Windows.Forms.WebBrowser
    Friend WithEvents Labelhumedad As System.Windows.Forms.Label
    Friend WithEvents Labeltemp As System.Windows.Forms.Label
    Friend WithEvents pbclima As System.Windows.Forms.PictureBox
    Friend WithEvents LbCerrarSesion As System.Windows.Forms.LinkLabel
    Friend WithEvents LblCargo As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents LblHora As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
End Class
