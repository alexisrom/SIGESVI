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
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.acceder = New System.Windows.Forms.Button
        Me.txtpassw = New System.Windows.Forms.TextBox
        Me.Txtuser = New System.Windows.Forms.TextBox
        Me.erroruser = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.errorpassw = New System.Windows.Forms.ErrorProvider(Me.components)
        CType(Me.erroruser, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.errorpassw, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(60, 123)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Contraseña"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(60, 85)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Usuario"
        '
        'acceder
        '
        Me.acceder.Location = New System.Drawing.Point(125, 160)
        Me.acceder.Name = "acceder"
        Me.acceder.Size = New System.Drawing.Size(75, 23)
        Me.acceder.TabIndex = 7
        Me.acceder.Text = "Entrar"
        Me.acceder.UseVisualStyleBackColor = True
        '
        'txtpassw
        '
        Me.txtpassw.Location = New System.Drawing.Point(125, 116)
        Me.txtpassw.Name = "txtpassw"
        Me.txtpassw.Size = New System.Drawing.Size(100, 20)
        Me.txtpassw.TabIndex = 6
        '
        'Txtuser
        '
        Me.Txtuser.Location = New System.Drawing.Point(125, 78)
        Me.Txtuser.Name = "Txtuser"
        Me.Txtuser.Size = New System.Drawing.Size(100, 20)
        Me.Txtuser.TabIndex = 5
        '
        'erroruser
        '
        Me.erroruser.ContainerControl = Me
        '
        'errorpassw
        '
        Me.errorpassw.ContainerControl = Me
        '
        'login2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.acceder)
        Me.Controls.Add(Me.txtpassw)
        Me.Controls.Add(Me.Txtuser)
        Me.Name = "login2"
        Me.Text = "login2"
        CType(Me.erroruser, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.errorpassw, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents acceder As System.Windows.Forms.Button
    Friend WithEvents txtpassw As System.Windows.Forms.TextBox
    Friend WithEvents Txtuser As System.Windows.Forms.TextBox
    Friend WithEvents erroruser As System.Windows.Forms.ErrorProvider
    Friend WithEvents errorpassw As System.Windows.Forms.ErrorProvider
End Class
