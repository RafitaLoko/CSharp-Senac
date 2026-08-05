namespace GerenciamentoDeFuncionarios.Forms
{
    partial class FrmTelaPrincipal
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
            dgvFuncionarios = new DataGridView();
            BtnNovo = new Button();
            BtnEditar = new Button();
            BtnExcluir = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvFuncionarios).BeginInit();
            SuspendLayout();
            // 
            // dgvFuncionarios
            // 
            dgvFuncionarios.ColumnHeadersHeight = 34;
            dgvFuncionarios.Location = new Point(21, 15);
            dgvFuncionarios.MultiSelect = false;
            dgvFuncionarios.Name = "dgvFuncionarios";
            dgvFuncionarios.RowHeadersWidth = 62;
            dgvFuncionarios.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvFuncionarios.Size = new Size(755, 320);
            dgvFuncionarios.TabIndex = 0;
            // 
            // BtnNovo
            // 
            BtnNovo.Location = new Point(21, 366);
            BtnNovo.Name = "BtnNovo";
            BtnNovo.Size = new Size(129, 58);
            BtnNovo.TabIndex = 1;
            BtnNovo.Text = "Novo";
            BtnNovo.UseVisualStyleBackColor = true;
            BtnNovo.Click += BtnNovo_Click;
            // 
            // BtnEditar
            // 
            BtnEditar.Location = new Point(503, 366);
            BtnEditar.Name = "BtnEditar";
            BtnEditar.Size = new Size(129, 58);
            BtnEditar.TabIndex = 2;
            BtnEditar.Text = "Editar";
            BtnEditar.UseVisualStyleBackColor = true;
            BtnEditar.Click += BtnEditar_Click;
            // 
            // BtnExcluir
            // 
            BtnExcluir.Location = new Point(647, 366);
            BtnExcluir.Name = "BtnExcluir";
            BtnExcluir.Size = new Size(129, 58);
            BtnExcluir.TabIndex = 3;
            BtnExcluir.Text = "Excluir";
            BtnExcluir.UseVisualStyleBackColor = true;
            BtnExcluir.Click += BtnExcluir_Click;
            // 
            // FrmTelaPrincipal
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(BtnExcluir);
            Controls.Add(BtnEditar);
            Controls.Add(BtnNovo);
            Controls.Add(dgvFuncionarios);
            Name = "FrmTelaPrincipal";
            Text = "FrmTelaPrincipal";
            Load += FrmTelaPrincipal_Load;
            ((System.ComponentModel.ISupportInitialize)dgvFuncionarios).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvFuncionarios;
        private Button BtnNovo;
        private Button BtnEditar;
        private Button BtnExcluir;
    }
}