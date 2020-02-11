using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* Crea un programa que "dibuje" asteriscos en 100 posiciones al azar de la pantalla . Para ayudarte para escribir en cualquier coordenada, puedes usar un array de dos dimensiones (con tamaños 24 para el alto y 79 para el ancho), que primero rellenes y 
   luego dibujes en pantalla. */
namespace ejercicio_5._9._1._3
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] dibuje = new string[24, 79];

            for (int i = 0; i < 24; i++)
                for (int j = 0; j < 79; j++)
                    dibuje[i, j] = " ";
            Random random = new Random(); 
            Random random2 = new Random();
            int num;
            int num2;
            for(int i = 0;i < 200;i++)
            {
                num = random.Next(0, 23) ;
                num2 = random2.Next(0, 78);
                while(dibuje[num,num2] == "*")
                {
                    num = random.Next(0, 23);
                    num2 = random2.Next(0, 78);
                }
                dibuje[num, num2] = "*";
            }
            for (int i = 0; i < 24; i++)
            {
                for (int j = 0; j < 79; j++)
                    Console.Write(dibuje[i, j]);
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
