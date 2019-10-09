using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial.Entidades
{
    public class Concesionaria
    {
        private int capacidad;
        private List<Vehiculo> vehiculos;
        public double PrecioDeAutos { get; }
        public double PrecioDeMotos { get; }
        public double PrecioDeTotal { get; }

        private Concesionaria()
        {
            this.vehiculos = new List<Vehiculo>();
        }
        private Concesionaria(int capacidad):this()
        {
            this.capacidad = capacidad;
        }

        public static string Mostrar(Concesionaria c)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Capacidad: 6");
            sb.AppendLine("************************************");
            sb.AppendLine("Listado de vehiculos");
            sb.AppendLine("************************************");
            foreach (Vehiculo v in c.vehiculos)
                sb.AppendLine(v.ToString());
            return sb.ToString();
        }
        //public double ObtenerPrecio(EVehiculo tipoVehiculo)
        //{
        //    float total = 0;
        //    foreach (Vehiculo v in this.vehiculos)
        //    {
        //        if (tipoVehiculo == EVehiculo.PrecioDeAutos)
        //            if (v is Auto)
        //            {
        //                total += (Single)v;
        //            }
        //    }
           

        //    return 
        //}

        public static implicit operator Concesionaria (int capacidad)
        {
            Concesionaria c = new Concesionaria(capacidad);
            return c;
        }
        public static Concesionaria operator +(Concesionaria c , Vehiculo v)
        {
            if (c.vehiculos.Count < c.capacidad)
            {
                if (c != v)
                    c.vehiculos.Add(v);
               
            }
                
                
            return c;
        }
        public static bool operator != (Concesionaria c , Vehiculo v)
        {
            return !(c == v);
        }
        public static bool operator == (Concesionaria c , Vehiculo v)
        {
            foreach (Vehiculo b in c.vehiculos)
                if (v == b)
                    return true;
            return false;
        }



    }
}
