using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//  Un programa que calcule el determinante de una matriz de 2x2. 
namespace ejercicio_4._2._3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matriz = new int[2, 2];
            int respuesta = new int();
            bool respuestas;
            for(int i = 0; i < 2;i++)
            {
                for(int j = 0; j < 2;j++)
                {
                    Console.WriteLine("ingrese el numero[{0},{1}]", i, j);
                    matriz[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            respuesta = (matriz[0, 0] * matriz[1, 1]) - (matriz[0, 1] * matriz[1, 0]);
            respuestas = respuesta != 0;
            Console.WriteLine("la matriz \n{0}-{1}\n{2}-{3}\n tiene inversa {4}", matriz[0, 0], matriz[0, 1], matriz[1, 0], matriz[1, 1],respuestas);
            Console.ReadLine();
        }
    }
}
