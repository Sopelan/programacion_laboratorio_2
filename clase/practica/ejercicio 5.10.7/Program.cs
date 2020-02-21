using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//  Crear, tanto de forma recursiva como de forma iterativa, una función diga si una cadena de caracteres es simétrica (un palíndromo). Por ejemplo, "DABALEARROZALAZORRAELABAD" es un palíndromo. 
namespace ejercicio_5._10._7
{
    class Program
    {
        static void Main(string[] args)
        {
            string cadena = "DABALEARROZALAZORRAELABAD";
            string anedac = "";
            bool verdad = Interativa(cadena,ref anedac);
            Console.WriteLine("Es verdad que esta {0} y esta {1} son iguales? {2}",cadena,anedac, verdad);
            Console.ReadLine();

        }
        static bool Recursividad(string cadena,ref string anedac, int i)
        {
            if (i == cadena.Length - 1 && anedac != "")
                return false;
            if (i >= 0)
            {
                anedac += cadena[i];
                Recursividad(cadena, ref anedac, i - 1);
                if (cadena == anedac)
                    return true;
            }
            return false;
        }
        static bool Interativa(string cadena, ref string anedac)
        {
            if (anedac != "")
                return false;
            for (int i = cadena.Length - 1; i >= 0; i--) 
                anedac += cadena[i];
            return cadena == anedac;
        }
    }
}
