using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiciosVet.Models
{
    public class Especie
    {
        public int id { get; set; }
        public string Nombre {  get; set; }
        public int EdadMadurez {  get; set; }
        public decimal PesoPromedio { get; set; }
        public Especie(string nombre, int edadMadurez, decimal pesoPromedio)
        {
            this.Nombre = nombre;
            this.EdadMadurez = edadMadurez;
            this.PesoPromedio = pesoPromedio;
        }

        public Especie()
        {
        }
    }


}
