Public Class frm_menu

    Private Sub btn_doble_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_doble.Click
        frm_doble.Show()
        Me.Hide()
    End Sub

    Private Sub btn_simple_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_simple.Click
        frm_simple.Show()
        Me.Hide()
    End Sub

    Private Sub btn_multiple_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_multiple.Click
        frm_multiple.Show()
        Me.Hide()
    End Sub

    Private Sub btn_salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_salir.Click
        End
    End Sub
End Class