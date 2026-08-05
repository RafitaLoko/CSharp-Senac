namespace GerenciamentoDeFuncionarios
{
    partial class FrmTelaNova
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
            btnSouFuncionario = new Button();
            btn1SouAdm = new Button();
            SuspendLayout();
            // 
            // btnSouFuncionario
            // 
            btnSouFuncionario.Location = new Point(307, 237);
            btnSouFuncionario.Name = "btnSouFuncionario";
            btnSouFuncionario.Size = new Size(186, 78);
            btnSouFuncionario.TabIndex = 3;
            btnSouFuncionario.Text = "Sou Funcionário";
            btnSouFuncionario.UseVisualStyleBackColor = true;
            btnSouFuncionario.Click += btnSouFuncionario_Click;
            // 
            // btn1SouAdm
            // 
            btn1SouAdm.Location = new Point(307, 135);
            btn1SouAdm.Name = "btn1SouAdm";
            btn1SouAdm.Size = new Size(186, 78);
            btn1SouAdm.TabIndex = 2;
            btn1SouAdm.Text = "Sou Administrador";
            btn1SouAdm.UseVisualStyleBackColor = true;
            btn1SouAdm.Click += btn1SouAdm_Click;
            // 
            // FrmTelaNova
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSouFuncionario);
            Controls.Add(btn1SouAdm);
            Name = "FrmTelaNova";
            Text = "FrmTelaNova";
            Load += FrmTelaNova_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnSouFuncionario;
        private Button btn1SouAdm;
    }
}