using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_18.Entidades
{
    public class Deposito<T>
    {
        private int _capacidadMaxima;
        private List<T> _lista;

        public Deposito(int capacidad)
        {
            this._capacidadMaxima = capacidad;
            this._lista = new List<T>();
        }

        public bool Agregar(T a)
        {
            return this + a ;
        }
        private int GetIndice(T a)
        {
            for(int i = 0; i < this._lista.Count; i++)
            {
                if (this._lista[i].Equals(a))
                    return i;
            }
            return -1;
        }
        public bool Remover(T a)
        {
            return this - a;
        }

        public static bool operator -(Deposito<T> d, T a)
        {
            int indice = d.GetIndice(a);
            if(indice != -1)
            {
                d._lista.RemoveAt(indice);
                return true;
            }
            return false;
        }
        public static bool operator +(Deposito<T> d , T a)
        {
            if(d._capacidadMaxima > d._lista.Count)
            {
                d._lista.Add(a);
                return true;
            }
            return false;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Capacidad Máxima: " + this._capacidadMaxima);
            sb.AppendLine("Listado de " + List.Enumerator);
            foreach(T t in this._lista )
                sb.AppendLine(t.ToString());
            return sb.ToString();
        }

    }
}
