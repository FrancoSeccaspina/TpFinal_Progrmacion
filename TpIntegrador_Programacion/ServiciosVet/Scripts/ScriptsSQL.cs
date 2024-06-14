using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace ServiciosVet.Scripts
{
    public class ScriptsSQL
    {

        private string InstanciaServer;
        private string NombreScript;
        private string databaseConnectionString;

        public ScriptsSQL()
        {
            InstanciaServer = ConfigurationManager.AppSettings["SqlServerInstance"];
            NombreScript = ConfigurationManager.AppSettings["SqlScript"];
            databaseConnectionString = $"Server={InstanciaServer};Integrated Security=True;";
        }

        public void Ejecutar()
        {
            string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
            string rutaDeCarpetaTpIntegradorProgramacion = Path.GetFullPath(Path.Combine(baseDirectory, @"..\..\..\ServiciosVet"));
            string scriptFilePath = Path.Combine(rutaDeCarpetaTpIntegradorProgramacion, "Sql", NombreScript);

            SqlConnection connection = null;

            try
            {
                if (File.Exists(scriptFilePath))
                {
                    string script = File.ReadAllText(scriptFilePath);

                    connection = new SqlConnection(databaseConnectionString);
                    connection.Open();
                    string[] commandTexts = script.Split(new[] { "GO" }, StringSplitOptions.RemoveEmptyEntries);

                    foreach (var commandText in commandTexts)
                    {
                        SqlCommand command = new SqlCommand(commandText, connection);
                        command.ExecuteNonQuery();
                    }
                    Console.WriteLine("El script SQL se ejecutó correctamente.");
                }
                else
                {
                    Console.WriteLine("No se encontró el archivo.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ocurrió un error al ejecutar el script SQL: {ex.Message}");
            }
            finally
            {
                if (connection != null && connection.State == ConnectionState.Open)
                {
                    connection.Close();
                    connection.Dispose();
                }
            }
        }
    }
}
