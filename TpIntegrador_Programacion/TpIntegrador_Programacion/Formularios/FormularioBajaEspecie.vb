Imports ServiciosVet.DAO

Public Class FormularioBajaEspecie
    Dim dao As New VeterinariaDAO
    Private Sub FormularioBajaEspecie_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DataGridEspecies.DataSource = dao.ObtenerEspeciesActivos
    End Sub

    Private Sub BtnDarDeBaja_Click(sender As Object, e As EventArgs) Handles BtnDarDeBaja.Click
        Dim IdIngresado = TextBoxId.Text
        If (dao.EspecieExistentePorID(IdIngresado) And dao.DarDeBajaEspecie(IdIngresado)) Then
            MessageBox.Show("Cliente dado de baja con exito", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information)
            TextBoxId.Text = ""
        Else
            MessageBox.Show("No se pudo dar de baja al cliente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        DataGridEspecies.DataSource = dao.ObtenerEspeciesActivos
    End Sub
End Class