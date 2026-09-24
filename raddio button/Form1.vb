Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If monto.Text > 20000 And jubilado.Checked = True Then
            descuento.Text = monto.Text * 0.1
            montofinal.Text = monto.Text - descuento.Text
        End If
        If monto.Text > 20000 And empleado.Checked = True Then
            descuento.Text = monto.Text * 0.2
            montofinal.Text = monto.Text - descuento.Text
        End If
    End Sub
End Class
