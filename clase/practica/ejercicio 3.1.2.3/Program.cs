using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Pedir al usuario dos números enteros largos ("long") y mostrar su suma, su resta y su producto. 
namespace ejercicio_3._1._2._3
{
    class Program
    {
        static void Main(string[] args)
        {
            long num1;
            long num2;
            Console.WriteLine("ingrese el numero 1");
            num1 = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("ingrese el numero 2");
            num2 = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("la suma entre el numero 1 y 2 es:{0}", num1 + num2);
            Console.WriteLine("la resta entre el numero 1 y 2 es: {0}", num1 - num2);
            Console.WriteLine("la multiplicacion entre el numero 1 y 2 es {0}", num1 * num2);
            Console.Read();
        }
    }
}
