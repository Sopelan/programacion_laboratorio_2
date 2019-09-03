using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* Realizar una aplicación de consola llamada Clase-4 con una clase llamada Sumador. 
Parte I 
Crear dos constructores: 
     Sumador() – inicializa cantidadSumas en 0. 
     Sumador(int) – inicializa cantidadSumas en el valor recibido por parámetros. 
Sumador contará con un atributo privado: 
     int cantidadSumas 
Y un método público llamado Sumar con la siguiente firma: 
     long Sumar(long a, long b) 
Sumar deberá incrementar en 1 el atributo cantidadSumas, sumar mediante el operador + sus argumentos y retornarlos. 
Agregar un objeto del tipo Sumador en el Main y probar el código.  
Parte II 
Utilizar sobrecarga para agregar un nuevo método Sumar que realice las mismas acciones, pero con la siguiente firma: 
     string Sumar(string a, string b) 
Probar el código.  
Parte III 
Generar una conversión explícita que retorne cantidadSumas.  
Parte IV 
1. Sobrecargar el operador + (suma) para que puedan sumar cantidadSumas y retornen un long con dicho valor. 
2. Sobrecargar el operador | (pipe) para que retorne True si ambos sumadores tienen igual cantidadSumas. 
Agregar un segundo objeto del tipo Sumador en el Main y probar el código.*/ ///

namespace clase_04._2
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
