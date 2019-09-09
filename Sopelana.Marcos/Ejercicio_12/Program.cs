using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* Realizar un programa que sume números enteros hasta que el usuario lo determine, por medio de un mensaje "¿Continuar? (S/N)". 
En el método estático ValidaS_N(char c) de la clase ValidarRespuesta, se validará el ingreso de opciones.
El método devolverá un valor de tipo booleano, TRUE si se ingresó una 'S' y FALSE si se ingresó cualquier otro valor*/
namespace Ejercicio_12
{
    class Program
    {
        static void Main(string[] args)
        {
            bool condiccion = true;
            int num;
            char validar;
            int suma = 0;
            while (condiccion == true)
            {
                Console.WriteLine("ingrese un numero");
                num = Convert.ToInt32(Console.ReadLine());
                suma += num;
                Console.WriteLine("queres ingresar otro numero?");
                validar = Convert.ToChar(Console.ReadLine());
                condiccion = ValidarRespuesta.ValidaS_N(validar);
            }
            Console.WriteLine("la suma es: " + suma);
            Console.Read();
        }
    }
}
