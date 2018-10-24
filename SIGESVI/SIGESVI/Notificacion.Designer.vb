<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Notificacion
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
        Me.PnlNotificacion = New System.Windows.Forms.Panel
        Me.LblMensaje = New System.Windows.Forms.Label
        Me.PnlNotificacion.SuspendLayout()
        Me.SuspendLayout()
        '
        'PnlNotificacion
        '
        Me.PnlNotificacion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PnlNotificacion.Controls.Add(Me.LblMensaje)
        Me.PnlNotificacion.Dock = System.Windows.Forms.DockStyle.Top
        Me.PnlNotificacion.Location = New System.Drawing.Point(0, 0)
        Me.PnlNotificacion.Name = "PnlNotificacion"
        Me.PnlNotificacion.Size = New System.Drawing.Size(425, 40)
        Me.PnlNotificacion.TabIndex = 0
        '
        'LblMensaje
        '
        Me.LblMensaje.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LblMensaje.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblMensaje.ForeColor = System.Drawing.Color.White
        Me.LblMensaje.Location = New System.Drawing.Point(0, 0)
        Me.LblMensaje.Name = "LblMensaje"
        Me.LblMensaje.Size = New System.Drawing.Size(423, 38)
        Me.LblMensaje.TabIndex = 0
        Me.LblMensaje.Text = "Lorem impsum"
        '
        'Notificacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.PnlNotificacion)
        Me.Name = "Notificacion"
        Me.Size = New System.Drawing.Size(425, 40)
        Me.PnlNotificacion.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PnlNotificacion As System.Windows.Forms.Panel
    Friend WithEvents LblMensaje As System.Windows.Forms.Label

End Class
