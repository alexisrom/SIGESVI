<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Viñedo
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Viñedo))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.LblMensaje = New System.Windows.Forms.Label
        Me.Lbl_Nombre = New System.Windows.Forms.Label
        Me.Lbl_Propietario = New System.Windows.Forms.Label
        Me.Lbl_Id = New System.Windows.Forms.Label
        Me.FlowLayoutPanel2 = New System.Windows.Forms.FlowLayoutPanel
        Me.Txt_Ci = New System.Windows.Forms.TextBox
        Me.Txt_Nombre = New System.Windows.Forms.TextBox
        Me.Txt_Apellido = New System.Windows.Forms.TextBox
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel
        Me.Btn_Agregar = New System.Windows.Forms.Button
        Me.Btn_Modificar = New System.Windows.Forms.Button
        Me.Btn_Eliminar = New System.Windows.Forms.Button
        Me.Btn_Limpiar = New System.Windows.Forms.Button
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.Lbl_IdBusqueda = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.Txt_IdBusqueda = New System.Windows.Forms.TextBox
        Me.CI = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Nombre = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Apellido = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.GroupBox1.SuspendLayout()
        Me.FlowLayoutPanel2.SuspendLayout()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.LblMensaje)
        Me.GroupBox1.Controls.Add(Me.Lbl_Nombre)
        Me.GroupBox1.Controls.Add(Me.Lbl_Propietario)
        Me.GroupBox1.Controls.Add(Me.Lbl_Id)
        Me.GroupBox1.Controls.Add(Me.FlowLayoutPanel2)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(299, 142)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Información viñedo"
        '
        'LblMensaje
        '
        Me.LblMensaje.AutoSize = True
        Me.LblMensaje.Location = New System.Drawing.Point(120, 222)
        Me.LblMensaje.Name = "LblMensaje"
        Me.LblMensaje.Size = New System.Drawing.Size(0, 13)
        Me.LblMensaje.TabIndex = 3
        '
        'Lbl_Nombre
        '
        Me.Lbl_Nombre.AutoSize = True
        Me.Lbl_Nombre.Location = New System.Drawing.Point(56, 73)
        Me.Lbl_Nombre.Name = "Lbl_Nombre"
        Me.Lbl_Nombre.Size = New System.Drawing.Size(44, 13)
        Me.Lbl_Nombre.TabIndex = 3
        Me.Lbl_Nombre.Text = "Nombre"
        '
        'Lbl_Propietario
        '
        Me.Lbl_Propietario.AutoSize = True
        Me.Lbl_Propietario.Location = New System.Drawing.Point(42, 99)
        Me.Lbl_Propietario.Name = "Lbl_Propietario"
        Me.Lbl_Propietario.Size = New System.Drawing.Size(57, 13)
        Me.Lbl_Propietario.TabIndex = 2
        Me.Lbl_Propietario.Text = "Propietario"
        '
        'Lbl_Id
        '
        Me.Lbl_Id.AutoSize = True
        Me.Lbl_Id.Location = New System.Drawing.Point(82, 44)
        Me.Lbl_Id.Name = "Lbl_Id"
        Me.Lbl_Id.Size = New System.Drawing.Size(18, 13)
        Me.Lbl_Id.TabIndex = 1
        Me.Lbl_Id.Text = "ID"
        '
        'FlowLayoutPanel2
        '
        Me.FlowLayoutPanel2.Controls.Add(Me.Txt_Ci)
        Me.FlowLayoutPanel2.Controls.Add(Me.Txt_Nombre)
        Me.FlowLayoutPanel2.Controls.Add(Me.Txt_Apellido)
        Me.FlowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.FlowLayoutPanel2.Location = New System.Drawing.Point(106, 41)
        Me.FlowLayoutPanel2.Name = "FlowLayoutPanel2"
        Me.FlowLayoutPanel2.Size = New System.Drawing.Size(184, 86)
        Me.FlowLayoutPanel2.TabIndex = 0
        '
        'Txt_Ci
        '
        Me.Txt_Ci.Location = New System.Drawing.Point(3, 3)
        Me.Txt_Ci.Name = "Txt_Ci"
        Me.Txt_Ci.Size = New System.Drawing.Size(173, 20)
        Me.Txt_Ci.TabIndex = 1
        '
        'Txt_Nombre
        '
        Me.Txt_Nombre.Location = New System.Drawing.Point(3, 29)
        Me.Txt_Nombre.Name = "Txt_Nombre"
        Me.Txt_Nombre.Size = New System.Drawing.Size(173, 20)
        Me.Txt_Nombre.TabIndex = 2
        '
        'Txt_Apellido
        '
        Me.Txt_Apellido.Location = New System.Drawing.Point(3, 55)
        Me.Txt_Apellido.Name = "Txt_Apellido"
        Me.Txt_Apellido.Size = New System.Drawing.Size(173, 20)
        Me.Txt_Apellido.TabIndex = 3
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Controls.Add(Me.Btn_Agregar)
        Me.FlowLayoutPanel1.Controls.Add(Me.Btn_Modificar)
        Me.FlowLayoutPanel1.Controls.Add(Me.Btn_Eliminar)
        Me.FlowLayoutPanel1.Controls.Add(Me.Btn_Limpiar)
        Me.FlowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(317, 18)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(84, 229)
        Me.FlowLayoutPanel1.TabIndex = 4
        '
        'Btn_Agregar
        '
        Me.Btn_Agregar.Location = New System.Drawing.Point(3, 3)
        Me.Btn_Agregar.Name = "Btn_Agregar"
        Me.Btn_Agregar.Size = New System.Drawing.Size(75, 23)
        Me.Btn_Agregar.TabIndex = 0
        Me.Btn_Agregar.Text = "Agregar"
        Me.Btn_Agregar.UseVisualStyleBackColor = True
        '
        'Btn_Modificar
        '
        Me.Btn_Modificar.Location = New System.Drawing.Point(3, 32)
        Me.Btn_Modificar.Name = "Btn_Modificar"
        Me.Btn_Modificar.Size = New System.Drawing.Size(75, 23)
        Me.Btn_Modificar.TabIndex = 1
        Me.Btn_Modificar.Text = "Modificar"
        Me.Btn_Modificar.UseVisualStyleBackColor = True
        '
        'Btn_Eliminar
        '
        Me.Btn_Eliminar.Location = New System.Drawing.Point(3, 61)
        Me.Btn_Eliminar.Name = "Btn_Eliminar"
        Me.Btn_Eliminar.Size = New System.Drawing.Size(75, 23)
        Me.Btn_Eliminar.TabIndex = 2
        Me.Btn_Eliminar.Text = "Eliminar"
        Me.Btn_Eliminar.UseVisualStyleBackColor = True
        '
        'Btn_Limpiar
        '
        Me.Btn_Limpiar.Location = New System.Drawing.Point(3, 90)
        Me.Btn_Limpiar.Name = "Btn_Limpiar"
        Me.Btn_Limpiar.Size = New System.Drawing.Size(75, 23)
        Me.Btn_Limpiar.TabIndex = 3
        Me.Btn_Limpiar.Text = "Limpiar"
        Me.Btn_Limpiar.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Lbl_IdBusqueda)
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Controls.Add(Me.DataGridView1)
        Me.Panel2.Controls.Add(Me.Txt_IdBusqueda)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel2.Location = New System.Drawing.Point(407, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(809, 474)
        Me.Panel2.TabIndex = 12
        '
        'Lbl_IdBusqueda
        '
        Me.Lbl_IdBusqueda.AutoSize = True
        Me.Lbl_IdBusqueda.Location = New System.Drawing.Point(34, 40)
        Me.Lbl_IdBusqueda.Name = "Lbl_IdBusqueda"
        Me.Lbl_IdBusqueda.Size = New System.Drawing.Size(40, 13)
        Me.Lbl_IdBusqueda.TabIndex = 11
        Me.Lbl_IdBusqueda.Text = "Cédula"
        '
        'PictureBox1
        '
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
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
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CI, Me.Nombre, Me.Apellido})
        Me.DataGridView1.Location = New System.Drawing.Point(37, 106)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(344, 150)
        Me.DataGridView1.TabIndex = 9
        '
        'Txt_IdBusqueda
        '
        Me.Txt_IdBusqueda.Location = New System.Drawing.Point(37, 55)
        Me.Txt_IdBusqueda.Name = "Txt_IdBusqueda"
        Me.Txt_IdBusqueda.Size = New System.Drawing.Size(159, 20)
        Me.Txt_IdBusqueda.TabIndex = 10
        '
        'CI
        '
        Me.CI.HeaderText = "ID"
        Me.CI.Name = "CI"
        Me.CI.ReadOnly = True
        '
        'Nombre
        '
        Me.Nombre.HeaderText = "Nombre"
        Me.Nombre.Name = "Nombre"
        Me.Nombre.ReadOnly = True
        '
        'Apellido
        '
        Me.Apellido.HeaderText = "Propietario"
        Me.Apellido.Name = "Apellido"
        Me.Apellido.ReadOnly = True
        '
        'Viñedo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1216, 474)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Viñedo"
        Me.Text = "Viñedo"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.FlowLayoutPanel2.ResumeLayout(False)
        Me.FlowLayoutPanel2.PerformLayout()
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents LblMensaje As System.Windows.Forms.Label
    Friend WithEvents Lbl_Nombre As System.Windows.Forms.Label
    Friend WithEvents Lbl_Propietario As System.Windows.Forms.Label
    Friend WithEvents Lbl_Id As System.Windows.Forms.Label
    Friend WithEvents FlowLayoutPanel2 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents Txt_Ci As System.Windows.Forms.TextBox
    Friend WithEvents Txt_Nombre As System.Windows.Forms.TextBox
    Friend WithEvents Txt_Apellido As System.Windows.Forms.TextBox
    Friend WithEvents FlowLayoutPanel1 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents Btn_Agregar As System.Windows.Forms.Button
    Friend WithEvents Btn_Modificar As System.Windows.Forms.Button
    Friend WithEvents Btn_Eliminar As System.Windows.Forms.Button
    Friend WithEvents Btn_Limpiar As System.Windows.Forms.Button
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Lbl_IdBusqueda As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents CI As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Nombre As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Apellido As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Txt_IdBusqueda As System.Windows.Forms.TextBox
End Class
