using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_12y14.Entidades
{
    public abstract class Llamada
    {
        protected float duracion;
        protected string _nroDestino;
        protected string _nroOrigen;
        public abstract float CostoLlamada { get; }
        public float Duracion
        {
            get { return duracion; }
        }
        public string NroDestino
        {
            get { return _nroDestino; }
        }
        public string NroOrigen
        {
            get { return _nroOrigen; }
        }
        public Llamada(string origen, string destino, float duracion)
        {
            this.duracion = duracion;
            this._nroDestino = destino;
            this._nroOrigen = origen;
        }
        protected virtual string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("duracion:" + this.duracion);
            sb.AppendLine("origen: " + this._nroOrigen);
            sb.AppendLine("destino: " + this._nroDestino);
            return sb.ToString();
        }
        public static bool operator ==(Llamada uno, Llamada dos)
        {
            if (!Object.Equals(uno, null) && !Object.Equals(dos, null))
                if (uno.Equals(dos))
                    if (uno.NroDestino == dos.NroDestino && uno.NroOrigen == dos.NroOrigen)
                        return true;
            return false;

        }
        public static bool operator !=(Llamada uno, Llamada dos)
        {
            return !(uno == dos);
        }
        public static int OrdenarPorDuracion(Llamada uno, Llamada dos)
        {
            return String.Compare(uno.Duracion.ToString(), dos.Duracion.ToString());
        }
    }
}
