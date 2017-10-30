using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntidadesAbstractas;

namespace ClasesInstanciables
{
    public sealed class Alumno : Universitario 
    {
        public enum EEstadoCuenta
        {
            AlDia, Deudor, Becado
        }
        private Universidad.EClases _claseQueToma;
        private EEstadoCuenta _estadoCuenta;

        public Alumno () :this (0, "Sin nombre", "Sin apellido", "2", ENacionalidad.Argentino, Universidad.EClases.Laboratorio) { }

        public Alumno (int id, string nombre, string apellido, string dni, ENacionalidad nacionalidad, Universidad.EClases clasesQueToma)
            :this(id,nombre,apellido,dni,nacionalidad,clasesQueToma,EEstadoCuenta.AlDia)
        {
            
        }

        public Alumno (int id, string nombre, string apellido, string dni, ENacionalidad nacionalidad, Universidad.EClases clasesQueToma, EEstadoCuenta estadoCuenta)
            :base(id,nombre,apellido,dni,nacionalidad)
        {
            this._estadoCuenta = estadoCuenta;
            this._claseQueToma = clasesQueToma;
        }

        protected override string MostrarDatos()
        {
            if(this._estadoCuenta == EEstadoCuenta.Becado)       
                return base.MostrarDatos() + "Estado de la cuenta: Becado";            
            else
            {
                if (this._estadoCuenta == EEstadoCuenta.AlDia)
                    return base.MostrarDatos() + "Estado de la cuenta: Al Dia";
                else
                    return base.MostrarDatos() + "Estado de la cuenta: Deudor";
            }
            
        }

        protected override string ParticiparEnClase()
        {
            return "Toma clase de: " + this._claseQueToma.ToString();
        }

        public static bool operator == (Alumno a, Universidad.EClases clases)
        {
            if (a._claseQueToma == clases && a._estadoCuenta != EEstadoCuenta.Deudor)
                return true;
            else
                return false;
        }

        public static bool operator != (Alumno a, Universidad.EClases clases)
        {
             if (a._claseQueToma != clases)
                 return true;
             else
                 return false;          
        }

        public override string ToString()
        {
            return this.MostrarDatos();
        }

    }
}
