using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//  Un programa que calcule el determinante de una matriz de 3x3. 
namespace ejercicio_4._2._4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matriz = new int[3, 3];
            int resultados;
            bool resultado;
            for (int i = 0; i < 3; i++)
            {
                for(int j = 0; j < 3; j++)
                {
                    Console.WriteLine("ingrese el numero[{0},{1}]", i, j);
                    matriz[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            resultados = (matriz[0, 0] * matriz[1, 1] * matriz[2, 2]) + (matriz[0, 1] * matriz[1, 2] * matriz[2, 0]) + (matriz[0, 2] * matriz[1, 0] * matriz[2, 1])
                - (matriz[0, 2] * matriz[1, 1] * matriz[2, 0]) - (matriz[0, 0] * matriz[1, 2] * matriz[2, 1]) - (matriz[0, 1] * matriz[1, 0] * matriz[2, 2]);
            resultado = resultados != 0;
            Console.WriteLine("la matrix\n{0}-{1}-{2}\n{3}-{4}-{5}\n{6}-{7}-{8}\n{9}", matriz[0, 0], matriz[0, 1], matriz[0, 2], matriz[1, 0], matriz[1, 1], matriz[1, 2], matriz[2, 0], matriz[2, 1], matriz[2, 2],resultados);
            Console.WriteLine("la matris puede ser inversa: " + resultado);
            Console.Read();

        }
    }
}
