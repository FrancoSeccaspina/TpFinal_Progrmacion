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
        public string Nombre { get; set; }
        public decimal Peso { get; set; }
        public int Edad { get; set; }

        public int IDEspecie { get; set; }
        public int IDCliente { get; set; }


        public Animal(string nombre, decimal peso, int edad, int cliente, int especie)
        {
            this.Nombre = nombre;
            this.Peso = peso;
            this.Edad = edad;
            this.IDEspecie = cliente;
            this.IDEspecie = especie;   
        }

        public Animal()
        {
        }
    }

}