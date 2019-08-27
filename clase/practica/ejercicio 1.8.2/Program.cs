using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Crea un programa que calcule la división de dos números introducidos por el usuario, así como el resto de esa división.  
namespace ejercicio_1._8._2
{
    class Program
    {
        static void Main(string[] args)
        {
            int primerNumero;
            int segundoNumero;
            int division;
            int resto;

            Console.WriteLine("ingrese el primer numero");
            primerNumero = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo numero");
            segundoNumero = Convert.ToInt32(Console.ReadLine());
            division = primerNumero / segundoNumero;
            resto = primerNumero % segundoNumero;
            Console.WriteLine("la division entre {0} y {1} es {2} con resto {3}", primerNumero, segundoNumero, division, resto);
            Console.Read();
        }
    }
}
