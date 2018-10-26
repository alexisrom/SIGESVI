Public Class FrmTraslados

    Dim persistencia As PersistenciaTransaccion

    Private Sub FrmTraslados_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        persistencia = New PersistenciaTransaccion
        RestringirCampos(Me)
        ControlesPorDefecto()
    End Sub

    Private Sub ControlesPorDefecto()
        LimpiarControles(Me)
        CboVehiculo.DataSource = New PersistenciaTransporte().Listar()


        If usuarioLogueado.EsGerenteGeneral Then
            DgvVentas.DataSource = persistencia.ListarTraslados
        Else
            DgvVentas.DataSource = New PersistenciaCompra().Listar(CType(usuarioLogueado, Funcionario).Sucursal)
        End If



    End Sub

    Private Sub BtnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNuevo.Click

        If ValidarCampos(Me) Then
            Dim traslado As New Traslado()
            traslado.Fecha = DtpFecha.Value
            traslado.Destino = TxtDestino_REQ.Text
            traslado.Vehiculo = CboVehiculo.SelectedItem
            traslado.Sucursal = CType(usuarioLogueado, Funcionario).Sucursal

            Dim cantidad = 0
            For Each item In LstLotes.Items
                Dim lote = CType(item, Lote)
                traslado.Productos.Add(lote)
                cantidad += lote.Stock
            Next

            If cantidad > traslado.Vehiculo.Capacidad Then
                MessageBox.Show("La cantidad de productos supera la capacidad del vehículo")
            Else
                persistencia.Agregar(traslado)
                ControlesPorDefecto()
            End If



        End If

    End Sub

    Private Sub BtnSeleccionarLotes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAgregarLote.Click
        Dim frm As New FrmSeleccionarLotes
        AddOwnedForm(frm)
        frm.ShowDialog()
    End Sub

    Private Sub BtnEliminarLote_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEliminarLote.Click

        If LstLotes.SelectedIndex >= 0 Then
            LstLotes.Items.Remove(LstLotes.SelectedItem)
        End If

    End Sub
End Class