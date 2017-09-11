using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP01
{
    public class Calculadora
    {
        public static double operar (Numero numero1, Numero numero2, string operador)
        {
            double resultado=0;
            double num1 = numero1.getNumero();
            double num2 = numero2.getNumero();
            operador = validarOperador(operador);
            switch (operador)
            {
                case "+":
                    resultado =  num1 + num2;
                    break;

                case "-":
                    resultado = num1 - num2;
                    break;

                case "*":
                    resultado = num1 * num2;
                    break;

                case "/":
                    if (num2!=0)
                    {
                        resultado = num1 / num2;
                    }
                    else
                    {                       
                        System.Windows.Forms.MessageBox.Show("No se puede dividir por 0!");
                    }
                    break;
            }
            return resultado;
        }

        public static string validarOperador (string operador)
        {
            if (operador!="+" && operador!="-" && operador!="*" && operador!="/")
            {
                operador = "+";
            }
            return operador;
        }
    }
}
