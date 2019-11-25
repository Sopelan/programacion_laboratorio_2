using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Clase_16_Library;
/* Dado el proyecto de librería con la clase Persona , utilizar test unitarios para evaluar los siguientes comportamientos.

    Comprobar que la propiedad DNI reciba números entre 1 y 99.999.999 Si se carga un DNI con un número distinto a los aceptados, se arrojará DniInvalidoException.
    Si el número está entre 1 y 89.999.999, la nacionalidad debe ser Argentino. Si no, extranjero. Si se carga un DNI con un número distinto a los correspondientes según su nacionalidad, se arrojará NacionalidadInvalidaException. 
    Corregir los errores de validación que pueda encontrar en el código.*/ 
namespace clase_16
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void DniMayor()
        {
            try
            {
                Persona persona = new Persona("marcos", "sopelana ", 10000000, Persona.ENacionalidad.Argentino);
            }
            catch(Exception e)
            {
                Assert.IsInstanceOfType(e, typeof(NacionalidadInvalidaException));
            }
        }
        [TestMethod]
        public void DniMenor()
        {
            try
            {
                Persona persona = new Persona("marcos", "sopelana ", -3, Persona.ENacionalidad.Argentino);
            }
            catch (Exception e)
            {
                Assert.IsInstanceOfType(e, typeof(NacionalidadInvalidaException));
            }
        }
        [TestMethod]
        public void DniTexto()
        {
            try
            {
                Persona persona = new Persona("marcos", "sopelana ", "30.999,999", Persona.ENacionalidad.Argentino);
            }
            catch (Exception e)
            {
                Assert.IsInstanceOfType(e, typeof(DniInvalidoException));
            }
            try
            {
                Persona persona = new Persona("marcos", "sopelana ", "30a00123", Persona.ENacionalidad.Argentino);
            }
            catch (Exception e)
            {
                Assert.IsInstanceOfType(e, typeof(DniInvalidoException));
            }
        }
        [TestMethod]
        public void DniArgentinos()
        {
            Persona persona = new Persona("marcos", "sopelana", 1, Persona.ENacionalidad.Argentino);
            Assert.AreEqual(persona.DNI, 1);
            Persona persona2 = new Persona("marcos", "sopelana", 89999999, Persona.ENacionalidad.Argentino);
            Assert.AreEqual(persona2.DNI, 89999999);
            int numero = new Random().Next(1, 89999999);
            Persona persona3 = new Persona("marcos", "sopelana", numero, Persona.ENacionalidad.Argentino);
            Assert.AreEqual(persona3.DNI, numero);
            string numero2 = "89999999";
            Persona persona4 = new Persona("marcos", "sopelana", numero2, Persona.ENacionalidad.Argentino);
            Assert.AreEqual(persona4.DNI, 89999999);
        }
        [TestMethod]
        public void DniExtranjeros()
        {
            Persona persona = new Persona("marcos", "sopelana", 90000000, Persona.ENacionalidad.Extranjero);
            Assert.AreEqual(persona.DNI, 90000000);
            Persona persona2 = new Persona("marcos", "sopelana", 99999999, Persona.ENacionalidad.Extranjero);
            Assert.AreEqual(persona2.DNI, 99999999);
            int numero = new Random().Next(90000000, 99999999);
            Persona persona3 = new Persona("marcos", "sopelana", numero, Persona.ENacionalidad.Extranjero);
            Assert.AreEqual(persona3.DNI, numero);
            Persona persona4 = new Persona("marcos", "sopelana", "99999999", Persona.ENacionalidad.Extranjero);
            Assert.AreEqual(persona4.DNI, 99999999);
        }


    }
}
