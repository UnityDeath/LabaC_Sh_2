namespace WinFormsApp1
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
            comboBox1 = new ComboBox();
            button1 = new Button();
            label1 = new Label();
            textBox1 = new TextBox();
            comboBox2 = new ComboBox();
            comboBox3 = new ComboBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            comboBox4 = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            comboBox5 = new ComboBox();
            comboBox6 = new ComboBox();
            textBox6 = new TextBox();
            label4 = new Label();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(323, 147);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(98, 28);
            comboBox1.TabIndex = 0;
            comboBox1.Text = "10";
            comboBox1.SelectedIndexChanged += onValueChanged;
            // 
            // button1
            // 
            button1.Location = new Point(87, 396);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 1;
            button1.Text = "Clear All";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(694, 120);
            label1.TabIndex = 2;
            label1.Text = "Число, заданное в системе счисления (двоичная, восьмеричная, десятичная шестнадцатеричная)\r\n- сложение\r\n- вычитание\r\n- умножение\r\n- сравнение\r\n- вывод значения в любой системе счисления";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(87, 148);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(206, 27);
            textBox1.TabIndex = 3;
            textBox1.TextChanged += onValueChanged;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(323, 246);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(98, 28);
            comboBox2.TabIndex = 4;
            comboBox2.Text = "10";
            comboBox2.SelectedIndexChanged += onValueChanged;
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(323, 328);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(98, 28);
            comboBox3.TabIndex = 5;
            comboBox3.Text = "10";
            comboBox3.SelectedIndexChanged += onValueChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(87, 247);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(206, 27);
            textBox2.TabIndex = 6;
            textBox2.TextChanged += onValueChanged;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(87, 329);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(206, 27);
            textBox3.TabIndex = 7;
            // 
            // comboBox4
            // 
            comboBox4.FormattingEnabled = true;
            comboBox4.Items.AddRange(new object[] { "+", "-", "*" });
            comboBox4.Location = new Point(149, 194);
            comboBox4.Name = "comboBox4";
            comboBox4.Size = new Size(98, 28);
            comboBox4.TabIndex = 8;
            comboBox4.Text = "+";
            comboBox4.SelectedIndexChanged += onValueChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(323, 106);
            label2.Name = "label2";
            label2.Size = new Size(0, 20);
            label2.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(33, 331);
            label3.Name = "label3";
            label3.Size = new Size(48, 20);
            label3.TabIndex = 10;
            label3.Text = "Ответ";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(503, 195);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(159, 27);
            textBox4.TabIndex = 11;
            textBox4.TextChanged += onCompareValues;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(503, 298);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(159, 27);
            textBox5.TabIndex = 12;
            textBox5.TextChanged += onCompareValues;
            // 
            // comboBox5
            // 
            comboBox5.FormattingEnabled = true;
            comboBox5.Location = new Point(690, 195);
            comboBox5.Name = "comboBox5";
            comboBox5.Size = new Size(98, 28);
            comboBox5.TabIndex = 13;
            comboBox5.SelectedIndexChanged += onCompareValues;
            // 
            // comboBox6
            // 
            comboBox6.FormattingEnabled = true;
            comboBox6.Location = new Point(690, 297);
            comboBox6.Name = "comboBox6";
            comboBox6.Size = new Size(98, 28);
            comboBox6.TabIndex = 14;
            comboBox6.SelectedIndexChanged += onCompareValues;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(553, 246);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(62, 27);
            textBox6.TabIndex = 15;
            textBox6.TextChanged += onCompareValues;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(503, 151);
            label4.Name = "label4";
            label4.Size = new Size(121, 20);
            label4.TabIndex = 16;
            label4.Text = "Блок сравнения";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(textBox6);
            Controls.Add(comboBox6);
            Controls.Add(comboBox5);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(comboBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(comboBox3);
            Controls.Add(comboBox2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(comboBox1);
            Name = "Form1";
            Text = "Калькулятор";
            TextChanged += onCompareValues;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBox1;
        private Button button1;
        private Label label1;
        private TextBox textBox1;
        private ComboBox comboBox2;
        private ComboBox comboBox3;
        private TextBox textBox2;
        private TextBox textBox3;
        private ComboBox comboBox4;
        private Label label2;
        private Label label3;
        private TextBox textBox4;
        private TextBox textBox5;
        private ComboBox comboBox5;
        private ComboBox comboBox6;
        private TextBox textBox6;
        private Label label4;
    }
}
