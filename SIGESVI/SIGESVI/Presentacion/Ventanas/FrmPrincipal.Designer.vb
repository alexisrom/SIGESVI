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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.GestiónToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ClientesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.TransporteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.FuncionariosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ProducciónToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ProductosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.VinosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.MostoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.SucursalesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.TransaccionesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.CompraToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.VentaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.TransporteToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.ConsultasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ElaboraciónToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ProducciónSucursalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.NóminaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.CantidadDeProductoPorEstadoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.EstadísticasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ConfiguraciónToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip
        Me.PnlContenidoPrincipal = New System.Windows.Forms.Panel
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GestiónToolStripMenuItem, Me.TransaccionesToolStripMenuItem, Me.ConsultasToolStripMenuItem, Me.EstadísticasToolStripMenuItem, Me.ConfiguraciónToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(982, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'GestiónToolStripMenuItem
        '
        Me.GestiónToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ClientesToolStripMenuItem, Me.TransporteToolStripMenuItem, Me.FuncionariosToolStripMenuItem, Me.ProducciónToolStripMenuItem, Me.ProductosToolStripMenuItem, Me.SucursalesToolStripMenuItem})
        Me.GestiónToolStripMenuItem.Name = "GestiónToolStripMenuItem"
        Me.GestiónToolStripMenuItem.Size = New System.Drawing.Size(59, 20)
        Me.GestiónToolStripMenuItem.Text = "Gestión"
        '
        'ClientesToolStripMenuItem
        '
        Me.ClientesToolStripMenuItem.Name = "ClientesToolStripMenuItem"
        Me.ClientesToolStripMenuItem.Size = New System.Drawing.Size(142, 22)
        Me.ClientesToolStripMenuItem.Text = "Clientes"
        '
        'TransporteToolStripMenuItem
        '
        Me.TransporteToolStripMenuItem.Name = "TransporteToolStripMenuItem"
        Me.TransporteToolStripMenuItem.Size = New System.Drawing.Size(142, 22)
        Me.TransporteToolStripMenuItem.Text = "Vehículos"
        '
        'FuncionariosToolStripMenuItem
        '
        Me.FuncionariosToolStripMenuItem.Name = "FuncionariosToolStripMenuItem"
        Me.FuncionariosToolStripMenuItem.Size = New System.Drawing.Size(142, 22)
        Me.FuncionariosToolStripMenuItem.Text = "Funcionarios"
        '
        'ProducciónToolStripMenuItem
        '
        Me.ProducciónToolStripMenuItem.Name = "ProducciónToolStripMenuItem"
        Me.ProducciónToolStripMenuItem.Size = New System.Drawing.Size(142, 22)
        Me.ProducciónToolStripMenuItem.Text = "Producción"
        '
        'ProductosToolStripMenuItem
        '
        Me.ProductosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.VinosToolStripMenuItem, Me.MostoToolStripMenuItem})
        Me.ProductosToolStripMenuItem.Name = "ProductosToolStripMenuItem"
        Me.ProductosToolStripMenuItem.Size = New System.Drawing.Size(142, 22)
        Me.ProductosToolStripMenuItem.Text = "Productos"
        '
        'VinosToolStripMenuItem
        '
        Me.VinosToolStripMenuItem.Name = "VinosToolStripMenuItem"
        Me.VinosToolStripMenuItem.Size = New System.Drawing.Size(108, 22)
        Me.VinosToolStripMenuItem.Text = "Vinos"
        '
        'MostoToolStripMenuItem
        '
        Me.MostoToolStripMenuItem.Name = "MostoToolStripMenuItem"
        Me.MostoToolStripMenuItem.Size = New System.Drawing.Size(108, 22)
        Me.MostoToolStripMenuItem.Text = "Mosto"
        '
        'SucursalesToolStripMenuItem
        '
        Me.SucursalesToolStripMenuItem.Name = "SucursalesToolStripMenuItem"
        Me.SucursalesToolStripMenuItem.Size = New System.Drawing.Size(142, 22)
        Me.SucursalesToolStripMenuItem.Text = "Sucursales"
        '
        'TransaccionesToolStripMenuItem
        '
        Me.TransaccionesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CompraToolStripMenuItem, Me.VentaToolStripMenuItem, Me.TransporteToolStripMenuItem1})
        Me.TransaccionesToolStripMenuItem.Name = "TransaccionesToolStripMenuItem"
        Me.TransaccionesToolStripMenuItem.Size = New System.Drawing.Size(93, 20)
        Me.TransaccionesToolStripMenuItem.Text = "Transacciones"
        '
        'CompraToolStripMenuItem
        '
        Me.CompraToolStripMenuItem.Name = "CompraToolStripMenuItem"
        Me.CompraToolStripMenuItem.Size = New System.Drawing.Size(130, 22)
        Me.CompraToolStripMenuItem.Text = "Compra"
        '
        'VentaToolStripMenuItem
        '
        Me.VentaToolStripMenuItem.Name = "VentaToolStripMenuItem"
        Me.VentaToolStripMenuItem.Size = New System.Drawing.Size(130, 22)
        Me.VentaToolStripMenuItem.Text = "Venta"
        '
        'TransporteToolStripMenuItem1
        '
        Me.TransporteToolStripMenuItem1.Name = "TransporteToolStripMenuItem1"
        Me.TransporteToolStripMenuItem1.Size = New System.Drawing.Size(130, 22)
        Me.TransporteToolStripMenuItem1.Text = "Transporte"
        '
        'ConsultasToolStripMenuItem
        '
        Me.ConsultasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ElaboraciónToolStripMenuItem, Me.ProducciónSucursalToolStripMenuItem, Me.NóminaToolStripMenuItem, Me.CantidadDeProductoPorEstadoToolStripMenuItem})
        Me.ConsultasToolStripMenuItem.Name = "ConsultasToolStripMenuItem"
        Me.ConsultasToolStripMenuItem.Size = New System.Drawing.Size(71, 20)
        Me.ConsultasToolStripMenuItem.Text = "Consultas"
        '
        'ElaboraciónToolStripMenuItem
        '
        Me.ElaboraciónToolStripMenuItem.Name = "ElaboraciónToolStripMenuItem"
        Me.ElaboraciónToolStripMenuItem.Size = New System.Drawing.Size(249, 22)
        Me.ElaboraciónToolStripMenuItem.Text = "Producción Total"
        '
        'ProducciónSucursalToolStripMenuItem
        '
        Me.ProducciónSucursalToolStripMenuItem.Name = "ProducciónSucursalToolStripMenuItem"
        Me.ProducciónSucursalToolStripMenuItem.Size = New System.Drawing.Size(249, 22)
        Me.ProducciónSucursalToolStripMenuItem.Text = "Producción Sucursal"
        '
        'NóminaToolStripMenuItem
        '
        Me.NóminaToolStripMenuItem.Name = "NóminaToolStripMenuItem"
        Me.NóminaToolStripMenuItem.Size = New System.Drawing.Size(249, 22)
        Me.NóminaToolStripMenuItem.Text = "Nómina"
        '
        'CantidadDeProductoPorEstadoToolStripMenuItem
        '
        Me.CantidadDeProductoPorEstadoToolStripMenuItem.Name = "CantidadDeProductoPorEstadoToolStripMenuItem"
        Me.CantidadDeProductoPorEstadoToolStripMenuItem.Size = New System.Drawing.Size(249, 22)
        Me.CantidadDeProductoPorEstadoToolStripMenuItem.Text = "Cantidad de producto por estado"
        '
        'EstadísticasToolStripMenuItem
        '
        Me.EstadísticasToolStripMenuItem.Name = "EstadísticasToolStripMenuItem"
        Me.EstadísticasToolStripMenuItem.Size = New System.Drawing.Size(79, 20)
        Me.EstadísticasToolStripMenuItem.Text = "Estadísticas"
        '
        'ConfiguraciónToolStripMenuItem
        '
        Me.ConfiguraciónToolStripMenuItem.Name = "ConfiguraciónToolStripMenuItem"
        Me.ConfiguraciónToolStripMenuItem.Size = New System.Drawing.Size(95, 20)
        Me.ConfiguraciónToolStripMenuItem.Text = "Configuración"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 426)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(982, 22)
        Me.StatusStrip1.TabIndex = 1
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'PnlContenidoPrincipal
        '
        Me.PnlContenidoPrincipal.BackgroundImage = Global.SIGESVI.My.Resources.Resources.Imagen_menu_principal
        Me.PnlContenidoPrincipal.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PnlContenidoPrincipal.Location = New System.Drawing.Point(0, 24)
        Me.PnlContenidoPrincipal.Name = "PnlContenidoPrincipal"
        Me.PnlContenidoPrincipal.Size = New System.Drawing.Size(982, 402)
        Me.PnlContenidoPrincipal.TabIndex = 2
        '
        'FrmPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDark
        Me.ClientSize = New System.Drawing.Size(982, 448)
        Me.Controls.Add(Me.PnlContenidoPrincipal)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "FrmPrincipal"
        Me.Text = "Menu Principal"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents GestiónToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ProductosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ProducciónToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FuncionariosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SucursalesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TransporteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConsultasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EstadísticasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConfiguraciónToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TransaccionesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CompraToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VentaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TransporteToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents PnlContenidoPrincipal As System.Windows.Forms.Panel
    Friend WithEvents ClientesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VinosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ElaboraciónToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ProducciónSucursalToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NóminaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CantidadDeProductoPorEstadoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MostoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
