using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiciosVet.Models
{
    public class Cliente
    {
        public int id {  get; set; }
        public string DNI {  get; set; }
        public string Nombre {  get; set; }

        public Cliente(string dNI, string nombre)
        {
            this.DNI = dNI;
            this.Nombre = nombre;
        }

        public Cliente()
        {
        }
    }
}
