Public Class frm_act_Tema4
    Private puntos As Single
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        frm_Caratula_Tema4.Show()
        Me.Hide()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        End
    End Sub

    Private Sub btn_comprobar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_comprobar.Click
        If cbo_1.SelectedItem = "Verdadero" Then
            pic_1.BackColor = Color.Blue
            puntos = puntos + 1
        ElseIf cbo_1.SelectedItem = "Falso" Then
            pic_1.BackColor = Color.Red
        End If
        If cbo_2.SelectedItem = "Verdadero" Then
            pic_2.BackColor = Color.Blue
            puntos = puntos + 1
        ElseIf cbo_2.SelectedItem = "Falso" Then
            pic_2.BackColor = Color.Red
        End If
        If cbo_3.SelectedItem = "Verdadero" Then
            pic_3.BackColor = Color.Blue
            puntos = puntos + 1
        ElseIf cbo_3.SelectedItem = "Falso" Then
            cbo_3.BackColor = Color.Red
        End If
        If cbo_4.SelectedItem = "Verdadero" Then
            pic_4.BackColor = Color.Blue
            puntos = puntos + 1
        ElseIf cbo_4.SelectedItem = "Falso" Then
            pic_4.BackColor = Color.Red
        End If
        If puntos = 4 Then
            MsgBox("Buen trabajo lo conseguiste has completado todo la actividad con exito")
            Button3.Visible = True
            Button1.Visible = True
        Else
            MsgBox("Sigue esforzandote lo conseguiras")
        End If
    End Sub

    Private Sub frm_act_Tema4_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Button3.Visible = False
        Button1.Visible = False
    End Sub

    Private Sub btn_limpiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_limpiar.Click
        cbo_1.SelectedIndex = -1
        cbo_2.SelectedIndex = -1
        cbo_3.SelectedIndex = -1
        cbo_4.SelectedIndex = -1
        pic_1.BackColor = Color.White
        pic_2.BackColor = Color.White
        pic_3.BackColor = Color.White
        pic_4.BackColor = Color.White
    End Sub
End Class