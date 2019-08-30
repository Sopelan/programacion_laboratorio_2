using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Conversor;
/* 2. El en Main generar un menú para que el usuario elija que tipo de conversión desea realizar o si desea salir del programa. 
      Luego de elegir una opción, le deberá pedir que ingrese el número a convertir y mostrarle el resultado por pantalla; al presionar cualquier tecla retornar al menu. */
namespace clase_02
{
    class Program
    {
        static void Main(string[] args)
        {
            int option = 1;
            int num1;
            string num2;
            string numConvert1;
            double numConvert2;
            while(option != 3)
            {
                Console.WriteLine("1 - convertir de binario a entero");
                Console.WriteLine("2 - convertir de entero a binario");
                Console.WriteLine("3 - salir");
                option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        Console.WriteLine("ingresar un entero para convertir a binario");
                        num1 = Convert.ToInt32(Console.ReadLine());
                        numConvert1 = Class.EnteroBinario(num1);
                        Console.WriteLine("el numero en binario es " + numConvert1);
                        break;
                    case 2:
                        Console.WriteLine("ingresar un binario para convertir a entero");
                        num2 = Console.ReadLine();
                        numConvert2 = Class.BinarioDecimal(num2);
                        Console.WriteLine("el numero en entero es " + numConvert2);
                        break;
                    case 3:
                        Console.WriteLine("salir");
                        break;
                    default:
                        Console.WriteLine("numero incorrecto");
                        break;
                }

            }
            Console.Read();
        }
    }
}
