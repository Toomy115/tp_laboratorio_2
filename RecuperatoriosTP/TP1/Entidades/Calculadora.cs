using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Calculadora
    {
        public static double Operar(Numero numero1, Numero numero2, string operador)
        {
            operador = ValidarOperador(operador);
            switch(operador)
            {
                case "+":
                    return numero1 + numero2;
                case "-":
                    return numero1 - numero2;
                case "*":
                    return numero1 * numero2;
                case "/":
                    return numero1 / numero2;                       
            }
            return 1;
        }

        private static string ValidarOperador(string operador)
        {
            if (operador == "+" || operador == "-" || operador == "*" || operador == "/")
            {
                return operador;
            }
            else
            {
                return "+";
            }
        }
    }
}
