using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP01
{
    public class Numero
    {
        private double _numero;
        
        public double getNumero()
        {
            return this._numero;
        }

        public Numero()
        {
            this._numero = 0;
        }

        public Numero(double numero)
        {
            this._numero = numero;
        }

        public Numero (string numero)
        {
            setNumero(numero);
        }

        private void setNumero (string numero)
        {
            double num;
            if ((num = validarNumero(numero)) != 0)
                this._numero = num;
        }

        private static double validarNumero (string numeroString)
        {
            double retorno;
            if (!double.TryParse(numeroString,out retorno))
            {
                retorno = 0;
            }
            return retorno;
        }

        
    }
}
