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
    public partial class FrmTelaPrincipal : Form
    {
        private int? idFuncionarioLogado = null;
        public FrmTelaPrincipal()
        {
            InitializeComponent();

            Load += FrmTelaPrincipal_Load1;
        }
        public FrmTelaPrincipal(int idFuncionario)
        { //Bagulho do Funcionario
            InitializeComponent();
            idFuncionarioLogado = idFuncionario;

            BtnExcluir.Visible = false;
            BtnNovo.Visible = false;
            btnLimpar.Visible = false;
            btnBuscar.Visible = false;
            cbFiltro.Visible = false;
            txtCampo.Visible = false;
        }

        private async void FrmTelaPrincipal_Load1(object? sender, EventArgs e)
        {
            var funcionarios = await FuncionarioRepository.ObterTodos();

            dgvFuncionarios.DataSource = new BindingList<Funcionario>(funcionarios.ToList());


            cbFiltro.Items.Add("Todos");
            cbFiltro.Items.Add("CLT");
            cbFiltro.Items.Add("PJ");
            cbFiltro.Items.Add("AUTONOMO");
            cbFiltro.SelectedIndex = 0;
        }

        private void FrmTelaPrincipal_Load(object sender, EventArgs e)
        {

        }

        private async void BtnNovo_Click(object sender, EventArgs e)
        {
            new FrmCadastroFuncionario().ShowDialog();

            await AtualizarTabela();
        }
        private async Task AtualizarTabela()
        {
            var funcionarios = await FuncionarioRepository.ObterTodos();

            dgvFuncionarios.DataSource = new BindingList<Funcionario>(funcionarios.ToList());
        }

        private async void BtnExcluir_Click(object sender, EventArgs e)
        {
            string nomeFuncionario = dgvFuncionarios.SelectedRows[0].Cells[1].Value.ToString();

            var retorno = MessageBox.Show($"Tem certeza que deseja excluir o funcionário {nomeFuncionario}?", "Exclusão de funcionários", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (retorno == DialogResult.Yes)
            {
                int idFuncionario = (int)dgvFuncionarios.SelectedRows[0].Cells[0].Value;

                await FuncionarioRepository.DeletarPorId(idFuncionario);

                MessageBox.Show($"O funcionário {nomeFuncionario} foi excluído com sucesso", "Exclusão de funcionarios", MessageBoxButtons.OK, MessageBoxIcon.Information);

                await AtualizarTabela();
            }
        }

        private async void BtnEditar_Click(object sender, EventArgs e)
        {


            //int idFuncionario = (int)dgvFuncionarios.CurrentRow.Cells[0].Value;

            //new frmAtualizacaoFuncionarioNovo(idFuncionario).ShowDialog();

            //await AtualizarTabela();

            int idParaEditar;

            if (idFuncionarioLogado.HasValue)
            {
                idParaEditar = idFuncionarioLogado.Value;
            }
            else
            {
                if (dgvFuncionarios.CurrentRow == null)
                {
                    MessageBox.Show("Selecione um funcionario para editar.");
                    return;
                }
                idParaEditar = (int)dgvFuncionarios.CurrentRow.Cells[0].Value;
            }
            new frmAtualizacaoFuncionarioNovo(idParaEditar).ShowDialog();
            await AtualizarTabela();
        }

        private void txtCampo_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbFiltro_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dgvFuncionarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private async void btnBuscar_Click(object sender, EventArgs e)
        {

            var termo = txtCampo.Text;
            var tipoContrato = cbFiltro.SelectedItem?.ToString() ?? "Todos";

            var funcionarios = await FuncionarioRepository.BuscarPorNomeOuEmail(termo, tipoContrato);

            dgvFuncionarios.DataSource = new BindingList<Funcionario>(funcionarios);

            if (funcionarios.Count == 0)
            {
                MessageBox.Show("Nenhum funcionario encontrado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
             //Nada chefia
            }

        }
                private async void btnLimpar_Click(object sender, EventArgs e)
                {
                    txtCampo.Text = "";
                    await AtualizarTabela();
                }
    }
}
