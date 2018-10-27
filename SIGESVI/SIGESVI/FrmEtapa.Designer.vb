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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmEtapa))
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
        Me.Label6.AccessibleDescription = Nothing
        Me.Label6.AccessibleName = Nothing
        resources.ApplyResources(Me.Label6, "Label6")
        Me.Label6.Name = "Label6"
        '
        'TxtNumero_NUM_REQ
        '
        Me.TxtNumero_NUM_REQ.AccessibleDescription = Nothing
        Me.TxtNumero_NUM_REQ.AccessibleName = Nothing
        resources.ApplyResources(Me.TxtNumero_NUM_REQ, "TxtNumero_NUM_REQ")
        Me.TxtNumero_NUM_REQ.BackgroundImage = Nothing
        Me.TxtNumero_NUM_REQ.Name = "TxtNumero_NUM_REQ"
        '
        'Label2
        '
        Me.Label2.AccessibleDescription = Nothing
        Me.Label2.AccessibleName = Nothing
        resources.ApplyResources(Me.Label2, "Label2")
        Me.Label2.Name = "Label2"
        '
        'TxtDescripcion_REQ
        '
        Me.TxtDescripcion_REQ.AccessibleDescription = Nothing
        Me.TxtDescripcion_REQ.AccessibleName = Nothing
        resources.ApplyResources(Me.TxtDescripcion_REQ, "TxtDescripcion_REQ")
        Me.TxtDescripcion_REQ.BackgroundImage = Nothing
        Me.TxtDescripcion_REQ.Name = "TxtDescripcion_REQ"
        '
        'Label1
        '
        Me.Label1.AccessibleDescription = Nothing
        Me.Label1.AccessibleName = Nothing
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.Name = "Label1"
        '
        'TxtNombre_REQ
        '
        Me.TxtNombre_REQ.AccessibleDescription = Nothing
        Me.TxtNombre_REQ.AccessibleName = Nothing
        resources.ApplyResources(Me.TxtNombre_REQ, "TxtNombre_REQ")
        Me.TxtNombre_REQ.BackgroundImage = Nothing
        Me.TxtNombre_REQ.Name = "TxtNombre_REQ"
        '
        'Label3
        '
        Me.Label3.AccessibleDescription = Nothing
        Me.Label3.AccessibleName = Nothing
        resources.ApplyResources(Me.Label3, "Label3")
        Me.Label3.Name = "Label3"
        '
        'TxtDuracion_NUM_REQ
        '
        Me.TxtDuracion_NUM_REQ.AccessibleDescription = Nothing
        Me.TxtDuracion_NUM_REQ.AccessibleName = Nothing
        resources.ApplyResources(Me.TxtDuracion_NUM_REQ, "TxtDuracion_NUM_REQ")
        Me.TxtDuracion_NUM_REQ.BackgroundImage = Nothing
        Me.TxtDuracion_NUM_REQ.Name = "TxtDuracion_NUM_REQ"
        '
        'BtnAgregar
        '
        Me.BtnAgregar.AccessibleDescription = Nothing
        Me.BtnAgregar.AccessibleName = Nothing
        resources.ApplyResources(Me.BtnAgregar, "BtnAgregar")
        Me.BtnAgregar.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.BtnAgregar.BackgroundImage = Nothing
        Me.BtnAgregar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnAgregar.FlatAppearance.BorderSize = 0
        Me.BtnAgregar.Font = Nothing
        Me.BtnAgregar.ForeColor = System.Drawing.Color.White
        Me.BtnAgregar.Name = "BtnAgregar"
        Me.BtnAgregar.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AccessibleDescription = Nothing
        Me.Label4.AccessibleName = Nothing
        resources.ApplyResources(Me.Label4, "Label4")
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(172, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.Label4.Name = "Label4"
        '
        'Panel1
        '
        Me.Panel1.AccessibleDescription = Nothing
        Me.Panel1.AccessibleName = Nothing
        resources.ApplyResources(Me.Panel1, "Panel1")
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(149, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.Panel1.BackgroundImage = Nothing
        Me.Panel1.Controls.Add(Me.BtnAgregarRecordatorio)
        Me.Panel1.Controls.Add(Me.LstRecordatorios)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.TxtDia)
        Me.Panel1.Controls.Add(Me.TxtMensaje)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Font = Nothing
        Me.Panel1.Name = "Panel1"
        '
        'BtnAgregarRecordatorio
        '
        Me.BtnAgregarRecordatorio.AccessibleDescription = Nothing
        Me.BtnAgregarRecordatorio.AccessibleName = Nothing
        resources.ApplyResources(Me.BtnAgregarRecordatorio, "BtnAgregarRecordatorio")
        Me.BtnAgregarRecordatorio.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(161, Byte), Integer))
        Me.BtnAgregarRecordatorio.BackgroundImage = Nothing
        Me.BtnAgregarRecordatorio.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnAgregarRecordatorio.FlatAppearance.BorderSize = 0
        Me.BtnAgregarRecordatorio.ForeColor = System.Drawing.Color.White
        Me.BtnAgregarRecordatorio.Name = "BtnAgregarRecordatorio"
        Me.BtnAgregarRecordatorio.UseVisualStyleBackColor = False
        '
        'LstRecordatorios
        '
        Me.LstRecordatorios.AccessibleDescription = Nothing
        Me.LstRecordatorios.AccessibleName = Nothing
        resources.ApplyResources(Me.LstRecordatorios, "LstRecordatorios")
        Me.LstRecordatorios.BackgroundImage = Nothing
        Me.LstRecordatorios.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.LstRecordatorios.FormattingEnabled = True
        Me.LstRecordatorios.Name = "LstRecordatorios"
        '
        'Label5
        '
        Me.Label5.AccessibleDescription = Nothing
        Me.Label5.AccessibleName = Nothing
        resources.ApplyResources(Me.Label5, "Label5")
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.Label5.Name = "Label5"
        '
        'Label8
        '
        Me.Label8.AccessibleDescription = Nothing
        Me.Label8.AccessibleName = Nothing
        resources.ApplyResources(Me.Label8, "Label8")
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.Label8.Name = "Label8"
        '
        'TxtDia
        '
        Me.TxtDia.AccessibleDescription = Nothing
        Me.TxtDia.AccessibleName = Nothing
        resources.ApplyResources(Me.TxtDia, "TxtDia")
        Me.TxtDia.BackgroundImage = Nothing
        Me.TxtDia.Name = "TxtDia"
        '
        'TxtMensaje
        '
        Me.TxtMensaje.AccessibleDescription = Nothing
        Me.TxtMensaje.AccessibleName = Nothing
        resources.ApplyResources(Me.TxtMensaje, "TxtMensaje")
        Me.TxtMensaje.BackgroundImage = Nothing
        Me.TxtMensaje.Name = "TxtMensaje"
        '
        'Label7
        '
        Me.Label7.AccessibleDescription = Nothing
        Me.Label7.AccessibleName = Nothing
        resources.ApplyResources(Me.Label7, "Label7")
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.Label7.Name = "Label7"
        '
        'FrmEtapa
        '
        Me.AccessibleDescription = Nothing
        Me.AccessibleName = Nothing
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.BackgroundImage = Nothing
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
        Me.Font = Nothing
        Me.Icon = Nothing
        Me.Name = "FrmEtapa"
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
