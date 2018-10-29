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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmEstadisticas))
        Me.Label1 = New System.Windows.Forms.Label
        Me.PicReservas = New System.Windows.Forms.PictureBox
        CType(Me.PicReservas, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'PicReservas
        '
        Me.PicReservas.AccessibleDescription = Nothing
        Me.PicReservas.AccessibleName = Nothing
        resources.ApplyResources(Me.PicReservas, "PicReservas")
        Me.PicReservas.BackColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(149, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.PicReservas.BackgroundImage = Nothing
        Me.PicReservas.Font = Nothing
        Me.PicReservas.Image = Global.SIGESVI.My.Resources.Resources.online_booking
        Me.PicReservas.ImageLocation = Nothing
        Me.PicReservas.Name = "PicReservas"
        Me.PicReservas.TabStop = False
        '
        'FrmEstadisticas
        '
        Me.AccessibleDescription = Nothing
        Me.AccessibleName = Nothing
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.BackgroundImage = Nothing
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PicReservas)
        Me.Font = Nothing
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = Nothing
        Me.Name = "FrmEstadisticas"
        CType(Me.PicReservas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PicReservas As System.Windows.Forms.PictureBox
End Class
