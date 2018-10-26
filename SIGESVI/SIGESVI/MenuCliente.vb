Public Class MenuCliente
    
 
    Private Sub BtnQuitarProducto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnQuitarProducto.Click

        If LstProductos.SelectedIndex >= 0 Then
            Carrito.EliminarProducto(LstProductos.SelectedIndex)
        End If

    End Sub

    Private Sub BtnCompetarReserva_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCompetarReserva.Click
        Dim r As New Reserva
        r.Cliente = CType(usuarioLogueado, Cliente)
        r.FechaHora = Date.Now
        r.Lineas = Carrito.lineas

        Try

            If lineas.Count = 0 Then
                Throw New Exception("Debe ingresar algún producto al carrito")
            End If

            Dim persistencia As New PersistenciaReserva
            persistencia.Agregar(r)
            MessageBox.Show("Reserva realiza exitosamente")
            'ControlesPorDefecto
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

End Class
