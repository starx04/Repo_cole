Public Class frm_refuerzo

    Private Sub btn_comprobar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_calcular.Click
        Dim horas, pago, bono, parcial, total As Single
        'Entrada de Datos
        horas = Val(txt_hora.Text)
        pago = Val(txt_hora.Text)
        Select Case cbo_antiguedad.SelectedItem
            Case "1 - 10 años"
                bono = 10
            Case "11 - 20 años"
                bono = 20
            Case "21 - 30 años"
                bono = 30
            Case "31 - 40 años"
                bono = 40
            Case "Mayor a 40"
                bono = 50
            Case Else
                MsgBox("Debe de seleccionar la antiguedad", MsgBoxStyle.Exclamation, "Sueldo Trabajadores")
        End Select
        parcial = horas * pago
        total = parcial + bono
        'Salida de Datos
        txt_SParcial.Text = parcial
        txt_STotal.Text = total
        txt_bono.Text = bono
    End Sub

    Private Sub btn_limpiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_limpiar.Click
        txt_bono.Clear()
        txt_hora.Clear()
        txt_pago.Clear()
        txt_SParcial.Clear()
        txt_STotal.Clear()
        txt_trabajador.Clear()
        cbo_antiguedad.SelectedIndex = -1
    End Sub

    Private Sub btn_salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_salir.Click
        End
    End Sub
End Class
