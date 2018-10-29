<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmLenguaje
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
        Me.BtnEspanol = New System.Windows.Forms.Button
        Me.BtnIngles = New System.Windows.Forms.Button
        Me.PicClose = New System.Windows.Forms.PictureBox
        CType(Me.PicClose, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnEspanol
        '
        Me.BtnEspanol.BackColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(205, Byte), Integer))
        Me.BtnEspanol.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnEspanol.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEspanol.ForeColor = System.Drawing.Color.White
        Me.BtnEspanol.Location = New System.Drawing.Point(34, 96)
        Me.BtnEspanol.Name = "BtnEspanol"
        Me.BtnEspanol.Size = New System.Drawing.Size(87, 36)
        Me.BtnEspanol.TabIndex = 0
        Me.BtnEspanol.Text = "Español"
        Me.BtnEspanol.UseVisualStyleBackColor = False
        '
        'BtnIngles
        '
        Me.BtnIngles.BackColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(205, Byte), Integer))
        Me.BtnIngles.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnIngles.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnIngles.ForeColor = System.Drawing.Color.White
        Me.BtnIngles.Location = New System.Drawing.Point(171, 96)
        Me.BtnIngles.Name = "BtnIngles"
        Me.BtnIngles.Size = New System.Drawing.Size(87, 36)
        Me.BtnIngles.TabIndex = 1
        Me.BtnIngles.Text = "English"
        Me.BtnIngles.UseVisualStyleBackColor = False
        '
        'PicClose
        '
        Me.PicClose.Image = Global.SIGESVI.My.Resources.Resources.close
        Me.PicClose.Location = New System.Drawing.Point(268, 12)
        Me.PicClose.Name = "PicClose"
        Me.PicClose.Size = New System.Drawing.Size(20, 20)
        Me.PicClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PicClose.TabIndex = 2
        Me.PicClose.TabStop = False
        '
        'FrmLenguaje
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(151, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(300, 213)
        Me.Controls.Add(Me.PicClose)
        Me.Controls.Add(Me.BtnIngles)
        Me.Controls.Add(Me.BtnEspanol)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmLenguaje"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmLenguaje"
        CType(Me.PicClose, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BtnEspanol As System.Windows.Forms.Button
    Friend WithEvents BtnIngles As System.Windows.Forms.Button
    Friend WithEvents PicClose As System.Windows.Forms.PictureBox
End Class
