Imports System.Threading
Imports System.Globalization


Public Class FrmLenguaje


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Thread.CurrentThread.CurrentUICulture = New CultureInfo("es")
        Me.Hide()
        FrmLogin.Show()

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        Thread.CurrentThread.CurrentUICulture = New CultureInfo("en")
        Me.Hide()
        FrmLogin.Show()

    End Sub
End Class