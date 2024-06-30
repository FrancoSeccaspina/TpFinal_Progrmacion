Imports ServiciosVet
Imports ServiciosVet.DAO

Public Class FormularioBajaAnimal
    Dim dao As New VeterinariaDAO
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub DataGridAnimales_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridAnimales.CellContentClick

    End Sub

    Private Sub FormularioBajaAnimal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DataGridAnimales.DataSource = dao.ObtenerAnimalesActivos
    End Sub

    Private Sub BtnDarDeBaja_Click(sender As Object, e As EventArgs) Handles BtnDarDeBaja.Click
        Dim IdIngresado = TextBoxId.Text
        If IdIngresado = "" Or IdIngresado Is Nothing Then
            MessageBox.Show("Error. Ingrese un id")
            Return
        End If
        If (dao.AnimalExistente(IdIngresado) And dao.DarDeBajaAnimal(IdIngresado)) Then
            MessageBox.Show("Cliente dado de baja con exito", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information)
            TextBoxId.Text = ""
        Else
            MessageBox.Show("No se pudo dar de baja al cliente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        DataGridAnimales.DataSource = dao.ObtenerAnimalesActivos
    End Sub
End Class