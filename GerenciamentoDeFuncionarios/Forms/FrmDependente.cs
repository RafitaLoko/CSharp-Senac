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
    public partial class FrmDependente : Form
    {
        private int funcionarioId;
        public FrmDependente(int Idfuncionario)
        {
            InitializeComponent();
            funcionarioId = Idfuncionario;
        }

        private void FrmDependente_Load(object sender, EventArgs e)
        {

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Dependente dependente = new Dependente();

            dependente.Nome = txtNomeDpe.Text;
            dependente.DataDeNascimento = DateTime.Parse(txtDataDeNascimentoDpe.Text);
            dependente.Parentesco = txtParentescoDpe.Text;
            dependente.IdFuncionario = funcionarioId;
        }
    }
}
