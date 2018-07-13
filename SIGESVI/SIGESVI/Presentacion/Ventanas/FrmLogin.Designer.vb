<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmLogin
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
        Me.components = New System.ComponentModel.Container
        Me.Txtuser = New System.Windows.Forms.TextBox
        Me.txtpassw = New System.Windows.Forms.TextBox
        Me.acceder = New System.Windows.Forms.Button
        Me.Lbl_Usuario = New System.Windows.Forms.Label
        Me.Lbl_Contraseña = New System.Windows.Forms.Label
        Me.erroruser = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.errorpassw = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Lbl_Info = New System.Windows.Forms.Label
        CType(Me.erroruser, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.errorpassw, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Txtuser
        '
        Me.Txtuser.Location = New System.Drawing.Point(96, 60)
        Me.Txtuser.Name = "Txtuser"
        Me.Txtuser.Size = New System.Drawing.Size(130, 20)
        Me.Txtuser.TabIndex = 0
        '
        'txtpassw
        '
        Me.txtpassw.Location = New System.Drawing.Point(96, 99)
        Me.txtpassw.Name = "txtpassw"
        Me.txtpassw.Size = New System.Drawing.Size(130, 20)
        Me.txtpassw.TabIndex = 1
        '
        'acceder
        '
        Me.acceder.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.acceder.Location = New System.Drawing.Point(93, 135)
        Me.acceder.Name = "acceder"
        Me.acceder.Size = New System.Drawing.Size(133, 29)
        Me.acceder.TabIndex = 2
        Me.acceder.Text = "Ingresar Ahora"
        Me.acceder.UseVisualStyleBackColor = True
        '
        'Lbl_Usuario
        '
        Me.Lbl_Usuario.AutoSize = True
        Me.Lbl_Usuario.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Usuario.Location = New System.Drawing.Point(33, 60)
        Me.Lbl_Usuario.Name = "Lbl_Usuario"
        Me.Lbl_Usuario.Size = New System.Drawing.Size(57, 17)
        Me.Lbl_Usuario.TabIndex = 3
        Me.Lbl_Usuario.Text = "Usuario"
        '
        'Lbl_Contraseña
        '
        Me.Lbl_Contraseña.AutoSize = True
        Me.Lbl_Contraseña.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Contraseña.Location = New System.Drawing.Point(12, 99)
        Me.Lbl_Contraseña.Name = "Lbl_Contraseña"
        Me.Lbl_Contraseña.Size = New System.Drawing.Size(78, 17)
        Me.Lbl_Contraseña.TabIndex = 4
        Me.Lbl_Contraseña.Text = "Contraseña"
        '
        'erroruser
        '
        Me.erroruser.ContainerControl = Me
        '
        'errorpassw
        '
        Me.errorpassw.ContainerControl = Me
        '
        'Lbl_Info
        '
        Me.Lbl_Info.AutoSize = True
        Me.Lbl_Info.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Info.Location = New System.Drawing.Point(24, 26)
        Me.Lbl_Info.Name = "Lbl_Info"
        Me.Lbl_Info.Size = New System.Drawing.Size(217, 17)
        Me.Lbl_Info.TabIndex = 5
        Me.Lbl_Info.Text = "A continuación ingrese sus datos: "
        '
        'FrmLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(307, 195)
        Me.Controls.Add(Me.Lbl_Info)
        Me.Controls.Add(Me.Lbl_Contraseña)
        Me.Controls.Add(Me.Lbl_Usuario)
        Me.Controls.Add(Me.acceder)
        Me.Controls.Add(Me.txtpassw)
        Me.Controls.Add(Me.Txtuser)
        Me.Name = "FrmLogin"
        Me.Text = "Login"
        CType(Me.erroruser, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.errorpassw, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Txtuser As System.Windows.Forms.TextBox
    Friend WithEvents txtpassw As System.Windows.Forms.TextBox
    Friend WithEvents acceder As System.Windows.Forms.Button
    Friend WithEvents Lbl_Usuario As System.Windows.Forms.Label
    Friend WithEvents Lbl_Contraseña As System.Windows.Forms.Label
    Friend WithEvents erroruser As System.Windows.Forms.ErrorProvider
    Friend WithEvents errorpassw As System.Windows.Forms.ErrorProvider
    Friend WithEvents Lbl_Info As System.Windows.Forms.Label
End Class
