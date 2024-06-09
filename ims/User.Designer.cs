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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
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
            nameErrorLabel = new Label();
            usernameErrorLabel = new Label();
            passwordErrorLabel = new Label();
            emailErrorLabel = new Label();
            phoneErrorLabel = new Label();
            dataGridView1 = new DataGridView();
            userIDGV = new DataGridViewTextBoxColumn();
            NameGV = new DataGridViewTextBoxColumn();
            UserNameGV = new DataGridViewTextBoxColumn();
            PassGV = new DataGridViewTextBoxColumn();
            EmailGV = new DataGridViewTextBoxColumn();
            PhoneGV = new DataGridViewTextBoxColumn();
            StatusGV = new DataGridViewTextBoxColumn();
            label8 = new Label();
            statusDD = new ComboBox();
            statusErrorLabel = new Label();
            actionLeftPanel.SuspendLayout();
            leftPanel.SuspendLayout();
            rightPanel.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // backBtn
            // 
            backBtn.FlatAppearance.BorderSize = 0;
            backBtn.Click += backBtn_Click;
            // 
            // searchBox
            // 
            searchBox.Margin = new Padding(3, 2, 3, 2);
            searchBox.Size = new Size(84, 23);
            // 
            // actionLeftPanel
            // 
            actionLeftPanel.Dock = DockStyle.None;
            // 
            // formsHeadingLabel
            // 
            formsHeadingLabel.Size = new Size(85, 21);
            formsHeadingLabel.Text = "User Form";
            // 
            // leftPanel
            // 
            leftPanel.Controls.Add(statusDD);
            leftPanel.Controls.Add(label8);
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
            leftPanel.Controls.Add(statusErrorLabel);
            leftPanel.Controls.SetChildIndex(actionLeftPanel, 0);
            leftPanel.Controls.SetChildIndex(statusErrorLabel, 0);
            leftPanel.Controls.SetChildIndex(phoneErrorLabel, 0);
            leftPanel.Controls.SetChildIndex(emailErrorLabel, 0);
            leftPanel.Controls.SetChildIndex(passwordErrorLabel, 0);
            leftPanel.Controls.SetChildIndex(usernameErrorLabel, 0);
            leftPanel.Controls.SetChildIndex(nameErrorLabel, 0);
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
            leftPanel.Controls.SetChildIndex(label8, 0);
            leftPanel.Controls.SetChildIndex(statusDD, 0);
            leftPanel.Controls.SetChildIndex(panel1, 0);
            // 
            // rightPanel
            // 
            rightPanel.Controls.Add(dataGridView1);
            rightPanel.Controls.SetChildIndex(dataGridView1, 0);
            // 
            // phoneTxt
            // 
            phoneTxt.Location = new Point(10, 286);
            phoneTxt.Margin = new Padding(3, 2, 3, 2);
            phoneTxt.Name = "phoneTxt";
            phoneTxt.Size = new Size(206, 23);
            phoneTxt.TabIndex = 7;
            // 
            // emailTxt
            // 
            emailTxt.Location = new Point(10, 247);
            emailTxt.Margin = new Padding(3, 2, 3, 2);
            emailTxt.Name = "emailTxt";
            emailTxt.Size = new Size(206, 23);
            emailTxt.TabIndex = 8;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(10, 269);
            label7.Name = "label7";
            label7.Size = new Size(41, 15);
            label7.TabIndex = 2;
            label7.Text = "Phone";
            // 
            // passwordTxt
            // 
            passwordTxt.Location = new Point(10, 207);
            passwordTxt.Margin = new Padding(3, 2, 3, 2);
            passwordTxt.Name = "passwordTxt";
            passwordTxt.Size = new Size(206, 23);
            passwordTxt.TabIndex = 9;
            passwordTxt.UseSystemPasswordChar = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(10, 230);
            label6.Name = "label6";
            label6.Size = new Size(36, 15);
            label6.TabIndex = 3;
            label6.Text = "Email";
            // 
            // usernameTxt
            // 
            usernameTxt.Location = new Point(10, 167);
            usernameTxt.Margin = new Padding(3, 2, 3, 2);
            usernameTxt.Name = "usernameTxt";
            usernameTxt.Size = new Size(206, 23);
            usernameTxt.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(10, 190);
            label5.Name = "label5";
            label5.Size = new Size(57, 15);
            label5.TabIndex = 4;
            label5.Text = "Password";
            // 
            // nameTxt
            // 
            nameTxt.Location = new Point(10, 128);
            nameTxt.Margin = new Padding(3, 2, 3, 2);
            nameTxt.Name = "nameTxt";
            nameTxt.Size = new Size(206, 23);
            nameTxt.TabIndex = 11;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(10, 150);
            label4.Name = "label4";
            label4.Size = new Size(60, 15);
            label4.TabIndex = 5;
            label4.Text = "Username";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(10, 110);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 6;
            label3.Text = "Name";
            // 
            // nameErrorLabel
            // 
            nameErrorLabel.AutoSize = true;
            nameErrorLabel.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nameErrorLabel.ForeColor = Color.LightCoral;
            nameErrorLabel.Location = new Point(46, 105);
            nameErrorLabel.Name = "nameErrorLabel";
            nameErrorLabel.Size = new Size(22, 30);
            nameErrorLabel.TabIndex = 13;
            nameErrorLabel.Text = "*";
            nameErrorLabel.Visible = false;
            // 
            // usernameErrorLabel
            // 
            usernameErrorLabel.AutoSize = true;
            usernameErrorLabel.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            usernameErrorLabel.ForeColor = Color.LightCoral;
            usernameErrorLabel.Location = new Point(69, 144);
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
            passwordErrorLabel.Location = new Point(65, 184);
            passwordErrorLabel.Name = "passwordErrorLabel";
            passwordErrorLabel.Size = new Size(22, 30);
            passwordErrorLabel.TabIndex = 15;
            passwordErrorLabel.Text = "*";
            passwordErrorLabel.Visible = false;
            // 
            // emailErrorLabel
            // 
            emailErrorLabel.AutoSize = true;
            emailErrorLabel.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            emailErrorLabel.ForeColor = Color.LightCoral;
            emailErrorLabel.Location = new Point(45, 224);
            emailErrorLabel.Name = "emailErrorLabel";
            emailErrorLabel.Size = new Size(22, 30);
            emailErrorLabel.TabIndex = 16;
            emailErrorLabel.Text = "*";
            emailErrorLabel.Visible = false;
            // 
            // phoneErrorLabel
            // 
            phoneErrorLabel.AutoSize = true;
            phoneErrorLabel.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            phoneErrorLabel.ForeColor = Color.LightCoral;
            phoneErrorLabel.Location = new Point(46, 265);
            phoneErrorLabel.Name = "phoneErrorLabel";
            phoneErrorLabel.Size = new Size(22, 30);
            phoneErrorLabel.TabIndex = 17;
            phoneErrorLabel.Text = "*";
            phoneErrorLabel.Visible = false;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { userIDGV, NameGV, UserNameGV, PassGV, EmailGV, PhoneGV, StatusGV });
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 100);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(571, 350);
            dataGridView1.TabIndex = 2;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // userIDGV
            // 
            userIDGV.HeaderText = "User ID";
            userIDGV.MinimumWidth = 6;
            userIDGV.Name = "userIDGV";
            userIDGV.ReadOnly = true;
            userIDGV.Visible = false;
            // 
            // NameGV
            // 
            NameGV.HeaderText = "Name";
            NameGV.MinimumWidth = 6;
            NameGV.Name = "NameGV";
            NameGV.ReadOnly = true;
            // 
            // UserNameGV
            // 
            UserNameGV.HeaderText = "Username";
            UserNameGV.MinimumWidth = 6;
            UserNameGV.Name = "UserNameGV";
            UserNameGV.ReadOnly = true;
            // 
            // PassGV
            // 
            PassGV.HeaderText = "Password";
            PassGV.MinimumWidth = 6;
            PassGV.Name = "PassGV";
            PassGV.ReadOnly = true;
            // 
            // EmailGV
            // 
            EmailGV.HeaderText = "Email";
            EmailGV.MinimumWidth = 6;
            EmailGV.Name = "EmailGV";
            EmailGV.ReadOnly = true;
            // 
            // PhoneGV
            // 
            PhoneGV.HeaderText = "Phone";
            PhoneGV.MinimumWidth = 6;
            PhoneGV.Name = "PhoneGV";
            PhoneGV.ReadOnly = true;
            // 
            // StatusGV
            // 
            StatusGV.HeaderText = "Status";
            StatusGV.MinimumWidth = 6;
            StatusGV.Name = "StatusGV";
            StatusGV.ReadOnly = true;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(10, 309);
            label8.Name = "label8";
            label8.Size = new Size(39, 15);
            label8.TabIndex = 18;
            label8.Text = "Status";
            // 
            // statusDD
            // 
            statusDD.DropDownStyle = ComboBoxStyle.DropDownList;
            statusDD.FormattingEnabled = true;
            statusDD.Items.AddRange(new object[] { "Active", "In-active" });
            statusDD.Location = new Point(10, 326);
            statusDD.Margin = new Padding(3, 2, 3, 2);
            statusDD.Name = "statusDD";
            statusDD.Size = new Size(205, 23);
            statusDD.TabIndex = 19;
            // 
            // statusErrorLabel
            // 
            statusErrorLabel.AutoSize = true;
            statusErrorLabel.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            statusErrorLabel.ForeColor = Color.LightCoral;
            statusErrorLabel.Location = new Point(46, 304);
            statusErrorLabel.Name = "statusErrorLabel";
            statusErrorLabel.Size = new Size(22, 30);
            statusErrorLabel.TabIndex = 20;
            statusErrorLabel.Text = "*";
            statusErrorLabel.Visible = false;
            // 
            // User
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Margin = new Padding(3, 5, 3, 5);
            Name = "User";
            Text = "User";
            Load += User_Load;
            actionLeftPanel.ResumeLayout(false);
            actionLeftPanel.PerformLayout();
            leftPanel.ResumeLayout(false);
            leftPanel.PerformLayout();
            rightPanel.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
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
        private Label nameErrorLabel;
        private Label usernameErrorLabel;
        private Label passwordErrorLabel;
        private Label emailErrorLabel;
        private Label phoneErrorLabel;
        private DataGridView dataGridView1;
        private Label label8;
        private ComboBox statusDD;
        private DataGridViewTextBoxColumn userIDGV;
        private DataGridViewTextBoxColumn NameGV;
        private DataGridViewTextBoxColumn UserNameGV;
        private DataGridViewTextBoxColumn PassGV;
        private DataGridViewTextBoxColumn EmailGV;
        private DataGridViewTextBoxColumn PhoneGV;
        private DataGridViewTextBoxColumn StatusGV;
        private Label statusErrorLabel;
    }
}