Module Validacion
    
    Dim ep As New ErrorProvider()

    Function ValidarCampos(ByVal frm As Form) As Boolean
        Dim camposValidados = True
        ep.Clear()

        For Each ctrl As Control In frm.Controls

            If TypeOf ctrl Is Panel Then
                For Each c In ctrl.Controls
                    If TypeOf c Is TextBox Then
                        If c.Name.Contains("REQ") And String.IsNullOrEmpty(c.Text.Trim()) Then
                            ep.SetError(c, "Campo requerido")
                            camposValidados = False
                        End If

                    ElseIf TypeOf c Is ListBox Then
                        Dim lista = CType(c, ListBox)
                        If c.Name.Contains("REQ") And lista.Items.Count = 0 Then
                            ep.SetError(c, "Agregue elementos a la lista")
                            camposValidados = False
                        End If
                    ElseIf TypeOf c Is ComboBox Then
                        Dim combo = CType(c, ComboBox)
                        If c.Name.Contains("REQ") And combo.SelectedIndex < 0 Then
                            ep.SetError(c, "Seleccione algún elemento")
                            camposValidados = False
                        End If
                    End If
                Next
            End If


            If TypeOf ctrl Is TextBox Then
                If ctrl.Name.Contains("REQ") And String.IsNullOrEmpty(ctrl.Text.Trim()) Then
                    ep.SetError(ctrl, "Campo requerido")
                    camposValidados = False
                End If

            ElseIf TypeOf ctrl Is ListBox Then
                Dim lista = CType(ctrl, ListBox)
                If ctrl.Name.Contains("REQ") And lista.Items.Count = 0 Then
                    ep.SetError(ctrl, "Agregue elementos a la lista")
                    camposValidados = False
                End If
            ElseIf TypeOf ctrl Is ComboBox Then
                Dim combo = CType(ctrl, ComboBox)
                If ctrl.Name.Contains("REQ") And combo.SelectedIndex < 0 Then
                    ep.SetError(ctrl, "Seleccione algún elemento")
                    camposValidados = False
                End If
            End If

        Next

        Return camposValidados

    End Function



    Private Sub CampoNumerico_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Not Char.IsNumber(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Public Sub RestringirCampos(ByVal frm As Form)

        For Each ctrl As Control In frm.Controls

            If TypeOf ctrl Is TextBox And ctrl.Name.Contains("NUM") Then
                AddHandler ctrl.KeyPress, AddressOf CampoNumerico_KeyPress
            End If
        Next

    End Sub

End Module
