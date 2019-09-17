using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_09.Entidades
{
    public class Capitulo
    {
        private int numero;
        private string titulo;
        private int paginas;
        private static Random generadorDeNumeros;
        private static Random generadorDePaginas;
        public int Numero
        {
            get { return this.numero; }
        }
        public string Titulo
        {
            get { return this.titulo; }
        }
        public int Paginas
        {
            get { return this.paginas; }
        }
        static Capitulo()
        {
            generadorDeNumeros = new Random();
            generadorDePaginas = new Random();

        }
        public Capitulo(int numero, string titulo, int paginas)
        {
            this.numero = numero;
            this.paginas = paginas;
            this.titulo = titulo;
        }
        public static implicit operator Capitulo(string titulo)
        {

            Capitulo c1 = new Capitulo(generadorDeNumeros.Next(1,65), titulo, generadorDeNumeros.Next(10,233));
           
            return c1;
        }
        public static bool operator ==(Capitulo c1, Capitulo c2)
        {
            return (c1.Numero == c2.Numero);
        }
        public static bool operator != (Capitulo c1, Capitulo c2)
        {
            return (!(c1 == c2));    
        }


    }
}
