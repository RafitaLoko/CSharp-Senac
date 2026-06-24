using Microsoft.VisualBasic.ApplicationServices;
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


    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            

            string nomeUsuario = textBox1.Text;
            string senha = textBox2.Text;

            if (nomeUsuario == "admin" && senha == "1234")
            {
                

                this.Hide();
                string nome = textNomeUsuario.Text;
                new menuPrincipal(nome).ShowDialog();
                this.Show();


                
            }
            else
            {
                MessageBox.Show("Usuario ou senha estão incorretos", "Erro ao fazer login", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void lblUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
