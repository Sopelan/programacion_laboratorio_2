using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 01";
            //Console.WriteLine("hola mundo");
            /*string nombre = "marcos sopelana";
            int edad = 18;
            nombre = Console.ReadLine();
            Console.WriteLine("mi nombre es {0} y tengo {1}",nombre,edad);*/
            int num;
            int suma = 0;
            float promedio;
            int valorMinimo = int.MaxValue;
            int valorMaximo = int.MinValue;
            int i;
            for(i = 0; i < 5; i++)
            {
                Console.WriteLine("ingresar el numero {0}", i + 1);
                num = int.Parse(Console.ReadLine());
                suma = suma + num;
                if (num > valorMaximo)
                    valorMaximo = num;
                if (num < valorMinimo)
                    valorMinimo = num;
            }
            promedio = suma / 5f;
            Console.WriteLine("la suma total es {0}",suma);
            Console.WriteLine("el promedio es {0}", promedio);
            Console.WriteLine("el valor minimo es {0}",valorMinimo);
            Console.WriteLine("el valor maximo es {0}", valorMaximo);
            Console.Read();
        }
    }
}
