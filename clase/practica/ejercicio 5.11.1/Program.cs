using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* Crear un programa llamado "suma", que calcule (y muestre) la suma de dos números que se le indiquen como parámetro.  Por ejemplo, si se teclea "suma 2 3" deberá responder "5", y si se teclea "suma 2" deberá responder "no hay suficientes datos y 
   devolver un código de error 1. */
namespace ejercicio_5._11._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Suma();
            Console.ReadLine(); 
        }
        static int Suma()
        {
            Console.WriteLine("Ingrese la suma");
            int x;
            bool bandera = false;
            bool bandera2 = false;
            string numero = "";
            string numero2 = "";
            bool bandera3 = false;
            string suma = Console.ReadLine();
            suma += ' ';
            for (int i = 0; i < suma.Length;i++)
            {     
                if (suma[i] == 's')
                {
                    x = i;
                    if (suma[x + 1] == 'u' && suma[x + 2] == 'm' && suma[x + 3] == 'a')
                        bandera = true;
                }
                
                if (bandera2)
                {
                    if (char.IsNumber(suma[i]) && bandera == false)
                    {
                        numero2 += suma[i];
                        if (suma[i + 1] == ' ')
                        {
                            bandera3 = true;
                            bandera2 = false;
                        }
                    }
                }
                if (bandera)
                {
                    if (char.IsNumber(suma[i]) && bandera2 == false)
                    {
                        numero += suma[i];
                        if (suma[i + 1] == ' ')
                        {
                            bandera2 = true;
                            bandera = false;
                        }
                    }
                }


            }
            bool flag = int.TryParse(numero, out int num1);
            bool flag2 = int.TryParse(numero2, out int num2);
            if (flag && flag2)
            {
                Console.WriteLine("La suma entre {0} y {1} es {2}", num1, num2, num1 + num2);
                return num1 + num2;
            } 
            else
            {
                Console.WriteLine("no hay suficientes datos y devolver un código de error 1");
                Environment.Exit(1);
            }
            return 0;
        }
    }
}
