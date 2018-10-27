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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MenuAsesorProfesional))
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
        Me.PnlMenu.AccessibleDescription = Nothing
        Me.PnlMenu.AccessibleName = Nothing
        resources.ApplyResources(Me.PnlMenu, "PnlMenu")
        Me.PnlMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(151, Byte), Integer))
        Me.PnlMenu.BackgroundImage = Nothing
        Me.PnlMenu.Controls.Add(Me.Panel3)
        Me.PnlMenu.Controls.Add(Me.Panel4)
        Me.PnlMenu.Controls.Add(Me.BtnProductos)
        Me.PnlMenu.Controls.Add(Me.BtnProduccion)
        Me.PnlMenu.Controls.Add(Me.PicLogo)
        Me.PnlMenu.Font = Nothing
        Me.PnlMenu.Name = "PnlMenu"
        '
        'Panel3
        '
        Me.Panel3.AccessibleDescription = Nothing
        Me.Panel3.AccessibleName = Nothing
        resources.ApplyResources(Me.Panel3, "Panel3")
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(205, Byte), Integer))
        Me.Panel3.BackgroundImage = Nothing
        Me.Panel3.Cursor = System.Windows.Forms.Cursors.Default
        Me.Panel3.Font = Nothing
        Me.Panel3.Name = "Panel3"
        '
        'Panel4
        '
        Me.Panel4.AccessibleDescription = Nothing
        Me.Panel4.AccessibleName = Nothing
        resources.ApplyResources(Me.Panel4, "Panel4")
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(205, Byte), Integer))
        Me.Panel4.BackgroundImage = Nothing
        Me.Panel4.Cursor = System.Windows.Forms.Cursors.Default
        Me.Panel4.Font = Nothing
        Me.Panel4.Name = "Panel4"
        '
        'BtnProductos
        '
        Me.BtnProductos.AccessibleDescription = Nothing
        Me.BtnProductos.AccessibleName = Nothing
        resources.ApplyResources(Me.BtnProductos, "BtnProductos")
        Me.BtnProductos.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(151, Byte), Integer))
        Me.BtnProductos.BackgroundImage = Nothing
        Me.BtnProductos.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnProductos.FlatAppearance.BorderSize = 0
        Me.BtnProductos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(205, Byte), Integer))
        Me.BtnProductos.ForeColor = System.Drawing.Color.White
        Me.BtnProductos.Image = Global.SIGESVI.My.Resources.Resources.product
        Me.BtnProductos.Name = "BtnProductos"
        Me.BtnProductos.UseVisualStyleBackColor = False
        '
        'BtnProduccion
        '
        Me.BtnProduccion.AccessibleDescription = Nothing
        Me.BtnProduccion.AccessibleName = Nothing
        resources.ApplyResources(Me.BtnProduccion, "BtnProduccion")
        Me.BtnProduccion.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(151, Byte), Integer))
        Me.BtnProduccion.BackgroundImage = Nothing
        Me.BtnProduccion.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnProduccion.FlatAppearance.BorderSize = 0
        Me.BtnProduccion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(205, Byte), Integer))
        Me.BtnProduccion.ForeColor = System.Drawing.Color.White
        Me.BtnProduccion.Image = Global.SIGESVI.My.Resources.Resources.mass_production
        Me.BtnProduccion.Name = "BtnProduccion"
        Me.BtnProduccion.UseVisualStyleBackColor = False
        '
        'PicLogo
        '
        Me.PicLogo.AccessibleDescription = Nothing
        Me.PicLogo.AccessibleName = Nothing
        resources.ApplyResources(Me.PicLogo, "PicLogo")
        Me.PicLogo.BackgroundImage = Nothing
        Me.PicLogo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PicLogo.Font = Nothing
        Me.PicLogo.Image = Global.SIGESVI.My.Resources.Resources.enoturismo_2
        Me.PicLogo.ImageLocation = Nothing
        Me.PicLogo.Name = "PicLogo"
        Me.PicLogo.TabStop = False
        '
        'MenuAsesorProfesional
        '
        Me.AccessibleDescription = Nothing
        Me.AccessibleName = Nothing
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Nothing
        Me.Controls.Add(Me.PnlMenu)
        Me.Font = Nothing
        Me.Name = "MenuAsesorProfesional"
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
