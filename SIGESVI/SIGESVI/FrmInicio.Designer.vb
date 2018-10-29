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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmInicio))
        Me.TmrFechaHora = New System.Windows.Forms.Timer(Me.components)
        Me.Timerclima = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.LabelUbicación = New System.Windows.Forms.Label
        Me.WebBrowser2 = New System.Windows.Forms.WebBrowser
        Me.PnlRecordatorios = New System.Windows.Forms.FlowLayoutPanel
        Me.PnlAlarmas = New System.Windows.Forms.FlowLayoutPanel
        Me.Labelhumedad = New System.Windows.Forms.Label
        Me.Labeltemp = New System.Windows.Forms.Label
        Me.pbclima = New System.Windows.Forms.PictureBox
        Me.LbCerrarSesion = New System.Windows.Forms.LinkLabel
        Me.LblCargo = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.LblHora = New System.Windows.Forms.Label
        Me.Panel1.SuspendLayout()
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
        Me.Panel1.AccessibleDescription = Nothing
        Me.Panel1.AccessibleName = Nothing
        resources.ApplyResources(Me.Panel1, "Panel1")
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.BackgroundImage = Global.SIGESVI.My.Resources.Resources.bmaurvhz
        Me.Panel1.Controls.Add(Me.LabelUbicación)
        Me.Panel1.Controls.Add(Me.WebBrowser2)
        Me.Panel1.Controls.Add(Me.PnlRecordatorios)
        Me.Panel1.Controls.Add(Me.PnlAlarmas)
        Me.Panel1.Controls.Add(Me.Labelhumedad)
        Me.Panel1.Controls.Add(Me.Labeltemp)
        Me.Panel1.Controls.Add(Me.pbclima)
        Me.Panel1.Controls.Add(Me.LbCerrarSesion)
        Me.Panel1.Controls.Add(Me.LblCargo)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.LblHora)
        Me.Panel1.Font = Nothing
        Me.Panel1.Name = "Panel1"
        '
        'LabelUbicación
        '
        Me.LabelUbicación.AccessibleDescription = Nothing
        Me.LabelUbicación.AccessibleName = Nothing
        resources.ApplyResources(Me.LabelUbicación, "LabelUbicación")
        Me.LabelUbicación.ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.LabelUbicación.Name = "LabelUbicación"
        '
        'WebBrowser2
        '
        Me.WebBrowser2.AccessibleDescription = Nothing
        Me.WebBrowser2.AccessibleName = Nothing
        resources.ApplyResources(Me.WebBrowser2, "WebBrowser2")
        Me.WebBrowser2.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser2.Name = "WebBrowser2"
        '
        'PnlRecordatorios
        '
        Me.PnlRecordatorios.AccessibleDescription = Nothing
        Me.PnlRecordatorios.AccessibleName = Nothing
        resources.ApplyResources(Me.PnlRecordatorios, "PnlRecordatorios")
        Me.PnlRecordatorios.BackgroundImage = Nothing
        Me.PnlRecordatorios.Font = Nothing
        Me.PnlRecordatorios.Name = "PnlRecordatorios"
        '
        'PnlAlarmas
        '
        Me.PnlAlarmas.AccessibleDescription = Nothing
        Me.PnlAlarmas.AccessibleName = Nothing
        resources.ApplyResources(Me.PnlAlarmas, "PnlAlarmas")
        Me.PnlAlarmas.BackgroundImage = Nothing
        Me.PnlAlarmas.Font = Nothing
        Me.PnlAlarmas.Name = "PnlAlarmas"
        '
        'Labelhumedad
        '
        Me.Labelhumedad.AccessibleDescription = Nothing
        Me.Labelhumedad.AccessibleName = Nothing
        resources.ApplyResources(Me.Labelhumedad, "Labelhumedad")
        Me.Labelhumedad.ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.Labelhumedad.Name = "Labelhumedad"
        '
        'Labeltemp
        '
        Me.Labeltemp.AccessibleDescription = Nothing
        Me.Labeltemp.AccessibleName = Nothing
        resources.ApplyResources(Me.Labeltemp, "Labeltemp")
        Me.Labeltemp.ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.Labeltemp.Name = "Labeltemp"
        '
        'pbclima
        '
        Me.pbclima.AccessibleDescription = Nothing
        Me.pbclima.AccessibleName = Nothing
        resources.ApplyResources(Me.pbclima, "pbclima")
        Me.pbclima.BackgroundImage = Nothing
        Me.pbclima.Font = Nothing
        Me.pbclima.ImageLocation = Nothing
        Me.pbclima.Name = "pbclima"
        Me.pbclima.TabStop = False
        '
        'LbCerrarSesion
        '
        Me.LbCerrarSesion.AccessibleDescription = Nothing
        Me.LbCerrarSesion.AccessibleName = Nothing
        resources.ApplyResources(Me.LbCerrarSesion, "LbCerrarSesion")
        Me.LbCerrarSesion.LinkColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.LbCerrarSesion.Name = "LbCerrarSesion"
        Me.LbCerrarSesion.TabStop = True
        '
        'LblCargo
        '
        Me.LblCargo.AccessibleDescription = Nothing
        Me.LblCargo.AccessibleName = Nothing
        resources.ApplyResources(Me.LblCargo, "LblCargo")
        Me.LblCargo.ForeColor = System.Drawing.Color.White
        Me.LblCargo.Name = "LblCargo"
        '
        'PictureBox1
        '
        Me.PictureBox1.AccessibleDescription = Nothing
        Me.PictureBox1.AccessibleName = Nothing
        resources.ApplyResources(Me.PictureBox1, "PictureBox1")
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImage = Nothing
        Me.PictureBox1.Font = Nothing
        Me.PictureBox1.Image = Global.SIGESVI.My.Resources.Resources.user
        Me.PictureBox1.ImageLocation = Nothing
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.TabStop = False
        '
        'LblHora
        '
        Me.LblHora.AccessibleDescription = Nothing
        Me.LblHora.AccessibleName = Nothing
        resources.ApplyResources(Me.LblHora, "LblHora")
        Me.LblHora.BackColor = System.Drawing.Color.Transparent
        Me.LblHora.ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.LblHora.Name = "LblHora"
        '
        'FrmInicio
        '
        Me.AccessibleDescription = Nothing
        Me.AccessibleName = Nothing
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Nothing
        Me.Controls.Add(Me.Panel1)
        Me.Font = Nothing
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = Nothing
        Me.Name = "FrmInicio"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.pbclima, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TmrFechaHora As System.Windows.Forms.Timer
    Friend WithEvents Timerclima As System.Windows.Forms.Timer
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents PnlRecordatorios As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents PnlAlarmas As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents Labelhumedad As System.Windows.Forms.Label
    Friend WithEvents Labeltemp As System.Windows.Forms.Label
    Friend WithEvents LbCerrarSesion As System.Windows.Forms.LinkLabel
    Friend WithEvents LblCargo As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents LblHora As System.Windows.Forms.Label
    Friend WithEvents WebBrowser2 As System.Windows.Forms.WebBrowser
    Friend WithEvents pbclima As System.Windows.Forms.PictureBox
    Friend WithEvents LabelUbicación As System.Windows.Forms.Label
End Class
