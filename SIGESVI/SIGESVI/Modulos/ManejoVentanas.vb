Module ManejoVentanas

    Public frmPrincipal As FrmPrincipal



    Public Sub AbrirFormulario(ByVal frm As Form)
        AbrirFormulario(frm, Nothing)
    End Sub

    Public Sub AbrirFormulario(ByVal frm As Form, ByVal sender As Object)


        If Not sender Is Nothing Then
            SeleccionarItem(sender)
        End If


        If frmPrincipal.PnlContenido.Controls.Count > 0 Then
            frmPrincipal.PnlContenido.Controls.RemoveAt(0)
        End If



        frm.TopLevel = False
        frm.Dock = DockStyle.Fill

        frmPrincipal.PnlContenido.Controls.Add(frm)
        frmPrincipal.PnlContenido.Tag = frm

        frm.Show()


    End Sub

    Private Sub SeleccionarItem(ByVal sender As Button)
        Dim ctrl = frmPrincipal.Controls.Find("PnlMenu", True)
        Dim panel = CType(ctrl(0), Panel)

        For Each item As Control In panel.Controls

            If item.Name.Equals(sender.Name) Then
                item.BackColor = Color.FromArgb(95, 39, 205)
            Else
                item.BackColor = Color.FromArgb(52, 31, 151)
            End If
        Next

    End Sub

End Module
