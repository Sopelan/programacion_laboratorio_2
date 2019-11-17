using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*  Un programa que pida una cadena al usuario y la modifique, de modo que las letras de las posiciones impares (primera, tercera, etc.) estén en minúsculas y las de las posiciones pares estén en mayúsculas, mostrando el resultado en pantalla. Por ejemplo, 
 *  a partir de un nombre como "Nacho", la cadena resultante sería "nAcHo".*/
namespace ejercicio_4._4._8._1
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            Console.WriteLine("ingrese la frase");
            sb.Append(Console.ReadLine());
            for(int i = 0; i < sb.Length; i++)
            {
                if (i % 2 != 0)
                    sb[i] = char.ToUpper(sb[i]);
                else
                    sb[i] = char.ToLower(sb[i]); 
            }
            Console.WriteLine(sb);
            Console.WriteLine(sb.ToString());
            Console.ReadLine();
        }
    }
}
