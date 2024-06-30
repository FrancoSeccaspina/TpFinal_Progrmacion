Imports ServiciosVet.DAO

Public Class FormularioBajaCliente
    Dim dao As New VeterinariaDAO
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BtnDarDeBaja.Click
        Dim dniIngresado = TextBoxId.Text
        If (dao.ClienteExistente(dniIngresado) And dao.DarDeBajaCliente(dniIngresado)) Then
            MessageBox.Show("Cliente dado de baja con exito", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("No se pudo dar de baja al cliente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        DataGridClientes.DataSource = dao.ObtenerClientesActivos
    End Sub


    Private Sub FormularioBajaCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DataGridClientes.DataSource = dao.ObtenerClientesActivos
    End Sub

End Class