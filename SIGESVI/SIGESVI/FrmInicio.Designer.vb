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
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.LbCerrarSesion = New System.Windows.Forms.LinkLabel
        Me.Label1 = New System.Windows.Forms.Label
        Me.LblCargo = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.LblHora = New System.Windows.Forms.Label
        Me.Timerclima = New System.Windows.Forms.Timer(Me.components)
        Me.Labelhumedad = New System.Windows.Forms.Label
        Me.Labeltemp = New System.Windows.Forms.Label
        Me.pbclima = New System.Windows.Forms.PictureBox
        Me.WebBrowser1 = New System.Windows.Forms.WebBrowser
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbclima, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TmrFechaHora
        '
        Me.TmrFechaHora.Enabled = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.BackgroundImage = Global.SIGESVI.My.Resources.Resources.bmaurvhz
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.Controls.Add(Me.WebBrowser1)
        Me.Panel1.Controls.Add(Me.Labelhumedad)
        Me.Panel1.Controls.Add(Me.Labeltemp)
        Me.Panel1.Controls.Add(Me.pbclima)
        Me.Panel1.Controls.Add(Me.LbCerrarSesion)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.LblCargo)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.LblHora)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(813, 383)
        Me.Panel1.TabIndex = 0
        '
        'LbCerrarSesion
        '
        Me.LbCerrarSesion.AutoSize = True
        Me.LbCerrarSesion.Location = New System.Drawing.Point(688, 153)
        Me.LbCerrarSesion.Name = "LbCerrarSesion"
        Me.LbCerrarSesion.Size = New System.Drawing.Size(70, 13)
        Me.LbCerrarSesion.TabIndex = 5
        Me.LbCerrarSesion.TabStop = True
        Me.LbCerrarSesion.Text = "Cerrar Sesión"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(36, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Notificaciones"
        '
        'LblCargo
        '
        Me.LblCargo.AutoSize = True
        Me.LblCargo.ForeColor = System.Drawing.Color.White
        Me.LblCargo.Location = New System.Drawing.Point(698, 136)
        Me.LblCargo.Name = "LblCargo"
        Me.LblCargo.Size = New System.Drawing.Size(35, 13)
        Me.LblCargo.TabIndex = 3
        Me.LblCargo.Text = "Cargo"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Silver
        Me.PictureBox1.Location = New System.Drawing.Point(675, 32)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(90, 90)
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'LblHora
        '
        Me.LblHora.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblHora.AutoSize = True
        Me.LblHora.BackColor = System.Drawing.Color.Transparent
        Me.LblHora.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblHora.ForeColor = System.Drawing.Color.SkyBlue
        Me.LblHora.Location = New System.Drawing.Point(340, 313)
        Me.LblHora.Name = "LblHora"
        Me.LblHora.Size = New System.Drawing.Size(0, 46)
        Me.LblHora.TabIndex = 1
        '
        'Timerclima
        '
        '
        'Labelhumedad
        '
        Me.Labelhumedad.AutoSize = True
        Me.Labelhumedad.ForeColor = System.Drawing.Color.White
        Me.Labelhumedad.Location = New System.Drawing.Point(417, 153)
        Me.Labelhumedad.Name = "Labelhumedad"
        Me.Labelhumedad.Size = New System.Drawing.Size(79, 13)
        Me.Labelhumedad.TabIndex = 16
        Me.Labelhumedad.Text = "Humedad: 00%"
        '
        'Labeltemp
        '
        Me.Labeltemp.AutoSize = True
        Me.Labeltemp.ForeColor = System.Drawing.Color.White
        Me.Labeltemp.Location = New System.Drawing.Point(417, 127)
        Me.Labeltemp.Name = "Labeltemp"
        Me.Labeltemp.Size = New System.Drawing.Size(102, 13)
        Me.Labeltemp.TabIndex = 14
        Me.Labeltemp.Text = "Temperatura : 00 °C"
        '
        'pbclima
        '
        Me.pbclima.Location = New System.Drawing.Point(327, 78)
        Me.pbclima.Name = "pbclima"
        Me.pbclima.Size = New System.Drawing.Size(72, 71)
        Me.pbclima.TabIndex = 13
        Me.pbclima.TabStop = False
        '
        'WebBrowser1
        '
        Me.WebBrowser1.Location = New System.Drawing.Point(597, 246)
        Me.WebBrowser1.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser1.Name = "WebBrowser1"
        Me.WebBrowser1.Size = New System.Drawing.Size(20, 20)
        Me.WebBrowser1.TabIndex = 17
        Me.WebBrowser1.Visible = False
        '
        'FrmInicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(813, 383)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmInicio"
        Me.Text = "Inicio"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbclima, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TmrFechaHora As System.Windows.Forms.Timer
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents LblHora As System.Windows.Forms.Label
    Friend WithEvents LblCargo As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents LbCerrarSesion As System.Windows.Forms.LinkLabel
    Friend WithEvents Labelhumedad As System.Windows.Forms.Label
    Friend WithEvents Labeltemp As System.Windows.Forms.Label
    Friend WithEvents pbclima As System.Windows.Forms.PictureBox
    Friend WithEvents Timerclima As System.Windows.Forms.Timer
    Friend WithEvents WebBrowser1 As System.Windows.Forms.WebBrowser
End Class
