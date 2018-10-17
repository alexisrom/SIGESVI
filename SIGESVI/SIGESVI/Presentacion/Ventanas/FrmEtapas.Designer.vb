<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmEtapas
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
        Me.BtnAgregarEtapa = New System.Windows.Forms.Button
        Me.Label14 = New System.Windows.Forms.Label
        Me.TxtDuracion_NUM_REQ = New System.Windows.Forms.TextBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.TxtDescripcion_REQ = New System.Windows.Forms.TextBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.TxtNumero_NUM_REQ = New System.Windows.Forms.TextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.TxtNombre_REQ = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'BtnAgregarEtapa
        '
        Me.BtnAgregarEtapa.Location = New System.Drawing.Point(263, 210)
        Me.BtnAgregarEtapa.Name = "BtnAgregarEtapa"
        Me.BtnAgregarEtapa.Size = New System.Drawing.Size(130, 36)
        Me.BtnAgregarEtapa.TabIndex = 127
        Me.BtnAgregarEtapa.Text = "Agregar etapa"
        Me.BtnAgregarEtapa.UseVisualStyleBackColor = True
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(359, 37)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(34, 18)
        Me.Label14.TabIndex = 121
        Me.Label14.Text = "días"
        '
        'TxtDuracion_NUM_REQ
        '
        Me.TxtDuracion_NUM_REQ.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDuracion_NUM_REQ.Location = New System.Drawing.Point(308, 33)
        Me.TxtDuracion_NUM_REQ.Name = "TxtDuracion_NUM_REQ"
        Me.TxtDuracion_NUM_REQ.Size = New System.Drawing.Size(33, 24)
        Me.TxtDuracion_NUM_REQ.TabIndex = 120
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(233, 37)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(69, 18)
        Me.Label13.TabIndex = 119
        Me.Label13.Text = "Duración"
        '
        'TxtDescripcion_REQ
        '
        Me.TxtDescripcion_REQ.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDescripcion_REQ.Location = New System.Drawing.Point(131, 93)
        Me.TxtDescripcion_REQ.Multiline = True
        Me.TxtDescripcion_REQ.Name = "TxtDescripcion_REQ"
        Me.TxtDescripcion_REQ.Size = New System.Drawing.Size(262, 111)
        Me.TxtDescripcion_REQ.TabIndex = 118
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(40, 117)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(85, 18)
        Me.Label12.TabIndex = 117
        Me.Label12.Text = "Descripción"
        '
        'TxtNumero_NUM_REQ
        '
        Me.TxtNumero_NUM_REQ.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNumero_NUM_REQ.Location = New System.Drawing.Point(131, 31)
        Me.TxtNumero_NUM_REQ.Name = "TxtNumero_NUM_REQ"
        Me.TxtNumero_NUM_REQ.Size = New System.Drawing.Size(40, 24)
        Me.TxtNumero_NUM_REQ.TabIndex = 116
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(40, 37)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(62, 18)
        Me.Label11.TabIndex = 115
        Me.Label11.Text = "Número"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(40, 66)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(61, 18)
        Me.Label10.TabIndex = 114
        Me.Label10.Text = "Nombre"
        '
        'TxtNombre_REQ
        '
        Me.TxtNombre_REQ.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNombre_REQ.Location = New System.Drawing.Point(131, 62)
        Me.TxtNombre_REQ.Name = "TxtNombre_REQ"
        Me.TxtNombre_REQ.Size = New System.Drawing.Size(262, 24)
        Me.TxtNombre_REQ.TabIndex = 113
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(559, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(92, 18)
        Me.Label1.TabIndex = 128
        Me.Label1.Text = "Recordatorio"
        '
        'FrmEtapas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.CornflowerBlue
        Me.ClientSize = New System.Drawing.Size(754, 290)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtnAgregarEtapa)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.TxtDuracion_NUM_REQ)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.TxtDescripcion_REQ)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.TxtNumero_NUM_REQ)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.TxtNombre_REQ)
        Me.Font = New System.Drawing.Font("Constantia", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FrmEtapas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Etapas de elaboracion"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BtnAgregarEtapa As System.Windows.Forms.Button
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents TxtDuracion_NUM_REQ As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents TxtDescripcion_REQ As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents TxtNumero_NUM_REQ As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents TxtNombre_REQ As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
