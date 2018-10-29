Imports System.Threading
Imports System.Globalization


Public Class FrmLenguaje


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEspanol.Click
        Thread.CurrentThread.CurrentUICulture = New CultureInfo("es")
        Me.Hide()
        FrmLogin.Show()

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnIngles.Click

        Thread.CurrentThread.CurrentUICulture = New CultureInfo("en")
        Me.Hide()
        FrmLogin.Show()

    End Sub

    Private Sub PicClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PicClose.Click
        Application.Exit()
    End Sub
End Class