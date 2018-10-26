Public Class FrmReservas

    Private Sub FrmReservas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim persistencia As New PersistenciaReserva
        DgvReservas.DataSource = persistencia.Listar
    End Sub
End Class