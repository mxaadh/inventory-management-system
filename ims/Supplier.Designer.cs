namespace ims
{
    partial class Supplier
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            dataGridView1 = new DataGridView();
            catIDGV = new DataGridViewTextBoxColumn();
            catNameGV = new DataGridViewTextBoxColumn();
            catStatusGV = new DataGridViewTextBoxColumn();
            nameTxt = new TextBox();
            label3 = new Label();
            nameErrorLabel = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            label4 = new Label();
            textBox2 = new TextBox();
            label5 = new Label();
            textBox3 = new TextBox();
            label7 = new Label();
            label8 = new Label();
            textBox4 = new TextBox();
            label9 = new Label();
            label10 = new Label();
            textBox5 = new TextBox();
            label11 = new Label();
            label12 = new Label();
            statusDD = new ComboBox();
            label13 = new Label();
            statusErrorLabel = new Label();
            textBox6 = new TextBox();
            label14 = new Label();
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
            searchBox.Size = new Size(84, 23);
            // 
            // formsHeadingLabel
            // 
            formsHeadingLabel.Size = new Size(113, 21);
            formsHeadingLabel.Text = "Supplier Form";
            // 
            // leftPanel
            // 
            leftPanel.Controls.Add(textBox6);
            leftPanel.Controls.Add(label14);
            leftPanel.Controls.Add(statusDD);
            leftPanel.Controls.Add(label13);
            leftPanel.Controls.Add(statusErrorLabel);
            leftPanel.Controls.Add(textBox4);
            leftPanel.Controls.Add(label9);
            leftPanel.Controls.Add(label10);
            leftPanel.Controls.Add(textBox5);
            leftPanel.Controls.Add(label11);
            leftPanel.Controls.Add(label12);
            leftPanel.Controls.Add(textBox2);
            leftPanel.Controls.Add(label5);
            leftPanel.Controls.Add(textBox3);
            leftPanel.Controls.Add(label7);
            leftPanel.Controls.Add(label8);
            leftPanel.Controls.Add(textBox1);
            leftPanel.Controls.Add(label2);
            leftPanel.Controls.Add(label4);
            leftPanel.Controls.Add(nameTxt);
            leftPanel.Controls.Add(label3);
            leftPanel.Controls.Add(nameErrorLabel);
            leftPanel.Size = new Size(229, 507);
            leftPanel.Controls.SetChildIndex(panel1, 0);
            leftPanel.Controls.SetChildIndex(actionLeftPanel, 0);
            leftPanel.Controls.SetChildIndex(nameErrorLabel, 0);
            leftPanel.Controls.SetChildIndex(label3, 0);
            leftPanel.Controls.SetChildIndex(nameTxt, 0);
            leftPanel.Controls.SetChildIndex(label4, 0);
            leftPanel.Controls.SetChildIndex(label2, 0);
            leftPanel.Controls.SetChildIndex(textBox1, 0);
            leftPanel.Controls.SetChildIndex(label8, 0);
            leftPanel.Controls.SetChildIndex(label7, 0);
            leftPanel.Controls.SetChildIndex(textBox3, 0);
            leftPanel.Controls.SetChildIndex(label5, 0);
            leftPanel.Controls.SetChildIndex(textBox2, 0);
            leftPanel.Controls.SetChildIndex(label12, 0);
            leftPanel.Controls.SetChildIndex(label11, 0);
            leftPanel.Controls.SetChildIndex(textBox5, 0);
            leftPanel.Controls.SetChildIndex(label10, 0);
            leftPanel.Controls.SetChildIndex(label9, 0);
            leftPanel.Controls.SetChildIndex(textBox4, 0);
            leftPanel.Controls.SetChildIndex(statusErrorLabel, 0);
            leftPanel.Controls.SetChildIndex(label13, 0);
            leftPanel.Controls.SetChildIndex(statusDD, 0);
            leftPanel.Controls.SetChildIndex(label14, 0);
            leftPanel.Controls.SetChildIndex(textBox6, 0);
            // 
            // rightPanel
            // 
            rightPanel.Controls.Add(dataGridView1);
            rightPanel.Size = new Size(571, 507);
            rightPanel.Controls.SetChildIndex(dataGridView1, 0);
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { catIDGV, catNameGV, catStatusGV });
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 100);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(571, 407);
            dataGridView1.TabIndex = 3;
            // 
            // catIDGV
            // 
            catIDGV.HeaderText = "Category ID";
            catIDGV.MinimumWidth = 6;
            catIDGV.Name = "catIDGV";
            catIDGV.ReadOnly = true;
            catIDGV.Visible = false;
            // 
            // catNameGV
            // 
            catNameGV.HeaderText = "Name";
            catNameGV.MinimumWidth = 6;
            catNameGV.Name = "catNameGV";
            catNameGV.ReadOnly = true;
            // 
            // catStatusGV
            // 
            catStatusGV.HeaderText = "Status";
            catStatusGV.MinimumWidth = 6;
            catStatusGV.Name = "catStatusGV";
            catStatusGV.ReadOnly = true;
            // 
            // nameTxt
            // 
            nameTxt.Location = new Point(12, 129);
            nameTxt.Margin = new Padding(3, 2, 3, 2);
            nameTxt.Name = "nameTxt";
            nameTxt.Size = new Size(206, 23);
            nameTxt.TabIndex = 18;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 110);
            label3.Name = "label3";
            label3.Size = new Size(102, 15);
            label3.TabIndex = 17;
            label3.Text = "Name / Company";
            // 
            // nameErrorLabel
            // 
            nameErrorLabel.AutoSize = true;
            nameErrorLabel.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nameErrorLabel.ForeColor = Color.LightCoral;
            nameErrorLabel.Location = new Point(115, 106);
            nameErrorLabel.Name = "nameErrorLabel";
            nameErrorLabel.Size = new Size(22, 30);
            nameErrorLabel.TabIndex = 19;
            nameErrorLabel.Text = "*";
            nameErrorLabel.Visible = false;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 177);
            textBox1.Margin = new Padding(3, 2, 3, 2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(206, 23);
            textBox1.TabIndex = 21;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 158);
            label2.Name = "label2";
            label2.Size = new Size(88, 15);
            label2.TabIndex = 20;
            label2.Text = "Contect Person";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.LightCoral;
            label4.Location = new Point(98, 154);
            label4.Name = "label4";
            label4.Size = new Size(22, 30);
            label4.TabIndex = 22;
            label4.Text = "*";
            label4.Visible = false;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(11, 273);
            textBox2.Margin = new Padding(3, 2, 3, 2);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(206, 23);
            textBox2.TabIndex = 27;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(11, 254);
            label5.Name = "label5";
            label5.Size = new Size(50, 15);
            label5.TabIndex = 26;
            label5.Text = "Phone 2";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(11, 225);
            textBox3.Margin = new Padding(3, 2, 3, 2);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(206, 23);
            textBox3.TabIndex = 24;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(11, 206);
            label7.Name = "label7";
            label7.Size = new Size(50, 15);
            label7.TabIndex = 23;
            label7.Text = "Phone 1";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.LightCoral;
            label8.Location = new Point(59, 202);
            label8.Name = "label8";
            label8.Size = new Size(22, 30);
            label8.TabIndex = 25;
            label8.Text = "*";
            label8.Visible = false;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(11, 369);
            textBox4.Margin = new Padding(3, 2, 3, 2);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(206, 23);
            textBox4.TabIndex = 33;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(11, 350);
            label9.Name = "label9";
            label9.Size = new Size(49, 15);
            label9.TabIndex = 32;
            label9.Text = "Address";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.LightCoral;
            label10.Location = new Point(58, 346);
            label10.Name = "label10";
            label10.Size = new Size(22, 30);
            label10.TabIndex = 34;
            label10.Text = "*";
            label10.Visible = false;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(11, 321);
            textBox5.Margin = new Padding(3, 2, 3, 2);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(206, 23);
            textBox5.TabIndex = 30;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(11, 302);
            label11.Name = "label11";
            label11.Size = new Size(39, 15);
            label11.TabIndex = 29;
            label11.Text = "Name";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label12.ForeColor = Color.LightCoral;
            label12.Location = new Point(48, 298);
            label12.Name = "label12";
            label12.Size = new Size(22, 30);
            label12.TabIndex = 31;
            label12.Text = "*";
            label12.Visible = false;
            // 
            // statusDD
            // 
            statusDD.DropDownStyle = ComboBoxStyle.DropDownList;
            statusDD.FormattingEnabled = true;
            statusDD.Items.AddRange(new object[] { "Active", "In-active" });
            statusDD.Location = new Point(10, 464);
            statusDD.Margin = new Padding(3, 2, 3, 2);
            statusDD.Name = "statusDD";
            statusDD.Size = new Size(207, 23);
            statusDD.TabIndex = 37;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(10, 447);
            label13.Name = "label13";
            label13.Size = new Size(39, 15);
            label13.TabIndex = 35;
            label13.Text = "Status";
            // 
            // statusErrorLabel
            // 
            statusErrorLabel.AutoSize = true;
            statusErrorLabel.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            statusErrorLabel.ForeColor = Color.LightCoral;
            statusErrorLabel.Location = new Point(48, 442);
            statusErrorLabel.Name = "statusErrorLabel";
            statusErrorLabel.Size = new Size(22, 30);
            statusErrorLabel.TabIndex = 36;
            statusErrorLabel.Text = "*";
            statusErrorLabel.Visible = false;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(11, 417);
            textBox6.Margin = new Padding(3, 2, 3, 2);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(206, 23);
            textBox6.TabIndex = 39;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(11, 398);
            label14.Name = "label14";
            label14.Size = new Size(31, 15);
            label14.TabIndex = 38;
            label14.Text = "NTN";
            // 
            // Supplier
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 507);
            Name = "Supplier";
            Text = "Supplier";
            Load += Supplier_Load;
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

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn catIDGV;
        private DataGridViewTextBoxColumn catNameGV;
        private DataGridViewTextBoxColumn catStatusGV;
        private TextBox nameTxt;
        private Label label3;
        private Label nameErrorLabel;
        private TextBox textBox4;
        private Label label9;
        private Label label10;
        private TextBox textBox5;
        private Label label11;
        private Label label12;
        private TextBox textBox2;
        private Label label5;
        private TextBox textBox3;
        private Label label7;
        private Label label8;
        private TextBox textBox1;
        private Label label2;
        private Label label4;
        private ComboBox statusDD;
        private Label label13;
        private Label statusErrorLabel;
        private TextBox textBox6;
        private Label label14;
    }
}