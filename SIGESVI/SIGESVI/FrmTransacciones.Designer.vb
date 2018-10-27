<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmTransacciones
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmTransacciones))
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.BtnTraslado = New System.Windows.Forms.PictureBox
        Me.BtnCompra = New System.Windows.Forms.PictureBox
        Me.BtnVenta = New System.Windows.Forms.PictureBox
        CType(Me.BtnTraslado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnCompra, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnVenta, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        'Label5
        '
        Me.Label5.AccessibleDescription = Nothing
        Me.Label5.AccessibleName = Nothing
        resources.ApplyResources(Me.Label5, "Label5")
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Name = "Label5"
        '
        'BtnTraslado
        '
        Me.BtnTraslado.AccessibleDescription = Nothing
        Me.BtnTraslado.AccessibleName = Nothing
        resources.ApplyResources(Me.BtnTraslado, "BtnTraslado")
        Me.BtnTraslado.BackColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(149, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.BtnTraslado.BackgroundImage = Nothing
        Me.BtnTraslado.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnTraslado.Font = Nothing
        Me.BtnTraslado.Image = Global.SIGESVI.My.Resources.Resources.delivery_truck
        Me.BtnTraslado.ImageLocation = Nothing
        Me.BtnTraslado.Name = "BtnTraslado"
        Me.BtnTraslado.TabStop = False
        '
        'BtnCompra
        '
        Me.BtnCompra.AccessibleDescription = Nothing
        Me.BtnCompra.AccessibleName = Nothing
        resources.ApplyResources(Me.BtnCompra, "BtnCompra")
        Me.BtnCompra.BackColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(149, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.BtnCompra.BackgroundImage = Nothing
        Me.BtnCompra.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnCompra.Font = Nothing
        Me.BtnCompra.Image = Global.SIGESVI.My.Resources.Resources.compra
        Me.BtnCompra.ImageLocation = Nothing
        Me.BtnCompra.Name = "BtnCompra"
        Me.BtnCompra.TabStop = False
        '
        'BtnVenta
        '
        Me.BtnVenta.AccessibleDescription = Nothing
        Me.BtnVenta.AccessibleName = Nothing
        resources.ApplyResources(Me.BtnVenta, "BtnVenta")
        Me.BtnVenta.BackColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(149, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.BtnVenta.BackgroundImage = Nothing
        Me.BtnVenta.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnVenta.Font = Nothing
        Me.BtnVenta.Image = Global.SIGESVI.My.Resources.Resources.venta
        Me.BtnVenta.ImageLocation = Nothing
        Me.BtnVenta.Name = "BtnVenta"
        Me.BtnVenta.TabStop = False
        '
        'FrmTransacciones
        '
        Me.AccessibleDescription = Nothing
        Me.AccessibleName = Nothing
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.BackgroundImage = Nothing
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.BtnTraslado)
        Me.Controls.Add(Me.BtnCompra)
        Me.Controls.Add(Me.BtnVenta)
        Me.Font = Nothing
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = Nothing
        Me.Name = "FrmTransacciones"
        CType(Me.BtnTraslado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnCompra, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnVenta, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BtnTraslado As System.Windows.Forms.PictureBox
    Friend WithEvents BtnCompra As System.Windows.Forms.PictureBox
    Friend WithEvents BtnVenta As System.Windows.Forms.PictureBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
End Class
