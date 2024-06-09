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
            textBoxServer = new TextBox();
            serverText = new Label();
            textBox3 = new TextBox();
            label5 = new Label();
            saveSettings = new Button();
            isIntegratedSecurity = new CheckBox();
            panel4 = new Panel();
            textBoxDatabase = new TextBox();
            label3 = new Label();
            panel5 = new Panel();
            textBoxPassword = new TextBox();
            label4 = new Label();
            panel6 = new Panel();
            textBoxUsername = new TextBox();
            label6 = new Label();
            leftPanel.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            SuspendLayout();
            // 
            // leftPanel
            // 
            leftPanel.Controls.Add(panel5);
            leftPanel.Controls.Add(panel4);
            leftPanel.Controls.Add(panel6);
            leftPanel.Controls.Add(isIntegratedSecurity);
            leftPanel.Controls.Add(saveSettings);
            leftPanel.Controls.Add(panel3);
            leftPanel.Margin = new Padding(3, 5, 3, 5);
            leftPanel.Controls.SetChildIndex(panel1, 0);
            leftPanel.Controls.SetChildIndex(panel3, 0);
            leftPanel.Controls.SetChildIndex(saveSettings, 0);
            leftPanel.Controls.SetChildIndex(isIntegratedSecurity, 0);
            leftPanel.Controls.SetChildIndex(panel6, 0);
            leftPanel.Controls.SetChildIndex(panel4, 0);
            leftPanel.Controls.SetChildIndex(panel5, 0);
            // 
            // rightPanel
            // 
            rightPanel.Margin = new Padding(3, 5, 3, 5);
            rightPanel.Size = new Size(571, 450);
            // 
            // panel1
            // 
            panel1.Margin = new Padding(3, 5, 3, 5);
            // 
            // panel3
            // 
            panel3.Controls.Add(textBoxServer);
            panel3.Controls.Add(serverText);
            panel3.Location = new Point(12, 92);
            panel3.Name = "panel3";
            panel3.Size = new Size(203, 41);
            panel3.TabIndex = 1;
            // 
            // textBoxServer
            // 
            textBoxServer.Dock = DockStyle.Bottom;
            textBoxServer.Location = new Point(0, 18);
            textBoxServer.MaxLength = 50;
            textBoxServer.Name = "textBoxServer";
            textBoxServer.Size = new Size(203, 23);
            textBoxServer.TabIndex = 1;
            // 
            // serverText
            // 
            serverText.AutoSize = true;
            serverText.Dock = DockStyle.Top;
            serverText.Location = new Point(0, 0);
            serverText.Name = "serverText";
            serverText.Size = new Size(39, 15);
            serverText.TabIndex = 0;
            serverText.Text = "Server";
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
            // saveSettings
            // 
            saveSettings.FlatAppearance.BorderSize = 2;
            saveSettings.FlatStyle = FlatStyle.Flat;
            saveSettings.Location = new Point(12, 298);
            saveSettings.Name = "saveSettings";
            saveSettings.Size = new Size(203, 30);
            saveSettings.TabIndex = 6;
            saveSettings.Text = "Save";
            saveSettings.UseVisualStyleBackColor = true;
            saveSettings.Click += saveSettings_Click;
            // 
            // isIntegratedSecurity
            // 
            isIntegratedSecurity.BackColor = SystemColors.HotTrack;
            isIntegratedSecurity.Location = new Point(12, 268);
            isIntegratedSecurity.Name = "isIntegratedSecurity";
            isIntegratedSecurity.Size = new Size(203, 24);
            isIntegratedSecurity.TabIndex = 1;
            isIntegratedSecurity.Text = "Integrated Security";
            isIntegratedSecurity.UseVisualStyleBackColor = false;
            isIntegratedSecurity.CheckedChanged += isIntegratedSecurity_CheckedChanged;
            // 
            // panel4
            // 
            panel4.Controls.Add(textBoxDatabase);
            panel4.Controls.Add(label3);
            panel4.Location = new Point(12, 136);
            panel4.Name = "panel4";
            panel4.Size = new Size(203, 41);
            panel4.TabIndex = 2;
            // 
            // textBoxDatabase
            // 
            textBoxDatabase.Dock = DockStyle.Bottom;
            textBoxDatabase.Location = new Point(0, 18);
            textBoxDatabase.MaxLength = 50;
            textBoxDatabase.Name = "textBoxDatabase";
            textBoxDatabase.Size = new Size(203, 23);
            textBoxDatabase.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Top;
            label3.Location = new Point(0, 0);
            label3.Name = "label3";
            label3.Size = new Size(55, 15);
            label3.TabIndex = 0;
            label3.Text = "Database";
            // 
            // panel5
            // 
            panel5.Controls.Add(textBoxPassword);
            panel5.Controls.Add(label4);
            panel5.Location = new Point(12, 224);
            panel5.Name = "panel5";
            panel5.Size = new Size(203, 41);
            panel5.TabIndex = 4;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Dock = DockStyle.Bottom;
            textBoxPassword.Location = new Point(0, 18);
            textBoxPassword.MaxLength = 50;
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(203, 23);
            textBoxPassword.TabIndex = 1;
            textBoxPassword.UseSystemPasswordChar = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Dock = DockStyle.Top;
            label4.Location = new Point(0, 0);
            label4.Name = "label4";
            label4.Size = new Size(57, 15);
            label4.TabIndex = 0;
            label4.Text = "Password";
            // 
            // panel6
            // 
            panel6.Controls.Add(textBoxUsername);
            panel6.Controls.Add(label6);
            panel6.Location = new Point(12, 180);
            panel6.Name = "panel6";
            panel6.Size = new Size(203, 41);
            panel6.TabIndex = 3;
            // 
            // textBoxUsername
            // 
            textBoxUsername.Dock = DockStyle.Bottom;
            textBoxUsername.Location = new Point(0, 18);
            textBoxUsername.MaxLength = 50;
            textBoxUsername.Name = "textBoxUsername";
            textBoxUsername.Size = new Size(203, 23);
            textBoxUsername.TabIndex = 1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Dock = DockStyle.Top;
            label6.Location = new Point(0, 0);
            label6.Name = "label6";
            label6.Size = new Size(60, 15);
            label6.TabIndex = 0;
            label6.Text = "Username";
            // 
            // Settings
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Margin = new Padding(3, 4, 3, 4);
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
        private TextBox textBoxServer;
        private Label serverText;
        private TextBox textBox3;
        private Label label5;
        private CheckBox isIntegratedSecurity;
        private Button saveSettings;
        private Panel panel5;
        private TextBox textBoxPassword;
        private Label label4;
        private Panel panel4;
        private TextBox textBoxDatabase;
        private Label label3;
        private Panel panel6;
        private TextBox textBoxUsername;
        private Label label6;
    }
}