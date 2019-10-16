using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_18.Entidades
{
    public class DepositoDeAutos
    {
        private int _capacidadMaxima;
        private List<Auto> _Lista;

        public DepositoDeAutos(int capacidad)
        {
            this._capacidadMaxima = capacidad;
            this._Lista = new List<Auto>();
        }

        public bool Agregar(Auto a)
        {
            return this + a;
        }
        private int GetIndice(Auto a)
        {
            for(int i = 0; i < this._Lista.Count; i++)
            {
                if (a == this._Lista[i])
                    return i;
            }
            return -1;
        }
        public bool Remover(Auto a)
        {         
            return this - a;
        }

        public static bool operator -(DepositoDeAutos d, Auto a)
        {
            int indice = d.GetIndice(a);
            if (indice != -1) 
            {
                d._Lista.RemoveAt(indice);
                return true;
            }
            return false;
        }
        public static bool operator +(DepositoDeAutos d , Auto a)
        {
            if(d._capacidadMaxima > d._Lista.Count)
            {
                d._Lista.Add(a);
                return true;
            }
            return false;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Capacidad máxima: " + this._capacidadMaxima);
            sb.AppendLine("Listado de Autos:");
            foreach (Auto a in this._Lista)
                sb.AppendLine(a.ToString());
            return sb.ToString();
        }


    }
}
