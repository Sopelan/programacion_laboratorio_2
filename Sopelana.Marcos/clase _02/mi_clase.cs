using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mi_clase
{
    public class MiClase
    {
        public static string nombre;
        public static int edad;
        public static void MostrarEdad()
        {
            Console.WriteLine("mi edad es {0}", edad);
        }
        public static string RetornarNombre()
        {
            return nombre;
        }
        public static bool CompararNombre(string nombre)
        {
            if(MiClase.nombre == nombre)
            {
                return true;
            }
            return false;
        }
    }
}
