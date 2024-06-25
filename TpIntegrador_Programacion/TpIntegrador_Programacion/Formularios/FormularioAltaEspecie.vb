Imports ServiciosVet.DAO
Imports ServiciosVet.Models

Public Class FormularioAltaEspecie

    Private Sub btnAgregarEspecie_Click(sender As Object, e As EventArgs) Handles btnAgregarEspecie.Click
        'Dim sql As New InicializarSql
        Dim dao As New VeterinariaDAO
        If txtNombreEspecie.Text = "" OrElse txtNombreEspecie.Text Is Nothing Then
            MessageBox.Show("ERROR. Complete el campo")
            Return
        Else

            Dim nombreEspecie = txtNombreEspecie.Text
            Dim peso = 0
            Dim edad = 0
            Dim especie As New Especie(nombreEspecie, peso, edad)
            dao.InsertNuevaEspecie(especie)

            MessageBox.Show("La Especie se agregó con éxito.")
            txtNombreEspecie.Text = ""
            'sql.CerrarConexion()
        End If
    End Sub

End Class