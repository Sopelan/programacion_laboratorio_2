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
        private int acumulador;
        public Calculado()
        {
            acumulador = 0;
        }
        public Calculado(int num)
        {
            acumulador = num;
        }
        public Calculado(string num)
        {
            acumulador = (int)Class.BinarioDecimal(num);
        }
        public void acumular(string num)
        {
           acumulador += Convert.ToInt32(num);
        }
        public void acumular(int num)
        {
            acumulador += num;
        }
        public string getResultadoBinario()
        {
            return Convert.ToString(Class.EnteroBinario(acumulador));
        }
        public  int getResultadoEntero()
        {
            return acumulador;
        }

    }
}
