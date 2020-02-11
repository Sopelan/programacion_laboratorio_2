using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Mejorar el programa del ahorcado (4.4.8.3), para que la palabra a adivinar no sea tecleado por un segundo usuario, sino que se escoja al azar de un "array" de palabras prefijadas (por ejemplo, nombres de ciudades).
namespace ejercicio_5._9._1._2
{
    class Program
    {
        static void Main(string[] args)
        {
            int intentos = 8;
            string Adivinar;
            string[] equipo = {"independiente","river","boca","racing","estudiantes","lanus","velez","patronato","defensa y justicia","gimnasia","aldosivi","central cordoba","arsenal","godoy cruz","colon","san lorenzo","banfield","argentinos","newels","union","atletico tucuman","talleres","rosario central","huracan" };
            StringBuilder palabra = new StringBuilder();
            char adi;
            Console.WriteLine("ingrese la palabra al adivinar");
            Adivinar = equipo[new Random().Next(1,equipo.Length)-1];
            for (int i = 0; i < Adivinar.Length; i++)
            {
                palabra.Append('-');
            }
            Console.Clear();
            while (Adivinar != palabra.ToString())
            {
                if (intentos == 0)
                {
                    Console.WriteLine("Te quedaste sin intentos");
                    break;
                }
                Console.WriteLine(palabra);
                Console.WriteLine("ingrese letra o palabra que puede estar ahi");
                try
                {
                    adi = Convert.ToChar(Console.ReadLine());
                }
                catch (Exception exception)
                {
                    Console.WriteLine("se te resta un punto por " + exception.Message);
                    intentos--;
                    Console.WriteLine("te quedan {0} intentos", intentos);
                    continue;
                }
                bool flag = false;
                for (int i = 0; i < Adivinar.Length; i++)
                {
                    if (Adivinar[i] == adi)
                    {
                        flag = true;
                        palabra[i] = adi;
                    }
                }
                Console.Clear();
                if (flag == false)
                {
                    intentos -= 1;
                    Console.WriteLine("la erraste\n se te ha restado un intento");
                    Console.WriteLine("te quedan {0} intentos", intentos);
                }
            }
            if (intentos == 0)
            {
                Console.WriteLine("perdiste");
                Console.WriteLine("la palabra era " + Adivinar);
            }
            else
            {
                Console.WriteLine("ganaste");
                Console.WriteLine("adivinaste la palabra que es " + Adivinar);
            }
            Console.Read();
        }
    }
}
