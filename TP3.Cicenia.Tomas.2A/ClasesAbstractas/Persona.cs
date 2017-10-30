using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excepciones;

namespace EntidadesAbstractas
{
    public abstract class Persona
    {
        public enum ENacionalidad
        {
            Argentino, Extranjero
        }
        private string _nombre;
        private string _apellido;
        private int _dni;
        private ENacionalidad _nacionalidad;

        public string Apellido
        { get
            {
                return this._apellido;
            }
            set
            {
                if (this.ValidarNombreApellido(value) != "no")
                    this._apellido = value;
            }
        }

        public string Nombre
        {
            get
            {
                return this._nombre;
            }
            set
            {
                if (this.ValidarNombreApellido(value) != "no")
                    this._nombre = value;
            }
        }

        public int DNI
        {
            get
            {
                return this._dni;
            }
            set
            {
                this._dni = ValidarDni(this.Nacionalidad, value);
            }
        }

        public ENacionalidad Nacionalidad
        {
            get
            {
                return this._nacionalidad;
            }
            set
            {
                this._nacionalidad = value;
            }
        }

        public string StringToDNI { set {this.ValidarDni(this.Nacionalidad,value) ; } }

        public Persona()
            :this("sin nombre","sin apellido",ENacionalidad.Argentino)
        {        
        }

        public Persona (string nombre, string apellido, ENacionalidad nacionalidad)
            :this(nombre,apellido,1,nacionalidad)
        {
            
        }

        public Persona (string nombre, string apellido, int dni, ENacionalidad nacionalidad)
            :this(nombre,apellido,dni.ToString(),nacionalidad)
        {
            this.DNI = dni;
        }

        public Persona (string nombre, string apellido, string dni, ENacionalidad nacionalidad)          
        {
            this._apellido = apellido;
            this._nombre = nombre;
            this.Nacionalidad = nacionalidad;
            this.StringToDNI = dni;
        }

        private int ValidarDni (ENacionalidad nacionalidad, int dato)
        {
            if (nacionalidad == ENacionalidad.Argentino && (dato < 1 || dato > 89999999))
                throw new DniInvalidoException("El DNI es invalido", new NacionalidadInvalidaException("La nacionalidad no coincide con el DNI!"));
            else
            {
                if (nacionalidad == ENacionalidad.Extranjero && dato < 89999999)
                    throw new NacionalidadInvalidaException ("La nacionalidad no coincide con el DNI!");
            }
            return dato;
        }

        private int ValidarDni (ENacionalidad nacionalidad, string dato)
        {
            return ValidarDni(nacionalidad,int.Parse(dato));
        }

        private string ValidarNombreApellido (string dato)
        {
            if (dato.All(ch => Char.IsLetter(ch) || ch == ' '))
                return dato;
            else
            {
                return "no";
            }
        }

        public override string ToString()
        {
            return ("Nombre Completo:  " + this.Nombre + ", " + this.Apellido + " \nNacionalidad: " + this.Nacionalidad);
        }

    }
}
