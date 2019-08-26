using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Calcular el resultado de 2 + 10 / 5 * 2 - 7 % 1 
namespace ejercicio_1._4._2._4
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 10 / 5 * 2;
            int num2 = 7 % 1;
            Console.WriteLine(2 + num1 - num2);
            Console.Read();
        }
    }
}
