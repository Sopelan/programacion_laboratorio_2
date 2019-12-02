using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* Un programa que pida datos de 8 personas: nombre, dia de nacimiento, mes de nacimiento, y año de nacimiento (que se deben almacenar en una tabla de structs). Después deberá repetir lo siguiente: preguntar un número de 
 * mes y mostrar en pantalla los datos de las personas que cumplan los años durante ese mes. Terminará de repetirse cuando se teclee 0 como número de mes*/
namespace ejercicio_4._5._2
{
    class Program
    {
        public struct Persona
        {
            public string nombre;
            public int diaDeNacimiento;
            public int mesDeNacimiento;
            public int añoDeNacimiento;
        }
        static void Main(string[] args)
        {
            Persona[] persona = new Persona[8];
            int num = -2;
            for(int i = 0; i< 8;i++)
            {
                while(true)
                {
                    try
                    {
                        Console.WriteLine("ingrese el nombre de la persona {0}", i + 1);
                        persona[i].nombre = Console.ReadLine();
                        Console.WriteLine("ingrese el dia de nacimiento de la persona {0}", i + 1);
                        persona[i].diaDeNacimiento = Convert.ToInt32(Console.ReadLine());
                        while (persona[i].diaDeNacimiento > 31 || persona[i].diaDeNacimiento <= 0)
                        {
                            Console.WriteLine("error del dia");
                            Console.WriteLine("ingrese otra vez el dia de nacimiento de la persona {0}", i + 1);
                            persona[i].diaDeNacimiento = Convert.ToInt32(Console.ReadLine());
                        }
                        Console.WriteLine("ingrese el mes de nacimiento de la persona {0}", i + 1);
                        persona[i].mesDeNacimiento = Convert.ToInt32(Console.ReadLine());
                        while(persona[i].mesDeNacimiento > 12|| persona[i].mesDeNacimiento <= 0)
                        {
                            Console.WriteLine("error del mes");
                            Console.WriteLine("ingrese otra vez el mes de nacimiento de la persona {0}", i + 1);
                            persona[i].mesDeNacimiento = Convert.ToInt32(Console.ReadLine());
                        }
                        Console.WriteLine("ingrese el año de nacimiento de la persona {0}", i + 1);
                        persona[i].añoDeNacimiento = Convert.ToInt32(Console.ReadLine());
                        break;
                    }
                    catch(Exception e)
                    {
                        Console.WriteLine(e.Message);
                    }
                }
            }
            while(num != 0)
            {
                while (true)
                {
                    try
                    {
                        Console.WriteLine("ingrese el mes que buscar");
                        num = Convert.ToInt32(Console.ReadLine());
                        break;
                    }
                    catch(Exception Message)
                    {
                        Console.WriteLine(Message.Message);
                    }
                }
                switch(num)
                {
                    case 1:
                        Console.WriteLine("En enero cumple:");
                        foreach(Persona p in persona)
                        {
                            if (p.mesDeNacimiento == 1)
                                Console.WriteLine(p.nombre + " el dia " + p.diaDeNacimiento);
                        }
                        break;
                    case 2:
                        Console.WriteLine("En febrero cumple:");
                        foreach (Persona p in persona)
                        {
                            if (p.mesDeNacimiento == 2)
                                Console.WriteLine(p.nombre + " el dia " + p.diaDeNacimiento);
                        }
                        break;
                    case 3:
                        Console.WriteLine("En marzo cumple:");
                        foreach (Persona p in persona)
                        {
                            if (p.mesDeNacimiento == 3)
                                Console.WriteLine(p.nombre + " el dia " + p.diaDeNacimiento);
                        }
                        break;
                    case 4:
                        Console.WriteLine("En abril cumple:");
                        foreach (Persona p in persona)
                        {
                            if (p.mesDeNacimiento == 4)
                                Console.WriteLine(p.nombre + " el dia " + p.diaDeNacimiento);
                        }
                        break;
                    case 5:
                        Console.WriteLine("En mayo cumple:");
                        foreach (Persona p in persona)
                        {
                            if (p.mesDeNacimiento == 5)
                                Console.WriteLine(p.nombre + " el dia " + p.diaDeNacimiento);
                        }
                        break;
                    case 6:
                        Console.WriteLine("En junio cumple:");
                        foreach (Persona p in persona)
                        {
                            if (p.mesDeNacimiento == 6)
                                Console.WriteLine(p.nombre + " el dia " + p.diaDeNacimiento);
                        }
                        break;
                    case 7:
                        Console.WriteLine("En julio cumple:");
                        foreach (Persona p in persona)
                        {
                            if (p.mesDeNacimiento == 7)
                                Console.WriteLine(p.nombre + " el dia " + p.diaDeNacimiento);
                        }
                        break;
                    case 8:
                        Console.WriteLine("En agosto cumple:");
                        foreach (Persona p in persona)
                        {
                            if (p.mesDeNacimiento == 8)
                                Console.WriteLine(p.nombre + " el dia " + p.diaDeNacimiento);
                        }
                        break;
                    case 9:
                        Console.WriteLine("En septiembre cumple:");
                        foreach (Persona p in persona)
                        {
                            if (p.mesDeNacimiento == 9)
                                Console.WriteLine(p.nombre + " el dia " + p.diaDeNacimiento);
                        }
                        break;
                    case 10:
                        Console.WriteLine("En octubre cumple:");
                        foreach (Persona p in persona)
                        {
                            if (p.mesDeNacimiento == 10)
                                Console.WriteLine(p.nombre + " el dia " + p.diaDeNacimiento);
                        }
                        break;
                    case 11:
                        Console.WriteLine("En noviembre cumple:");
                        foreach (Persona p in persona)
                        {
                            if (p.mesDeNacimiento == 11)
                                Console.WriteLine(p.nombre + " el dia " + p.diaDeNacimiento);
                        }
                        break;
                    case 12:
                        Console.WriteLine("En diciembre cumple:");
                        foreach (Persona p in persona)
                        {
                            if (p.mesDeNacimiento == 12)
                                Console.WriteLine(p.nombre + " el dia " + p.diaDeNacimiento);
                        }
                        break;

                }
            }
            

        }
    }
}
