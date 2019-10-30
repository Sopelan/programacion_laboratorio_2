using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_21.Entidades
{
    public class Empleado : Persona
    {
        public int legajo;
        public double sueldo;
        public Empleado(string nombre , string apellido , int edad , int legajo , double sueldo):base(nombre,apellido,edad)
        {
            this.legajo = legajo;
            this.sueldo = sueldo;
        }
        public Empleado()
        {

        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.ToString());
            sb.AppendLine("Legajo: " + this.legajo);
            sb.Append("Sueldo: " + this.sueldo);
            return sb.ToString();
        }
    }
}
