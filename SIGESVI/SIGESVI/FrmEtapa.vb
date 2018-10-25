Public Class FrmEtapa
    Private recordatrios As List(Of Recordatorio)

    Private Sub FrmEtapa_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        recordatrios = New List(Of Recordatorio)
        RestringirCampos(Me)
    End Sub

    Private Sub BtnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAgregar.Click

        If ValidarCampos(Me) Then
            Dim etapa As New EtapaElaboracion()
            etapa.Nombre = TxtNombre_REQ.Text
            etapa.Descripcion = TxtDescripcion_REQ.Text
            etapa.Numero = CInt(TxtNumero_NUM_REQ.Text)
            etapa.Duracion = CInt(TxtDuracion_NUM_REQ.Text)
            etapa.Recordatorios = recordatrios
            AgregarEtapa(etapa)
        End If

    End Sub

    Private Sub AgregarEtapa(ByVal etapa As EtapaElaboracion)
        Dim frm As FrmProductoFinal = CType(Owner, FrmProductoFinal)
        frm.etapasDeElaboracion.Add(etapa)
        Me.Close()
    End Sub


    Private Sub BtnAgregarRecordatorio_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAgregarRecordatorio.Click


        If String.IsNullOrEmpty(TxtMensaje.Text) Or String.IsNullOrEmpty(TxtDia.Text) Then
            MessageBox.Show("Ingrese el mensaje y el día del recordatorío")
        Else
            
        End If

        Try

            If String.IsNullOrEmpty(TxtMensaje.Text) Then
                Throw New Exception("Ingrese el mensaje del recordatorio")
            End If

            If String.IsNullOrEmpty(TxtDia.Text) Then
                Throw New Exception("Ingrese el numero del día a mostrar")
            End If

            Dim r As New Recordatorio
            r.Mensaje = TxtMensaje.Text
            r.Dia = TxtDia.Text
            recordatrios.Add(r)
            LstRecordatorios.Items.Add(r)
            TxtDia.Clear()
            TxtMensaje.Clear()


        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub


End Class