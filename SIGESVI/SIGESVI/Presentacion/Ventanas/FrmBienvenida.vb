﻿Public Class frm_Bienvenida

    Private Sub lbl_SIGESVI_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbl_SIGESVI.Click

    End Sub

    Private Sub lbl_Ingreso_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub btn_IngresarAlSistema_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Hide()
        Dim frm = New FrmCatalogo()
        frm.ShowDialog()
        Me.Close()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Call conecta()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim sql As String
        sql = "insert into almacen values(01, 'soyunasucursal', 01)"
        Dim comando As New Odbc.OdbcCommand
        conexion.conecta()
        comando.Connection = conectar
        comando.CommandText = sql
        Try
            comando.ExecuteNonQuery()
        Catch
            MsgBox("Error" & Err.Description)

        End Try
        conexion.cierra()
    End Sub

    Private Sub frm_Bienvenida_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
