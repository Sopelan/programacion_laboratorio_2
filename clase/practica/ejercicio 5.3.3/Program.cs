using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//  Crea una función que dibuje en pantalla un rectángulo hueco del ancho y alto que se indiquen como parámetros, formado por una letra que también se indique como parámetro. Completa el programa con un Main que pida esos datos al usuario y dibuje el rectángulo
namespace ejercicio_5._3._3
{
    class Program
    {
        static void Main(string[] args)
        {

        }
        static void Rectangulo(int x ,int y, char letra)
        {
            for (int i = 0; i < x; i++) 
            {
                for (int j = 0; j < y; j++)
                    Console.Write(letra);
                Console.WriteLine();
            }
        }
    }
}
