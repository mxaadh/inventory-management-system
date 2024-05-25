namespace ims
{
    partial class User
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
            textBox6 = new TextBox();
            textBox5 = new TextBox();
            label7 = new Label();
            textBox4 = new TextBox();
            label6 = new Label();
            textBox3 = new TextBox();
            label5 = new Label();
            textBox1 = new TextBox();
            label4 = new Label();
            label3 = new Label();
            leftPanel.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // backBtn
            // 
            backBtn.FlatAppearance.BorderSize = 0;
            backBtn.Click += backBtn_Click;
            // 
            // leftPanel
            // 
            leftPanel.Controls.Add(textBox6);
            leftPanel.Controls.Add(textBox5);
            leftPanel.Controls.Add(label7);
            leftPanel.Controls.Add(textBox4);
            leftPanel.Controls.Add(label6);
            leftPanel.Controls.Add(textBox3);
            leftPanel.Controls.Add(label5);
            leftPanel.Controls.Add(textBox1);
            leftPanel.Controls.Add(label4);
            leftPanel.Controls.Add(label3);
            leftPanel.Controls.SetChildIndex(panel1, 0);
            leftPanel.Controls.SetChildIndex(label3, 0);
            leftPanel.Controls.SetChildIndex(label4, 0);
            leftPanel.Controls.SetChildIndex(textBox1, 0);
            leftPanel.Controls.SetChildIndex(label5, 0);
            leftPanel.Controls.SetChildIndex(textBox3, 0);
            leftPanel.Controls.SetChildIndex(label6, 0);
            leftPanel.Controls.SetChildIndex(textBox4, 0);
            leftPanel.Controls.SetChildIndex(label7, 0);
            leftPanel.Controls.SetChildIndex(textBox5, 0);
            leftPanel.Controls.SetChildIndex(textBox6, 0);
            // 
            // panel1
            // 
            panel1.Location = new Point(0, 67);
            // 
            // textBox6
            // 
            textBox6.Location = new Point(12, 379);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(211, 27);
            textBox6.TabIndex = 7;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(12, 326);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(211, 27);
            textBox5.TabIndex = 8;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(12, 356);
            label7.Name = "label7";
            label7.Size = new Size(50, 20);
            label7.TabIndex = 2;
            label7.Text = "Phone";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(12, 273);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(211, 27);
            textBox4.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(13, 303);
            label6.Name = "label6";
            label6.Size = new Size(46, 20);
            label6.TabIndex = 3;
            label6.Text = "Email";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(12, 220);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(211, 27);
            textBox3.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 250);
            label5.Name = "label5";
            label5.Size = new Size(70, 20);
            label5.TabIndex = 4;
            label5.Text = "Password";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 167);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(211, 27);
            textBox1.TabIndex = 11;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 197);
            label4.Name = "label4";
            label4.Size = new Size(75, 20);
            label4.TabIndex = 5;
            label4.Text = "Username";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(13, 144);
            label3.Name = "label3";
            label3.Size = new Size(49, 20);
            label3.TabIndex = 6;
            label3.Text = "Name";
            // 
            // User
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Margin = new Padding(3, 7, 3, 7);
            Name = "User";
            Text = "User";
            Load += User_Load;
            leftPanel.ResumeLayout(false);
            leftPanel.PerformLayout();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TextBox textBox6;
        private TextBox textBox5;
        private Label label7;
        private TextBox textBox4;
        private Label label6;
        private TextBox textBox3;
        private Label label5;
        private TextBox textBox1;
        private Label label4;
        private Label label3;
    }
}