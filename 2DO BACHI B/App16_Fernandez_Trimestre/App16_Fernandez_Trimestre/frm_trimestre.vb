Public Class frm_trimestre

    Private Sub btn_comprobar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_comprobar.Click
        If nud_mes.Value = 1 Or nud_mes.Value = 2 Or nud_mes.Value = 3 Then
            MsgBox("El mes ingresado corresponde al 1er trimestre", MsgBoxStyle.Information, "Trimestre")
        ElseIf nud_mes.Value = 4 Or nud_mes.Value = 5 Or nud_mes.Value = 6 Then
            MsgBox("El mes ingresado corresponde al 2do trimestre", MsgBoxStyle.Information, "Trimestre")
        ElseIf nud_mes.Value = 7 Or nud_mes.Value = 8 Or nud_mes.Value = 9 Then
            MsgBox("El mes ingresado corresponde al 3er trimestre", MsgBoxStyle.Information, "Trimestre")
        ElseIf nud_mes.Value = 10 Or nud_mes.Value = 11 Or nud_mes.Value = 12 Then
            MsgBox("El mes ingresado corresponde al 4to trimestre", MsgBoxStyle.Information, "Trimestre")
        Else
            MsgBox("Ingrese un mes para poder calcular el numero de trimestre", MsgBoxStyle.Exclamation, "Trimestre")
        End If
    End Sub

    Private Sub btn_salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_salir.Click
        End
    End Sub

    Private Sub btn_limpiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_limpiar.Click
        nud_anio.Text = 1900
        nud_dia.Text = 0
        nud_mes.Text = 0
    End Sub
End Class
