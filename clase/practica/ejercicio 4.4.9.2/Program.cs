using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//  Un programa que pida al usuario varios números separados por espacios y muestre su suma (como el del ejercicio 4.4.6.4), pero empleando "foreach". 
namespace ejercicio_4._4._9._2
{
    class Program
    {
        static void Main(string[] args)
        {
            string frase;
            int suma = new int();
            string[] numeros;
            Console.WriteLine("ingrese los numeros a sumar separado por coma");
            frase = Console.ReadLine();
            numeros = frase.Split(',');
            try
            {
                foreach(string num in numeros)
                {
                    suma += Convert.ToInt32(num);
                }
                Console.WriteLine("la suma entre {0} es: {1}", frase, suma);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.ReadLine();
            }
            
        }
    }
}
