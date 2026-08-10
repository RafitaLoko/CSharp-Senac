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
            txtCampo = new TextBox();
            btnBuscar = new Button();
            btnLimpar = new Button();
            cbFiltro = new ComboBox();
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
            dgvFuncionarios.CellContentClick += dgvFuncionarios_CellContentClick;
            // 
            // BtnNovo
            // 
            BtnNovo.BackColor = SystemColors.ActiveCaption;
            BtnNovo.Location = new Point(21, 366);
            BtnNovo.Name = "BtnNovo";
            BtnNovo.Size = new Size(129, 58);
            BtnNovo.TabIndex = 1;
            BtnNovo.Text = "Novo";
            BtnNovo.UseVisualStyleBackColor = false;
            BtnNovo.Click += BtnNovo_Click;
            // 
            // BtnEditar
            // 
            BtnEditar.BackColor = SystemColors.ActiveBorder;
            BtnEditar.Location = new Point(503, 366);
            BtnEditar.Name = "BtnEditar";
            BtnEditar.Size = new Size(129, 58);
            BtnEditar.TabIndex = 2;
            BtnEditar.Text = "Ver/Editar";
            BtnEditar.UseVisualStyleBackColor = false;
            BtnEditar.Click += BtnEditar_Click;
            // 
            // BtnExcluir
            // 
            BtnExcluir.BackColor = SystemColors.GradientInactiveCaption;
            BtnExcluir.Location = new Point(647, 366);
            BtnExcluir.Name = "BtnExcluir";
            BtnExcluir.Size = new Size(129, 58);
            BtnExcluir.TabIndex = 3;
            BtnExcluir.Text = "Excluir";
            BtnExcluir.UseVisualStyleBackColor = false;
            BtnExcluir.Click += BtnExcluir_Click;
            // 
            // txtCampo
            // 
            txtCampo.Location = new Point(203, 341);
            txtCampo.Name = "txtCampo";
            txtCampo.PlaceholderText = "Insira nome ou email";
            txtCampo.Size = new Size(204, 31);
            txtCampo.TabIndex = 4;
            txtCampo.TextChanged += txtCampo_TextChanged;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(184, 378);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(112, 34);
            btnBuscar.TabIndex = 5;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // btnLimpar
            // 
            btnLimpar.Location = new Point(314, 378);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(112, 34);
            btnLimpar.TabIndex = 6;
            btnLimpar.Text = "Limpar";
            btnLimpar.UseVisualStyleBackColor = true;
            btnLimpar.Click += btnLimpar_Click;
            // 
            // cbFiltro
            // 
            cbFiltro.FormattingEnabled = true;
            cbFiltro.Location = new Point(420, 341);
            cbFiltro.Name = "cbFiltro";
            cbFiltro.Size = new Size(85, 33);
            cbFiltro.TabIndex = 7;
            cbFiltro.SelectedIndexChanged += cbFiltro_SelectedIndexChanged;
            // 
            // FrmTelaPrincipal
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(cbFiltro);
            Controls.Add(btnLimpar);
            Controls.Add(btnBuscar);
            Controls.Add(txtCampo);
            Controls.Add(BtnExcluir);
            Controls.Add(BtnEditar);
            Controls.Add(BtnNovo);
            Controls.Add(dgvFuncionarios);
            Name = "FrmTelaPrincipal";
            Text = "FrmTelaPrincipal";
            Load += FrmTelaPrincipal_Load;
            ((System.ComponentModel.ISupportInitialize)dgvFuncionarios).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvFuncionarios;
        private Button BtnNovo;
        private Button BtnEditar;
        private Button BtnExcluir;
        private TextBox txtCampo;
        private Button btnBuscar;
        private Button btnLimpar;
        private ComboBox cbFiltro;
    }
}