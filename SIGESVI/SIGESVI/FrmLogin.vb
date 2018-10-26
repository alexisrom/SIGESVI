Imports System.Runtime.InteropServices

Public Class FrmLogin

    Private Sub BtnIngresar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnIngresar.Click

        Dim user = TxtUser_REQ.Text
        Dim pass = TxtPass_REQ.Text

        Try
            Dim persistencia As New PersistenciaUsuario()
            Dim usuario = persistencia.Login(user, pass)

            If usuario Is Nothing Then
                Throw New Exception("Usuario y Contraseña incorrectos")
            End If

            usuarioLogueado = usuario

            Dim frm As New FrmPrincipal
            Me.Hide()
            frm.ShowDialog()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub BtnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCerrar.Click
        Application.Exit()
    End Sub

    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")> _
    Private Shared Sub ReleaseCapture()
    End Sub

    <DllImport("user32.DLL", EntryPoint:="SendMessage")> _
    Private Shared Sub SendMessage(ByVal hWnd As System.IntPtr, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer)
    End Sub


    Private Sub ArrastrarVentana(ByVal sender As Object, ByVal e As MouseEventArgs) Handles Panel2.MouseMove, PictureBox2.MouseMove
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub


End Class