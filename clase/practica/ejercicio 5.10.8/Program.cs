using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* Crear un programa que encuentre el máximo común divisor de dos números usando el algoritmo de Euclides: Dados dos números enteros positivos m y n, tal que m > n, para encontrar su máximo común divisor, es decir, el mayor entero positivo que divide a ambos: 
 * - Dividir m por n para obtener el resto r (0 ≤ r < n) ; - Si r = 0, el MCD es n.; - Si no, el máximo común divisor es MCD(n,r). */
namespace ejercicio_5._10._8
{
    class Program
    {
        static void Main(string[] args)
        {
            double m = 700;
            double n = 125;
            double menor = 0;
            if (m > n)
                menor = n;
            else
                menor = m;
            double mcd = 1;
            for (double i = menor; i > 0; i--)
            {
                if (m % i == 0 && n % i == 0)
                {
                    mcd = i;
                    break;
                }
            }
            Console.WriteLine("El mcd de {0} y {1} es {2}", m, n, mcd);
            Console.ReadLine();


        }
    }
}
