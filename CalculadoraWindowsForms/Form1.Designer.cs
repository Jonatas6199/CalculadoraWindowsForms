namespace CalculadoraWindowsForms
{
    partial class Form1
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
            txtOperacao = new TextBox();
            btn1 = new Button();
            btn2 = new Button();
            btn3 = new Button();
            btn4 = new Button();
            btn5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            button10 = new Button();
            btnSomar = new Button();
            btnSubtrair = new Button();
            btnMultiplicar = new Button();
            btnDividir = new Button();
            btnResultado = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // txtOperacao
            // 
            txtOperacao.Enabled = false;
            txtOperacao.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtOperacao.Location = new Point(20, 33);
            txtOperacao.Multiline = true;
            txtOperacao.Name = "txtOperacao";
            txtOperacao.Size = new Size(197, 52);
            txtOperacao.TabIndex = 0;
            // 
            // btn1
            // 
            btn1.Location = new Point(20, 99);
            btn1.Name = "btn1";
            btn1.Size = new Size(53, 52);
            btn1.TabIndex = 1;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += btn1_Click;
            // 
            // btn2
            // 
            btn2.Location = new Point(93, 99);
            btn2.Name = "btn2";
            btn2.Size = new Size(53, 52);
            btn2.TabIndex = 2;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = true;
            btn2.Click += btn2_Click;
            // 
            // btn3
            // 
            btn3.Location = new Point(164, 99);
            btn3.Name = "btn3";
            btn3.Size = new Size(53, 52);
            btn3.TabIndex = 3;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = true;
            btn3.Click += btn3_Click;
            // 
            // btn4
            // 
            btn4.Location = new Point(20, 170);
            btn4.Name = "btn4";
            btn4.Size = new Size(53, 52);
            btn4.TabIndex = 4;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = true;
            btn4.Click += btn4_Click;
            // 
            // btn5
            // 
            btn5.Location = new Point(93, 170);
            btn5.Name = "btn5";
            btn5.Size = new Size(53, 52);
            btn5.TabIndex = 5;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = true;
            btn5.Click += btn5_Click;
            // 
            // button6
            // 
            button6.Location = new Point(164, 170);
            button6.Name = "button6";
            button6.Size = new Size(53, 52);
            button6.TabIndex = 6;
            button6.Text = "6";
            button6.UseVisualStyleBackColor = true;
            button6.Click += btn6_Click;
            // 
            // button7
            // 
            button7.Location = new Point(20, 242);
            button7.Name = "button7";
            button7.Size = new Size(53, 52);
            button7.TabIndex = 7;
            button7.Text = "7";
            button7.UseVisualStyleBackColor = true;
            button7.Click += btn7_Click;
            // 
            // button8
            // 
            button8.Location = new Point(93, 242);
            button8.Name = "button8";
            button8.Size = new Size(53, 52);
            button8.TabIndex = 8;
            button8.Text = "8";
            button8.UseVisualStyleBackColor = true;
            button8.Click += btn8_Click;
            // 
            // button9
            // 
            button9.Location = new Point(164, 242);
            button9.Name = "button9";
            button9.Size = new Size(53, 52);
            button9.TabIndex = 9;
            button9.Text = "9";
            button9.UseVisualStyleBackColor = true;
            button9.Click += btn9_Click;
            // 
            // button10
            // 
            button10.Location = new Point(20, 321);
            button10.Name = "button10";
            button10.Size = new Size(53, 52);
            button10.TabIndex = 10;
            button10.Text = "0";
            button10.UseVisualStyleBackColor = true;
            button10.Click += btn0_Click;
            // 
            // btnSomar
            // 
            btnSomar.Location = new Point(267, 33);
            btnSomar.Name = "btnSomar";
            btnSomar.Size = new Size(53, 52);
            btnSomar.TabIndex = 11;
            btnSomar.Text = "+";
            btnSomar.UseVisualStyleBackColor = true;
            btnSomar.Click += btnSomar_Click;
            // 
            // btnSubtrair
            // 
            btnSubtrair.Location = new Point(267, 99);
            btnSubtrair.Name = "btnSubtrair";
            btnSubtrair.Size = new Size(53, 52);
            btnSubtrair.TabIndex = 12;
            btnSubtrair.Text = "-";
            btnSubtrair.UseVisualStyleBackColor = true;
            btnSubtrair.Click += btnSubtrair_Click;
            // 
            // btnMultiplicar
            // 
            btnMultiplicar.Location = new Point(267, 170);
            btnMultiplicar.Name = "btnMultiplicar";
            btnMultiplicar.Size = new Size(53, 52);
            btnMultiplicar.TabIndex = 13;
            btnMultiplicar.Text = "*";
            btnMultiplicar.UseVisualStyleBackColor = true;
            btnMultiplicar.Click += btnMultiplicar_Click;
            // 
            // btnDividir
            // 
            btnDividir.Location = new Point(267, 242);
            btnDividir.Name = "btnDividir";
            btnDividir.Size = new Size(53, 52);
            btnDividir.TabIndex = 14;
            btnDividir.Text = "/";
            btnDividir.UseVisualStyleBackColor = true;
            btnDividir.Click += btnDividir_Click;
            // 
            // btnResultado
            // 
            btnResultado.Location = new Point(267, 321);
            btnResultado.Name = "btnResultado";
            btnResultado.Size = new Size(53, 52);
            btnResultado.TabIndex = 15;
            btnResultado.Text = "=";
            btnResultado.UseVisualStyleBackColor = true;
            btnResultado.Click += btnResultado_Click;
            // 
            // button1
            // 
            button1.Location = new Point(93, 321);
            button1.Name = "button1";
            button1.Size = new Size(124, 52);
            button1.TabIndex = 16;
            button1.Text = "Limpar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += btnLimpar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(348, 409);
            Controls.Add(button1);
            Controls.Add(btnResultado);
            Controls.Add(btnDividir);
            Controls.Add(btnMultiplicar);
            Controls.Add(btnSubtrair);
            Controls.Add(btnSomar);
            Controls.Add(button10);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(btn5);
            Controls.Add(btn4);
            Controls.Add(btn3);
            Controls.Add(btn2);
            Controls.Add(btn1);
            Controls.Add(txtOperacao);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtOperacao;
        private Button btn1;
        private Button btn2;
        private Button btn3;
        private Button btn4;
        private Button btn5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button button10;
        private Button btnSomar;
        private Button btnSubtrair;
        private Button btnMultiplicar;
        private Button btnDividir;
        private Button btnResultado;
        private Button button1;
    }
}
