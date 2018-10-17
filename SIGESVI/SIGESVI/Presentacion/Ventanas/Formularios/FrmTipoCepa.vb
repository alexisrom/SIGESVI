Public Class FrmTipoCepa

    Public modoAlta As Boolean = True
    Public tipoCepa As TipoCepa

    Private Sub FrmTipoCepa_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SuscribirControles(Me)
        ControlesPorDefecto()

    End Sub

    Private Sub ControlesPorDefecto()
        LimpiarControles(Me)
        If modoAlta Then
            TxtID.Text = "0"
            TxtID.ReadOnly = True
        Else
            TxtID.Text = tipoCepa.ID
            TxtNombre_REQ.Text = tipoCepa.Nombre
            For Each item In CboTipo.Items

                If item.ToString().Equals(tipoCepa.Tipo) Then
                    CboTipo.SelectedIndex = CboTipo.Items.IndexOf(item)
                End If

            Next

        End If
    End Sub



    Private Sub BtnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnGuardar.Click

        If Not Validacion.ValidarCampos(Me) Then
            Return
        End If

        Dim id = CInt(TxtID.Text)
        Dim nombre = TxtNombre_REQ.Text
        Dim tipo = CboTipo.SelectedItem.ToString()
        Dim tipoCepa As New TipoCepa(id, nombre, tipo)

        Guardar(tipoCepa)

        ControlesPorDefecto()
    End Sub


    Private Sub Guardar(ByVal tipoCepa As TipoCepa)
        Dim persistencia As New PersistenciaTipoCepa

        Try
            If modoAlta Then
                persistencia.Agregar(tipoCepa)
            Else
                persistencia.Modificar(tipoCepa)
            End If
            Me.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

End Class