<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmLogin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmLogin))
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.TxtUser_REQ = New System.Windows.Forms.TextBox
        Me.BtnIngresar = New System.Windows.Forms.Button
        Me.Label6 = New System.Windows.Forms.Label
        Me.TxtPass_REQ = New System.Windows.Forms.TextBox
        Me.BtnCerrar = New System.Windows.Forms.PictureBox
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.BtnCerrar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.AccessibleDescription = Nothing
        Me.Panel1.AccessibleName = Nothing
        resources.ApplyResources(Me.Panel1, "Panel1")
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(205, Byte), Integer))
        Me.Panel1.BackgroundImage = Nothing
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Font = Nothing
        Me.Panel1.Name = "Panel1"
        '
        'Panel2
        '
        Me.Panel2.AccessibleDescription = Nothing
        Me.Panel2.AccessibleName = Nothing
        resources.ApplyResources(Me.Panel2, "Panel2")
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(151, Byte), Integer))
        Me.Panel2.BackgroundImage = Nothing
        Me.Panel2.Controls.Add(Me.BtnCerrar)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.Label10)
        Me.Panel2.Controls.Add(Me.TxtUser_REQ)
        Me.Panel2.Controls.Add(Me.BtnIngresar)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.TxtPass_REQ)
        Me.Panel2.Font = Nothing
        Me.Panel2.Name = "Panel2"
        '
        'Label1
        '
        Me.Label1.AccessibleDescription = Nothing
        Me.Label1.AccessibleName = Nothing
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Name = "Label1"
        '
        'Label10
        '
        Me.Label10.AccessibleDescription = Nothing
        Me.Label10.AccessibleName = Nothing
        resources.ApplyResources(Me.Label10, "Label10")
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Name = "Label10"
        '
        'TxtUser_REQ
        '
        Me.TxtUser_REQ.AccessibleDescription = Nothing
        Me.TxtUser_REQ.AccessibleName = Nothing
        resources.ApplyResources(Me.TxtUser_REQ, "TxtUser_REQ")
        Me.TxtUser_REQ.BackgroundImage = Nothing
        Me.TxtUser_REQ.Name = "TxtUser_REQ"
        '
        'BtnIngresar
        '
        Me.BtnIngresar.AccessibleDescription = Nothing
        Me.BtnIngresar.AccessibleName = Nothing
        resources.ApplyResources(Me.BtnIngresar, "BtnIngresar")
        Me.BtnIngresar.BackColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(205, Byte), Integer))
        Me.BtnIngresar.BackgroundImage = Nothing
        Me.BtnIngresar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnIngresar.FlatAppearance.BorderSize = 0
        Me.BtnIngresar.ForeColor = System.Drawing.Color.White
        Me.BtnIngresar.Name = "BtnIngresar"
        Me.BtnIngresar.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.AccessibleDescription = Nothing
        Me.Label6.AccessibleName = Nothing
        resources.ApplyResources(Me.Label6, "Label6")
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Name = "Label6"
        '
        'TxtPass_REQ
        '
        Me.TxtPass_REQ.AccessibleDescription = Nothing
        Me.TxtPass_REQ.AccessibleName = Nothing
        resources.ApplyResources(Me.TxtPass_REQ, "TxtPass_REQ")
        Me.TxtPass_REQ.BackgroundImage = Nothing
        Me.TxtPass_REQ.Name = "TxtPass_REQ"
        '
        'BtnCerrar
        '
        Me.BtnCerrar.AccessibleDescription = Nothing
        Me.BtnCerrar.AccessibleName = Nothing
        resources.ApplyResources(Me.BtnCerrar, "BtnCerrar")
        Me.BtnCerrar.BackgroundImage = Nothing
        Me.BtnCerrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnCerrar.Font = Nothing
        Me.BtnCerrar.Image = Global.SIGESVI.My.Resources.Resources.close
        Me.BtnCerrar.ImageLocation = Nothing
        Me.BtnCerrar.Name = "BtnCerrar"
        Me.BtnCerrar.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.AccessibleDescription = Nothing
        Me.PictureBox2.AccessibleName = Nothing
        resources.ApplyResources(Me.PictureBox2, "PictureBox2")
        Me.PictureBox2.BackgroundImage = Nothing
        Me.PictureBox2.Font = Nothing
        Me.PictureBox2.Image = Global.SIGESVI.My.Resources.Resources.enoturismo_2
        Me.PictureBox2.ImageLocation = Nothing
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.TabStop = False
        '
        'FrmLogin
        '
        Me.AccessibleDescription = Nothing
        Me.AccessibleName = Nothing
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Nothing
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Font = Nothing
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = Nothing
        Me.Name = "FrmLogin"
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.BtnCerrar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents TxtUser_REQ As System.Windows.Forms.TextBox
    Friend WithEvents BtnIngresar As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TxtPass_REQ As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents BtnCerrar As System.Windows.Forms.PictureBox
End Class
