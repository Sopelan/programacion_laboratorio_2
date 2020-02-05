using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//  Un programa que pida al usuario 5 nombres y los muestre ordenados alfabéticamente. 
namespace ejercicio_4._6._2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nombres = new string[5];
            string nombre;
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("ingrese su nombre {0}", i + 1);
                nombres[i] = Console.ReadLine();
            }
            for (int i = 0; i < 4; i++)
            {
                for (int j = i + 1; j < 5; j++) 
                {
                    if(string.Compare(nombres[i],nombres[j],true)>0)
                    {
                        nombre = nombres[i];
                        nombres[i] = nombres[j];
                        nombres[j] = nombre;
                    }
                }
            }
            foreach (string nomb in nombres)
                Console.WriteLine(nomb);
            Console.ReadLine();
        }
    }
}
