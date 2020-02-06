using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//  Crear una función que reciba una cadena y una letra, y devuelva la cantidad de veces que dicha letra aparece en la cadena. Por ejemplo, si la cadena es "Barcelona" y la letra es 'a', debería devolver 2 (porque la "a" aparece 2 veces). 
namespace ejercicio_5._5._4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("¿Cuantas a tiene la palabra barcelona?\nTiene {0} a", CantidadDeLetra("barcelona", 'a'));
            Console.ReadLine();
        }
        static int CantidadDeLetra(string cadena, char letra)
        {
            int retorno = 0;
            for (int i = 0; i < cadena.Length;i++)
                if (cadena[i] == letra)
                    retorno++;
            return retorno;
        }
    }
}
