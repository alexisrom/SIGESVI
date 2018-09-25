Public Class FrmSucursales
    Dim persistencia As PersistenciaSucursal
    Dim sucursal As Sucursal
    
    Private Sub FrmSucursales_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        persistencia = New PersistenciaSucursal()
        InicializarComponentes()
    End Sub

    Sub InicializarComponentes()
        sucursal = Nothing
        DgvSucursales.DataSource = persistencia.Listar()
        
        LimpiarControles(Me)

        CboDepartamentos.DataSource = ListarDepartamentos()
        CboDepartamentos.SelectedIndex = 0

        BtnGuardar.Text = "AGREGAR"
    End Sub

    Private Sub BtnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnGuardar.Click

        If BtnGuardar.Text.Equals("AGREGAR") Then
            sucursal = New Sucursal()
        End If

        sucursal.Nombre = Txt_Nombre.Text
        sucursal.Direccion = Txt_Direccion.Text
        sucursal.Departamento = CboDepartamentos.SelectedItem.ToString()

        sucursal.Telefonos.Clear()
        For Each tel As String In LstTelefonos.Items
            sucursal.Telefonos.Add(tel)
        Next

        Try
            If BtnGuardar.Text.Equals("AGREGAR") Then
                persistencia.Agregar(sucursal)
            Else
                persistencia.Modificar(sucursal)
            End If

            InicializarComponentes()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub BtnEditarSucursal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEditarSucursal.Click
        If DgvSucursales.SelectedRows.Count > 0 Then
            sucursal = CType(DgvSucursales.SelectedRows(0).DataBoundItem, Sucursal)
            Txt_Nombre.Text = sucursal.Nombre
            Txt_Direccion.Text = sucursal.Direccion
            'CboDepartamentos.SelectedValue = sucursal.Departamento
            For Each item In CboDepartamentos.Items

                If item.ToString().Equals(sucursal.Departamento) Then
                    CboDepartamentos.SelectedItem = item
                End If

            Next
            LstTelefonos.Items.Clear()
            LstTelefonos.Items.AddRange(sucursal.Telefonos.ToArray)
            BtnGuardar.Text = "GUARDAR"
        End If
    End Sub

    Private Sub BtnEliminarSucursal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEliminarSucursal.Click

        If DgvSucursales.SelectedRows.Count > 0 Then
            sucursal = CType(DgvSucursales.SelectedRows(0).DataBoundItem, Sucursal)
            Try
                persistencia.Eliminar(sucursal)
                sucursal = Nothing
                DgvSucursales.DataSource = persistencia.Listar()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If

    End Sub

    Private Sub LbAgregarTelefono_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LbAgregarTelefono.LinkClicked

        If Txt_Telefono.Text <> "" And Not LstTelefonos.Items.Contains(Txt_Telefono.Text) Then
            LstTelefonos.Items.Add(Txt_Telefono.Text)
            Txt_Telefono.Clear()
        End If

    End Sub

    Private Sub LbQuitarTelefono_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LbQuitarTelefono.LinkClicked

        If LstTelefonos.SelectedIndex >= 0 Then
            LstTelefonos.Items.Remove(LstTelefonos.SelectedItem)
        End If

    End Sub

    Private Sub BtnLimpiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnLimpiar.Click
        InicializarComponentes()
    End Sub

    Private Sub Txt_Telefono_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)
    End Sub

End Class