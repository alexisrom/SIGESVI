<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MenuCliente
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
        Me.Label1 = New System.Windows.Forms.Label
        Me.BtnCompetarReserva = New System.Windows.Forms.Button
        Me.LstProductos = New System.Windows.Forms.ListBox
        Me.RadioButton2 = New System.Windows.Forms.RadioButton
        Me.RadioButton1 = New System.Windows.Forms.RadioButton
        Me.BtnQuitarProducto = New System.Windows.Forms.Button
        Me.LblCantidadProductos = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.CheckBox3 = New System.Windows.Forms.CheckBox
        Me.CheckBox2 = New System.Windows.Forms.CheckBox
        Me.CheckBox1 = New System.Windows.Forms.CheckBox
        Me.PicLogo = New System.Windows.Forms.PictureBox
        Me.PnlMenu.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PnlMenu
        '
        Me.PnlMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(151, Byte), Integer))
        Me.PnlMenu.Controls.Add(Me.Label1)
        Me.PnlMenu.Controls.Add(Me.BtnCompetarReserva)
        Me.PnlMenu.Controls.Add(Me.LstProductos)
        Me.PnlMenu.Controls.Add(Me.RadioButton2)
        Me.PnlMenu.Controls.Add(Me.RadioButton1)
        Me.PnlMenu.Controls.Add(Me.BtnQuitarProducto)
        Me.PnlMenu.Controls.Add(Me.LblCantidadProductos)
        Me.PnlMenu.Controls.Add(Me.PictureBox1)
        Me.PnlMenu.Controls.Add(Me.CheckBox3)
        Me.PnlMenu.Controls.Add(Me.CheckBox2)
        Me.PnlMenu.Controls.Add(Me.CheckBox1)
        Me.PnlMenu.Controls.Add(Me.PicLogo)
        Me.PnlMenu.Dock = System.Windows.Forms.DockStyle.Left
        Me.PnlMenu.Location = New System.Drawing.Point(0, 0)
        Me.PnlMenu.Name = "PnlMenu"
        Me.PnlMenu.Size = New System.Drawing.Size(200, 610)
        Me.PnlMenu.TabIndex = 8
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(74, 165)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 17)
        Me.Label1.TabIndex = 48
        Me.Label1.Text = "CANTIDAD"
        '
        'BtnCompetarReserva
        '
        Me.BtnCompetarReserva.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.BtnCompetarReserva.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(161, Byte), Integer))
        Me.BtnCompetarReserva.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnCompetarReserva.FlatAppearance.BorderSize = 0
        Me.BtnCompetarReserva.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCompetarReserva.Font = New System.Drawing.Font("Roboto", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCompetarReserva.ForeColor = System.Drawing.Color.White
        Me.BtnCompetarReserva.Location = New System.Drawing.Point(23, 554)
        Me.BtnCompetarReserva.Name = "BtnCompetarReserva"
        Me.BtnCompetarReserva.Size = New System.Drawing.Size(144, 34)
        Me.BtnCompetarReserva.TabIndex = 47
        Me.BtnCompetarReserva.Text = "COMPLETAR RESERVA"
        Me.BtnCompetarReserva.UseVisualStyleBackColor = False
        '
        'LstProductos
        '
        Me.LstProductos.BackColor = System.Drawing.Color.FromArgb(CType(CType(124, Byte), Integer), CType(CType(107, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.LstProductos.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.LstProductos.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LstProductos.ForeColor = System.Drawing.Color.White
        Me.LstProductos.FormattingEnabled = True
        Me.LstProductos.Location = New System.Drawing.Point(22, 220)
        Me.LstProductos.Name = "LstProductos"
        Me.LstProductos.Size = New System.Drawing.Size(148, 117)
        Me.LstProductos.TabIndex = 46
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.RadioButton2.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadioButton2.ForeColor = System.Drawing.Color.White
        Me.RadioButton2.Location = New System.Drawing.Point(23, 496)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(82, 25)
        Me.RadioButton2.TabIndex = 45
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "MOSTO"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.RadioButton1.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadioButton1.ForeColor = System.Drawing.Color.White
        Me.RadioButton1.Location = New System.Drawing.Point(23, 465)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(74, 25)
        Me.RadioButton1.TabIndex = 44
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "VINOS"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'BtnQuitarProducto
        '
        Me.BtnQuitarProducto.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnQuitarProducto.BackColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(205, Byte), Integer))
        Me.BtnQuitarProducto.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnQuitarProducto.FlatAppearance.BorderSize = 0
        Me.BtnQuitarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnQuitarProducto.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnQuitarProducto.ForeColor = System.Drawing.Color.White
        Me.BtnQuitarProducto.Location = New System.Drawing.Point(77, 188)
        Me.BtnQuitarProducto.Name = "BtnQuitarProducto"
        Me.BtnQuitarProducto.Size = New System.Drawing.Size(93, 23)
        Me.BtnQuitarProducto.TabIndex = 43
        Me.BtnQuitarProducto.Text = "QUITAR PRODUCTO"
        Me.BtnQuitarProducto.UseVisualStyleBackColor = False
        '
        'LblCantidadProductos
        '
        Me.LblCantidadProductos.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCantidadProductos.ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.LblCantidadProductos.Location = New System.Drawing.Point(141, 164)
        Me.LblCantidadProductos.Name = "LblCantidadProductos"
        Me.LblCantidadProductos.Size = New System.Drawing.Size(43, 18)
        Me.LblCantidadProductos.TabIndex = 42
        Me.LblCantidadProductos.Text = "(0)"
        Me.LblCantidadProductos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.SIGESVI.My.Resources.Resources.shopping_cart
        Me.PictureBox1.Location = New System.Drawing.Point(22, 165)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(45, 45)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 41
        Me.PictureBox1.TabStop = False
        '
        'CheckBox3
        '
        Me.CheckBox3.AutoSize = True
        Me.CheckBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CheckBox3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox3.ForeColor = System.Drawing.Color.White
        Me.CheckBox3.Location = New System.Drawing.Point(23, 413)
        Me.CheckBox3.Name = "CheckBox3"
        Me.CheckBox3.Size = New System.Drawing.Size(87, 25)
        Me.CheckBox3.TabIndex = 3
        Me.CheckBox3.Text = "BLANCO"
        Me.CheckBox3.UseVisualStyleBackColor = True
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CheckBox2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox2.ForeColor = System.Drawing.Color.White
        Me.CheckBox2.Location = New System.Drawing.Point(23, 382)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(90, 25)
        Me.CheckBox2.TabIndex = 2
        Me.CheckBox2.Text = "ROSADO"
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CheckBox1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox1.ForeColor = System.Drawing.Color.White
        Me.CheckBox1.Location = New System.Drawing.Point(23, 351)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(70, 25)
        Me.CheckBox1.TabIndex = 1
        Me.CheckBox1.Text = "TINTO"
        Me.CheckBox1.UseVisualStyleBackColor = True
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
        'MenuCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.PnlMenu)
        Me.Name = "MenuCliente"
        Me.Size = New System.Drawing.Size(200, 610)
        Me.PnlMenu.ResumeLayout(False)
        Me.PnlMenu.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PnlMenu As System.Windows.Forms.Panel
    Friend WithEvents PicLogo As System.Windows.Forms.PictureBox
    Friend WithEvents CheckBox2 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox3 As System.Windows.Forms.CheckBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents LblCantidadProductos As System.Windows.Forms.Label
    Friend WithEvents LstProductos As System.Windows.Forms.ListBox
    Friend WithEvents BtnQuitarProducto As System.Windows.Forms.Button
    Friend WithEvents BtnCompetarReserva As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton

End Class
