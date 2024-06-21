Imports System
Imports System.Collections.Generic
Imports System.Data

Public Class CrearBaseDeDatos
    Public Sub New()
    End Sub

    Public Sub Iniciar()
        Me.CrearBaseDeDatosVeterinaria()
    End Sub

    Public Sub CrearBaseDeDatosVeterinaria()
        Dim nombreBaseDeDatos As String = "BaseDatosVeterinaria"
        Me.CrearBase(nombreBaseDeDatos)
    End Sub

    ''' <summary>
    ''' Ejecuta comando SQL para crear una base de datos comprobando si existe
    ''' </summary>
    ''' <param name="nombreBaseDeDatos"></param>
    Private Sub CrearBase(ByVal nombreBaseDeDatos As String)
        Try
            Console.WriteLine($"Iniciando creación de base de datos {nombreBaseDeDatos}...")
            Dim instaciaSql As New InstanciaSql()
            Using con As IDbConnection = instaciaSql.ObtenerConexion

                Dim queryBaseDatos As String = $"
                IF DB_ID('{nombreBaseDeDatos}') IS NULL
                BEGIN
                    CREATE DATABASE {nombreBaseDeDatos};
                END"

                Using command As IDbCommand = con.CreateCommand()
                    Try
                        command.CommandText = queryBaseDatos
                        Dim lector As IDataReader = command.ExecuteReader()
                        Console.WriteLine($"Base de datos {nombreBaseDeDatos} creada correctamente.")
                    Catch ex As Exception
                        Console.WriteLine(ex.Message)
                    Finally
                        con.Close()
                    End Try
                End Using
            End Using
        Catch ex As Exception
            Console.WriteLine("Error al crear la base de datos: " & ex.Message)
        End Try
    End Sub
End Class