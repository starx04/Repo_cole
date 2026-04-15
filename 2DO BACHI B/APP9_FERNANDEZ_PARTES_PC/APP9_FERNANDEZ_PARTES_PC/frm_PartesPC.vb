Public Class frm_PartesPC

    Private Sub lbl_monitor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbl_monitor.Click
        lbl_partes.Text = "Monitor"
    End Sub

    Private Sub lbl_teclado_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbl_teclado.Click
        lbl_partes.Text = "Teclado"
    End Sub

    Private Sub lbl_cpu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbl_cpu.Click
        lbl_partes.Text = "CPU"
    End Sub

    Private Sub lbl_mouse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbl_mouse.Click
        lbl_partes.Text = "Mouse"
    End Sub

    Private Sub pic_evaluacion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pic_evaluacion.Click
        frm_evaluacion.Show()
        Me.Hide()
    End Sub
End Class
