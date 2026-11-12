namespace Tutorial_5_2
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
            listBox1 = new ListBox();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBox3 = new TextBox();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(93, 216);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(657, 234);
            listBox1.TabIndex = 0;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(185, 43);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(358, 30);
            textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(185, 116);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(358, 30);
            textBox2.TabIndex = 2;
            // 
            // button1
            // 
            button1.Location = new Point(93, 507);
            button1.Name = "button1";
            button1.Size = new Size(166, 61);
            button1.TabIndex = 3;
            button1.Text = "計算";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(314, 507);
            button2.Name = "button2";
            button2.Size = new Size(166, 61);
            button2.TabIndex = 4;
            button2.Text = "清除";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(520, 507);
            button3.Name = "button3";
            button3.Size = new Size(166, 61);
            button3.TabIndex = 5;
            button3.Text = "退出";
            button3.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(93, 43);
            label1.Name = "label1";
            label1.Size = new Size(86, 23);
            label1.TabIndex = 6;
            label1.Text = "起始餘額:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(93, 116);
            label2.Name = "label2";
            label2.Size = new Size(86, 23);
            label2.TabIndex = 7;
            label2.Text = "月份數量:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(93, 466);
            label3.Name = "label3";
            label3.Size = new Size(50, 23);
            label3.TabIndex = 8;
            label3.Text = "結餘:";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(185, 463);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(358, 30);
            textBox3.TabIndex = 9;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(853, 580);
            Controls.Add(textBox3);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(listBox1);
            Name = "Form1";
            Text = "Form1";

            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBox1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button button1;
        private Button button2;
        private Button button3;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBox3;
    }
}
