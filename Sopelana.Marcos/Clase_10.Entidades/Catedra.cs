using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_10.Entidades
{
    public class Catedra
    {
        private List<Alumno> alumnos;
        public List<Alumno> Alumnos { get { return alumnos; } }
        public Catedra()
        {
            this.alumnos = new List<Alumno>();
        }
        public static bool operator ==(Catedra c, Alumno a)
        {
            if(!Object.Equals(c,null) && (!Object.Equals(a, null)))
            {
                for(int i = 0;i<c.alumnos.Count;i++)
                    if (c.alumnos[i] == a)
                        return true;
            }
            return false;
        }
        public static bool operator != (Catedra c , Alumno a)
        {
            return !(c == a);
        }
        public static bool operator +(Catedra c , Alumno a)
        {
            if(c != a)
            {
                c.alumnos.Add(a);
                return true;
            }
            return false;
        }
        public static bool operator -(Catedra c, Alumno a)
        {
            if(c == a)
            {
                c.alumnos.Remove(a);
                return true;
            }
            return false;
        }
        public static int operator |(Alumno a, Catedra c)
        {
            for (int i = 0; i < c.alumnos.Count; i++)
                if (c.alumnos[i] == a)
                    return i;
            return -1;
        }
        public override string ToString()
        {
            string mostrar = "";
            for(int i = 0; i < alumnos.Count; i++)
            {
                mostrar += Alumno.Mostrar(alumnos[i]) + "\n";
            }
            return mostrar;
        }

    }
}
