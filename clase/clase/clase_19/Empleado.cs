using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clase_19
{
    public class Empleado: Persona
    {
        public enum EPuestoJerarquico
        {
            Administracion,
            Gerencia,
            Sistemas,
            Accionista
        }
        private string _legajo;
        private EPuestoJerarquico _puesto;
        private int _salario;

        public string Legajo { get => _legajo; set => _legajo = value; }
        public EPuestoJerarquico Puesto { get => _puesto; set => _puesto = value; }
        public int Salario { get => _salario; set => _salario = value; }

        public Empleado(string nombre,string apellido,string legajo,EPuestoJerarquico puesto ,int salario):base(nombre,apellido)
        {
            this.Legajo = legajo;
            this.Puesto = puesto;
            this.Salario = salario;
        }
        public Empleado(Persona persona,string legajo , int salario):base(persona.Nombre,persona.Apellido)
        {
            this.Legajo = legajo;
            this.Salario = salario;
        }

        public Empleado():base()
        {
        }

        public static bool operator == (Empleado e1,Empleado e2)
        {
            return (e1.Legajo == e2.Legajo);
        }
        public static bool operator !=(Empleado e1, Empleado e2)
        {
            return !(e1 == e2);
        }
        protected override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(base.Mostrar());
            sb.AppendLine("Legajo: " + this.Legajo);
            sb.AppendLine(this.PosicionSocietaria());
            sb.AppendLine("Salario: $" + this.Salario);
            return sb.ToString();
        }
        public override string PosicionSocietaria()
        {
            return "Empleado de " + Puesto;
        }
        public override string ToString()
        {
            return this.Mostrar();
        }
        public bool GuardarEnTexto(string path)
        { 
            return new Texto().Guardar(path, this.Mostrar());
        }
        public static bool LeerEnTexto(string path , out string mensaje)
        {
            return new Texto().Leer(path,out mensaje);
        }
        public bool GuardarEnPersona(string path)
        {
            return new Xml<Empleado>().Guardar(path, this);
        }
        public static bool LeerEnPersona(string path ,out Empleado empleado)
        {
            return new Xml<Empleado>().Leer(path, out empleado);
        }

    }
}
