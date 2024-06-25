Imports System
Imports System.Collections.Generic
Imports System.Configuration
Imports System.Data.SqlClient
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks


Public Class InicializarSql

    Public Sub New()
    End Sub

    Public Sub Iniciar()
        Dim crearBaseDeDatos As New CrearBaseDeDatos()
        crearBaseDeDatos.Iniciar()

        Dim ejecutarScripts As New EjecutarScripts()
        ejecutarScripts.Iniciar()
    End Sub

    Public Function ConexionAInstanciaSQL() As IDbConnection
        Try
            Dim StringDeConexion As String = ConfigurationManager.ConnectionStrings("MiConexionSQLExpress").ConnectionString
            Dim connection As New SqlConnection(StringDeConexion)
            connection.Open()
            Console.WriteLine("Conexión exitosa.")
            Return connection
        Catch ex As Exception
            Console.WriteLine($"Error: {ex.Message}")
            Throw
        End Try
    End Function
    Public Function CerrarConexion() As IDbConnection
        Dim StringDeConexion As String = ConfigurationManager.ConnectionStrings("MiConexionSQLExpress").ConnectionString
        Dim connection As New SqlConnection(StringDeConexion)

        Try
            connection.Close()
            Return connection
        Catch ex As Exception
            ' Maneja la excepción aquí según sea necesario
            Console.WriteLine("Error al cerrar la conexión: " & ex.Message)
            Return Nothing ' O devuelve otra cosa según la lógica de tu aplicación
        End Try
    End Function

End Class