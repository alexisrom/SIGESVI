<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Bienvenida
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
        Me.lbl_Bienvenida = New System.Windows.Forms.Label
        Me.lbl_SIGESVI = New System.Windows.Forms.Label
        Me.lbl_Aclaración = New System.Windows.Forms.Label
        Me.Lbl_Usuario = New System.Windows.Forms.Label
        Me.Txt_UsuarioREQ = New System.Windows.Forms.TextBox
        Me.Txt_ConstraseñaREQ = New System.Windows.Forms.TextBox
        Me.Lbl_Constraseña = New System.Windows.Forms.Label
        Me.Btn_IniciarSesion = New System.Windows.Forms.Button
        Me.LbRegistrarNuevoCliente = New System.Windows.Forms.LinkLabel
        Me.SuspendLayout()
        '
        'lbl_Bienvenida
        '
        Me.lbl_Bienvenida.AutoSize = True
        Me.lbl_Bienvenida.Font = New System.Drawing.Font("Constantia", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Bienvenida.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lbl_Bienvenida.Location = New System.Drawing.Point(123, 13)
        Me.lbl_Bienvenida.Name = "lbl_Bienvenida"
        Me.lbl_Bienvenida.Size = New System.Drawing.Size(238, 29)
        Me.lbl_Bienvenida.TabIndex = 0
        Me.lbl_Bienvenida.Text = "Bienvenido a nuestro:"
        '
        'lbl_SIGESVI
        '
        Me.lbl_SIGESVI.AutoSize = True
        Me.lbl_SIGESVI.Font = New System.Drawing.Font("Constantia", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_SIGESVI.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lbl_SIGESVI.Location = New System.Drawing.Point(75, 42)
        Me.lbl_SIGESVI.Name = "lbl_SIGESVI"
        Me.lbl_SIGESVI.Size = New System.Drawing.Size(351, 78)
        Me.lbl_SIGESVI.TabIndex = 1
        Me.lbl_SIGESVI.Text = "S.I.GES.VI."
        '
        'lbl_Aclaración
        '
        Me.lbl_Aclaración.AutoSize = True
        Me.lbl_Aclaración.Font = New System.Drawing.Font("Constantia", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Aclaración.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lbl_Aclaración.Location = New System.Drawing.Point(23, 120)
        Me.lbl_Aclaración.Name = "lbl_Aclaración"
        Me.lbl_Aclaración.Size = New System.Drawing.Size(434, 23)
        Me.lbl_Aclaración.TabIndex = 2
        Me.lbl_Aclaración.Text = "(Sistema Informático de Gestión de Viticultura)"
        '
        'Lbl_Usuario
        '
        Me.Lbl_Usuario.AutoSize = True
        Me.Lbl_Usuario.Font = New System.Drawing.Font("Constantia", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Usuario.Location = New System.Drawing.Point(84, 190)
        Me.Lbl_Usuario.Name = "Lbl_Usuario"
        Me.Lbl_Usuario.Size = New System.Drawing.Size(79, 23)
        Me.Lbl_Usuario.TabIndex = 3
        Me.Lbl_Usuario.Text = "Usuario:"
        '
        'Txt_UsuarioREQ
        '
        Me.Txt_UsuarioREQ.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_UsuarioREQ.Location = New System.Drawing.Point(169, 194)
        Me.Txt_UsuarioREQ.Name = "Txt_UsuarioREQ"
        Me.Txt_UsuarioREQ.Size = New System.Drawing.Size(175, 24)
        Me.Txt_UsuarioREQ.TabIndex = 4
        '
        'Txt_ConstraseñaREQ
        '
        Me.Txt_ConstraseñaREQ.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_ConstraseñaREQ.Location = New System.Drawing.Point(169, 228)
        Me.Txt_ConstraseñaREQ.Name = "Txt_ConstraseñaREQ"
        Me.Txt_ConstraseñaREQ.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.Txt_ConstraseñaREQ.Size = New System.Drawing.Size(175, 24)
        Me.Txt_ConstraseñaREQ.TabIndex = 6
        '
        'Lbl_Constraseña
        '
        Me.Lbl_Constraseña.AutoSize = True
        Me.Lbl_Constraseña.Font = New System.Drawing.Font("Constantia", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Constraseña.Location = New System.Drawing.Point(47, 224)
        Me.Lbl_Constraseña.Name = "Lbl_Constraseña"
        Me.Lbl_Constraseña.Size = New System.Drawing.Size(116, 23)
        Me.Lbl_Constraseña.TabIndex = 5
        Me.Lbl_Constraseña.Text = "Constraseña:"
        '
        'Btn_IniciarSesion
        '
        Me.Btn_IniciarSesion.Font = New System.Drawing.Font("Constantia", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_IniciarSesion.Location = New System.Drawing.Point(183, 266)
        Me.Btn_IniciarSesion.Name = "Btn_IniciarSesion"
        Me.Btn_IniciarSesion.Size = New System.Drawing.Size(135, 40)
        Me.Btn_IniciarSesion.TabIndex = 7
        Me.Btn_IniciarSesion.Text = "Iniciar sesión"
        Me.Btn_IniciarSesion.UseVisualStyleBackColor = True
        '
        'LbRegistrarNuevoCliente
        '
        Me.LbRegistrarNuevoCliente.AutoSize = True
        Me.LbRegistrarNuevoCliente.Location = New System.Drawing.Point(186, 327)
        Me.LbRegistrarNuevoCliente.Name = "LbRegistrarNuevoCliente"
        Me.LbRegistrarNuevoCliente.Size = New System.Drawing.Size(132, 13)
        Me.LbRegistrarNuevoCliente.TabIndex = 8
        Me.LbRegistrarNuevoCliente.TabStop = True
        Me.LbRegistrarNuevoCliente.Text = "Registrar un nuevo Cliente"
        '
        'frm_Bienvenida
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.CornflowerBlue
        Me.ClientSize = New System.Drawing.Size(484, 461)
        Me.Controls.Add(Me.LbRegistrarNuevoCliente)
        Me.Controls.Add(Me.Btn_IniciarSesion)
        Me.Controls.Add(Me.Txt_ConstraseñaREQ)
        Me.Controls.Add(Me.Lbl_Constraseña)
        Me.Controls.Add(Me.Txt_UsuarioREQ)
        Me.Controls.Add(Me.Lbl_Usuario)
        Me.Controls.Add(Me.lbl_Aclaración)
        Me.Controls.Add(Me.lbl_SIGESVI)
        Me.Controls.Add(Me.lbl_Bienvenida)
        Me.Name = "frm_Bienvenida"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Bienvenida"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbl_Bienvenida As System.Windows.Forms.Label
    Friend WithEvents lbl_SIGESVI As System.Windows.Forms.Label
    Friend WithEvents lbl_Aclaración As System.Windows.Forms.Label
    Friend WithEvents Lbl_Usuario As System.Windows.Forms.Label
    Friend WithEvents Txt_UsuarioREQ As System.Windows.Forms.TextBox
    Friend WithEvents Txt_ConstraseñaREQ As System.Windows.Forms.TextBox
    Friend WithEvents Lbl_Constraseña As System.Windows.Forms.Label
    Friend WithEvents Btn_IniciarSesion As System.Windows.Forms.Button
    Friend WithEvents LbRegistrarNuevoCliente As System.Windows.Forms.LinkLabel

End Class
