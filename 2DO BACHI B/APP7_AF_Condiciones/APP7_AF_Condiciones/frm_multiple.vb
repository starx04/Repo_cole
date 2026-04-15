Public Class frm_multiple

    Private Sub btn_menu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_menu.Click
        frm_menu.Show()
        Me.Hide()
    End Sub

    Private Sub btn_mensaje_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_mensaje.Click
        Dim edad As Byte
        edad = nud_edad.Value
        'Estructura condicional multiple
        If edad >= 65 Then
            'Instrucciones por verdadero
            MsgBox("Adulto mayor")
            'Instruccion por falso
        ElseIf edad >= 18 Then
            'Instruccion por verdadero
            MsgBox("Es adulto")
        Else
            'Instruccion por falso
            MsgBox("Es menor de edad")
        End If
    End Sub

End Class