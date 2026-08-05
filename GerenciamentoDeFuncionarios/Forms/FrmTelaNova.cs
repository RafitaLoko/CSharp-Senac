using GerenciamentoDeFuncionarios.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GerenciamentoDeFuncionarios
{
    public partial class FrmTelaNova : Form
    {
        public FrmTelaNova()
        {
            InitializeComponent();
        }

        private void FrmTelaNova_Load(object sender, EventArgs e)
        {

        }

        private void btn1SouAdm_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FormLoginAdministrador().ShowDialog();
            this.Show();

        }

        private void btnSouFuncionario_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FrmLoginFuncionario().ShowDialog();
            this.Show();
        }
    }
}
