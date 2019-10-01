using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Crear un programa que pregunte al usuario su edad y su año de nacimiento. Si la edad que introduce no es un número válido, mostrará un mensaje de aviso, pero aun así le preguntará su año de nacimiento
namespace ejercicio_2._9._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int edad;
            int anioNacimiento;
            try
            {
                Console.Write("Ingrese su edad: ");
                edad = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Su edad es " + edad);
            }
            catch(Exception exception)
            {
                Console.WriteLine("Error: " + exception.Message);
            }
            Console.WriteLine("Ingrese su año de nacimiento");
            anioNacimiento = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Su año de nacimiento es " + anioNacimiento);
            Console.Read();


        }
    }
}
