using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_08
{
    public class Sumar
    {
        public int valorHora;
        public string nombre;
        public int antiguedad;
        public int horasTrabajadas;
        public int Total()
        {
            int total;
             return total = (this.valorHora * this.horasTrabajadas) + (this.antiguedad * 150);
        }
        public int TotalConResto()
        {
            int totalConResto;
            return totalConResto = this.Total() * 87 / 100;
        }
        public string Mostrar()
        {
            return "nombre: " + this.nombre + "\ntrabajaste por: " + this.antiguedad + "\nvalor de la hora " + this.horasTrabajadas + "\na cobrar en bruto: " + this.Total() + "\na cobrar en neto\n";
        }

    }
}
