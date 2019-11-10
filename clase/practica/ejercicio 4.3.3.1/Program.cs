using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* Ampliar el programa 4.3.2.1, para que el campo "duración" se almacene como minutos y segundos, usando un "struct" anidado que contenga a su vez 
 * estos dos campos*/
namespace ejercicio_4._3._3._1
{
    class Program
    {
        struct Cancion
        {
            public string titulo;
            public string artista;
            public Duracion duracion;
            public float tamaño;
           
        }
        struct Duracion
        {
            public int minutos;
            public int segundos;
        }
        static void Main(string[] args)
        {
            Cancion[] canciones = new Cancion[100];
            int espacio = 100;
            int cantidad = 0;
            int option = new int();
            bool flag;
            while (option != 4)
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
                            cancion.duracion = new Duracion();
                            Console.WriteLine("ingrese la duracion de la cancion en segundos");
                            cancion.duracion.segundos = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("ingrese la duracion de la cancion en minutos");
                            cancion.duracion.minutos = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("ingrese el tamaño de la cancion en KB");
                            cancion.tamaño = Convert.ToSingle(Console.ReadLine());
                            Console.WriteLine("Cancion: {0}\nArtista: {1}\nDuracion: {2}:{4}\nTamaño en KB: {3}", cancion.titulo, cancion.artista, cancion.duracion.minutos.ToString("00"), cancion.tamaño, cancion.duracion.segundos.ToString("00"));
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
                            for (int i = 0; i < cantidad; i++)
                            {
                                Console.WriteLine("Cancion: {0}\nArtista: {1}\nDuracion: {2}:{4}\nTamaño en KB: {3}",
                                    canciones[i].titulo, canciones[i].artista, canciones[i].duracion.minutos.ToString("00"), canciones[i].tamaño,canciones[i].duracion.segundos.ToString("00"));
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
                                    Console.WriteLine("{4}.Cancion: {0}\nArtista: {1}\nDuracion: {2}:{5}\nTamaño en KB: {3}",
                                        canciones[i].titulo, canciones[i].artista, canciones[i].duracion.minutos.ToString("00"), canciones[i].tamaño, i + 1,canciones[i].duracion.segundos.ToString("00"));
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
