using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*  Crea una función que reciba una cadena de texto, y una subcadena, y devuelva cuántas veces aparece la subcadena en la cadena, como subsecuencia formada a partir de sus letras en orden. Por ejemplo, si recibes la palabra "Hhoola" y la subcadena "hola", 
 *  la respuesta sería 4, porque se podría tomar la primera H con la primera O (y con la L y con la A), la primera H con la segunda O, la segunda H con la primera O, o bien la segunda H con la segunda O. Si recibes "hobla", la respuesta sería 1. Si recibes "ohla", 
 *  la respuesta sería 0, porque tras la H no hay ninguna O que permita completar la secuencia en orden. */
namespace ejercicio_5._10._10
{
    class Program
    {
        static void Main(string[] args)
        {

        }
        static int Interativa(string cadena,string subcadena)
        {
            int retorno = 0;
            int j = 0;
            for(int i = 0;i < cadena.Length;i++)
            {
                if (cadena[i] == subcadena[j])
                {
                    j++;
                    if (j == subcadena.Length)
                    {
                        Console.WriteLine("Se encontro ");
                    }
                }
                else
                    j = 0;
            }
            return retorno;
        }
    }
}
