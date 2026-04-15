Public Class frm_descuento

    Private Sub btn_calcular_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_calcular.Click
        Dim compra, descuento, total As Single
        compra = Val(txt_compra.Text)
        descuento = Val(txt_descuento.Text)
        total = Val(txt_total.Text)
        If compra < 100 Then
            MsgBox("NO APLICA DESCUENTO", MsgBoxStyle.Information, "DESCUENTO")
            descuento = 0
        ElseIf compra >= 100 And compra < 200 Then
            MsgBox("APLICA EL 10 % DESCUENTO", MsgBoxStyle.Information, "DESCUENTO")
            descuento = (compra * 10) / 100
        Else
            MsgBox("APLICA EL 15 % DESCUENTO", MsgBoxStyle.Information, "DESCUENTO")
            descuento = (compra * 15) / 100
        End If
        total = compra - descuento
        txt_descuento.Text = descuento
        txt_total.Text = total
    End Sub

    Private Sub btn_limpiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_limpiar.Click
        txt_compra.Clear()
        txt_descuento.Clear()
        txt_total.Clear()
    End Sub

    Private Sub btn_salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_salir.Click
        End
    End Sub
End Class
