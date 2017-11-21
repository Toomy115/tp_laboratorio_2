using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace CalculadoraFormulario
{
    public partial class LaCalculadora : Form
    {
        public LaCalculadora()
        {
            InitializeComponent();
            this.cmbOperacion.SelectedIndex = 0;
        }

        private void Limpiar ()
        {
            txtNumero1.Clear();
            txtNumero2.Clear();
            lblResultado.Text = "Resultado";
            cmbOperacion.SelectedItem = "+";
            lblConvertido.Text = " ";
            txtNumero1.Focus();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.Limpiar();
        }

        private static double Operar(string numero1, string numero2, string operador)
        {
            Numero Numero1 = new Numero(numero1);
            Numero Numero2 = new Numero(numero2);

            return Calculadora.Operar(Numero1, Numero2, operador);
        }

        private void btnOperar_Click(object sender, EventArgs e)
        {
            if (txtNumero1.Text != "" && txtNumero2.Text != "")
            {             
                try
                {
                    lblResultado.Text = Convert.ToString(Operar(txtNumero1.Text,txtNumero2.Text,cmbOperacion.Text));
                }
                catch (DivideByZeroException) { MessageBox.Show("No se puede dividir por cero"); }
            }
            else
            {
                MessageBox.Show("Debe completar todos los campos");
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnABinario_Click(object sender, EventArgs e)
        {
            double v;
            if (lblResultado.Text != "Resultado")
            {            
                this.lblConvertido.Text = ("= " + Numero.DecimalBinario(lblResultado.Text));              
            }
            else
                MessageBox.Show("No se encontro resultado para convertir");
        }

        private void btnADecimal_Click(object sender, EventArgs e)
        {
            if (lblResultado.Text != "Resultado")
            {                
                this.lblConvertido.Text = ("= " + Numero.BinarioDecimal(lblResultado.Text));
            }
            else
                MessageBox.Show("No se encontro resultado para convertir");
        }
    }
}
