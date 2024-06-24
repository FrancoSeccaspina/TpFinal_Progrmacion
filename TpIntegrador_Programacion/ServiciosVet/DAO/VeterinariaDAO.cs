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
        public DataTable ObtenerAnimales()
        {
            string query = " SELECT * FROM Animales";
            return ConsultarTabla(query);
        }

        public DataTable ObtenerEspecies()
        {
            string query = " SELECT * FROM Especies";
            return ConsultarTabla(query);
        }

        public bool AgregarUsuario(Usuario nuevoUsuario)
        {
            string query = $"INSERT INTO Usuarios (NickName, Contra) VALUES ('{nuevoUsuario.NickName}', '{nuevoUsuario.Contra}')";
            return this.EjecutarComando(query);
        }
        public bool AgregarCliente(Cliente nuevoCliente)
        {
            string query = $"INSERT INTO Usuarios (DNI, Nombre) VALUES ('{nuevoCliente.DNI}', '{nuevoCliente.Nombre})'";
            return this.EjecutarComando(query);
        }

        public bool AgregarAnimal(Animal nuevoAnimal)
        {
            string query = $"INSERT INTO Usuarios (Nombre, Peso, Edad, IDCliente, IDEspecie) " +
                $"VALUES ('{nuevoAnimal.Nombre}', {nuevoAnimal.Peso}, {nuevoAnimal.Edad}, {nuevoAnimal.IDCliente}, {nuevoAnimal.IDEspecie})";
            return this.EjecutarComando(query);
        }

        public bool AgregarEspecie(Especie nuevaEspecie)
        {
            string query = $"INSERT INTO Especie (Nombre, EdadMadurez, PesoPromedio) " +
                $"VALUES ('{nuevaEspecie.Nombre}', {nuevaEspecie.EdadMadurez}, {nuevaEspecie.PesoPromedio})";
            return this.EjecutarComando(query);
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