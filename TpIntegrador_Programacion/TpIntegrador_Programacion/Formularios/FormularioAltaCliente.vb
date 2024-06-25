Imports ServiciosVet.DAO
Imports ServiciosVet.Models

Public Class FormularioAltaCliente
    Private Sub btnAgregarCliente_Click(sender As Object, e As EventArgs) Handles btnAgregarCliente.Click
        Dim dao As New VeterinariaDAO
        Dim nombre = txtNombre.Text
        Dim dni = txtDNI.Text
        If nombre = "" Or dni = "" Then
            MessageBox.Show("ERROR. Complete todos los campos.")
            Limpiar()
            Return

        End If

        Try

            Dim nuevoCliente As New Cliente(nombre, dni)
            dao.InsertNuevoCliente(nuevoCliente)
        Catch ex As Exception

        End Try
        MessageBox.Show("¡Cliente Agregado con exito!")
        Limpiar()
    End Sub

    Private Sub Limpiar()
        txtNombre.Text = ""
        txtDNI.Text = ""
    End Sub
End Class