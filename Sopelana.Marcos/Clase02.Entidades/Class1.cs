using System;

namespace Clase02.Entidades
{
    public class Sello
    {
        public static ConsoleColor Color;
        public static string mensaje;
        public static string Imprimir()
        {

            Console.WriteLine(ArmarFormatoMensaje());
            return mensaje;
        }
        public static void Borrar()
        {
            mensaje = "";
        }
        public static void ImprimirEnColor()
        {
            Console.ForegroundColor = Color;
            Console.WriteLine(ArmarFormatoMensaje());
            Console.ForegroundColor = ConsoleColor.White;
        }
        private static string ArmarFormatoMensaje()
        {
            
            string techo = "";
            string msg;
            int longitud = Sello.mensaje.Length;
            for(int i = 0; i < longitud + 2 ; i++)
            {
                techo += "*";
            }
            msg = techo + "\n*" + Sello.mensaje + "*\n" + techo;
            return msg;
        }
        
    }
}
