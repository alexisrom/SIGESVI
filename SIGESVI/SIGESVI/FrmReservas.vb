Public Class FrmReservas

    Private Sub FrmReservas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim persistencia As New PersistenciaReserva



        If CType(usuarioLogueado, Funcionario).EsGerenteGeneral Then
            DgvReservas.DataSource = persistencia.Listar
        Else
            DgvReservas.DataSource = persistencia.Listar(CType(usuarioLogueado, Funcionario).Sucursal)
        End If


    End Sub
End Class