using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Crea un programa para mostar los números del 0 a 255 en hexadecimal, en 16 filas de 16 columnas cada una (la primera fila contendrá los números del 0 al 15 – decimal-, la segunda del 16 al 31 –decimal- y así sucesivamente). 
namespace ejercicio_3._2._4._3
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            StringBuilder sb2 = new StringBuilder();
            for (int i = 0; i <= 15;i++)
            {
                
                for (int j = 0;j <= 15; j++)
                {
                    int num;

                    if (i == 0)
                    {
                        sb.Append(j.ToString("000")+ " ");
                    }
                    else
                    {
                        num = 16 * i + j;
                        sb.Append(num.ToString("000") + " ");
                    }

                }
                for(int j = 0; j <= 15; j++)
                {
                int num;

                    if (i == 0)
                    {
                        string s = (Convert.ToString(j, 16));
                        sb.Append(0 + s + " ");
                    }
                    else
                    {
                        num = 16 * i + j;
                        sb.Append(Convert.ToString(num, 16)+ " ");
                    }

            }
            sb.AppendLine();
            }
            Console.WriteLine(sb);
            Console.Read();
        }
    }
}
