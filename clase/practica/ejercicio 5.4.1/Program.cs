using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Crear una función que calcule el cubo de un número real (float) que se indique como parámetro. El resultado deberá ser otro número real. Probar esta función para calcular el cubo de 3.2 y el de 5. 
namespace ejercicio_5._4._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("El cubo de 3.2 es {0} y el cubo de 5 es {1}", Cubo(3.2f), Cubo(5f));
            Console.ReadLine();
        }
        static float Cubo(float num)
        {
            return Convert.ToSingle(Math.Pow(num, 3));
        }
    }
}
