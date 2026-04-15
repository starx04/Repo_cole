Public Class frm_evaluacion

    Private Sub btn_calificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_calificar.Click
        Dim puntos As Single
        If txt_monitor.Text = "MONITOR" Then
            puntos = puntos + 2.5
            pic_r1.Image = My.Resources.Visto
        Else
            pic_r1.Image = My.Resources.X
        End If
        If txt_cpu.Text = "CPU" Then
            puntos = puntos + 2.5
            pic_r2.Image = My.Resources.Visto
        Else
            pic_r2.Image = My.Resources.X
        End If
        If txt_teclado.Text = "TECLADO" Then
            puntos = puntos + 2.5
            pic_r3.Image = My.Resources.Visto
        Else
            pic_r3.Image = My.Resources.X
        End If
        If txt_mouse.Text = "MOUSE" Then
            puntos = puntos + 2.5
            pic_r4.Image = My.Resources.Visto
        Else
            pic_r4.Image = My.Resources.X
        End If
        lbl_puntos.Text = puntos
        txt_cpu.Enabled = False
        txt_monitor.Enabled = False
        txt_mouse.Enabled = False
        txt_teclado.Enabled = False
    End Sub

    Private Sub btn_regresar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_regresar.Click
        frm_PartesPC.Show()
        Me.Hide()
    End Sub

    Private Sub btn_salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_salir.Click
        End
    End Sub

    Private Sub btn_limpiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_limpiar.Click
        txt_cpu.Enabled = True
        txt_monitor.Enabled = True
        txt_mouse.Enabled = True
        txt_teclado.Enabled = True
        txt_cpu.Clear()
        txt_monitor.Clear()
        txt_mouse.Clear()
        txt_teclado.Clear()
        lbl_puntos.Text = ""
        pic_r1.Image = Nothing
        pic_r2.Image = Nothing
        pic_r3.Image = Nothing
        pic_r4.Image = Nothing
    End Sub

End Class