using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//  Crear una función que reciba un número y calcule y muestre en pantalla el valor del perímetro y de la superficie de un cuadrado que tenga como lado el número que se ha indicado como parámetro. 
namespace ejercicio_5._4._6
{
    class Program
    {
        static void Main(string[] args)
        {
            cuadrado(7);
            Console.ReadLine();
        }
        static void cuadrado(int x)
        {
            Console.WriteLine("La superficie de un cuadrado con lados {0} es {1}", x, Math.Pow(x, 2));
            Console.WriteLine("El perimetro de un cuadrado con lados {0} es {1}", x, x * 4);
        }
    }
}
