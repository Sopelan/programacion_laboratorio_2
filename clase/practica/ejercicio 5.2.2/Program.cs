using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Crea una función llamada "DibujarCuadrado3x3", que dibuje un cuadrado formato por 3 filas con 3 asteriscos cada una.  Crea también un "Main" que permita probarla. 
namespace ejercicio_5._2._2
{
    class Program
    {
        static void Main(string[] args)
        {
            DibujarCuadrado3x3();
            Console.ReadLine();
        }
        static void DibujarCuadrado3x3()
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                    Console.Write("*");
                Console.WriteLine();
            }
        }
    }
}
