using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial.Entidades
{
    public abstract class  Vehiculo
    {
        protected Fabricante fabricantes;
        protected static Random generadorDeVelocidades;
        protected string modelo;
        protected float precio;
        protected int velocidadMaxima;

        public int VelocidadMaxima
        {
            get
            {
                if (this.velocidadMaxima == 0)
                    this.velocidadMaxima = generadorDeVelocidades.Next(100, 280);
                return this.velocidadMaxima;
            }
        }

        static Vehiculo()
        {
            generadorDeVelocidades = new Random();
        }
        public Vehiculo(float precio ,string modelo , Fabricante fabri)
        {
            this.fabricantes = fabri;
            this.modelo = modelo;
            this.precio = precio;
        }
        public Vehiculo(string marca , EPais pais , string modelo, float precio):this(precio,modelo,new Fabricante(marca ,pais))
        {
            
        }

        private static string Mostrar(Vehiculo c)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append((string)c.fabricantes);
            sb.AppendLine("Modelo: " + c.modelo);
            sb.AppendLine("Precio: " + c.precio);
            sb.AppendLine("Velocidad maxima: " + c.VelocidadMaxima);
            return sb.ToString();
        }

        public static explicit operator String(Vehiculo v)
        {
            return Mostrar(v);
        }
        public static bool operator !=(Vehiculo a , Vehiculo b)
        {
            return !(a == b);
        }
        public static bool operator == (Vehiculo a , Vehiculo b)
        {
            return (a.fabricantes == b.fabricantes) && (a.modelo == b.modelo);
        }

    }
}
