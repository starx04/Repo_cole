Public Class frm_crucigrama

    Private Sub btn_comprobar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_comprobar.Click
        If txt_m.Text = "M" And txt_o.Text = "O" And txt_n.Text = "N" And txt_i.Text = "I" And txt_t.Text = "T" And txt_o2.Text = "O" And txt_r.Text = "R" Then
            txt_m.BackColor = Color.Blue
            txt_o.BackColor = Color.Blue
            txt_n.BackColor = Color.Blue
            txt_i.BackColor = Color.Blue
            txt_t.BackColor = Color.Blue
            txt_o2.BackColor = Color.Blue
            txt_r.BackColor = Color.Blue
            chk_monitor.Checked = True
        Else
            txt_m.BackColor = Color.Red
            txt_o.BackColor = Color.Red
            txt_n.BackColor = Color.Red
            txt_i.BackColor = Color.Red
            txt_t.BackColor = Color.Red
            txt_o2.BackColor = Color.Red
            txt_r.BackColor = Color.Red
            chk_monitor.Checked = False
        End If
        If txt_m2.Text = "M" And txt_o2.Text = "O" And txt_u.Text = "U" And txt_s.Text = "S" And txt_e.Text = "E" Then
            txt_m2.BackColor = Color.Blue
            txt_o2.BackColor = Color.Blue
            txt_u.BackColor = Color.Blue
            txt_s.BackColor = Color.Blue
            txt_e.BackColor = Color.Blue
            chk_mouse.Checked = True
        Else
            txt_m2.BackColor = Color.Red
            txt_o2.BackColor = Color.Red
            txt_u.BackColor = Color.Red
            txt_s.BackColor = Color.Red
            txt_e.BackColor = Color.Red
            chk_mouse.Checked = False
        End If
        If txt_c.Text = "C" And txt_p.Text = "P" And txt_u.Text = "U" Then
            txt_c.BackColor = Color.Blue
            txt_p.BackColor = Color.Blue
            txt_u.BackColor = Color.Blue
            chk_cpu.Checked = True
        Else
            txt_c.BackColor = Color.Red
            txt_p.BackColor = Color.Red
            txt_u.BackColor = Color.Red
            chk_cpu.Checked = False
        End If
        If txt_t2.Text = "T" And txt_e.Text = "E" And txt_c2.Text = "C" And txt_l.Text = "L" And txt_a.Text = "A" And txt_d.Text = "D" And txt_o3.Text = "O" Then
            txt_t2.BackColor = Color.Blue
            txt_e.BackColor = Color.Blue
            txt_c2.BackColor = Color.Blue
            txt_l.BackColor = Color.Blue
            txt_a.BackColor = Color.Blue
            txt_d.BackColor = Color.Blue
            txt_o3.BackColor = Color.Blue
            chk_teclado.Checked = True
        Else
            txt_t2.BackColor = Color.Red
            txt_e.BackColor = Color.Red
            txt_c2.BackColor = Color.Red
            txt_l.BackColor = Color.Red
            txt_a.BackColor = Color.Red
            txt_d.BackColor = Color.Red
            txt_o3.BackColor = Color.Red
            chk_teclado.Checked = False
        End If
    End Sub

    Private Sub btn_limpiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_limpiar.Click
        txt_m.Clear()
        txt_o.Clear()
        txt_n.Clear()
        txt_i.Clear()
        txt_t.Clear()
        txt_o2.Clear()
        txt_r.Clear()
        txt_m2.Clear()
        txt_u.Clear()
        txt_s.Clear()
        txt_e.Clear()
        txt_c.Clear()
        txt_p.Clear()
        txt_u.Clear()
        txt_t2.Clear()
        txt_c2.Clear()
        txt_l.Clear()
        txt_a.Clear()
        txt_d.Clear()
        txt_o3.Clear()
        chk_cpu.Checked = False
        chk_monitor.Checked = False
        chk_mouse.Checked = False
        chk_teclado.Checked = False
        txt_m.BackColor = Color.Black
        txt_o.BackColor = Color.Black
        txt_n.BackColor = Color.Black
        txt_i.BackColor = Color.Black
        txt_t.BackColor = Color.Black
        txt_o2.BackColor = Color.Black
        txt_r.BackColor = Color.Black
        txt_m2.BackColor = Color.Black
        txt_u.BackColor = Color.Black
        txt_s.BackColor = Color.Black
        txt_e.BackColor = Color.Black
        txt_c.BackColor = Color.Black
        txt_p.BackColor = Color.Black
        txt_u.BackColor = Color.Black
        txt_t2.BackColor = Color.Black
        txt_c2.BackColor = Color.Black
        txt_l.BackColor = Color.Black
        txt_a.BackColor = Color.Black
        txt_d.BackColor = Color.Black
        txt_o3.BackColor = Color.Black
    End Sub

    Private Sub btn_salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_salir.Click
        End
    End Sub
End Class
