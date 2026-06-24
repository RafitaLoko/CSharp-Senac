namespace calculadoraDoWindows.cs
{
    partial class Calculadora
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
            BtnClear = new Button();
            BtnIgual = new Button();
            BtnVirgula = new Button();
            Btn0 = new Button();
            BtnApagar = new Button();
            BtnDividir = new Button();
            BtnMultiplicar = new Button();
            BtnSubtrair = new Button();
            BtnSomar = new Button();
            Btn9 = new Button();
            Btn8 = new Button();
            Btn7 = new Button();
            Btn6 = new Button();
            Btn5 = new Button();
            Btn4 = new Button();
            Btn3 = new Button();
            Btn2 = new Button();
            Btn1 = new Button();
            lblResultado = new TextBox();
            SuspendLayout();
            // 
            // BtnClear
            // 
            BtnClear.Location = new Point(206, 163);
            BtnClear.Name = "BtnClear";
            BtnClear.Size = new Size(94, 64);
            BtnClear.TabIndex = 37;
            BtnClear.Text = "C";
            BtnClear.UseVisualStyleBackColor = true;
            BtnClear.Click += BtnClear_Click;
            // 
            // BtnIgual
            // 
            BtnIgual.Location = new Point(306, 513);
            BtnIgual.Name = "BtnIgual";
            BtnIgual.Size = new Size(94, 64);
            BtnIgual.TabIndex = 35;
            BtnIgual.Text = "=";
            BtnIgual.UseVisualStyleBackColor = true;
            BtnIgual.Click += BtnIgual_Click;
            // 
            // BtnVirgula
            // 
            BtnVirgula.Font = new Font("Segoe UI", 19F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnVirgula.Location = new Point(206, 513);
            BtnVirgula.Name = "BtnVirgula";
            BtnVirgula.Size = new Size(94, 64);
            BtnVirgula.TabIndex = 34;
            BtnVirgula.Text = "⸴";
            BtnVirgula.UseVisualStyleBackColor = true;
            BtnVirgula.Click += BtnVirgula_Click;
            // 
            // Btn0
            // 
            Btn0.Location = new Point(106, 513);
            Btn0.Name = "Btn0";
            Btn0.Size = new Size(94, 64);
            Btn0.TabIndex = 33;
            Btn0.Text = "0";
            Btn0.UseVisualStyleBackColor = true;
            Btn0.Click += Btn0_Click;
            // 
            // BtnApagar
            // 
            BtnApagar.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnApagar.Location = new Point(306, 163);
            BtnApagar.Name = "BtnApagar";
            BtnApagar.Size = new Size(94, 64);
            BtnApagar.TabIndex = 32;
            BtnApagar.Text = "🠔";
            BtnApagar.UseVisualStyleBackColor = true;
            BtnApagar.Click += BtnApagar_Click;
            // 
            // BtnDividir
            // 
            BtnDividir.Location = new Point(306, 233);
            BtnDividir.Name = "BtnDividir";
            BtnDividir.Size = new Size(94, 64);
            BtnDividir.TabIndex = 31;
            BtnDividir.Text = "➗";
            BtnDividir.UseVisualStyleBackColor = true;
            BtnDividir.Click += BtnDividir_Click;
            // 
            // BtnMultiplicar
            // 
            BtnMultiplicar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnMultiplicar.Location = new Point(306, 303);
            BtnMultiplicar.Name = "BtnMultiplicar";
            BtnMultiplicar.Size = new Size(94, 64);
            BtnMultiplicar.TabIndex = 30;
            BtnMultiplicar.Text = "✖";
            BtnMultiplicar.UseVisualStyleBackColor = true;
            BtnMultiplicar.Click += BtnMultiplicar_Click;
            // 
            // BtnSubtrair
            // 
            BtnSubtrair.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnSubtrair.Location = new Point(306, 373);
            BtnSubtrair.Name = "BtnSubtrair";
            BtnSubtrair.Size = new Size(94, 64);
            BtnSubtrair.TabIndex = 29;
            BtnSubtrair.Text = "➖";
            BtnSubtrair.UseVisualStyleBackColor = true;
            BtnSubtrair.Click += BtnSubtrair_Click;
            // 
            // BtnSomar
            // 
            BtnSomar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnSomar.Location = new Point(306, 443);
            BtnSomar.Name = "BtnSomar";
            BtnSomar.Size = new Size(94, 64);
            BtnSomar.TabIndex = 28;
            BtnSomar.Text = "➕";
            BtnSomar.UseVisualStyleBackColor = true;
            BtnSomar.Click += BtnSomar_Click;
            // 
            // Btn9
            // 
            Btn9.Location = new Point(206, 443);
            Btn9.Name = "Btn9";
            Btn9.Size = new Size(94, 64);
            Btn9.TabIndex = 27;
            Btn9.Text = "9";
            Btn9.UseVisualStyleBackColor = true;
            Btn9.Click += Btn9_Click;
            // 
            // Btn8
            // 
            Btn8.Location = new Point(106, 443);
            Btn8.Name = "Btn8";
            Btn8.Size = new Size(94, 64);
            Btn8.TabIndex = 26;
            Btn8.Text = "8";
            Btn8.UseVisualStyleBackColor = true;
            Btn8.Click += Btn8_Click;
            // 
            // Btn7
            // 
            Btn7.Location = new Point(6, 443);
            Btn7.Name = "Btn7";
            Btn7.Size = new Size(94, 64);
            Btn7.TabIndex = 25;
            Btn7.Text = "7";
            Btn7.UseVisualStyleBackColor = true;
            Btn7.Click += Btn7_Click;
            // 
            // Btn6
            // 
            Btn6.Location = new Point(206, 373);
            Btn6.Name = "Btn6";
            Btn6.Size = new Size(94, 64);
            Btn6.TabIndex = 24;
            Btn6.Text = "6";
            Btn6.UseVisualStyleBackColor = true;
            Btn6.Click += Btn6_Click;
            // 
            // Btn5
            // 
            Btn5.Location = new Point(106, 373);
            Btn5.Name = "Btn5";
            Btn5.Size = new Size(94, 64);
            Btn5.TabIndex = 23;
            Btn5.Text = "5";
            Btn5.UseVisualStyleBackColor = true;
            Btn5.Click += Btn5_Click;
            // 
            // Btn4
            // 
            Btn4.Location = new Point(6, 373);
            Btn4.Name = "Btn4";
            Btn4.Size = new Size(94, 64);
            Btn4.TabIndex = 22;
            Btn4.Text = "4";
            Btn4.UseVisualStyleBackColor = true;
            Btn4.Click += Btn4_Click;
            // 
            // Btn3
            // 
            Btn3.Location = new Point(206, 303);
            Btn3.Name = "Btn3";
            Btn3.Size = new Size(94, 64);
            Btn3.TabIndex = 21;
            Btn3.Text = "3";
            Btn3.UseVisualStyleBackColor = true;
            Btn3.Click += Btn3_Click;
            // 
            // Btn2
            // 
            Btn2.Location = new Point(106, 303);
            Btn2.Name = "Btn2";
            Btn2.Size = new Size(94, 64);
            Btn2.TabIndex = 20;
            Btn2.Text = "2";
            Btn2.UseVisualStyleBackColor = true;
            Btn2.Click += Btn2_Click;
            // 
            // Btn1
            // 
            Btn1.Location = new Point(6, 303);
            Btn1.Name = "Btn1";
            Btn1.Size = new Size(94, 64);
            Btn1.TabIndex = 19;
            Btn1.Text = "1";
            Btn1.UseVisualStyleBackColor = true;
            Btn1.Click += Btn1_Click;
            // 
            // lblResultado
            // 
            lblResultado.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblResultado.Location = new Point(48, 100);
            lblResultado.Name = "lblResultado";
            lblResultado.RightToLeft = RightToLeft.Yes;
            lblResultado.Size = new Size(352, 45);
            lblResultado.TabIndex = 38;
            lblResultado.TextChanged += lblResultado_TextChanged;
            // 
            // Calculadora
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(411, 583);
            Controls.Add(lblResultado);
            Controls.Add(BtnClear);
            Controls.Add(BtnIgual);
            Controls.Add(BtnVirgula);
            Controls.Add(Btn0);
            Controls.Add(BtnApagar);
            Controls.Add(BtnDividir);
            Controls.Add(BtnMultiplicar);
            Controls.Add(BtnSubtrair);
            Controls.Add(BtnSomar);
            Controls.Add(Btn9);
            Controls.Add(Btn8);
            Controls.Add(Btn7);
            Controls.Add(Btn6);
            Controls.Add(Btn5);
            Controls.Add(Btn4);
            Controls.Add(Btn3);
            Controls.Add(Btn2);
            Controls.Add(Btn1);
            Name = "Calculadora";
            Text = "Calculadora";
            Load += Calculadora_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnClear;
        private Button BtnIgual;
        private Button BtnVirgula;
        private Button Btn0;
        private Button BtnApagar;
        private Button BtnDividir;
        private Button BtnMultiplicar;
        private Button BtnSubtrair;
        private Button BtnSomar;
        private Button Btn9;
        private Button Btn8;
        private Button Btn7;
        private Button Btn6;
        private Button Btn5;
        private Button Btn4;
        private Button Btn3;
        private Button Btn2;
        private Button Btn1;
        private TextBox lblResultado;
    }
}