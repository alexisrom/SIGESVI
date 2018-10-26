<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CatalogoItem
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
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.PicFoto = New System.Windows.Forms.PictureBox
        Me.BtnAgregarProducto = New System.Windows.Forms.Button
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.LblDescripcion = New System.Windows.Forms.Label
        Me.LblNombre = New System.Windows.Forms.Label
        Me.LblPrecio = New System.Windows.Forms.Label
        Me.Panel1.SuspendLayout()
        CType(Me.PicFoto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(205, Byte), Integer))
        Me.Panel1.Controls.Add(Me.PicFoto)
        Me.Panel1.Controls.Add(Me.BtnAgregarProducto)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(400, 200)
        Me.Panel1.TabIndex = 42
        '
        'PicFoto
        '
        Me.PicFoto.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(151, Byte), Integer))
        Me.PicFoto.Location = New System.Drawing.Point(17, 19)
        Me.PicFoto.Name = "PicFoto"
        Me.PicFoto.Size = New System.Drawing.Size(130, 130)
        Me.PicFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PicFoto.TabIndex = 42
        Me.PicFoto.TabStop = False
        '
        'BtnAgregarProducto
        '
        Me.BtnAgregarProducto.BackColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(205, Byte), Integer))
        Me.BtnAgregarProducto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BtnAgregarProducto.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnAgregarProducto.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.BtnAgregarProducto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(161, Byte), Integer))
        Me.BtnAgregarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAgregarProducto.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAgregarProducto.ForeColor = System.Drawing.Color.White
        Me.BtnAgregarProducto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnAgregarProducto.Location = New System.Drawing.Point(17, 159)
        Me.BtnAgregarProducto.Name = "BtnAgregarProducto"
        Me.BtnAgregarProducto.Size = New System.Drawing.Size(130, 28)
        Me.BtnAgregarProducto.TabIndex = 44
        Me.BtnAgregarProducto.Text = "AÑADIR AL CARRITO"
        Me.BtnAgregarProducto.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.LblDescripcion)
        Me.Panel2.Controls.Add(Me.LblNombre)
        Me.Panel2.Controls.Add(Me.LblPrecio)
        Me.Panel2.Location = New System.Drawing.Point(153, 19)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(200, 168)
        Me.Panel2.TabIndex = 43
        '
        'LblDescripcion
        '
        Me.LblDescripcion.BackColor = System.Drawing.Color.Transparent
        Me.LblDescripcion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LblDescripcion.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDescripcion.ForeColor = System.Drawing.Color.White
        Me.LblDescripcion.Location = New System.Drawing.Point(0, 38)
        Me.LblDescripcion.Name = "LblDescripcion"
        Me.LblDescripcion.Size = New System.Drawing.Size(200, 102)
        Me.LblDescripcion.TabIndex = 38
        Me.LblDescripcion.Text = "Descripción producto"
        '
        'LblNombre
        '
        Me.LblNombre.BackColor = System.Drawing.Color.Transparent
        Me.LblNombre.Dock = System.Windows.Forms.DockStyle.Top
        Me.LblNombre.Font = New System.Drawing.Font("Roboto", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblNombre.ForeColor = System.Drawing.Color.White
        Me.LblNombre.Location = New System.Drawing.Point(0, 0)
        Me.LblNombre.Name = "LblNombre"
        Me.LblNombre.Size = New System.Drawing.Size(200, 38)
        Me.LblNombre.TabIndex = 35
        Me.LblNombre.Text = "Nombre Producto"
        '
        'LblPrecio
        '
        Me.LblPrecio.BackColor = System.Drawing.Color.Transparent
        Me.LblPrecio.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.LblPrecio.Font = New System.Drawing.Font("Roboto", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPrecio.ForeColor = System.Drawing.Color.White
        Me.LblPrecio.Location = New System.Drawing.Point(0, 140)
        Me.LblPrecio.Name = "LblPrecio"
        Me.LblPrecio.Size = New System.Drawing.Size(200, 28)
        Me.LblPrecio.TabIndex = 37
        Me.LblPrecio.Text = "Precio: $000"
        Me.LblPrecio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'CatalogoItem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Panel1)
        Me.Name = "CatalogoItem"
        Me.Size = New System.Drawing.Size(400, 200)
        Me.Panel1.ResumeLayout(False)
        CType(Me.PicFoto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents PicFoto As System.Windows.Forms.PictureBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents LblDescripcion As System.Windows.Forms.Label
    Friend WithEvents LblNombre As System.Windows.Forms.Label
    Friend WithEvents LblPrecio As System.Windows.Forms.Label
    Friend WithEvents BtnAgregarProducto As System.Windows.Forms.Button

End Class
