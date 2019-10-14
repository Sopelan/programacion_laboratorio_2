using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*  Crea un programa que pida números (en base 10) al usuario y muestre su equivalente en sistema binario y en hexadecimal. Debe repetirse hasta que el usuario introduzca el número 0. */
namespace ejercicio_3._2._4._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Int32 num;
            while (true) 
            {
                Console.WriteLine("ingrese un numero");
                num = Convert.ToInt32(Console.ReadLine());
                if(num == 0)
                {
                    Console.WriteLine("Salir!!!");
                    break;
                }
                Console.WriteLine("En binario: " + Convert.ToString(num, 2));
                Console.WriteLine("En hexadecimal " + Convert.ToString(num,16 ));

            }
            Console.Read();
        }
    }
}
