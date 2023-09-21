namespace WinFormsApp
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
            panel1 = new Panel();
            button13 = new Button();
            button12 = new Button();
            button11 = new Button();
            button10 = new Button();
            button9 = new Button();
            button8 = new Button();
            button7 = new Button();
            button6 = new Button();
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            comboBox1 = new ComboBox();
            label1 = new Label();
            panel2 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveBorder;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(button13);
            panel1.Controls.Add(button12);
            panel1.Controls.Add(button11);
            panel1.Controls.Add(button10);
            panel1.Controls.Add(button9);
            panel1.Controls.Add(button8);
            panel1.Controls.Add(button7);
            panel1.Controls.Add(button6);
            panel1.Controls.Add(button5);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(comboBox1);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(493, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(295, 426);
            panel1.TabIndex = 0;
            // 
            // button13
            // 
            button13.Location = new Point(223, 280);
            button13.Name = "button13";
            button13.Size = new Size(38, 52);
            button13.TabIndex = 14;
            button13.Text = "->>";
            button13.UseVisualStyleBackColor = true;
            // 
            // button12
            // 
            button12.Location = new Point(188, 280);
            button12.Name = "button12";
            button12.Size = new Size(29, 52);
            button12.TabIndex = 13;
            button12.Text = "->";
            button12.UseVisualStyleBackColor = true;
            // 
            // button11
            // 
            button11.Location = new Point(29, 280);
            button11.Name = "button11";
            button11.Size = new Size(36, 52);
            button11.TabIndex = 12;
            button11.Text = "<<-";
            button11.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            button10.Location = new Point(71, 280);
            button10.Name = "button10";
            button10.Size = new Size(30, 52);
            button10.TabIndex = 11;
            button10.Text = "<-";
            button10.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            button9.Location = new Point(107, 367);
            button9.Name = "button9";
            button9.Size = new Size(75, 23);
            button9.TabIndex = 10;
            button9.Text = "DownFar";
            button9.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            button8.Location = new Point(107, 338);
            button8.Name = "button8";
            button8.Size = new Size(75, 23);
            button8.TabIndex = 9;
            button8.Text = "Down";
            button8.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            button7.Location = new Point(107, 309);
            button7.Name = "button7";
            button7.Size = new Size(75, 23);
            button7.TabIndex = 8;
            button7.Text = "-";
            button7.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Location = new Point(107, 280);
            button6.Name = "button6";
            button6.Size = new Size(75, 23);
            button6.TabIndex = 7;
            button6.Text = "+";
            button6.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(107, 251);
            button5.Name = "button5";
            button5.Size = new Size(75, 23);
            button5.TabIndex = 6;
            button5.Text = "Up";
            button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(107, 222);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 5;
            button4.Text = "UpFar";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.Location = new Point(15, 161);
            button3.Name = "button3";
            button3.Size = new Size(261, 34);
            button3.TabIndex = 4;
            button3.Text = "Проказати об'єкт";
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(15, 121);
            button2.Name = "button2";
            button2.Size = new Size(261, 34);
            button2.TabIndex = 3;
            button2.Text = "Приховати об'єкт";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(15, 77);
            button1.Name = "button1";
            button1.Size = new Size(261, 38);
            button1.TabIndex = 2;
            button1.Text = "Створити об'єкт";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(15, 48);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(261, 23);
            comboBox1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 30);
            label1.Name = "label1";
            label1.Size = new Size(97, 15);
            label1.TabIndex = 0;
            label1.Text = "Перелік об'єктів";
            label1.Click += label1_Click;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ButtonHighlight;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Location = new Point(12, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(475, 426);
            panel2.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "\"Лабораторна робота No1 Васильєв\"";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private Button button3;
        private Button button2;
        private Button button1;
        private ComboBox comboBox1;
        private Button button13;
        private Button button12;
        private Button button11;
        private Button button10;
        private Button button9;
        private Button button8;
        private Button button7;
        private Button button6;
        private Button button5;
        private Button button4;
    }
}