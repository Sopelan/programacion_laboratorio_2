using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*  Crear un juego del ahorcado, en el que un primer usuario introduzca la palabra a adivinar, se muestre esta programa oculta con guiones (-----) y el programa acepte las letras que introduzca el segundo usuario, cambiando los guiones por letras correctas cada vez 
 *  que acierte (por ejemplo, a---a-t-). La partida terminará cuando se acierte la palabra por completo o el usuario agote sus 8 intentos. */
namespace ejercicio_4._4._8._3
{
    class Program
    {
        static void Main(string[] args)
        {
            int intentos = 8;
            string Adivinar;
            StringBuilder palabra = new StringBuilder();
            char adi;
            Console.WriteLine("ingrese la palabra al adivinar");
            Adivinar = Console.ReadLine();
            for(int i = 0;i< Adivinar.Length; i++)
            {
                palabra.Append('-');
            }
            Console.Clear();
            while(Adivinar != palabra.ToString())
            {
                if(intentos == 0)
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
                catch(Exception exception)
                {
                    Console.WriteLine("se te resta un punto por " + exception.Message);
                    intentos--;
                    Console.WriteLine("te quedan {0} intentos" , intentos);
                    continue;
                }
                bool flag = false;
                for (int i = 0; i < Adivinar.Length; i++)
                {
                    if(Adivinar[i] == adi)
                    {
                        flag = true;
                        palabra[i] = adi;
                    }
                }
                Console.Clear();
                if(flag == false)
                {
                    intentos -= 1;
                    Console.WriteLine("la erraste\n se te ha restado un intento");
                    Console.WriteLine("te quedan {0} intentos" , intentos);
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
