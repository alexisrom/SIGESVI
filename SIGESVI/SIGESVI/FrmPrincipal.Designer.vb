<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPrincipal
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
        Me.PnlContenedor = New System.Windows.Forms.Panel
        Me.PnlContenido = New System.Windows.Forms.Panel
        Me.PnlMenuContenedor = New System.Windows.Forms.Panel
        Me.PnlCabecera = New System.Windows.Forms.Panel
        Me.BtnRestaurar = New System.Windows.Forms.PictureBox
        Me.BtnMinimizar = New System.Windows.Forms.PictureBox
        Me.BtnMaximizar = New System.Windows.Forms.PictureBox
        Me.BtnCerrar = New System.Windows.Forms.PictureBox
        Me.PnlContenedor.SuspendLayout()
        Me.PnlCabecera.SuspendLayout()
        CType(Me.BtnRestaurar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnMinimizar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnMaximizar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnCerrar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PnlContenedor
        '
        Me.PnlContenedor.Controls.Add(Me.PnlContenido)
        Me.PnlContenedor.Controls.Add(Me.PnlMenuContenedor)
        Me.PnlContenedor.Controls.Add(Me.PnlCabecera)
        Me.PnlContenedor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PnlContenedor.Location = New System.Drawing.Point(0, 0)
        Me.PnlContenedor.Name = "PnlContenedor"
        Me.PnlContenedor.Size = New System.Drawing.Size(1284, 650)
        Me.PnlContenedor.TabIndex = 0
        '
        'PnlContenido
        '
        Me.PnlContenido.BackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.PnlContenido.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PnlContenido.Location = New System.Drawing.Point(200, 40)
        Me.PnlContenido.Name = "PnlContenido"
        Me.PnlContenido.Size = New System.Drawing.Size(1084, 610)
        Me.PnlContenido.TabIndex = 7
        '
        'PnlMenuContenedor
        '
        Me.PnlMenuContenedor.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(151, Byte), Integer))
        Me.PnlMenuContenedor.Dock = System.Windows.Forms.DockStyle.Left
        Me.PnlMenuContenedor.Location = New System.Drawing.Point(0, 40)
        Me.PnlMenuContenedor.Name = "PnlMenuContenedor"
        Me.PnlMenuContenedor.Size = New System.Drawing.Size(200, 610)
        Me.PnlMenuContenedor.TabIndex = 6
        '
        'PnlCabecera
        '
        Me.PnlCabecera.BackColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(205, Byte), Integer))
        Me.PnlCabecera.Controls.Add(Me.BtnRestaurar)
        Me.PnlCabecera.Controls.Add(Me.BtnMinimizar)
        Me.PnlCabecera.Controls.Add(Me.BtnMaximizar)
        Me.PnlCabecera.Controls.Add(Me.BtnCerrar)
        Me.PnlCabecera.Cursor = System.Windows.Forms.Cursors.SizeAll
        Me.PnlCabecera.Dock = System.Windows.Forms.DockStyle.Top
        Me.PnlCabecera.Location = New System.Drawing.Point(0, 0)
        Me.PnlCabecera.Name = "PnlCabecera"
        Me.PnlCabecera.Size = New System.Drawing.Size(1284, 40)
        Me.PnlCabecera.TabIndex = 5
        '
        'BtnRestaurar
        '
        Me.BtnRestaurar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnRestaurar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnRestaurar.Image = Global.SIGESVI.My.Resources.Resources.restaurar
        Me.BtnRestaurar.Location = New System.Drawing.Point(1234, 12)
        Me.BtnRestaurar.Name = "BtnRestaurar"
        Me.BtnRestaurar.Size = New System.Drawing.Size(16, 16)
        Me.BtnRestaurar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BtnRestaurar.TabIndex = 3
        Me.BtnRestaurar.TabStop = False
        Me.BtnRestaurar.Visible = False
        '
        'BtnMinimizar
        '
        Me.BtnMinimizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnMinimizar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnMinimizar.Image = Global.SIGESVI.My.Resources.Resources.minimize
        Me.BtnMinimizar.Location = New System.Drawing.Point(1212, 12)
        Me.BtnMinimizar.Name = "BtnMinimizar"
        Me.BtnMinimizar.Size = New System.Drawing.Size(16, 16)
        Me.BtnMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BtnMinimizar.TabIndex = 2
        Me.BtnMinimizar.TabStop = False
        '
        'BtnMaximizar
        '
        Me.BtnMaximizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnMaximizar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnMaximizar.Image = Global.SIGESVI.My.Resources.Resources.maximize
        Me.BtnMaximizar.Location = New System.Drawing.Point(1234, 12)
        Me.BtnMaximizar.Name = "BtnMaximizar"
        Me.BtnMaximizar.Size = New System.Drawing.Size(16, 16)
        Me.BtnMaximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BtnMaximizar.TabIndex = 1
        Me.BtnMaximizar.TabStop = False
        '
        'BtnCerrar
        '
        Me.BtnCerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnCerrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnCerrar.Image = Global.SIGESVI.My.Resources.Resources.close
        Me.BtnCerrar.Location = New System.Drawing.Point(1256, 12)
        Me.BtnCerrar.Name = "BtnCerrar"
        Me.BtnCerrar.Size = New System.Drawing.Size(16, 16)
        Me.BtnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BtnCerrar.TabIndex = 0
        Me.BtnCerrar.TabStop = False
        '
        'FrmPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1284, 650)
        Me.Controls.Add(Me.PnlContenedor)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MinimumSize = New System.Drawing.Size(650, 400)
        Me.Name = "FrmPrincipal"
        Me.Text = "FrmPrincipal"
        Me.PnlContenedor.ResumeLayout(False)
        Me.PnlCabecera.ResumeLayout(False)
        CType(Me.BtnRestaurar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnMinimizar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnMaximizar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnCerrar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PnlContenedor As System.Windows.Forms.Panel
    Friend WithEvents PnlContenido As System.Windows.Forms.Panel
    Friend WithEvents PnlMenuContenedor As System.Windows.Forms.Panel
    Friend WithEvents PnlCabecera As System.Windows.Forms.Panel
    Friend WithEvents BtnRestaurar As System.Windows.Forms.PictureBox
    Friend WithEvents BtnMinimizar As System.Windows.Forms.PictureBox
    Friend WithEvents BtnMaximizar As System.Windows.Forms.PictureBox
    Friend WithEvents BtnCerrar As System.Windows.Forms.PictureBox
End Class
