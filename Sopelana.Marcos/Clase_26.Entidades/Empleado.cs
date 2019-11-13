using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_26.Entidades
{
    
    public class Empleado
    {
        private string nombre;
        private string apellido;
        private int legajo;
        private double sueldo;
        private EmpleadoEventArgs empleadoEvent;
        public event LimiteSueldoDelegado LimiteSueldo;
        public event LimiteSueldoMejoradoDel LimiteSueldoMejorado;
        public string Nombre
        {
            get
            {
                return this.nombre;
            }
            set
            {
                this.nombre = value;
            }
        }
        public string Apellido
        {
            get
            {
                return this.apellido;
            }
            set
            {
                this.apellido = value;
            }
        }
        public int Legajo
        {
            get
            {
                return this.legajo;
            }
            set
            {
                this.legajo = value;
            }
        }
        public double Sueldo
        {
            get
            {
                return this.sueldo;
            }
            set
            {
                this.empleadoEvent.SueldoAsignar = value;
                if (value > 30000)
                    this.LimiteSueldoMejorado(this, this.empleadoEvent);
                else if (value > 18000)
                    this.LimiteSueldo(value, this);

                else
                    this.sueldo = value;
            }
        }
        

        public Empleado(string nombre , string apellido ,int legajo)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.legajo = legajo;
            this.sueldo = new double();
            this.empleadoEvent = new EmpleadoEventArgs();
        }
        public void ManejadorLimiteSueldo (double sueldo , Empleado empleado)
        {
            Console.WriteLine(empleado.nombre + " " + empleado.apellido); 
            Console.WriteLine("el sueldo que quiso tener es " + sueldo);
        }
        public static void ManejadorLimiteSueldoMejorado(Empleado empleado, EmpleadoEventArgs empleadoEventArgs)
        {
            Console.WriteLine(empleado.nombre + " " + empleado.apellido);
            Console.WriteLine("el sueldo que quiso tener es " + empleadoEventArgs.SueldoAsignar);
            
        }
        public void ManejadorLimiteSueldoMejorado2(Empleado empleado , EmpleadoEventArgs empleadoEventArgs)
        {
            Console.WriteLine(empleado.nombre + " " + empleado.apellido);
            Console.WriteLine("el sueldo que quiso tener es " + empleadoEventArgs.SueldoAsignar);
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Nombre: " + this.nombre);
            sb.AppendLine("Apellido: " + this.apellido);
            sb.AppendLine("Legajo: " + this.legajo);
            sb.AppendLine("Sueldo: " + this.sueldo);
            return sb.ToString();
        }
    }
}
