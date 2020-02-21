using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//  Crea dos funciones que sirvan para saber si un cierto texto es subcadena de una cadena. No puedes usar "Contains" ni "IndexOf", sino que debes analizar letra a letra. Una función debe ser iterativa y la otra debe ser recursiva
namespace ejercicio_5._10._9
{
    class Program
    {
        static void Main(string[] args)
        {
            Iterativa("Hola Soy Marcos", "ola");
            Console.ReadLine();
        }
        static bool Iterativa(string cadena,string subcadena)
        {
            int j = 0;
            for (int i = 0;i< cadena.Length;i++)
            {
                if (cadena[i] == subcadena[j])
                {
                    j++;
                    if(j == subcadena.Length)
                    {
                        Console.WriteLine("Se encontro ");
                        int e = i - subcadena.Length +1;
                        for(int k = e; k <= i ; k++)
                            Console.WriteLine(cadena[k]);
                        return true;
                    }
                }
                else
                    j = 0;
            }
            Console.WriteLine("No se Encontro");
            return false;
        }
    }
}
