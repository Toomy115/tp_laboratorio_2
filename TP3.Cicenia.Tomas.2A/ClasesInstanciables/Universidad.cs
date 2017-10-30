using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excepciones;
using Archivos;
using System.Xml.Serialization;

namespace ClasesInstanciables
{   
    public class Universidad
    {
        public enum EClases
        {
            Programacion, Laboratorio, Legislacion, SPD
        }
        private List<Alumno> alumnos;
        private List<Jornada> jornada;
        private List<Profesor> profesor;

        public List<Alumno> Alumnos { get { return this.alumnos; } set { this.alumnos = value; } }
        public List<Profesor> Insructores { get { return this.profesor; } set { this.profesor = value; } }
        public List<Jornada> Jornadas { get {return this.jornada; } set { this.jornada = value; } }
        public Jornada this[int i] { get {return this.jornada[i]; } set {this.jornada[i]=value; } }

        public Universidad()
        {
            this.alumnos = new List<Alumno>();
            this.jornada = new List<Jornada>();
            this.profesor = new List<Profesor>();
        }

        public static bool Guardar(Universidad gim)
        {
            Xml<Universidad> xml = new Xml<Universidad>();
            xml.guardar("universidad.xml", gim);
            return true;
        }       

        private static string MostrarDatos(Universidad gim)
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine("Jornada: ");
            foreach (Jornada j in gim.Jornadas)
            {
                stringBuilder.AppendLine(j.ToString());
            }
            return stringBuilder.ToString();

        }

        public static bool operator ==(Universidad g, Alumno a)
        {
            foreach (Alumno alumno in g.Alumnos)
            {
                if (a == alumno)
                    return true;                                  
            }
            return false;
        }

        public static Profesor operator ==(Universidad g, EClases clase)
        {
            foreach (Profesor p in g.Insructores)
            {
                if (p == clase)
                    return p;
            }
            throw new SinProfesorException();
        }

        public static bool operator ==(Universidad g, Profesor profesor)
        {
            foreach(Profesor p in g.Insructores)
            {
                if (p == profesor)               
                    return true;               
            }
            Console.WriteLine("No hay un profesor para la clase.");
            return false;
        }

        public static bool operator != (Universidad g, Alumno a)
        {
            return !(g == a);
        }

        public static Profesor operator !=(Universidad g, EClases clases)
        {
            foreach (Profesor p in g.Insructores)
            {
                if (p != clases)
                    return p;
            }
            throw new SinProfesorException();
        }

        public static bool operator !=(Universidad g, Profesor profesor)
        {
            return !(g == profesor);
        }

        public static Universidad operator + (Universidad g, Alumno a)
        {
            if (g != a)
            {
                g.alumnos.Add(a);
            }
            else
            {
                throw new Excepciones.AlumnoRepetidoException();
            }
            return g;
        }

        public static Universidad operator +(Universidad g, EClases clases)
        {
            Jornada jornada;
            foreach (Profesor p in g.Insructores)
            {
                if (p == clases)
                {
                    jornada = new Jornada(clases, p);
                    foreach(Alumno a in g.Alumnos)
                    {
                        if (a == clases)
                            jornada += a;
                    }
                    g.Jornadas.Add(jornada);
                    break;
                }
            }
            return g;
        }

        public static Universidad operator +(Universidad g, Profesor profesor)
        {
            if (g != profesor)
                g.Insructores.Add(profesor);
            return g;
        }

        public override string ToString()
        {
            return MostrarDatos(this);
        }

    }
}
