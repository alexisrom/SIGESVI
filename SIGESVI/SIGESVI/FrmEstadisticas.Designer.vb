<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmEstadisticas
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
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Pic_UBICACION = New System.Windows.Forms.PictureBox
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.PicReservas = New System.Windows.Forms.PictureBox
        CType(Me.Pic_UBICACION, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicReservas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(471, 311)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(129, 30)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "UBICACIÓN"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(304, 311)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(116, 30)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "ORIGENES"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(144, 311)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(116, 30)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "RESERVAS"
        '
        'Pic_UBICACION
        '
        Me.Pic_UBICACION.BackColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(149, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.Pic_UBICACION.Image = Global.SIGESVI.My.Resources.Resources.placeholder
        Me.Pic_UBICACION.Location = New System.Drawing.Point(470, 178)
        Me.Pic_UBICACION.Name = "Pic_UBICACION"
        Me.Pic_UBICACION.Size = New System.Drawing.Size(130, 130)
        Me.Pic_UBICACION.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.Pic_UBICACION.TabIndex = 14
        Me.Pic_UBICACION.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(149, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.PictureBox2.Image = Global.SIGESVI.My.Resources.Resources.field
        Me.PictureBox2.Location = New System.Drawing.Point(299, 178)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(130, 130)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox2.TabIndex = 13
        Me.PictureBox2.TabStop = False
        '
        'PicReservas
        '
        Me.PicReservas.BackColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(149, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.PicReservas.Image = Global.SIGESVI.My.Resources.Resources.cepa
        Me.PicReservas.Location = New System.Drawing.Point(130, 178)
        Me.PicReservas.Name = "PicReservas"
        Me.PicReservas.Size = New System.Drawing.Size(130, 130)
        Me.PicReservas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PicReservas.TabIndex = 12
        Me.PicReservas.TabStop = False
        '
        'FrmEstadisticas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1144, 584)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Pic_UBICACION)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PicReservas)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmEstadisticas"
        Me.Text = "FrmEstadisticas"
        CType(Me.Pic_UBICACION, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicReservas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Pic_UBICACION As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PicReservas As System.Windows.Forms.PictureBox
End Class
