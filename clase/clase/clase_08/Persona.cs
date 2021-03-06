﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clase_08
{
    public abstract class Persona
    {
        protected string _nombre;
        protected string _apellido;
        public string Nombre { get { return this._nombre; } }
        public string Apellido { get { return this._apellido; } }
        public Persona(string nombre, string apellido)
        {
            this._nombre = nombre;
            this._apellido = apellido;
        }
        public abstract string PosicionSocietaria();
        protected virtual string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Nombre: " + this.Nombre);
            sb.AppendLine("apellido: " + this.Apellido);
            return sb.ToString();
        }
    }
}
