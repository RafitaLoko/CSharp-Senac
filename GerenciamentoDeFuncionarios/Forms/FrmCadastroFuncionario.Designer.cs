namespace GerenciamentoDeFuncionarios.Forms
{
    partial class FrmCadastroFuncionario
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            txtNome = new TextBox();
            label2 = new Label();
            txtEmail = new TextBox();
            label3 = new Label();
            txtSalario = new TextBox();
            groupBox1 = new GroupBox();
            rbFeminino = new RadioButton();
            rbMasculino = new RadioButton();
            groupBox2 = new GroupBox();
            rbAutonomo = new RadioButton();
            rbPj = new RadioButton();
            rbClt = new RadioButton();
            btnSalvar = new Button();
            lblErros = new Label();
            lblSenha = new Label();
            txtSenha = new TextBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(42, 37);
            label1.Name = "label1";
            label1.Size = new Size(65, 25);
            label1.TabIndex = 0;
            label1.Text = "Nome:";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(42, 65);
            txtNome.Name = "txtNome";
            txtNome.PlaceholderText = "João da Silva";
            txtNome.Size = new Size(309, 31);
            txtNome.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(42, 126);
            label2.Name = "label2";
            label2.Size = new Size(58, 25);
            label2.TabIndex = 2;
            label2.Text = "Email:";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(42, 154);
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "joao.silva@email.com";
            txtEmail.Size = new Size(309, 31);
            txtEmail.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(42, 214);
            label3.Name = "label3";
            label3.Size = new Size(69, 25);
            label3.TabIndex = 4;
            label3.Text = "Salario:";
            // 
            // txtSalario
            // 
            txtSalario.Location = new Point(42, 242);
            txtSalario.Name = "txtSalario";
            txtSalario.PlaceholderText = "2000 Somente valores numéricos";
            txtSalario.Size = new Size(309, 31);
            txtSalario.TabIndex = 5;
            txtSalario.KeyPress += txtSalario_keyPress;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rbFeminino);
            groupBox1.Controls.Add(rbMasculino);
            groupBox1.Location = new Point(422, 35);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(300, 71);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Sexo:";
            // 
            // rbFeminino
            // 
            rbFeminino.AutoSize = true;
            rbFeminino.Location = new Point(139, 36);
            rbFeminino.Name = "rbFeminino";
            rbFeminino.Size = new Size(110, 29);
            rbFeminino.TabIndex = 1;
            rbFeminino.Text = "Feminino";
            rbFeminino.UseVisualStyleBackColor = true;
            // 
            // rbMasculino
            // 
            rbMasculino.AutoSize = true;
            rbMasculino.Checked = true;
            rbMasculino.Location = new Point(7, 35);
            rbMasculino.Name = "rbMasculino";
            rbMasculino.Size = new Size(117, 29);
            rbMasculino.TabIndex = 0;
            rbMasculino.TabStop = true;
            rbMasculino.Text = "Masculino";
            rbMasculino.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(rbAutonomo);
            groupBox2.Controls.Add(rbPj);
            groupBox2.Controls.Add(rbClt);
            groupBox2.Location = new Point(422, 126);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(300, 79);
            groupBox2.TabIndex = 7;
            groupBox2.TabStop = false;
            groupBox2.Text = "Tipo de Contrato:";
            // 
            // rbAutonomo
            // 
            rbAutonomo.AutoSize = true;
            rbAutonomo.Location = new Point(133, 32);
            rbAutonomo.Name = "rbAutonomo";
            rbAutonomo.Size = new Size(124, 29);
            rbAutonomo.TabIndex = 2;
            rbAutonomo.Text = "Autônomo";
            rbAutonomo.UseVisualStyleBackColor = true;
            // 
            // rbPj
            // 
            rbPj.AutoSize = true;
            rbPj.Location = new Point(75, 32);
            rbPj.Name = "rbPj";
            rbPj.Size = new Size(52, 29);
            rbPj.TabIndex = 1;
            rbPj.Text = "PJ";
            rbPj.UseVisualStyleBackColor = true;
            // 
            // rbClt
            // 
            rbClt.AutoSize = true;
            rbClt.Checked = true;
            rbClt.Location = new Point(6, 32);
            rbClt.Name = "rbClt";
            rbClt.Size = new Size(58, 29);
            rbClt.TabIndex = 0;
            rbClt.TabStop = true;
            rbClt.Text = "Clt";
            rbClt.UseVisualStyleBackColor = true;
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(640, 354);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(115, 55);
            btnSalvar.TabIndex = 8;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // lblErros
            // 
            lblErros.AutoSize = true;
            lblErros.ForeColor = Color.Red;
            lblErros.Location = new Point(42, 315);
            lblErros.Name = "lblErros";
            lblErros.Size = new Size(0, 25);
            lblErros.TabIndex = 9;
            // 
            // lblSenha
            // 
            lblSenha.AutoSize = true;
            lblSenha.Location = new Point(42, 313);
            lblSenha.Name = "lblSenha";
            lblSenha.Size = new Size(64, 25);
            lblSenha.TabIndex = 10;
            lblSenha.Text = "Senha:";
            lblSenha.Click += label4_Click;
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(42, 341);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(150, 31);
            txtSenha.TabIndex = 11;
            txtSenha.UseSystemPasswordChar = true;
            // 
            // FrmCadastroFuncionario
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtSenha);
            Controls.Add(lblSenha);
            Controls.Add(lblErros);
            Controls.Add(btnSalvar);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(txtSalario);
            Controls.Add(label3);
            Controls.Add(txtEmail);
            Controls.Add(label2);
            Controls.Add(txtNome);
            Controls.Add(label1);
            Name = "FrmCadastroFuncionario";
            Text = "FrmCadastroFuncionario";
            Load += FrmCadastroFuncionario_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtNome;
        private Label label2;
        private TextBox txtEmail;
        private Label label3;
        private TextBox txtSalario;
        private GroupBox groupBox1;
        private RadioButton rbFeminino;
        private RadioButton rbMasculino;
        private GroupBox groupBox2;
        private RadioButton rbAutonomo;
        private RadioButton rbPj;
        private RadioButton rbClt;
        private Button btnSalvar;
        private Label lblErros;
        private Label lblSenha;
        private TextBox txtSenha;
    }
}