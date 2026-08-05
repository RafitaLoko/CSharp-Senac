using GerenciamentoDeFuncionarios.Banco.Repositories;
using GerenciamentoDeFuncionarios.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace GerenciamentoDeFuncionarios.Forms
{
    public partial class frmAtualizacaoFuncionarioNovo : Form
    {

        private int idFuncionario;


        public frmAtualizacaoFuncionarioNovo(int idFuncionario)
        {
            InitializeComponent();

            this.idFuncionario = idFuncionario;

            Load += frmAtualizacaoFuncionarioNovo_Load;
        }


        private async void frmAtualizacaoFuncionarioNovo_Load(object sender, EventArgs e)
        {
            var funcionario = await FuncionarioRepository.ObterPorId(this.idFuncionario);

            txtNome.Text = funcionario.Nome;
            txtEmail.Text = funcionario.Email;
            txtSalario.Text = funcionario.Salario.ToString();
            txtSenha.Text = funcionario.Senha?.ToString() ??"";

            switch (funcionario.Sexo)
            {
                case 'M':
                    rbMasculino.Checked = true;
                    break;
                case 'F':
                    rbFeminino.Checked = true;
                    break;
            }

            switch (funcionario.TipoDeContrato)
            {
                case "CLT":
                    rbClt.Checked = true;
                    break;
                case "PJ":
                    rbPj.Checked = true;
                    break;
                case "Autonomo":
                    rbAutonomo.Checked = true;
                    break;
            }
        }

        private async void btnSalvar_Click(object sender, EventArgs e)
        {
            var funcionario = await FuncionarioRepository.ObterPorId(this.idFuncionario);

            funcionario.SetEmail(txtEmail.Text);
            funcionario.SetNome(txtNome.Text);
            funcionario.SetSalario(decimal.Parse(txtSalario.Text));
            funcionario.SetSexo(rbMasculino.Checked ? 'M' : 'F');
            funcionario.SetTipoDeContrato(rbClt.Checked ? "CLT" : rbPj.Checked ? "PJ" : "Autonomo");             
            funcionario.SetSenha(BCrypt.Net.BCrypt.HashPassword(txtSenha.Text));

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
                await FuncionarioRepository.Editar(funcionario);


                this.Close();

            }
        }
    }


}
