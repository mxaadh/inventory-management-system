namespace ims
{
    partial class Product
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
            nameTxt = new TextBox();
            label3 = new Label();
            nameErrorLabel = new Label();
            barcodeTxt = new TextBox();
            label4 = new Label();
            barcodeErrorLabel = new Label();
            label6 = new Label();
            expiryDateErrorLabel = new Label();
            label8 = new Label();
            priceErrorLabel = new Label();
            categoryDD = new ComboBox();
            label10 = new Label();
            categoryErrorLabel = new Label();
            statusDD = new ComboBox();
            label11 = new Label();
            statusErrorLabel = new Label();
            expiryDateTxt = new DateTimePicker();
            priceTxt = new NumericUpDown();
            dataGridView1 = new DataGridView();
            proIDGV = new DataGridViewTextBoxColumn();
            catIDGV = new DataGridViewTextBoxColumn();
            NameGV = new DataGridViewTextBoxColumn();
            BarcodeGV = new DataGridViewTextBoxColumn();
            ExpiryDateGV = new DataGridViewTextBoxColumn();
            PriceGV = new DataGridViewTextBoxColumn();
            CategoryGV = new DataGridViewTextBoxColumn();
            StatusGV = new DataGridViewTextBoxColumn();
            actionLeftPanel.SuspendLayout();
            leftPanel.SuspendLayout();
            rightPanel.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)priceTxt).BeginInit();
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
            // formsHeadingLabel
            // 
            formsHeadingLabel.Size = new Size(110, 21);
            formsHeadingLabel.Text = "Product Form";
            // 
            // leftPanel
            // 
            leftPanel.Controls.Add(priceTxt);
            leftPanel.Controls.Add(expiryDateTxt);
            leftPanel.Controls.Add(statusDD);
            leftPanel.Controls.Add(label11);
            leftPanel.Controls.Add(categoryDD);
            leftPanel.Controls.Add(label10);
            leftPanel.Controls.Add(label8);
            leftPanel.Controls.Add(label6);
            leftPanel.Controls.Add(barcodeTxt);
            leftPanel.Controls.Add(label4);
            leftPanel.Controls.Add(nameTxt);
            leftPanel.Controls.Add(label3);
            leftPanel.Controls.Add(statusErrorLabel);
            leftPanel.Controls.Add(categoryErrorLabel);
            leftPanel.Controls.Add(priceErrorLabel);
            leftPanel.Controls.Add(expiryDateErrorLabel);
            leftPanel.Controls.Add(barcodeErrorLabel);
            leftPanel.Controls.Add(nameErrorLabel);
            leftPanel.Controls.SetChildIndex(nameErrorLabel, 0);
            leftPanel.Controls.SetChildIndex(barcodeErrorLabel, 0);
            leftPanel.Controls.SetChildIndex(expiryDateErrorLabel, 0);
            leftPanel.Controls.SetChildIndex(priceErrorLabel, 0);
            leftPanel.Controls.SetChildIndex(categoryErrorLabel, 0);
            leftPanel.Controls.SetChildIndex(statusErrorLabel, 0);
            leftPanel.Controls.SetChildIndex(label3, 0);
            leftPanel.Controls.SetChildIndex(nameTxt, 0);
            leftPanel.Controls.SetChildIndex(panel1, 0);
            leftPanel.Controls.SetChildIndex(actionLeftPanel, 0);
            leftPanel.Controls.SetChildIndex(label4, 0);
            leftPanel.Controls.SetChildIndex(barcodeTxt, 0);
            leftPanel.Controls.SetChildIndex(label6, 0);
            leftPanel.Controls.SetChildIndex(label8, 0);
            leftPanel.Controls.SetChildIndex(label10, 0);
            leftPanel.Controls.SetChildIndex(categoryDD, 0);
            leftPanel.Controls.SetChildIndex(label11, 0);
            leftPanel.Controls.SetChildIndex(statusDD, 0);
            leftPanel.Controls.SetChildIndex(expiryDateTxt, 0);
            leftPanel.Controls.SetChildIndex(priceTxt, 0);
            // 
            // rightPanel
            // 
            rightPanel.Controls.Add(dataGridView1);
            rightPanel.Controls.SetChildIndex(dataGridView1, 0);
            // 
            // nameTxt
            // 
            nameTxt.Location = new Point(10, 126);
            nameTxt.Margin = new Padding(3, 2, 3, 2);
            nameTxt.Name = "nameTxt";
            nameTxt.Size = new Size(207, 23);
            nameTxt.TabIndex = 15;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(11, 109);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 14;
            label3.Text = "Name";
            // 
            // nameErrorLabel
            // 
            nameErrorLabel.AutoSize = true;
            nameErrorLabel.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nameErrorLabel.ForeColor = Color.LightCoral;
            nameErrorLabel.Location = new Point(47, 104);
            nameErrorLabel.Name = "nameErrorLabel";
            nameErrorLabel.Size = new Size(22, 30);
            nameErrorLabel.TabIndex = 16;
            nameErrorLabel.Text = "*";
            nameErrorLabel.Visible = false;
            // 
            // barcodeTxt
            // 
            barcodeTxt.Location = new Point(10, 169);
            barcodeTxt.Margin = new Padding(3, 2, 3, 2);
            barcodeTxt.Name = "barcodeTxt";
            barcodeTxt.Size = new Size(207, 23);
            barcodeTxt.TabIndex = 18;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(11, 151);
            label4.Name = "label4";
            label4.Size = new Size(50, 15);
            label4.TabIndex = 17;
            label4.Text = "Barcode";
            // 
            // barcodeErrorLabel
            // 
            barcodeErrorLabel.AutoSize = true;
            barcodeErrorLabel.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            barcodeErrorLabel.ForeColor = Color.LightCoral;
            barcodeErrorLabel.Location = new Point(60, 146);
            barcodeErrorLabel.Name = "barcodeErrorLabel";
            barcodeErrorLabel.Size = new Size(22, 30);
            barcodeErrorLabel.TabIndex = 19;
            barcodeErrorLabel.Text = "*";
            barcodeErrorLabel.Visible = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(11, 194);
            label6.Name = "label6";
            label6.Size = new Size(66, 15);
            label6.TabIndex = 20;
            label6.Text = "Expiry Date";
            // 
            // expiryDateErrorLabel
            // 
            expiryDateErrorLabel.AutoSize = true;
            expiryDateErrorLabel.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            expiryDateErrorLabel.ForeColor = Color.LightCoral;
            expiryDateErrorLabel.Location = new Point(79, 189);
            expiryDateErrorLabel.Name = "expiryDateErrorLabel";
            expiryDateErrorLabel.Size = new Size(22, 30);
            expiryDateErrorLabel.TabIndex = 22;
            expiryDateErrorLabel.Text = "*";
            expiryDateErrorLabel.Visible = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(11, 237);
            label8.Name = "label8";
            label8.Size = new Size(33, 15);
            label8.TabIndex = 23;
            label8.Text = "Price";
            // 
            // priceErrorLabel
            // 
            priceErrorLabel.AutoSize = true;
            priceErrorLabel.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            priceErrorLabel.ForeColor = Color.LightCoral;
            priceErrorLabel.Location = new Point(40, 232);
            priceErrorLabel.Name = "priceErrorLabel";
            priceErrorLabel.Size = new Size(22, 30);
            priceErrorLabel.TabIndex = 25;
            priceErrorLabel.Text = "*";
            priceErrorLabel.Visible = false;
            // 
            // categoryDD
            // 
            categoryDD.DropDownStyle = ComboBoxStyle.DropDownList;
            categoryDD.FormattingEnabled = true;
            categoryDD.Location = new Point(12, 296);
            categoryDD.Margin = new Padding(3, 2, 3, 2);
            categoryDD.Name = "categoryDD";
            categoryDD.Size = new Size(205, 23);
            categoryDD.TabIndex = 27;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(11, 278);
            label10.Name = "label10";
            label10.Size = new Size(55, 15);
            label10.TabIndex = 26;
            label10.Text = "Category";
            // 
            // categoryErrorLabel
            // 
            categoryErrorLabel.AutoSize = true;
            categoryErrorLabel.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            categoryErrorLabel.ForeColor = Color.LightCoral;
            categoryErrorLabel.Location = new Point(66, 274);
            categoryErrorLabel.Name = "categoryErrorLabel";
            categoryErrorLabel.Size = new Size(22, 30);
            categoryErrorLabel.TabIndex = 28;
            categoryErrorLabel.Text = "*";
            categoryErrorLabel.Visible = false;
            // 
            // statusDD
            // 
            statusDD.DropDownStyle = ComboBoxStyle.DropDownList;
            statusDD.FormattingEnabled = true;
            statusDD.Items.AddRange(new object[] { "Active", "In-active" });
            statusDD.Location = new Point(12, 337);
            statusDD.Margin = new Padding(3, 2, 3, 2);
            statusDD.Name = "statusDD";
            statusDD.Size = new Size(205, 23);
            statusDD.TabIndex = 30;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(11, 320);
            label11.Name = "label11";
            label11.Size = new Size(39, 15);
            label11.TabIndex = 29;
            label11.Text = "Status";
            // 
            // statusErrorLabel
            // 
            statusErrorLabel.AutoSize = true;
            statusErrorLabel.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            statusErrorLabel.ForeColor = Color.LightCoral;
            statusErrorLabel.Location = new Point(47, 316);
            statusErrorLabel.Name = "statusErrorLabel";
            statusErrorLabel.Size = new Size(22, 30);
            statusErrorLabel.TabIndex = 31;
            statusErrorLabel.Text = "*";
            statusErrorLabel.Visible = false;
            // 
            // expiryDateTxt
            // 
            expiryDateTxt.CustomFormat = "dd-MMM-yyyy";
            expiryDateTxt.Format = DateTimePickerFormat.Custom;
            expiryDateTxt.Location = new Point(10, 212);
            expiryDateTxt.Margin = new Padding(3, 2, 3, 2);
            expiryDateTxt.MinDate = new DateTime(2024, 6, 6, 0, 0, 0, 0);
            expiryDateTxt.Name = "expiryDateTxt";
            expiryDateTxt.Size = new Size(207, 23);
            expiryDateTxt.TabIndex = 32;
            // 
            // priceTxt
            // 
            priceTxt.Location = new Point(10, 254);
            priceTxt.Margin = new Padding(3, 2, 3, 2);
            priceTxt.Name = "priceTxt";
            priceTxt.Size = new Size(206, 23);
            priceTxt.TabIndex = 33;
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
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { proIDGV, catIDGV, NameGV, BarcodeGV, ExpiryDateGV, PriceGV, CategoryGV, StatusGV });
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
            // proIDGV
            // 
            proIDGV.HeaderText = "Product ID";
            proIDGV.MinimumWidth = 6;
            proIDGV.Name = "proIDGV";
            proIDGV.ReadOnly = true;
            proIDGV.Visible = false;
            // 
            // catIDGV
            // 
            catIDGV.HeaderText = "Category ID";
            catIDGV.Name = "catIDGV";
            catIDGV.ReadOnly = true;
            catIDGV.Visible = false;
            // 
            // NameGV
            // 
            NameGV.HeaderText = "Name";
            NameGV.MinimumWidth = 6;
            NameGV.Name = "NameGV";
            NameGV.ReadOnly = true;
            // 
            // BarcodeGV
            // 
            BarcodeGV.HeaderText = "Barcode";
            BarcodeGV.MinimumWidth = 6;
            BarcodeGV.Name = "BarcodeGV";
            BarcodeGV.ReadOnly = true;
            // 
            // ExpiryDateGV
            // 
            ExpiryDateGV.HeaderText = "Expiry Date";
            ExpiryDateGV.MinimumWidth = 6;
            ExpiryDateGV.Name = "ExpiryDateGV";
            ExpiryDateGV.ReadOnly = true;
            // 
            // PriceGV
            // 
            PriceGV.HeaderText = "Price";
            PriceGV.MinimumWidth = 6;
            PriceGV.Name = "PriceGV";
            PriceGV.ReadOnly = true;
            // 
            // CategoryGV
            // 
            CategoryGV.HeaderText = "Category";
            CategoryGV.MinimumWidth = 6;
            CategoryGV.Name = "CategoryGV";
            CategoryGV.ReadOnly = true;
            // 
            // StatusGV
            // 
            StatusGV.HeaderText = "Status";
            StatusGV.MinimumWidth = 6;
            StatusGV.Name = "StatusGV";
            StatusGV.ReadOnly = true;
            // 
            // Product
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Margin = new Padding(3);
            Name = "Product";
            Text = "Product";
            Load += Product_Load;
            actionLeftPanel.ResumeLayout(false);
            actionLeftPanel.PerformLayout();
            leftPanel.ResumeLayout(false);
            leftPanel.PerformLayout();
            rightPanel.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)priceTxt).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TextBox nameTxt;
        private Label label3;
        private Label nameErrorLabel;
        private Label label8;
        private Label priceErrorLabel;
        private Label label6;
        private Label expiryDateErrorLabel;
        private TextBox barcodeTxt;
        private Label label4;
        private Label barcodeErrorLabel;
        private ComboBox statusDD;
        private Label label11;
        private ComboBox categoryDD;
        private Label label10;
        private Label statusErrorLabel;
        private Label categoryErrorLabel;
        private DateTimePicker expiryDateTxt;
        private NumericUpDown priceTxt;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn proIDGV;
        private DataGridViewTextBoxColumn catIDGV;
        private DataGridViewTextBoxColumn NameGV;
        private DataGridViewTextBoxColumn BarcodeGV;
        private DataGridViewTextBoxColumn ExpiryDateGV;
        private DataGridViewTextBoxColumn PriceGV;
        private DataGridViewTextBoxColumn CategoryGV;
        private DataGridViewTextBoxColumn StatusGV;
    }
}