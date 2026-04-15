Public Class frm_simple

    Private Sub btn_menu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_menu.Click
        frm_menu.Show()
        Me.Hide()
    End Sub

    Private Sub btn_mensaje_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_mensaje.Click
        Dim edad As Byte
        edad = nud_edad.Value
        If edad >= 18 Then
            'Instruccion por verdadero
            MsgBox("Es mayor de edad")
        End If
    End Sub
End Class