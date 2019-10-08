using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_15.Entidades
{
    public class Alumno
    {
        private string _apellido;
        private int _legajo;
        private string _nombre;
        private float _nota;

        public string Apellido { get { return this._apellido; } set { this._apellido = value; } }
        public int Legajo { get {return this._legajo; } set {this._legajo = value; } }
        public string Nombre { get {return this._nombre; } set {this._nombre = value; } }
        public float Nota { get {return this._nota; } set  {this._nota = value; } }

        public Alumno(int legajo, string nombre, string apellido)
        {
            this.Apellido = apellido;
            this.Nombre = nombre;
            this.Legajo = legajo;
        }
        private string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(this.Apellido +", ");
            sb.Append (this.Nombre);
            sb.Append(" - Legajo: " + this.Legajo);
            sb.AppendLine(" - Nota: " + this.Nota);
            return sb.ToString();
        }
        public static string Mostrar(Alumno alumno)
        {
            return alumno.Mostrar();
        }
        public static bool operator !=(Alumno a1, Alumno a2)
        {
            return !(a1 == a2);
        }
        public static bool operator ==(Alumno a1 , Alumno a2)
        {
            return a1.Legajo == a2.Legajo;
        }


        
    }
}
