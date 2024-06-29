﻿using System;
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

        public string IDEspecie { get; set; }
        public string IDCliente { get; set; }


        public Animal(string nombre, decimal peso, int edad, string iDEspecie, string iDCliente)
        {
            this.Nombre = nombre;
            this.Peso = peso;
            this.Edad = edad;
            this.IDEspecie = iDEspecie;
            this.IDCliente = iDCliente;
            //this.IDEspecie = cliente;
            //    this.IDEspecie = especie;   
        }

        public Animal()
        {
        }
    }

}