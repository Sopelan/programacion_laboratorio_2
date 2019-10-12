using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* Crear un programa que pida al usuario a una distancia (en metros) y el
tiempo necesario para recorrerla (como tres números: horas, minutos, segundos), y
muestre la velocidad, en metros por segundo, en kilómetros por hora y en millas por
hora (pista: 1 milla = 1.609 metros).*/
namespace ejercicio_3._2._2._2
{
    class Program
    {
        static void Main(string[] args)
        { 
            float distancia;
            int hora;
            int minutos;
            int segundos;
            float milla;
            Console.WriteLine("ingrese a distancia en metros");
            distancia = float.Parse(Console.ReadLine());
            Console.WriteLine("ingrese la hora");
            hora = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("ingrese los minutos");
            minutos = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("ingrese segundo");
            segundos = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("la velocidad:");
            int segundo = (hora * 60 * 60) + (minutos * 60) + segundos;
            int horas = (minutos / 60) + hora + (segundo / 60 /60);
            Console.WriteLine("en metros por segundo: {0}", distancia * segundo);
            Console.WriteLine("en kilometros por hora: {0}", distancia * horas / 1000);
            milla = distancia * 1.609f;
            Console.WriteLine("en milla por hora: {0}", milla * horas);
            Console.Read();




        }
    }
}
