Public Class frm_compra

    Private Sub btn_limpiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_limpiar.Click
        nud_compra.Value = 0
        nud_descuento.Value = 0
        nud_total.Value = 0
        nud_compra.Enabled = True
    End Sub

    Private Sub btn_salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_salir.Click
        End
    End Sub

    Private Sub btn_calcular_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_calcular.Click
        Dim com, desc As Single
        com = nud_compra.Value
        desc = nud_descuento.Value
        If com >= 1 And com < 100 Then
            MsgBox("TIENES UN DESCUENTO DE 0 %", MsgBoxStyle.Information, "DESCUENTO")
            nud_compra.Enabled = False
        ElseIf com >= 100 And com < 200 Then
            desc = (com * 10) / 100
            MsgBox("TIENES UN DESCUENTO DE 10 %", MsgBoxStyle.Information, "DESCUENTO")
            nud_compra.Enabled = False
        ElseIf com >= 200 Then
            desc = (com * 15) / 100
            MsgBox("TIENES UN DESCUENTO DE 15 %", MsgBoxStyle.Information, "DESCUENTO")
            nud_compra.Enabled = False
        Else
            MsgBox("NO HICISTE NINGUNA COMPRA", MsgBoxStyle.Information, "COMPRA")
            nud_compra.Enabled = False
        End If
        nud_compra.Value = com
        nud_descuento.Value = desc
        nud_total.Value = com - desc
    End Sub
End Class
