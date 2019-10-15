using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//  Crea una versión alternativa del ejercicio 3.5.1, que use "if" en vez del operador condicional. 
namespace ejercicio_3._5._2
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1;
            int num2;
            Console.WriteLine("ingrese el num1");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("ingrese el num2");
            num2 = Convert.ToInt32(Console.ReadLine());
            if (num1 == num2)
                Console.WriteLine("son iguales");
            else
                Console.WriteLine("son distintos");
            Console.Read();
        }
    }
}
