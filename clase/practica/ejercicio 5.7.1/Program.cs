using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Crear una función "intercambia", que intercambie el valor de los dos números enteros que se le indiquen como parámetro.
namespace ejercicio_5._7._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 1;
            int y = 2;
            Console.WriteLine("la x es {0}, y la y es {1}", x, y);
            Intercambia(ref x,ref y);
            Console.WriteLine("y Ahora la x es {0}, y la y es {1}", x, y);
            Console.ReadLine();
        }
        static void Intercambia(ref int a , ref int b)
        {
            int c = a;
            a = b;
            b = c;
        }
    }
}
