Public Class FrmListadoProduccion

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim frm As New FrmRecordatorio()
        frm.ShowDialog()
    End Sub

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Dim frm As New FrmVerTrazabilidad()
        frm.ShowDialog()
    End Sub
End Class