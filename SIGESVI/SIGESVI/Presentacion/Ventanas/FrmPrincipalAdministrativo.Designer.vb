<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPrincipalAdministrativo
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
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.LbCerrarSesion = New System.Windows.Forms.LinkLabel
        Me.LblCargoUsuario = New System.Windows.Forms.Label
        Me.LblNombreUsuario = New System.Windows.Forms.Label
        Me.BtnGestionProductos = New System.Windows.Forms.Button
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.PbFotoUsuario = New System.Windows.Forms.PictureBox
        Me.BtnEspeficicacionesProducto = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.Button3 = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.Panel1.SuspendLayout()
        CType(Me.PbFotoUsuario, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.CornflowerBlue
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.Button3)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.BtnEspeficicacionesProducto)
        Me.Panel1.Controls.Add(Me.LbCerrarSesion)
        Me.Panel1.Controls.Add(Me.LblCargoUsuario)
        Me.Panel1.Controls.Add(Me.LblNombreUsuario)
        Me.Panel1.Controls.Add(Me.PbFotoUsuario)
        Me.Panel1.Controls.Add(Me.BtnGestionProductos)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(208, 628)
        Me.Panel1.TabIndex = 3
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
        'LblCargoUsuario
        '
        Me.LblCargoUsuario.AutoSize = True
        Me.LblCargoUsuario.Location = New System.Drawing.Point(101, 522)
        Me.LblCargoUsuario.Name = "LblCargoUsuario"
        Me.LblCargoUsuario.Size = New System.Drawing.Size(72, 13)
        Me.LblCargoUsuario.TabIndex = 5
        Me.LblCargoUsuario.Text = "Administrativo"
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
        'BtnGestionProductos
        '
        Me.BtnGestionProductos.Location = New System.Drawing.Point(3, 133)
        Me.BtnGestionProductos.Name = "BtnGestionProductos"
        Me.BtnGestionProductos.Size = New System.Drawing.Size(180, 33)
        Me.BtnGestionProductos.TabIndex = 0
        Me.BtnGestionProductos.Text = "Gestion de Productos"
        Me.BtnGestionProductos.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.BackgroundImage = Global.SIGESVI.My.Resources.Resources.Imagen_menu_principal
        Me.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(208, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(976, 628)
        Me.Panel2.TabIndex = 5
        '
        'PbFotoUsuario
        '
        Me.PbFotoUsuario.Location = New System.Drawing.Point(12, 505)
        Me.PbFotoUsuario.Name = "PbFotoUsuario"
        Me.PbFotoUsuario.Size = New System.Drawing.Size(80, 80)
        Me.PbFotoUsuario.TabIndex = 3
        Me.PbFotoUsuario.TabStop = False
        '
        'BtnEspeficicacionesProducto
        '
        Me.BtnEspeficicacionesProducto.Location = New System.Drawing.Point(3, 359)
        Me.BtnEspeficicacionesProducto.Name = "BtnEspeficicacionesProducto"
        Me.BtnEspeficicacionesProducto.Size = New System.Drawing.Size(180, 33)
        Me.BtnEspeficicacionesProducto.TabIndex = 7
        Me.BtnEspeficicacionesProducto.Text = "Especificaciones de Productos"
        Me.BtnEspeficicacionesProducto.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(3, 211)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(180, 33)
        Me.Button2.TabIndex = 8
        Me.Button2.Text = "Gestion de Producción"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(3, 172)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(180, 33)
        Me.Button3.TabIndex = 9
        Me.Button3.Text = "Traslado de Productos"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(3, 250)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(180, 33)
        Me.Button1.TabIndex = 10
        Me.Button1.Text = "Gestion de Lotes"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'FrmPrincipalAdministrativo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1184, 628)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "FrmPrincipalAdministrativo"
        Me.Text = "FrmPrincipalAdministrativo"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PbFotoUsuario, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents LbCerrarSesion As System.Windows.Forms.LinkLabel
    Friend WithEvents LblCargoUsuario As System.Windows.Forms.Label
    Friend WithEvents LblNombreUsuario As System.Windows.Forms.Label
    Friend WithEvents PbFotoUsuario As System.Windows.Forms.PictureBox
    Friend WithEvents BtnGestionProductos As System.Windows.Forms.Button
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents BtnEspeficicacionesProducto As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
