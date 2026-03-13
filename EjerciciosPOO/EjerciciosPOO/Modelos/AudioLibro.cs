using EjerciciosPOO.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosPOO
{
    internal class AudioLibro: MaterialBiblioteca, IPrestable
    {
        TimeSpan Duracion { get; set; }
        string Narrador { get; set; }

        public AudioLibro(int id, string titulo, string autor, int yearpublication, TipoCategoria categoria, TimeSpan duracion, string narrador) : base(id, titulo, autor, yearpublication, categoria)
        {
            this.Duracion = duracion;
            this.Narrador = narrador;
        }

        public override void MostrarInformacion()
        {
            base.MostrarInformacion();

            Console.WriteLine($"Duracion: {Duracion}");
            Console.WriteLine($"Narrador: {Narrador}");
        }
        public DateTime CalcularFechaDevolucion()
        {
            return DateTime.Now.AddDays(15);
        }

        public void GenerarComprobantePrestamo()
        {
            Console.WriteLine("Se genero el comprobante del audiolibro con exito!");
        }

        public decimal CalcularMultaPorRetraso(int diasRetraso)
        {
            Console.Write("Su multa sera de ");
            return diasRetraso * 1000;
        }

    }
}
