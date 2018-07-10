<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Login
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_Login))
        Me.lbl_Info = New System.Windows.Forms.Label
        Me.lbl_LoginContraseña = New System.Windows.Forms.Label
        Me.lbl_LoginUsuario = New System.Windows.Forms.Label
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.TextBox2 = New System.Windows.Forms.TextBox
        Me.Pct_LogoEmpresa = New System.Windows.Forms.PictureBox
        Me.btn_Ingresar = New System.Windows.Forms.Button
        CType(Me.Pct_LogoEmpresa, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_Info
        '
        Me.lbl_Info.AutoSize = True
        Me.lbl_Info.Font = New System.Drawing.Font("Constantia", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Info.Location = New System.Drawing.Point(28, 24)
        Me.lbl_Info.Name = "lbl_Info"
        Me.lbl_Info.Size = New System.Drawing.Size(409, 19)
        Me.lbl_Info.TabIndex = 0
        Me.lbl_Info.Text = "A continuación ingrese sus datos para ingresar al sistema:"
        '
        'lbl_LoginContraseña
        '
        Me.lbl_LoginContraseña.AutoSize = True
        Me.lbl_LoginContraseña.Font = New System.Drawing.Font("Constantia", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_LoginContraseña.Location = New System.Drawing.Point(28, 133)
        Me.lbl_LoginContraseña.Name = "lbl_LoginContraseña"
        Me.lbl_LoginContraseña.Size = New System.Drawing.Size(92, 19)
        Me.lbl_LoginContraseña.TabIndex = 1
        Me.lbl_LoginContraseña.Text = "Contraseña:"
        '
        'lbl_LoginUsuario
        '
        Me.lbl_LoginUsuario.AutoSize = True
        Me.lbl_LoginUsuario.Font = New System.Drawing.Font("Constantia", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_LoginUsuario.Location = New System.Drawing.Point(28, 72)
        Me.lbl_LoginUsuario.Name = "lbl_LoginUsuario"
        Me.lbl_LoginUsuario.Size = New System.Drawing.Size(68, 19)
        Me.lbl_LoginUsuario.TabIndex = 2
        Me.lbl_LoginUsuario.Text = "Usuario:"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(32, 164)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(175, 20)
        Me.TextBox1.TabIndex = 3
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(33, 94)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(176, 20)
        Me.TextBox2.TabIndex = 4
        '
        'Pct_LogoEmpresa
        '
        Me.Pct_LogoEmpresa.Image = CType(resources.GetObject("Pct_LogoEmpresa.Image"), System.Drawing.Image)
        Me.Pct_LogoEmpresa.Location = New System.Drawing.Point(421, 409)
        Me.Pct_LogoEmpresa.Name = "Pct_LogoEmpresa"
        Me.Pct_LogoEmpresa.Size = New System.Drawing.Size(60, 50)
        Me.Pct_LogoEmpresa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Pct_LogoEmpresa.TabIndex = 5
        Me.Pct_LogoEmpresa.TabStop = False
        '
        'btn_Ingresar
        '
        Me.btn_Ingresar.Font = New System.Drawing.Font("Constantia", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Ingresar.Location = New System.Drawing.Point(53, 213)
        Me.btn_Ingresar.Name = "btn_Ingresar"
        Me.btn_Ingresar.Size = New System.Drawing.Size(124, 36)
        Me.btn_Ingresar.TabIndex = 6
        Me.btn_Ingresar.Text = "Ingresar ahora"
        Me.btn_Ingresar.UseVisualStyleBackColor = True
        '
        'frm_Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(484, 461)
        Me.Controls.Add(Me.btn_Ingresar)
        Me.Controls.Add(Me.Pct_LogoEmpresa)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.lbl_LoginUsuario)
        Me.Controls.Add(Me.lbl_LoginContraseña)
        Me.Controls.Add(Me.lbl_Info)
        Me.Name = "frm_Login"
        Me.Text = "Login"
        CType(Me.Pct_LogoEmpresa, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbl_Info As System.Windows.Forms.Label
    Friend WithEvents lbl_LoginContraseña As System.Windows.Forms.Label
    Friend WithEvents lbl_LoginUsuario As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Pct_LogoEmpresa As System.Windows.Forms.PictureBox
    Friend WithEvents btn_Ingresar As System.Windows.Forms.Button
End Class
