using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* Un programa capaz de sumar dos números enteros muy grandes (por ejemplo, de 30 cifras), que se deberán pedir como cadena de texto y analizar letra 
 * a letra.*/
namespace ejercicio_4._4._3._3
{
    class Program
    {
        static void Main(string[] args)
        {
            string num1;
            string num2;
            long suma;
            string sumas;
            Console.WriteLine("ingresar el num1 ");
            num1 = Console.ReadLine();
            Console.WriteLine("ingresar el num2 ");
            num2 = Console.ReadLine();
            for(int i = 0; i< num1.Length; i++)
            {
                Console.Write(num1[i] + " ");
            }
            for(int i  = 0; i< num1.Length;i++)
            {
                Console.Write(num2[i] + " ");
            }
            suma = Convert.ToInt64(num1) + Convert.ToInt64(num2);
            sumas = suma.ToString();   
            for(int i = 0; i < sumas.Length; i++)
            {
                Console.Write(sumas[i] + " ");
            }
            Console.WriteLine("la suma entre {0} y {1} es: {2}", num1, num2, suma);
            Console.Read();
        }
    }
}
