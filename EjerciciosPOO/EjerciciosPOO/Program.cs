using EjerciciosPOO.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosPOO
{
    internal class Program
    {
        private static List<IPrestable> MaterialesPrestable = new List<IPrestable>();
        private static int siguienteId = 1;
        static void Main(string[] args)
        {
            bool while_menu = true;
            List<MaterialBiblioteca> lista = new List<MaterialBiblioteca>();
            while (while_menu == true)
            {
                Console.WriteLine("Bienvenido a la biblioteca!");
                Console.WriteLine("Que desea pedir prestado? 1-Libro | 2-Revista | 3-Audiolibro");
                Console.WriteLine("Si desea ver el total y salir presione 4");
                int if_menu = int.Parse(Console.ReadLine());
                if (if_menu == 1)
                {
                    Console.WriteLine("Nombre del libro");
                    string nombre_libro = Console.ReadLine();

                    Console.WriteLine("Autor del libro");
                    string autor_libro = Console.ReadLine();

                    Console.WriteLine("Id del libro");
                    int id_libro = int.Parse(Console.ReadLine());

                    Console.WriteLine("Año de publicacion");
                    int year_libro = int.Parse(Console.ReadLine());

                    TipoCategoria categoria = SeleccionarCategoria();

                    Console.WriteLine("ISBN del libro");
                    int isbn_libro = int.Parse(Console.ReadLine());

                    Console.WriteLine("Numero de paginas del libro");
                    int paginas_libro = int.Parse(Console.ReadLine());


                    Libro libro1 = new Libro(id_libro, nombre_libro, autor_libro, year_libro, categoria, isbn_libro, paginas_libro);
                    lista.Add(libro1);
                }
                else if (if_menu == 2)
                {
                    Console.WriteLine("Nombre de la revista");
                    string nombre_revista = Console.ReadLine();

                    Console.WriteLine("Autor de la revista");
                    string autor_revista = Console.ReadLine();

                    Console.WriteLine("Id del libro");
                    int id_revista = int.Parse(Console.ReadLine());

                    Console.WriteLine("Año de publicacion");
                    int year_revista = int.Parse(Console.ReadLine());


                    TipoCategoria categoria = SeleccionarCategoria();

                    Console.WriteLine("Numero de edicion de la revista");
                    int num_edicion = int.Parse(Console.ReadLine());

                    Console.WriteLine("Periodicidad de la revista");
                    string periodicidad = Console.ReadLine();

                    Console.WriteLine("Numero de paginas de la revista");
                    int num_paginas = int.Parse(Console.ReadLine());

                    Console.WriteLine("Editorial de la revista");
                    string editorial = Console.ReadLine();


                    Revista revista1 = new Revista(id_revista, nombre_revista, autor_revista, year_revista, categoria, num_edicion, periodicidad, num_paginas, editorial);
                    lista.Add(revista1);
                }
                else if (if_menu == 3)
                {
                    Console.WriteLine("Nombre del audiolibro");
                    string nombre_audiolibro = Console.ReadLine();

                    Console.WriteLine("Autor del audiolibro");
                    string autor_audiolibro = Console.ReadLine();

                    Console.WriteLine("Id del audiolibro");
                    int id_audiolibro = int.Parse(Console.ReadLine());

                    Console.WriteLine("Año de publicacion del audiolibro");
                    int year_audiolibro = int.Parse(Console.ReadLine());

                    TipoCategoria categoria = SeleccionarCategoria();

                    Console.WriteLine("Duracion del audiolibro");
                    TimeSpan duracion = TimeSpan.Parse(Console.ReadLine());

                    Console.WriteLine("Narrador del audiolibro");
                    string narrador = Console.ReadLine();


                    AudioLibro audiolibro1 = new AudioLibro(id_audiolibro, nombre_audiolibro, autor_audiolibro, year_audiolibro, categoria, duracion, narrador);
                    lista.Add(audiolibro1);
                }
                else if (if_menu == 4)
                {
                    foreach (MaterialBiblioteca item in lista)
                    {
                        item.MostrarInformacion();
                        Console.WriteLine("");
                        Console.WriteLine("");
                        while_menu = false;


                    }
                }

            }

        }
        private static TipoCategoria SeleccionarCategoria()
        {
            Console.WriteLine("Selecciona una categoria");
            Console.WriteLine("1.Ficcion");
            Console.WriteLine("2.NoFiccion");
            Console.WriteLine("3.Ciencia");
            Console.WriteLine("4.Historia");
            Console.WriteLine("5.Tecnologia");

            int seleccioncategoria = int.Parse(Console.ReadLine());
            switch (seleccioncategoria)
            {
                case 1:
                    {
                        Console.WriteLine(TipoCategoria.Ficcion);
                        return TipoCategoria.Ficcion;
                    }

                case 2:
                    {
                        Console.WriteLine(TipoCategoria.NoFiccion);
                        return TipoCategoria.NoFiccion;
                    }
                case 3:
                    {
                        Console.WriteLine(TipoCategoria.Ciencia);
                        return TipoCategoria.Ciencia;
                    }
                case 4:
                    {
                        Console.WriteLine(TipoCategoria.Historia);
                        return TipoCategoria.Historia;
                    }
                case 5:
                    {
                        Console.WriteLine(TipoCategoria.Tecnologia);
                        return TipoCategoria.Tecnologia;
                    }
                default:
                    {
                        Console.WriteLine(TipoCategoria.SinCategoria);
                        return TipoCategoria.SinCategoria;
                    }
            }
        }
    }
    
}
