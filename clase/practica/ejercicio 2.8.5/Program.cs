using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*  Crea un programa que "dibuje" un triángulo decreciente, con la altura que indique el usuario. Por ejemplo, si el usuario dice que desea 4 caracteres de alto, el triángulo sería así: 
 *  **** 
 *  *** 
 *  ** 
 *  * */
namespace ejercicio_2._8._5
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            int j;
            int altura;
            int altura2;
            string piramide = "";
            Console.WriteLine("ingrese la altura");
            altura = Convert.ToInt32(Console.ReadLine());
            altura2 = altura;
            for (i = 0; i < altura; i++)
            {
                for (j = 0; j < altura2; j++)
                {
                    piramide += "*";
                }
                altura2--;
                piramide += "\n";
            }
            Console.WriteLine(piramide);
            Console.Read();
            
        }
    }
}
