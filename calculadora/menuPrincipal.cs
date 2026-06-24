using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculadora
{
    public partial class menuPrincipal : Form
    {
        public menuPrincipal()
        {
            InitializeComponent();
        }

        private void MenuPrincipal_Click(object sender, EventArgs e)
        {

        }
        public menuPrincipal(string nomeUsuario)

        {
            InitializeComponent();

            lblUsuario.Text = $"Bem vindo {nomeUsuario}";



        }


        private void menuPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void BtnCalculadora_Click(object sender, EventArgs e)
        {
            Calculadora calc = new Calculadora();
            calc.Show();
        }
    }
} 
