Public Class FrmVehículos

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub BtnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAgregar.Click



    End Sub

    Private Sub TxtCI_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Txt_Matricula.Validated
        If Txt_Matricula.Text = "" Then
            EpErrores.SetError(Txt_Matricula, "Ingrese una cédula válida")
        End If
    End Sub

    Private Sub TxtCI_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Txt_Matricula.TextChanged

    End Sub

    Private Sub Lbl_Capacidad_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Lbl_Capacidad.Click

    End Sub
End Class