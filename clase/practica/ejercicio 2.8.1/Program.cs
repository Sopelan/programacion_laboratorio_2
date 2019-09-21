using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* Crear un programa que dé al usuario la oportunidad de adivinar un número del 1 al 100 (prefijado en el programa) en un máximo de 6 intentos. En cada pasada deberá avisar de si se ha pasado o se ha quedado 
   corto.*/
namespace ejercicio_2._8._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Random numRandow = new Random();
            int randow;
            int num;
            int intentos = 6;
            randow = numRandow.Next(1,100);
            while(intentos > 0)
            {
                Console.WriteLine("intentos: " + intentos);
                Console.WriteLine("ingrese el numero");
                num = Convert.ToInt32(Console.ReadLine());
                if(randow == num)
                {
                    Console.WriteLine("es ese numero");
                    break;
                }
                Console.WriteLine("no es ese numero\n reintentar");
                Console.ReadLine();
                intentos--;
                Console.Clear();
            }
            if (intentos == 0)
                Console.WriteLine("te quedaste sin intentos\nPerdiste");
            else
                Console.WriteLine("ganaste y te quedaron {0} intentos", intentos);
            Console.ReadLine();

        }
    }
}
