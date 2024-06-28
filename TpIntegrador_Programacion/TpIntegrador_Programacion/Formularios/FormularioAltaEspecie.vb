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
            Dim peso = txtPesoPromedio.Text
            Dim edad = txtEdadMadurez.Text
            Dim especie As New Especie(nombreEspecie, edad, peso)
            dao.InsertNuevaEspecie(especie)

            MessageBox.Show("La Especie se agregó con éxito.")
            txtNombreEspecie.Text = ""
            'sql.CerrarConexion()
        End If
    End Sub

    Private Sub FormularioAltaEspecie_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class