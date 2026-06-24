namespace SistemaDeLogin
{
    partial class FrmLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            textUsuario = new TextBox();
            label2 = new Label();
            textSenha = new TextBox();
            btnEnviar = new Button();
            label3 = new Label();
            textNome = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(-4, 0);
            label1.Name = "label1";
            label1.Size = new Size(126, 41);
            label1.TabIndex = 0;
            label1.Text = "Usuario:";
            // 
            // textUsuario
            // 
            textUsuario.Location = new Point(-4, 44);
            textUsuario.Name = "textUsuario";
            textUsuario.Size = new Size(150, 31);
            textUsuario.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(-4, 87);
            label2.Name = "label2";
            label2.Size = new Size(106, 41);
            label2.TabIndex = 2;
            label2.Text = "Senha:";
            // 
            // textSenha
            // 
            textSenha.Location = new Point(-4, 140);
            textSenha.Name = "textSenha";
            textSenha.Size = new Size(150, 31);
            textSenha.TabIndex = 3;
            // 
            // btnEnviar
            // 
            btnEnviar.Location = new Point(163, 136);
            btnEnviar.Name = "btnEnviar";
            btnEnviar.Size = new Size(81, 38);
            btnEnviar.TabIndex = 4;
            btnEnviar.Text = "Enviar";
            btnEnviar.UseVisualStyleBackColor = true;
            btnEnviar.Click += btnEnviar_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(184, 3);
            label3.Name = "label3";
            label3.Size = new Size(287, 38);
            label3.TabIndex = 5;
            label3.Text = "Nome a ser chamado:";
            // 
            // textNome
            // 
            textNome.Location = new Point(184, 44);
            textNome.Name = "textNome";
            textNome.Size = new Size(277, 31);
            textNome.TabIndex = 6;
            // 
            // FrmLogin
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(808, 450);
            Controls.Add(textNome);
            Controls.Add(label3);
            Controls.Add(btnEnviar);
            Controls.Add(textSenha);
            Controls.Add(label2);
            Controls.Add(textUsuario);
            Controls.Add(label1);
            Name = "FrmLogin";
            Text = "Login";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textUsuario;
        private Label label2;
        private TextBox textSenha;
        private Button btnEnviar;
        private Label label3;
        private TextBox textNome;
    }
}
