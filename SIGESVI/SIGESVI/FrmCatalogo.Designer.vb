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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmCatalogo))
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
        Me.Panel2.AccessibleDescription = Nothing
        Me.Panel2.AccessibleName = Nothing
        resources.ApplyResources(Me.Panel2, "Panel2")
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.Panel2.BackgroundImage = Nothing
        Me.Panel2.Controls.Add(Me.Panel1)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Font = Nothing
        Me.Panel2.Name = "Panel2"
        '
        'Panel1
        '
        Me.Panel1.AccessibleDescription = Nothing
        Me.Panel1.AccessibleName = Nothing
        resources.ApplyResources(Me.Panel1, "Panel1")
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(124, Byte), Integer), CType(CType(107, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.Panel1.BackgroundImage = Nothing
        Me.Panel1.Controls.Add(Me.PnlMostoContenedor)
        Me.Panel1.Controls.Add(Me.LblMosto)
        Me.Panel1.Controls.Add(Me.PnlVinosContenedor)
        Me.Panel1.Controls.Add(Me.LblVinos)
        Me.Panel1.Font = Nothing
        Me.Panel1.Name = "Panel1"
        '
        'PnlMostoContenedor
        '
        Me.PnlMostoContenedor.AccessibleDescription = Nothing
        Me.PnlMostoContenedor.AccessibleName = Nothing
        resources.ApplyResources(Me.PnlMostoContenedor, "PnlMostoContenedor")
        Me.PnlMostoContenedor.BackgroundImage = Nothing
        Me.PnlMostoContenedor.Controls.Add(Me.PnlMosto)
        Me.PnlMostoContenedor.Font = Nothing
        Me.PnlMostoContenedor.Name = "PnlMostoContenedor"
        '
        'PnlMosto
        '
        Me.PnlMosto.AccessibleDescription = Nothing
        Me.PnlMosto.AccessibleName = Nothing
        resources.ApplyResources(Me.PnlMosto, "PnlMosto")
        Me.PnlMosto.BackColor = System.Drawing.Color.Transparent
        Me.PnlMosto.BackgroundImage = Nothing
        Me.PnlMosto.Font = Nothing
        Me.PnlMosto.Name = "PnlMosto"
        '
        'LblMosto
        '
        Me.LblMosto.AccessibleDescription = Nothing
        Me.LblMosto.AccessibleName = Nothing
        resources.ApplyResources(Me.LblMosto, "LblMosto")
        Me.LblMosto.BackColor = System.Drawing.Color.Transparent
        Me.LblMosto.ForeColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(16, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.LblMosto.Name = "LblMosto"
        '
        'PnlVinosContenedor
        '
        Me.PnlVinosContenedor.AccessibleDescription = Nothing
        Me.PnlVinosContenedor.AccessibleName = Nothing
        resources.ApplyResources(Me.PnlVinosContenedor, "PnlVinosContenedor")
        Me.PnlVinosContenedor.BackgroundImage = Nothing
        Me.PnlVinosContenedor.Controls.Add(Me.PnlVinos)
        Me.PnlVinosContenedor.Font = Nothing
        Me.PnlVinosContenedor.Name = "PnlVinosContenedor"
        '
        'PnlVinos
        '
        Me.PnlVinos.AccessibleDescription = Nothing
        Me.PnlVinos.AccessibleName = Nothing
        resources.ApplyResources(Me.PnlVinos, "PnlVinos")
        Me.PnlVinos.BackColor = System.Drawing.Color.Transparent
        Me.PnlVinos.BackgroundImage = Nothing
        Me.PnlVinos.Font = Nothing
        Me.PnlVinos.Name = "PnlVinos"
        '
        'LblVinos
        '
        Me.LblVinos.AccessibleDescription = Nothing
        Me.LblVinos.AccessibleName = Nothing
        resources.ApplyResources(Me.LblVinos, "LblVinos")
        Me.LblVinos.BackColor = System.Drawing.Color.Transparent
        Me.LblVinos.ForeColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(16, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.LblVinos.Name = "LblVinos"
        '
        'Label1
        '
        Me.Label1.AccessibleDescription = Nothing
        Me.Label1.AccessibleName = Nothing
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(16, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Name = "Label1"
        '
        'FrmCatalogo
        '
        Me.AccessibleDescription = Nothing
        Me.AccessibleName = Nothing
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Nothing
        Me.Controls.Add(Me.Panel2)
        Me.Font = Nothing
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = Nothing
        Me.Name = "FrmCatalogo"
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
