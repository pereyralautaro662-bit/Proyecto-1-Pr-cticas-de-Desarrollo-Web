Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If monto.Text > 10000 And cuotas.Text < 6 Then
            descuento.Text = monto.Text * 0.3
            montofinal.Text = monto.Text - descuento.Text
            cuotamensual.Text = montofinal.Text / cuotas.Text
        Else
            descuento.Text = 800
            montofinal.Text = monto.Text - descuento.Text
            cuotamensual.Text = montofinal.Text / cuotas.Text
        End If
    End Sub
End Class
