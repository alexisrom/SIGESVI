<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MenuAsesorProfesional
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
        Me.PnlMenu = New System.Windows.Forms.Panel
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.Panel4 = New System.Windows.Forms.Panel
        Me.BtnProductos = New System.Windows.Forms.Button
        Me.BtnProduccion = New System.Windows.Forms.Button
        Me.PicLogo = New System.Windows.Forms.PictureBox
        Me.PnlMenu.SuspendLayout()
        CType(Me.PicLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PnlMenu
        '
        Me.PnlMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(151, Byte), Integer))
        Me.PnlMenu.Controls.Add(Me.Panel3)
        Me.PnlMenu.Controls.Add(Me.Panel4)
        Me.PnlMenu.Controls.Add(Me.BtnProductos)
        Me.PnlMenu.Controls.Add(Me.BtnProduccion)
        Me.PnlMenu.Controls.Add(Me.PicLogo)
        Me.PnlMenu.Dock = System.Windows.Forms.DockStyle.Left
        Me.PnlMenu.Location = New System.Drawing.Point(0, 0)
        Me.PnlMenu.Name = "PnlMenu"
        Me.PnlMenu.Size = New System.Drawing.Size(200, 610)
        Me.PnlMenu.TabIndex = 9
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(205, Byte), Integer))
        Me.Panel3.Cursor = System.Windows.Forms.Cursors.Default
        Me.Panel3.Location = New System.Drawing.Point(3, 206)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(5, 40)
        Me.Panel3.TabIndex = 4
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(205, Byte), Integer))
        Me.Panel4.Cursor = System.Windows.Forms.Cursors.Default
        Me.Panel4.Location = New System.Drawing.Point(3, 160)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(5, 40)
        Me.Panel4.TabIndex = 2
        '
        'BtnProductos
        '
        Me.BtnProductos.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(151, Byte), Integer))
        Me.BtnProductos.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnProductos.FlatAppearance.BorderSize = 0
        Me.BtnProductos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(205, Byte), Integer))
        Me.BtnProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnProductos.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnProductos.ForeColor = System.Drawing.Color.White
        Me.BtnProductos.Image = Global.SIGESVI.My.Resources.Resources.product
        Me.BtnProductos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnProductos.Location = New System.Drawing.Point(7, 206)
        Me.BtnProductos.Name = "BtnProductos"
        Me.BtnProductos.Size = New System.Drawing.Size(190, 40)
        Me.BtnProductos.TabIndex = 5
        Me.BtnProductos.Text = "Productos"
        Me.BtnProductos.UseVisualStyleBackColor = False
        '
        'BtnProduccion
        '
        Me.BtnProduccion.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(151, Byte), Integer))
        Me.BtnProduccion.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnProduccion.FlatAppearance.BorderSize = 0
        Me.BtnProduccion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(205, Byte), Integer))
        Me.BtnProduccion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnProduccion.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnProduccion.ForeColor = System.Drawing.Color.White
        Me.BtnProduccion.Image = Global.SIGESVI.My.Resources.Resources.mass_production
        Me.BtnProduccion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnProduccion.Location = New System.Drawing.Point(7, 160)
        Me.BtnProduccion.Name = "BtnProduccion"
        Me.BtnProduccion.Size = New System.Drawing.Size(190, 40)
        Me.BtnProduccion.TabIndex = 3
        Me.BtnProduccion.Text = " Producción"
        Me.BtnProduccion.UseVisualStyleBackColor = False
        '
        'PicLogo
        '
        Me.PicLogo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PicLogo.Image = Global.SIGESVI.My.Resources.Resources.enoturismo_2
        Me.PicLogo.Location = New System.Drawing.Point(0, 0)
        Me.PicLogo.Name = "PicLogo"
        Me.PicLogo.Size = New System.Drawing.Size(200, 135)
        Me.PicLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PicLogo.TabIndex = 0
        Me.PicLogo.TabStop = False
        '
        'MenuAsesorProfesional
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.PnlMenu)
        Me.Name = "MenuAsesorProfesional"
        Me.Size = New System.Drawing.Size(200, 610)
        Me.PnlMenu.ResumeLayout(False)
        CType(Me.PicLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PnlMenu As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents BtnProductos As System.Windows.Forms.Button
    Friend WithEvents BtnProduccion As System.Windows.Forms.Button
    Friend WithEvents PicLogo As System.Windows.Forms.PictureBox

End Class
