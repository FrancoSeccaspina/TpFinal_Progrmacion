Public Class PantallaDeCarga
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If ProgressBar1.Value = ProgressBar1.Maximum Then
            Me.Close()
        Else
            Dim nuevoValor = ProgressBar1.Value + 10
            ProgressBar1.Value = Math.Min(nuevoValor, ProgressBar1.Maximum)
        End If
    End Sub

    'Private Sub PantallaDeCarga_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    'End Sub
End Class