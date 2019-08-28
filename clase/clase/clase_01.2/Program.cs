using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* . Siendo la definición de número primo “un número natural mayor que 1 que tiene únicamente dos divisores distintos: él mismo y el 1.”:
A. Mostrar por pantalla todos los números primos que haya hasta el número que ingrese el usuario por consola*/
namespace clase_01._2
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            int i;
            int j;
            int contador;
            Console.WriteLine("ingrese un numero");
            num = Convert.ToInt32(Console.ReadLine());
            for(i = 1; i <= num; i++)
            {
                contador = 0;
                for (j = 1; j <= i; j++)
                {
                    if(i % j == 0)
                    {
                        contador++;
                    }  
                }
                if (contador == 2)
                    {
                        Console.WriteLine(i);
                    }
            }
            Console.Read();
        }
    }
}
