<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMateriaPrima
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMateriaPrima))
        Me.Label7 = New System.Windows.Forms.Label
        Me.CboCepas = New System.Windows.Forms.ComboBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.TxtPrecio_NUM_REQ = New System.Windows.Forms.TextBox
        Me.TxtID = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.BtnGuardar = New System.Windows.Forms.Button
        Me.Label2 = New System.Windows.Forms.Label
        Me.TxtDescripcion_REQ = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.TxtNombre_REQ = New System.Windows.Forms.TextBox
        Me.BtnSeleccionarFoto = New System.Windows.Forms.Button
        Me.Label3 = New System.Windows.Forms.Label
        Me.OfdImagen = New System.Windows.Forms.OpenFileDialog
        Me.PicVolver = New System.Windows.Forms.PictureBox
        Me.PicFoto = New System.Windows.Forms.PictureBox
        CType(Me.PicVolver, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicFoto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label7
        '
        Me.Label7.AccessibleDescription = Nothing
        Me.Label7.AccessibleName = Nothing
        resources.ApplyResources(Me.Label7, "Label7")
        Me.Label7.Name = "Label7"
        '
        'CboCepas
        '
        Me.CboCepas.AccessibleDescription = Nothing
        Me.CboCepas.AccessibleName = Nothing
        resources.ApplyResources(Me.CboCepas, "CboCepas")
        Me.CboCepas.BackColor = System.Drawing.Color.White
        Me.CboCepas.BackgroundImage = Nothing
        Me.CboCepas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboCepas.FormattingEnabled = True
        Me.CboCepas.Items.AddRange(New Object() {resources.GetString("CboCepas.Items"), resources.GetString("CboCepas.Items1"), resources.GetString("CboCepas.Items2")})
        Me.CboCepas.Name = "CboCepas"
        '
        'Label6
        '
        Me.Label6.AccessibleDescription = Nothing
        Me.Label6.AccessibleName = Nothing
        resources.ApplyResources(Me.Label6, "Label6")
        Me.Label6.Name = "Label6"
        '
        'TxtPrecio_NUM_REQ
        '
        Me.TxtPrecio_NUM_REQ.AccessibleDescription = Nothing
        Me.TxtPrecio_NUM_REQ.AccessibleName = Nothing
        resources.ApplyResources(Me.TxtPrecio_NUM_REQ, "TxtPrecio_NUM_REQ")
        Me.TxtPrecio_NUM_REQ.BackgroundImage = Nothing
        Me.TxtPrecio_NUM_REQ.Name = "TxtPrecio_NUM_REQ"
        '
        'TxtID
        '
        Me.TxtID.AccessibleDescription = Nothing
        Me.TxtID.AccessibleName = Nothing
        resources.ApplyResources(Me.TxtID, "TxtID")
        Me.TxtID.BackgroundImage = Nothing
        Me.TxtID.Name = "TxtID"
        '
        'Label5
        '
        Me.Label5.AccessibleDescription = Nothing
        Me.Label5.AccessibleName = Nothing
        resources.ApplyResources(Me.Label5, "Label5")
        Me.Label5.Name = "Label5"
        '
        'BtnGuardar
        '
        Me.BtnGuardar.AccessibleDescription = Nothing
        Me.BtnGuardar.AccessibleName = Nothing
        resources.ApplyResources(Me.BtnGuardar, "BtnGuardar")
        Me.BtnGuardar.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.BtnGuardar.BackgroundImage = Nothing
        Me.BtnGuardar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnGuardar.FlatAppearance.BorderSize = 0
        Me.BtnGuardar.Font = Nothing
        Me.BtnGuardar.ForeColor = System.Drawing.Color.White
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AccessibleDescription = Nothing
        Me.Label2.AccessibleName = Nothing
        resources.ApplyResources(Me.Label2, "Label2")
        Me.Label2.Name = "Label2"
        '
        'TxtDescripcion_REQ
        '
        Me.TxtDescripcion_REQ.AccessibleDescription = Nothing
        Me.TxtDescripcion_REQ.AccessibleName = Nothing
        resources.ApplyResources(Me.TxtDescripcion_REQ, "TxtDescripcion_REQ")
        Me.TxtDescripcion_REQ.BackgroundImage = Nothing
        Me.TxtDescripcion_REQ.Name = "TxtDescripcion_REQ"
        '
        'Label1
        '
        Me.Label1.AccessibleDescription = Nothing
        Me.Label1.AccessibleName = Nothing
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.Name = "Label1"
        '
        'TxtNombre_REQ
        '
        Me.TxtNombre_REQ.AccessibleDescription = Nothing
        Me.TxtNombre_REQ.AccessibleName = Nothing
        resources.ApplyResources(Me.TxtNombre_REQ, "TxtNombre_REQ")
        Me.TxtNombre_REQ.BackgroundImage = Nothing
        Me.TxtNombre_REQ.Name = "TxtNombre_REQ"
        '
        'BtnSeleccionarFoto
        '
        Me.BtnSeleccionarFoto.AccessibleDescription = Nothing
        Me.BtnSeleccionarFoto.AccessibleName = Nothing
        resources.ApplyResources(Me.BtnSeleccionarFoto, "BtnSeleccionarFoto")
        Me.BtnSeleccionarFoto.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(161, Byte), Integer))
        Me.BtnSeleccionarFoto.BackgroundImage = Nothing
        Me.BtnSeleccionarFoto.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnSeleccionarFoto.FlatAppearance.BorderSize = 0
        Me.BtnSeleccionarFoto.ForeColor = System.Drawing.Color.White
        Me.BtnSeleccionarFoto.Name = "BtnSeleccionarFoto"
        Me.BtnSeleccionarFoto.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AccessibleDescription = Nothing
        Me.Label3.AccessibleName = Nothing
        resources.ApplyResources(Me.Label3, "Label3")
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(172, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.Label3.Name = "Label3"
        '
        'OfdImagen
        '
        resources.ApplyResources(Me.OfdImagen, "OfdImagen")
        '
        'PicVolver
        '
        Me.PicVolver.AccessibleDescription = Nothing
        Me.PicVolver.AccessibleName = Nothing
        resources.ApplyResources(Me.PicVolver, "PicVolver")
        Me.PicVolver.BackgroundImage = Nothing
        Me.PicVolver.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PicVolver.Font = Nothing
        Me.PicVolver.Image = Global.SIGESVI.My.Resources.Resources.icons8_go_back_50__1_
        Me.PicVolver.ImageLocation = Nothing
        Me.PicVolver.Name = "PicVolver"
        Me.PicVolver.TabStop = False
        '
        'PicFoto
        '
        Me.PicFoto.AccessibleDescription = Nothing
        Me.PicFoto.AccessibleName = Nothing
        resources.ApplyResources(Me.PicFoto, "PicFoto")
        Me.PicFoto.BackColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(149, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.PicFoto.BackgroundImage = Nothing
        Me.PicFoto.Font = Nothing
        Me.PicFoto.ImageLocation = Nothing
        Me.PicFoto.Name = "PicFoto"
        Me.PicFoto.TabStop = False
        '
        'FrmMateriaPrima
        '
        Me.AccessibleDescription = Nothing
        Me.AccessibleName = Nothing
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.BackgroundImage = Nothing
        Me.Controls.Add(Me.PicVolver)
        Me.Controls.Add(Me.BtnSeleccionarFoto)
        Me.Controls.Add(Me.PicFoto)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.CboCepas)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TxtPrecio_NUM_REQ)
        Me.Controls.Add(Me.TxtID)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.BtnGuardar)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TxtDescripcion_REQ)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxtNombre_REQ)
        Me.Font = Nothing
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = Nothing
        Me.Name = "FrmMateriaPrima"
        CType(Me.PicVolver, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicFoto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents CboCepas As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TxtPrecio_NUM_REQ As System.Windows.Forms.TextBox
    Friend WithEvents TxtID As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents BtnGuardar As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TxtDescripcion_REQ As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TxtNombre_REQ As System.Windows.Forms.TextBox
    Friend WithEvents BtnSeleccionarFoto As System.Windows.Forms.Button
    Friend WithEvents PicFoto As System.Windows.Forms.PictureBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents PicVolver As System.Windows.Forms.PictureBox
    Friend WithEvents OfdImagen As System.Windows.Forms.OpenFileDialog
End Class
