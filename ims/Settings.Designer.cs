namespace ims
{
    partial class Settings
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
            panel3 = new Panel();
            textBox1 = new TextBox();
            serverText = new Label();
            panel4 = new Panel();
            textBox2 = new TextBox();
            label4 = new Label();
            panel5 = new Panel();
            textBox3 = new TextBox();
            label5 = new Label();
            panel6 = new Panel();
            textBox4 = new TextBox();
            label6 = new Label();
            button1 = new Button();
            isIntegratedSecurity = new CheckBox();
            leftPanel.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            SuspendLayout();
            // 
            // leftPanel
            // 
            leftPanel.Controls.Add(isIntegratedSecurity);
            leftPanel.Controls.Add(panel6);
            leftPanel.Controls.Add(button1);
            leftPanel.Controls.Add(panel4);
            leftPanel.Controls.Add(panel5);
            leftPanel.Controls.Add(panel3);
            leftPanel.Controls.SetChildIndex(panel3, 0);
            leftPanel.Controls.SetChildIndex(panel5, 0);
            leftPanel.Controls.SetChildIndex(panel4, 0);
            leftPanel.Controls.SetChildIndex(button1, 0);
            leftPanel.Controls.SetChildIndex(panel6, 0);
            leftPanel.Controls.SetChildIndex(isIntegratedSecurity, 0);
            // 
            // panel3
            // 
            panel3.Controls.Add(textBox1);
            panel3.Controls.Add(serverText);
            panel3.Location = new Point(12, 92);
            panel3.Name = "panel3";
            panel3.Size = new Size(174, 41);
            panel3.TabIndex = 1;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(0, 18);
            textBox1.MaxLength = 50;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(174, 23);
            textBox1.TabIndex = 1;
            // 
            // serverText
            // 
            serverText.AutoSize = true;
            serverText.Location = new Point(0, 0);
            serverText.Name = "serverText";
            serverText.Size = new Size(39, 15);
            serverText.TabIndex = 0;
            serverText.Text = "Server";
            // 
            // panel4
            // 
            panel4.Controls.Add(textBox2);
            panel4.Controls.Add(label4);
            panel4.Location = new Point(12, 139);
            panel4.Name = "panel4";
            panel4.Size = new Size(174, 41);
            panel4.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(0, 18);
            textBox2.MaxLength = 50;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(174, 23);
            textBox2.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(0, 0);
            label4.Name = "label4";
            label4.Size = new Size(55, 15);
            label4.TabIndex = 0;
            label4.Text = "Database";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(0, 18);
            textBox3.MaxLength = 50;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(174, 23);
            textBox3.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(0, 0);
            label5.Name = "label5";
            label5.Size = new Size(60, 15);
            label5.TabIndex = 0;
            label5.Text = "Username";
            // 
            // panel6
            // 
            panel6.Controls.Add(textBox4);
            panel6.Controls.Add(label6);
            panel6.Location = new Point(12, 233);
            panel6.Name = "panel6";
            panel6.Size = new Size(174, 41);
            panel6.TabIndex = 2;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(0, 18);
            textBox4.MaxLength = 50;
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(174, 23);
            textBox4.TabIndex = 4;
            textBox4.UseSystemPasswordChar = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(0, 0);
            label6.Name = "label6";
            label6.Size = new Size(57, 15);
            label6.TabIndex = 0;
            label6.Text = "Password";
            // 
            // button1
            // 
            button1.FlatAppearance.BorderSize = 2;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(12, 310);
            button1.Name = "button1";
            button1.Size = new Size(174, 30);
            button1.TabIndex = 6;
            button1.Text = "Save";
            button1.UseVisualStyleBackColor = true;
            // 
            // isIntegratedSecurity
            // 
            isIntegratedSecurity.BackColor = SystemColors.HotTrack;
            isIntegratedSecurity.Location = new Point(12, 280);
            isIntegratedSecurity.Name = "isIntegratedSecurity";
            isIntegratedSecurity.Size = new Size(174, 24);
            isIntegratedSecurity.TabIndex = 1;
            isIntegratedSecurity.Text = "Integrated Security";
            isIntegratedSecurity.UseVisualStyleBackColor = false;
            isIntegratedSecurity.CheckedChanged += isIntegratedSecurity_CheckedChanged;
            // 
            // Settings
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Name = "Settings";
            Text = "Settings";
            leftPanel.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel3;
        private TextBox textBox1;
        private Label serverText;
        private Panel panel4;
        private TextBox textBox2;
        private Label label4;
        private Panel panel5;
        private TextBox textBox3;
        private Label label5;
        private Panel panel6;
        private TextBox textBox4;
        private Label label6;
        private CheckBox isIntegratedSecurity;
        private Button button1;
    }
}