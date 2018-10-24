Module Utilidades
    Public ubicacion As String = "Montevideo"

    Function ListarDepartamentos() As List(Of String)
        Dim departamentos As New List(Of String)
        departamentos.Add("Artigas")
        departamentos.Add("Canelones")
        departamentos.Add("Cerro Largo")
        departamentos.Add("Colonia")
        departamentos.Add("Durazno")
        departamentos.Add("Flores")
        departamentos.Add("Florida")
        departamentos.Add("Lavalleja")
        departamentos.Add("Maldonado")
        departamentos.Add("Montevideo")
        departamentos.Add("Paysandú")
        departamentos.Add("Río Negro")
        departamentos.Add("Rivera")
        departamentos.Add("Rocha")
        departamentos.Add("Salto")
        departamentos.Add("San José")
        departamentos.Add("Soriano")
        departamentos.Add("Tacuarembó")
        departamentos.Add("Treinta y Tres")
        Return departamentos
    End Function


    Sub LimpiarControles(ByRef form As Form)
        For Each control As Control In form.Controls

            If TypeOf control Is Panel Then
                For Each c In control.Controls
                    If TypeOf c Is TextBox Then
                        c.Text = ""
                    ElseIf TypeOf c Is ListBox Then
                        Dim listbox = CType(c, ListBox)
                        listbox.DataSource = Nothing
                        listbox.Items.Clear()
                    ElseIf TypeOf c Is ComboBox Then
                        Dim combobox = CType(c, ComboBox)
                        If combobox.Items.Count > 0 Then
                            combobox.SelectedIndex = 0
                        End If
                    End If
                Next
            End If

            If TypeOf control Is TextBox Then
                control.Text = ""
            ElseIf TypeOf control Is ListBox Then
                Dim listbox = CType(control, ListBox)
                listbox.Items.Clear()
            ElseIf TypeOf control Is ComboBox Then
                Dim combobox = CType(control, ComboBox)
                If combobox.Items.Count > 0 Then
                    combobox.SelectedIndex = 0
                End If
            End If
        Next
    End Sub


    Function FormatearFecha(ByVal fecha As Date) As String
        Return String.Format("{0}-{1}-{2}", fecha.Day, fecha.Month, fecha.Year)
    End Function

    Function FormatearFechaHora(ByVal fecha As Date) As String
        Return String.Format("{0}-{1}-{2} {3}:{4}", fecha.Year, fecha.Month, fecha.Day, fecha.Hour, fecha.Minute)
    End Function
End Module
