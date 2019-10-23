using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_20.Entidades
{
    public class Privado:Avion
    {
        protected int _ValoracionServicioDeAbordo;
        public Privado(double precio ,double velocidad ,int valoracion):base(precio,velocidad)
        {
            this._ValoracionServicioDeAbordo = valoracion;
        }
    }
}
