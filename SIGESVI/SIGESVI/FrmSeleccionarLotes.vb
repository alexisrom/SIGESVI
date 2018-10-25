Public Class FrmSeleccionarLotes

    Private Sub BtnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEliminar.Click

        If DgvLotes.SelectedRows.Count > 0 Then
            Dim frm
            Dim lstLotes As ListBox

            If TypeOf Owner Is FrmVentas Then
                frm = CType(Owner, FrmVentas)
                lstLotes = CType(Owner, FrmVentas).LstLotes
            Else
                frm = CType(Owner, FrmTraslados)
                lstLotes = CType(Owner, FrmTraslados).LstLotes
            End If

            Dim lote = CType(DgvLotes.SelectedRows(0).DataBoundItem, Lote)

            For Each item In lstLotes.Items

                If CType(item, Lote).ID = lote.ID Then
                    MessageBox.Show("El lote ya fue agregado a la lista")
                    Return
                End If

            Next

            If TypeOf Owner Is FrmVentas Then
                CType(Owner, FrmVentas).LstLotes.Items.Add(lote)
            Else
                CType(Owner, FrmTraslados).LstLotes.Items.Add(lote)
            End If
            Me.Close()
        End If

    End Sub

    Private Sub FrmSeleccionarLotes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim lotes = New PersistenciaLote().Listar
        lotes.Sort(Function(x, y) x.ID.CompareTo(y.ID))
        DgvLotes.DataSource = lotes
    End Sub
End Class