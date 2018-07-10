<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmVehículos
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
        Me.components = New System.ComponentModel.Container
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.LblMensaje = New System.Windows.Forms.Label
        Me.Lbl_Actividad = New System.Windows.Forms.Label
        Me.Lbl_Anio = New System.Windows.Forms.Label
        Me.Lbl_Capacidad = New System.Windows.Forms.Label
        Me.Lbl_Marca = New System.Windows.Forms.Label
        Me.Lbl_Matrícula = New System.Windows.Forms.Label
        Me.FlowLayoutPanel2 = New System.Windows.Forms.FlowLayoutPanel
        Me.Txt_Matricula = New System.Windows.Forms.TextBox
        Me.TxtNombre = New System.Windows.Forms.TextBox
        Me.TextBox4 = New System.Windows.Forms.TextBox
        Me.TextBox5 = New System.Windows.Forms.TextBox
        Me.TextBox6 = New System.Windows.Forms.TextBox
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel
        Me.BtnAgregar = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.Button3 = New System.Windows.Forms.Button
        Me.Button4 = New System.Windows.Forms.Button
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.Lbl_Matricula = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.Txt_Matriculabusq = New System.Windows.Forms.TextBox
        Me.EpErrores = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Matricula = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Marca = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Capacidad = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Anio = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Actividad = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.FlowLayoutPanel2.SuspendLayout()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EpErrores, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Controls.Add(Me.FlowLayoutPanel1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(440, 386)
        Me.Panel1.TabIndex = 10
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.LblMensaje)
        Me.GroupBox1.Controls.Add(Me.Lbl_Actividad)
        Me.GroupBox1.Controls.Add(Me.Lbl_Anio)
        Me.GroupBox1.Controls.Add(Me.Lbl_Capacidad)
        Me.GroupBox1.Controls.Add(Me.Lbl_Marca)
        Me.GroupBox1.Controls.Add(Me.Lbl_Matrícula)
        Me.GroupBox1.Controls.Add(Me.FlowLayoutPanel2)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 21)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(332, 305)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Vehículos"
        '
        'LblMensaje
        '
        Me.LblMensaje.AutoSize = True
        Me.LblMensaje.Location = New System.Drawing.Point(120, 222)
        Me.LblMensaje.Name = "LblMensaje"
        Me.LblMensaje.Size = New System.Drawing.Size(0, 13)
        Me.LblMensaje.TabIndex = 3
        '
        'Lbl_Actividad
        '
        Me.Lbl_Actividad.AutoSize = True
        Me.Lbl_Actividad.Location = New System.Drawing.Point(42, 151)
        Me.Lbl_Actividad.Name = "Lbl_Actividad"
        Me.Lbl_Actividad.Size = New System.Drawing.Size(51, 13)
        Me.Lbl_Actividad.TabIndex = 5
        Me.Lbl_Actividad.Text = "Actividad"
        '
        'Lbl_Anio
        '
        Me.Lbl_Anio.AutoSize = True
        Me.Lbl_Anio.Location = New System.Drawing.Point(42, 125)
        Me.Lbl_Anio.Name = "Lbl_Anio"
        Me.Lbl_Anio.Size = New System.Drawing.Size(26, 13)
        Me.Lbl_Anio.TabIndex = 4
        Me.Lbl_Anio.Text = "Año"
        '
        'Lbl_Capacidad
        '
        Me.Lbl_Capacidad.AutoSize = True
        Me.Lbl_Capacidad.Location = New System.Drawing.Point(42, 99)
        Me.Lbl_Capacidad.Name = "Lbl_Capacidad"
        Me.Lbl_Capacidad.Size = New System.Drawing.Size(58, 13)
        Me.Lbl_Capacidad.TabIndex = 3
        Me.Lbl_Capacidad.Text = "Capacidad"
        '
        'Lbl_Marca
        '
        Me.Lbl_Marca.AutoSize = True
        Me.Lbl_Marca.Location = New System.Drawing.Point(42, 73)
        Me.Lbl_Marca.Name = "Lbl_Marca"
        Me.Lbl_Marca.Size = New System.Drawing.Size(37, 13)
        Me.Lbl_Marca.TabIndex = 2
        Me.Lbl_Marca.Text = "Marca"
        '
        'Lbl_Matrícula
        '
        Me.Lbl_Matrícula.AutoSize = True
        Me.Lbl_Matrícula.Location = New System.Drawing.Point(42, 47)
        Me.Lbl_Matrícula.Name = "Lbl_Matrícula"
        Me.Lbl_Matrícula.Size = New System.Drawing.Size(52, 13)
        Me.Lbl_Matrícula.TabIndex = 1
        Me.Lbl_Matrícula.Text = "Matrícula"
        '
        'FlowLayoutPanel2
        '
        Me.FlowLayoutPanel2.Controls.Add(Me.Txt_Matricula)
        Me.FlowLayoutPanel2.Controls.Add(Me.TxtNombre)
        Me.FlowLayoutPanel2.Controls.Add(Me.TextBox4)
        Me.FlowLayoutPanel2.Controls.Add(Me.TextBox5)
        Me.FlowLayoutPanel2.Controls.Add(Me.TextBox6)
        Me.FlowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.FlowLayoutPanel2.Location = New System.Drawing.Point(106, 41)
        Me.FlowLayoutPanel2.Name = "FlowLayoutPanel2"
        Me.FlowLayoutPanel2.Size = New System.Drawing.Size(202, 134)
        Me.FlowLayoutPanel2.TabIndex = 0
        '
        'Txt_Matricula
        '
        Me.Txt_Matricula.Location = New System.Drawing.Point(3, 3)
        Me.Txt_Matricula.Name = "Txt_Matricula"
        Me.Txt_Matricula.Size = New System.Drawing.Size(173, 20)
        Me.Txt_Matricula.TabIndex = 1
        '
        'TxtNombre
        '
        Me.TxtNombre.Location = New System.Drawing.Point(3, 29)
        Me.TxtNombre.Name = "TxtNombre"
        Me.TxtNombre.Size = New System.Drawing.Size(173, 20)
        Me.TxtNombre.TabIndex = 2
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(3, 55)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(173, 20)
        Me.TextBox4.TabIndex = 3
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(3, 81)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(173, 20)
        Me.TextBox5.TabIndex = 4
        '
        'TextBox6
        '
        Me.TextBox6.Location = New System.Drawing.Point(3, 107)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(173, 20)
        Me.TextBox6.TabIndex = 5
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Controls.Add(Me.BtnAgregar)
        Me.FlowLayoutPanel1.Controls.Add(Me.Button2)
        Me.FlowLayoutPanel1.Controls.Add(Me.Button3)
        Me.FlowLayoutPanel1.Controls.Add(Me.Button4)
        Me.FlowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(350, 30)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(84, 229)
        Me.FlowLayoutPanel1.TabIndex = 2
        '
        'BtnAgregar
        '
        Me.BtnAgregar.Location = New System.Drawing.Point(3, 3)
        Me.BtnAgregar.Name = "BtnAgregar"
        Me.BtnAgregar.Size = New System.Drawing.Size(75, 23)
        Me.BtnAgregar.TabIndex = 0
        Me.BtnAgregar.Text = "Agregar"
        Me.BtnAgregar.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(3, 32)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Modificar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(3, 61)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "Eliminar"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(3, 90)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 23)
        Me.Button4.TabIndex = 3
        Me.Button4.Text = "Limpiar"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Lbl_Matricula)
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Controls.Add(Me.DataGridView1)
        Me.Panel2.Controls.Add(Me.Txt_Matriculabusq)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel2.Location = New System.Drawing.Point(446, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(752, 386)
        Me.Panel2.TabIndex = 11
        '
        'Lbl_Matricula
        '
        Me.Lbl_Matricula.AutoSize = True
        Me.Lbl_Matricula.Location = New System.Drawing.Point(34, 40)
        Me.Lbl_Matricula.Name = "Lbl_Matricula"
        Me.Lbl_Matricula.Size = New System.Drawing.Size(52, 13)
        Me.Lbl_Matricula.TabIndex = 11
        Me.Lbl_Matricula.Text = "Matrícula"
        '
        'PictureBox1
        '
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox1.Location = New System.Drawing.Point(202, 50)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(25, 25)
        Me.PictureBox1.TabIndex = 12
        Me.PictureBox1.TabStop = False
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Matricula, Me.Marca, Me.Capacidad, Me.Anio, Me.Actividad})
        Me.DataGridView1.Location = New System.Drawing.Point(37, 106)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(544, 150)
        Me.DataGridView1.TabIndex = 9
        '
        'Txt_Matriculabusq
        '
        Me.Txt_Matriculabusq.Location = New System.Drawing.Point(37, 55)
        Me.Txt_Matriculabusq.Name = "Txt_Matriculabusq"
        Me.Txt_Matriculabusq.Size = New System.Drawing.Size(159, 20)
        Me.Txt_Matriculabusq.TabIndex = 10
        '
        'EpErrores
        '
        Me.EpErrores.ContainerControl = Me
        '
        'Matricula
        '
        Me.Matricula.HeaderText = "Matrícula"
        Me.Matricula.Name = "Matricula"
        Me.Matricula.ReadOnly = True
        '
        'Marca
        '
        Me.Marca.HeaderText = "Marca"
        Me.Marca.Name = "Marca"
        Me.Marca.ReadOnly = True
        '
        'Capacidad
        '
        Me.Capacidad.HeaderText = "Capacidad"
        Me.Capacidad.Name = "Capacidad"
        Me.Capacidad.ReadOnly = True
        '
        'Anio
        '
        Me.Anio.HeaderText = "Año"
        Me.Anio.Name = "Anio"
        Me.Anio.ReadOnly = True
        '
        'Actividad
        '
        Me.Actividad.HeaderText = "Actividad"
        Me.Actividad.Name = "Actividad"
        Me.Actividad.ReadOnly = True
        '
        'FrmVehículos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1198, 386)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "FrmVehículos"
        Me.Text = "Vehículos"
        Me.Panel1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.FlowLayoutPanel2.ResumeLayout(False)
        Me.FlowLayoutPanel2.PerformLayout()
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EpErrores, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents LblMensaje As System.Windows.Forms.Label
    Friend WithEvents Lbl_Actividad As System.Windows.Forms.Label
    Friend WithEvents Lbl_Anio As System.Windows.Forms.Label
    Friend WithEvents Lbl_Capacidad As System.Windows.Forms.Label
    Friend WithEvents Lbl_Marca As System.Windows.Forms.Label
    Friend WithEvents Lbl_Matrícula As System.Windows.Forms.Label
    Friend WithEvents FlowLayoutPanel2 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents Txt_Matricula As System.Windows.Forms.TextBox
    Friend WithEvents TxtNombre As System.Windows.Forms.TextBox
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox5 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox6 As System.Windows.Forms.TextBox
    Friend WithEvents FlowLayoutPanel1 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents BtnAgregar As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Lbl_Matricula As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Txt_Matriculabusq As System.Windows.Forms.TextBox
    Friend WithEvents EpErrores As System.Windows.Forms.ErrorProvider
    Friend WithEvents Matricula As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Marca As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Capacidad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Anio As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Actividad As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
