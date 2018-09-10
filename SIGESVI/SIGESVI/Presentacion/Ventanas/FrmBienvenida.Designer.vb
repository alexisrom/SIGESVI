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
        Me.Label1 = New System.Windows.Forms.Label
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.TextBox2 = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button
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
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Constantia", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(67, 190)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 23)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Usuario:"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(153, 192)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(175, 20)
        Me.TextBox1.TabIndex = 4
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(153, 228)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(175, 20)
        Me.TextBox2.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Constantia", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(30, 224)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(116, 23)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Constraseña:"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Constantia", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(164, 277)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(135, 40)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "Iniciar sesión"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'frm_Bienvenida
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(484, 461)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label1)
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
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button

End Class
