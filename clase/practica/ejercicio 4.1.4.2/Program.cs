using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*  Crear un programa que pida al usuario 10 números en coma flotante (pista: necesitarás un array de "float") y luego los muestre en orden inverso 
 *  del último que se ha introducido al primero que se introdujo).*/
namespace ejercicio_4._1._4._2
{
    class Program
    {
        static void Main(string[] args)
        {
            float[] num = new float[10];
            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine("ingrese el numero {0}",i +1);
                num[i] = Convert.ToInt32(Console.ReadLine());
            }
            for(int i = 9; i >= 0;i--)
                Console.WriteLine("el numero {0} es {1}", i + 1, num[i]);
            Console.ReadLine();
        }
    }
}
