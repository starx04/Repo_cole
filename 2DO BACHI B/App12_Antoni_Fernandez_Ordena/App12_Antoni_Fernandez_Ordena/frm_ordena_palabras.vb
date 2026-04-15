Public Class frm_ordena_palabras

    Private Sub btn_salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_salir.Click
        End
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If cbo_1.SelectedItem = "LOS" And cbo_2.SelectedItem = "NIÑOS" And cbo_3.SelectedItem = "COMEN" Then
            frm_bien.Show()
            btn_salir.Visible = True
        Else
            frm_mal.Show()
            cbo_1.SelectedIndex = -1
            cbo_2.SelectedIndex = -1
            cbo_3.SelectedIndex = -1
        End If
    End Sub

    Private Sub frm_ordena_palabras_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        btn_salir.Visible = False
    End Sub
End Class