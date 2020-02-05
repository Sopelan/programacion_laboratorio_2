using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Crea una función que dibuje en pantalla un cuadrado del ancho (y alto) que se indique como parámetro. Completa el programa con un Main que permita probarla.
namespace ejercicio_5._3._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Cuadrado(11);
            Console.ReadLine();
        }
        static void Cuadrado(int x)
        {
            for(int i = 0; i < x; i++)
            {
                for (int j = 0; j < x; j++)
                    Console.Write("*");
                Console.WriteLine();
            }
        }
    }
}
