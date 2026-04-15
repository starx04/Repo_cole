Public Class frm_semana

    Private Sub btn_presentar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_presentar.Click
        Dim dia As Byte
        dia = nud_dia.Value
        Select Case dia
            Case 1
                txt_mensaje.Text = "Es lunes un nuevo comienzo"
            Case 2
                txt_mensaje.Text = "Es martes la diciplina es gloria"
            Case 3
                txt_mensaje.Text = "Es miercoles la victoria te espera"
            Case 4
                txt_mensaje.Text = "Es jueves disfruta de la vida"
            Case 5
                txt_mensaje.Text = "Es viernes la derrota no es una opcion"
            Case 6
                txt_mensaje.Text = "Es sabado el inicio de un amanecer"
            Case 6
                txt_mensaje.Text = "Es domingo reposa tu mente"
            Case Else
                MsgBox("Debes de seleccionar un numero", MsgBoxStyle.Information, "ERROR")
        End Select
    End Sub

    Private Sub btn_limpiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_limpiar.Click
        nud_dia.Value = 0
        txt_mensaje.Clear()
    End Sub

    Private Sub btn_salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_salir.Click
        End
    End Sub
End Class
