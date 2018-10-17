<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SelectorImagen
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.BtnSeleccionarImagen = New System.Windows.Forms.Button
        Me.OfdSeleccionarImagen = New System.Windows.Forms.OpenFileDialog
        Me.PbFoto = New System.Windows.Forms.PictureBox
        CType(Me.PbFoto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnSeleccionarImagen
        '
        Me.BtnSeleccionarImagen.Location = New System.Drawing.Point(31, 103)
        Me.BtnSeleccionarImagen.Name = "BtnSeleccionarImagen"
        Me.BtnSeleccionarImagen.Size = New System.Drawing.Size(88, 23)
        Me.BtnSeleccionarImagen.TabIndex = 119
        Me.BtnSeleccionarImagen.Text = "Seleccionar"
        Me.BtnSeleccionarImagen.UseVisualStyleBackColor = True
        '
        'OfdSeleccionarImagen
        '
        Me.OfdSeleccionarImagen.Filter = "JPEG|*.JPG|PNG|*.PNG"
        Me.OfdSeleccionarImagen.Title = "Seleccionar imagen"
        '
        'PbFoto
        '
        Me.PbFoto.BackColor = System.Drawing.SystemColors.ControlDark
        Me.PbFoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PbFoto.Location = New System.Drawing.Point(31, 24)
        Me.PbFoto.Name = "PbFoto"
        Me.PbFoto.Size = New System.Drawing.Size(88, 73)
        Me.PbFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PbFoto.TabIndex = 118
        Me.PbFoto.TabStop = False
        '
        'SelectorImagen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.BtnSeleccionarImagen)
        Me.Controls.Add(Me.PbFoto)
        Me.Name = "SelectorImagen"
        CType(Me.PbFoto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BtnSeleccionarImagen As System.Windows.Forms.Button
    Friend WithEvents PbFoto As System.Windows.Forms.PictureBox
    Friend WithEvents OfdSeleccionarImagen As System.Windows.Forms.OpenFileDialog

End Class
