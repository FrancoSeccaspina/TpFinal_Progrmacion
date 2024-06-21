Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.IO

Public Class EjecutarScripts

    Public Sub Iniciar()
        Dim baseDirectory As String = AppDomain.CurrentDomain.BaseDirectory
        Dim rutaServiciosVet As String = Path.GetFullPath(Path.Combine(baseDirectory, "..\..\..\ServiciosVet"))
        Dim scriptsDir As String = Path.Combine(rutaServiciosVet, "SQLScripts")
        Dim archivos As IEnumerable(Of String) = Directory.GetFiles(scriptsDir, "*.sql").OrderBy(Function(f) f)

        Dim instaciaSql As New InstanciaSql()
        Using con As IDbConnection = instaciaSql.ObtenerConexion
            Using command As IDbCommand = con.CreateCommand()

                For Each archivo As String In archivos
                    Try
                        Dim script As String = File.ReadAllText(archivo)
                        command.CommandText = script
                        command.ExecuteReader()
                        Console.WriteLine($"Script {Path.GetFileName(archivo)} ejecutado correctamente.")
                    Catch ex As Exception
                        Console.WriteLine($"Error al ejecutar el script {Path.GetFileName(archivo)}: {ex.Message}")
                    End Try
                Next
            End Using
        End Using
    End Sub
End Class
