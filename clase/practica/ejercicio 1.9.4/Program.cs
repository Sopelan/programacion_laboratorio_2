using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_1._9._4
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            int b;
            int c;
            int suma;
            Console.WriteLine("ingrese el primer numero");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("ingrese el segundo numero");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("ingrese el tercer numero");
            c = Convert.ToInt32(Console.ReadLine());
            suma = a + b + c;
            Console.WriteLine("la suma entre {0} , {1} y {2} es {3}", a, b, c, suma);
            Console.ReadLine();
        }
    }
}
