using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*  Amplía el ejemplo anterior (36b) para que avise si el dato buscado no aparece. */
namespace ejercicio_4._1._5._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dato = { 10, 15, 12, 0, 0 };

            int capacidad = 5; // Capacidad maxima del array
            int cantidad = 3; // Número real de datos guardados

            int i; // Para recorrer los elementos

            bool flag = false;
            // Mostramos el array
            for (i = 0; i < cantidad; i++)
                Console.Write("{0} ", dato[i]);
            Console.WriteLine();

            // Buscamos el dato "15"
            for (i = 0; i < cantidad; i++)
            {
                if (dato[i] == 15)
                {
                     Console.WriteLine("15 encontrado en la posición {0} ", i + 1);
                    flag = true;
                }  
            }
            if (flag == false)
            {
                Console.WriteLine("no fue encontrado");
            }
                

                
                

            // Añadimos un dato al final
            Console.WriteLine("Añadiendo 6 al final");
            if (cantidad < capacidad)
            {
                dato[cantidad] = 6;
                cantidad++;
            }

            // Y volvemos a mostrar el array
            for (i = 0; i < cantidad; i++)
                Console.Write("{0} ", dato[i]);
            Console.WriteLine();
            // Borramos el segundo dato
            Console.WriteLine("Borrando el segundo dato");
            int posicionBorrar = 1;
            for (i = posicionBorrar; i < cantidad - 1; i++)
                dato[i] = dato[i + 1];
            cantidad--;

            // Y volvemos a mostrar el array
            for (i = 0; i < cantidad; i++)
                Console.Write("{0} ", dato[i]);
            Console.WriteLine();

            // Insertamos 30 en la tercera posición
            if (cantidad < capacidad)
            {
                Console.WriteLine("Insertando 30 en la posición 3");
                int posicionInsertar = 2;
                for (i = cantidad; i > posicionInsertar; i--)
                    dato[i] = dato[i - 1];
                dato[posicionInsertar] = 30;
                cantidad++;
            }

            // Y volvemos a mostrar el array
            for (i = 0; i < cantidad; i++)
                Console.Write("{0} ", dato[i]);
            Console.WriteLine();
            Console.Read();
        }
    }
}
