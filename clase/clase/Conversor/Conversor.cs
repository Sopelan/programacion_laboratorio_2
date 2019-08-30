using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* Desarrollar una clase llamada Conversor.  
      1. Deberá poseer dos métodos de clase (estáticos):
      A. string EnteroBinario(int). Convierte un número de entero a binario ascii (un caracter por bit, siendo “111” el equivalente al número 7).
      B. double BinarioDecimal(string). Convierte un número binario a decimal */

namespace Conversor
{
    public class Class
    {
        public static string EnteroBinario(int num)
        {
            string conversor = "";
            int j = 1;
            if(num == 1)
                return "1";

            if(num == 0)
                return "0";
            while(num >= j)
                j = j * 2; 
            while(j > 1)
            {
                j /= 2; 
                if (num >= j)
                {
                    conversor += "1";
                    num -= j;
                }
                else
                    conversor += "0";
            }
            return conversor;
        }
        public static double BinarioDecimal(string num)
        {
            return 1;
        }
      
    }
}
