Imports System.Net
Imports ServiciosVet.DAO
Imports ServiciosVet.Models

Public Class FormularioPeso
    Private Sub FormularioPeso_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Posible muestra de combobox Nombre de Especie
        'Dim dao As New VeterinariaDAO
        'Dim nombreEspecies As List(Of String) = dao.ObtenerNombreEspecies()
        'CBAnimal.Items.Clear()
        'For Each nombre As String In nombreEspecies
        '    CBAnimal.Items.Add(nombre)
        'Next
    End Sub

    Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click

        Dim min = txtMin.Text
        Dim max = txtMax.Text
        If min = "" OrElse min = Nothing Or max = "" OrElse max = Nothing Then
            MessageBox.Show("Error. Complete todos los campos.")
            Return
        End If
        Dim minS As Double
        Dim maxS As Double
        If Not Double.TryParse(min, minS) Or Not Double.TryParse(max, maxS) Then
            MessageBox.Show("ERROR. Debe contener solo números.")
            Return
        End If
        If min <= 0 Or max <= 0 Then
            MessageBox.Show("Error. Los numeros deben ser positivos.")
            Return
        End If
        If max <= min Then
            MessageBox.Show("Error. El maximo tiene que ser mayor al minimo")
            Return
        End If

        Dim dao As New VeterinariaDAO
        Dim mostrarTabla = dao.ObtenerPrimerReporte(min, max)
        DG_Peso.DataSource = mostrarTabla
    End Sub
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub txtMin_TextChanged(sender As Object, e As EventArgs) Handles txtMin.TextChanged

    End Sub
End Class