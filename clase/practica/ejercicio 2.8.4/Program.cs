using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* Crea un programa que "dibuje" un rectángulo formado por asteriscos, con el ancho y el alto que indique el usuario, usando dos "for" anidados. Por ejemplo, si desea anchura 4 y altura 3, el rectángulo sería 
 * así: 
 * **** 
 * **** 
 * **** */
namespace ejercicio_2._8._4
{
    class Program
    {
        static void Main(string[] args)
        {
            int alto;
            int ancho;
            int i;
            int j;
            string rectangulo = "";
            Console.WriteLine("ingresar el alto");
            alto = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("ingresar el ancho");
            ancho = Convert.ToInt32(Console.ReadLine());
            for(i = 0; i < alto; i++)
            {
                for(j = 0; j < ancho; j++)
                {
                    rectangulo += "*";
                }
                rectangulo += "\n";
            }
            Console.WriteLine(rectangulo);
            Console.Read();
            
        }
    }
}
