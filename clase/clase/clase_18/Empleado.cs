using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace clase_18
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
        public Empleado(string nombre,string apellido,string legajo,EPuestoJerarquico puesto ,int salario):base(nombre,apellido)
        {
            this._legajo = legajo;
            this._puesto = puesto;
            this._salario = salario;
        }
        public Empleado(Persona persona,string legajo , int salario):base(persona.Nombre,persona.Apellido)
        {
            this._legajo = legajo;
            this._salario = salario;
        }
        public static bool operator == (Empleado e1,Empleado e2)
        {
            return (e1._legajo == e2._legajo);
        }
        public static bool operator !=(Empleado e1, Empleado e2)
        {
            return !(e1 == e2);
        }
        public void Mostrar(IGrafica grafica)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(base.Mostrar());
            sb.AppendLine("Legajo: " + this._legajo);
            sb.AppendLine(this.PosicionSocietaria());
            sb.AppendLine("Salario: $" + this._salario);
            grafica.MostrarEnGUI(sb.ToString());
        }
        public override string PosicionSocietaria()
        {
            return "Empleado de " + _puesto;
        }
    }
}
