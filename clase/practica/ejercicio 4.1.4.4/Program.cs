using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* Un programa que pida al usuario 10 números, calcule su media y luego muestre los que están por encima de la media.*/
namespace ejercicio_4._1._4._4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] num = new int[10];
            int suma = new int();
            float promedio;
            for(int i = 0;i < 10; i++)
            {
                Console.WriteLine("ingrese el numero {0}", i + 1);
                num[i] = Convert.ToInt32(Console.ReadLine());
                suma += num[i];
            }
            promedio = suma / 10f;
            Console.WriteLine("numero que estan encima de la media");
            foreach(int i in num)
            {
                if (promedio < i)
                    Console.WriteLine("numero " + i);
            }
            Console.Read();
        }
    }
}
