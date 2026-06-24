using System.Drawing.Text;

namespace calculadora
{
    public partial class Calculadora : Form
    {
        public Calculadora()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnSomar_Click(object sender, EventArgs e)
        {
            double num1 = Convert.ToDouble(textBox1.Text);
            double num2 = Convert.ToDouble(textBox2.Text);

            double soma = num1 + num2;

            lblResultado.Text =$"Resultado:  {soma}";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Subtarir nao apagar
            double num1 = Convert.ToDouble(textBox1.Text);
            double num2 = Convert.ToDouble(textBox2.Text);

            double subtracao = num1 - num2;

            lblResultado.Text = $"Resultado:  {subtracao}";
        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            double num1 = Convert.ToDouble(textBox1.Text);
            double num2 = Convert.ToDouble(textBox2.Text);

            double multiplicar = num1 * num2;

            lblResultado.Text = $"Resultado:  {multiplicar}";
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            double num1 = Convert.ToDouble(textBox1.Text);
            double num2 = Convert.ToDouble(textBox2.Text);

            double divisao = num1 / num2;

            lblResultado.Text = $"Resultado:  {divisao}";
        }

        private void lblResultado_Click(object sender, EventArgs e)
        {

        }
    }
}
