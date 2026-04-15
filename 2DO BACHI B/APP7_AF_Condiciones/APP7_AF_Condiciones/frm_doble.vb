Public Class frm_doble

    Private Sub btn_mensaje_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_mensaje.Click
        Dim edad As Byte
        edad = nud_edad.Value
        'Estructura condicional
        If edad >= 18 Then
            'Instrucciones por verdadero
            MsgBox("Es mayor de edad")
            'caso contrario
        Else
            'Instrucciones por falso
            MsgBox("Es menor de edad")
        End If
    End Sub

    Private Sub btn_menu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_menu.Click
        frm_menu.Show()
        Me.Hide()
    End Sub

    Private Sub frm_doble_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
