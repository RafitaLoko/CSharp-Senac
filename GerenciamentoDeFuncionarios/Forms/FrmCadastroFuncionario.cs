using GerenciamentoDeFuncionarios.Banco.Repositories;
using GerenciamentoDeFuncionarios.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GerenciamentoDeFuncionarios.Forms
{
    public partial class FrmCadastroFuncionario : Form
    {
        public FrmCadastroFuncionario()
        {
            InitializeComponent();
        }

        private async void btnSalvar_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text;
            string email = txtEmail.Text;
            char sexo = rbMasculino.Checked ? 'M' : 'F';
            string tipoContrato = rbClt.Checked ? "CLT" : rbPj.Checked ? "PJ" : "Autonomo";
            decimal salario = decimal.Parse(txtSalario.Text);
            var dataDeCadastro = DateTime.Now;
            string senha = BCrypt.Net.BCrypt.HashPassword(txtSenha.Text);

            var funcionario = new Funcionario(nome, email, sexo, tipoContrato, salario, dataDeCadastro);

            var stringBuilder = new StringBuilder();
            var listaDeErros = new List<ValidationResult>();

            var contexto = new ValidationContext(funcionario);
            Validator.TryValidateObject(funcionario, contexto, listaDeErros, true);

            if (listaDeErros.Count > 0)
            {
                // adiciona os erros no stringBuilder e exibe na tela
                foreach (var erro in listaDeErros)
                {
                    stringBuilder.Append(erro.ErrorMessage + "\n");
                }

                lblErros.Text = stringBuilder.ToString();

            }
            else
            {
                await FuncionarioRepository.Adicionar(funcionario);

               

                this.Close();
            }




            // O ? alí em cima é esse if aqui em baixo, só que de forma simplificada.
            // char sexo;
            //if (rbMasculino.Checked)
            //{
            //    sexo = "M";
            //}
            //else
            //{
            //    sexo = "F";
            //}
        }

        private void FrmCadastroFuncionario_Load(object sender, EventArgs e)
        {

        }

        private void txtSalario_keyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar))
            {
                return;
            }

            if (!char.IsDigit(e.KeyChar) && e.KeyChar != ',')
            {
                e.Handled = true;
            }

            if (e.KeyChar == ',' && ((TextBox)sender).Text.Contains(","))
            {
                e.Handled = true;
            }

            if (e.KeyChar == ',' && ((TextBox)sender).Text == string.Empty)
            {
                e.Handled = true;
            }


        }

        

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
