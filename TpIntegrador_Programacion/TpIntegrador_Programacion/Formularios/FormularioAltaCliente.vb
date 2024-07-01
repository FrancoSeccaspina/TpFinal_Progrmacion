Imports ServiciosVet.DAO
Imports ServiciosVet.Models

Public Class FormularioAltaCliente
    Private Sub btnAgregarCliente_Click(sender As Object, e As EventArgs) Handles btnAgregarCliente.Click
        Dim dao As New VeterinariaDAO
        Dim dni = txtDNI.Text
        Dim nombre = txtNombre.Text

        If txtDNI.Text = "" Or txtNombre.Text = "" Then
            MessageBox.Show("ERROR. Complete todos los campos.")
            'Limpiar()
            Return
        End If
        If Not nombre.All(AddressOf Char.IsLetter) Then
            MessageBox.Show("ERROR. El Nombre debe contener solo letras.")
            Return
        End If
        If Not dni.All(AddressOf Char.IsDigit) Then
            MessageBox.Show("ERROR. El DNI debe contener solo números.")
            Return
        End If
        If dni.Length < 7 Then
            MessageBox.Show("Error. El DNI debe tenera al menos 7 digitos.")
            Return
        End If
        If dni.Length > 8 Then
            MessageBox.Show("Error. El DNI debe ser menor o igual a 8 digitos")
            Return
        End If
        Try
            If dao.ClienteExistente(dni) Then
                MessageBox.Show("Error.El DNi del cliente ya esta registrado")
                Return
            End If
            Dim nuevoCliente As New Cliente(dni, nombre)
            dao.InsertNuevoCliente(nuevoCliente)
            MessageBox.Show("¡Cliente Agregado con exito!")
            Limpiar()
        Catch ex As Exception

        End Try



    End Sub

    Private Sub Limpiar()
        txtNombre.Text = ""
        txtDNI.Text = ""
    End Sub

    Private Sub FormularioAltaCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class