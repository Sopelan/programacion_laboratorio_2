﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* Crea una versión del ejercicio 4.4.5.1 en el que, en caso de que alguno de los textos aparezca como subcadena, se avise además si se encuentra exactamente al principio. */
namespace ejercicio_4._4._5._2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] frases = new string[10];
            string buscar;
            bool flag = false;
            for (int i = 0; i < frases.Length; i++)
            {
                Console.WriteLine("escribi la frase {0}", i + 1);
                frases[i] = Console.ReadLine();
            }
            do
            {
                Console.WriteLine("ingrese la frase al buscar");
                buscar = Console.ReadLine();
                foreach (string frase in frases)
                {
                    if (frase.IndexOf(buscar) >= 0)
                    {
                        Console.WriteLine("existe la frase " + frase);
                        if(frase.IndexOf(buscar) == 0)
                            Console.WriteLine("esta al principio");
                        flag = true;
                        break;
                    }
                }
                if (!flag)
                    Console.WriteLine("no existe la frase " + buscar);
            } while (buscar != "fin");
        }
    }
}
