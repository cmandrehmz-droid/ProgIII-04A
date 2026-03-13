using EjerciciosPOO.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosPOO
{
    internal class Libro: MaterialBiblioteca, IPrestable
    {
        int ISBN { get; set; }
        int Numero_paginas { get; set; }

        public Libro(int id, string titulo, string autor, int yearpublication, TipoCategoria categoria, int isbn, int numero_paginas) : base(id, titulo, autor, yearpublication, categoria)
        {
            this.Numero_paginas = numero_paginas;
            this.ISBN = isbn;
        }


        public override void MostrarInformacion()
        {
            base.MostrarInformacion();

            Console.WriteLine($"ISBN: {ISBN}");
            Console.WriteLine($"Numero de paginas: {Numero_paginas}");
        }
        public DateTime CalcularFechaDevolucion()
        {
            return DateTime.Now.AddDays(15);
        }

        public void GenerarComprobantePrestamo()
        {
            Console.WriteLine("Se genero el comprobante del libro con exito!");
        }

        public decimal CalcularMultaPorRetraso(int diasRetraso)
        {

            Console.Write($"Su multa sera de {diasRetraso * 1000} ");
            Console.WriteLine("");
            return diasRetraso;

        }
    }
}
