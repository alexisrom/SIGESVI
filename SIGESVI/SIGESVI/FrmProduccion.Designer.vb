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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmProduccion))
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
        Me.Label4 = New System.Windows.Forms.Label
        Me.TxtID = New System.Windows.Forms.TextBox
        Me.BtnVolver = New System.Windows.Forms.PictureBox
        CType(Me.BtnVolver, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AccessibleDescription = Nothing
        Me.Label3.AccessibleName = Nothing
        resources.ApplyResources(Me.Label3, "Label3")
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(172, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.Label3.Name = "Label3"
        '
        'Label9
        '
        Me.Label9.AccessibleDescription = Nothing
        Me.Label9.AccessibleName = Nothing
        resources.ApplyResources(Me.Label9, "Label9")
        Me.Label9.Name = "Label9"
        '
        'Label8
        '
        Me.Label8.AccessibleDescription = Nothing
        Me.Label8.AccessibleName = Nothing
        resources.ApplyResources(Me.Label8, "Label8")
        Me.Label8.Name = "Label8"
        '
        'CboEspecificaciones
        '
        Me.CboEspecificaciones.AccessibleDescription = Nothing
        Me.CboEspecificaciones.AccessibleName = Nothing
        resources.ApplyResources(Me.CboEspecificaciones, "CboEspecificaciones")
        Me.CboEspecificaciones.BackColor = System.Drawing.Color.White
        Me.CboEspecificaciones.BackgroundImage = Nothing
        Me.CboEspecificaciones.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboEspecificaciones.FormattingEnabled = True
        Me.CboEspecificaciones.Items.AddRange(New Object() {resources.GetString("CboEspecificaciones.Items"), resources.GetString("CboEspecificaciones.Items1")})
        Me.CboEspecificaciones.Name = "CboEspecificaciones"
        '
        'BtnProgramar
        '
        Me.BtnProgramar.AccessibleDescription = Nothing
        Me.BtnProgramar.AccessibleName = Nothing
        resources.ApplyResources(Me.BtnProgramar, "BtnProgramar")
        Me.BtnProgramar.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.BtnProgramar.BackgroundImage = Nothing
        Me.BtnProgramar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnProgramar.FlatAppearance.BorderSize = 0
        Me.BtnProgramar.Font = Nothing
        Me.BtnProgramar.ForeColor = System.Drawing.Color.White
        Me.BtnProgramar.Name = "BtnProgramar"
        Me.BtnProgramar.UseVisualStyleBackColor = False
        '
        'DtpFechaInicio
        '
        Me.DtpFechaInicio.AccessibleDescription = Nothing
        Me.DtpFechaInicio.AccessibleName = Nothing
        resources.ApplyResources(Me.DtpFechaInicio, "DtpFechaInicio")
        Me.DtpFechaInicio.BackgroundImage = Nothing
        Me.DtpFechaInicio.CalendarFont = Nothing
        Me.DtpFechaInicio.CustomFormat = Nothing
        Me.DtpFechaInicio.Name = "DtpFechaInicio"
        '
        'DtpFechaFin
        '
        Me.DtpFechaFin.AccessibleDescription = Nothing
        Me.DtpFechaFin.AccessibleName = Nothing
        resources.ApplyResources(Me.DtpFechaFin, "DtpFechaFin")
        Me.DtpFechaFin.BackgroundImage = Nothing
        Me.DtpFechaFin.CalendarFont = Nothing
        Me.DtpFechaFin.CustomFormat = Nothing
        Me.DtpFechaFin.Name = "DtpFechaFin"
        '
        'Label1
        '
        Me.Label1.AccessibleDescription = Nothing
        Me.Label1.AccessibleName = Nothing
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.Name = "Label1"
        '
        'Label2
        '
        Me.Label2.AccessibleDescription = Nothing
        Me.Label2.AccessibleName = Nothing
        resources.ApplyResources(Me.Label2, "Label2")
        Me.Label2.Name = "Label2"
        '
        'TxtCantidad_NUM_REQ
        '
        Me.TxtCantidad_NUM_REQ.AccessibleDescription = Nothing
        Me.TxtCantidad_NUM_REQ.AccessibleName = Nothing
        resources.ApplyResources(Me.TxtCantidad_NUM_REQ, "TxtCantidad_NUM_REQ")
        Me.TxtCantidad_NUM_REQ.BackgroundImage = Nothing
        Me.TxtCantidad_NUM_REQ.Name = "TxtCantidad_NUM_REQ"
        '
        'Label4
        '
        Me.Label4.AccessibleDescription = Nothing
        Me.Label4.AccessibleName = Nothing
        resources.ApplyResources(Me.Label4, "Label4")
        Me.Label4.Name = "Label4"
        '
        'TxtID
        '
        Me.TxtID.AccessibleDescription = Nothing
        Me.TxtID.AccessibleName = Nothing
        resources.ApplyResources(Me.TxtID, "TxtID")
        Me.TxtID.BackgroundImage = Nothing
        Me.TxtID.Name = "TxtID"
        '
        'BtnVolver
        '
        Me.BtnVolver.AccessibleDescription = Nothing
        Me.BtnVolver.AccessibleName = Nothing
        resources.ApplyResources(Me.BtnVolver, "BtnVolver")
        Me.BtnVolver.BackgroundImage = Nothing
        Me.BtnVolver.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnVolver.Font = Nothing
        Me.BtnVolver.Image = Global.SIGESVI.My.Resources.Resources.icons8_go_back_50__1_
        Me.BtnVolver.ImageLocation = Nothing
        Me.BtnVolver.Name = "BtnVolver"
        Me.BtnVolver.TabStop = False
        '
        'FrmProduccion
        '
        Me.AccessibleDescription = Nothing
        Me.AccessibleName = Nothing
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.BackgroundImage = Nothing
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
        Me.Font = Nothing
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = Nothing
        Me.Name = "FrmProduccion"
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
