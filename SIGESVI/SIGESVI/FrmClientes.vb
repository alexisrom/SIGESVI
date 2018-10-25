Public Class FrmClientes
    Private persistencia As PersistenciaCliente
  
    Private Sub FrmClientes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        persistencia = New PersistenciaCliente
        RestringirCampos(Me)
        ControlesPorDefecto()
    End Sub

    Private Sub ControlesPorDefecto()
        LimpiarControles(Me)

        TxtID_NUM_REQ.Enabled = True
        DgvClientes.DataSource = persistencia.Listar()
    End Sub



    Private Sub BtnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnGuardar.Click
        If ValidarCampos(Me) Then
            Dim c As New Cliente()
            c.ID = CInt(TxtID_NUM_REQ.Text)
            c.Nombre = TxtNombre_REQ.Text
            c.Direccion = TxtDireccion_REQ.Text
            'f.Usuario = TxtUser_REQ.Text
            'f.Contrasena = TxtPass_REQ.Text
            c.Telefono = TxtTelefono_NUM_REQ.Text
            Guardar(c)
        End If
    End Sub

    Private Sub Guardar(ByVal cliente As Cliente)
        Try
            If TxtID_NUM_REQ.Enabled Then
                persistencia.Agregar(cliente)
                MessageBox.Show("cliente agregado exitosamente")
            Else
                persistencia.Modificar(cliente)
                MessageBox.Show("cliente modificado exitosamente")
            End If
            ControlesPorDefecto()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub BtnEditarCliente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEditarCliente.Click
        If DgvClientes.SelectedRows.Count > 0 Then
            Dim cliente = CType(DgvClientes.SelectedRows(0).DataBoundItem, Cliente)
            TxtID_NUM_REQ.Enabled = False
            TxtID_NUM_REQ.Text = cliente.ID
            TxtNombre_REQ.Text = cliente.Nombre
            TxtDireccion_REQ.Text = cliente.Direccion
            TxtTelefono_NUM_REQ.Text = cliente.Telefono
            'TxtPass_REQ.Text = cliente.Contrasena
            'TxtUser_REQ.Text = cliente.Usuario
            
        End If
    End Sub

    
    Private Sub BtnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEliminar.Click
        If DgvClientes.SelectedRows.Count > 0 Then
            Dim cliente = CType(DgvClientes.SelectedRows(0).DataBoundItem, Cliente)
            persistencia.Eliminar(Cliente)
            ControlesPorDefecto()
        End If
    End Sub

    Private Sub BtnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancelar.Click
        ControlesPorDefecto()
    End Sub
End Class