Public Class FrmFuncionarios

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub BtnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Agregar.Click



    End Sub

    Private Sub TxtCI_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Txt_Ci.Validated
        If Txt_Ci.Text = "" Then
            EpErrores.SetError(Txt_Ci, "Ingrese una cédula válida")
        End If
    End Sub

    Private Sub TxtCI_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Txt_Ci.TextChanged

    End Sub
End Class