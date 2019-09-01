using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Conversor;
namespace Calculador
{
    public class Calculado
    {
        private static int acumulador;
        static Calculado()
        {
            acumulador = 0;
        }
        public static void acumular(string num)
        {
           acumulador += Convert.ToInt32(num);
        }
        public static string getResultadoBinario()
        {
            return Convert.ToString(Class.EnteroBinario(acumulador));
        }
        public static int getResultadoEntero()
        {
            return acumulador;
        }
    }
}
