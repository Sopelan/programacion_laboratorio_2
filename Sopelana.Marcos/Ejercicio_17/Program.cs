using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ejercicio_17.Entidades;
namespace Ejercicio_17
{
    class Program
    {
        static void Main(string[] args)
        {
            Boligrafo boligrafo = new Boligrafo(100, ConsoleColor.Blue);
            Boligrafo boligrafo2 = new Boligrafo(50, ConsoleColor.Red);
            boligrafo.Pintar(20,out string pintar);
            Console.WriteLine(pintar);
            boligrafo.Pintar(90, out pintar);
            Console.WriteLine(pintar);
            boligrafo.Recargar();
            boligrafo.Pintar(100, out pintar);
            Console.WriteLine(pintar);
            boligrafo.Pintar(100, out pintar);
            Console.WriteLine(pintar);
            Console.Read();

        }
    }
}
