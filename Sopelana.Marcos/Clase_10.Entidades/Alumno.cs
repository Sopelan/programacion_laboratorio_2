using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_10.Entidades
{
    public class Alumno
    {
        protected string apellido;
        protected ETipoExamen examen;
        protected int legajo;
        protected string nombre;

        public string Apellido { get { return this.apellido; } }
        public ETipoExamen Examen { get { return this.examen; } }
        public int Legajo { get { return this.legajo; } }
        public string Nombre { get { return this.nombre; } }

        public Alumno(string nombre , string apellido , int legajo , ETipoExamen examen)
        {
            this.apellido = apellido;
            this.examen = examen;
            this.legajo = legajo;
            this.nombre = nombre;
        }
        public static string Mostrar(Alumno a)
        {
            return "nombre: " + a.nombre + " apellido: " + a.Apellido + " examen:" + a.examen + " legajo: " + a.legajo;
        }
        public static bool operator ==(Alumno a,Alumno b)
        {
            if (!(Object.Equals(a, null)) && !(Object.Equals(b, null)))
                return (a.legajo == b.legajo);
            return false;
        }
        public static bool operator !=(Alumno a, Alumno b)
        {
            return !(a == b);
        }
        public static int OrdenarPorApellidoAsc(Alumno a , Alumno b)
        {
            return String.Compare(a.apellido,b.apellido);
        }
        public static int OrdenarPorApellidoDec(Alumno a , Alumno b)
        {
            return -1 *  Alumno.OrdenarPorApellidoAsc(a, b);//String.Compare(b.apellido, a.apellido);
        }
        public static int OrdenarPorLegajoAsc(Alumno a, Alumno b)
        {
            return String.Compare(a.legajo.ToString(), b.legajo.ToString());
        }
        public static int OrdenarPorLegajoDec(Alumno a , Alumno b)
        {
            return -1 * Alumno.OrdenarPorLegajoAsc(a, b);
        }

    }
}
