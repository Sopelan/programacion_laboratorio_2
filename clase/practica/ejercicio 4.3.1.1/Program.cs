using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*  Un "struct" que almacene datos de una canción en formato MP3: Artista, Título, Duración (en segundos), Tamaño del fichero (en KB). Un programa debe pedir los datos de una canción al usuario,
 *  almacenarlos en dicho "struct" y después mostrarlos en pantalla.*/ 
namespace ejercicio_4._3._1._1
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
            Console.ReadLine();

        }
    }
}
