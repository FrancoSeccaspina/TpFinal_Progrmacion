using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiciosVet.Sql
{
    public class CrearBaseDeDatos
    {

        public void Iniciar()
        {
            this.CrearBaseDeDatosVeterinaria();
        }

        public void CrearBaseDeDatosVeterinaria()
        {
            string nombreBaseDeDatos = "BaseDatosVeterinaria";
            this.CrearBase(nombreBaseDeDatos);
        }

        private void CrearBase(string nombreBaseDeDatos)
        {

            try
            {
                ConexionSql Conexion = new ConexionSql();

                Console.WriteLine($"Iniciando creación de base de datos {nombreBaseDeDatos}...");
                using (IDbConnection con = Conexion.Iniciar())
                {
                    string queryBaseDatos = $@"
                    IF DB_ID('{nombreBaseDeDatos}') IS NULL
                    BEGIN
                        CREATE DATABASE {nombreBaseDeDatos};
                    END";

                    using (IDbCommand command = con.CreateCommand())
                    {
                        try
                        {
                            command.CommandText = queryBaseDatos;
                            IDataReader lector = command.ExecuteReader();
                            Console.WriteLine($"Base de datos {nombreBaseDeDatos} creadas correctamente.");
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        finally
                        {
                            con.Close();
                        }

                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al crear la base de datos : " + ex.Message);
            }
        }
    }
}
