﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clase_05.Entidades;
namespace Clase_05
{
    class Program
    {
        static void Main(string[] args)
        {
            Tinta a = new Tinta();
            string b = (string)a;
            Pluma c = new Pluma();
            b = c;
            c += a;
            Console.Read();
        }
    }
}
