﻿Public Class FrmTransacciones

    Private Sub BtnTraslado_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnVenta.MouseHover, BtnTraslado.MouseHover, BtnCompra.MouseHover
        Dim pic = CType(sender, PictureBox)
        pic.BackColor = Color.FromArgb(29, 209, 161)
    End Sub

    Private Sub BtnVenta_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnVenta.MouseLeave, BtnTraslado.MouseLeave, BtnCompra.MouseLeave
        Dim pic = CType(sender, PictureBox)
        pic.BackColor = Color.FromArgb(131, 149, 167)
    End Sub

    Private Sub BtnCompra_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCompra.Click
        AbrirFormulario(New FrmCompras)
    End Sub

    Private Sub BtnVenta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnVenta.Click
        AbrirFormulario(New FrmVentas)
    End Sub

    Private Sub BtnTraslado_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnTraslado.Click
        AbrirFormulario(New FrmTraslados)
    End Sub
End Class