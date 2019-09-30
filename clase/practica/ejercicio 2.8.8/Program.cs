using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*  Crear un programa que devuelva el cambio de una compra, utilizando monedas (o billetes) del mayor valor posible. Supondremos que tenemos una cantidad ilimitada de monedas (o billetes) de 100, 50, 20, 10, 5, 2 y 1, y que no hay 
 *  decimales. La ejecución podría ser algo como:  
Precio? 44 
Pagado? 100 
Su cambio es de 56: 50 5 1  
Precio? 1 
Pagado? 100 
Su cambio es de 99: 50 20 20 5 2 2 */
namespace ejercicio_2._8._8
{
    class Program
    {
        static void Main(string[] args)
        {
            int precio;
            int pagado;
            int vuelto;
            int cambio;
            Console.Write("Precio?");
            precio = Convert.ToInt32(Console.ReadLine());
            Console.Write("Pagado?");
            pagado = Convert.ToInt32(Console.ReadLine());
            vuelto = pagado - precio;
            Console.Write("su cambio es de {0}:", vuelto);
            while (vuelto > 0)
            {
                if (vuelto >= 5 && vuelto < 10)
                    cambio = 5;
                else if (vuelto >= 10 && vuelto < 20)
                    cambio = 10;
                else if (vuelto >= 20 && vuelto < 50)
                    cambio = 20;
                else if (vuelto >= 2 && vuelto < 5)
                    cambio = 2;
                else if (vuelto >= 50 && vuelto < 100)
                    cambio = 50;
                else if (vuelto == 1)
                    cambio = 1;
                else
                    cambio = 100;
                if(vuelto >= cambio)
                {
                    vuelto -= cambio;
                    Console.Write(" " + cambio);
                }
            }
            Console.Read();
        }
    }
}
