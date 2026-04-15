Public Class Form1

    Private Sub btn_presentar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_presentar.Click
        Dim num1, num2, num3 As Byte
        num1 = nud_n1.Value
        num2 = nud_n2.Value
        num3 = nud_n3.Value
        If num1 > num2 And num1 > num3 Then
            txt_mayor.Text = num1
        ElseIf num2 > num3 Then
            txt_mayor.Text = num2
        Else
            txt_mayor.Text = num3
        End If
        If num1 < num2 And num1 < num3 Then
            txt_menor.Text = num1
        ElseIf num2 < num3 Then
            txt_menor.Text = num2
        Else
            txt_menor.Text = num3
        End If
    End Sub
End Class
