using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Crear una función que devuelva la primera letra de una cadena de texto. Probar esta función para calcular la primera letra de la frase "Hola". 
namespace ejercicio_5._4._4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("la primera letra de hola es " + PrimeraLetra("hola"));
            Console.ReadLine();
        }
        static char PrimeraLetra(string cadena)
        {
            return cadena[0];
        }
    }
}
