Imports ServiciosVet.DAO
Imports ServiciosVet.Models

Public Class FormularioAltaUsuario
    Private Sub btnAgregarUsuario_Click(sender As Object, e As EventArgs) Handles btnAgregarUsuario.Click
        Dim dao As New VeterinariaDAO
        Dim usuario = txtUsuario.Text
        Dim contrasenia = txtContrasenia.Text
        Dim confirmarContrasenia = txtConfirContrasenia.Text
        If contrasenia <> confirmarContrasenia Then
            MessageBox.Show("ERROR. Las contraseñas no coinciden.")
            Return
        End If
        If usuario = "" Or contrasenia = "" Or confirmarContrasenia = "" Then
            MessageBox.Show("ERROR. Complete todos los campos.")
            Limpiar()
            Return

        End If

        Try

            Dim nuevoUsuario As New Usuario(usuario, contrasenia)
            dao.InsertNuevoUsuario(nuevoUsuario)
        Catch ex As Exception

        End Try
        MessageBox.Show("¡Usuario Agregado con exito!")
        Limpiar()
    End Sub

    Private Sub Limpiar()
        txtUsuario.Text = ""
        txtContrasenia.Text = ""
        txtConfirContrasenia.Text = ""
    End Sub

    Private Sub FormularioAltaUsuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class