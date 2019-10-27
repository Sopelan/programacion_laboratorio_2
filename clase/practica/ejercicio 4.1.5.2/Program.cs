using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* Un programa que prepare espacio para un máximo de 10 nombres. Deberá mostrar al usuario un menú que le permita realizar las siguientes 
operaciones:
o Añadir un dato al final de los ya existentes.
o Insertar un dato en una cierta posición (como ya se ha comentado, los que quedén detrás deberán desplazarse "a la derecha" para dejarle hueco;
por ejemplo, si el array contiene "hola", "adios" y se pide insertar "bien" en la segunda posición, el array pasará a contener "hola", "bien", 
"adios".
o Borrar el dato que hay en una cierta posición (como se ha visto, lo que estaban detrás deberán desplazarse "a la izquierda" para que no haya
huecos; por ejemplo, si el array contiene "hola", "bien", "adios" y se pide borrar el dato de la segunda posición, el array pasará a contener 
"hola", "adios"
o Mostrar los datos que contiene el array.
o Salir del programa.*/
namespace ejercicio_4._1._5._2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] num = new int[10];
            int cantidad = 0;
            int espacio = 0;
            int opcion;
            while(true)
            {
                Console.WriteLine("1.añadir\n2.Borrar\n3.borrar de una cierta posicion\n4.Mostrar\5.Salir");
                opcion = Convert.ToInt32(Console.ReadLine());
                switch (opcion)
                {
                    case 1:

                        break;
                }
            }
        }
    }
}
