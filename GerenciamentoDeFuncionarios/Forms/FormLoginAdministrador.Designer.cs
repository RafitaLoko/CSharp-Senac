namespace GerenciamentoDeFuncionarios.Forms
{
    partial class FormLoginAdministrador
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
            lblUsuario = new Label();
            TxtUsuario = new TextBox();
            lblSenha = new Label();
            TxtSenha = new TextBox();
            BtnEntrar = new Button();
            SuspendLayout();
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUsuario.Location = new Point(318, 75);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(94, 32);
            lblUsuario.TabIndex = 0;
            lblUsuario.Text = "Usuario";
            // 
            // TxtUsuario
            // 
            TxtUsuario.Location = new Point(298, 135);
            TxtUsuario.Name = "TxtUsuario";
            TxtUsuario.Size = new Size(150, 31);
            TxtUsuario.TabIndex = 2;
            // 
            // lblSenha
            // 
            lblSenha.AutoSize = true;
            lblSenha.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSenha.Location = new Point(332, 199);
            lblSenha.Name = "lblSenha";
            lblSenha.Size = new Size(80, 32);
            lblSenha.TabIndex = 3;
            lblSenha.Text = "Senha";
            // 
            // TxtSenha
            // 
            TxtSenha.Location = new Point(298, 251);
            TxtSenha.Name = "TxtSenha";
            TxtSenha.Size = new Size(150, 31);
            TxtSenha.TabIndex = 4;
            TxtSenha.UseSystemPasswordChar = true;
            // 
            // BtnEntrar
            // 
            BtnEntrar.Location = new Point(318, 326);
            BtnEntrar.Name = "BtnEntrar";
            BtnEntrar.Size = new Size(112, 34);
            BtnEntrar.TabIndex = 5;
            BtnEntrar.Text = "Entrar";
            BtnEntrar.UseVisualStyleBackColor = true;
            BtnEntrar.Click += BtnEntrar_Click;
            // 
            // FormLoginAdministrador
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(BtnEntrar);
            Controls.Add(TxtSenha);
            Controls.Add(lblSenha);
            Controls.Add(TxtUsuario);
            Controls.Add(lblUsuario);
            Name = "FormLoginAdministrador";
            Text = "FormLoginAdministrador";
            Load += FormLoginAdministrador_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblUsuario;
        private TextBox TxtUsuario;
        private Label lblSenha;
        private TextBox TxtSenha;
        private Button BtnEntrar;
    }
}