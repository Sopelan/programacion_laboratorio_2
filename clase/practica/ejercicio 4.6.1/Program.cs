using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//  Un programa que pida al usuario 5 números en coma flotante y los muestre ordenados. 
namespace ejercicio_4._6._1
{
    class Program
    {
        static void Main(string[] args)
        {
            float[] numeros = new float[5];
            float num;
            for(int i = 0; i < 5; i++)
            {
                bool flag = false;
                while (flag == false)
                {
                    Console.WriteLine("ingrese un numero " + (i+1));
                    flag = float.TryParse(Console.ReadLine(), out numeros[i]);
                }
            }
            for (int i = 0; i < 4;i++)
            {
                for (int j = i+1; j < 5; j++)
                {
                    if(numeros[i] > numeros[j])
                    {
                        num = numeros[i];
                        numeros[i] = numeros[j];
                        numeros[j] = num;
                    }
                }
            }
            foreach (float numero in numeros)
                Console.WriteLine(numero);
            Console.ReadLine();
        }
    }
}
