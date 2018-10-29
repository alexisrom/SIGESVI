<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmSucursales
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmSucursales))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.CbProveedor = New System.Windows.Forms.CheckBox
        Me.BtnCancelar = New System.Windows.Forms.Button
        Me.BtnGuardar = New System.Windows.Forms.Button
        Me.BtnEliminarTelefono = New System.Windows.Forms.Button
        Me.BtnAgregarTelefono = New System.Windows.Forms.Button
        Me.TxtTelefono_NUM = New System.Windows.Forms.TextBox
        Me.LstTelefonos_REQ = New System.Windows.Forms.ListBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.TxtDireccion_REQ = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.TxtDepartamento_REQ = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.TxtID = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.TxtNombre_REQ = New System.Windows.Forms.TextBox
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.Label3 = New System.Windows.Forms.Label
        Me.BtnEliminar = New System.Windows.Forms.Button
        Me.BtnEditar = New System.Windows.Forms.Button
        Me.DgvSucursales = New System.Windows.Forms.DataGridView
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.DgvSucursales, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.AccessibleDescription = Nothing
        Me.Panel1.AccessibleName = Nothing
        resources.ApplyResources(Me.Panel1, "Panel1")
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(149, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.Panel1.BackgroundImage = Nothing
        Me.Panel1.Controls.Add(Me.CbProveedor)
        Me.Panel1.Controls.Add(Me.BtnCancelar)
        Me.Panel1.Controls.Add(Me.BtnGuardar)
        Me.Panel1.Controls.Add(Me.BtnEliminarTelefono)
        Me.Panel1.Controls.Add(Me.BtnAgregarTelefono)
        Me.Panel1.Controls.Add(Me.TxtTelefono_NUM)
        Me.Panel1.Controls.Add(Me.LstTelefonos_REQ)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.TxtDireccion_REQ)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.TxtDepartamento_REQ)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.TxtID)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.TxtNombre_REQ)
        Me.Panel1.Font = Nothing
        Me.Panel1.Name = "Panel1"
        '
        'CbProveedor
        '
        Me.CbProveedor.AccessibleDescription = Nothing
        Me.CbProveedor.AccessibleName = Nothing
        resources.ApplyResources(Me.CbProveedor, "CbProveedor")
        Me.CbProveedor.BackgroundImage = Nothing
        Me.CbProveedor.ForeColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.CbProveedor.Name = "CbProveedor"
        Me.CbProveedor.UseVisualStyleBackColor = True
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
        'BtnEliminarTelefono
        '
        Me.BtnEliminarTelefono.AccessibleDescription = Nothing
        Me.BtnEliminarTelefono.AccessibleName = Nothing
        resources.ApplyResources(Me.BtnEliminarTelefono, "BtnEliminarTelefono")
        Me.BtnEliminarTelefono.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(161, Byte), Integer))
        Me.BtnEliminarTelefono.BackgroundImage = Nothing
        Me.BtnEliminarTelefono.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnEliminarTelefono.FlatAppearance.BorderSize = 0
        Me.BtnEliminarTelefono.ForeColor = System.Drawing.Color.White
        Me.BtnEliminarTelefono.Name = "BtnEliminarTelefono"
        Me.BtnEliminarTelefono.UseVisualStyleBackColor = False
        '
        'BtnAgregarTelefono
        '
        Me.BtnAgregarTelefono.AccessibleDescription = Nothing
        Me.BtnAgregarTelefono.AccessibleName = Nothing
        resources.ApplyResources(Me.BtnAgregarTelefono, "BtnAgregarTelefono")
        Me.BtnAgregarTelefono.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(161, Byte), Integer))
        Me.BtnAgregarTelefono.BackgroundImage = Nothing
        Me.BtnAgregarTelefono.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnAgregarTelefono.FlatAppearance.BorderSize = 0
        Me.BtnAgregarTelefono.ForeColor = System.Drawing.Color.White
        Me.BtnAgregarTelefono.Name = "BtnAgregarTelefono"
        Me.BtnAgregarTelefono.UseVisualStyleBackColor = False
        '
        'TxtTelefono_NUM
        '
        Me.TxtTelefono_NUM.AccessibleDescription = Nothing
        Me.TxtTelefono_NUM.AccessibleName = Nothing
        resources.ApplyResources(Me.TxtTelefono_NUM, "TxtTelefono_NUM")
        Me.TxtTelefono_NUM.BackgroundImage = Nothing
        Me.TxtTelefono_NUM.Name = "TxtTelefono_NUM"
        '
        'LstTelefonos_REQ
        '
        Me.LstTelefonos_REQ.AccessibleDescription = Nothing
        Me.LstTelefonos_REQ.AccessibleName = Nothing
        resources.ApplyResources(Me.LstTelefonos_REQ, "LstTelefonos_REQ")
        Me.LstTelefonos_REQ.BackgroundImage = Nothing
        Me.LstTelefonos_REQ.FormattingEnabled = True
        Me.LstTelefonos_REQ.Name = "LstTelefonos_REQ"
        '
        'Label7
        '
        Me.Label7.AccessibleDescription = Nothing
        Me.Label7.AccessibleName = Nothing
        resources.ApplyResources(Me.Label7, "Label7")
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.Label7.Name = "Label7"
        '
        'TxtDireccion_REQ
        '
        Me.TxtDireccion_REQ.AccessibleDescription = Nothing
        Me.TxtDireccion_REQ.AccessibleName = Nothing
        resources.ApplyResources(Me.TxtDireccion_REQ, "TxtDireccion_REQ")
        Me.TxtDireccion_REQ.BackgroundImage = Nothing
        Me.TxtDireccion_REQ.Name = "TxtDireccion_REQ"
        '
        'Label4
        '
        Me.Label4.AccessibleDescription = Nothing
        Me.Label4.AccessibleName = Nothing
        resources.ApplyResources(Me.Label4, "Label4")
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.Label4.Name = "Label4"
        '
        'Label6
        '
        Me.Label6.AccessibleDescription = Nothing
        Me.Label6.AccessibleName = Nothing
        resources.ApplyResources(Me.Label6, "Label6")
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.Label6.Name = "Label6"
        '
        'TxtDepartamento_REQ
        '
        Me.TxtDepartamento_REQ.AccessibleDescription = Nothing
        Me.TxtDepartamento_REQ.AccessibleName = Nothing
        resources.ApplyResources(Me.TxtDepartamento_REQ, "TxtDepartamento_REQ")
        Me.TxtDepartamento_REQ.BackgroundImage = Nothing
        Me.TxtDepartamento_REQ.Name = "TxtDepartamento_REQ"
        '
        'Label2
        '
        Me.Label2.AccessibleDescription = Nothing
        Me.Label2.AccessibleName = Nothing
        resources.ApplyResources(Me.Label2, "Label2")
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.Label2.Name = "Label2"
        '
        'TxtID
        '
        Me.TxtID.AccessibleDescription = Nothing
        Me.TxtID.AccessibleName = Nothing
        resources.ApplyResources(Me.TxtID, "TxtID")
        Me.TxtID.BackgroundImage = Nothing
        Me.TxtID.Name = "TxtID"
        '
        'Label5
        '
        Me.Label5.AccessibleDescription = Nothing
        Me.Label5.AccessibleName = Nothing
        resources.ApplyResources(Me.Label5, "Label5")
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.Label5.Name = "Label5"
        '
        'Label1
        '
        Me.Label1.AccessibleDescription = Nothing
        Me.Label1.AccessibleName = Nothing
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(229, Byte), Integer))
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
        'Panel2
        '
        Me.Panel2.AccessibleDescription = Nothing
        Me.Panel2.AccessibleName = Nothing
        resources.ApplyResources(Me.Panel2, "Panel2")
        Me.Panel2.BackgroundImage = Nothing
        Me.Panel2.Controls.Add(Me.DgvSucursales)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.BtnEliminar)
        Me.Panel2.Controls.Add(Me.BtnEditar)
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
        'BtnEliminar
        '
        Me.BtnEliminar.AccessibleDescription = Nothing
        Me.BtnEliminar.AccessibleName = Nothing
        resources.ApplyResources(Me.BtnEliminar, "BtnEliminar")
        Me.BtnEliminar.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(161, Byte), Integer))
        Me.BtnEliminar.BackgroundImage = Nothing
        Me.BtnEliminar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnEliminar.FlatAppearance.BorderSize = 0
        Me.BtnEliminar.ForeColor = System.Drawing.Color.White
        Me.BtnEliminar.Name = "BtnEliminar"
        Me.BtnEliminar.UseVisualStyleBackColor = False
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
        'DgvSucursales
        '
        Me.DgvSucursales.AccessibleDescription = Nothing
        Me.DgvSucursales.AccessibleName = Nothing
        resources.ApplyResources(Me.DgvSucursales, "DgvSucursales")
        Me.DgvSucursales.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(149, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.DgvSucursales.BackgroundImage = Nothing
        Me.DgvSucursales.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DgvSucursales.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(161, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(211, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgvSucursales.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DgvSucursales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(149, Byte), Integer), CType(CType(167, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DgvSucursales.DefaultCellStyle = DataGridViewCellStyle2
        Me.DgvSucursales.EnableHeadersVisualStyles = False
        Me.DgvSucursales.Font = Nothing
        Me.DgvSucursales.GridColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.DgvSucursales.MultiSelect = False
        Me.DgvSucursales.Name = "DgvSucursales"
        Me.DgvSucursales.ReadOnly = True
        Me.DgvSucursales.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(149, Byte), Integer), CType(CType(167, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(211, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgvSucursales.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(149, Byte), Integer), CType(CType(167, Byte), Integer))
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.DgvSucursales.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.DgvSucursales.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(149, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.DgvSucursales.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White
        Me.DgvSucursales.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.DgvSucursales.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DgvSucursales.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        '
        'FrmSucursales
        '
        Me.AccessibleDescription = Nothing
        Me.AccessibleName = Nothing
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.BackgroundImage = Nothing
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Font = Nothing
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = Nothing
        Me.Name = "FrmSucursales"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        CType(Me.DgvSucursales, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents TxtID As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TxtNombre_REQ As System.Windows.Forms.TextBox
    Friend WithEvents TxtDireccion_REQ As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TxtDepartamento_REQ As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents BtnEliminarTelefono As System.Windows.Forms.Button
    Friend WithEvents BtnAgregarTelefono As System.Windows.Forms.Button
    Friend WithEvents TxtTelefono_NUM As System.Windows.Forms.TextBox
    Friend WithEvents LstTelefonos_REQ As System.Windows.Forms.ListBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents BtnGuardar As System.Windows.Forms.Button
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents BtnEliminar As System.Windows.Forms.Button
    Friend WithEvents BtnEditar As System.Windows.Forms.Button
    Friend WithEvents BtnCancelar As System.Windows.Forms.Button
    Friend WithEvents CbProveedor As System.Windows.Forms.CheckBox
    Friend WithEvents DgvSucursales As System.Windows.Forms.DataGridView
End Class
