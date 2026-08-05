using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GerenciamentoDeFuncionarios.Forms
{
    public partial class FormLoginAdministrador : Form
    {
        public FormLoginAdministrador()
        {
            InitializeComponent();
        }

        private void FormLoginAdministrador_Load(object sender, EventArgs e)
        {

        }

        private void BtnEntrar_Click(object sender, EventArgs e)
        {
            if (TxtUsuario.Text == "admin" && TxtSenha.Text == "1234")
            {
                this.Hide();
                new FrmTelaPrincipal().ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Usuário ou senha incorretos", "Erro ao fazrt login", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
