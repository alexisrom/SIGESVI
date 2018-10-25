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
        Me.Label3 = New System.Windows.Forms.Label
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Panel4 = New System.Windows.Forms.Panel
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.Panel2.Controls.Add(Me.Panel4)
        Me.Panel2.Controls.Add(Me.Panel1)
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1289, 690)
        Me.Panel2.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 16.0!)
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(172, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(713, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(126, 30)
        Me.Label3.TabIndex = 31
        Me.Label3.Text = "CATÁLOGO"
        '
        'Panel3
        '
        Me.Panel3.Location = New System.Drawing.Point(270, 83)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(940, 157)
        Me.Panel3.TabIndex = 32
        '
        'Panel1
        '
        Me.Panel1.Location = New System.Drawing.Point(270, 275)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(940, 157)
        Me.Panel1.TabIndex = 33
        '
        'Panel4
        '
        Me.Panel4.Location = New System.Drawing.Point(270, 464)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(940, 157)
        Me.Panel4.TabIndex = 33
        '
        'FrmCatalogo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1289, 690)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmCatalogo"
        Me.Text = "FrmCatalogo"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
End Class
