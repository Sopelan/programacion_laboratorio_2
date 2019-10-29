using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* Un programa que permita guardar datos de "imágenes" (ficheros de ordenador que contengan fotografías o cualquier otro tipo de información gráfica). De cada imagen se debe guardar: nombre 
 * (texto), ancho en píxeles (por ejemplo 2000), alto en píxeles (por ejemplo, 3000), tamaño en Kb (por ejemplo 145,6). El programa debe ser capaz de almacenar hasta 700 imágenes (deberá avisar
 * cuando su capacidad esté llena). Debe permitir las opciones: añadir una ficha nueva, ver todas las fichas (número y nombre de cada imagen), buscar la ficha que tenga un cierto nombre. */
namespace ejercicio_4._3._2._2
{
    class Program
    {
        struct Imagen
        {
            public string nombre;
            public int anchoEnPixeles;
            public int altoEnPixeles;
            public float tamañoEnKb;
        }
        static void Main(string[] args)
        {
            Imagen[] imagenes = new Imagen[700];
            int espacio = 700;
            int cantidad = 0;
            int option = new int();
            while(option != 4)
            {
                try
                {

                    Console.ReadLine();
                    Console.Clear();
                    Console.WriteLine("1.Añadir una ficha nueva\n2.Ver todas las fichas (número y nombre de cada imagen)\n3.Buscar la ficha que tenga un cierto nombre\n4.Salir");
                    option = Convert.ToInt32(Console.ReadLine());
                    switch(option)
                    {
                        case 1:
                            Console.WriteLine("1.Añadir una ficha nueva");
                            if (espacio > cantidad)
                            {
                                Imagen imagen = new Imagen();
                                Console.WriteLine("ingresa el nombre de la imagen");
                                imagen.nombre = Console.ReadLine();
                                Console.WriteLine("ingrese el ancho en pixeles");
                                imagen.anchoEnPixeles = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine("ingrese el alto en pixeles");
                                imagen.altoEnPixeles = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine("ingrese el tamaño en kb");
                                imagen.tamañoEnKb = Convert.ToSingle(Console.ReadLine());
                                imagenes[cantidad] = imagen;
                                cantidad++;
                            }
                            else
                                Console.WriteLine("no hay espacio suficiente");
                            break;
                        case 2:
                            Console.WriteLine("2.Ver todas las fichas (número y nombre de cada imagen)");
                            if (cantidad != 0)
                            {
                                Console.WriteLine("{0,10}{1,10}{2,10}{3,20}{4,20}","indice","nombre","tamaño","ancho en pixeles","alto en pixeles");
                                for (int i = 0; i < cantidad; i++)
                                    Console.WriteLine("{0,10}{1,10}{2,10}{3,20}{4,20}", i + 1, imagenes[i].nombre, imagenes[i].tamañoEnKb, imagenes[i].anchoEnPixeles, imagenes[i].altoEnPixeles);
                            }
                            else
                                Console.WriteLine("no hay ninguna imagen introducida");
                            break;
                        case 3:
                            Console.WriteLine("3.Buscar la ficha que tenga un cierto nombre");
                            if (cantidad != 0)
                            {
                                bool flag = false;
                                Console.WriteLine("ingrese el nombre de la imagen que buscar");
                                string buscar = Console.ReadLine();
                                Console.WriteLine("{0,10}-{1,10}-{2,10}-{3,10}-{4,10}", "indice", "nombre", "tamaño", "ancho en pixeles", "alto en pixeles");
                                for (int i = 0; i< cantidad;i++)
                                {
                                    if (imagenes[i].nombre == buscar)
                                    {
                                        Console.WriteLine("{0,10}-{1,10}-{2,10}-{3,10}-{4,10}", i + 1, imagenes[i].nombre, imagenes[i].tamañoEnKb, imagenes[i].anchoEnPixeles, imagenes[i].altoEnPixeles);
                                        flag = true;
                                    }
                                }
                                if (flag == false)
                                    Console.WriteLine("no se encontro nada");
                            }
                            else
                                Console.WriteLine("no hay ninguna imagen introducida");
                            break;
                        case 4:
                            Console.WriteLine("4.Salir");
                            break;
                        default:
                            Console.WriteLine("tiene que estar entre 1 y 4");
                            break;
                    }
                }
                catch(Exception exepcion)
                {
                    Console.WriteLine(exepcion.Message);
                }
                
            }
        }
    }
}
