Imports Microsoft.Win32
Imports System
Imports System.Data.SqlClient
Imports System.Data

''' <summary>
''' Clase que maneja la conexión a SQL Server.
''' </summary>
Public Class InstanciaSql
    Private StringDeConexion As String

    Public Sub New()
    End Sub

    ''' <summary>
    ''' Inicia la conexión con la instancia de SQL Server.
    ''' </summary>
    ''' <returns>IDbConnection: Instancia de conexión a SQL Server ya abierta.</returns>
    Public Function ObtenerConexion() As IDbConnection
        Try
            Dim instancia As String = Me.ServerName()
            StringDeConexion = $"Server={instancia};Integrated Security=True;"

            Dim connection As New SqlConnection(Me.StringDeConexion)
            connection.Open()
            Console.WriteLine("Conexión exitosa.")
            Return connection
        Catch ex As Exception
            Console.WriteLine($"Error: {ex.Message}")
            Throw
        End Try
    End Function


    ''' <summary>
    ''' Verifica el tipo de instancia de SQL Server instalada en la máquina local.
    ''' </summary>
    ''' <returns>String: Nombre del servidor SQL.</returns>
    Private Function ServerName() As String
        Dim instanciaSQLExpress As String = "SOFTWARE\Microsoft\Microsoft SQL Server\SQLEXPRESS"
        Dim instanciaSQLLocal As String = "SOFTWARE\Microsoft\Microsoft SQL Server"

        If Registry.LocalMachine.OpenSubKey(instanciaSQLExpress) IsNot Nothing Then
            Return ".\SQLEXPRESS"
        ElseIf Registry.LocalMachine.OpenSubKey(instanciaSQLLocal) IsNot Nothing Then
            Return ".\"
        Else
            Return "No se encontraron instancias de SQL Server instaladas."
        End If
    End Function
End Class
