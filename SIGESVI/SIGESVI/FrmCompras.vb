Public Class FrmCompras
    Dim persistencia As PersistenciaCompra
    Dim compra As Compra
   
    Private Sub FrmCompras_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        persistencia = New PersistenciaCompra
        RestringirCampos(Me)
        ControlesPorDefecto()
    End Sub


    Private Sub ControlesPorDefecto()
        LimpiarControles(Me)

        CboProductos.DataSource = ListarEspecificaciones()
        CboProveedores.DataSource = New PersistenciaSucursal().ListarProveedores

        If usuarioLogueado.EsGerenteGeneral Then
            DgvCompras.DataSource = New PersistenciaCompra().Listar
        Else
            DgvCompras.DataSource = New PersistenciaCompra().Listar(CType(usuarioLogueado, Funcionario).Sucursal)

        End If



        LstProductos_REQ.DataSource = Nothing

        compra = New Compra()
        compra.Fecha = Date.Now
    End Sub

    Private Function ListarEspecificaciones() As List(Of EspecificacionProducto)
        Dim eproductos As New List(Of EspecificacionProducto)

        Dim materiasprimas = New PersistenciaMateriaPrima().Listar
        For Each m In materiasprimas
            eproductos.Add(m)
        Next

        Dim productosintermedios = New PersistenciaProductoIntermedio().Listar
        For Each p In productosintermedios
            eproductos.Add(p)
        Next

        Return eproductos
    End Function

    Private Sub BtnAgregarProducto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAgregarProducto.Click


        If String.IsNullOrEmpty(TxtCantidad_NUM.Text) Then
            Return
        End If

        Dim cantidad = TxtCantidad_NUM.Text

        If cantidad < 1 Then
            MessageBox.Show("Ingrese la cantidad de productos del tipo seleccionado")
        Else
            Dim eproducto = CType(CboProductos.SelectedItem, EspecificacionProducto)
            Dim lote As New Lote
            lote.Tipo = eproducto
            lote.Stock = cantidad
            lote.Origen = CType(CboProveedores.SelectedItem, Sucursal)
            lote.Fecha = compra.Fecha
            compra.Productos.Add(lote)
            LstProductos_REQ.DataSource = Nothing
            LstProductos_REQ.DataSource = compra.Productos
            LstProductos_REQ.Refresh()
        End If

    End Sub

    Private Sub BtnRegistrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnRegistrar.Click

        If ValidarCampos(Me) Then

            compra.Costo = TxtCosto_NUM_REQ.Text
            compra.Sucursal = CType(usuarioLogueado, Funcionario).Sucursal

            Try
                persistencia.Registrar(compra)
                MessageBox.Show("Compra registrada exitosamente")
                ControlesPorDefecto()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try

            
        End If

    End Sub
End Class