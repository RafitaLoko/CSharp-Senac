namespace GerenciamentoDeFuncionarios.Forms
{
    partial class FrmDependente
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
            lblNome = new Label();
            txtNomeDpe = new TextBox();
            lblDataDeNascimento = new Label();
            txtDataDeNascimentoDpe = new TextBox();
            lblParentesco = new Label();
            txtParentescoDpe = new TextBox();
            btnCadastrar = new Button();
            SuspendLayout();
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNome.Location = new Point(12, 9);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(80, 32);
            lblNome.TabIndex = 0;
            lblNome.Text = "Nome";
            // 
            // txtNomeDpe
            // 
            txtNomeDpe.Location = new Point(12, 44);
            txtNomeDpe.Name = "txtNomeDpe";
            txtNomeDpe.Size = new Size(150, 31);
            txtNomeDpe.TabIndex = 1;
            // 
            // lblDataDeNascimento
            // 
            lblDataDeNascimento.AutoSize = true;
            lblDataDeNascimento.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDataDeNascimento.Location = new Point(12, 113);
            lblDataDeNascimento.Name = "lblDataDeNascimento";
            lblDataDeNascimento.Size = new Size(231, 32);
            lblDataDeNascimento.TabIndex = 2;
            lblDataDeNascimento.Text = "Data de Nascimento";
            // 
            // txtDataDeNascimentoDpe
            // 
            txtDataDeNascimentoDpe.Location = new Point(12, 148);
            txtDataDeNascimentoDpe.Name = "txtDataDeNascimentoDpe";
            txtDataDeNascimentoDpe.PlaceholderText = "00/00/0000";
            txtDataDeNascimentoDpe.Size = new Size(150, 31);
            txtDataDeNascimentoDpe.TabIndex = 3;
            // 
            // lblParentesco
            // 
            lblParentesco.AutoSize = true;
            lblParentesco.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblParentesco.Location = new Point(12, 219);
            lblParentesco.Name = "lblParentesco";
            lblParentesco.Size = new Size(129, 32);
            lblParentesco.TabIndex = 4;
            lblParentesco.Text = "Parentesco";
            // 
            // txtParentescoDpe
            // 
            txtParentescoDpe.Location = new Point(12, 254);
            txtParentescoDpe.Name = "txtParentescoDpe";
            txtParentescoDpe.Size = new Size(150, 31);
            txtParentescoDpe.TabIndex = 5;
            // 
            // btnCadastrar
            // 
            btnCadastrar.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCadastrar.Location = new Point(2, 388);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(150, 59);
            btnCadastrar.TabIndex = 6;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = true;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // FrmDependente
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCadastrar);
            Controls.Add(txtParentescoDpe);
            Controls.Add(lblParentesco);
            Controls.Add(txtDataDeNascimentoDpe);
            Controls.Add(lblDataDeNascimento);
            Controls.Add(txtNomeDpe);
            Controls.Add(lblNome);
            Name = "FrmDependente";
            Text = "FrmDependente";
            Load += FrmDependente_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNome;
        private TextBox txtNomeDpe;
        private Label lblDataDeNascimento;
        private TextBox txtDataDeNascimentoDpe;
        private Label lblParentesco;
        private TextBox txtParentescoDpe;
        private Button btnCadastrar;
    }
}