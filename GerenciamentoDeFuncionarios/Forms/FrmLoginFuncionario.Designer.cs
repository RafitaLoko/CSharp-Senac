namespace GerenciamentoDeFuncionarios.Forms
{
    partial class FrmLoginFuncionario
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
            BtnEntrarFO = new Button();
            txtMatriculaId = new TextBox();
            lblMatricula = new Label();
            lblPassword = new Label();
            txtPassword = new TextBox();
            SuspendLayout();
            // 
            // BtnEntrarFO
            // 
            BtnEntrarFO.Location = new Point(339, 317);
            BtnEntrarFO.Name = "BtnEntrarFO";
            BtnEntrarFO.Size = new Size(112, 34);
            BtnEntrarFO.TabIndex = 10;
            BtnEntrarFO.Text = "Entrar";
            BtnEntrarFO.UseVisualStyleBackColor = true;
            BtnEntrarFO.Click += BtnEntrarFO_Click;
            // 
            // txtMatriculaId
            // 
            txtMatriculaId.Location = new Point(318, 108);
            txtMatriculaId.Name = "txtMatriculaId";
            txtMatriculaId.Size = new Size(150, 31);
            txtMatriculaId.TabIndex = 11;
            // 
            // lblMatricula
            // 
            lblMatricula.AutoSize = true;
            lblMatricula.Location = new Point(285, 64);
            lblMatricula.Name = "lblMatricula";
            lblMatricula.Size = new Size(221, 25);
            lblMatricula.TabIndex = 12;
            lblMatricula.Text = "Insira sua MATRICULA (id):";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(359, 178);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(64, 25);
            lblPassword.TabIndex = 13;
            lblPassword.Text = "Senha:";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(318, 227);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(150, 31);
            txtPassword.TabIndex = 14;
            txtPassword.UseSystemPasswordChar = true;
            txtPassword.TextChanged += txtPassword_TextChanged;
            // 
            // FrmLoginFuncionario
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtPassword);
            Controls.Add(lblPassword);
            Controls.Add(lblMatricula);
            Controls.Add(txtMatriculaId);
            Controls.Add(BtnEntrarFO);
            Name = "FrmLoginFuncionario";
            Text = "FrmLoginFuncionario";
            Load += FrmLoginFuncionario_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnEntrarFO;
        private TextBox txtMatriculaId;
        private Label lblMatricula;
        private Label lblPassword;
        private TextBox txtPassword;
    }
}