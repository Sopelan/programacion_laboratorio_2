using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_17.Entidades
{
    public class Boligrafo
    {
        public const short cantidadTintaMaxima = 100;
        private ConsoleColor color;
        private short tinta;

        public Boligrafo(short tinta , ConsoleColor color)
        {
            this.SetTinta(tinta);
            this.color = color;
        }

        public ConsoleColor GetColor()
        {
            return this.color;
        }
        public short GetTinta()
        {
            return this.tinta;
        }
        public bool Pintar(int gasto, out string dibujo)
        {
            if(gasto <= tinta)
            {
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < gasto; i++)
                    sb.Append("*");
                dibujo = sb.ToString();
                this.tinta-= (short)gasto;
                return true;
            }
            else
            {
                Console.WriteLine("no se pudo gastar de mas");
                dibujo = "";
                return false;
            }
        }
        public void Recargar()
        {
            this.SetTinta(cantidadTintaMaxima);
        }
        private void SetTinta(short tinta)
        {
            short tint = this.tinta;
            tint += tinta;
            if (tint > cantidadTintaMaxima)
                this.tinta = cantidadTintaMaxima;
            else if (tinta < 0)
                this.tinta = 0;
            else
                this.tinta = tint;      
        }

    }
}
