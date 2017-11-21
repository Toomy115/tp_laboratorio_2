using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Numero
    {
        private double _numero;

        public string SetNumero { set { this._numero = ValidarNumero(value); } }
        public double GetNumero { get { return this._numero; } }

        public Numero()
        {
            this._numero = 0;
        }

        public Numero(double numero)
        {
            this._numero = numero;
        }

        public Numero(string strNumero)
        {
            SetNumero = strNumero;
        }

        public static string BinarioDecimal(string binario)
        {
            int numero = 0;
            for(int x = binario.Length - 1, y=0 ; x >= 0 ; x-- , y++)
            {
                if (binario[x] == '0' || binario[x] == '1')
                    numero += (int)(int.Parse(binario[x].ToString()) * Math.Pow(2, y));
                else
                    return "Valor invalido";
            }
            return Convert.ToString(numero);
        }

        public static string DecimalBinario(double numero)
        {
            int conversion;
            conversion = Convert.ToInt32(numero);
            string binario = "";
            if (numero > 0)
            {
                while (numero > 0)
                {
                    if (numero % 2 == 0)
                    {
                        binario = "0" + binario;
                    }
                    else
                    {
                        binario = "1" + binario;
                    }

                    numero = (int)numero / 2;
                }
            }
            else if (numero == 0)
            {
                binario = "0";
            }
            else
            {
                binario = "Valor invalido";
            }

            return binario;
        }

        public static string DecimalBinario(string numero)
        {
            double v;
            if (double.TryParse(numero, out v))
                return DecimalBinario(v);
            else
                return "Valor invalido";

        }

        private double ValidarNumero(string strNumero)
        {
            double retorno;
            if (double.TryParse(strNumero, out retorno))
                return retorno;
            else
                return 0;
        }

        public static double operator -(Numero n1, Numero n2)
        {
            return (n1.GetNumero - n2.GetNumero);
        }

        public static double operator * (Numero n1, Numero n2)
        {
            return (n1.GetNumero * n2.GetNumero);
        }

        public static double operator / (Numero n1, Numero n2)
        {
            if (n2.GetNumero != 0)
                return (n1.GetNumero / (n2.GetNumero));
            else
                throw new DivideByZeroException();
        }

        public static double operator + (Numero n1, Numero n2)
        {
            return (n1.GetNumero + n2.GetNumero);
        }

    }
}
