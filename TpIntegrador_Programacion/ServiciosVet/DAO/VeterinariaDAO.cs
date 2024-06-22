using ServiciosVet.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace ServiciosVet.DAO
{
    public class VeterinariaDAO
    {
        public VeterinariaDAO()
        {

        }
        public IDbConnection ObtenerConexion()
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

        public List<Usuario> ObtenerTablasUsuario()
        {
            IDbConnection connection = this.ObtenerConexion();
            IDbCommand command = connection.CreateCommand();

            command.CommandText = " SELECT NickName, Contra FROM Usuario";

            IDataReader lector = command.ExecuteReader();
            List<Usuario> listadin = new List<Usuario>();

            while (lector.Read())
            {

                Usuario UsuarioObt = new Usuario()
                {
                    NickName = lector.GetString(2),
                    Contra = lector.GetInt32(3),
                };
                listadin.Add(UsuarioObt);
            }
            connection.Close();
            return listadin;
        }

        //public void AgregarUsuario()
        //{
        //    string query = "INSERT INTO Usuarios (NickName, Contra)VALUES ('usuario1', 123456);"
        //}

        public List<Cliente> ObtenerTablasClientes()
        {
            IDbConnection connection = this.ObtenerConexion();
            IDbCommand command = connection.CreateCommand();

            command.CommandText = " SELECT DNI, Nombre FROM Clientes";

            IDataReader lector = command.ExecuteReader();
            List<Cliente> listadin = new List<Cliente>();

            while (lector.Read())
            {

                Cliente clienteObt = new Cliente()
                {
                    DNI = lector.GetString(2), 
                    Nombre = lector.GetString(3) 

                };
                listadin.Add(clienteObt);
            }

            connection.Close();
            return listadin;
        }
    }
}