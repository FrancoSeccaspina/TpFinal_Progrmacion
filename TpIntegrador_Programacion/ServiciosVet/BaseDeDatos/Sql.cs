using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiciosVet.Sql
{
    public class Sql
    {
        public Sql()
        {
        }

        public void Iniciar()
        {
            CrearBaseDeDatos crearBaseDeDatos = new CrearBaseDeDatos();
            crearBaseDeDatos.Iniciar();

            EjecutarScripts ejecutarScripts = new EjecutarScripts();
            ejecutarScripts.Iniciar();
        }
    }
}
