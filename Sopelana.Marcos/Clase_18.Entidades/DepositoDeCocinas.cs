using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_18.Entidades
{
    public class DepositoDeCocinas
    {
        private int _capacidadMaxima;
        private List<Cocina> _lista;

        public DepositoDeCocinas(int capacidad)
        {
            this._capacidadMaxima = capacidad;
            this._lista = new List<Cocina>();
        }

        public bool Agregar(Cocina c)
        {
            return this + c;
        }
        private int GetIndice(Cocina c)
        {
            for(int i = 0; i < this._lista.Count;i++)
            {
                if (this._lista[i] == c)
                    return i;  
            }
            return -1;
        }
        public bool Remover(Cocina c)
        {
            return this - c;
        }

        public static bool operator -(DepositoDeCocinas d ,Cocina c)
        {
            int indice = d.GetIndice(c);
            if (indice != -1)
            {
                d._lista.RemoveAt(indice);
                return true;
            }
            return false;
        }
        public static bool operator +(DepositoDeCocinas d ,Cocina c)
        {
            if(d._capacidadMaxima > d._lista.Count)
            {
                d._lista.Add(c);
                return true;
            }
            return false;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Capacidad máxima: " + this._capacidadMaxima);
            sb.AppendLine("Listado de Cocinas: ");
            foreach (Cocina c in this._lista)
                sb.AppendLine(c.ToString());
            return sb.ToString();
        }
    }
}
