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
            phoneTxt = new TextBox();
            emailTxt = new TextBox();
            label7 = new Label();
            passwordTxt = new TextBox();
            label6 = new Label();
            usernameTxt = new TextBox();
            label5 = new Label();
            nameTxt = new TextBox();
            label4 = new Label();
            label3 = new Label();
            panel3 = new Panel();
            nameErrorLabel = new Label();
            usernameErrorLabel = new Label();
            passwordErrorLabel = new Label();
            emailErrorLabel = new Label();
            phoneErrorLabel = new Label();
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
            leftPanel.Controls.Add(panel3);
            leftPanel.Controls.Add(phoneTxt);
            leftPanel.Controls.Add(emailTxt);
            leftPanel.Controls.Add(label7);
            leftPanel.Controls.Add(passwordTxt);
            leftPanel.Controls.Add(label6);
            leftPanel.Controls.Add(usernameTxt);
            leftPanel.Controls.Add(label5);
            leftPanel.Controls.Add(nameTxt);
            leftPanel.Controls.Add(label4);
            leftPanel.Controls.Add(label3);
            leftPanel.Controls.Add(nameErrorLabel);
            leftPanel.Controls.Add(usernameErrorLabel);
            leftPanel.Controls.Add(passwordErrorLabel);
            leftPanel.Controls.Add(emailErrorLabel);
            leftPanel.Controls.Add(phoneErrorLabel);
            leftPanel.Controls.SetChildIndex(phoneErrorLabel, 0);
            leftPanel.Controls.SetChildIndex(emailErrorLabel, 0);
            leftPanel.Controls.SetChildIndex(passwordErrorLabel, 0);
            leftPanel.Controls.SetChildIndex(usernameErrorLabel, 0);
            leftPanel.Controls.SetChildIndex(nameErrorLabel, 0);
            leftPanel.Controls.SetChildIndex(panel1, 0);
            leftPanel.Controls.SetChildIndex(label3, 0);
            leftPanel.Controls.SetChildIndex(label4, 0);
            leftPanel.Controls.SetChildIndex(nameTxt, 0);
            leftPanel.Controls.SetChildIndex(label5, 0);
            leftPanel.Controls.SetChildIndex(usernameTxt, 0);
            leftPanel.Controls.SetChildIndex(label6, 0);
            leftPanel.Controls.SetChildIndex(passwordTxt, 0);
            leftPanel.Controls.SetChildIndex(label7, 0);
            leftPanel.Controls.SetChildIndex(emailTxt, 0);
            leftPanel.Controls.SetChildIndex(phoneTxt, 0);
            leftPanel.Controls.SetChildIndex(panel3, 0);
            // 
            // phoneTxt
            // 
            phoneTxt.Location = new Point(12, 379);
            phoneTxt.Name = "phoneTxt";
            phoneTxt.Size = new Size(211, 27);
            phoneTxt.TabIndex = 7;
            // 
            // emailTxt
            // 
            emailTxt.Location = new Point(12, 326);
            emailTxt.Name = "emailTxt";
            emailTxt.Size = new Size(211, 27);
            emailTxt.TabIndex = 8;
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
            // passwordTxt
            // 
            passwordTxt.Location = new Point(12, 273);
            passwordTxt.Name = "passwordTxt";
            passwordTxt.Size = new Size(211, 27);
            passwordTxt.TabIndex = 9;
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
            // usernameTxt
            // 
            usernameTxt.Location = new Point(12, 220);
            usernameTxt.Name = "usernameTxt";
            usernameTxt.Size = new Size(211, 27);
            usernameTxt.TabIndex = 10;
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
            // nameTxt
            // 
            nameTxt.Location = new Point(12, 167);
            nameTxt.Name = "nameTxt";
            nameTxt.Size = new Size(211, 27);
            nameTxt.TabIndex = 11;
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
            // panel3
            // 
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 67);
            panel3.Name = "panel3";
            panel3.Size = new Size(229, 67);
            panel3.TabIndex = 12;
            // 
            // nameErrorLabel
            // 
            nameErrorLabel.AutoSize = true;
            nameErrorLabel.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nameErrorLabel.ForeColor = Color.LightCoral;
            nameErrorLabel.Location = new Point(54, 137);
            nameErrorLabel.Name = "nameErrorLabel";
            nameErrorLabel.Size = new Size(29, 38);
            nameErrorLabel.TabIndex = 13;
            nameErrorLabel.Text = "*";
            nameErrorLabel.Visible = false;
            // 
            // usernameErrorLabel
            // 
            usernameErrorLabel.AutoSize = true;
            usernameErrorLabel.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            usernameErrorLabel.ForeColor = Color.LightCoral;
            usernameErrorLabel.Location = new Point(80, 189);
            usernameErrorLabel.Name = "usernameErrorLabel";
            usernameErrorLabel.Size = new Size(29, 38);
            usernameErrorLabel.TabIndex = 14;
            usernameErrorLabel.Text = "*";
            usernameErrorLabel.Visible = false;
            // 
            // passwordErrorLabel
            // 
            passwordErrorLabel.AutoSize = true;
            passwordErrorLabel.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            passwordErrorLabel.ForeColor = Color.LightCoral;
            passwordErrorLabel.Location = new Point(75, 243);
            passwordErrorLabel.Name = "passwordErrorLabel";
            passwordErrorLabel.Size = new Size(29, 38);
            passwordErrorLabel.TabIndex = 15;
            passwordErrorLabel.Text = "*";
            passwordErrorLabel.Visible = false;
            // 
            // emailErrorLabel
            // 
            emailErrorLabel.AutoSize = true;
            emailErrorLabel.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            emailErrorLabel.ForeColor = Color.LightCoral;
            emailErrorLabel.Location = new Point(52, 296);
            emailErrorLabel.Name = "emailErrorLabel";
            emailErrorLabel.Size = new Size(29, 38);
            emailErrorLabel.TabIndex = 16;
            emailErrorLabel.Text = "*";
            emailErrorLabel.Visible = false;
            // 
            // phoneErrorLabel
            // 
            phoneErrorLabel.AutoSize = true;
            phoneErrorLabel.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            phoneErrorLabel.ForeColor = Color.LightCoral;
            phoneErrorLabel.Location = new Point(54, 350);
            phoneErrorLabel.Name = "phoneErrorLabel";
            phoneErrorLabel.Size = new Size(29, 38);
            phoneErrorLabel.TabIndex = 17;
            phoneErrorLabel.Text = "*";
            phoneErrorLabel.Visible = false;
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

        private TextBox phoneTxt;
        private TextBox emailTxt;
        private Label label7;
        private TextBox passwordTxt;
        private Label label6;
        private TextBox usernameTxt;
        private Label label5;
        private TextBox nameTxt;
        private Label label4;
        private Label label3;
        private Panel panel3;
        private Label nameErrorLabel;
        private Label usernameErrorLabel;
        private Label passwordErrorLabel;
        private Label emailErrorLabel;
        private Label phoneErrorLabel;
    }
}