using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clase_08
{
    public class Empresa
    {
        private List<Empleado> _nominaEmpleados;
        private string _razonSocial;
        private string _direccion;
        private float _ganacias;
        public List<Empleado> NominaEmpleados { get { return this._nominaEmpleados; } }
        public string RazonSocial { get { return this._razonSocial; } set { this._razonSocial = value; } }
        public string Direccion { get { return this._direccion; } set { this._direccion = value; } }
        public float Ganancias { get { return this._ganacias; }set { this._ganacias = value; } }
        private Empresa()
        {
            this._nominaEmpleados = new List<Empleado>();
        }
        public Empresa(string razonSocial , string direccion , float ganancias):this()
        {
            this._razonSocial = razonSocial;
            this._direccion = direccion;
            this._ganacias = ganancias;
        }
        public static Empresa operator +(Empresa empresa , Empleado empleado)
        {
            bool flag = true;
            for (int i = 0; i < empresa._nominaEmpleados.Count; i++)
            {
                if (empresa._nominaEmpleados[i] == empleado)
                {
                    flag = false;
                    break; 
                }
                   
            }
            if(flag == true)
                empresa._nominaEmpleados.Add(empleado);
            return empresa;
        }
        public string MostrarEmpresa()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("la empresa " + this.RazonSocial + " sita en la calle " + this.Direccion + " cuenta con ganancias por " + this.Ganancias + " y con " + this._nominaEmpleados.Count + "empleados:");
            foreach(Empleado e in this._nominaEmpleados)
                sb.AppendLine(e.ToString());
            return sb.ToString();
        }
    }
}
