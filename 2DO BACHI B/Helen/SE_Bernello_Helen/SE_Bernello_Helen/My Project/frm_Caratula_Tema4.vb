Public Class frm_Caratula_Tema4

    Private Sub btn_materia_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_materia.Click
        frm_Tema4.Show()
        Me.Hide()
    End Sub

    Private Sub btn_menu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_menu.Click
        frm_menu.Show()
        Me.Hide()
    End Sub

    Private Sub pic_ichigo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pic_ichigo.Click
        btn_materia.Visible = True
        btn_menu.Visible = True
    End Sub
End Class