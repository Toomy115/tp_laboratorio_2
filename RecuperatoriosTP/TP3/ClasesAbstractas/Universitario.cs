using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesAbstractas
{
    public abstract class Universitario : Persona
    {
        private int _legajo;

        public Universitario():this(0,"sin nombre","sin apellido","1",ENacionalidad.Argentino) { }

        public Universitario(int legajo, string nombre, string apellido, string dni, ENacionalidad nacionalidad)
            :base(nombre,apellido,dni,nacionalidad)
        {
            this._legajo = legajo;
        }

        protected virtual string MostrarDatos()
        {
            return base.ToString() + "\nLegajo numero: " + this._legajo;
        }

        protected abstract string ParticiparEnClase();
        

        public static bool operator == (Universitario pg1, Universitario pg2)
        {
            if ((pg1.DNI == pg2.DNI || pg1._legajo == pg2._legajo) && pg1.GetType() == pg2.GetType() )
                return true;
            else
                return false;
        }

        public static bool operator != (Universitario pg1, Universitario pg2)
        {
            return !(pg1 == pg2);
        }

        public override bool Equals(object obj)
        {
            if (obj is Universitario && (Universitario)obj == this) 
                return true;
            else
                return false;
        }

        }
}
