<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmTraslados
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmTraslados))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.BtnEliminarLote = New System.Windows.Forms.Button
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.CboVehiculo = New System.Windows.Forms.ComboBox
        Me.DtpFecha = New System.Windows.Forms.DateTimePicker
        Me.LstLotes = New System.Windows.Forms.ListBox
        Me.BtnAgregarLote = New System.Windows.Forms.Button
        Me.BtnNuevo = New System.Windows.Forms.Button
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.TxtDestino_REQ = New System.Windows.Forms.TextBox
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.Label3 = New System.Windows.Forms.Label
        Me.DgvTraslados = New System.Windows.Forms.DataGridView
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.DgvTraslados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.AccessibleDescription = Nothing
        Me.Panel1.AccessibleName = Nothing
        resources.ApplyResources(Me.Panel1, "Panel1")
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(149, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.Panel1.BackgroundImage = Nothing
        Me.Panel1.Controls.Add(Me.BtnEliminarLote)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.CboVehiculo)
        Me.Panel1.Controls.Add(Me.DtpFecha)
        Me.Panel1.Controls.Add(Me.LstLotes)
        Me.Panel1.Controls.Add(Me.BtnAgregarLote)
        Me.Panel1.Controls.Add(Me.BtnNuevo)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.TxtDestino_REQ)
        Me.Panel1.Font = Nothing
        Me.Panel1.Name = "Panel1"
        '
        'BtnEliminarLote
        '
        Me.BtnEliminarLote.AccessibleDescription = Nothing
        Me.BtnEliminarLote.AccessibleName = Nothing
        resources.ApplyResources(Me.BtnEliminarLote, "BtnEliminarLote")
        Me.BtnEliminarLote.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(161, Byte), Integer))
        Me.BtnEliminarLote.BackgroundImage = Nothing
        Me.BtnEliminarLote.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnEliminarLote.FlatAppearance.BorderSize = 0
        Me.BtnEliminarLote.ForeColor = System.Drawing.Color.White
        Me.BtnEliminarLote.Name = "BtnEliminarLote"
        Me.BtnEliminarLote.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.AccessibleDescription = Nothing
        Me.Label6.AccessibleName = Nothing
        resources.ApplyResources(Me.Label6, "Label6")
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.Label6.Name = "Label6"
        '
        'Label5
        '
        Me.Label5.AccessibleDescription = Nothing
        Me.Label5.AccessibleName = Nothing
        resources.ApplyResources(Me.Label5, "Label5")
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.Label5.Name = "Label5"
        '
        'CboVehiculo
        '
        Me.CboVehiculo.AccessibleDescription = Nothing
        Me.CboVehiculo.AccessibleName = Nothing
        resources.ApplyResources(Me.CboVehiculo, "CboVehiculo")
        Me.CboVehiculo.BackgroundImage = Nothing
        Me.CboVehiculo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboVehiculo.FormattingEnabled = True
        Me.CboVehiculo.Name = "CboVehiculo"
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
        'BtnAgregarLote
        '
        Me.BtnAgregarLote.AccessibleDescription = Nothing
        Me.BtnAgregarLote.AccessibleName = Nothing
        resources.ApplyResources(Me.BtnAgregarLote, "BtnAgregarLote")
        Me.BtnAgregarLote.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(161, Byte), Integer))
        Me.BtnAgregarLote.BackgroundImage = Nothing
        Me.BtnAgregarLote.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnAgregarLote.FlatAppearance.BorderSize = 0
        Me.BtnAgregarLote.ForeColor = System.Drawing.Color.White
        Me.BtnAgregarLote.Name = "BtnAgregarLote"
        Me.BtnAgregarLote.UseVisualStyleBackColor = False
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
        'TxtDestino_REQ
        '
        Me.TxtDestino_REQ.AccessibleDescription = Nothing
        Me.TxtDestino_REQ.AccessibleName = Nothing
        resources.ApplyResources(Me.TxtDestino_REQ, "TxtDestino_REQ")
        Me.TxtDestino_REQ.BackgroundImage = Nothing
        Me.TxtDestino_REQ.Name = "TxtDestino_REQ"
        '
        'Panel2
        '
        Me.Panel2.AccessibleDescription = Nothing
        Me.Panel2.AccessibleName = Nothing
        resources.ApplyResources(Me.Panel2, "Panel2")
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.Panel2.BackgroundImage = Nothing
        Me.Panel2.Controls.Add(Me.DgvTraslados)
        Me.Panel2.Controls.Add(Me.Label3)
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
        'DgvTraslados
        '
        Me.DgvTraslados.AccessibleDescription = Nothing
        Me.DgvTraslados.AccessibleName = Nothing
        resources.ApplyResources(Me.DgvTraslados, "DgvTraslados")
        Me.DgvTraslados.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(149, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.DgvTraslados.BackgroundImage = Nothing
        Me.DgvTraslados.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DgvTraslados.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(161, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(211, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgvTraslados.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DgvTraslados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(149, Byte), Integer), CType(CType(167, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DgvTraslados.DefaultCellStyle = DataGridViewCellStyle2
        Me.DgvTraslados.EnableHeadersVisualStyles = False
        Me.DgvTraslados.Font = Nothing
        Me.DgvTraslados.GridColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.DgvTraslados.MultiSelect = False
        Me.DgvTraslados.Name = "DgvTraslados"
        Me.DgvTraslados.ReadOnly = True
        Me.DgvTraslados.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(149, Byte), Integer), CType(CType(167, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(211, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgvTraslados.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(149, Byte), Integer), CType(CType(167, Byte), Integer))
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.DgvTraslados.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.DgvTraslados.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(149, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.DgvTraslados.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White
        Me.DgvTraslados.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.DgvTraslados.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DgvTraslados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        '
        'FrmTraslados
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
        Me.Name = "FrmTraslados"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        CType(Me.DgvTraslados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents DtpFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents LstLotes As System.Windows.Forms.ListBox
    Friend WithEvents BtnAgregarLote As System.Windows.Forms.Button
    Friend WithEvents BtnNuevo As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TxtDestino_REQ As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents CboVehiculo As System.Windows.Forms.ComboBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents BtnEliminarLote As System.Windows.Forms.Button
    Friend WithEvents DgvTraslados As System.Windows.Forms.DataGridView
End Class
