Public Class ACCESORIOS

    Private Sub ACCESORIOS_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        NumericUpDown1.Visible = False
        NumericUpDown2.Visible = False
        NumericUpDown3.Visible = False
        NumericUpDown4.Visible = False
        NumericUpDown5.Visible = False

    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        Select Case CheckBox1.Checked
            Case True
                NumericUpDown1.Visible = True
        End Select
    End Sub

    Private Sub CheckBox5_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox5.CheckedChanged
        Select Case CheckBox5.Checked
            Case True
                NumericUpDown2.Visible = True
        End Select
    End Sub

    Private Sub CheckBox7_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox7.CheckedChanged
        Select Case CheckBox7.Checked
            Case True
                NumericUpDown3.Visible = True
        End Select
    End Sub

    Private Sub CheckBox10_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox10.CheckedChanged
        Select Case CheckBox10.Checked
            Case True
                NumericUpDown4.Visible = True
        End Select
    End Sub

    Private Sub CheckBox13_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox13.CheckedChanged
        Select Case CheckBox13.Checked
            Case True
                NumericUpDown5.Visible = True
        End Select
    End Sub
End Class