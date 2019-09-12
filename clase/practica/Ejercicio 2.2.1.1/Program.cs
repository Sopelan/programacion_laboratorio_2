using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* ) Crear un programa que pida al usuario su contraseña (numérica). Deberá terminar cuando introduzca como contraseña el número 1111, pero volvérsela a pedir tantas veces como sea necesario.*/
namespace ejercicio_2._2._1._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            Console.WriteLine("ingrese la contrasenia");
            numero = Convert.ToInt32(Console.ReadLine());
            while(numero != 1111)
            {
                Console.WriteLine("Contrasenia incorrecta. Reingresar nuevamente");
                numero = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Contrasenia correcta");
            Console.ReadLine();
        }
    }
}
