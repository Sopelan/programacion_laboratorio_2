using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_09
{
    public class Lavadero
    {
        private List<Vehiculo> _vehiculos;
        private float _precioAuto;
        private float _precioCamion;
        private float _precioMoto;
        public string Vehiculos
        {
            get
            {
                StringBuilder sb = new StringBuilder();
                foreach(Vehiculo v in this._vehiculos)
                {
                    sb.AppendLine(v.Mostrar());
                    sb.Append("precio: ");
                    if (v is Moto)
                        sb.AppendLine(this._precioMoto + "");
                    else if (v is Auto)
                        sb.AppendLine(this._precioAuto + "");
                    else if (v is Camion)
                        sb.AppendLine(this._precioCamion + "");
                    else
                        sb.AppendLine(this.MostrarTotalFacturado() + "");
                }
                return sb.ToString();
                
            }
        }
        private Lavadero()
        {
            _vehiculos = new List<Vehiculo>();
        }
        public Lavadero(float precioAuto, float precioCamion, float precioMoto) : this()
        {
            this._precioAuto = precioAuto;
            this._precioCamion = precioCamion;
            this._precioMoto = precioCamion;
        }
        public double MostrarTotalFacturado()
        {
            double retorno = 0;
            foreach(Vehiculo v in this._vehiculos)
            {
                if (v is Moto)
                    retorno += this._precioMoto;
                else if (v is Camion)
                    retorno += this._precioCamion;
                else if (v is Auto)
                    retorno += this._precioAuto;
            }
            return retorno;
        }
        public double MostrarTotalFacturado(EVehiculos vehiculos)
        {
            double retorno = 0;
            foreach (Vehiculo v in this._vehiculos)
            {
                if (vehiculos == EVehiculos.Moto)
                    if (v is Moto)
                        retorno += this._precioMoto;
                if (vehiculos == EVehiculos.Camion)
                    if (v is Camion)
                        retorno += this._precioCamion;
                if (vehiculos == EVehiculos.Auto)
                    if (v is Auto)
                        retorno += this._precioAuto;
            }
            return retorno;
        }
        public static bool operator ==(Lavadero l,Vehiculo v)
        {
            foreach (Vehiculo b in l._vehiculos)
                if (b == v)
                    return true;
            return false;
        }
        public static bool operator !=(Lavadero l , Vehiculo v)
        {
            return !(l == v);
        }
        public static Lavadero operator +(Lavadero l , Vehiculo v)
        {
            if(l != v)
            {
                l._vehiculos.Add(v);
            }
            return l;
        }
        public static Lavadero operator -(Lavadero l , Vehiculo v)
        {
            if(l == v)
            {
                l._vehiculos.Remove(v);
            }
            return l;
        }
        public static int OrdenarVehiculosPorPatentes(Vehiculo v1 , Vehiculo v2)
        {
            return string.Compare(v1.Patentes, v2.Patentes);
        }
        public static int OrdenarVehiculosPorMarca(Vehiculo v1 , Vehiculo v2)
        {
            return string.Compare(v1.Marcas.ToString() , v2.Marcas.ToString());
        }


    }
}
