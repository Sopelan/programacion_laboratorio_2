using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*  Crear un programa que use el operador condicional para mostrar un el valor absoluto de un número de la siguiente forma: si el número es positivo, se mostrará tal cual; si es negativo, se mostrará 
    cambiado de signo. */
namespace ejercicio_2._1._8._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("ingrese un numero");
            num = Convert.ToInt32(Console.ReadLine());
            int operador = (num >= 0) ? num:num= num-num-num ;
            Console.WriteLine("el num es: " + num);
            Console.Read();
        }
    }
}
