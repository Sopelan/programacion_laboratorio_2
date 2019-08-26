using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//  Crea un programa que calcule el resto de dividir 3784 entre 16, usando variables.  
namespace ejercicio_1._5._3._3
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 3784;
            int divisor = 16;
            int resto = num % divisor;
            Console.WriteLine("el resto de dividir {0} entre {1} es {2}", num, divisor, resto);
            Console.Read();
        }
    }
}
