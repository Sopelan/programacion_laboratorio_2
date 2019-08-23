using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_03
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0;
            int i;
            int num;
            Console.WriteLine("ingrese un numero");
            num = int.Parse(Console.ReadLine());
            for (i = 1; i < num + 1 ; i += 1)
            {
                if(num % i == 0)
                    a++;
            }
            if (a != 2)
                Console.WriteLine("no es primo");
            else
                Console.WriteLine("es primo");
            Console.Read();
        }
    }
}
