using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Crear el diagrama de flujo y la versión en C# de un programa que dé al usuario tres oportunidades para adivinar un número del 1 al 10. 
namespace ejercicio_2._2._1._5
{
    class Program
    {
        static void Main(string[] args)
        {
            Random num = new Random();
            int num2 = num.Next(1, 10);
            int num3;
            Console.WriteLine("ingrese un numero");
            num3 = Convert.ToInt32(Console.ReadLine());
            int i = 0;
            while(num3 != num2 || i < 3)
            {
                i++;
                if (num3 == num2)
                {
                    Console.WriteLine("numero correcto");
                    break;
                }
                    
                Console.WriteLine("numero incorrecto");
                if (i == 3)
                {
                    Console.WriteLine("perdiste");
                    break;
                }
                Console.WriteLine("reingrese un numero");
                num3 = Convert.ToInt32(Console.ReadLine());
            }
            Console.ReadLine();

        }
    }
}
