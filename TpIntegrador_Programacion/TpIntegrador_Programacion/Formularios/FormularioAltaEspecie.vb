Imports System.Net
Imports ServiciosVet.DAO
Imports ServiciosVet.Models

Public Class FormularioAltaEspecie

    Private Sub btnAgregarEspecie_Click(sender As Object, e As EventArgs) Handles btnAgregarEspecie.Click
        'Dim sql As New InicializarSql
        Dim dao As New VeterinariaDAO
        Dim nombreEspecie = txtNombreEspecie.Text
        Dim peso = txtPesoPromedio.Text
        Dim edad = txtEdadMadurez.Text
        If nombreEspecie = "" OrElse nombreEspecie Is Nothing Or peso = "" OrElse peso Is Nothing Or edad = "" OrElse edad Is Nothing Then
            MessageBox.Show("ERROR. Complete todos los campos campo")
            Return
        End If
        If Not nombreEspecie.All(AddressOf Char.IsLetter) Then
            MessageBox.Show("ERROR. El Nombre de la especie debe contener solo letras.")
            Return
        End If
        If Not peso.All(AddressOf Char.IsDigit) Then
            MessageBox.Show("ERROR. El peso debe contener solo números.")
            Return
        End If
        If Not edad.All(AddressOf Char.IsDigit) Then
            MessageBox.Show("ERROR. El edad debe contener solo números.")
            Return
        End If
        Try
            If dao.EspecieExistente(nombreEspecie) Then
                MessageBox.Show("Error. La especie ya existe.")
                Return
            End If

            Dim especie As New Especie(nombreEspecie, edad, peso)
            dao.InsertNuevaEspecie(especie)
            MessageBox.Show("La Especie se agregó con éxito.")
            Limpiar()
        Catch ex As Exception

        End Try



    End Sub

    Private Sub Limpiar()
        txtNombreEspecie.Text = ""
        txtPesoPromedio.Text = ""
        txtEdadMadurez.Text = ""
    End Sub

    Private Sub FormularioAltaEspecie_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class