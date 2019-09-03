using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* Escribir un programa que determine si un año es bisiesto. Un año es bisiesto si es múltiplo de 4. Los años múltiplos de 100 no son bisiestos, salvo si ellos también son múltiplos de 400. 
 Por ejemplo: el año 2000 es bisiesto pero 1900 no. Pedirle al usuario un año de inicio y otro de fin y mostrar todos los años bisiestos en ese rango. Nota: Utilizar estructuras repetitivas, 
 selectivas y la función módulo (%). */ 
namespace Ejercicio_06
{
    class Program
    {
        static void Main(string[] args)
        {
            int inicio;
            int fin;
            int i;
            Console.WriteLine("ingrese la fecha de inicio");
            inicio = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("ingrese la fecha de fin");
            fin = Convert.ToInt32(Console.ReadLine());
            for (i = inicio; i <= fin; i++)
            {
                if(i % 4 == 0)
                {
                    if (i % 400 == 0)
                        Console.WriteLine(i);
                    else if (i % 100 == 0)
                    {

                    }
                    else
                        Console.Write(i + " ");
                }
            }
            Console.Read();
        }
        
    }
}
