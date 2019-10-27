using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*  Un programa que reserve espacio para dos vectores de 3 componentes, pida al usuario sus valores y calcule la suma de ambos vectores 
 *  (su primera componente será x1+y1, la segunda será x2+y2 y así sucesivamente).*/
namespace ejercicio_4._1._4._8
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vec1 = new int[3];
            int[] vec2 = new int[3];
            int suma1 = new int();
            int suma2 = new int();
            for(int i = 0; i < 3; i++)
            {
                Console.WriteLine("Ingrese el numero x{0}", i + 1);
                vec1[i] = Convert.ToInt32(Console.ReadLine());
                suma1 += vec1[i];
            }
            for(int i = 0; i < 3; i++ )
            {
                Console.WriteLine("ingrese el numero y{0}", i + 1);
                vec2[i] = Convert.ToInt32(Console.ReadLine());
                suma2 += vec2[i];
            }
            Console.WriteLine("la suma del vector 1 es " + suma1);
            Console.WriteLine("la suma del vector 2 es " + suma2);
            Console.ReadLine();

        }
    }
}
