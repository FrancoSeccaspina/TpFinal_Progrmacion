Public Class FormularioAltaEspecie
    Private Sub btnAgregarEspecie_Click(sender As Object, e As EventArgs) Handles btnAgregarEspecie.Click
        If txtNombreEspecie.Text = "" OrElse txtNombreEspecie.Text Is Nothing Then
            MessageBox.Show("ERROR. Complete el campo")
            Return
        Else
            MessageBox.Show("La Especie se agregó con éxito.")
            txtNombreEspecie.Text = ""
        End If
    End Sub

End Class