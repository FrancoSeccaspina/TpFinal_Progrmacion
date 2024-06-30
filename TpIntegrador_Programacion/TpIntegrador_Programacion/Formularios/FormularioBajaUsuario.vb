Imports ServiciosVet.DAO

Public Class FormularioBajaUsuario
    Dim dao As New VeterinariaDAO
    Private Sub FormularioBajaUsuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DataGridUsuarios.DataSource = dao.ObtenerUsuariosActivos
    End Sub

    Private Sub BtnDarDeBaja_Click(sender As Object, e As EventArgs) Handles BtnDarDeBaja.Click
        Dim IdIngresado = TextBoxId.Text
        If IdIngresado = "" Or Nothing Then
            MessageBox.Show("Error. Ingrese una id.")
            Return
        End If
        If (dao.UsuarioExistentePorId(IdIngresado) And dao.DarDeBajaUsuario(IdIngresado)) Then
            MessageBox.Show("Cliente dado de baja con exito", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information)
            TextBoxId.Text = ""
        Else
            MessageBox.Show("No se pudo dar de baja al cliente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        DataGridUsuarios.DataSource = dao.ObtenerUsuariosActivos
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class