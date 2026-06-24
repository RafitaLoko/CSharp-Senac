namespace calculadora
{
    partial class Login
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
            textBox1 = new TextBox();
            label2 = new Label();
            textBox2 = new TextBox();
            btnEnviar = new Button();
            usuario = new Label();
            textNomeUsuario = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(99, 38);
            label1.TabIndex = 0;
            label1.Text = "Nome:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 50);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(206, 31);
            textBox1.TabIndex = 1;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 113);
            label2.Name = "label2";
            label2.Size = new Size(99, 38);
            label2.TabIndex = 2;
            label2.Text = "Senha:";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(12, 154);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(203, 31);
            textBox2.TabIndex = 3;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // btnEnviar
            // 
            btnEnviar.Location = new Point(252, 144);
            btnEnviar.Name = "btnEnviar";
            btnEnviar.Size = new Size(121, 50);
            btnEnviar.TabIndex = 4;
            btnEnviar.Text = "Enviar";
            btnEnviar.UseVisualStyleBackColor = true;
            btnEnviar.Click += btnEnviar_Click;
            // 
            // usuario
            // 
            usuario.AutoSize = true;
            usuario.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            usuario.Location = new Point(297, 9);
            usuario.Name = "usuario";
            usuario.Size = new Size(111, 38);
            usuario.TabIndex = 5;
            usuario.Text = "Usuario";
            // 
            // textNomeUsuario
            // 
            textNomeUsuario.Location = new Point(297, 50);
            textNomeUsuario.Name = "textNomeUsuario";
            textNomeUsuario.Size = new Size(161, 31);
            textNomeUsuario.TabIndex = 6;
            textNomeUsuario.TextChanged += lblUsuario_TextChanged;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textNomeUsuario);
            Controls.Add(usuario);
            Controls.Add(btnEnviar);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "Login";
            Text = "Login";
            Load += Login_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private Label label2;
        private TextBox textBox2;
        private Button btnEnviar;
        private Label usuario;
        private TextBox textNomeUsuario;
    }
}