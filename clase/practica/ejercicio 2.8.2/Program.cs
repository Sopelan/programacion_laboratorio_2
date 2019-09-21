using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Crear un programa que descomponga un número (que teclee el usuario) como producto de su factores primos. Por ejemplo, 60 = 2 · 2 · 3 · 5 
namespace ejercicio_2._8._2
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            int fact = 2;
            Console.WriteLine("ingrese un numero");
            num = Convert.ToInt32(Console.ReadLine());
            while(num > 1)
            {
                while(num%fact == 0)
                {
                    num = num / fact;
                    Console.WriteLine(fact);
                }
                fact++;
            }
            Console.Read();
        }
    }
}
