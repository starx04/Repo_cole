Public Class frm_operaciones

    Private Sub cbo_operaciones_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbo_operaciones.SelectedIndexChanged
        'Declaracion de variables
        Dim n1, n2, resultado As Single
        'Entrada de datos
        n1 = Val(txt_n1.Text)
        n2 = Val(txt_n2.Text)
        'Proceso
        Select Case cbo_operaciones.SelectedItem
            Case "Suma"
                resultado = n1 + n2
            Case "Resta"
                resultado = n1 - n2
            Case "Multiplicacion"
                resultado = n1 * n2
            Case "Division"
                resultado = n1 / n2
        End Select
        'Salida de datos
        txt_resultado.Text = resultado
    End Sub

    Private Sub btn_limpiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_limpiar.Click
        txt_n1.Clear()
        txt_n2.Clear()
        txt_resultado.Clear()
        cbo_operaciones.SelectedItem = -1
        cbo_operaciones.Text = "Selecciona la operacion"
    End Sub

    Private Sub btn_salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_salir.Click
        End
    End Sub
End Class
