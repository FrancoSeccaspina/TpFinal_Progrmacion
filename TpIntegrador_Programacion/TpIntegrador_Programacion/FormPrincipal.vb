Imports ServiciosVet.Scripts
Imports ServiciosVet.Sql

Public Class Form1
    Private Sub MenuStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked
        Me.Close()
    End Sub

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
        Dim contraseña = "123"
        Dim usuario = "pepe"
        Dim mensaje_con = $"Contraseña incorrecta, ingrese '{contraseña}'"
        Dim mensaje_usu = $"Usuario inexistente, ingrese '{usuario}'"
        If TextBox1.Text = "pepe" And TextBox2.Text = "123" Then
            'Dim pantalla As New PantalaDeCarga
            'pantalla.Show()
            TimerCarga.Enabled = True
            mensaje_con = "Cargando....."
            mensaje_usu = "Cargando....."
        End If
        lblInfo.Text = mensaje_usu
        lblInfo.Visible = True
        lblInfo2.Text = mensaje_con
        lblInfo2.Visible = True
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim sql As New Sql()
        sql.Iniciar()
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
