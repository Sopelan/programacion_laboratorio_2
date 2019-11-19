using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_27.Entidades
{
    public class Persona
    {
        protected string nombre;
        protected string apellido;
        protected int dni;

        public string Nombre => this.nombre;
        public string Apellido => this.apellido;
        public int Dni => this.dni;

        public Persona(string nombre, string apellido, int dni)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.dni = dni;
        }
        public string ObtenerInfo()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Nombre: " + this.nombre);
            sb.AppendLine("Apellido: " + this.apellido);
            sb.AppendLine("Dni: " + this.dni);
            return sb.ToString();
        }
    }
}
