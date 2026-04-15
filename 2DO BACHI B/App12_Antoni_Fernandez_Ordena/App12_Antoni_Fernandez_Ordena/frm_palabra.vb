Public Class frm_palabra

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If lbl_titulo.ForeColor = Color.White Then
            lbl_titulo.ForeColor = Color.Blue
        ElseIf lbl_titulo.ForeColor = Color.Black Then
            lbl_titulo.ForeColor = Color.Red
        Else
            lbl_titulo.ForeColor = Color.White
        End If
    End Sub

    Private Sub btn_comprobar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_comprobar.Click
        If txt_b.Text = "b" And txt_o.Text = "o" And txt_c.Text = "c" And txt_a.Text = "a" Then
            frm_bien.Show()
            btn_siguiente.Visible = True
        Else
            frm_mal.Show()
            txt_a.Clear()
            txt_b.Clear()
            txt_c.Clear()
            txt_o.Clear()
        End If
    End Sub

    Private Sub frm_palabra_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        btn_siguiente.Visible = False
    End Sub

    Private Sub btn_siguiente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_siguiente.Click
        frm_ordena_palabras.Show()
        Me.Hide()
    End Sub
End Class
