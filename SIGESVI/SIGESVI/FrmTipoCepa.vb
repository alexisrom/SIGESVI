﻿Public Class FrmTipoCepa
    Private persistencia As PersistenciaTipoCepa
    
   
    Private Sub FrmTipoCepa_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        persistencia = New PersistenciaTipoCepa
        ValidarControles(Me)
        ControlesPorDefecto()
    End Sub

    Private Sub ControlesPorDefecto()
        LimpiarControles(Me)
        TxtNombre_REQ.Focus()
        DgvEtapas.DataSource = persistencia.ListarTodas
    End Sub

    Private Sub BtnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAgregar.Click

        If ValidarCampos(Me) Then
            Dim cepa As New TipoCepa()
            cepa.Nombre = TxtNombre_REQ.Text
            cepa.Tipo = CboTipoCepa_REQ.SelectedItem.ToString
            Try
                persistencia.Agregar(cepa)
                MessageBox.Show("Cepa agregada exitosamente")
                ControlesPorDefecto()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If

    End Sub

End Class