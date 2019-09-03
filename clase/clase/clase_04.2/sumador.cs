using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clase_04._2
{
    class Sumador
    {
        private int cantidadSumas;
        public Sumador()
        {
            cantidadSumas = 0;
        }
        public Sumador(int num)
        {
            cantidadSumas = num;
        }
        public long Sumar(long a, long b)
        {
            cantidadSumas++;
            return a + b;
        }
        public string Sumar(string a, string b)
        {
            cantidadSumas++;
            int resultado = Convert.ToInt32(a) + Convert.ToInt32(b);
            return Convert.ToString(resultado);
        }
        public int Retorno()
        {
            return cantidadSumas;
        }
    }
}
