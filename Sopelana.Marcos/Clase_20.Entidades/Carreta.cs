﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_20.Entidades
{
    public class Carreta : Vehiculo,IARBA
    {
        public Carreta(double precio):base(precio)
        {

        }

        public double CalcularImpuesto()
        {
            return this._precio * 0.18;
        }
    }
}
