using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Crear una función "iniciales", que reciba una cadena como "Nacho Cabanes" y devuelva las letras N y C (primera letra, y letra situada tras el primer espacio), usando parámetros por referencia.
namespace ejercicio_5._7._2
{
    class Program
    {
        static void Main(string[] args)
        {
            string nombreCompleto = "Nacho Cabanes";
            Console.WriteLine("su nombre completo es " + nombreCompleto);
            Iniciales(ref nombreCompleto);
            Console.WriteLine("Sus iniciales son " + nombreCompleto);
            Console.ReadLine();
        }
        static void Iniciales(ref string cadena)
        {
            string retorno = "";
            for (int i = 0; i< cadena.Length;i++)
            {
                if(i == 0)
                {
                    if (cadena[i] != ' ')
                        retorno += cadena[i]; 
                }
                else if(cadena[i - 1] == ' ' && cadena[i] != ' ')
                    retorno += cadena[i];
            }
            cadena = retorno;
        }
    }
}
