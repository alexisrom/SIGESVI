<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCatalogo
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
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.PnlMostoContenedor = New System.Windows.Forms.Panel
        Me.PnlMosto = New System.Windows.Forms.FlowLayoutPanel
        Me.LblMosto = New System.Windows.Forms.Label
        Me.PnlVinosContenedor = New System.Windows.Forms.Panel
        Me.PnlVinos = New System.Windows.Forms.FlowLayoutPanel
        Me.LblVinos = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.PnlMostoContenedor.SuspendLayout()
        Me.PnlVinosContenedor.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel2.Controls.Add(Me.Panel1)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1289, 1000)
        Me.Panel2.TabIndex = 5
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(124, Byte), Integer), CType(CType(107, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.Panel1.Controls.Add(Me.PnlMostoContenedor)
        Me.Panel1.Controls.Add(Me.LblMosto)
        Me.Panel1.Controls.Add(Me.PnlVinosContenedor)
        Me.Panel1.Controls.Add(Me.LblVinos)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 82)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1289, 918)
        Me.Panel1.TabIndex = 1
        '
        'PnlMostoContenedor
        '
        Me.PnlMostoContenedor.Controls.Add(Me.PnlMosto)
        Me.PnlMostoContenedor.Dock = System.Windows.Forms.DockStyle.Top
        Me.PnlMostoContenedor.Location = New System.Drawing.Point(0, 424)
        Me.PnlMostoContenedor.Name = "PnlMostoContenedor"
        Me.PnlMostoContenedor.Padding = New System.Windows.Forms.Padding(50, 0, 50, 0)
        Me.PnlMostoContenedor.Size = New System.Drawing.Size(1289, 230)
        Me.PnlMostoContenedor.TabIndex = 10
        '
        'PnlMosto
        '
        Me.PnlMosto.AutoScroll = True
        Me.PnlMosto.BackColor = System.Drawing.Color.Transparent
        Me.PnlMosto.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PnlMosto.Location = New System.Drawing.Point(50, 0)
        Me.PnlMosto.Name = "PnlMosto"
        Me.PnlMosto.Size = New System.Drawing.Size(1189, 230)
        Me.PnlMosto.TabIndex = 1
        '
        'LblMosto
        '
        Me.LblMosto.BackColor = System.Drawing.Color.Transparent
        Me.LblMosto.Dock = System.Windows.Forms.DockStyle.Top
        Me.LblMosto.Font = New System.Drawing.Font("Roboto", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblMosto.ForeColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(16, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.LblMosto.Location = New System.Drawing.Point(0, 342)
        Me.LblMosto.Name = "LblMosto"
        Me.LblMosto.Size = New System.Drawing.Size(1289, 82)
        Me.LblMosto.TabIndex = 9
        Me.LblMosto.Text = "MOSTO"
        Me.LblMosto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PnlVinosContenedor
        '
        Me.PnlVinosContenedor.Controls.Add(Me.PnlVinos)
        Me.PnlVinosContenedor.Dock = System.Windows.Forms.DockStyle.Top
        Me.PnlVinosContenedor.Location = New System.Drawing.Point(0, 82)
        Me.PnlVinosContenedor.Name = "PnlVinosContenedor"
        Me.PnlVinosContenedor.Padding = New System.Windows.Forms.Padding(50, 0, 50, 30)
        Me.PnlVinosContenedor.Size = New System.Drawing.Size(1289, 260)
        Me.PnlVinosContenedor.TabIndex = 3
        '
        'PnlVinos
        '
        Me.PnlVinos.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PnlVinos.AutoScroll = True
        Me.PnlVinos.BackColor = System.Drawing.Color.Transparent
        Me.PnlVinos.Location = New System.Drawing.Point(50, 0)
        Me.PnlVinos.Name = "PnlVinos"
        Me.PnlVinos.Size = New System.Drawing.Size(1189, 230)
        Me.PnlVinos.TabIndex = 1
        '
        'LblVinos
        '
        Me.LblVinos.BackColor = System.Drawing.Color.Transparent
        Me.LblVinos.Dock = System.Windows.Forms.DockStyle.Top
        Me.LblVinos.Font = New System.Drawing.Font("Roboto", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblVinos.ForeColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(16, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.LblVinos.Location = New System.Drawing.Point(0, 0)
        Me.LblVinos.Name = "LblVinos"
        Me.LblVinos.Size = New System.Drawing.Size(1289, 82)
        Me.LblVinos.TabIndex = 2
        Me.LblVinos.Text = "VINOS"
        Me.LblVinos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(16, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Roboto", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1289, 82)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "CATÁLOGO DE PRODUCTOS"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FrmCatalogo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1289, 1000)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmCatalogo"
        Me.Text = "FrmCatalogo"
        Me.Panel2.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.PnlMostoContenedor.ResumeLayout(False)
        Me.PnlVinosContenedor.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents LblVinos As System.Windows.Forms.Label
    Friend WithEvents PnlMostoContenedor As System.Windows.Forms.Panel
    Friend WithEvents PnlMosto As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents LblMosto As System.Windows.Forms.Label
    Friend WithEvents PnlVinosContenedor As System.Windows.Forms.Panel
    Friend WithEvents PnlVinos As System.Windows.Forms.FlowLayoutPanel
End Class
