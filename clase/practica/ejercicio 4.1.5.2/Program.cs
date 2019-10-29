using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* Un programa que prepare espacio para un máximo de 10 nombres. Deberá mostrar al usuario un menú que le permita realizar las siguientes operaciones:
o Añadir un dato al final de los ya existentes.
o Insertar un dato en una cierta posición (como ya se ha comentado, los que quedén detrás deberán desplazarse "a la derecha" para dejarle hueco; por ejemplo, si el array contiene "hola", "adios" 
  y se pide insertar "bien" en la segunda posición, el array pasará a contener "hola", "bien", "adios".
o Borrar el dato que hay en una cierta posición (como se ha visto, lo que estaban detrás deberán desplazarse "a la izquierda" para que no hay huecos; por ejemplo, si el array contiene "hola", "bien",
  "adios" y se pide borrar el dato de la segunda posición, el array pasará a contener "hola", "adios"
o Mostrar los datos que contiene el array.
o Salir del programa.*/
namespace ejercicio_4._1._5._2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nombres = new string[10];
            string nombre;
            int cantidad = 10;
            int espacio = 0;
            int opcion = 0;
            int posicion;
            while(opcion != 5)
            {
                Console.ReadLine();
                Console.Clear();
                Console.WriteLine("1.añadir\n2.añadir en una cierta posicion\n3.borrar de una cierta posicion\n4.Mostrar\n5.Salir");
                opcion = Convert.ToInt32(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("1.añadir");
                        if (cantidad > espacio)
                        {
                            Console.WriteLine("Ingrese el nombre que quiere añadir");
                            nombres[espacio] = Console.ReadLine();
                            espacio++;
                        }
                        else
                            Console.WriteLine("no hay espacio suficiente");
                        break;
                    case 2:
                        Console.WriteLine("2.añadir en una cierta posicion");
                        if (cantidad > espacio)
                        {
                            Console.WriteLine("Ingrese el nombre que quiere añadir");
                            nombre = Console.ReadLine();
                            Console.WriteLine("eligi la posicion que queres guardar");
                            posicion = Convert.ToInt32(Console.ReadLine());
                            if (posicion - 1 < espacio && posicion > 0)
                            {
                                for (int i = posicion - 1; i < espacio; i++)
                                    nombres[i + 1] = nombres[i];
                                nombres[posicion - 1] = nombre;
                                espacio++;
                            }
                            else if (posicion - 1 >= espacio && posicion < cantidad)
                            {
                                nombres[espacio] = nombre;
                                espacio++;
                            }
                            else
                                Console.WriteLine("no se puede guardar el nombre en esa posicion");
                            
                        }
                        else
                            Console.WriteLine("no hay espacio suficiente");
                        break;
                    case 3:
                        Console.WriteLine("3.borrar en una cierta posicion");
                        if (espacio != 0)
                        {
                            Console.WriteLine("ingresar la posicion que quiere borrar");
                            posicion = Convert.ToInt32(Console.ReadLine());
                            if (posicion - 1 < espacio && posicion > 0)
                            {
                                nombres[posicion -1] = "";
                                for (int i = posicion - 1; i < espacio; i++)
                                    nombres[i] = nombres[i + 1];
                                espacio--;
                            }
                            else
                                Console.WriteLine("no hay nada en esa posicion");
                        }
                        else
                            Console.WriteLine("no hay nada");
                        break;
                    case 4:
                        Console.WriteLine("4.mostrar");
                        if(espacio != 0)
                        {
                            Console.WriteLine("listado de nombres");
                            for (int i = 0; i < espacio; i++)
                                Console.WriteLine("nombre {0}: {1}", i + 1, nombres[i]);  
                        }
                        else
                            Console.WriteLine("no hay nada");
                        break;
                    case 5:
                        Console.WriteLine("5.salir");
                        break;
                    default:
                        Console.WriteLine("tiene que estar entre 1 y 5");
                        break;
                        
                }

            }
        }
    }
}
