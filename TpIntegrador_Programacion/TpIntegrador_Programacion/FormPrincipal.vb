'Imports ServiciosVet.Scripts

Imports ServiciosVet.DAO

Public Class Form1
    Dim Dao As VeterinariaDAO

    Private Sub AltaUsuarioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AltaUsuarioToolStripMenuItem.Click
        Dim formu As New FormularioAltaUsuario

        formu.MdiParent = Me

        formu.Show()
    End Sub
    Private Sub AltaAnimalesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AltaAnimalesToolStripMenuItem.Click
        Dim formu As New FormularioAltaAnimales

        formu.MdiParent = Me

        formu.Show()
    End Sub

    Private Sub ListaBusquedaPorPesoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListadoUsuariosToolStripMenuItem.Click
        Dim formu As New FormularioPeso

        formu.MdiParent = Me

        formu.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim dao As New VeterinariaDAO
        Dim usuario As String = TextBox1.Text.Trim()
        Dim contra As String = TextBox2.Text.Trim()
        Dim mensajeUsuario As String = "Usuario inexistente"
        Dim mensajeContra As String = "Contraseña incorrecta"
        If dao.VerificarExistenciaDeUsuario(usuario, contra) Then
            TimerCarga.Enabled = True
            mensajeUsuario = "Cargando..."
            mensajeContra = "Cargando..."
        End If
        lblInfo.Text = mensajeUsuario
        lblInfo2.Text = mensajeContra
        lblInfo.Visible = True
        lblInfo2.Visible = True

    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim sql As New InicializarSql()
        sql.Iniciar()
        Dim dao As New VeterinariaDAO
        dao.DarDeBajaCliente(3)
    End Sub
    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub TimerCarga_Tick(sender As Object, e As EventArgs) Handles TimerCarga.Tick

        If ProgressBar1.Value = ProgressBar1.Maximum Then
            Panel1.Hide()
            MenuStrip1.Visible = True
        Else

            Dim nuevoValor = ProgressBar1.Value + 10

            ProgressBar1.Value = Math.Min(nuevoValor, ProgressBar1.Maximum)
        End If
    End Sub

    Private Sub EspecieToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EspecieToolStripMenuItem.Click
        Dim formu As New FormularioAltaEspecie
        formu.MdiParent = Me

        formu.Show()
    End Sub

    Private Sub AltaClienToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AltaClienToolStripMenuItem.Click
        Dim formu As New FormularioAltaCliente
        formu.MdiParent = Me

        formu.Show()
    End Sub

    Private Sub MenuStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked

    End Sub

    Private Sub ListadoVerdurasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListadoVerdurasToolStripMenuItem.Click
        Dim formu As New FormularioCantidadDeAnimales
        formu.MdiParent = Me
        formu.Show()
    End Sub

    Private Sub ClienteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClienteToolStripMenuItem.Click
        Dim formu As New FormularioBajaCliente
        formu.MdiParent = Me
        formu.Show()
    End Sub

    Private Sub AnimalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AnimalToolStripMenuItem.Click
        Dim formu As New FormularioBajaAnimal
        formu.MdiParent = Me
        formu.Show()
    End Sub

    Private Sub UsuarioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UsuarioToolStripMenuItem.Click
        Dim formu As New FormularioBajaUsuario
        formu.MdiParent = Me
        formu.Show()
    End Sub

    Private Sub EspecieToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles EspecieToolStripMenuItem1.Click
        Dim formu As New FormularioBajaEspecie
        formu.MdiParent = Me
        formu.Show()
    End Sub
End Class
