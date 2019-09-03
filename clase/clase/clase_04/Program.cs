using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculador;
using Conversor;
/* Tomar como base la clase 3 [DESCARGAR]
1. Agregar los siguientes métodos 
    1. acumular(int) : void recibirá un entero y lo acumulará en acumulador 
    2. Calculador (int) inicializará el acumulador con el valor recibido 
    3. Calculador (string) inicializará el acumulador con el valor recibido. Este constructor no contendrá código y llamará al constructor del punto b. 
2. Modificar el Main 
    1. Siempre que se cargue un nuevo valor, deberá realizar la suma en Calculador. */
namespace clase_04
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
            Calculado c;
            c = new Calculado();
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
                        c.acumular(Convert.ToString(num1));
                        Console.WriteLine("el numero en binario es " + numConvert1);
                        break;
                    case 2:
                        Console.WriteLine("ingresar un binario para convertir a entero");
                        num2 = Console.ReadLine();
                        numConvert2 = Class.BinarioDecimal(num2);
                        c.acumular(Convert.ToString(numConvert2));
                        Console.WriteLine("el numero en entero es " + numConvert2);
                        break;
                    case 3:
                        Console.WriteLine("1 - ver lo acumulado en binario");
                        Console.WriteLine("2 - ver lo acumulado en entero");
                        option2 = Convert.ToInt32(Console.ReadLine());
                        switch (option2)
                        {
                            case 1:
                                Console.WriteLine("el numero acumulado en binario es " + c.getResultadoBinario());
                                break;
                            case 2:
                                Console.WriteLine("el numer(o acumulado en entero es " + c.getResultadoEntero());
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
