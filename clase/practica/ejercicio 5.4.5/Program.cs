using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Crear una función que devuelva la última letra de una cadena de texto. Probar esta función para calcular la última letra de la frase "Hola". 
namespace ejercicio_5._4._5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("La ultima letra de hola es " + UltimaLetra("hola"));
            Console.ReadLine();
        }
        static char UltimaLetra(string cadena)
        {
            return cadena[cadena.Length - 1];
        }
    }
}
