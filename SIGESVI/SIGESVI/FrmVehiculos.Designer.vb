<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmVehiculos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmVehiculos))
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Label4 = New System.Windows.Forms.Label
        Me.TxtMatricula_NUM_REQ = New System.Windows.Forms.TextBox
        Me.TxtCapacidad_NUM_REQ = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.BtnNuevo = New System.Windows.Forms.Button
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.TxtNombre_REQ = New System.Windows.Forms.TextBox
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.Button4 = New System.Windows.Forms.Button
        Me.BtnAgregarEtapa = New System.Windows.Forms.Button
        Me.Label3 = New System.Windows.Forms.Label
        Me.DgvEtapas = New System.Windows.Forms.DataGridView
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.DgvEtapas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.AccessibleDescription = Nothing
        Me.Panel1.AccessibleName = Nothing
        resources.ApplyResources(Me.Panel1, "Panel1")
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(149, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.Panel1.BackgroundImage = Nothing
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.TxtMatricula_NUM_REQ)
        Me.Panel1.Controls.Add(Me.TxtCapacidad_NUM_REQ)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.BtnNuevo)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.TxtNombre_REQ)
        Me.Panel1.Font = Nothing
        Me.Panel1.Name = "Panel1"
        '
        'Label4
        '
        Me.Label4.AccessibleDescription = Nothing
        Me.Label4.AccessibleName = Nothing
        resources.ApplyResources(Me.Label4, "Label4")
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.Label4.Name = "Label4"
        '
        'TxtMatricula_NUM_REQ
        '
        Me.TxtMatricula_NUM_REQ.AccessibleDescription = Nothing
        Me.TxtMatricula_NUM_REQ.AccessibleName = Nothing
        resources.ApplyResources(Me.TxtMatricula_NUM_REQ, "TxtMatricula_NUM_REQ")
        Me.TxtMatricula_NUM_REQ.BackgroundImage = Nothing
        Me.TxtMatricula_NUM_REQ.Name = "TxtMatricula_NUM_REQ"
        '
        'TxtCapacidad_NUM_REQ
        '
        Me.TxtCapacidad_NUM_REQ.AccessibleDescription = Nothing
        Me.TxtCapacidad_NUM_REQ.AccessibleName = Nothing
        resources.ApplyResources(Me.TxtCapacidad_NUM_REQ, "TxtCapacidad_NUM_REQ")
        Me.TxtCapacidad_NUM_REQ.BackgroundImage = Nothing
        Me.TxtCapacidad_NUM_REQ.Name = "TxtCapacidad_NUM_REQ"
        '
        'Label8
        '
        Me.Label8.AccessibleDescription = Nothing
        Me.Label8.AccessibleName = Nothing
        resources.ApplyResources(Me.Label8, "Label8")
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.Label8.Name = "Label8"
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
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.Panel2.BackgroundImage = Nothing
        Me.Panel2.Controls.Add(Me.Button4)
        Me.Panel2.Controls.Add(Me.BtnAgregarEtapa)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.DgvEtapas)
        Me.Panel2.Font = Nothing
        Me.Panel2.Name = "Panel2"
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
        'Label3
        '
        Me.Label3.AccessibleDescription = Nothing
        Me.Label3.AccessibleName = Nothing
        resources.ApplyResources(Me.Label3, "Label3")
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(172, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.Label3.Name = "Label3"
        '
        'DgvEtapas
        '
        Me.DgvEtapas.AccessibleDescription = Nothing
        Me.DgvEtapas.AccessibleName = Nothing
        resources.ApplyResources(Me.DgvEtapas, "DgvEtapas")
        Me.DgvEtapas.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(149, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.DgvEtapas.BackgroundImage = Nothing
        Me.DgvEtapas.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DgvEtapas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvEtapas.Font = Nothing
        Me.DgvEtapas.Name = "DgvEtapas"
        '
        'FrmVehiculos
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
        Me.Name = "FrmVehiculos"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.DgvEtapas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents TxtCapacidad_NUM_REQ As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents BtnNuevo As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TxtNombre_REQ As System.Windows.Forms.TextBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents BtnAgregarEtapa As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents DgvEtapas As System.Windows.Forms.DataGridView
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TxtMatricula_NUM_REQ As System.Windows.Forms.TextBox
End Class
