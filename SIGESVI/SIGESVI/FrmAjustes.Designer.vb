<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAjustes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmAjustes))
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.PicVehiculos = New System.Windows.Forms.PictureBox
        Me.Pic_UBICACION = New System.Windows.Forms.PictureBox
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        CType(Me.PicVehiculos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Pic_UBICACION, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AccessibleDescription = Nothing
        Me.Label1.AccessibleName = Nothing
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Name = "Label1"
        '
        'Label3
        '
        Me.Label3.AccessibleDescription = Nothing
        Me.Label3.AccessibleName = Nothing
        resources.ApplyResources(Me.Label3, "Label3")
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Name = "Label3"
        '
        'Label4
        '
        Me.Label4.AccessibleDescription = Nothing
        Me.Label4.AccessibleName = Nothing
        resources.ApplyResources(Me.Label4, "Label4")
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Name = "Label4"
        '
        'PicVehiculos
        '
        Me.PicVehiculos.AccessibleDescription = Nothing
        Me.PicVehiculos.AccessibleName = Nothing
        resources.ApplyResources(Me.PicVehiculos, "PicVehiculos")
        Me.PicVehiculos.BackColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(149, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.PicVehiculos.BackgroundImage = Nothing
        Me.PicVehiculos.Font = Nothing
        Me.PicVehiculos.Image = Global.SIGESVI.My.Resources.Resources.traslados
        Me.PicVehiculos.ImageLocation = Nothing
        Me.PicVehiculos.Name = "PicVehiculos"
        Me.PicVehiculos.TabStop = False
        '
        'Pic_UBICACION
        '
        Me.Pic_UBICACION.AccessibleDescription = Nothing
        Me.Pic_UBICACION.AccessibleName = Nothing
        resources.ApplyResources(Me.Pic_UBICACION, "Pic_UBICACION")
        Me.Pic_UBICACION.BackColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(149, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.Pic_UBICACION.BackgroundImage = Nothing
        Me.Pic_UBICACION.Font = Nothing
        Me.Pic_UBICACION.Image = Global.SIGESVI.My.Resources.Resources.placeholder
        Me.Pic_UBICACION.ImageLocation = Nothing
        Me.Pic_UBICACION.Name = "Pic_UBICACION"
        Me.Pic_UBICACION.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.AccessibleDescription = Nothing
        Me.PictureBox1.AccessibleName = Nothing
        resources.ApplyResources(Me.PictureBox1, "PictureBox1")
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(149, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.PictureBox1.BackgroundImage = Nothing
        Me.PictureBox1.Font = Nothing
        Me.PictureBox1.Image = Global.SIGESVI.My.Resources.Resources.cepa
        Me.PictureBox1.ImageLocation = Nothing
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.TabStop = False
        '
        'FrmAjustes
        '
        Me.AccessibleDescription = Nothing
        Me.AccessibleName = Nothing
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.BackgroundImage = Nothing
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PicVehiculos)
        Me.Controls.Add(Me.Pic_UBICACION)
        Me.Controls.Add(Me.PictureBox1)
        Me.Font = Nothing
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = Nothing
        Me.Name = "FrmAjustes"
        CType(Me.PicVehiculos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Pic_UBICACION, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Pic_UBICACION As System.Windows.Forms.PictureBox
    Friend WithEvents PicVehiculos As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
End Class
