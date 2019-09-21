using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*  Crea un programa que "dibuje" un triángulo creciente, alineado a la derecha, con la altura que indique el usuario. Por ejemplo, si el usuario dice que desea 4 caracteres de alto, el triángulo sería así:    
 *  *   
 *  **  
 *  *** 
 *  **** */
namespace ejercicio_2._8._7
{
    class Program
    {
        static void Main(string[] args)
        {
            int ancho = 1;
            int altura;
            int i;
            int j;
            string rectangulo = "";
            Console.WriteLine("ingrese la altura");
            altura = Convert.ToInt32(Console.ReadLine());
            for(i = 0; i < altura; i++)
            {
                for(j = 0; j < ancho; j++)
                    rectangulo += "*";
                rectangulo += "\n";
                ancho++;
            }
            Console.WriteLine(rectangulo);
            Console.Read();
        }
    }
}
