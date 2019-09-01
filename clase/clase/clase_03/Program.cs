using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Conversor;
using Calculador;
/*1. Crear una clase Calculador con las siguientes características:
1. Contendrá un atributo de instancia y privado llamado acumulador : int
Tendrá los siguientes métodos:
    1. Calculador() constructor por defecto, el cual inicializará el acumulador = 0
    2. acumular(string) : void recibirá un binario en formato ASCII y lo acumulará como entero en el atributo acumulador
    3. getResultadoBinario() : string retornará la variable acumulador convertida a binario.
    4. getResultadoEntero() : int retornará la variable acumulador.
2. Siempre que se cargue un binario, deberá realizar la suma en Calculador a través del método acumular.
3. Modificar el Main agregando la opción al menú para mostrar el resultado del cálculo en binario o entero según el usuario lo dedica.
NOTAS:
Reutilizar código siempre.
Utilizar this siempre que correspond*/
namespace clase_03
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
            int option2;
            while (option != 4)
            {
                Console.WriteLine("1 - convertir de binario a entero");
                Console.WriteLine("2 - convertir de entero a binario");
                Console.WriteLine("3 - mostrar acumulado");
                Console.WriteLine("4 - salir");
                option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        Console.WriteLine("ingresar un entero para convertir a binario");
                        num1 = Convert.ToInt32(Console.ReadLine());
                        numConvert1 = Class.EnteroBinario(num1);
                        Calculado.acumular(Convert.ToString(num1));
                        Console.WriteLine("el numero en binario es " + numConvert1);
                        break;
                    case 2:
                        Console.WriteLine("ingresar un binario para convertir a entero");
                        num2 = Console.ReadLine();
                        numConvert2 = Class.BinarioDecimal(num2);
                        Calculado.acumular(Convert.ToString(numConvert2));
                        Console.WriteLine("el numero en entero es " + numConvert2);
                        break;
                    case 3:
                        Console.WriteLine("1 - ver lo acumulado en binario");
                        Console.WriteLine("2 - ver lo acumulado en entero");
                        option2 = Convert.ToInt32(Console.ReadLine());
                        switch (option2)
                        {
                            case 1:
                                Console.WriteLine("el numero acumulado en binario es " + Calculado.getResultadoBinario());
                                break;
                            case 2:
                                Console.WriteLine("el numer(o acumulado en entero es " + Calculado.getResultadoEntero());
                                break;
                            default:
                                Console.WriteLine("el numero es incrrecto");
                                break;
                        }
                        break;
                    case 4:
                        Console.WriteLine("salir");
                        break;
                    default:
                        Console.WriteLine("numero incorrecto");
                        break;
                }
            }
            Console.ReadLine();
        }
    }   
}
