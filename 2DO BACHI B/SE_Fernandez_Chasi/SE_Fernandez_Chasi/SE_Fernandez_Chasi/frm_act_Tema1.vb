Public Class frm_act_Tema1
    Private puntos As Single

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_regresar.Click
        frm_Caratula_Tema1.Show()
        Me.Hide()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_menu.Click
        frm_menu.Show()
        Me.Hide()
    End Sub

    Private Sub btn_comprobar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_comprobar.Click
        If cbo_1.SelectedItem = "155" Then
            pic_r1.Image = My.Resources.Visto
            puntos = puntos + 1
        Else
            pic_r1.Image = My.Resources.X
        End If
        If cbo_2.SelectedItem = "180" Then
            pic_r2.Image = My.Resources.Visto
            puntos = puntos + 1
        Else
            pic_r2.Image = My.Resources.X
        End If
        If cbo_3.SelectedItem = "200" Then
            pic_r3.Image = My.Resources.Visto
            puntos = puntos + 1
        Else
            pic_r3.Image = My.Resources.X
        End If
        If cbo_4.SelectedItem = "360" Then
            pic_r4.Image = My.Resources.Visto
            puntos = puntos + 1
        Else
            pic_r4.Image = My.Resources.X
        End If
        If cbo_5.SelectedItem = "735" Then
            pic_r5.Image = My.Resources.Visto
            puntos = puntos + 1
        Else
            pic_r5.Image = My.Resources.X
        End If
        If puntos = 5 Then
            MsgBox("Buen trabajo lo conseguiste")
            btn_menu.Visible = True
            btn_regresar.Visible = True
        Else
            MsgBox("Sigue esforzandote que de seguro lo logras")
        End If
    End Sub

    Private Sub frm_act_Tema1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        btn_menu.Visible = False
        btn_regresar.Visible = False
    End Sub

    Private Sub btn_limpiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_limpiar.Click
        pic_r1.Image = Nothing
        pic_r2.Image = Nothing
        pic_r3.Image = Nothing
        pic_r4.Image = Nothing
        pic_r5.Image = Nothing
        cbo_1.Enabled = True
        cbo_2.Enabled = True
        cbo_3.Enabled = True
        cbo_4.Enabled = True
        cbo_5.Enabled = True
        cbo_1.SelectedIndex = -1
        cbo_2.SelectedIndex = -1
        cbo_3.SelectedIndex = -1
        cbo_4.SelectedIndex = -1
        cbo_5.SelectedIndex = -1
    End Sub
End Class