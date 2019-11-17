using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//  Un programa que pida al usuario una frase y elimine todos los espacios redundantes que contenga (debe quedar sólo un espacio entre cada palabra y la siguiente).   
namespace ejercicio_4._4._6._2
{
    class Program
    {
        static void Main(string[] args)
        {
            string frase;
            Console.WriteLine("ingrese la frase");
            frase = Console.ReadLine();
            while(frase.IndexOf("  ") != -1 )
            {
                frase = frase.Replace("  ", " ");
            }
            Console.WriteLine(frase);
            Console.Read();
        }
    }
}
