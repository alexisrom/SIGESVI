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
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(429, 302)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(82, 30)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "VENTA"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(142, 302)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(104, 30)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "COMPRA"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(723, 302)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(135, 30)
        Me.Label5.TabIndex = 18
        Me.Label5.Text = "TRASLADOS"
        '
        'BtnTraslado
        '
        Me.BtnTraslado.BackColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(149, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.BtnTraslado.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnTraslado.Image = Global.SIGESVI.My.Resources.Resources.delivery_truck
        Me.BtnTraslado.Location = New System.Drawing.Point(728, 169)
        Me.BtnTraslado.Name = "BtnTraslado"
        Me.BtnTraslado.Size = New System.Drawing.Size(130, 130)
        Me.BtnTraslado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.BtnTraslado.TabIndex = 13
        Me.BtnTraslado.TabStop = False
        '
        'BtnCompra
        '
        Me.BtnCompra.BackColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(149, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.BtnCompra.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnCompra.Image = Global.SIGESVI.My.Resources.Resources.compra
        Me.BtnCompra.Location = New System.Drawing.Point(128, 169)
        Me.BtnCompra.Name = "BtnCompra"
        Me.BtnCompra.Size = New System.Drawing.Size(130, 130)
        Me.BtnCompra.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.BtnCompra.TabIndex = 12
        Me.BtnCompra.TabStop = False
        '
        'BtnVenta
        '
        Me.BtnVenta.BackColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(149, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.BtnVenta.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnVenta.Image = Global.SIGESVI.My.Resources.Resources.venta
        Me.BtnVenta.Location = New System.Drawing.Point(403, 169)
        Me.BtnVenta.Name = "BtnVenta"
        Me.BtnVenta.Size = New System.Drawing.Size(130, 130)
        Me.BtnVenta.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.BtnVenta.TabIndex = 11
        Me.BtnVenta.TabStop = False
        '
        'FrmTransacciones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1007, 499)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.BtnTraslado)
        Me.Controls.Add(Me.BtnCompra)
        Me.Controls.Add(Me.BtnVenta)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmTransacciones"
        Me.Text = "FrmTransacciones"
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
