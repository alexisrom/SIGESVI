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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_Bienvenida))
        Me.lbl_Bienvenida = New System.Windows.Forms.Label
        Me.lbl_SIGESVI = New System.Windows.Forms.Label
        Me.lbl_Aclaración = New System.Windows.Forms.Label
        Me.lbl_Ingreso = New System.Windows.Forms.Label
        Me.btn_IngresarAlSistema = New System.Windows.Forms.Button
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.lbl_Elaborado = New System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'lbl_Ingreso
        '
        Me.lbl_Ingreso.AutoSize = True
        Me.lbl_Ingreso.Font = New System.Drawing.Font("Constantia", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Ingreso.Location = New System.Drawing.Point(197, 337)
        Me.lbl_Ingreso.Name = "lbl_Ingreso"
        Me.lbl_Ingreso.Size = New System.Drawing.Size(100, 19)
        Me.lbl_Ingreso.TabIndex = 3
        Me.lbl_Ingreso.Text = "Iniciar como:"
        '
        'btn_IngresarAlSistema
        '
        Me.btn_IngresarAlSistema.Font = New System.Drawing.Font("Constantia", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_IngresarAlSistema.Location = New System.Drawing.Point(45, 360)
        Me.btn_IngresarAlSistema.Name = "btn_IngresarAlSistema"
        Me.btn_IngresarAlSistema.Size = New System.Drawing.Size(130, 52)
        Me.btn_IngresarAlSistema.TabIndex = 4
        Me.btn_IngresarAlSistema.Text = "Funcionario"
        Me.btn_IngresarAlSistema.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(173, 193)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(141, 125)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'lbl_Elaborado
        '
        Me.lbl_Elaborado.AutoSize = True
        Me.lbl_Elaborado.Font = New System.Drawing.Font("Constantia", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Elaborado.Location = New System.Drawing.Point(184, 171)
        Me.lbl_Elaborado.Name = "lbl_Elaborado"
        Me.lbl_Elaborado.Size = New System.Drawing.Size(113, 19)
        Me.lbl_Elaborado.TabIndex = 6
        Me.lbl_Elaborado.Text = "Elaborado por:"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Constantia", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(307, 360)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(130, 52)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "Cliente"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'frm_Bienvenida
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Menu
        Me.ClientSize = New System.Drawing.Size(484, 461)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.lbl_Elaborado)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btn_IngresarAlSistema)
        Me.Controls.Add(Me.lbl_Ingreso)
        Me.Controls.Add(Me.lbl_Aclaración)
        Me.Controls.Add(Me.lbl_SIGESVI)
        Me.Controls.Add(Me.lbl_Bienvenida)
        Me.Name = "frm_Bienvenida"
        Me.Text = "Bienvenida"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbl_Bienvenida As System.Windows.Forms.Label
    Friend WithEvents lbl_SIGESVI As System.Windows.Forms.Label
    Friend WithEvents lbl_Aclaración As System.Windows.Forms.Label
    Friend WithEvents lbl_Ingreso As System.Windows.Forms.Label
    Friend WithEvents btn_IngresarAlSistema As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents lbl_Elaborado As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button

End Class
