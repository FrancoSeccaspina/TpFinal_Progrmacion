using ServiciosVet.Models;
using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace ServiciosVet.DAO
{
    public class VeterinariaDAO
    {

        private static VeterinariaDAO instancia;
        private string StringConexion;

        private VeterinariaDAO()
        {
            StringConexion = ConfigurationManager.ConnectionStrings["MiConexionBaseDeDatosVeterinaria"].ConnectionString;
        }

        public static VeterinariaDAO ObtenerInstancia()
        {
            if (instancia == null)
            {
                instancia = new VeterinariaDAO();
            }
            return instancia;
        }

        public SqlConnection ObtenerConexion()
        {
            try
            {
                SqlConnection connection = new SqlConnection(StringConexion);
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


        public DataTable ConsultarTabla(string query)
        {
            DataTable dataTable = new DataTable();

            using (SqlConnection connection = this.ObtenerConexion())
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);

                try
                {
                    adapter.Fill(dataTable);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
            }
            return dataTable;
        }

        public bool EjecutarComando(string comando)
        {
            using (SqlConnection connection = this.ObtenerConexion())
            {
                try
                {
                    using (SqlCommand command = new SqlCommand(comando, connection))
                    {
                        command.ExecuteNonQuery();
                    }
                    return true;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error al ejecutar Comando: " + comando + " : " + ex.Message);
                    return false;
                }
            }
        }
    }
}