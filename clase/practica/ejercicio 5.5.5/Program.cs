using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Crear una función que reciba un numero cualquiera y que devuelva como resultado la suma de sus dígitos. Por ejemplo, si el número fuera 123 la suma sería 6. 
namespace ejercicio_5._5._5
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 123;
            Console.WriteLine("la suma de los digitos {0} es  {1}", num, SumaDeDigito(num));
            Console.ReadLine();
        }
        static int SumaDeDigito(int num)
        {
            string numero = num.ToString();
            int retorno = 0;
            for (int i = 0; i < numero.Length; i++)
                retorno += Convert.ToInt32(numero[i].ToString());
            return retorno;
        }
    }
}
