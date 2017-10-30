using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Archivos;
using EntidadesAbstractas;
using ClasesInstanciables;
using Excepciones;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void EnviaExcepcion()
        {

            try
            {
                Alumno alumno = new Alumno(1, "Juan", "Perez", "dw487998", Persona.ENacionalidad.Argentino, Universidad.EClases.Laboratorio);
            }
            catch (DniInvalidoException e)
            {
                Assert.IsTrue(true);
            }
            catch (Exception e)
            {
                Assert.Fail();
            }

        }
        [TestMethod]
        public void ArchivoExcepcion()
        {
            try
            {
                Texto unTexto = new Texto();
                unTexto.guardar("archivo.txt", "mensaje");
            }
            catch (ArchivosException e)
            {
                Assert.IsTrue(true);
            }
            catch (Exception e)
            {
                Assert.Fail();
            }

        }
        [TestMethod]
        public void NoNull()
        {
            try
            {
                Alumno alumno= new Alumno();
                Profesor profesor = new Profesor();
                Universidad uni = new Universidad();
                Jornada jornada = new Jornada(Universidad.EClases.Laboratorio, profesor);
                alumno.ToString();
                profesor.ToString();
                uni.ToString();
                jornada.ToString();
            }
            catch (Exception e)
            {
                //Si no es null, funciona
                Assert.IsNotInstanceOfType(e, typeof(NullReferenceException));
            }
        }
    }
}
