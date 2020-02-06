using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Crear una función "pedirEntero", que reciba como parámetros el texto que se debe mostrar en pantalla, el valor mínimo aceptable y el valor máximo aceptable. Deberá pedir al usuario que introduzca el valor tantas veces como sea necesario, 
  volvérselo a pedir en caso de error, y devolver un valor correcto. Probarlo con un programa que pida al usuario un año entre 1800 y 2100. */
namespace ejercicio_5._5._1
{
    class Program
    {
        static void Main(string[] args)
        {
            PedirEntero("ingrese un numero entre 1800 y 2100 ", 1800, 2100);
            Console.ReadLine();
        }
        static int PedirEntero(string mostrar, int minimo, int maximo)
        {
            while (true)
            {
                Console.WriteLine(mostrar);
                if (int.TryParse(Console.ReadLine(), out int num))
                    if (num > minimo && num < maximo)
                        return num;
                    else
                        Console.WriteLine("Error numero mas grande o mas chico");
                else
                    Console.WriteLine("Error de palabra");         
            }
        }
    }
}
