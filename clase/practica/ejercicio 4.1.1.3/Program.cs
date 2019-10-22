using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*  Un programa que pida al usuario 4 números enteros y calcule (y muestre) cuál es el mayor de ellos. Nota: para calcular el mayor valor de un array, hay que cada uno de los valores que tiene almacenados con el que hasta ese momento es 
 *  el máximo. El valor inicial de este máximo no debería ser cero (porque fallaría si todos los números son negativos), sino el primer elemento del array. */
namespace ejercicio_4._1._1._3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] num = new int[4];
            int max = new int();
            for(int i = 0; i < 4; i++)
            {
                Console.WriteLine("ingrese el numero {0}", i + 1);
                num[i] = Convert.ToInt32(Console.ReadLine());
                if (i == 0)
                    max = num[0];
                else
                    if (max < num[i])
                        max = num[i];
            }
            Console.WriteLine("el numero mas grande es: {0}", max);
            Console.Read();
        }
    }
}
