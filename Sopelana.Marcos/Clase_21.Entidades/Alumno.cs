using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_21.Entidades
{
    public class Alumno : Persona
    {
        public double nota;
        public Alumno(string nombre , string apellido, int edad , double nota):base(nombre,apellido,edad)
        {
            this.nota = nota;
        }
        public Alumno()
        {

        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.ToString());
            sb.Append("Nota: " + this.nota);
            return sb.ToString(); 
        }
    }
}
