using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* Un programa que reserve espacio para dos vectores de 3 componentes, pida al usuario sus valores y calcule su producto escalar 
 * (x1·y1+ x2·y2+x3·y3).*/
namespace ejercicio_4._1._4._9
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] num = new int[2, 3];
            int suma = new int();
            for(int i = 0;i < 2; i++)
            {
                for(int j = 0; j< 3; j++)
                {
                    if(i == 0)
                    {
                        Console.WriteLine("ingrese el numero x{0}", j + 1);
                        num[i, j] = Convert.ToInt32(Console.ReadLine());
                    }
                    else if(i == 1)
                    {
                        Console.WriteLine("ingrese el numero y{0}", j + 1);
                        num[i, j] = Convert.ToInt32(Console.ReadLine());
                        suma += (num[i, j] * num[0, j]);
                    }
                }
            }
            Console.WriteLine("el resultado es " + suma);
            Console.Read();
        }
    }
}
