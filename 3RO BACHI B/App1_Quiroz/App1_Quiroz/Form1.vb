Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        End
    End Sub

    Private Sub rbd_1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbd_1.CheckedChanged
        If rbd_1.Checked = True Then
            txt_1.Font = New Font("arial", 16, FontStyle.Bold)
        End If
    End Sub

    Private Sub rbd_2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbd_2.CheckedChanged
        If rbd_2.Checked = True Then
            txt_1.Font = New Font("Pristina", 16)
        End If
    End Sub

    Private Sub rbd_3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbd_3.CheckedChanged
        If rbd_3.Checked = True Then
            txt_1.CharacterCasing = CharacterCasing.Lower
            txt_1.Font = New Font("arial", 16)
        End If
    End Sub

    Private Sub rdb_4_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdb_4.CheckedChanged
        If rdb_4.Checked = True Then
            txt_1.CharacterCasing = CharacterCasing.Upper
            txt_1.Font = New Font("arial", 16)
        End If
    End Sub

    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged
        If RadioButton1.Checked = True Then
            txt_1.Font = New Font("arial", 16, FontStyle.Underline)
        End If
    End Sub
End Class
