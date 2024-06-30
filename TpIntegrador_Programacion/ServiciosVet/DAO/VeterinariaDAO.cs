using ServiciosVet.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Contracts;
using System.Text.RegularExpressions;

namespace ServiciosVet.DAO
{
    public class VeterinariaDAO
    {
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
            string query = $"INSERT INTO Usuarios (NickName,Contranueva) VALUES ('{nuevoUsuario.NickName}','{nuevoUsuario.Contranueva}')";
            IDbConnection conn = this.ObtenerConexion();
            IDbCommand command = conn.CreateCommand();
            command.CommandText = query;
            int rowsAffected = command.ExecuteNonQuery();
            conn.Close();
            return rowsAffected > 0;
        }
        public bool InsertNuevoAnimal(Animal nuevoanimal)
        {
            string query = $"INSERT INTO Animales (Nombre, Peso, Edad, NombreCliente, NombreEspecie) VALUES ('{nuevoanimal.Nombre}',{nuevoanimal.Peso},{nuevoanimal.Edad},'{nuevoanimal.NombreEspecie}','{nuevoanimal.NombreCliente}')";
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
            //string query = $"SELECT * FROM Usuarios WHERE NickName = '{usuario}' AND Contranueva = '{contranueva}'";
            string query = $"SELECT * FROM Usuarios WHERE NickName COLLATE Latin1_General_BIN = '{usuario}' AND Contranueva COLLATE Latin1_General_BIN = '{contranueva}';";

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

        /// <summary>
        /// Mostrar el peso máximo, mínimo y promedio de agrupado por especie de todos los animales. 
        /// Este reporte debe contener un filtro para poder seleccionar el rango de edad. 
        /// (Pueden hacerlo por medio de dos textbox e incluir su valor en el texto de la query)
        /// </summary>
        /// <param name="ran1"></param>
        /// <param name="ran2"></param>
        /// <returns>DataTable: con los resultados de la consulta</returns>
        public DataTable ObtenerPrimerReporte(int ran1, int ran2)
        {
            string query = $"SELECT " +
                               $"e.Nombre AS Especie, " +
                               $"MAX(a.Peso) AS PesoMaximo, " +
                               $"MIN(a.Peso) AS PesoMinimo, " +
                               $"AVG(a.Peso) AS PesoPromedio " +
                               $"FROM Animales a " +
                               $"JOIN Especies e " +
                               $"ON a.NombreEspecie = e.Nombre " +
                               $"WHERE a.Edad BETWEEN {ran1} AND {ran2} " +
                               $"GROUP BY e.Nombre;";

            return this.ConsultarTabla(query);
        }

        /// <summary>
        /// Mostrar la cantidad de animales con los que cuenta cada dueño ordenado de menor a mayor
        /// </summary>
        /// <returns>DataTable: con los resultados de la consulta</returns>
        public DataTable ObtenerSegundoReporte()
        {
            string query ="SELECT c.Nombre AS Dueño, COUNT(a.ID) AS CantidadAnimales " +
                            "FROM Clientes c " +
                            "JOIN Animales a ON c.Nombre = a.NombreCliente " +
                            "GROUP BY c.Nombre " +
                            "ORDER BY CantidadAnimales;";
            return this.ConsultarTabla(query);
        }

        /// <summary>
        ///     Se conecta a la base de datos BaseDatosVeterinaria
        /// </summary>
        /// <returns>SqlConnection: conexion a la base de datos abierto (open) </returns>
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


        /// <summary>
        /// Consultas de selección SQL a la base de datos cualquier, devolviendo un objeto de tipo DataTable 
        /// </summary>
        /// <param name="query"></param>
        /// <returns>Resultado de la consulta: DataTable</returns>
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

        /// <summary>
        /// Ejecuta un comando SQL que no devuelve resultados en la base de datos como INSERT, UPDATE, DELETE, 
        /// o cualquier comando que no genere un conjunto de resultados.
        ///</summary>
        /// <param name="comando"></param>
        /// <returns>Devuelve true si el comando se ejecutó correctamente, de lo contrario, devuelve false.</returns>
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