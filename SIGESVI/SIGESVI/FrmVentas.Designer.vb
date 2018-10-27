<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmVentas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmVentas))
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.DtpFecha = New System.Windows.Forms.DateTimePicker
        Me.LstLotes = New System.Windows.Forms.ListBox
        Me.BtnSeleccionarLotes = New System.Windows.Forms.Button
        Me.BtnNuevo = New System.Windows.Forms.Button
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.TxtCosto_NUM_REQ = New System.Windows.Forms.TextBox
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.Label3 = New System.Windows.Forms.Label
        Me.Button4 = New System.Windows.Forms.Button
        Me.BtnAgregarEtapa = New System.Windows.Forms.Button
        Me.DgvVentas = New System.Windows.Forms.DataGridView
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.DgvVentas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.AccessibleDescription = Nothing
        Me.Panel1.AccessibleName = Nothing
        resources.ApplyResources(Me.Panel1, "Panel1")
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(149, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.Panel1.BackgroundImage = Nothing
        Me.Panel1.Controls.Add(Me.DtpFecha)
        Me.Panel1.Controls.Add(Me.LstLotes)
        Me.Panel1.Controls.Add(Me.BtnSeleccionarLotes)
        Me.Panel1.Controls.Add(Me.BtnNuevo)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.TxtCosto_NUM_REQ)
        Me.Panel1.Font = Nothing
        Me.Panel1.Name = "Panel1"
        '
        'DtpFecha
        '
        Me.DtpFecha.AccessibleDescription = Nothing
        Me.DtpFecha.AccessibleName = Nothing
        resources.ApplyResources(Me.DtpFecha, "DtpFecha")
        Me.DtpFecha.BackgroundImage = Nothing
        Me.DtpFecha.CalendarFont = Nothing
        Me.DtpFecha.CustomFormat = Nothing
        Me.DtpFecha.Name = "DtpFecha"
        '
        'LstLotes
        '
        Me.LstLotes.AccessibleDescription = Nothing
        Me.LstLotes.AccessibleName = Nothing
        resources.ApplyResources(Me.LstLotes, "LstLotes")
        Me.LstLotes.BackgroundImage = Nothing
        Me.LstLotes.FormattingEnabled = True
        Me.LstLotes.Name = "LstLotes"
        '
        'BtnSeleccionarLotes
        '
        Me.BtnSeleccionarLotes.AccessibleDescription = Nothing
        Me.BtnSeleccionarLotes.AccessibleName = Nothing
        resources.ApplyResources(Me.BtnSeleccionarLotes, "BtnSeleccionarLotes")
        Me.BtnSeleccionarLotes.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(161, Byte), Integer))
        Me.BtnSeleccionarLotes.BackgroundImage = Nothing
        Me.BtnSeleccionarLotes.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnSeleccionarLotes.FlatAppearance.BorderSize = 0
        Me.BtnSeleccionarLotes.ForeColor = System.Drawing.Color.White
        Me.BtnSeleccionarLotes.Name = "BtnSeleccionarLotes"
        Me.BtnSeleccionarLotes.UseVisualStyleBackColor = False
        '
        'BtnNuevo
        '
        Me.BtnNuevo.AccessibleDescription = Nothing
        Me.BtnNuevo.AccessibleName = Nothing
        resources.ApplyResources(Me.BtnNuevo, "BtnNuevo")
        Me.BtnNuevo.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.BtnNuevo.BackgroundImage = Nothing
        Me.BtnNuevo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnNuevo.FlatAppearance.BorderSize = 0
        Me.BtnNuevo.Font = Nothing
        Me.BtnNuevo.ForeColor = System.Drawing.Color.White
        Me.BtnNuevo.Name = "BtnNuevo"
        Me.BtnNuevo.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AccessibleDescription = Nothing
        Me.Label4.AccessibleName = Nothing
        resources.ApplyResources(Me.Label4, "Label4")
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.Label4.Name = "Label4"
        '
        'Label2
        '
        Me.Label2.AccessibleDescription = Nothing
        Me.Label2.AccessibleName = Nothing
        resources.ApplyResources(Me.Label2, "Label2")
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.Label2.Name = "Label2"
        '
        'Label1
        '
        Me.Label1.AccessibleDescription = Nothing
        Me.Label1.AccessibleName = Nothing
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.Label1.Name = "Label1"
        '
        'TxtCosto_NUM_REQ
        '
        Me.TxtCosto_NUM_REQ.AccessibleDescription = Nothing
        Me.TxtCosto_NUM_REQ.AccessibleName = Nothing
        resources.ApplyResources(Me.TxtCosto_NUM_REQ, "TxtCosto_NUM_REQ")
        Me.TxtCosto_NUM_REQ.BackgroundImage = Nothing
        Me.TxtCosto_NUM_REQ.Name = "TxtCosto_NUM_REQ"
        '
        'Panel2
        '
        Me.Panel2.AccessibleDescription = Nothing
        Me.Panel2.AccessibleName = Nothing
        resources.ApplyResources(Me.Panel2, "Panel2")
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.Panel2.BackgroundImage = Nothing
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.Button4)
        Me.Panel2.Controls.Add(Me.BtnAgregarEtapa)
        Me.Panel2.Controls.Add(Me.DgvVentas)
        Me.Panel2.Font = Nothing
        Me.Panel2.Name = "Panel2"
        '
        'Label3
        '
        Me.Label3.AccessibleDescription = Nothing
        Me.Label3.AccessibleName = Nothing
        resources.ApplyResources(Me.Label3, "Label3")
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(172, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.Label3.Name = "Label3"
        '
        'Button4
        '
        Me.Button4.AccessibleDescription = Nothing
        Me.Button4.AccessibleName = Nothing
        resources.ApplyResources(Me.Button4, "Button4")
        Me.Button4.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(161, Byte), Integer))
        Me.Button4.BackgroundImage = Nothing
        Me.Button4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button4.FlatAppearance.BorderSize = 0
        Me.Button4.ForeColor = System.Drawing.Color.White
        Me.Button4.Name = "Button4"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'BtnAgregarEtapa
        '
        Me.BtnAgregarEtapa.AccessibleDescription = Nothing
        Me.BtnAgregarEtapa.AccessibleName = Nothing
        resources.ApplyResources(Me.BtnAgregarEtapa, "BtnAgregarEtapa")
        Me.BtnAgregarEtapa.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(161, Byte), Integer))
        Me.BtnAgregarEtapa.BackgroundImage = Nothing
        Me.BtnAgregarEtapa.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnAgregarEtapa.FlatAppearance.BorderSize = 0
        Me.BtnAgregarEtapa.ForeColor = System.Drawing.Color.White
        Me.BtnAgregarEtapa.Name = "BtnAgregarEtapa"
        Me.BtnAgregarEtapa.UseVisualStyleBackColor = False
        '
        'DgvVentas
        '
        Me.DgvVentas.AccessibleDescription = Nothing
        Me.DgvVentas.AccessibleName = Nothing
        resources.ApplyResources(Me.DgvVentas, "DgvVentas")
        Me.DgvVentas.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(149, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.DgvVentas.BackgroundImage = Nothing
        Me.DgvVentas.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DgvVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvVentas.Font = Nothing
        Me.DgvVentas.Name = "DgvVentas"
        '
        'FrmVentas
        '
        Me.AccessibleDescription = Nothing
        Me.AccessibleName = Nothing
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Nothing
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Font = Nothing
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = Nothing
        Me.Name = "FrmVentas"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.DgvVentas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents LstLotes As System.Windows.Forms.ListBox
    Friend WithEvents BtnSeleccionarLotes As System.Windows.Forms.Button
    Friend WithEvents BtnNuevo As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TxtCosto_NUM_REQ As System.Windows.Forms.TextBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents BtnAgregarEtapa As System.Windows.Forms.Button
    Friend WithEvents DgvVentas As System.Windows.Forms.DataGridView
    Friend WithEvents DtpFecha As System.Windows.Forms.DateTimePicker
End Class
