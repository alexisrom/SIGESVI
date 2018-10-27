<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmClientes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmClientes))
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.BtnCancelar = New System.Windows.Forms.Button
        Me.Label10 = New System.Windows.Forms.Label
        Me.TxtUser_REQ = New System.Windows.Forms.TextBox
        Me.BtnGuardar = New System.Windows.Forms.Button
        Me.TxtTelefono_NUM_REQ = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.TxtDireccion_REQ = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.TxtPass_REQ = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.TxtID_NUM_REQ = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.TxtNombre_REQ = New System.Windows.Forms.TextBox
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.Label3 = New System.Windows.Forms.Label
        Me.BtnEliminar = New System.Windows.Forms.Button
        Me.BtnEditarCliente = New System.Windows.Forms.Button
        Me.DgvClientes = New System.Windows.Forms.DataGridView
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.DgvClientes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.AccessibleDescription = Nothing
        Me.Panel1.AccessibleName = Nothing
        resources.ApplyResources(Me.Panel1, "Panel1")
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(149, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.Panel1.BackgroundImage = Nothing
        Me.Panel1.Controls.Add(Me.BtnCancelar)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.TxtUser_REQ)
        Me.Panel1.Controls.Add(Me.BtnGuardar)
        Me.Panel1.Controls.Add(Me.TxtTelefono_NUM_REQ)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.TxtDireccion_REQ)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.TxtPass_REQ)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.TxtID_NUM_REQ)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.TxtNombre_REQ)
        Me.Panel1.Font = Nothing
        Me.Panel1.Name = "Panel1"
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
        'Label10
        '
        Me.Label10.AccessibleDescription = Nothing
        Me.Label10.AccessibleName = Nothing
        resources.ApplyResources(Me.Label10, "Label10")
        Me.Label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.Label10.Name = "Label10"
        '
        'TxtUser_REQ
        '
        Me.TxtUser_REQ.AccessibleDescription = Nothing
        Me.TxtUser_REQ.AccessibleName = Nothing
        resources.ApplyResources(Me.TxtUser_REQ, "TxtUser_REQ")
        Me.TxtUser_REQ.BackgroundImage = Nothing
        Me.TxtUser_REQ.Name = "TxtUser_REQ"
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
        'TxtTelefono_NUM_REQ
        '
        Me.TxtTelefono_NUM_REQ.AccessibleDescription = Nothing
        Me.TxtTelefono_NUM_REQ.AccessibleName = Nothing
        resources.ApplyResources(Me.TxtTelefono_NUM_REQ, "TxtTelefono_NUM_REQ")
        Me.TxtTelefono_NUM_REQ.BackgroundImage = Nothing
        Me.TxtTelefono_NUM_REQ.Name = "TxtTelefono_NUM_REQ"
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
        'TxtPass_REQ
        '
        Me.TxtPass_REQ.AccessibleDescription = Nothing
        Me.TxtPass_REQ.AccessibleName = Nothing
        resources.ApplyResources(Me.TxtPass_REQ, "TxtPass_REQ")
        Me.TxtPass_REQ.BackgroundImage = Nothing
        Me.TxtPass_REQ.Name = "TxtPass_REQ"
        '
        'Label2
        '
        Me.Label2.AccessibleDescription = Nothing
        Me.Label2.AccessibleName = Nothing
        resources.ApplyResources(Me.Label2, "Label2")
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.Label2.Name = "Label2"
        '
        'TxtID_NUM_REQ
        '
        Me.TxtID_NUM_REQ.AccessibleDescription = Nothing
        Me.TxtID_NUM_REQ.AccessibleName = Nothing
        resources.ApplyResources(Me.TxtID_NUM_REQ, "TxtID_NUM_REQ")
        Me.TxtID_NUM_REQ.BackgroundImage = Nothing
        Me.TxtID_NUM_REQ.Name = "TxtID_NUM_REQ"
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
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.Panel2.BackgroundImage = Nothing
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.BtnEliminar)
        Me.Panel2.Controls.Add(Me.BtnEditarCliente)
        Me.Panel2.Controls.Add(Me.DgvClientes)
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
        'BtnEditarCliente
        '
        Me.BtnEditarCliente.AccessibleDescription = Nothing
        Me.BtnEditarCliente.AccessibleName = Nothing
        resources.ApplyResources(Me.BtnEditarCliente, "BtnEditarCliente")
        Me.BtnEditarCliente.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(161, Byte), Integer))
        Me.BtnEditarCliente.BackgroundImage = Nothing
        Me.BtnEditarCliente.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnEditarCliente.FlatAppearance.BorderSize = 0
        Me.BtnEditarCliente.ForeColor = System.Drawing.Color.White
        Me.BtnEditarCliente.Name = "BtnEditarCliente"
        Me.BtnEditarCliente.UseVisualStyleBackColor = False
        '
        'DgvClientes
        '
        Me.DgvClientes.AccessibleDescription = Nothing
        Me.DgvClientes.AccessibleName = Nothing
        resources.ApplyResources(Me.DgvClientes, "DgvClientes")
        Me.DgvClientes.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(149, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.DgvClientes.BackgroundImage = Nothing
        Me.DgvClientes.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvClientes.Font = Nothing
        Me.DgvClientes.Name = "DgvClientes"
        '
        'FrmClientes
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
        Me.Name = "FrmClientes"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.DgvClientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents TxtUser_REQ As System.Windows.Forms.TextBox
    Friend WithEvents BtnGuardar As System.Windows.Forms.Button
    Friend WithEvents TxtTelefono_NUM_REQ As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents TxtDireccion_REQ As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TxtPass_REQ As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TxtID_NUM_REQ As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TxtNombre_REQ As System.Windows.Forms.TextBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents BtnEliminar As System.Windows.Forms.Button
    Friend WithEvents BtnEditarCliente As System.Windows.Forms.Button
    Friend WithEvents DgvClientes As System.Windows.Forms.DataGridView
    Friend WithEvents BtnCancelar As System.Windows.Forms.Button
End Class
