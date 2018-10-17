Public Class FrmFormularioEProducto

    Private persistencia As PersistenciaEspecificacionProducto
    Public etapas As List(Of EtapaElaboracion)

    ' Indica el modo en que se utilizará el formulario
    Public modoAlta = True

    Private Sub FrmFormularioEProducto_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        persistencia = New PersistenciaEspecificacionProducto()

        etapas = New List(Of EtapaElaboracion)
        etapas.Add(New EtapaElaboracion(0, 12, "asd", "as", 3))

        MostarEtapas()


        ControlesPorDefecto()

        SuscribirControles(Me)

    End Sub

    Public Sub MostarEtapas()
        DgvEtapasElaboracion.DataSource = Nothing
        DgvEtapasElaboracion.DataSource = etapas
        DgvEtapasElaboracion.Refresh()
    End Sub


    Private Sub ControlesPorDefecto()
        Utilidades.LimpiarControles(Me)

        If modoAlta Then
            TxtID_NUM_REQ.Text = 0
        End If

    End Sub


    Private Function ValidarCampos(ByVal eproducto As EspecificacionProducto) As Boolean

        Dim camposValidos = True

        If camposValidos Then
            Dim ep As New ErrorProvider

            If eproducto.Precio <= 0 Then
                ep.SetError(TxtPrecio_NUM_REQ, "El precio debe ser positivo")
                camposValidos = False
            End If
        End If

        Return camposValidos
    End Function

    

    Private Sub BtnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnGuardar.Click

        Dim validacionCorrecta = Validacion.ValidarCampos(Me)

        If Not validacionCorrecta Then
            Return
        End If


        Dim eproducto = CrearProducto()

        If Not ValidarCampos(eproducto) Then
            Return
        End If

        Try
            If modoAlta Then

                If TypeOf eproducto Is MateriaPrima Then

                End If


            Else
                persistencia.Modificar(eproducto)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Function CrearProducto() As EspecificacionProducto
        Dim id = CInt(TxtID_NUM_REQ.Text)
        Dim nombre = TxtNombre_REQ.Text
        Dim descripcion = TxtDescripcion_REQ.Text
        Dim precio = CDec(TxtPrecio_NUM_REQ.Text)
        Dim guia = TxtTextoGuia.Text
        Dim cepa = CStr(CboCepas.SelectedItem)
        Dim calidad = CStr(CboCalidad.SelectedItem)
        Dim crianza = CStr(CboCrianza.SelectedItem)
        Dim embotellamiento = CStr(CboEmbotellamiento.SelectedItem)
        Dim foto = PbFoto.Image



        Select Case CboTipoProducto.SelectedItem.ToString()
            Case "Materia Prima"
                ' Return New MateriaPrima(id, nombre, descripcion, precio, etapas, foto, "Tinto", cepa)
            Case "Producto Intermedio"
                ' Return New ProductoIntermedio(id, nombre, descripcion, calidad, precio, "Kg", etapas, foto, cepa)
            Case Else
                ' Return New ProductoFinal(id, nombre, descripcion, calidad, precio, "L", etapas, foto, cepa)
        End Select
        
    End Function

    Private Sub CboTipoProducto_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CboTipoProducto.SelectedIndexChanged
        Select Case CboTipoProducto.SelectedItem.ToString()
            Case "Materia Prima"
                CboCalidad.Visible = False
                CboCrianza.Visible = False
                CboEmbotellamiento.Visible = False
                CboCepas.Visible = True
            Case "Producto Intermedio"
                CboCalidad.Visible = True
                CboCrianza.Visible = False
                CboEmbotellamiento.Visible = False
                CboCepas.Visible = False
            Case "Producto Final"
                CboCalidad.Visible = False
                CboCrianza.Visible = True
                CboEmbotellamiento.Visible = True
                CboCepas.Visible = False
        End Select
    End Sub

    Private Sub BtnSeleccionarImagen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSeleccionarImagen.Click
        If OfdSeleccionarImagen.ShowDialog() = DialogResult.OK Then
            PbFoto.Image = Image.FromFile(OfdSeleccionarImagen.FileName)
        End If
    End Sub

    Private Sub LbNuevaEtapa_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LbNuevaEtapa.LinkClicked
        Dim frm As New FrmEtapas
        AddOwnedForm(frm)
        frm.ShowDialog()
        MostarEtapas()
    End Sub
End Class