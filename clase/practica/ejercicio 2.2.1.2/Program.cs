using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* Crea un programa que escriba en pantalla los números del 1 al 10, usando "while". */
namespace ejercicio_2._2._1._2
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 1;
            while(num <= 10)
            {
                Console.WriteLine(num);
                num++;
            }
            Console.Read();
        }
    }
}
