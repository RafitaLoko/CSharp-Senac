using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculadoraDoWindows.cs
{
    public partial class Calculadora : Form
    {
        private double NumeroAtual = 0;
        private string Operador = "";
        public Calculadora()
        {
            InitializeComponent();


        }

        private void Calculadora_Load(object sender, EventArgs e)
        {

        }

        private void Btn1_Click(object sender, EventArgs e)
        {
            Button botaoPressionado = (Button)sender;
            lblResultado.Text += botaoPressionado.Text;
        }

        private void Btn2_Click(object sender, EventArgs e)
        {
            Button botaoPressionado = (Button)sender;
            lblResultado.Text += botaoPressionado.Text;
        }

        private void Btn3_Click(object sender, EventArgs e)
        {
            Button botaoPressionado = (Button)sender;
            lblResultado.Text += botaoPressionado.Text;
        }

        private void Btn4_Click(object sender, EventArgs e)
        {
            Button botaoPressionado = (Button)sender;
            lblResultado.Text += botaoPressionado.Text;
        }

        private void Btn5_Click(object sender, EventArgs e)
        {
            Button botaoPressionado = (Button)sender;
            lblResultado.Text += botaoPressionado.Text;
        }

        private void Btn6_Click(object sender, EventArgs e)
        {
            Button botaoPressionado = (Button)sender;
            lblResultado.Text += botaoPressionado.Text;
        }

        private void Btn7_Click(object sender, EventArgs e)
        {
            Button botaoPressionado = (Button)sender;
            lblResultado.Text += botaoPressionado.Text;
        }

        private void Btn8_Click(object sender, EventArgs e)
        {
            Button botaoPressionado = (Button)sender;
            lblResultado.Text += botaoPressionado.Text;
        }

        private void Btn9_Click(object sender, EventArgs e)
        {
            Button botaoPressionado = (Button)sender;
            lblResultado.Text += botaoPressionado.Text;
        }

        private void Btn0_Click(object sender, EventArgs e)
        {
            Button botaoPressionado = (Button)sender;
            lblResultado.Text += botaoPressionado.Text;
        }

        private void lblResultado_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnSomar_Click(object sender, EventArgs e)
        {
            NumeroAtual = Convert.ToDouble(lblResultado.Text);
            Operador = "+";
            lblResultado.Text = "";
        }

        private void BtnSubtrair_Click(object sender, EventArgs e)
        {
            NumeroAtual = Convert.ToDouble(lblResultado.Text);
            Operador = "-";
            lblResultado.Text = "";
        }

        private void BtnMultiplicar_Click(object sender, EventArgs e)
        {
            NumeroAtual = Convert.ToDouble(lblResultado.Text);
            Operador = "*";
            lblResultado.Text = "";

        }

        private void BtnDividir_Click(object sender, EventArgs e)
        {
            NumeroAtual = Convert.ToDouble(lblResultado.Text);
            Operador = "/";
            lblResultado.Text = "";

        }

        private void BtnApagar_Click(object sender, EventArgs e)
        {
            if (lblResultado.Text.Length > 0)
            {
                lblResultado.Text = lblResultado.Text.Substring(0, lblResultado.Text.Length - 1);
            }
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            lblResultado.Text = "";
            NumeroAtual = 0;
            Operador = "";
        }

        private void BtnVirgula_Click(object sender, EventArgs e)
        {
            if (!lblResultado.Text.Contains(","))
            {
                lblResultado.Text += ",";
            }
        }

        private void BtnIgual_Click(object sender, EventArgs e)
        {
            double segundoNumero = Convert.ToDouble(lblResultado.Text);
            double resultado = 0;

            switch (Operador)
            {
                case "+":
                    resultado = NumeroAtual + segundoNumero; break;
                case "-":
                    resultado = NumeroAtual - segundoNumero; break;
                case "*":
                    resultado = NumeroAtual * segundoNumero; break;
                case "/":
                    if (segundoNumero != 0)
                        resultado = NumeroAtual / segundoNumero;
                        else
                        {
                            MessageBox.Show("Não é possivel dividir 0");
                            return;
                        }
                        break;
                    }
                    lblResultado.Text = resultado.ToString();
            } 
    }
}
