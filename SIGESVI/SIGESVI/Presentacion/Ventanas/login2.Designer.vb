<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class login2
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
        Me.Btn_IngresarLogin2 = New System.Windows.Forms.Button
        Me.Txt_Passwd = New System.Windows.Forms.TextBox
        Me.erroruser = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.errorpassw = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Txt_Usuario = New System.Windows.Forms.TextBox
        Me.Lbl_Info = New System.Windows.Forms.Label
        Me.Lbl_Contraseña = New System.Windows.Forms.Label
        Me.Lbl_Usuario = New System.Windows.Forms.Label
        CType(Me.erroruser, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.errorpassw, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Btn_IngresarLogin2
        '
        Me.Btn_IngresarLogin2.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_IngresarLogin2.Location = New System.Drawing.Point(93, 135)
        Me.Btn_IngresarLogin2.Name = "Btn_IngresarLogin2"
        Me.Btn_IngresarLogin2.Size = New System.Drawing.Size(133, 48)
        Me.Btn_IngresarLogin2.TabIndex = 7
        Me.Btn_IngresarLogin2.Text = "Ingresar Ahora"
        Me.Btn_IngresarLogin2.UseVisualStyleBackColor = True
        '
        'Txt_Passwd
        '
        Me.Txt_Passwd.Location = New System.Drawing.Point(96, 99)
        Me.Txt_Passwd.Name = "Txt_Passwd"
        Me.Txt_Passwd.Size = New System.Drawing.Size(130, 20)
        Me.Txt_Passwd.TabIndex = 6
        '
        'erroruser
        '
        Me.erroruser.ContainerControl = Me
        '
        'errorpassw
        '
        Me.errorpassw.ContainerControl = Me
        '
        'Txt_Usuario
        '
        Me.Txt_Usuario.Location = New System.Drawing.Point(96, 60)
        Me.Txt_Usuario.Name = "Txt_Usuario"
        Me.Txt_Usuario.Size = New System.Drawing.Size(130, 20)
        Me.Txt_Usuario.TabIndex = 5
        '
        'Lbl_Info
        '
        Me.Lbl_Info.AutoSize = True
        Me.Lbl_Info.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Info.Location = New System.Drawing.Point(24, 26)
        Me.Lbl_Info.Name = "Lbl_Info"
        Me.Lbl_Info.Size = New System.Drawing.Size(217, 17)
        Me.Lbl_Info.TabIndex = 10
        Me.Lbl_Info.Text = "A continuación ingrese sus datos: "
        '
        'Lbl_Contraseña
        '
        Me.Lbl_Contraseña.AutoSize = True
        Me.Lbl_Contraseña.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Contraseña.Location = New System.Drawing.Point(12, 99)
        Me.Lbl_Contraseña.Name = "Lbl_Contraseña"
        Me.Lbl_Contraseña.Size = New System.Drawing.Size(78, 17)
        Me.Lbl_Contraseña.TabIndex = 9
        Me.Lbl_Contraseña.Text = "Contraseña"
        '
        'Lbl_Usuario
        '
        Me.Lbl_Usuario.AutoSize = True
        Me.Lbl_Usuario.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Usuario.Location = New System.Drawing.Point(33, 60)
        Me.Lbl_Usuario.Name = "Lbl_Usuario"
        Me.Lbl_Usuario.Size = New System.Drawing.Size(57, 17)
        Me.Lbl_Usuario.TabIndex = 8
        Me.Lbl_Usuario.Text = "Usuario"
        '
        'login2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(307, 195)
        Me.Controls.Add(Me.Lbl_Info)
        Me.Controls.Add(Me.Lbl_Contraseña)
        Me.Controls.Add(Me.Lbl_Usuario)
        Me.Controls.Add(Me.Btn_IngresarLogin2)
        Me.Controls.Add(Me.Txt_Passwd)
        Me.Controls.Add(Me.Txt_Usuario)
        Me.Name = "login2"
        Me.Text = "Login Cliente"
        CType(Me.erroruser, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.errorpassw, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Btn_IngresarLogin2 As System.Windows.Forms.Button
    Friend WithEvents Txt_Passwd As System.Windows.Forms.TextBox
    Friend WithEvents erroruser As System.Windows.Forms.ErrorProvider
    Friend WithEvents errorpassw As System.Windows.Forms.ErrorProvider
    Friend WithEvents Txt_Usuario As System.Windows.Forms.TextBox
    Friend WithEvents Lbl_Info As System.Windows.Forms.Label
    Friend WithEvents Lbl_Contraseña As System.Windows.Forms.Label
    Friend WithEvents Lbl_Usuario As System.Windows.Forms.Label
End Class
