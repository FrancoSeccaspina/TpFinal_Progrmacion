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
        public double Peso { get; set; }
        public int Edad { get; set; }

        public string NombreEspecie { get; set; }
        public string NombreCliente { get; set; }


        public Animal(string nombre, double peso, int edad, string NombreEspecie, string NombreCliente)
        {
            this.Nombre = nombre;
            this.Peso = peso;
            this.Edad = edad;
            this.NombreEspecie = NombreEspecie;
            this.NombreCliente = NombreCliente;
            //this.IDEspecie = cliente;
            //    this.IDEspecie = especie;   
        }

        public Animal()
        {
        }
    }

}