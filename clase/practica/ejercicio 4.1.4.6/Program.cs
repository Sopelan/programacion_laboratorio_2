using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*  Un programa que prepare espacio para un máximo de 100 nombres. El usuario deberá ir introduciendo un nombre cada vez, hasta que se pulse 
 *  Intro sin teclear nada, momento en el que dejarán de pedirse más nombres y se mostrará en pantalla la lista de los nombres que se han 
 *  introducido.*/
namespace ejercicio_4._1._4._6
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nombres = new string[100];
            string nombre = "a";
            for (int i = 0; i < 100; i++)
            {
                if (nombre != "")
                {
                    Console.WriteLine("ingrese el nombre {0}", i + 1);
                    nombres[i] = Console.ReadLine();
                    if (nombres[i] == "")
                        nombre = "";
                }
                else
                    nombres[i] = "";
            }
            for (int i = 0; i < 100; i++)
            {
                if (nombres[i] != "")
                    Console.WriteLine("El nombre {1} {0}", nombres[i], i + 1);
                else
                    Console.WriteLine("El nombre {0} no tiene ", i + 1);
                   
            }
            Console.Read();
        }
    }
}
