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

    Private Sub ListadoUsuariosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListadoUsuariosToolStripMenuItem.Click
        Dim formu As New FormularioListadoUsuarios

        formu.MdiParent = Me

        formu.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim dao As New VeterinariaDAO()
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




    'Private Sub ProgressBar1_Click(sender As Object, e As EventArgs) Handles ProgressBar1.Click
    '    If ProgressBar1.Value = ProgressBar1.Maximum Then
    '        Me.Close()
    '    Else
    '        Dim nuevoValor = ProgressBar1.Value + 10
    '        ProgressBar1.Value = Math.Min(nuevoValor, ProgressBar1.Maximum)
    '    End If
    'End Sub

    'Private Sub TimerCarga_Tick(sender As Object, e As EventArgs) Handles TimerCarga.Tick
    '    If ProgressBar1.Value = ProgressBar1.Maximum Then
    '        Me.Close()
    '    Else
    '        Dim nuevoValor = ProgressBar1.Value + 10
    '        ProgressBar1.Value = Math.Min(nuevoValor, ProgressBar1.Maximum)
    '    End If
    'End Sub
End Class
