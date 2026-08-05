using GerenciamentoDeFuncionarios.Banco.Repositories;
using GerenciamentoDeFuncionarios.Modelos;
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
    public partial class FrmLoginFuncionario : Form
    {
        public FrmLoginFuncionario()
        {
            InitializeComponent();
        }

        private void FrmLoginFuncionario_Load(object sender, EventArgs e)
        {

        }

        private void TxtUsuarioFO_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtSenhaFO_TextChanged(object sender, EventArgs e)
        {

        }

        private async void BtnEntrarFO_Click(object sender, EventArgs e)
        {

            if (!int.TryParse(txtMatriculaId.Text, out int idFuncionario))
            {
                MessageBox.Show("Digite uma matrícula válida", "Erro ao fazer Login");
                return;
            }

            var funcionario = await FuncionarioRepository.ObterPorId(idFuncionario);


            if (funcionario != null && !string.IsNullOrEmpty(funcionario.Senha) && BCrypt.Net.BCrypt.Verify(txtPassword.Text, funcionario.Senha))
            {
                this.Hide();
                new FrmTelaPrincipal(idFuncionario).ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Matricula ou senha incorretas", "Erro ao fazer Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
