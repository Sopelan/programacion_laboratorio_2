using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*  Un programa que pida al usuario 10 números y luego calcule y muestre cuál es el mayor de todos ellos*/
namespace ejercicio_4._1._4._3
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            int max = int.MinValue;
            for(int i = 0; i < 10;i++)
            {
                Console.WriteLine("ingrese el numero {0}", i + 1);
                num = Convert.ToInt32(Console.ReadLine());
                if (max < num)
                    max = num;
            }
            Console.WriteLine("el numero mayor es {0}", max);
            Console.Read();
        }
    }
}
