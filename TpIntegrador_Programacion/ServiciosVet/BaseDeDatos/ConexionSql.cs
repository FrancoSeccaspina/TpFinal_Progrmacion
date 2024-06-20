using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiciosVet.Sql
{
    public class ConexionSql
    {
        private string StringDeConexion;

        public ConexionSql() { }

        /// <summary>
        ///    Iniciar la conexion con la instancia sql 
        /// </summary>
        /// <returns>IDbConnection: Instancia sql </returns>
        public IDbConnection Iniciar()
        {
            try
            {
                string instancia = this.ServerName();
                StringDeConexion = $"Server={instancia};Integrated Security=True;";

                SqlConnection connection = new SqlConnection(this.StringDeConexion);
                connection.Open();
                Console.WriteLine("Conexión exitosa.");
                return connection;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                throw;
            }
        }

        /// <summary>
        ///     Verifica el tipo de instancia que tiene la maquina donde se ejecutra el programa
        /// </summary>
        /// <returns>String: server name</returns>
        private string ServerName()
        {
            string instanciaSQLExpress = @"SOFTWARE\Microsoft\Microsoft SQL Server\SQLEXPRESS";
            string instanciaSQLLocal = @"SOFTWARE\Microsoft\Microsoft SQL Server";

            if (Registry.LocalMachine.OpenSubKey(instanciaSQLExpress) != null)
            {
                return ".\\SQLEXPRESS";
            }
            else if (Registry.LocalMachine.OpenSubKey(instanciaSQLLocal) != null)
            {
                return ".\\";
            }
            else
            {
                return "No se encontraron instancias de SQL Server instaladas.";
            }
        }

    }
}
