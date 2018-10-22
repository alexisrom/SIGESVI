Module ManejoVentanas

    Public frmPrincipal As FrmPrincipal

    Public Sub AbrirFormulario(ByVal frm As Form)

        If frmPrincipal.PnlContenido.Controls.Count > 0 Then
            frmPrincipal.PnlContenido.Controls.RemoveAt(0)
        End If

        frm.TopLevel = False
        frm.Dock = DockStyle.Fill
        frmPrincipal.PnlContenido.Controls.Add(frm)
        frmPrincipal.PnlContenido.Tag = frm
        frm.Show()
    End Sub

End Module
