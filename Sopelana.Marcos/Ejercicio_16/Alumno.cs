using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_16
{
    public class Alumno
    {
        private byte nota1;
        private byte nota2;
        private float notaFinal;
        public string apellido;
        public int legajo;
        public string nombre;

        public void CalcularFinal()
        {
            if (this.nota1 >= 4 && this.nota2 >= 4)
                notaFinal = new Random().Next(1, 10);
            else
                notaFinal = -1;
        }
        public void Estudiar(byte notaUno, byte notaDos)
        {
            this.nota1 = notaUno;
            this.nota2 = notaDos;
        }
        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Alumno: " + this.apellido + ", " + this.nombre);
            sb.AppendLine("Legajo: " + this.legajo);
            sb.AppendLine("Nota 1: " + this.nota1);
            sb.AppendLine("Nota 2: " + this.nota2);
            if (this.notaFinal != -1)
                sb.AppendLine("Nota final: " + this.notaFinal);
            else
                sb.AppendLine("Alumno desaprobado");
            return sb.ToString();
        }
    }
}
