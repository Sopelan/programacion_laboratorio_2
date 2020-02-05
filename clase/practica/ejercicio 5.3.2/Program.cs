using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//  Crea una función que dibuje en pantalla un rectángulo del ancho y alto que se indiquen como parámetros. Completa el programa con un Main que permita probarla
namespace ejercicio_5._3._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangulo(3,5);
            Console.ReadLine();
        }
        static void Rectangulo(int x , int y)
        {
            for (int i = 0; i < x; i++) 
            {
                for (int j = 0; j < y; j++) 
                    Console.Write("*");
                Console.WriteLine();
            }
        }
    }
}
