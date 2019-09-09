using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_13
{
    class Conversor
    {
        public static string EnteroBinario(int num)
        {
            string conversor = "";
            int j = 1;
            if (num == 1)
                return "1";

            if (num == 0)
                return "0";
            while (num >= j)
                j = j * 2;
            while (j > 1)
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
            double conversor = 0;
            double convert = Convert.ToDouble(num);
            int j = 1;
            int i = 0;
            if (convert == 1)
                return 1;
            if (convert == 0)
                return 0;
            while (convert >= j)
            {
                j = j * 10;
                i++;
            }

            while (j > 1)
            {
                j /= 10;
                i--;

                if (convert >= j)
                {
                    conversor += Math.Pow(2, i);
                    convert -= j;
                }

            }

            return conversor;
        }
    }
}
