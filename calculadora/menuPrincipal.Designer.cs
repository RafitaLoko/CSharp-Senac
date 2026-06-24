namespace calculadora
{
    partial class menuPrincipal
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
            BtnCalculadora = new Button();
            SuspendLayout();
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUsuario.Location = new Point(230, 190);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(330, 48);
            lblUsuario.TabIndex = 0;
            lblUsuario.Text = "Bem vindo Usuario!";
            lblUsuario.Click += MenuPrincipal_Click;
            // 
            // BtnCalculadora
            // 
            BtnCalculadora.Location = new Point(656, 342);
            BtnCalculadora.Name = "BtnCalculadora";
            BtnCalculadora.Size = new Size(132, 96);
            BtnCalculadora.TabIndex = 1;
            BtnCalculadora.Text = "Calculadora";
            BtnCalculadora.UseVisualStyleBackColor = true;
            BtnCalculadora.Click += BtnCalculadora_Click;
            // 
            // menuPrincipal
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(BtnCalculadora);
            Controls.Add(lblUsuario);
            Name = "menuPrincipal";
            Text = "Menu de boas vindas";
            Load += menuPrincipal_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblUsuario;
        private Button BtnCalculadora;
    }
}