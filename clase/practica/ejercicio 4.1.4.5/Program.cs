using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*  Un programa que pida 10 nombres y los memorice (pista: esta vez se trata de un array de "string"). Después deberá pedir que se teclee un 
 *  nombre y dirá si se encuentra o no entre los 10 que se han tecleado antes. Volverá a pedir otro nombre y  a decir si se encuentra entre 
 *  ellos, y así sucesivamente hasta que se teclee "fin".*/
namespace ejercicio_4._1._4._5
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nombres = new string[10];
            string nombre;
            bool flag;
            for (int i = 0; i < 10; i++)
            {
                Console.Clear();
                Console.WriteLine("ingrese el nombre {0}", i + 1);
                nombres[i] = Console.ReadLine();
                
            }
            while(true)
            {
                Console.Clear();
                flag = false;
                Console.WriteLine("ingrese el nombre a buscar");
                nombre = Console.ReadLine();
                if (nombre == "fin")
                    break;
                for (int i = 0; i < 10; i++)
                {
                    if (nombre == nombres[i])
                    {
                        flag = true;
                        break;
                    }
                    
                }
                if (flag == true)
                    Console.WriteLine("lo encontro");
                else
                    Console.WriteLine("no lo encontro");
                Console.Read();
            }
        }
    }
}
