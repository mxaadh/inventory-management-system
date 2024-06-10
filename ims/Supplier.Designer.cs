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
            supIDGV = new DataGridViewTextBoxColumn();
            supNameGV = new DataGridViewTextBoxColumn();
            supContectPersonGV = new DataGridViewTextBoxColumn();
            supPhone1GV = new DataGridViewTextBoxColumn();
            supPhone2GV = new DataGridViewTextBoxColumn();
            supAddressGV = new DataGridViewTextBoxColumn();
            supNTNGV = new DataGridViewTextBoxColumn();
            supStatusGV = new DataGridViewTextBoxColumn();
            nameTxt = new TextBox();
            label3 = new Label();
            nameErrorLabel = new Label();
            contectPersonTxt = new TextBox();
            label2 = new Label();
            contectPersonErrorLabel = new Label();
            phone2Txt = new TextBox();
            label5 = new Label();
            phone1Txt = new TextBox();
            label7 = new Label();
            phone1ErrorLabel = new Label();
            addressTxt = new TextBox();
            label9 = new Label();
            addressErrorLabel = new Label();
            statusDD = new ComboBox();
            label13 = new Label();
            statusErrorLabel = new Label();
            ntnTxt = new TextBox();
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
            leftPanel.Controls.Add(ntnTxt);
            leftPanel.Controls.Add(label14);
            leftPanel.Controls.Add(statusDD);
            leftPanel.Controls.Add(label13);
            leftPanel.Controls.Add(statusErrorLabel);
            leftPanel.Controls.Add(addressTxt);
            leftPanel.Controls.Add(label9);
            leftPanel.Controls.Add(addressErrorLabel);
            leftPanel.Controls.Add(phone2Txt);
            leftPanel.Controls.Add(label5);
            leftPanel.Controls.Add(phone1Txt);
            leftPanel.Controls.Add(label7);
            leftPanel.Controls.Add(phone1ErrorLabel);
            leftPanel.Controls.Add(contectPersonTxt);
            leftPanel.Controls.Add(label2);
            leftPanel.Controls.Add(contectPersonErrorLabel);
            leftPanel.Controls.Add(nameTxt);
            leftPanel.Controls.Add(label3);
            leftPanel.Controls.Add(nameErrorLabel);
            leftPanel.Size = new Size(229, 507);
            leftPanel.Controls.SetChildIndex(panel1, 0);
            leftPanel.Controls.SetChildIndex(actionLeftPanel, 0);
            leftPanel.Controls.SetChildIndex(nameErrorLabel, 0);
            leftPanel.Controls.SetChildIndex(label3, 0);
            leftPanel.Controls.SetChildIndex(nameTxt, 0);
            leftPanel.Controls.SetChildIndex(contectPersonErrorLabel, 0);
            leftPanel.Controls.SetChildIndex(label2, 0);
            leftPanel.Controls.SetChildIndex(contectPersonTxt, 0);
            leftPanel.Controls.SetChildIndex(phone1ErrorLabel, 0);
            leftPanel.Controls.SetChildIndex(label7, 0);
            leftPanel.Controls.SetChildIndex(phone1Txt, 0);
            leftPanel.Controls.SetChildIndex(label5, 0);
            leftPanel.Controls.SetChildIndex(phone2Txt, 0);
            leftPanel.Controls.SetChildIndex(addressErrorLabel, 0);
            leftPanel.Controls.SetChildIndex(label9, 0);
            leftPanel.Controls.SetChildIndex(addressTxt, 0);
            leftPanel.Controls.SetChildIndex(statusErrorLabel, 0);
            leftPanel.Controls.SetChildIndex(label13, 0);
            leftPanel.Controls.SetChildIndex(statusDD, 0);
            leftPanel.Controls.SetChildIndex(label14, 0);
            leftPanel.Controls.SetChildIndex(ntnTxt, 0);
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
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { supIDGV, supNameGV, supContectPersonGV, supPhone1GV, supPhone2GV, supAddressGV, supNTNGV, supStatusGV });
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
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // supIDGV
            // 
            supIDGV.HeaderText = "Supplier ID";
            supIDGV.MinimumWidth = 6;
            supIDGV.Name = "supIDGV";
            supIDGV.ReadOnly = true;
            supIDGV.Visible = false;
            // 
            // supNameGV
            // 
            supNameGV.HeaderText = "Name / Company";
            supNameGV.MinimumWidth = 6;
            supNameGV.Name = "supNameGV";
            supNameGV.ReadOnly = true;
            // 
            // supContectPersonGV
            // 
            supContectPersonGV.HeaderText = "Contect Person";
            supContectPersonGV.Name = "supContectPersonGV";
            supContectPersonGV.ReadOnly = true;
            // 
            // supPhone1GV
            // 
            supPhone1GV.HeaderText = "Phone 1";
            supPhone1GV.Name = "supPhone1GV";
            supPhone1GV.ReadOnly = true;
            // 
            // supPhone2GV
            // 
            supPhone2GV.HeaderText = "Phone 2";
            supPhone2GV.Name = "supPhone2GV";
            supPhone2GV.ReadOnly = true;
            // 
            // supAddressGV
            // 
            supAddressGV.HeaderText = "Address";
            supAddressGV.Name = "supAddressGV";
            supAddressGV.ReadOnly = true;
            // 
            // supNTNGV
            // 
            supNTNGV.HeaderText = "NTN #";
            supNTNGV.Name = "supNTNGV";
            supNTNGV.ReadOnly = true;
            // 
            // supStatusGV
            // 
            supStatusGV.HeaderText = "Status";
            supStatusGV.MinimumWidth = 6;
            supStatusGV.Name = "supStatusGV";
            supStatusGV.ReadOnly = true;
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
            // contectPersonTxt
            // 
            contectPersonTxt.Location = new Point(12, 177);
            contectPersonTxt.Margin = new Padding(3, 2, 3, 2);
            contectPersonTxt.Name = "contectPersonTxt";
            contectPersonTxt.Size = new Size(206, 23);
            contectPersonTxt.TabIndex = 21;
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
            // contectPersonErrorLabel
            // 
            contectPersonErrorLabel.AutoSize = true;
            contectPersonErrorLabel.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            contectPersonErrorLabel.ForeColor = Color.LightCoral;
            contectPersonErrorLabel.Location = new Point(98, 154);
            contectPersonErrorLabel.Name = "contectPersonErrorLabel";
            contectPersonErrorLabel.Size = new Size(22, 30);
            contectPersonErrorLabel.TabIndex = 22;
            contectPersonErrorLabel.Text = "*";
            contectPersonErrorLabel.Visible = false;
            // 
            // phone2Txt
            // 
            phone2Txt.Location = new Point(11, 273);
            phone2Txt.Margin = new Padding(3, 2, 3, 2);
            phone2Txt.Name = "phone2Txt";
            phone2Txt.Size = new Size(206, 23);
            phone2Txt.TabIndex = 27;
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
            // phone1Txt
            // 
            phone1Txt.Location = new Point(11, 225);
            phone1Txt.Margin = new Padding(3, 2, 3, 2);
            phone1Txt.Name = "phone1Txt";
            phone1Txt.Size = new Size(206, 23);
            phone1Txt.TabIndex = 24;
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
            // phone1ErrorLabel
            // 
            phone1ErrorLabel.AutoSize = true;
            phone1ErrorLabel.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            phone1ErrorLabel.ForeColor = Color.LightCoral;
            phone1ErrorLabel.Location = new Point(59, 202);
            phone1ErrorLabel.Name = "phone1ErrorLabel";
            phone1ErrorLabel.Size = new Size(22, 30);
            phone1ErrorLabel.TabIndex = 25;
            phone1ErrorLabel.Text = "*";
            phone1ErrorLabel.Visible = false;
            // 
            // addressTxt
            // 
            addressTxt.Location = new Point(11, 321);
            addressTxt.Margin = new Padding(3, 2, 3, 2);
            addressTxt.Name = "addressTxt";
            addressTxt.Size = new Size(206, 23);
            addressTxt.TabIndex = 33;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(11, 302);
            label9.Name = "label9";
            label9.Size = new Size(49, 15);
            label9.TabIndex = 32;
            label9.Text = "Address";
            // 
            // addressErrorLabel
            // 
            addressErrorLabel.AutoSize = true;
            addressErrorLabel.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            addressErrorLabel.ForeColor = Color.LightCoral;
            addressErrorLabel.Location = new Point(58, 298);
            addressErrorLabel.Name = "addressErrorLabel";
            addressErrorLabel.Size = new Size(22, 30);
            addressErrorLabel.TabIndex = 34;
            addressErrorLabel.Text = "*";
            addressErrorLabel.Visible = false;
            // 
            // statusDD
            // 
            statusDD.DropDownStyle = ComboBoxStyle.DropDownList;
            statusDD.FormattingEnabled = true;
            statusDD.Items.AddRange(new object[] { "Active", "In-active" });
            statusDD.Location = new Point(10, 416);
            statusDD.Margin = new Padding(3, 2, 3, 2);
            statusDD.Name = "statusDD";
            statusDD.Size = new Size(207, 23);
            statusDD.TabIndex = 37;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(10, 399);
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
            statusErrorLabel.Location = new Point(48, 394);
            statusErrorLabel.Name = "statusErrorLabel";
            statusErrorLabel.Size = new Size(22, 30);
            statusErrorLabel.TabIndex = 36;
            statusErrorLabel.Text = "*";
            statusErrorLabel.Visible = false;
            // 
            // ntnTxt
            // 
            ntnTxt.Location = new Point(11, 369);
            ntnTxt.Margin = new Padding(3, 2, 3, 2);
            ntnTxt.Name = "ntnTxt";
            ntnTxt.Size = new Size(206, 23);
            ntnTxt.TabIndex = 39;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(11, 350);
            label14.Name = "label14";
            label14.Size = new Size(41, 15);
            label14.TabIndex = 38;
            label14.Text = "NTN #";
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
        private TextBox nameTxt;
        private Label label3;
        private Label nameErrorLabel;
        private TextBox addressTxt;
        private Label label9;
        private Label addressErrorLabel;
        private TextBox phone2Txt;
        private Label label5;
        private TextBox phone1Txt;
        private Label label7;
        private Label phone1ErrorLabel;
        private TextBox contectPersonTxt;
        private Label label2;
        private Label contectPersonErrorLabel;
        private ComboBox statusDD;
        private Label label13;
        private Label statusErrorLabel;
        private TextBox ntnTxt;
        private Label label14;
        private DataGridViewTextBoxColumn supIDGV;
        private DataGridViewTextBoxColumn supNameGV;
        private DataGridViewTextBoxColumn supContectPersonGV;
        private DataGridViewTextBoxColumn supPhone1GV;
        private DataGridViewTextBoxColumn supPhone2GV;
        private DataGridViewTextBoxColumn supAddressGV;
        private DataGridViewTextBoxColumn supNTNGV;
        private DataGridViewTextBoxColumn supStatusGV;
    }
}