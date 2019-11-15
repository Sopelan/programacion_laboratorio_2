using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* Un programa que te pida tu nombre y lo muestre en pantalla como un triángulo creciente. Por ejemplo, si tu nombre es "Juan", debería aparecer en pantalla: 
 * J 
 * Ju 
 * Jua 
 * Juan */
namespace ejercicio_4._4._4._1
{
    public class Program
    {
        static void Main(string[] args)
        {
            string nombre;
            Console.WriteLine("ingrese tu nombre");
            nombre = Console.ReadLine();
            for (int i = 1; i <= nombre.Length; i++)
                Console.WriteLine(nombre.Substring(0, i));
            Console.ReadLine();
        }
    }
}
