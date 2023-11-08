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
            button1 = new Button();
            label1 = new Label();
            textBox1 = new TextBox();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            label2 = new Label();
            button5 = new Button();
            label3 = new Label();
            button6 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ImageAlign = ContentAlignment.BottomRight;
            button1.Location = new Point(185, 113);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Padding = new Padding(3, 0, 0, 5);
            button1.Size = new Size(88, 60);
            button1.TabIndex = 0;
            button1.Text = "+";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(121, 21);
            label1.Name = "label1";
            label1.Size = new Size(74, 15);
            label1.TabIndex = 1;
            label1.Text = "Enter the no.";
            label1.Click += label1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(228, 21);
            textBox1.Margin = new Padding(3, 2, 3, 2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(110, 23);
            textBox1.TabIndex = 2;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point);
            button2.ImageAlign = ContentAlignment.BottomRight;
            button2.Location = new Point(298, 113);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Padding = new Padding(3, 0, 0, 5);
            button2.Size = new Size(88, 60);
            button2.TabIndex = 11;
            button2.Text = "-";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point);
            button3.ImageAlign = ContentAlignment.BottomRight;
            button3.Location = new Point(185, 196);
            button3.Margin = new Padding(3, 2, 3, 2);
            button3.Name = "button3";
            button3.Padding = new Padding(3, 0, 0, 5);
            button3.Size = new Size(88, 60);
            button3.TabIndex = 12;
            button3.Text = "*";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point);
            button4.ImageAlign = ContentAlignment.BottomRight;
            button4.Location = new Point(298, 196);
            button4.Margin = new Padding(3, 2, 3, 2);
            button4.Name = "button4";
            button4.Padding = new Padding(3, 0, 0, 5);
            button4.Size = new Size(88, 60);
            button4.TabIndex = 13;
            button4.Text = "/";
            button4.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.Window;
            label2.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(121, 63);
            label2.Name = "label2";
            label2.Size = new Size(24, 28);
            label2.TabIndex = 14;
            label2.Text = "...";
            // 
            // button5
            // 
            button5.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            button5.ImageAlign = ContentAlignment.BottomRight;
            button5.Location = new Point(185, 288);
            button5.Margin = new Padding(3, 2, 3, 2);
            button5.Name = "button5";
            button5.Padding = new Padding(3, 0, 0, 5);
            button5.Size = new Size(201, 60);
            button5.TabIndex = 15;
            button5.Text = "Calculate";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.MenuHighlight;
            label3.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(248, 375);
            label3.Name = "label3";
            label3.Size = new Size(75, 28);
            label3.TabIndex = 16;
            label3.Text = "Answer";
            label3.Click += label3_Click_1;
            // 
            // button6
            // 
            button6.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            button6.ImageAlign = ContentAlignment.BottomRight;
            button6.Location = new Point(418, 288);
            button6.Margin = new Padding(3, 2, 3, 2);
            button6.Name = "button6";
            button6.Padding = new Padding(3, 0, 0, 5);
            button6.Size = new Size(201, 60);
            button6.TabIndex = 17;
            button6.Text = "Clear";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 422);
            Controls.Add(button6);
            Controls.Add(label3);
            Controls.Add(button5);
            Controls.Add(label2);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(button1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private TextBox textBox1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Label label2;
        private Button button5;
        private Label label3;
        private Button button6;
    }
}