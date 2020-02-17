using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* Crea un programa que "dibuje" la gráfica de la función y = 10 * seno(x*5), para valores de x entre 0 y 72 grados. Para ayudarte para escribir en cualquier coordenada, puedes usar un array de dos dimensiones, que primero rellenes y luego dibujes en pantalla 
 * (mira el ejercicio 5.9.1.3). */
namespace ejercicio_5._9._2._7
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] dibuje = new string[1000, 1000];

            for (int i = 0; i < 1000; i++)
                for (int j = 0; j < 1000; j++)
                    dibuje[i, j] = " ";
            for (int x = 0; x < 72; x++) 
            {
                int y = (int)(10 * Math.Sin(x * 5));
                if(y < 0)
                {
                    y = y * -1;
                }
                dibuje[x, y] = "*";
            }
            for (int i = 0; i < 72; i++)
            {
                for (int j = 0; j < 1000; j++)
                    Console.Write(dibuje[i, j]);
                Console.WriteLine();
            }
            Console.ReadLine();

        }
    }
}
