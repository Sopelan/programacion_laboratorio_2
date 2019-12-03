using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* Un programa que sea capaz de almacenar los datos de 50 personas: nombre, dirección, teléfono, edad (usando una tabla de structs). Deberá ir pidiendo los datos uno por uno, hasta que un nombre se introduzca vacío 
 * (se pulse Intro sin teclear nada). Entonces deberá aparecer un menú que permita: 
 * o Mostrar la lista de todos los nombres. 
 * o Mostrar las personas de una cierta edad. 
 * o Mostrar las personas cuya inicial sea la que el usuario indique. 
 * o Salir del programa 
 * (lógicamente, este menú debe repetirse hasta que se escoja la opción de "salir"). */
namespace ejercicio_4._5._3
{
    class Program
    {
        public struct Persona
        {
            public string nombre;
            public string direccion;
            public int telefono;
            public int edad;
        }
        static void Main(string[] args)
        {
            Persona[] personas = new Persona[50];
            int cantidad = 0;
            int option = 0;
            int ciertaEdad;
            string cuyaInicial;
            for(int i = 0;  i < 50; i++)
            {
                try
                {
                    Console.WriteLine("ingrese el nombre de la persona {0}", i + 1);
                    personas[i].nombre = Console.ReadLine();
                    if (personas[i].nombre == "")
                    {
                        break;
                    }
                    Console.WriteLine("ingrese la direccion de la persona {0}", i + 1);
                    personas[i].direccion = Console.ReadLine();
                    Console.WriteLine("ingrese el telefono de la persona {0}", i + 1);
                    personas[i].telefono = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("ingrese la edad de la persona {0}", i + 1);
                    personas[i].edad = Convert.ToInt32(Console.ReadLine());
                    cantidad++;
                }
                catch(Exception e)
                {
                    Console.WriteLine("error: " + e.Message);
                    i--;
                }
            }
            while(option != 4)
            {
                Console.WriteLine("1.Mostrar la lista de todos los nombres.");
                Console.WriteLine("2.Mostrar las personas de una cierta edad.");
                Console.WriteLine("3.Mostrar las personas cuya inicial sea la que el usuario indique.");
                Console.WriteLine("4.Salir del programa");
                try
                {
                    option = Convert.ToInt32(Console.ReadLine());
                }
                catch
                {
                    option = 5;
                }
                switch (option)
                {
                    case 1:
                        Console.WriteLine("1.Mostrar la lista de todos los nombres.");
                        for (int i = 0; i < cantidad; i++)
                        {
                            Console.WriteLine("Persona " + (i + 1));
                            Console.WriteLine("nombre: " + personas[i].nombre);
                            Console.WriteLine("direccion: " + personas[i].direccion);
                            Console.WriteLine("telefono: " + personas[i].telefono);
                            Console.WriteLine("edad: " + personas[i].edad);
                        }
                        break;
                    case 2:
                        Console.WriteLine("2.Mostrar las personas de una cierta edad.");
                        Console.WriteLine("ingrese la edad a buscar");
                        try
                        {
                            ciertaEdad = Convert.ToInt32(Console.ReadLine());
                        }
                        catch(Exception Message)
                        {
                            Console.WriteLine(Message.Message);
                            break;
                        }
                        for (int i = 0; i < cantidad; i++)
                        {
                            if(personas[i].edad == ciertaEdad)
                            {
                                Console.WriteLine("Persona " + (i + 1));
                                Console.WriteLine("nombre: " + personas[i].nombre);
                                Console.WriteLine("direccion: " + personas[i].direccion);
                                Console.WriteLine("telefono: " + personas[i].telefono);
                                Console.WriteLine("edad: " + personas[i].edad);
                            }
                        }
                        break;
                    case 3:
                        Console.WriteLine("3.Mostrar las personas cuya inicial sea la que el usuario indique.");
                        Console.WriteLine("ingrese la inicial a buscar");
                        cuyaInicial = Console.ReadLine();
                        for (int i = 0; i < cantidad; i++)
                        {
                            if (personas[i].nombre.IndexOf(cuyaInicial) == 0)
                            {
                                Console.WriteLine("Persona " + (i + 1));
                                Console.WriteLine("nombre: " + personas[i].nombre);
                                Console.WriteLine("direccion: " + personas[i].direccion);
                                Console.WriteLine("telefono: " + personas[i].telefono);
                                Console.WriteLine("edad: " + personas[i].edad);
                            }
                        }
                        break;
                    case 4:
                        Console.WriteLine("4.Salir del programa");
                        break;
                    default:
                        Console.WriteLine("Error");
                        break;

                }
            }
            
        }
    }
}
