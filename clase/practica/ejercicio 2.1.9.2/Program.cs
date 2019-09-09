using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* Crear un programa que lea una letra tecleada por el usuario y diga si se trata de un signo de puntuación, una cifra numérica o algún otro carácter. */
namespace ejercicio_2._1._9._2
{
    class Program
    {
        static void Main(string[] args)
        {
            char letra;
            Console.WriteLine("eligi una letra");
            letra = Convert.ToChar(Console.ReadLine());
            switch(letra)
            {
                case '0': goto case '9';
                case '1': goto case '9';
                case '2': goto case '9';
                case '3': goto case '9';
                case '4': goto case '9';
                case '5': goto case '9';
                case '6': goto case '9';
                case '7': goto case '9';
                case '8': goto case '9';
                case '9':
                    Console.WriteLine("es un numero");
                    break;
                case ',': goto case ':';
                case ';': goto case ':';
                case '.': goto case ':';
                case ':':
                    Console.WriteLine("es un signo de puntacion");
                   break;
                default:
                    Console.WriteLine("es algun otro caracter");
                    break;
            }
            Console.Read();
        }
    }
}
