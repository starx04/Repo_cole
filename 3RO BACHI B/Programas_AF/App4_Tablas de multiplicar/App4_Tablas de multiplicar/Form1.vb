Public Class Form1
    Dim num, resultado As Integer
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        ListBox1.ClearSelected()
        num = Val(TextBox1.Text)
        For a = 1 To 12
            ListBox1.Items.Add(num & "*" & a & "=" & TextBox1.Text * a)
        Next
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        TextBox1.Text = ""
        ListBox1.Items.Clear()

    End Sub
End Class
