using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//  Crear un programa que genere un número al azar entre 1 y 100. El usuario tendrá 6 oportunidades para acertarlo. 
namespace ejercicio_5._9._1._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int oportunidades = 6;
            int numeroABuscar = new Random().Next(1, 100);
            int numero;
            Console.WriteLine("adivina el numero del 1 al 100");
            while (true)
            {
                if(oportunidades == 0)
                {
                    Console.WriteLine("Perdiste y el numero era " + numeroABuscar);
                    break;
                }
                Console.WriteLine("ingresa el numero");
                int.TryParse(Console.ReadLine(), out numero);
                if (numero == numeroABuscar)
                {
                    Console.WriteLine("Ganaste");
                    break;
                }
                else
                {
                    Console.WriteLine("Ese no es intenta devuelta");
                    oportunidades--;
                }
                Console.WriteLine("le quedan {0} intentos ", oportunidades);
            }
            Console.ReadLine();
        }
    }
}
