using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*  a. Calcular (público): Recibirá tres parámetros, el primer número, el segundo número y la operación matemática. El método devolverá el resultado de la operación.
    b. Validar (privado): Recibirá como parámetro el segundo número. Este método se debe utilizar sólo cuando la operación elegida sea la DIVISIÓN. Este método devolverá TRUE si el número es distinto de CERO.*/
namespace Ejercicio_15
{
    public class Calculadora
    {
        public static double Calcular(double num1, double num2 , string operador)
        {
            switch(operador)
            {
                case "+":
                    return num1 + num2;
                case "-":
                    return num1 - num2;
                case "/":
                    if (Validar(num2))
                        return num1 / num2;
                    else
                        Console.WriteLine("no se divide por 0");
                    break;
                case "*":
                    return num1 * num2;
                default:
                    Console.WriteLine("Error en la operacion");
                    break;
            }
            return 0;
        }
        private static bool Validar(double num2)
        {
            return num2 != 0;
        }
    }
}
