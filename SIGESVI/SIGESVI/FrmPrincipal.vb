Imports System.Runtime.InteropServices

Public Class FrmPrincipal

    Private Sub FrmPrincipal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ManejoVentanas.frmPrincipal = Me
        PicLogo_Click(Nothing, e)

    End Sub


    Private Sub BtnGestionProductos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnProductos.Click
        AbrirFormulario(New FrmListadoProductos)
    End Sub

    Private Sub PicLogo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PicLogo.Click
        AbrirFormulario(New Inicio)
    End Sub

    Private Sub BtnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCerrar.Click
        Application.Exit()
    End Sub

    Private Sub BtnMinimizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnMinimizar.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub BtnSucursales_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSucursales.Click
        AbrirFormulario(New FrmSucursales)
    End Sub

#Region "Comportamiento de ventana"

    Dim lx, ly As Integer
    Dim sw, sh As Integer

    Private Sub BtnMaximizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnMaximizar.Click

        lx = Me.Location.X
        ly = Me.Location.Y
        sw = Me.Size.Width
        sh = Me.Size.Height

        BtnMaximizar.Visible = False
        BtnRestaurar.Visible = True

        Me.Size = Screen.PrimaryScreen.WorkingArea.Size
        Me.Location = Screen.PrimaryScreen.WorkingArea.Location
    End Sub

    Private Sub BtnRestaurar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnRestaurar.Click
        Me.Size = New Size(sw, sh)
        Me.Location = New Point(lx, ly)

        BtnMaximizar.Visible = True
        BtnRestaurar.Visible = False
    End Sub

    'RESIZE DEL FORMULARIO- CAMBIAR TAMAÑO
    Dim cGrip As Integer = 10

    Protected Overrides Sub WndProc(ByRef m As Message)
        If (m.Msg = 132) Then
            Dim pos As Point = New Point((m.LParam.ToInt32 And 65535), (m.LParam.ToInt32 + 16))
            pos = Me.PointToClient(pos)
            If ((pos.X _
                        >= (Me.ClientSize.Width - cGrip)) _
                        AndAlso (pos.Y _
                        >= (Me.ClientSize.Height - cGrip))) Then
                m.Result = CType(17, IntPtr)
                Return
            End If
        End If
        MyBase.WndProc(m)
    End Sub
    '----------------DIBUJAR RECTANGULO / EXCLUIR ESQUINA PANEL 
    Dim sizeGripRectangle As Rectangle
    Dim tolerance As Integer = 15

    Protected Overrides Sub OnSizeChanged(ByVal e As EventArgs)
        MyBase.OnSizeChanged(e)
        Dim region = New Region(New Rectangle(0, 0, Me.ClientRectangle.Width, Me.ClientRectangle.Height))
        sizeGripRectangle = New Rectangle((Me.ClientRectangle.Width - tolerance), (Me.ClientRectangle.Height - tolerance), tolerance, tolerance)
        region.Exclude(sizeGripRectangle)
        Me.PnlContenedor.Region = region
        Me.Invalidate()
    End Sub

    '----------------COLOR Y GRIP DE RECTANGULO INFERIOR
    Protected Overrides Sub OnPaint(ByVal e As PaintEventArgs)
        Dim blueBrush As SolidBrush = New SolidBrush(Color.FromArgb(64, 64, 64))
        e.Graphics.FillRectangle(blueBrush, sizeGripRectangle)
        'MyBase.OnPaint(e)
        'ControlPaint.DrawSizeGrip(e.Graphics, Color.Transparent, sizeGripRectangle)
    End Sub

    'ARRASTRAR FORMULARIO
    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")> _
    Private Shared Sub ReleaseCapture()
    End Sub

    <DllImport("user32.DLL", EntryPoint:="SendMessage")> _
    Private Shared Sub SendMessage(ByVal hWnd As System.IntPtr, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer)
    End Sub

    'LLAMAR METODO EN EVENTO MOUSEMOVE DEL PANEL BARRA TITULO
    Private Sub PanelCabecera_MouseMove(ByVal sender As Object, ByVal e As MouseEventArgs) Handles PnlCabecera.MouseMove
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)

    End Sub

#End Region

    Private Sub BtnProductos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        AbrirFormulario(New FrmListadoProductos)
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        AbrirFormulario(New FrmFuncionarios)
    End Sub

    Private Sub BtnCliente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCliente.Click
        AbrirFormulario(New FrmClientes)
    End Sub

    Private Sub BtnCepas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCepas.Click
        AbrirFormulario(New FrmTipoCepa)
    End Sub

    Private Sub BtnCampos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCampos.Click
        AbrirFormulario(New FrmCampos)
    End Sub

    Private Sub BtnLotes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnLotes.Click
        AbrirFormulario(New FrmLotes)
    End Sub

    Private Sub BtnProduccion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnProduccion.Click
        AbrirFormulario(New FrmListadoProduccion)
    End Sub
End Class
