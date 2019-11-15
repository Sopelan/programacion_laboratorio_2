using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* Un programa capaz de multiplicar dos números enteros muy grandes (por ejemplo, de 30 cifras), que se deberán pedir como cadena de texto y analizar 
 * letra a letra.*/
namespace ejercicio_4._4._3._4
{
    class Program
    {
        static void Main(string[] args)
        {
            string num1;
            string num2;
            long mul;
            Console.WriteLine("ingrese el numero 1");
            num1 = Console.ReadLine();
            Console.WriteLine("ingrese el numero 2");
            num2 = Console.ReadLine();
            foreach(char c in num1)
                Console.Write(c + " ");
            Console.WriteLine();
            foreach (char c in num2)
                Console.Write(c + " ");
            Console.WriteLine();
            mul = Convert.ToInt64(num1) * Convert.ToInt64(num2);
            foreach (char c in mul.ToString())
                Console.Write(c + " ");
            Console.WriteLine();
            Console.WriteLine("la multiplicacion entre {0} y {1} es {2} ", num1, num2, mul);
            Console.Read();


        }
    }
}
