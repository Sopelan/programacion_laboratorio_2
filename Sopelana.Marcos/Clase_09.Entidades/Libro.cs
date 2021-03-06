﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_09.Entidades
{
    public class Libro
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
        public int CantidadDePaginas
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
                if (i < this.capitulos.Count && i>= 0)
                    return this.capitulos[i];
                else
                    return null;
            }
            set
            {
                if(i >= 0)
                {
                    if (i == this.capitulos.Count)
                        this.capitulos.Add(value);
                    else if (i < this.capitulos.Count)
                        this.capitulos[i] = value;
                }
                //    if(i < this.capitulos.Count && i >= 0)
                //    this.capitulos[i] = value;
                //else if(i >= this.capitulos.Count)
                //{
                //    int cantidad = this.capitulos.Count;
                //    this.capitulos = new List<Capitulo>(cantidad + 1);
                //    this.capitulos[cantidad] = value;
                //}
            }
        }
        public int CantidadDeCapitulos
        {
            get { return this.capitulos.Count; }
        }


        public Libro(string titulo , string autor)
        {
            this.titulo = titulo;
            this.autor = autor;
            this.capitulos = new List<Capitulo>();
        }


    }
}
