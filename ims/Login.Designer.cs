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
            leftPanel.Margin = new Padding(3, 5, 3, 5);
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
            // 
            // panel1
            // 
            panel1.Margin = new Padding(3, 5, 3, 5);
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(14, 208);
            label4.Name = "label4";
            label4.Size = new Size(75, 20);
            label4.TabIndex = 3;
            label4.Text = "Username";
            label4.Click += label4_Click;
            // 
            // usernametext
            // 
            usernametext.Location = new Point(14, 232);
            usernametext.Margin = new Padding(3, 4, 3, 4);
            usernametext.MaxLength = 30;
            usernametext.Name = "usernametext";
            usernametext.Size = new Size(233, 27);
            usernametext.TabIndex = 4;
            // 
            // passwordText
            // 
            passwordText.Location = new Point(14, 291);
            passwordText.Margin = new Padding(3, 4, 3, 4);
            passwordText.MaxLength = 30;
            passwordText.Name = "passwordText";
            passwordText.Size = new Size(233, 27);
            passwordText.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(14, 267);
            label3.Name = "label3";
            label3.Size = new Size(70, 20);
            label3.TabIndex = 5;
            label3.Text = "Password";
            // 
            // loginButton
            // 
            loginButton.FlatAppearance.BorderSize = 2;
            loginButton.FlatStyle = FlatStyle.Flat;
            loginButton.Location = new Point(14, 329);
            loginButton.Margin = new Padding(3, 4, 3, 4);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(233, 40);
            loginButton.TabIndex = 7;
            loginButton.Text = "Login";
            loginButton.UseVisualStyleBackColor = true;
            loginButton.Click += loginButton_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Margin = new Padding(3, 5, 3, 5);
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
    }
}