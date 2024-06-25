Imports ServiciosVet.DAO
Imports ServiciosVet.Models

Public Class FormularioAltaAnimales
    Private Sub Btn_SeleccionarImagen_Click(sender As Object, e As EventArgs) Handles Btn_SeleccionarImagen.Click
        Dim imagen As New OpenFileDialog()
        imagen.Filter = "Archivos de Imagen|*.jpg;*.jpeg;*.png"

        If imagen.ShowDialog() = DialogResult.OK Then
            PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
            PictureBox1.Image = Image.FromFile(imagen.FileName)
            MessageBox.Show("¡Imagen adjuntada con exito!")
        End If
    End Sub

    Private Sub Btn_AgregarAnimal_Click(sender As Object, e As EventArgs) Handles Btn_AgregarAnimal.Click
        Dim dao As New VeterinariaDAO

        If TxtNombreAnimal.Text.Trim() <> "" And TxtEdadAnimal.Text.Trim() <> "" And TxtPesoAnimal.Text.Trim() <> "" Then
            Dim nombreAnimal = TxtNombreAnimal.Text
            Dim edadAnimal = TxtEdadAnimal.Text
            Dim pesoAnimal = TxtPesoAnimal.Text
            Dim nuevoAnimal As New Animal(nombreAnimal, edadAnimal, pesoAnimal)
            dao.InsertNuevoAnimal(nuevoAnimal)
            MessageBox.Show("¡Animal Agregado con exito!")
            Limpiar()
        Else
            MessageBox.Show("Por favor, complete todos los campos y asajunte una foto")
        End If


    End Sub

    Private Sub Limpiar()
        TxtNombreAnimal.Text = ""
        TxtEdadAnimal.Text = ""
        TxtPesoAnimal.Text = ""
        PictureBox1.Image = Nothing
    End Sub

    Private Sub FormularioAltaAnimales_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub CBAnimal_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBAnimal.SelectedIndexChanged

    End Sub
End Class
