using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiciosVet.Models
{
    public class Animal
    {
        public int id { get; set; }
        public string Nombre {  get; set; }
        public decimal Peso {  get; set; }
        public int Edad {  get; set; }

        //public int IDEspecie {  get; set; } preguntar si se tiene que declarar
        //public int IDCliente {  get; set; } o se encarga la base de datos
        public Animal(string nombre, decimal peso, int edad)
        {
            this.Nombre = nombre;
            this.Peso = peso;
            this.Edad = edad;
        }

        public Animal()
        {
        }
    }

}
