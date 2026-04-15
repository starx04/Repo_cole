Public Class PANTALONES
    Dim c1, c2, c3, c4, c5, c6, c7, c8, c9, c10, p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, n1, n2, n3, n4, n5, n6, n7, n8, n9, n10, total As Single

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        Select Case CheckBox1.Checked
            Case True
                NumericUpDown1.Visible = True
                p1 = 15
        End Select
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        total = c1 + c2 + c3 + c4 + c5 + c6 + c7 + c8 + c9 + c10
        lbl_total.Text = total
    End Sub

    Private Sub NumericUpDown1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NumericUpDown1.ValueChanged
        n1 = NumericUpDown1.Value
        c1 = p1 * n1
    End Sub

    Private Sub NumericUpDown2_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NumericUpDown2.ValueChanged
        n2 = NumericUpDown2.Value
        c2 = p2 * n2
    End Sub

    Private Sub NumericUpDown3_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NumericUpDown3.ValueChanged
        n3 = NumericUpDown3.Value
        c3 = p3 * n3
    End Sub

    Private Sub NumericUpDown4_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NumericUpDown4.ValueChanged
        n4 = NumericUpDown4.Value
        c4 = p4 * n4
    End Sub

    Private Sub NumericUpDown5_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NumericUpDown5.ValueChanged
        n5 = NumericUpDown5.Value
        c5 = p5 * n5
    End Sub

    Private Sub NumericUpDown10_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NumericUpDown10.ValueChanged
        n10 = NumericUpDown10.Value
        c10 = p10 * n10
    End Sub

    Private Sub NumericUpDown9_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NumericUpDown9.ValueChanged
        n9 = NumericUpDown9.Value
        c9 = p9 * n9
    End Sub

    Private Sub NumericUpDown8_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NumericUpDown8.ValueChanged
        n8 = NumericUpDown8.Value
        c8 = p8 * n8
    End Sub

    Private Sub NumericUpDown7_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NumericUpDown7.ValueChanged
        n7 = NumericUpDown7.Value
        c7 = p7 * n7
    End Sub

    Private Sub NumericUpDown6_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NumericUpDown6.ValueChanged
        n6 = NumericUpDown6.Value
        c6 = p6 * n6
    End Sub

    Private Sub CheckBox2_CheckedChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox2.CheckedChanged
        Select Case CheckBox2.Checked
            Case True
                NumericUpDown2.Visible = True
                p2 = 15
        End Select
    End Sub

    Private Sub CheckBox7_CheckedChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox7.CheckedChanged
        Select Case CheckBox7.Checked
            Case True
                NumericUpDown3.Visible = True
                p3 = 15

        End Select
    End Sub

    Private Sub CheckBox5_CheckedChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox5.CheckedChanged
        Select Case CheckBox5.Checked
            Case True
                NumericUpDown4.Visible = True
                p4 = 20

        End Select
    End Sub

    Private Sub CheckBox13_CheckedChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox13.CheckedChanged
        Select Case CheckBox13.Checked
            Case True
                NumericUpDown5.Visible = True
                p5 = 20
                
        End Select
    End Sub

    Private Sub CheckBox8_CheckedChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox8.CheckedChanged
        Select Case CheckBox8.Checked
            Case True
                NumericUpDown10.Visible = True
                p10 = 20

        End Select
    End Sub

    Private Sub CheckBox6_CheckedChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox6.CheckedChanged
        Select Case CheckBox6.Checked
            Case True
                NumericUpDown9.Visible = True
                p9 = 15

        End Select
    End Sub

    Private Sub CheckBox4_CheckedChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox4.CheckedChanged
        Select Case CheckBox4.Checked
            Case True
                NumericUpDown8.Visible = True
                p8 = 15

        End Select
    End Sub

    Private Sub CheckBox3_CheckedChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox3.CheckedChanged
        Select Case CheckBox3.Checked
            Case True
                NumericUpDown7.Visible = True
                p7 = 15

        End Select
    End Sub

    Private Sub CheckBox10_CheckedChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox10.CheckedChanged
        Select Case CheckBox10.Checked
            Case True
                NumericUpDown6.Visible = True
                p6 = 15

        End Select
    End Sub

    Private Sub PANTALONES_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        NumericUpDown1.Visible = False
        NumericUpDown2.Visible = False
        NumericUpDown3.Visible = False
        NumericUpDown4.Visible = False
        NumericUpDown5.Visible = False
        NumericUpDown6.Visible = False
        NumericUpDown7.Visible = False
        NumericUpDown8.Visible = False
        NumericUpDown9.Visible = False
        NumericUpDown10.Visible = False
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Hide()
        VENTAS.Show()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Hide()
        catálogo_virtual.Show()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        NumericUpDown1.Value = 0
        NumericUpDown2.Value = 0
        NumericUpDown3.Value = 0
        NumericUpDown4.Value = 0
        NumericUpDown5.Value = 0
        NumericUpDown6.Value = 0
        NumericUpDown7.Value = 0
        NumericUpDown8.Value = 0
        NumericUpDown9.Value = 0
        NumericUpDown10.Value = 0
        CheckBox1.Checked = False
        CheckBox2.Checked = False
        CheckBox3.Checked = False
        CheckBox4.Checked = False
        CheckBox5.Checked = False
        CheckBox6.Checked = False
        CheckBox7.Checked = False
        CheckBox8.Checked = False
        CheckBox10.Checked = False
        CheckBox13.Checked = False
        lbl_total.Text = ""
        NumericUpDown1.Visible = False
        NumericUpDown2.Visible = False
        NumericUpDown3.Visible = False
        NumericUpDown4.Visible = False
        NumericUpDown5.Visible = False
        NumericUpDown6.Visible = False
        NumericUpDown7.Visible = False
        NumericUpDown8.Visible = False
        NumericUpDown9.Visible = False
        NumericUpDown10.Visible = False
    End Sub
End Class