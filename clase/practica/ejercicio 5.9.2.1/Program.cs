﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//  Crea un programa que halle cualquier raíz de un número. El usuario deberá indicar el número (por ejemplo, 2) y el índice de la raíz (por ejemplo, 3 para la raíz cúbica). Pista: hallar la raíz cúbica de 2 es lo mismo que elevar 2 a 1/3. 
namespace ejercicio_5._9._2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            double raizNum;
            bool flag;
            Console.WriteLine("ingrese el numero");
            flag = double.TryParse(Console.ReadLine(), out double num);
            while(flag == false)
            {
                Console.WriteLine("Error!!!! ingrese el numero");
                flag = double.TryParse(Console.ReadLine(), out num);
            }
            Console.WriteLine("ingrese la raiz");
            flag = int.TryParse(Console.ReadLine(), out int indice);
            while (flag == false)
            {
                Console.WriteLine("Error!!!! ingrese la raiz");
                flag = int.TryParse(Console.ReadLine(), out indice);
            }
            raizNum = Math.Pow(num,1d/indice);
            Console.WriteLine("La raiz {2} de {0} es {1}", num, raizNum,indice);
            Console.ReadLine();
        }
    }
}
