using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*1. Generar un nuevo programaque realicelas siguientes acciones:
    A.Ingresar 5 números enteros por consola, guardándolos en 5 variables escalares. Luego calcular y mostrar: el valor máximo, el valor mínimo y el promedio.*/
namespace clase_01._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            int i;
            int valorMaximo = 0;
            int valorMinimo = 0;
            int suma = 0;
            float promedio;

            for (i = 0 ; i < 5; i++)
            {
                Console.WriteLine("ingrese el numero {0}", i + 1);
                num = Convert.ToInt32(Console.ReadLine());
                if(i == 0)
                {
                    valorMaximo = num;
                    valorMinimo = num;
                    suma = num;
                }
                else
                {
                    suma += num;
                    if (valorMaximo < num)
                        valorMaximo = num;
                    if (valorMinimo > num)
                        valorMinimo = num;
                }
            }
            promedio = suma / 5f;
            Console.WriteLine("el valor maximo es {0}", valorMaximo);
            Console.WriteLine("el valor minimo es {0}", valorMinimo);
            Console.WriteLine("el promedio es {0}", promedio);
            Console.Read();
        }
    }
}
