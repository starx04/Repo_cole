Public Class frm_Caratula_Tema3

    Private Sub pic_ichigo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pic_ichigo.Click
        btn_materia.Visible = True
        btn_menu.Visible = True
    End Sub

    Private Sub btn_menu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_menu.Click
        frm_menu.Show()
        Me.Hide()
    End Sub

    Private Sub btn_materia_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_materia.Click
        frm_Tema3.Show()
        Me.Hide()
    End Sub
End Class