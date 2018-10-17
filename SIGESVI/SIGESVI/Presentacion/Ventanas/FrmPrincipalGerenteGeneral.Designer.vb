<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPrincipalGerenteGeneral
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
        Me.Button1 = New System.Windows.Forms.Button
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Button2 = New System.Windows.Forms.Button
        Me.Button3 = New System.Windows.Forms.Button
        Me.PbFotoUsuario = New System.Windows.Forms.PictureBox
        Me.LblNombreUsuario = New System.Windows.Forms.Label
        Me.LblCargoUsuario = New System.Windows.Forms.Label
        Me.LbCerrarSesion = New System.Windows.Forms.LinkLabel
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.Panel1.SuspendLayout()
        CType(Me.PbFotoUsuario, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(3, 133)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(180, 33)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Gestion de Funcionarios"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.CornflowerBlue
        Me.Panel1.Controls.Add(Me.LbCerrarSesion)
        Me.Panel1.Controls.Add(Me.LblCargoUsuario)
        Me.Panel1.Controls.Add(Me.LblNombreUsuario)
        Me.Panel1.Controls.Add(Me.PbFotoUsuario)
        Me.Panel1.Controls.Add(Me.Button3)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(208, 593)
        Me.Panel1.TabIndex = 2
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(3, 172)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(180, 33)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Gestion de Funcionarios"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(3, 211)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(180, 33)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "Gestion de Funcionarios"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'PbFotoUsuario
        '
        Me.PbFotoUsuario.Location = New System.Drawing.Point(12, 505)
        Me.PbFotoUsuario.Name = "PbFotoUsuario"
        Me.PbFotoUsuario.Size = New System.Drawing.Size(80, 80)
        Me.PbFotoUsuario.TabIndex = 3
        Me.PbFotoUsuario.TabStop = False
        '
        'LblNombreUsuario
        '
        Me.LblNombreUsuario.AutoSize = True
        Me.LblNombreUsuario.Location = New System.Drawing.Point(98, 505)
        Me.LblNombreUsuario.Name = "LblNombreUsuario"
        Me.LblNombreUsuario.Size = New System.Drawing.Size(80, 13)
        Me.LblNombreUsuario.TabIndex = 4
        Me.LblNombreUsuario.Text = "Jose Rodriguez"
        '
        'LblCargoUsuario
        '
        Me.LblCargoUsuario.AutoSize = True
        Me.LblCargoUsuario.Location = New System.Drawing.Point(101, 522)
        Me.LblCargoUsuario.Name = "LblCargoUsuario"
        Me.LblCargoUsuario.Size = New System.Drawing.Size(72, 13)
        Me.LblCargoUsuario.TabIndex = 5
        Me.LblCargoUsuario.Text = "Administrativo"
        '
        'LbCerrarSesion
        '
        Me.LbCerrarSesion.AutoSize = True
        Me.LbCerrarSesion.Location = New System.Drawing.Point(104, 568)
        Me.LbCerrarSesion.Name = "LbCerrarSesion"
        Me.LbCerrarSesion.Size = New System.Drawing.Size(70, 13)
        Me.LbCerrarSesion.TabIndex = 6
        Me.LbCerrarSesion.TabStop = True
        Me.LbCerrarSesion.Text = "Cerrar Sesión"
        '
        'Panel2
        '
        Me.Panel2.BackgroundImage = Global.SIGESVI.My.Resources.Resources.Imagen_menu_principal
        Me.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(208, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(947, 593)
        Me.Panel2.TabIndex = 4
        '
        'FrmPrincipalGerenteSucursal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1155, 593)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "FrmPrincipalGerenteSucursal"
        Me.Text = "FrmPrincipalGerenteSucursal"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PbFotoUsuario, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents LblNombreUsuario As System.Windows.Forms.Label
    Friend WithEvents PbFotoUsuario As System.Windows.Forms.PictureBox
    Friend WithEvents LbCerrarSesion As System.Windows.Forms.LinkLabel
    Friend WithEvents LblCargoUsuario As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
End Class
