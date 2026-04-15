Public Class frm_ingreso

    
    Private Sub btn_salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_salir.Click
        End
    End Sub

    Private Sub btn_ingreso_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_ingreso.Click
        If txt_usuario.Text = "UELD" And txt_clave.Text = "123" Then
            MsgBox("Bienvenido " + txt_usuario.Text)
        Else
            MsgBox("Usuario y/o clave incorrecta")
            txt_clave.Clear()
            txt_usuario.Clear()
        End If
    End Sub
End Class
