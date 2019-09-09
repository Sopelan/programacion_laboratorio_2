using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*  Crear un programa que lea una letra tecleada por el usuario y diga si se trata de una vocal, una cifra numérica o una consonante (pista: habrá que usar un dato de tipo "char"). */
namespace ejercicio_2._1._9._1
{
    class Program
    {
        static void Main(string[] args)
        {
            char letra;
            Console.WriteLine("elige una letra");
            letra = Convert.ToChar(Console.ReadLine());
            switch(letra)
            {
                case 'a': goto case 'u';
                case 'e': goto case 'u';
                case 'i': goto case 'u';
                case 'o': goto case 'u';
                case 'u':
                    Console.WriteLine("es una vocal");
                    break;
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
                case 'b': goto case 'z';
                case 'c': goto case 'z';
                case 'd': goto case 'z';
                case 'f': goto case 'z';
                case 'g': goto case 'z';
                case 'h': goto case 'z';
                case 'j': goto case 'z';
                case 'k': goto case 'z';
                case 'l': goto case 'z';
                case 'm': goto case 'z';
                case 'n': goto case 'z';
                case 'p': goto case 'z';
                case 'q': goto case 'z';
                case 'r': goto case 'z';
                case 's': goto case 'z';
                case 't': goto case 'z';
                case 'v': goto case 'z';
                case 'w': goto case 'z';
                case 'x': goto case 'z';
                case 'y': goto case 'z';
                case 'z':
                    Console.WriteLine("es una consonante");
                    break;
                default:
                    Console.WriteLine("no es un numero , ni una vocal ni una consonante");
                    break;
               
            }
            Console.ReadLine();
        }
    }
}
