Public Class Form1

    Private Sub cbo_operaciones_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbo_operaciones.SelectedIndexChanged
        'Declaracion de variables
        Dim n1, n2, resultado As Single
        'Entrada de datos
        n1 = Val(txt_n1.Text)
        n2 = Val(txt_n2.Text)
        'Proceso
        Select Case cbo_operaciones.SelectedItem
            Case "+"
                resultado = n1 + n2
            Case "-"
                resultado = n1 - n2
            Case "*"
                resultado = n1 * n2
            Case "/"
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
    End Sub

    Private Sub btn_salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_salir.Click
        End
    End Sub

    Private Sub txt_n1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_n1.TextChanged

    End Sub

    Private Sub txt_n2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_n2.TextChanged

    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub txt_resultado_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_resultado.TextChanged

    End Sub
End Class
