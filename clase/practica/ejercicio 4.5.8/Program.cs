using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*  Mejorar la base de datos de ficheros (ejemplo 46) para que se pueda modificar un cierto dato a partir de su número (por ejemplo, el dato número 3). En esa modificación, se deberá permitir al usuario pulsar 
 *  Intro sin teclear nada, para indicar que no desea modificar un cierto dato, en vez de reemplazarlo por una cadena vacía. */
namespace ejercicio_4._5._8
{
    class Program
    {
        struct TipoFicha
        {
            public string nombreFich;   /* Nombre del fichero */
            public long tamanyo;        /* El tamaño en KB */
        }
        public static void Main()
        {
            TipoFicha[] fichas   /* Los datos en si */        = new TipoFicha[1000];
            int numeroFichas = 0;  /* Número de fichas que ya tenemos */
            int i;               /* Para bucles */
            int opcion;          /* La opcion del menu que elija el usuario */
            string textoBuscar;  /* Para cuando preguntemos al usuario */
            long tamanyoBuscar;  /* Para buscar por tamaño */
            do
            {       /* Menu principal */
                Console.WriteLine();
                Console.WriteLine("Escoja una opción:");
                Console.WriteLine("1.- Añadir datos de un nuevo fichero");
                Console.WriteLine("2.- Mostrar los nombres de todos los ficheros");
                Console.WriteLine("3.- Mostrar ficheros que sean de mas de un cierto tamaño");
                Console.WriteLine("4.- Ver datos de un fichero");
                Console.WriteLine("5.- Contiene");
                Console.WriteLine("6.- Borrar");
                Console.WriteLine("7.- Modificar");
                Console.WriteLine("8.- Salir");
                opcion = Convert.ToInt32(Console.ReadLine());       /* Hacemos una cosa u otra según la opción escogida */
                switch (opcion)
                {
                    case 1: /* Añadir un dato nuevo */
                        if (numeroFichas < 1000)
                        {  /* Si queda hueco */
                            Console.WriteLine("Introduce el nombre del fichero: ");
                            fichas[numeroFichas].nombreFich = Console.ReadLine();
                            while (fichas[numeroFichas].nombreFich == "")
                            {
                                Console.WriteLine("espacio vacio");
                                Console.WriteLine("Introduce nuevamente el nombre del fichero: ");
                                fichas[numeroFichas].nombreFich = Console.ReadLine();
                            }
                            Console.WriteLine("Introduce el tamaño en KB: ");
                            fichas[numeroFichas].tamanyo = Convert.ToInt32(Console.ReadLine());              /* Y ya tenemos una ficha más */
                            while (fichas[numeroFichas].tamanyo < 0)
                            {
                                Console.WriteLine("error de tamaño");
                                Console.WriteLine("Introduce nuevamente el tamaño en KB: ");
                                fichas[numeroFichas].tamanyo = Convert.ToInt32(Console.ReadLine());
                            }
                            numeroFichas++;
                        }
                        else   /* Si no hay hueco para más fichas, avisamos */
                            Console.WriteLine("Máximo de fichas alcanzado (1000)!");
                        break;
                    case 2: /* Mostrar todos */
                        for (i = 0; i < numeroFichas; i++)
                            Console.WriteLine("Nombre: {0} Tamaño: {1} KB", fichas[i].nombreFich, fichas[i].tamanyo);
                        break;
                    case 3: /* Mostrar según el tamaño */
                        Console.WriteLine("¿A partir de que tamaño quieres que te muestre?");
                        tamanyoBuscar = Convert.ToInt64(Console.ReadLine());
                        for (i = 0; i < numeroFichas; i++)
                            if (fichas[i].tamanyo >= tamanyoBuscar)
                                Console.WriteLine("Nombre: {0} Tamaño: {1} KB", fichas[i].nombreFich, fichas[i].tamanyo);
                        break;
                    case 4: /* Ver todos los datos (pocos) de un fichero */
                        Console.WriteLine("¿De qué fichero quieres ver todos los datos?");
                        textoBuscar = Console.ReadLine();
                        for (i = 0; i < numeroFichas; i++)
                            if (fichas[i].nombreFich == textoBuscar)
                                Console.WriteLine("Nombre: {0} Tamaño: {1} KB", fichas[i].nombreFich, fichas[i].tamanyo);
                        break;
                    case 5:
                        Console.WriteLine("5.- Contiene");
                        string contiene = Console.ReadLine();
                        string con = "" + contiene;
                        while (contiene != "")
                        {
                            for (i = 0; i < numeroFichas; i++)
                                if (fichas[i].nombreFich.ToLower().Contains(con.ToLower()))
                                    Console.WriteLine("Nombre: {0} Tamaño: {1} KB", fichas[i].nombreFich, fichas[i].tamanyo);
                            contiene = Console.ReadLine();
                            con += contiene;
                        }
                        break;
                    case 6:
                        Console.WriteLine("6.- Borrar");
                        Console.WriteLine("fichero queres eliminar");
                        for (i = 0; i < numeroFichas; i++)
                            Console.WriteLine("Id: {2} Nombre: {0} Tamaño: {1} KB", fichas[i].nombreFich, fichas[i].tamanyo, i + 1);
                        int eliminar = Convert.ToInt32(Console.ReadLine());
                        eliminar--;
                        for (i = eliminar; i < numeroFichas; i++)
                        {
                            fichas[i] = fichas[i + 1];
                        }
                        numeroFichas--;
                        break;
                    case 7:
                        Console.WriteLine("7.- Modificar");
                        Console.WriteLine("fichero queres eliminar");
                        for (i = 0; i < numeroFichas; i++)
                            Console.WriteLine("Id: {2} Nombre: {0} Tamaño: {1} KB", fichas[i].nombreFich, fichas[i].tamanyo, i + 1);
                        int buscar = Convert.ToInt32(Console.ReadLine());
                        buscar--;
                        TipoFicha ficha = new TipoFicha();
                        Console.WriteLine("Introduce el nombre del fichero: ");
                        ficha.nombreFich = Console.ReadLine();
                        while (ficha.nombreFich == "")
                        {
                            ficha.nombreFich = fichas[buscar].nombreFich;
                        }
                        Console.WriteLine("Introduce el tamaño en KB: ");
                        ficha.tamanyo = Convert.ToInt32(Console.ReadLine());              /* Y ya tenemos una ficha más */
                        while (ficha.tamanyo < 0)
                        {
                            ficha.tamanyo = fichas[buscar].tamanyo; 
                        }
                        fichas[buscar] = ficha;
                        break;
                    case 8: /* Salir: avisamos de que salimos */
                        Console.WriteLine("Fin del programa");
                        break;
                    
                    default: /* Otra opcion: no válida */
                        Console.WriteLine("Opción desconocida!");
                        break;
                }
            } while (opcion != 8);  /* Si la opcion es 5, terminamos */
        }
    }
}
