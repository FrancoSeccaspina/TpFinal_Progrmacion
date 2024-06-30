Imports ServiciosVet.DAO

Public Class FormularioCantidadDeAnimales
    Private Sub FormularioCantidadDeAnimales_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub BtnActualizar_Click(sender As Object, e As EventArgs) Handles BtnActualizar.Click
        Dim dao As New VeterinariaDAO
        DataGridCantAnimales.DataSource = dao.ObtenerSegundoReporte
    End Sub

    Private Sub DataGridCantAnimales_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridCantAnimales.CellContentClick

    End Sub
End Class