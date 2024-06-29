using ServiciosVet.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Contracts;

namespace ServiciosVet.DAO
{
    public class VeterinariaDAO
    {

        //private static VeterinariaDAO instancia;
        private string StringConexion;

        public VeterinariaDAO()
        {
            StringConexion = ConfigurationManager.ConnectionStrings["MiConexionBaseDeDatosVeterinaria"].ConnectionString;
        }

        public bool InsertNuevaEspecie(Especie nuevaEspecie)
        {
            string query = $"INSERT INTO Especies (Nombre,EdadMadurez, PesoPromedio) VALUES ('{nuevaEspecie.Nombre}',{nuevaEspecie.EdadMadurez},{nuevaEspecie.PesoPromedio})";
            IDbConnection conn = this.ObtenerConexion();
            IDbCommand command = conn.CreateCommand();
            command.CommandText = query;
            int rowsAffected = command.ExecuteNonQuery();
            conn.Close();
            return rowsAffected > 0;
        }

        public bool InsertNuevoUsuario(Usuario nuevoUsuario)
        {
            string query = $"INSERT INTO Usuarios (NickName,Contranueva) VALUES ('{nuevoUsuario.NickName}',{nuevoUsuario.Contranueva})";
            IDbConnection conn = this.ObtenerConexion();
            IDbCommand command = conn.CreateCommand();
            command.CommandText = query;
            int rowsAffected = command.ExecuteNonQuery();
            conn.Close();
            return rowsAffected > 0;
        }
        public bool InsertNuevoAnimal(Animal nuevoanimal)
        {
            string query = $"INSERT INTO Animales (Nombre, Peso, Edad) VALUES ('{nuevoanimal.Nombre}',{nuevoanimal.Peso},{nuevoanimal.Edad})";
            IDbConnection conn = this.ObtenerConexion();
            IDbCommand command = conn.CreateCommand();
            command.CommandText = query;
            int rowsAffected = command.ExecuteNonQuery();
            conn.Close();
            return rowsAffected > 0;
        }
        public bool InsertNuevoCliente(Cliente nuevocliente)
        {
            string query = $"INSERT INTO Clientes (Nombre, DNI) VALUES ('{nuevocliente.Nombre}',{nuevocliente.DNI})";
            IDbConnection conn = this.ObtenerConexion();
            IDbCommand command = conn.CreateCommand();
            command.CommandText = query;
            int rowsAffected = command.ExecuteNonQuery();
            conn.Close();
            return rowsAffected > 0;
        }
        public List<string> ObtenerNombreEspecies()
        {
            string query = "SELECT Nombre FROM Especies;";
            List<string> nombres = new List<string>();

            using (IDbConnection conn = this.ObtenerConexion())
            {
                IDbCommand command = conn.CreateCommand();
                command.CommandText = query;
                //conn.Open();

                using (IDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        nombres.Add(reader.GetString(0));
                    }
                }
                conn.Close();
            }

            return nombres;
        }

        public List<string> ObtenerNombreClientes()
        {
            string query = "SELECT Nombre FROM Clientes;";
            List<string> nombres = new List<string>();

            using (IDbConnection conn = this.ObtenerConexion())
            {
                IDbCommand command = conn.CreateCommand();
                command.CommandText = query;
                //conn.Open();

                using (IDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        nombres.Add(reader.GetString(0));
                    }
                }
                conn.Close();
            }

            return nombres;
        }
        //public List<string> ObtenerContraUsuario()
        //{
        //    string query = "SELECT Contranueva from Usuarios;";
        //    List<string> contras = new List<string>();

        //    using (IDbConnection conn = this.ObtenerConexion())
        //    {
        //        IDbCommand command = conn.CreateCommand();
        //        command.CommandText = query;
        //        //conn.Open();

        //        using (IDataReader reader = command.ExecuteReader())
        //        {
        //            while (reader.Read())
        //            {
        //                contras.Add(reader.GetString(0));
        //            }
        //        }
        //        conn.Close();
        //    }

        //    return contras;
        //}
        public Usuario GetUsuarioBasedeDatos(string nickName, string contranueva) { 
            //Usuario usuario = new Usuario();
            string query = "Select * from Usuarios;";
            IDbConnection conn = this.ObtenerConexion();
            IDbCommand command = conn.CreateCommand();
            command.CommandText = query;
            IDataReader reader = command.ExecuteReader();
            Usuario usuarioEncontrado = null;
            if(reader.Read())
            {
                usuarioEncontrado = new Usuario()
                {
                    Id = reader.GetInt32(0),
                    NickName = nickName,
                    Contranueva = contranueva,
                };
            }
            conn.Close();
            return usuarioEncontrado;
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
        //public void AgregarUsuario(Usuario nuevoUsuario)
        //{
        //    string query = $"INSERT INTO Usuarios (NickName, Contra) VALUES ({nuevoUsuario.NickName}, {nuevoUsuario.Contra})";
        //    this.EjecutarComando(query);
        //}

        public void AgregarCliente(Cliente nuevoCliente)
        {
            string query = $"INSERT INTO Usuarios (DNI, Nombre) VALUES ({nuevoCliente.DNI}, {nuevoCliente.Nombre})";
            this.EjecutarComando(query);
        }
        public DataTable ObtenerEspecies()
        {
            string query = "Select * FROM Especies";
                return ConsultarTabla(query);
        }
        public void AgregarEspecie(Especie nuevoEspecie)
        {
            string query = $"INSERT INTO Especies (Nombre) VALUES ('{nuevoEspecie.Nombre}')";
            this.EjecutarComando(query);
        }

        public bool VerificarExistenciaDeUsuario(string usuario, string contranueva)
        {
            string query = $"SELECT * FROM Usuarios WHERE NickName = '{usuario}' AND Contranueva = '{contranueva}'";
            return this.ConsultarTabla(query).Rows.Count > 0;
        }
        //public Usuario VerificarContrasenia(string contranueva)
        //{
        //    string query = "Select Contranueva from Usuarios";
        //    IDbConnection conn = this.ObtenerConexion();
        //    IDbCommand command = conn.CreateCommand();
        //    command.CommandText = query;
        //    IDataReader reader = command.ExecuteReader();
        //    Usuario UsuarioEncontrado = null;
        //    if (reader.Read())
        //    {
        //        UsuarioEncontrado = new Usuario()
        //        {
        //            Id = reader.GetInt32(0),
        //            NickName = reader.GetString(1),
        //            Contranueva = reader.GetString(2)
                    
        //        };
        //    }
        //    conn.Close();
        //    //ConsultarTabla(query);
        //    return UsuarioEncontrado;//contraseniaEncontrada
        //}
        public bool UsuarioExistente (string usuario)
        {
            string query = $"SELECT NickName FROM Usuarios WHERE NickName = '{usuario}'";
            return this.ConsultarTabla(query).Rows.Count > 0;


        }
        public bool EspecieExistente(string especie)
        {
            string query = $"SELECT Nombre from Especies where Nombre = '{especie}'";
            return this.ConsultarTabla(query).Rows.Count > 0;


        }
        public bool ClienteExistente(string dni)
        {
            string query = $"SELECT DNI FROM Clientes WHERE DNI = '{dni}'";
            return this.ConsultarTabla(query).Rows.Count > 0;


        }
        //public List<Animal> GetAnimalList()
        //{
        //    IDbConnection conn = this.ObtenerConexion();
        //    IDbCommand command = conn.CreateCommand();
        //    command.CommandText = "Select * from Especies ";
        //}
        public DataTable ConsultarTabla(string query)
        {
            DataTable dataTable = new DataTable();

            using (SqlConnection connection = this.ObtenerConexion())
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);

                try
                {
                    adapter.Fill(dataTable);
                    Console.Write("Consulta ejecutada con exito : " + query);
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