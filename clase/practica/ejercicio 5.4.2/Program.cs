using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Crear una función que calcule el menor de dos números enteros que recibirá como parámetros. El resultado será otro número entero. 
namespace ejercicio_5._4._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("el menor de 5 o 3 es " + Menor(5, 3));
            Console.WriteLine("el menor de 4 o 7 es " + Menor(4, 7));
            Console.ReadLine();
        }
        static int Menor(int a, int b)
        {
            if (a > b)
                return b;
            else if (a < b)
                return a;
            else
                throw new NotImplementedException();
        }
    }
}
