namespace WinFormsSerialPort2
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
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton3 = new RadioButton();
            radioButton4 = new RadioButton();
            panel1 = new Panel();
            panel2 = new Panel();
            textBox1 = new TextBox();
            button1 = new Button();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            button2 = new Button();
            button3 = new Button();
            textBox2 = new TextBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(3, 24);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(71, 28);
            radioButton1.TabIndex = 0;
            radioButton1.TabStop = true;
            radioButton1.Text = "数值";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(3, 20);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(71, 28);
            radioButton2.TabIndex = 1;
            radioButton2.TabStop = true;
            radioButton2.Text = "数值";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(158, 24);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(71, 28);
            radioButton3.TabIndex = 2;
            radioButton3.TabStop = true;
            radioButton3.Text = "字符";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            radioButton4.AutoSize = true;
            radioButton4.Location = new Point(158, 20);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(71, 28);
            radioButton4.TabIndex = 3;
            radioButton4.TabStop = true;
            radioButton4.Text = "字符";
            radioButton4.UseVisualStyleBackColor = true;
            radioButton4.CheckedChanged += radioButton4_CheckedChanged;
            // 
            // panel1
            // 
            panel1.Controls.Add(radioButton1);
            panel1.Controls.Add(radioButton3);
            panel1.Location = new Point(246, 385);
            panel1.Name = "panel1";
            panel1.Size = new Size(337, 83);
            panel1.TabIndex = 4;
            // 
            // panel2
            // 
            panel2.Controls.Add(radioButton2);
            panel2.Controls.Add(radioButton4);
            panel2.Location = new Point(243, 272);
            panel2.Name = "panel2";
            panel2.Size = new Size(337, 83);
            panel2.TabIndex = 5;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(712, 12);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ScrollBars = ScrollBars.Vertical;
            textBox1.Size = new Size(889, 631);
            textBox1.TabIndex = 6;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // button1
            // 
            button1.Location = new Point(1263, 716);
            button1.Name = "button1";
            button1.Size = new Size(272, 93);
            button1.TabIndex = 7;
            button1.Text = "发送";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(243, 99);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(340, 32);
            comboBox1.TabIndex = 8;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "600", "1200", "2400", "4800", "9600", "14400", "19200" });
            comboBox2.Location = new Point(243, 200);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(340, 32);
            comboBox2.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(62, 27);
            label1.Name = "label1";
            label1.Size = new Size(46, 24);
            label1.TabIndex = 10;
            label1.Text = "设置";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(121, 102);
            label2.Name = "label2";
            label2.Size = new Size(46, 24);
            label2.TabIndex = 11;
            label2.Text = "端口";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(103, 208);
            label3.Name = "label3";
            label3.Size = new Size(64, 24);
            label3.TabIndex = 12;
            label3.Text = "波特率";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(85, 294);
            label4.Name = "label4";
            label4.Size = new Size(82, 24);
            label4.TabIndex = 13;
            label4.Text = "发送模式";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(85, 423);
            label5.Name = "label5";
            label5.Size = new Size(82, 24);
            label5.TabIndex = 14;
            label5.Text = "接收模式";
            // 
            // button2
            // 
            button2.Location = new Point(388, 550);
            button2.Name = "button2";
            button2.Size = new Size(272, 93);
            button2.TabIndex = 15;
            button2.Text = "关闭端口";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(24, 550);
            button3.Name = "button3";
            button3.Size = new Size(272, 93);
            button3.TabIndex = 16;
            button3.Text = "打开端口";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(24, 716);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.ScrollBars = ScrollBars.Vertical;
            textBox2.Size = new Size(1149, 113);
            textBox2.TabIndex = 17;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1630, 870);
            Controls.Add(textBox2);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private RadioButton radioButton3;
        private RadioButton radioButton4;
        private Panel panel1;
        private Panel panel2;
        private TextBox textBox1;
        private Button button1;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button button2;
        private Button button3;
        private TextBox textBox2;
    }
}
