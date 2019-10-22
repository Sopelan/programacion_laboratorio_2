using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Un programa que pida al usuario 5 números reales (pista: necesitarás un array de "float") y luego los muestre en el orden contrario al que se introdujeron.  
namespace ejercicio_4._1._1._2
{
    class Program
    {
        static void Main(string[] args)
        {
            float[] numero = new float[5];
            for(int i = 0; i < 5; i++)
            {
                Console.WriteLine("ingrese el numero {0}", i + 1);
                numero[i] = Convert.ToSingle(Console.ReadLine());
            }
            for(int i = 4; i >= 0;i --)
                Console.WriteLine("numero {0}: {1} ", i + 1, numero[i]);
            Console.ReadLine();
                
        }
    }
}
