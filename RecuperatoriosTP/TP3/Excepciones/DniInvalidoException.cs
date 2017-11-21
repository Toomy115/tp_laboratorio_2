using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class DniInvalidoException : Exception
    {
        private static string _mensajeBase = "DNI no valido";

        public DniInvalidoException ()
            :base()
        {
           
        }

        public DniInvalidoException (Exception e)
            :this(_mensajeBase,e)
        {

        }

        public DniInvalidoException (string message)
            :base(message)
        {
            
        }

        public DniInvalidoException (string message, Exception e)
            :base(message,e)
        {
           
        }
    }
}
