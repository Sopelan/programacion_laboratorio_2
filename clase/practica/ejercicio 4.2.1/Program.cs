using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*  Un programa que pida al usuario dos bloques de 10 números enteros (usando un array de dos dimensiones). Después deberá mostrar el mayor dato que se ha introducido en cada uno de ellos. */
namespace ejercicio_4._2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] num = new int[2, 10];
            int[] mayor = { int.MinValue ,int.MinValue};
            for(int i = 0; i < 2; i++)
            {
                for(int j = 0; j < 10;j++ )
                {
                    Console.WriteLine("ingrese el numero {0}", (i * 10) + j + 1);
                    num[i, j] = Convert.ToInt32(Console.ReadLine());
                    if (mayor[i] < num[i, j])
                        mayor[i] = num[i, j];
                }
            }
            Console.WriteLine("el numero mayor del primer array es: " + mayor[0]);
            Console.WriteLine("el numero mayor del segundo array es: " + mayor[1]);
            Console.ReadLine();
        }
    }
}
