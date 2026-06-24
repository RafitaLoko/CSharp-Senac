using System.Drawing.Text;

namespace SistemaDeLogin
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            string nomeUsuario = textUsuario.Text;
            string senha = textSenha.Text;

            if (nomeUsuario == "admin" && senha == "1234")
            {
                this.Hide();
                string nome = textNome.Text;
                new MenuPrincipal(nome).ShowDialog();
                this.Show();
                
            }
            else
            {
                MessageBox.Show("Usuario ou senha estão incorretos", "Erro ao fazer login", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
               
        }
    }
}
