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
        Me.CheckBox1 = New System.Windows.Forms.CheckBox
        Me.CheckBox2 = New System.Windows.Forms.CheckBox
        Me.CheckBox3 = New System.Windows.Forms.CheckBox
        Me.CboTipoProducto = New System.Windows.Forms.ComboBox
        Me.LblCantidadProductos = New System.Windows.Forms.Label
        Me.BtnEliminar = New System.Windows.Forms.Button
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.PicLogo = New System.Windows.Forms.PictureBox
        Me.PnlMenu.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PnlMenu
        '
        Me.PnlMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(151, Byte), Integer))
        Me.PnlMenu.Controls.Add(Me.BtnEliminar)
        Me.PnlMenu.Controls.Add(Me.LblCantidadProductos)
        Me.PnlMenu.Controls.Add(Me.PictureBox1)
        Me.PnlMenu.Controls.Add(Me.CboTipoProducto)
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
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CheckBox1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox1.ForeColor = System.Drawing.Color.White
        Me.CheckBox1.Location = New System.Drawing.Point(23, 341)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(70, 25)
        Me.CheckBox1.TabIndex = 1
        Me.CheckBox1.Text = "TINTO"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CheckBox2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox2.ForeColor = System.Drawing.Color.White
        Me.CheckBox2.Location = New System.Drawing.Point(23, 372)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(90, 25)
        Me.CheckBox2.TabIndex = 2
        Me.CheckBox2.Text = "ROSADO"
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'CheckBox3
        '
        Me.CheckBox3.AutoSize = True
        Me.CheckBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CheckBox3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox3.ForeColor = System.Drawing.Color.White
        Me.CheckBox3.Location = New System.Drawing.Point(23, 403)
        Me.CheckBox3.Name = "CheckBox3"
        Me.CheckBox3.Size = New System.Drawing.Size(87, 25)
        Me.CheckBox3.TabIndex = 3
        Me.CheckBox3.Text = "BLANCO"
        Me.CheckBox3.UseVisualStyleBackColor = True
        '
        'CboTipoProducto
        '
        Me.CboTipoProducto.BackColor = System.Drawing.Color.White
        Me.CboTipoProducto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboTipoProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CboTipoProducto.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.CboTipoProducto.FormattingEnabled = True
        Me.CboTipoProducto.Items.AddRange(New Object() {"Vino", "Mosto"})
        Me.CboTipoProducto.Location = New System.Drawing.Point(23, 456)
        Me.CboTipoProducto.Name = "CboTipoProducto"
        Me.CboTipoProducto.Size = New System.Drawing.Size(147, 28)
        Me.CboTipoProducto.TabIndex = 40
        '
        'LblCantidadProductos
        '
        Me.LblCantidadProductos.AutoSize = True
        Me.LblCantidadProductos.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.LblCantidadProductos.ForeColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.LblCantidadProductos.Location = New System.Drawing.Point(73, 164)
        Me.LblCantidadProductos.Name = "LblCantidadProductos"
        Me.LblCantidadProductos.Size = New System.Drawing.Size(97, 20)
        Me.LblCantidadProductos.TabIndex = 42
        Me.LblCantidadProductos.Text = "Productos (0)"
        '
        'BtnEliminar
        '
        Me.BtnEliminar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnEliminar.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(161, Byte), Integer))
        Me.BtnEliminar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnEliminar.FlatAppearance.BorderSize = 0
        Me.BtnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnEliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEliminar.ForeColor = System.Drawing.Color.White
        Me.BtnEliminar.Location = New System.Drawing.Point(77, 187)
        Me.BtnEliminar.Name = "BtnEliminar"
        Me.BtnEliminar.Size = New System.Drawing.Size(93, 23)
        Me.BtnEliminar.TabIndex = 43
        Me.BtnEliminar.Text = "VER CARRITO"
        Me.BtnEliminar.UseVisualStyleBackColor = False
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
    Friend WithEvents CboTipoProducto As System.Windows.Forms.ComboBox
    Friend WithEvents LblCantidadProductos As System.Windows.Forms.Label
    Friend WithEvents BtnEliminar As System.Windows.Forms.Button

End Class
