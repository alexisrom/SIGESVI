Public Class FrmVentas
    Dim persistencia As PersistenciaTransaccion

    Private Sub FrmVentas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        persistencia = New PersistenciaTransaccion()
        RestringirCampos(Me)
        ControlesPorDefecto()
    End Sub

    Private Sub ControlesPorDefecto()
        LimpiarControles(Me)

        If usuarioLogueado.EsGerenteGeneral Then
            DgvVentas.DataSource = persistencia.ListarVentas
        Else
            DgvVentas.DataSource = persistencia.ListarVentas(CType(usuarioLogueado, Funcionario).Sucursal)
        End If


    End Sub

    Private Sub BtnSeleccionarLotes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSeleccionarLotes.Click
        Dim frm As New FrmSeleccionarLotes
        AddOwnedForm(frm)
        frm.ShowDialog()
    End Sub



    Private Sub BtnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNuevo.Click

        If ValidarCampos(Me) Then
            Dim venta As New Venta()
            venta.Precio = TxtCosto_NUM_REQ.Text
            venta.Fecha = DtpFecha.Value
            venta.Sucursal = CType(usuarioLogueado, Funcionario).Sucursal

            For Each item In LstLotes.Items
                venta.Productos.Add(CType(item, Lote))
            Next

            Try
                persistencia.Agregar(venta)
                MessageBox.Show("Venta registrada exitosamente")
                ControlesPorDefecto()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If

    End Sub


End Class