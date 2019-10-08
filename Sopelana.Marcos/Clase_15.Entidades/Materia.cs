using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_15.Entidades
{
    public class Materia
    {
        private List<Alumno> _alumnos;
        private EMateria _nombre;
        private static Random _notaParaUnAlumno;

        public List<Alumno> Alumnos { get { return this._alumnos; } set { this._alumnos = value; } }
        public EMateria Nombre { get { return this._nombre; } set { this._nombre = value; } }

        public void CalificarAlumnos()
        {
            for (int i = 0; i < this.Alumnos.Count; i++)
                this.Alumnos[i].Nota = _notaParaUnAlumno.Next(1, 10);
        }
        public static explicit operator String(Materia materia)
        {
            return materia.Mostrar() ;
        }
        public static implicit operator float(Materia m)
        {
            float notas = 0;
            float retorno;
            foreach (Alumno a in m.Alumnos)
                notas += a.Nota;
            retorno = notas / m.Alumnos.Count;
            return retorno;
        }
        public static implicit operator Materia(EMateria nombre)
        {
            Materia materia = new Materia(nombre);
            return materia;
        }
        private Materia()
        {
            this.Alumnos = new List<Alumno>();
        }
        static Materia()
        {
            _notaParaUnAlumno = new Random();
        }
        private Materia(EMateria nombre):this()
        {
            this.Nombre = nombre;
        }
        private string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine();
            sb.AppendLine("Materia: " + this.Nombre);
            sb.AppendLine("*************************************");
            sb.AppendLine("***************ALUMNOS***************");
            foreach (Alumno c in this.Alumnos)
                sb.AppendLine(Alumno.Mostrar(c));
            sb.AppendLine();
            return sb.ToString();
        }
        public static bool operator !=(Materia m , Alumno a)
        {
            return !(m == a);
        }
        public static Materia operator - (Materia m , Alumno a)
        {
            if (m == a)
            {
                m.Alumnos.Remove(a);
                Console.WriteLine("Se quitó el alumno de la materia{0}!!!", m.Nombre);
            }
            else
                Console.WriteLine("El alumno no esta en la materia {0}!!!", m.Nombre);

                
            return m;
        }
        public static Materia operator +(Materia m,Alumno a)
        {
            if (m != a)
            {
                m.Alumnos.Add(a);
                Console.WriteLine("Se agregó el alumno a la materia {0}!!!", m.Nombre);
            }
            else
                Console.WriteLine("El alumno ya esta en la materia {0}!!!", m.Nombre);
                
            return m;
        }
        public static bool operator == (Materia m , Alumno a)
        {
            foreach (Alumno c in m.Alumnos)
                if (c == a)
                    return true;
            return false;
        }


    }
}
