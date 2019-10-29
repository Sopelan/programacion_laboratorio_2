using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*  Ampliar el programa 4.3.1.1, para que almacene datos de hasta 100 canciones. Deberá tener un menú que permita las opciones: añadir una nueva canción, mostrar el título de todas las canciones,
 *  buscar la canción que contenga un cierto texto (en el artista o en el título). */
namespace ejercicio_4._3._2._1
{
    class Program
    {
        struct Cancion
        {
            public string titulo;
            public string artista;
            public int duracion;
            public float tamaño;
        }
        static void Main(string[] args)
        {
            Cancion[] canciones = new Cancion[100];
            int espacio = 100;
            int cantidad = 0;
            int option = new int();
            bool flag;
            while(option != 4)
            {
                Console.ReadLine();
                Console.Clear();
                Console.WriteLine("1.Añadir una nueva cancion\n2.Mostrar el titulo de todas las canciones\n3.Buscar la cancion que contenga un cierto texto(en el artista o en el titulo\n4.Salir");
                option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        Console.WriteLine("1.Añadir una nueva cancion");
                        if (cantidad < espacio)
                        {
                            Cancion cancion;
                            Console.WriteLine("ingrese el nombre del artista de la cancion");
                            cancion.titulo = Console.ReadLine();
                            Console.WriteLine("ingrese el titulo de la cancion");
                            cancion.artista = Console.ReadLine();
                            Console.WriteLine("ingrese la duracion de la cancion en segundos");
                            cancion.duracion = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("ingrese el tamaño de la cancion en KB");
                            cancion.tamaño = Convert.ToSingle(Console.ReadLine());
                            Console.WriteLine("Cancion: {0}\nArtista: {1}\nDuracion en segundos: {2}\nTamaño en KB: {3}", cancion.titulo, cancion.artista, cancion.duracion, cancion.tamaño);
                            canciones[cantidad] = cancion;
                            cantidad++;
                        }
                        else
                            Console.WriteLine("no hay espacio suficiente");
                        break;
                    case 2:
                        Console.WriteLine("2.Mostrar el titulo de todas las canciones");
                        if (cantidad != 0)
                        {
                            for(int i = 0; i < cantidad; i++)
                            {
                                Console.WriteLine("Cancion: {0}\nArtista: {1}\nDuracion en segundos: {2}\nTamaño en KB: {3}",
                                    canciones[i].titulo, canciones[i].artista, canciones[i].duracion, canciones[i].tamaño); 
                            }
                        }
                        else
                            Console.WriteLine("no hay nada");
                        break;
                    case 3:
                        Console.WriteLine("3.Buscar la cancion que contenga un cierto texto(en el artista o en el titulo");
                        if (cantidad != 0)
                        {
                            string buscar;
                            Console.WriteLine("escribir el texto de la cancion que buscas");
                            buscar = Console.ReadLine();
                            flag = false;
                            for (int i = 0; i < cantidad; i++)
                            {
                                if (buscar == canciones[i].artista || buscar == canciones[i].titulo)
                                {
                                    Console.WriteLine("{4}.Cancion: {0}\nArtista: {1}\nDuracion en segundos: {2}\nTamaño en KB: {3}",
                                        canciones[i].titulo, canciones[i].artista, canciones[i].duracion, canciones[i].tamaño, i + 1);
                                    flag = true;
                                }
                                if (flag == false)
                                    Console.WriteLine("No se encontro lo que estabas buscando");
                            }
                        }
                        else
                            Console.WriteLine("no hay nada");
                        break;
                    case 4:
                        Console.WriteLine("4.Salir");
                        break;
                    default:
                        Console.WriteLine("tiene que estar entre 1 y 4");
                        break;
                }
            }
        }
    }
}
