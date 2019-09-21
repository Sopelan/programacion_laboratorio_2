using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*  Crea un programa que "dibuje" un rectángulo hueco, cuyo borde sea una fila (o columna) de asteriscos y cuyo interior esté formado por espacios en blanco, con el ancho y el alto que indique el usuario. Por 
 *  ejemplo, si desea anchura 4 y altura 3, el rectángulo sería así: 
 *  **** 
 *  *  * 
 *  **** */
namespace ejercicio_2._8._6
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            int j;
            int altura;
            int ancho;
            string rectangulo = "";
            Console.WriteLine("ingrese la altura");
            altura = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("ingrese el ancho");
            ancho = Convert.ToInt32(Console.ReadLine());
            for(i = 0; i < altura; i++)
            {
                for(j = 0; j < ancho; j++)
                {
                    if (i == 0 || i == altura - 1 || j == 0 || j == ancho - 1)
                        rectangulo += "*";
                    else
                        rectangulo += " ";
                }
                rectangulo += "\n";
            }
            Console.WriteLine(rectangulo);
            Console.ReadLine();
        }
    }
}
