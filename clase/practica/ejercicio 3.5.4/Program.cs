using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Crea una versión alternativa del ejercicio 3.5.3, que use "if" en vez del operador condicional
namespace ejercicio_3._5._4
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1;
            int num2;
            Console.WriteLine("ingrese numero 1");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("ingrese numero 2");
            num2 = Convert.ToInt32(Console.ReadLine());
            if (num1 % 2 == 0 && num2 % 2 == 0)
                Console.WriteLine("son pares");
            else
                Console.WriteLine("son inpares");
            Console.ReadLine();
        }
    }
}
