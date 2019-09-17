using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_09.Entidades
{
    class Libro
    {
        private string titulo;
        private string autor;
        private List<Capitulo> capitulos;
        public string Titulo
        {
            get { return this.titulo; }
        }
        public string Autor
        {
            get { return this.autor; }
        }
        public int CantidadPaginas
        {
            get
            {
                int cantidad = this.capitulos.Count;
                int cantidadDePaginas = 0;
                for(int i = 0; i < cantidad; i++)
                    cantidadDePaginas += this.capitulos[i].Paginas;
                return cantidadDePaginas;
            }
        }
        public Capitulo this[int i]
        {
            get
            {
                if (i < this.capitulos.Count)
                    return this.capitulos[i];
                else
                    return null;
            }
            set
            {
                if(i < this.capitulos.Count)
                    this.capitulos[i] = value;
                else if(i >= this.capitulos.Count)
                {
                    this.capitulos = new List<Capitulo>(this.capitulos.Count + 1);
                    this.capitulos[this.capitulos.Count] = value;
                }
            }
        }

        public Libro(string titulo , string autor)
        {
            this.titulo = titulo;
            this.autor = autor;
            this.capitulos = new List<Capitulo>();
        }


    }
}
