Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.IO
Imports System.Runtime.CompilerServices

Public Class EjecutarScripts

    ''' <summary>
    ''' Recorre y ejecuta todos los scripts que estan en la carpeta SQLscripts
    ''' </summary>
    Public Sub Iniciar()
        Dim instaciaSql As New InstanciaSql()
        Using con As IDbConnection = instaciaSql.ObtenerConexion
            Using command As IDbCommand = con.CreateCommand()



                For Each archivo As String In Me.ObtenerArchivosSQL
                    Try
                        Dim script As String = File.ReadAllText(archivo)
                        command.CommandText = script
                        EjecutarComandosSQL(command, script, archivo)
                        Console.WriteLine($"Script {Path.GetFileName(archivo)} ejecutado correctamente.")
                    Catch ex As Exception
                        Console.WriteLine($"Error al ejecutar el script {Path.GetFileName(archivo)}: {ex.Message}")
                    End Try
                Next
            End Using
        End Using
    End Sub

    ''' <summary>
    ''' Ejecuta comandos SQL individuales extraídos de un script
    ''' </summary>
    ''' <param name="command">IDbCommand: Comando SQL a ejecutar</param>
    ''' <param name="script">String: Contenido del script SQL</param>
    ''' <param name="archivo">String: Nombre del archivo SQL</param>
    Private Sub EjecutarComandosSQL(command As IDbCommand, script As String, archivo As String)
        Dim comandos As String() = script.Split(New Char() {";"c}, StringSplitOptions.RemoveEmptyEntries)
        For Each comando As String In comandos
            Try
                command.CommandText = comando
                command.ExecuteNonQuery()
                Console.WriteLine($"Comando ejecutado con exito : {comando}")
            Catch ex As Exception
                Console.WriteLine($"Error al ejecutar el comando {comando} : {ex.Message}")
            End Try
        Next
    End Sub



    ''' <summary>
    '''     Obtiene los scripts que estan ubicados en la carpeta SQLscripts
    ''' </summary>
    ''' <returns>IEnumerable(Of String): Iterable de strings</returns>
    Public Function ObtenerArchivosSQL() As IEnumerable(Of String)
        Dim baseDirectory As String = AppDomain.CurrentDomain.BaseDirectory
        Dim rutaServiciosVet As String = Path.GetFullPath(Path.Combine(baseDirectory, "..\..\ConfiguracionesSql"))
        Dim scriptsDir As String = Path.Combine(rutaServiciosVet, "SQLscripts")

        If Directory.Exists(scriptsDir) Then
            Dim archivos As IEnumerable(Of String) = Directory.GetFiles(scriptsDir, "*.sql").OrderBy(Function(f) f)
            Return archivos
        Else
            Throw New DirectoryNotFoundException($"El directorio {scriptsDir} no existe.")
        End If
    End Function

End Class