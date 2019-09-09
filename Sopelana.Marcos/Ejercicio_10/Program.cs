using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* . Partiendo de la base del ejercicio anterior, se pide realizar un programa que imprima por pantalla una pirámide como la siguiente:  
    * 
   *** 
  ***** 
 *******
*********  
Nota: Utilizar estructuras repetitivas y selectivas. */ 
namespace Ejercicio_10
{
    class Program
    {
        static void Main(string[] args)
        {
   
            string piramide = "";
            string espaciado = "";
            int altura;
            int i;
            int j;
            Console.WriteLine("que altura eligis para la piramide");
            altura = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("la pirame es de {0}", altura);
            for (i = 0; i < altura; i++)
            {
                espaciado = "";
                for (j = 0; j < altura - i -1;j++)
                {
                    espaciado += " ";
                }
                if (i == 0)
                {
                   piramide = "*";
                }
                else
                {
                   piramide += "**";
                }
                Console.Write(espaciado);
                Console.WriteLine(piramide);
            }

            Console.Read();
        }
    }
}
