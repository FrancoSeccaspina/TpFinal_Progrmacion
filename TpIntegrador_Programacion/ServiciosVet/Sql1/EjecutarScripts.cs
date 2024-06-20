using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiciosVet.Sql
{
    public class EjecutarScripts
    {

        public void Iniciar()
        {
            ConexionSql Conexion = new ConexionSql();

            string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
            string rutaServiciosVet = Path.GetFullPath(Path.Combine(baseDirectory, @"..\..\..\ServiciosVet"));
            var scriptsDir = Path.Combine(rutaServiciosVet, "SQLScripts");
            var archivos = Directory.GetFiles(scriptsDir, "*.sql").OrderBy(f => f);

            foreach (var archivo in archivos)
            {
                string script = File.ReadAllText(archivo);

                using (IDbConnection con = Conexion.Iniciar())
                {
                    IDbCommand command = con.CreateCommand();
                    command.CommandText = script;

                    try
                    {
                        command.ExecuteReader();
                        Console.WriteLine($"Script {Path.GetFileName(archivo)} ejecutado correctamente.");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Error al ejecutar el script {Path.GetFileName(archivo)}: {ex.Message}");
                    }
                    finally
                    {
                        con.Close();
                    }
                }
            }
        }
    }
}
