using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* El usuario tecleará dos números (a y b), y el programa mostrará el resultado de la operación (a+b)*(a-b) y el resultado de la operación a2-b2.*/
namespace ejercicio_1._9._3
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            int b;
            int suma;
            int resta;
            int resultado1;
            int producto1;
            int producto2;
            int resultado2;
            Console.WriteLine("ingrese el primer numero");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("ingrese el segundo numero");
            b = Convert.ToInt32(Console.ReadLine());
            suma = a + b;
            resta = a - b;
            resultado1 = suma * resta;
            Console.WriteLine("el resultado de ({0}+{1})*({0}-{1}) es {2}", a, b, resultado1);
            producto1 = a * a;
            producto2 = b * b;
            resultado2 = producto1 - producto2;
            Console.WriteLine("el resultado de ({0}*{0})-({1}*{1}) es {2}", a, b, resultado2);
            Console.ReadLine();
        }
    }
}
