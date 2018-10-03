Public Class FrmSucursales
    Dim persistencia As PersistenciaSucursal
    Dim sucursal As Sucursal
    
    Private Sub FrmSucursales_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        persistencia = New PersistenciaSucursal()
        InicializarFormulario()
        SuscribirControles(Me)
    End Sub

    Sub InicializarFormulario()
        sucursal = Nothing
        DgvSucursales.DataSource = persistencia.Listar()

        CboDepartamentosREQ.DataSource = ListarDepartamentos()

        LimpiarControles(Me)

        BtnGuardar.Text = "AGREGAR"
    End Sub

    Private Sub BtnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnGuardar.Click

        If Not ValidarCampos(Me) Then
            Return
        End If

        If BtnGuardar.Text.Equals("AGREGAR") Then
            sucursal = New Sucursal()
        End If

        sucursal.Nombre = Txt_NombreREQ.Text.Trim()
        sucursal.Direccion = Txt_DireccionREQ.Text.Trim()
        sucursal.Departamento = CboDepartamentosREQ.SelectedItem.ToString()

        sucursal.Telefonos.Clear()
        For Each tel As String In LstTelefonosREQ.Items
            sucursal.Telefonos.Add(tel)
        Next

        Try

            If BtnGuardar.Text.Equals("AGREGAR") Then
                persistencia.Agregar(sucursal)
            Else
                persistencia.Modificar(sucursal)
            End If
            InicializarFormulario()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub BtnEditarSucursal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEditarSucursal.Click
        If DgvSucursales.SelectedRows.Count > 0 Then
            sucursal = CType(DgvSucursales.SelectedRows(0).DataBoundItem, Sucursal)
            Txt_NombreREQ.Text = sucursal.Nombre
            Txt_DireccionREQ.Text = sucursal.Direccion

            For Each item In CboDepartamentosREQ.Items

                If item.ToString().Equals(sucursal.Departamento) Then
                    CboDepartamentosREQ.SelectedItem = item
                End If

            Next
            LstTelefonosREQ.Items.Clear()
            LstTelefonosREQ.Items.AddRange(sucursal.Telefonos.ToArray)
            BtnGuardar.Text = "GUARDAR"
        End If
    End Sub

    Private Sub BtnEliminarSucursal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEliminarSucursal.Click

        If DgvSucursales.SelectedRows.Count > 0 Then
            sucursal = CType(DgvSucursales.SelectedRows(0).DataBoundItem, Sucursal)
            Try
                persistencia.Eliminar(sucursal)
                InicializarFormulario()

            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If

    End Sub

    Private Sub LbAgregarTelefono_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LbAgregarTelefono.LinkClicked

        If Txt_TelefonoNUM.Text <> "" And Not LstTelefonosREQ.Items.Contains(Txt_TelefonoNUM.Text) Then
            LstTelefonosREQ.Items.Add(Txt_TelefonoNUM.Text)
            Txt_TelefonoNUM.Clear()
        End If

    End Sub

    Private Sub LbQuitarTelefono_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LbQuitarTelefono.LinkClicked

        If LstTelefonosREQ.SelectedIndex >= 0 Then
            LstTelefonosREQ.Items.Remove(LstTelefonosREQ.SelectedItem)
        End If

    End Sub

    Private Sub BtnLimpiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnLimpiar.Click
        InicializarFormulario()
    End Sub

    Private Sub Txt_Telefono_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)
    End Sub


End Class