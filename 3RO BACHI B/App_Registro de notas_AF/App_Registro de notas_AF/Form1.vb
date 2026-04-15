Public Class Form1
    Dim porcentaje1, porcentaje2, porcentaje3, porcentaje4, n1, n2, n3, n4 As Single
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        n1 = Val(txt_in.Text)
        n2 = Val(txt_pra.Text)
        n3 = Val(txt_pro.Text)
        n4 = Val(txt_ex.Text)


        porcentaje1 = ((n1 * 10) / 100)
        txt_10.Text = porcentaje1
        porcentaje2 = ((n3 * 20) / 100)
        txt_20.Text = porcentaje2
        porcentaje3 = ((n2 * 40) / 100)
        txt_40.Text = porcentaje3
        porcentaje4 = ((n4 * 30) / 100)
        txt_30.Text = porcentaje4

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        End
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        txt_10.Clear()
        txt_20.Clear()
        txt_30.Clear()
        txt_40.Clear()
        txt_in.Clear()
        txt_pra.Clear()
        txt_pro.Clear()
        txt_ex.Clear()
        txt_jornada.Clear()
        txt_nombre.Clear()

    End Sub
End Class
