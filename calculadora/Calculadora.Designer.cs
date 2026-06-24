namespace calculadora
{
    partial class Calculadora
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
            btnSomar = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            btnSubtrair = new Button();
            btnMultiplicar = new Button();
            btnDividir = new Button();
            lblResultado = new Label();
            SuspendLayout();
            // 
            // btnSomar
            // 
            btnSomar.Location = new Point(12, 100);
            btnSomar.Name = "btnSomar";
            btnSomar.Size = new Size(105, 53);
            btnSomar.TabIndex = 0;
            btnSomar.Text = "Somar";
            btnSomar.UseVisualStyleBackColor = true;
            btnSomar.Click += btnSomar_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(24, 13);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(136, 31);
            textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(220, 13);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(146, 31);
            textBox2.TabIndex = 2;
            // 
            // btnSubtrair
            // 
            btnSubtrair.Location = new Point(12, 182);
            btnSubtrair.Name = "btnSubtrair";
            btnSubtrair.Size = new Size(112, 53);
            btnSubtrair.TabIndex = 3;
            btnSubtrair.Text = "Subtrair";
            btnSubtrair.UseVisualStyleBackColor = true;
            btnSubtrair.Click += button1_Click;
            // 
            // btnMultiplicar
            // 
            btnMultiplicar.Location = new Point(12, 251);
            btnMultiplicar.Name = "btnMultiplicar";
            btnMultiplicar.Size = new Size(112, 48);
            btnMultiplicar.TabIndex = 4;
            btnMultiplicar.Text = "Multiplicar";
            btnMultiplicar.UseVisualStyleBackColor = true;
            btnMultiplicar.Click += btnMultiplicar_Click;
            // 
            // btnDividir
            // 
            btnDividir.Location = new Point(12, 319);
            btnDividir.Name = "btnDividir";
            btnDividir.Size = new Size(116, 108);
            btnDividir.TabIndex = 5;
            btnDividir.Text = "Dividir";
            btnDividir.UseVisualStyleBackColor = true;
            btnDividir.Click += btnDividir_Click;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblResultado.Location = new Point(343, 148);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(246, 65);
            lblResultado.TabIndex = 6;
            lblResultado.Text = "Resultado:";
            lblResultado.Click += lblResultado_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblResultado);
            Controls.Add(btnDividir);
            Controls.Add(btnMultiplicar);
            Controls.Add(btnSubtrair);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(btnSomar);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSomar;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button btnSubtrair;
        private Button btnMultiplicar;
        private Button btnDividir;
        private Label lblResultado;



    }


}
