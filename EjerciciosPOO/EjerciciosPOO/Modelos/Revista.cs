using EjerciciosPOO.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosPOO
{
    internal class Revista: MaterialBiblioteca, IPrestable
    {
        int Numero_edicion { get; set; }
        string Periodicidad { get; set; }
        int Numero_Paginas { get; set; }
        string Editorial { get; set; }

        public Revista(int id, string titulo, string autor, int yearpublication, TipoCategoria categoria, int numero_edicion, string periodicidad, int numero_paginas, string editorial) : base(id, titulo, autor, yearpublication, categoria)
        {
            this.Numero_edicion = numero_edicion;
            this.Periodicidad = periodicidad;
            this.Numero_Paginas = numero_paginas;
            this.Editorial = editorial;
        }

        public override void MostrarInformacion()
        {
            base.MostrarInformacion();

            Console.WriteLine($"Numero edicion: {Numero_edicion}");
            Console.WriteLine($"Periodicidad: {Periodicidad}");
            Console.WriteLine($"Numero de paginas: {Numero_Paginas}");
            Console.WriteLine($"Editorial: {Editorial}");
        }
        public DateTime CalcularFechaDevolucion()
        {
            return DateTime.Now.AddDays(15);
        }

        public void GenerarComprobantePrestamo()
        {
            Console.WriteLine("Se genero el comprobante de la revista con exito!");
        }

        public decimal CalcularMultaPorRetraso(int diasRetraso)
        {
            Console.Write("Su multa sera de ");
            return diasRetraso * 1000;
        }
    }
}
