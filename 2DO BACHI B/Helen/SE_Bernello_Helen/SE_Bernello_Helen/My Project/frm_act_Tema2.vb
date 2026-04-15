Public Class frm_act_Tema2

    Private Sub btn_regresar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_regresar.Click
        frm_Caratula_Tema2.Show()
        Me.Hide()
    End Sub

    Private Sub btn_menu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_menu.Click
        frm_menu.Show()
        Me.Hide()
    End Sub

    Private Sub btn_verificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_verificar.Click
        If txt_1.Text = "1" And txt_2.Text = "2" And txt_3.Text = "3" Then
            txt_1.BackColor = Color.Aqua
            txt_2.BackColor = Color.Aqua
            txt_3.BackColor = Color.Aqua
            chk_1.Checked = True
        Else
            txt_1.BackColor = Color.Red
            txt_2.BackColor = Color.Red
            txt_3.BackColor = Color.Red
            chk_1.Checked = False
        End If
        If txt_1.Text = "1" And txt_1_1.Text = "1" Then
            txt_1.BackColor = Color.Aqua
            txt_1_1.BackColor = Color.Aqua
            chk_2.Checked = True
        Else
            txt_1.BackColor = Color.Red
            txt_1_1.BackColor = Color.Red
            chk_2.Checked = False
        End If
        If txt_2.Text = "2" And txt_9.Text = "9" And txt_1_2.Text = "1" Then
            txt_2.BackColor = Color.Aqua
            txt_9.BackColor = Color.Aqua
            txt_1_2.BackColor = Color.Aqua
            chk_3.Checked = True
        Else
            txt_2.BackColor = Color.Red
            txt_9.BackColor = Color.Red
            txt_1_2.BackColor = Color.Red
            chk_3.Checked = False
        End If
        If txt_1_2.Text = "1" And txt_2_1.Text = "2" And txt_5.Text = "5" Then
            txt_1_2.BackColor = Color.Aqua
            txt_2_1.BackColor = Color.Aqua
            txt_5.BackColor = Color.Aqua
            chk_4.Checked = True
        Else
            txt_1_2.BackColor = Color.Red
            txt_2_1.BackColor = Color.Red
            txt_5.BackColor = Color.Red
            chk_4.Checked = False
        End If
        If txt_5.Text = "5" And txt_3_1.Text = "3" Then
            txt_5.BackColor = Color.Aqua
            txt_3_1.BackColor = Color.Aqua
            chk_5.Checked = True
        Else
            txt_5.BackColor = Color.Red
            txt_3_1.BackColor = Color.Red
            chk_5.Checked = False
        End If
        If chk_1.Checked = True And chk_2.Checked = True And chk_3.Checked = True And chk_4.Checked = True And chk_5.Checked = True Then
            MsgBox("Buen trabajo lo conseguiste")
            btn_menu.Visible = True
            btn_regresar.Visible = True
        Else
            MsgBox("Sigue esforzandote que de seguro lo logras")
        End If

    End Sub

    Private Sub btn_limpiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_limpiar.Click
        txt_1.Clear()
        txt_1_1.Clear()
        txt_1_2.Clear()
        txt_2.Clear()
        txt_2_1.Clear()
        txt_3.Clear()
        txt_3_1.Clear()
        txt_5.Clear()
        txt_9.Clear()
        chk_1.Checked = False
        chk_2.Checked = False
        chk_3.Checked = False
        chk_4.Checked = False
        chk_5.Checked = False
        txt_1.BackColor = Color.Black
        txt_1_1.BackColor = Color.Black
        txt_1_2.BackColor = Color.Black
        txt_2.BackColor = Color.Black
        txt_2_1.BackColor = Color.Black
        txt_3.BackColor = Color.Black
        txt_3_1.BackColor = Color.Black
        txt_5.BackColor = Color.Black
        txt_9.BackColor = Color.Black
    End Sub

    Private Sub frm_act_Tema2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        btn_menu.Visible = False
        btn_regresar.Visible = False
    End Sub
End Class