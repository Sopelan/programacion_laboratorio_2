using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*  Crea un programa que "dibuje" la gráfica de y = (x-5)2 para valores de x entre 1 y 10. Deberá hacerlo dibujando varios espacios en 
pantalla y luego un asterisco. La cantidad de espacios dependerá del valor obtenido para "y"*/
namespace ejercicio_3._2._2._6
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            double y;
            for(x = 1; x <= 10; x++)
            {
                y = Math.Pow(x - 5, 2);
                Console.WriteLine(y);
            }
            Console.Read();
        }
    }
}
