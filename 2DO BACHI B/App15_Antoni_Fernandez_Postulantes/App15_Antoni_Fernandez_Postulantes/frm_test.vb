Public Class frm_test

    Private Sub btn_calcular_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_calcular.Click
        'Declaracion
        Dim preg, resp, porcentaje As Single
        'Ingreso de Datos
        preg = nud_cantPreg.Value
        resp = nud_cantResp.Value
        If txt_postulante.Text = "" Or nud_cantPreg.Value = 0 Or nud_cantResp.Value = 0 Then
            MsgBox("Debe de ingresar todos los datos para continuar", MsgBoxStyle.Critical, "Advertencia")
        Else
            'Proceso
            porcentaje = (resp * 100) / preg
            'Salida de Datos
            txt_porcentaje.Text = porcentaje & " %"
            If porcentaje <= 90 Then
                txt_mensaje.Text = "NIVEL MAXIMO"
            ElseIf porcentaje >= 75 And porcentaje < 90 Then
                txt_mensaje.Text = "NIVEL MEDIO"
            ElseIf porcentaje >= 50 And porcentaje < 75 Then
                txt_mensaje.Text = "NIVEL REGULAR"
            Else
                txt_mensaje.Text = "FUERA DE NIVEL"
            End If
        End If
    End Sub

    Private Sub btn_nuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_nuevo.Click
        txt_mensaje.Clear()
        txt_porcentaje.Clear()
        txt_postulante.Clear()
        nud_cantPreg.Value = 0
        nud_cantResp.Value = 0
    End Sub

    Private Sub btn_salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_salir.Click
        End
    End Sub
End Class
