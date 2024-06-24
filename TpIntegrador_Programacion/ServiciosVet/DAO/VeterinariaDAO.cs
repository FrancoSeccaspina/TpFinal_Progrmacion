using ServiciosVet.Models;
using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace ServiciosVet.DAO
{
    public class VeterinariaDAO
    {
        public VeterinariaDAO()
        {

        }

        public SqlConnection ObtenerConexion()
        {
            try
            {
                string StringConexion = ConfigurationManager.ConnectionStrings["MiConexionBaseDeDatosVeterinaria"].ConnectionString;
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

        public DataTable ObtenerUsuarios()
        {
            string query = "SELECT * FROM Usuario";
            return ConsultarTabla(query);
        }

        public DataTable ObtenerClientes()
        {
            string query = " SELECT * FROM Clientes";
            return ConsultarTabla(query);
        }
        public void AgregarUsuario(Usuario nuevoUsuario)
        {
            string query = $"INSERT INTO Usuarios (NickName, Contra) VALUES ({nuevoUsuario.NickName}, {nuevoUsuario.Contra})";
            this.EjecutarComando(query);
        }

        public void AgregarCliente(Cliente nuevoCliente)
        {
            string query = $"INSERT INTO Usuarios (DNI, Nombre) VALUES ({nuevoCliente.DNI}, {nuevoCliente.Nombre})";
            this.EjecutarComando(query);
        }
        public void AgregarEspecie(Especie nuevoEspecie)
        {
            string query = $"INSERT INTO Especies (Nombre) VALUES ({nuevoEspecie.Nombre}";
            this.EjecutarComando(query);
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

        public void EjecutarComando(string comando)
        {
            using (SqlConnection connection = this.ObtenerConexion())
            {
                try
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(comando, connection))
                    {
                        command.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error al ejecutar Comando: " + comando + " : " + ex.Message);
                }
            }
        }

    }
}