using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Crear una función "esPrimo", que reciba un número y devuelva el valor booleano "true" si es un número primo o "false" en caso contrario. 
namespace ejercicio_5._5._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Es primo el 49? {0}", EsPrimo(49));
            Console.ReadLine();
        }
        static bool EsPrimo(int num)
        {
            int division = 2;
            int resto = 0;
            while(num > division)
            {
                resto = num % division;
                if (resto == 0)
                    return false;
                division++;
            }
            return true;
        }
    }
}
