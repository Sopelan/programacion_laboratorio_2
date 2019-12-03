
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*  Realizar un programa que permita realizar operaciones matemáticas simples (suma, resta, multiplicación y división). Para ello se le debe pedir al usuario que ingrese dos números y la operación 
    que desea realizar (pulsando el caracter +, -, * ó /).
    El usuario decidirá cuándo finalizar el programa.
    Crear una clase llamada Calculadora que posea tres métodos estáticos (de clase):
    a. Calcular (público): Recibirá tres parámetros, el primer número, el segundo número y la operación matemática. El método devolverá el resultado de la operación.
    b. Validar (privado): Recibirá como parámetro el segundo número. Este método se debe utilizar sólo cuando la operación elegida sea la DIVISIÓN. Este método devolverá TRUE si el número es distinto de CERO.*/ 
namespace Ejercicio_15
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1;
            double num2;
            double operacion;
            string operador;
            int num;
            do
            {
                Console.WriteLine("Ingrese el numero 1");
                num1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("ingrese el numero 2");
                num2 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("ingrese el operador");
                operador = Console.ReadLine();
                operacion = Calculadora.Calcular(num1, num2, operador);
                Console.WriteLine("{0} {2} {1}: {3}", num1, num2, operador, operacion);
                Console.WriteLine("quieres continuar n/0");
                num = Convert.ToInt32(Console.ReadLine());
            } while (num != 0);
        }
    }
}
