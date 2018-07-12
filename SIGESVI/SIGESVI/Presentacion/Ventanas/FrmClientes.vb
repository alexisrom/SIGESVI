Public Class FrmClientes
   Private Sub Btn_AgregarTel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_AñadirTel.Click
        If vacio(Txt_Telefono) Then
            Errortelefono.SetError(Txt_Telefono, "pone un telefono messi")
        End If

        If Not vacio(Txt_Telefono) Then
            If solonumeros(Txt_Telefono) Then
                LblTelefonos.Items.Add(Txt_Telefono.Text)
                Errortelefono.Clear()
                Txt_Telefono.Clear()
            Else
                Errortelefono.SetError(Txt_Telefono, "ingrese un telefono valido")

            End If
        End If

    End Sub

    Private Sub ToolStripButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton3.Click

    End Sub

    Private Sub Btn_Quitar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Quitartel.Click
        If Not vaciolistbox(LblTelefonos) Then
            LblTelefonos.Items.RemoveAt(LblTelefonos.SelectedIndex)
        End If

    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click

       
        If vaciolistbox(LblTelefonos) Then
            Errortelefono.SetError(Txt_Telefono, "Tiene que igresar almenos un telefono")
        Else
            If Not vaciolistbox(LblTelefonos) Then
                Errortelefono.Clear()
            End If
        End If



        If vacio(Txt_nombre) Then
            errordenombre.SetError(Txt_nombre, "ingrese un nombre")
        ElseIf Not sololetras(Txt_nombre) Then
            errordenombre.SetError(Txt_nombre, "ingrese un nombre valido")
        Else
            errordenombre.Clear()
        End If



        If vacio(Txt_Apellido) Then
            errordeapellido.SetError(Txt_Apellido, "ingrese un apellido")
        ElseIf Not sololetras(Txt_Apellido) Then
            errordeapellido.SetError(Txt_Apellido, "ingrese un apellido valido")
        Else
            errordeapellido.Clear()
        End If

       





        'If vacio(Txt_Ci) Then
        'errordecedula.SetError(Txt_Ci, "ingrese una cedula")
        'End If

        If vacio(Txt_Direccion) Then
            errordedireccion.SetError(Txt_Direccion, "ingrese una direccion")
        End If
        If Not vacio(Txt_Direccion) Then
            errordedireccion.Clear()
        End If
        If Not sololetras(Txt_nombre) Then
            errordenombre.SetError(Txt_nombre, "ingrese un nombre Valido")
        End If

        'If Not cedulavalida(Txt_Ci) Then
        'errordecedula.SetError(Txt_Ci, "ingrese una cedula valida")
        'End If

        'If cedulavalida(Txt_Ci) Then
        'errordecedula.Clear()
        'End If
        If vacio(Txt_Ci) Then
            errordecedula.SetError(Txt_Ci, "ingrese una cedula")
        ElseIf Not solonumeros(Txt_Ci) Then
            errordecedula.SetError(Txt_Ci, "ingrese una cedula valida")
        Else
            errordecedula.Clear()
        End If
    End Sub

    Private Sub Txt_Ci_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Txt_Ci.TextChanged
        If Not sololetras(Txt_nombre) Then
            errordecedula.SetError(Txt_nombre, "ingrese un nombre valido")
        End If
    End Sub

    Private Sub FrmClientes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ToolStrip1_ItemClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles ToolStrip1.ItemClicked

    End Sub

    Private Sub Telefonos1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
End Class