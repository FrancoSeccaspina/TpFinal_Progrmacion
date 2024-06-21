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

End Class
