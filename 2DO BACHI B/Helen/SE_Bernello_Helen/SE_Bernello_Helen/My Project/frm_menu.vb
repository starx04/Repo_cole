Public Class frm_menu

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_tema1.Click
        frm_Caratula_Tema1.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_tema2.Click
        frm_Caratula_Tema2.Show()
        Me.Hide()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_tema3.Click
        frm_Caratula_Tema3.Show()
        Me.Hide()
    End Sub
    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_tema5.Click
        frm_Caratula_Tema5.Show()
        Me.Hide()
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_tema4.Click
        frm_Caratula_Tema4.Show()
        Me.Hide()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_salir.Click
        End
    End Sub

    Private Sub PictureBox4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox4.Click
        btn_salir.Visible = True
        btn_tema1.Visible = True
        btn_tema2.Visible = True
        btn_tema3.Visible = True
        btn_tema4.Visible = True
        btn_tema5.Visible = True
    End Sub
End Class