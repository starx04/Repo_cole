Public Class frm_recuperacion

    Private Sub btn_calcular_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_calcular.Click
        Dim dia, costo, total As Single
        dia = nud_dia.Value
        Select Case nud_enfermedad.Value
            Case 1
                costo = 25
            Case 2
                costo = 16
            Case 3
                costo = 20
            Case 4
                costo = 32
            Case Else
                MsgBox("Ingrese el tipo de enfermedad", MsgBoxStyle.Exclamation, "Enfermedad")
        End Select
        total = dia * costo
        txt_total.Text = total
    End Sub

    Private Sub btn_limpiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_limpiar.Click
        txt_paciente.Clear()
        txt_total.Clear()
        nud_dia.Text = 0
        nud_enfermedad.Text = 0
    End Sub

    Private Sub btn_salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_salir.Click
        End
    End Sub
End Class
