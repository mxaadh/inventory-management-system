namespace ims
{
    partial class Login
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
            label4 = new Label();
            usernametext = new TextBox();
            passwordText = new TextBox();
            label3 = new Label();
            loginButton = new Button();
            usernameErrorLabel = new Label();
            passwordErrorLabel = new Label();
            leftPanel.SuspendLayout();
            SuspendLayout();
            // 
            // leftPanel
            // 
            leftPanel.Controls.Add(loginButton);
            leftPanel.Controls.Add(passwordText);
            leftPanel.Controls.Add(label3);
            leftPanel.Controls.Add(usernametext);
            leftPanel.Controls.Add(label4);
            leftPanel.Controls.Add(usernameErrorLabel);
            leftPanel.Controls.Add(passwordErrorLabel);
            leftPanel.Margin = new Padding(3, 5, 3, 5);
            leftPanel.Controls.SetChildIndex(passwordErrorLabel, 0);
            leftPanel.Controls.SetChildIndex(usernameErrorLabel, 0);
            leftPanel.Controls.SetChildIndex(panel1, 0);
            leftPanel.Controls.SetChildIndex(label4, 0);
            leftPanel.Controls.SetChildIndex(usernametext, 0);
            leftPanel.Controls.SetChildIndex(label3, 0);
            leftPanel.Controls.SetChildIndex(passwordText, 0);
            leftPanel.Controls.SetChildIndex(loginButton, 0);
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
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 156);
            label4.Name = "label4";
            label4.Size = new Size(60, 15);
            label4.TabIndex = 3;
            label4.Text = "Username";
            label4.Click += label4_Click;
            // 
            // usernametext
            // 
            usernametext.Location = new Point(12, 174);
            usernametext.MaxLength = 30;
            usernametext.Name = "usernametext";
            usernametext.Size = new Size(204, 23);
            usernametext.TabIndex = 4;
            usernametext.TextChanged += usernametext_TextChanged;
            // 
            // passwordText
            // 
            passwordText.Location = new Point(12, 218);
            passwordText.MaxLength = 30;
            passwordText.Name = "passwordText";
            passwordText.Size = new Size(204, 23);
            passwordText.TabIndex = 6;
            passwordText.TextChanged += passwordText_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 200);
            label3.Name = "label3";
            label3.Size = new Size(57, 15);
            label3.TabIndex = 5;
            label3.Text = "Password";
            // 
            // loginButton
            // 
            loginButton.FlatAppearance.BorderSize = 2;
            loginButton.FlatStyle = FlatStyle.Flat;
            loginButton.Location = new Point(12, 247);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(204, 30);
            loginButton.TabIndex = 7;
            loginButton.Text = "Login";
            loginButton.UseVisualStyleBackColor = true;
            loginButton.Click += loginButton_Click;
            // 
            // usernameErrorLabel
            // 
            usernameErrorLabel.AutoSize = true;
            usernameErrorLabel.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            usernameErrorLabel.ForeColor = Color.LightCoral;
            usernameErrorLabel.Location = new Point(68, 150);
            usernameErrorLabel.Name = "usernameErrorLabel";
            usernameErrorLabel.Size = new Size(22, 30);
            usernameErrorLabel.TabIndex = 14;
            usernameErrorLabel.Text = "*";
            usernameErrorLabel.Visible = false;
            // 
            // passwordErrorLabel
            // 
            passwordErrorLabel.AutoSize = true;
            passwordErrorLabel.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            passwordErrorLabel.ForeColor = Color.LightCoral;
            passwordErrorLabel.Location = new Point(65, 194);
            passwordErrorLabel.Name = "passwordErrorLabel";
            passwordErrorLabel.Size = new Size(22, 30);
            passwordErrorLabel.TabIndex = 15;
            passwordErrorLabel.Text = "*";
            passwordErrorLabel.Visible = false;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Login";
            Text = "Login";
            leftPanel.ResumeLayout(false);
            leftPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label4;
        private TextBox usernametext;
        private TextBox passwordText;
        private Label label3;
        private Button loginButton;
        private Label usernameErrorLabel;
        private Label passwordErrorLabel;
    }
}