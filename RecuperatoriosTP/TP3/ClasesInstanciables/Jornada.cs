using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Archivos;


namespace ClasesInstanciables
{
    public class Jornada
    {
        private List<Alumno> _alumnos;
        private Universidad.EClases _clase;
        private Profesor _instructor;

        public List<Alumno> Alumnos { get {return this._alumnos; } set { this._alumnos=value; } }
        public Universidad.EClases Clase { get {return this._clase; } set {this._clase=value; } }
        public Profesor Instructor { get {return this._instructor; } set { this._instructor = value; } }

        private Jornada () { this._alumnos = new List<Alumno>(); }

        public Jornada (Universidad.EClases clase, Profesor instructor)
            :this()
        {
            this._clase = clase;
            this._instructor = instructor;
        }

        public static bool Guardar (Jornada jornada)
        {
            string path = AppDomain.CurrentDomain.BaseDirectory;
            path += @"\jornada.txt";
            Texto texto = new Texto();
            bool retorno = texto.guardar(path, jornada.ToString());
            return retorno;
        }

        public static string Leer ()
        {
            string path = AppDomain.CurrentDomain.BaseDirectory;
            path += @"\jornada.txt";
            Texto texto = new Texto();
            string datos;
            texto.leer(path, out datos);
            return datos;
        }

        public static bool operator == (Jornada jornada1, Alumno alumno)
        {
            return alumno == jornada1.Clase;
        }

        public static bool operator !=(Jornada jornada1, Alumno alumno)
        {
            return !(jornada1 == alumno);
        }

        public static Jornada operator + (Jornada jornada1, Alumno alumno)
        {
            bool si = false;
            foreach (Alumno a in jornada1.Alumnos)
            {
                if (a == alumno)
                    si = true;
            }
            if (si == false)
                jornada1.Alumnos.Add(alumno);
            return jornada1;
        }

        public override string ToString()
        {
            string retorno = "Clases de: " + this.Clase + " por " + this.Instructor + "Alumnos: \n";
            foreach (Alumno a in this.Alumnos)
            {
                retorno += a.ToString();
            }
            retorno += ("<----------------------------------------------------------->");
            return retorno;
        }
    }
}
