Imports System.Globalization
Imports ServiciosVet
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


        Dim especieAnimal As Integer

        If CBAnimal.SelectedItem IsNot Nothing Then
            Try
                especieAnimal = Integer.Parse(CBAnimal.SelectedItem.ToString())
                Console.WriteLine("El valor entero es: " & especieAnimal)
            Catch ex As FormatException
                Console.WriteLine("No se pudo convertir el valor seleccionado a un entero.")
            End Try
        End If
        If CBAnimal.SelectedItem Is Nothing Then
            MessageBox.Show("Por favor ingresar una Especie y si no está Creela en la pestaña Agregar Especie")
            Return
        End If
        If CBCliente.SelectedItem Is Nothing Then
            MessageBox.Show("Por favor ingresar un Cliente  y si no está Creelo en la pestaña Nuevo Cliente")
            Return
        End If
        If CBAnimal.SelectedItem IsNot Nothing Then
            Dim nombreEspecie As String = CBAnimal.SelectedItem.ToString()
            Console.WriteLine("La especie seleccionada es: " & especieAnimal)
            Dim nombreCliente As String = CBCliente.SelectedItem.ToString()
            If TxtNombreAnimal.Text.Trim() <> "" And TxtEdadAnimal.Text.Trim() <> "" And TxtPesoAnimal.Text.Trim() <> "" Then
                Dim nombreAnimal = TxtNombreAnimal.Text
                Dim edadAnimal = TxtEdadAnimal.Text
                Dim pesoAnimal As String = TxtPesoAnimal.Text

                If pesoAnimal = "" OrElse pesoAnimal Is Nothing Or edadAnimal = "" OrElse edadAnimal Is Nothing Then
                    MessageBox.Show("ERROR. Complete todos los campos campo")
                    Return
                End If
                If Not edadAnimal.All(AddressOf Char.IsDigit) Then
                    MessageBox.Show("ERROR. El peso debe contener solo números.")
                    Return
                End If

                Try
                    Dim pesoAnimalDecimal As Decimal = Decimal.Parse(TxtPesoAnimal.Text, CultureInfo.InvariantCulture)
                    Dim nuevoAnimal As New Animal(nombreAnimal, pesoAnimalDecimal, edadAnimal, nombreCliente, nombreEspecie)
                    dao.InsertNuevoAnimal(nuevoAnimal)
                Catch ex As Exception
                    MessageBox.Show($"Error : {ex}")
                End Try
                MessageBox.Show("¡Animal Agregado con exito!")
                Limpiar()
                Else
                    MessageBox.Show("Por favor, complete todos los campos y asajunte una foto")
            End If
        End If




    End Sub

    Private Sub Limpiar()
        TxtNombreAnimal.Text = ""
        TxtEdadAnimal.Text = ""
        TxtPesoAnimal.Text = ""
        PictureBox1.Image = Nothing
    End Sub

    Private Sub FormularioAltaAnimales_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Posible muestra de combobox Nombre de Especie
        Dim dao As New VeterinariaDAO
        Dim nombreEspecies As List(Of String) = dao.ObtenerNombreEspecies()
        CBAnimal.Items.Clear()
        For Each nombre As String In nombreEspecies
            CBAnimal.Items.Add(nombre)
        Next
        'Posible muestra de combobox Nombre de Cliente
        Dim nombreClientes As List(Of String) = dao.ObtenerNombreClientes()
        CBCliente.Items.Clear()
        For Each nombre As String In nombreClientes
            CBCliente.Items.Add(nombre)
        Next
    End Sub

    Private Sub CBAnimal_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBAnimal.SelectedIndexChanged

    End Sub
End Class
