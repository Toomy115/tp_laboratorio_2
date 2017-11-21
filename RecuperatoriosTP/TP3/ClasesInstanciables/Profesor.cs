using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntidadesAbstractas;

namespace ClasesInstanciables
{
    public sealed class Profesor : Universitario
    {
        private Queue<Universidad.EClases> _clasesDelDia;
        private static Random _random;

        static Profesor () { _random = new Random(); }

        public Profesor () :this(0,null,null,null,ENacionalidad.Argentino) {  } 
        
        public Profesor (int id, string nombre, string apellido, string dni, ENacionalidad nacionalidad)
            :base(id,nombre,apellido,dni,nacionalidad) 
            
        {
            this._clasesDelDia = new Queue<Universidad.EClases>();
            this._randomClases();

        }

        private void _randomClases()
        {
            int clase = _random.Next(0, 4);
            this._clasesDelDia.Enqueue((Universidad.EClases)clase);
        }

        protected override string MostrarDatos ()
        {
            return base.MostrarDatos();
        }

        protected override string ParticiparEnClase ()
        {
            string retorno = "Clases del dia: \n";
            foreach (Universidad.EClases clase in this._clasesDelDia)
            {
                retorno += clase.ToString();
                retorno += "\n";
            }
            return retorno;
        }

        public static bool operator == (Profesor profesor , Universidad.EClases clases)
        {
            foreach (Universidad.EClases clase in profesor._clasesDelDia)
            {
                if (clase == clases)
                    return true;
            }
            return false;
        }

        public static bool operator != (Profesor profesor , Universidad.EClases clases)
        {
            return !(profesor == clases);
        }

        public override string ToString()
        {
            return this.MostrarDatos() + "\n" + this.ParticiparEnClase();
        }
    }
}
