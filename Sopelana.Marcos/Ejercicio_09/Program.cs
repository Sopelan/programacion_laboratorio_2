using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* Escribir un programa que imprima por pantalla una pirámide como la siguiente:
 * 
 *** 
 *****
 *******
 *********  
El usuario indicará cuál será la altura de la pirámide ingresando un número entero positivo. Para el ejemplo anterior la altura ingresada fue de 5. Nota: Utilizar estructuras repetitivas y selectivas. */
namespace Ejercicio_09
{
    class Program
    {
        static void Main(string[] args)
        {
            string piramide = "";
            int altura;
            int i;
            Console.WriteLine("que altura eligis para la piramide");
            altura = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("la pirame es de {0}", altura);
            for (i = 0; i < altura;i++)
            {
                if(i == 0)
                {
                    piramide = "*";
                }
                else
                {
                    piramide += "**";
                }
                Console.WriteLine(piramide);
            }
            
            Console.Read();
        }
    }
}
