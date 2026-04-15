Public Class frm_act_Tema5
    Private puntos As Single

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        frm_Caratula_Tema5.Show()
        Me.Hide()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        End
    End Sub

    Private Sub btn_comprobar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_comprobar.Click
        If cbo_1.SelectedItem = "4 ANGULOS" Then
            pic_1.BackColor = Color.Blue
            puntos = puntos + 1
        Else
            pic_1.BackColor = Color.Red
        End If
        If cbo_2.SelectedItem = "90°" Then
            pic_2.BackColor = Color.Blue
            puntos = puntos + 1
        Else
            pic_2.BackColor = Color.Red
        End If
        If cbo_3.SelectedItem = "NO" Then
            pic_3.BackColor = Color.Blue
            puntos = puntos + 1
        Else
            pic_3.BackColor = Color.Red
        End If
        If cbo_4.SelectedItem = "Poseen la misma inclinacion" Then
            pic_4.BackColor = Color.Blue
            puntos = puntos + 1
        Else
            pic_4.BackColor = Color.Red
        End If
        If puntos = 4 Then
            MsgBox("Buen trabajo lo conseguiste has completado todo la actividad con exito")
            Button3.Visible = True
            Button1.Visible = True
        Else
            MsgBox("Buen trabajo lo conseguiste te esforzaste pero te falto un poco haci que sigue esforzandote")
        End If
    End Sub

    Private Sub frm_act_Tema5_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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