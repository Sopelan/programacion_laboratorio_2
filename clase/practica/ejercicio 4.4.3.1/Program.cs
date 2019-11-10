using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* Un programa que te pida tu nombre y lo muestre en pantalla separando cada letra de la siguiente con un espacio. Por ejemplo, si tu nombre es "Juan", 
 * debería aparecer en pantalla "J u a n".*/
namespace ejercicio_4._4._3._1
{
    class Program
    {
        static void Main(string[] args)
        {
            string nombre;
            Console.WriteLine("Ingrese el nombre");
            nombre = Console.ReadLine();
            foreach(char c in nombre)
            {
                Console.Write(c + " ");
            }
            Console.ReadLine();
        }
    }
}
