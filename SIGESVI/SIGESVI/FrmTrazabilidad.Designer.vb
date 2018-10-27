<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmTrazabilidad
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmTrazabilidad))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.DtpFin = New System.Windows.Forms.DateTimePicker
        Me.Label4 = New System.Windows.Forms.Label
        Me.DtpInicio = New System.Windows.Forms.DateTimePicker
        Me.CboEtapas = New System.Windows.Forms.ComboBox
        Me.TxtObservacion_REQ = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.BtnCancelar = New System.Windows.Forms.Button
        Me.BtnGuardar = New System.Windows.Forms.Button
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.BtnConfigurarAlarma = New System.Windows.Forms.Button
        Me.LblProduccion = New System.Windows.Forms.Label
        Me.DgvEtapasRecorridas = New System.Windows.Forms.DataGridView
        Me.Label3 = New System.Windows.Forms.Label
        Me.BtnEditar = New System.Windows.Forms.Button
        Me.BtnVolver = New System.Windows.Forms.PictureBox
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.DgvEtapasRecorridas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnVolver, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.AccessibleDescription = Nothing
        Me.Panel1.AccessibleName = Nothing
        resources.ApplyResources(Me.Panel1, "Panel1")
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(149, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.Panel1.BackgroundImage = Nothing
        Me.Panel1.Controls.Add(Me.DtpFin)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.DtpInicio)
        Me.Panel1.Controls.Add(Me.CboEtapas)
        Me.Panel1.Controls.Add(Me.TxtObservacion_REQ)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.BtnCancelar)
        Me.Panel1.Controls.Add(Me.BtnGuardar)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Font = Nothing
        Me.Panel1.Name = "Panel1"
        '
        'DtpFin
        '
        Me.DtpFin.AccessibleDescription = Nothing
        Me.DtpFin.AccessibleName = Nothing
        resources.ApplyResources(Me.DtpFin, "DtpFin")
        Me.DtpFin.BackgroundImage = Nothing
        Me.DtpFin.CalendarFont = Nothing
        Me.DtpFin.CustomFormat = Nothing
        Me.DtpFin.Name = "DtpFin"
        '
        'Label4
        '
        Me.Label4.AccessibleDescription = Nothing
        Me.Label4.AccessibleName = Nothing
        resources.ApplyResources(Me.Label4, "Label4")
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.Label4.Name = "Label4"
        '
        'DtpInicio
        '
        Me.DtpInicio.AccessibleDescription = Nothing
        Me.DtpInicio.AccessibleName = Nothing
        resources.ApplyResources(Me.DtpInicio, "DtpInicio")
        Me.DtpInicio.BackgroundImage = Nothing
        Me.DtpInicio.CalendarFont = Nothing
        Me.DtpInicio.CustomFormat = Nothing
        Me.DtpInicio.Name = "DtpInicio"
        '
        'CboEtapas
        '
        Me.CboEtapas.AccessibleDescription = Nothing
        Me.CboEtapas.AccessibleName = Nothing
        resources.ApplyResources(Me.CboEtapas, "CboEtapas")
        Me.CboEtapas.BackgroundImage = Nothing
        Me.CboEtapas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboEtapas.FormattingEnabled = True
        Me.CboEtapas.Name = "CboEtapas"
        '
        'TxtObservacion_REQ
        '
        Me.TxtObservacion_REQ.AccessibleDescription = Nothing
        Me.TxtObservacion_REQ.AccessibleName = Nothing
        resources.ApplyResources(Me.TxtObservacion_REQ, "TxtObservacion_REQ")
        Me.TxtObservacion_REQ.BackgroundImage = Nothing
        Me.TxtObservacion_REQ.Name = "TxtObservacion_REQ"
        '
        'Label6
        '
        Me.Label6.AccessibleDescription = Nothing
        Me.Label6.AccessibleName = Nothing
        resources.ApplyResources(Me.Label6, "Label6")
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.Label6.Name = "Label6"
        '
        'Label1
        '
        Me.Label1.AccessibleDescription = Nothing
        Me.Label1.AccessibleName = Nothing
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.Label1.Name = "Label1"
        '
        'BtnCancelar
        '
        Me.BtnCancelar.AccessibleDescription = Nothing
        Me.BtnCancelar.AccessibleName = Nothing
        resources.ApplyResources(Me.BtnCancelar, "BtnCancelar")
        Me.BtnCancelar.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(161, Byte), Integer))
        Me.BtnCancelar.BackgroundImage = Nothing
        Me.BtnCancelar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnCancelar.FlatAppearance.BorderSize = 0
        Me.BtnCancelar.ForeColor = System.Drawing.Color.White
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.UseVisualStyleBackColor = False
        '
        'BtnGuardar
        '
        Me.BtnGuardar.AccessibleDescription = Nothing
        Me.BtnGuardar.AccessibleName = Nothing
        resources.ApplyResources(Me.BtnGuardar, "BtnGuardar")
        Me.BtnGuardar.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.BtnGuardar.BackgroundImage = Nothing
        Me.BtnGuardar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnGuardar.FlatAppearance.BorderSize = 0
        Me.BtnGuardar.Font = Nothing
        Me.BtnGuardar.ForeColor = System.Drawing.Color.White
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AccessibleDescription = Nothing
        Me.Label2.AccessibleName = Nothing
        resources.ApplyResources(Me.Label2, "Label2")
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.Label2.Name = "Label2"
        '
        'Label5
        '
        Me.Label5.AccessibleDescription = Nothing
        Me.Label5.AccessibleName = Nothing
        resources.ApplyResources(Me.Label5, "Label5")
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.Label5.Name = "Label5"
        '
        'Panel2
        '
        Me.Panel2.AccessibleDescription = Nothing
        Me.Panel2.AccessibleName = Nothing
        resources.ApplyResources(Me.Panel2, "Panel2")
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.Panel2.BackgroundImage = Nothing
        Me.Panel2.Controls.Add(Me.BtnConfigurarAlarma)
        Me.Panel2.Controls.Add(Me.BtnVolver)
        Me.Panel2.Controls.Add(Me.LblProduccion)
        Me.Panel2.Controls.Add(Me.DgvEtapasRecorridas)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.BtnEditar)
        Me.Panel2.Font = Nothing
        Me.Panel2.Name = "Panel2"
        '
        'BtnConfigurarAlarma
        '
        Me.BtnConfigurarAlarma.AccessibleDescription = Nothing
        Me.BtnConfigurarAlarma.AccessibleName = Nothing
        resources.ApplyResources(Me.BtnConfigurarAlarma, "BtnConfigurarAlarma")
        Me.BtnConfigurarAlarma.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(161, Byte), Integer))
        Me.BtnConfigurarAlarma.BackgroundImage = Nothing
        Me.BtnConfigurarAlarma.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnConfigurarAlarma.FlatAppearance.BorderSize = 0
        Me.BtnConfigurarAlarma.ForeColor = System.Drawing.Color.White
        Me.BtnConfigurarAlarma.Name = "BtnConfigurarAlarma"
        Me.BtnConfigurarAlarma.UseVisualStyleBackColor = False
        '
        'LblProduccion
        '
        Me.LblProduccion.AccessibleDescription = Nothing
        Me.LblProduccion.AccessibleName = Nothing
        resources.ApplyResources(Me.LblProduccion, "LblProduccion")
        Me.LblProduccion.ForeColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(149, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.LblProduccion.Name = "LblProduccion"
        '
        'DgvEtapasRecorridas
        '
        Me.DgvEtapasRecorridas.AccessibleDescription = Nothing
        Me.DgvEtapasRecorridas.AccessibleName = Nothing
        resources.ApplyResources(Me.DgvEtapasRecorridas, "DgvEtapasRecorridas")
        Me.DgvEtapasRecorridas.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(149, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.DgvEtapasRecorridas.BackgroundImage = Nothing
        Me.DgvEtapasRecorridas.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DgvEtapasRecorridas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(161, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(211, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgvEtapasRecorridas.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DgvEtapasRecorridas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(149, Byte), Integer), CType(CType(167, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DgvEtapasRecorridas.DefaultCellStyle = DataGridViewCellStyle2
        Me.DgvEtapasRecorridas.EnableHeadersVisualStyles = False
        Me.DgvEtapasRecorridas.Font = Nothing
        Me.DgvEtapasRecorridas.GridColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.DgvEtapasRecorridas.MultiSelect = False
        Me.DgvEtapasRecorridas.Name = "DgvEtapasRecorridas"
        Me.DgvEtapasRecorridas.ReadOnly = True
        Me.DgvEtapasRecorridas.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(149, Byte), Integer), CType(CType(167, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(211, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgvEtapasRecorridas.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(149, Byte), Integer), CType(CType(167, Byte), Integer))
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.DgvEtapasRecorridas.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.DgvEtapasRecorridas.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(149, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.DgvEtapasRecorridas.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White
        Me.DgvEtapasRecorridas.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.DgvEtapasRecorridas.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DgvEtapasRecorridas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        '
        'Label3
        '
        Me.Label3.AccessibleDescription = Nothing
        Me.Label3.AccessibleName = Nothing
        resources.ApplyResources(Me.Label3, "Label3")
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(172, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.Label3.Name = "Label3"
        '
        'BtnEditar
        '
        Me.BtnEditar.AccessibleDescription = Nothing
        Me.BtnEditar.AccessibleName = Nothing
        resources.ApplyResources(Me.BtnEditar, "BtnEditar")
        Me.BtnEditar.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(161, Byte), Integer))
        Me.BtnEditar.BackgroundImage = Nothing
        Me.BtnEditar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnEditar.FlatAppearance.BorderSize = 0
        Me.BtnEditar.ForeColor = System.Drawing.Color.White
        Me.BtnEditar.Name = "BtnEditar"
        Me.BtnEditar.UseVisualStyleBackColor = False
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
        'FrmTrazabilidad
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
        Me.Name = "FrmTrazabilidad"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.DgvEtapasRecorridas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnVolver, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents BtnCancelar As System.Windows.Forms.Button
    Friend WithEvents BtnGuardar As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents LblProduccion As System.Windows.Forms.Label
    Friend WithEvents DgvEtapasRecorridas As System.Windows.Forms.DataGridView
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents BtnEditar As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TxtObservacion_REQ As System.Windows.Forms.TextBox
    Friend WithEvents BtnVolver As System.Windows.Forms.PictureBox
    Friend WithEvents CboEtapas As System.Windows.Forms.ComboBox
    Friend WithEvents DtpInicio As System.Windows.Forms.DateTimePicker
    Friend WithEvents DtpFin As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents BtnConfigurarAlarma As System.Windows.Forms.Button
End Class
