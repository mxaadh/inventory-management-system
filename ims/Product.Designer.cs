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
            actionLeftPanel.SuspendLayout();
            leftPanel.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)priceTxt).BeginInit();
            SuspendLayout();
            // 
            // backBtn
            // 
            backBtn.FlatAppearance.BorderSize = 0;
            backBtn.Click += backBtn_Click;
            // 
            // formsHeadingLabel
            // 
            formsHeadingLabel.Size = new Size(136, 28);
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
            // nameTxt
            // 
            nameTxt.Location = new Point(12, 168);
            nameTxt.Name = "nameTxt";
            nameTxt.Size = new Size(236, 27);
            nameTxt.TabIndex = 15;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(13, 145);
            label3.Name = "label3";
            label3.Size = new Size(49, 20);
            label3.TabIndex = 14;
            label3.Text = "Name";
            // 
            // nameErrorLabel
            // 
            nameErrorLabel.AutoSize = true;
            nameErrorLabel.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nameErrorLabel.ForeColor = Color.LightCoral;
            nameErrorLabel.Location = new Point(54, 138);
            nameErrorLabel.Name = "nameErrorLabel";
            nameErrorLabel.Size = new Size(29, 38);
            nameErrorLabel.TabIndex = 16;
            nameErrorLabel.Text = "*";
            nameErrorLabel.Visible = false;
            // 
            // barcodeTxt
            // 
            barcodeTxt.Location = new Point(12, 221);
            barcodeTxt.Name = "barcodeTxt";
            barcodeTxt.Size = new Size(236, 27);
            barcodeTxt.TabIndex = 18;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(13, 198);
            label4.Name = "label4";
            label4.Size = new Size(64, 20);
            label4.TabIndex = 17;
            label4.Text = "Barcode";
            // 
            // barcodeErrorLabel
            // 
            barcodeErrorLabel.AutoSize = true;
            barcodeErrorLabel.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            barcodeErrorLabel.ForeColor = Color.LightCoral;
            barcodeErrorLabel.Location = new Point(69, 191);
            barcodeErrorLabel.Name = "barcodeErrorLabel";
            barcodeErrorLabel.Size = new Size(29, 38);
            barcodeErrorLabel.TabIndex = 19;
            barcodeErrorLabel.Text = "*";
            barcodeErrorLabel.Visible = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(13, 251);
            label6.Name = "label6";
            label6.Size = new Size(85, 20);
            label6.TabIndex = 20;
            label6.Text = "Expiry Date";
            // 
            // expiryDateErrorLabel
            // 
            expiryDateErrorLabel.AutoSize = true;
            expiryDateErrorLabel.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            expiryDateErrorLabel.ForeColor = Color.LightCoral;
            expiryDateErrorLabel.Location = new Point(90, 244);
            expiryDateErrorLabel.Name = "expiryDateErrorLabel";
            expiryDateErrorLabel.Size = new Size(29, 38);
            expiryDateErrorLabel.TabIndex = 22;
            expiryDateErrorLabel.Text = "*";
            expiryDateErrorLabel.Visible = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(13, 304);
            label8.Name = "label8";
            label8.Size = new Size(41, 20);
            label8.TabIndex = 23;
            label8.Text = "Price";
            // 
            // priceErrorLabel
            // 
            priceErrorLabel.AutoSize = true;
            priceErrorLabel.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            priceErrorLabel.ForeColor = Color.LightCoral;
            priceErrorLabel.Location = new Point(46, 297);
            priceErrorLabel.Name = "priceErrorLabel";
            priceErrorLabel.Size = new Size(29, 38);
            priceErrorLabel.TabIndex = 25;
            priceErrorLabel.Text = "*";
            priceErrorLabel.Visible = false;
            // 
            // categoryDD
            // 
            categoryDD.DropDownStyle = ComboBoxStyle.DropDownList;
            categoryDD.FormattingEnabled = true;
            categoryDD.Location = new Point(14, 378);
            categoryDD.Name = "categoryDD";
            categoryDD.Size = new Size(234, 28);
            categoryDD.TabIndex = 27;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(13, 355);
            label10.Name = "label10";
            label10.Size = new Size(69, 20);
            label10.TabIndex = 26;
            label10.Text = "Category";
            // 
            // categoryErrorLabel
            // 
            categoryErrorLabel.AutoSize = true;
            categoryErrorLabel.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            categoryErrorLabel.ForeColor = Color.LightCoral;
            categoryErrorLabel.Location = new Point(75, 349);
            categoryErrorLabel.Name = "categoryErrorLabel";
            categoryErrorLabel.Size = new Size(29, 38);
            categoryErrorLabel.TabIndex = 28;
            categoryErrorLabel.Text = "*";
            categoryErrorLabel.Visible = false;
            // 
            // statusDD
            // 
            statusDD.DropDownStyle = ComboBoxStyle.DropDownList;
            statusDD.FormattingEnabled = true;
            statusDD.Items.AddRange(new object[] { "Active", "In-active" });
            statusDD.Location = new Point(14, 430);
            statusDD.Name = "statusDD";
            statusDD.Size = new Size(234, 28);
            statusDD.TabIndex = 30;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(13, 407);
            label11.Name = "label11";
            label11.Size = new Size(49, 20);
            label11.TabIndex = 29;
            label11.Text = "Status";
            // 
            // statusErrorLabel
            // 
            statusErrorLabel.AutoSize = true;
            statusErrorLabel.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            statusErrorLabel.ForeColor = Color.LightCoral;
            statusErrorLabel.Location = new Point(54, 401);
            statusErrorLabel.Name = "statusErrorLabel";
            statusErrorLabel.Size = new Size(29, 38);
            statusErrorLabel.TabIndex = 31;
            statusErrorLabel.Text = "*";
            statusErrorLabel.Visible = false;
            // 
            // expiryDateTxt
            // 
            expiryDateTxt.CustomFormat = "dd-MMM-yyyy";
            expiryDateTxt.Format = DateTimePickerFormat.Custom;
            expiryDateTxt.Location = new Point(12, 274);
            expiryDateTxt.MinDate = new DateTime(2024, 6, 6, 0, 0, 0, 0);
            expiryDateTxt.Name = "expiryDateTxt";
            expiryDateTxt.Size = new Size(236, 27);
            expiryDateTxt.TabIndex = 32;
            // 
            // priceTxt
            // 
            priceTxt.Location = new Point(12, 327);
            priceTxt.Name = "priceTxt";
            priceTxt.Size = new Size(236, 27);
            priceTxt.TabIndex = 33;
            // 
            // Product
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Name = "Product";
            Text = "Product";
            Load += Product_Load;
            actionLeftPanel.ResumeLayout(false);
            actionLeftPanel.PerformLayout();
            leftPanel.ResumeLayout(false);
            leftPanel.PerformLayout();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)priceTxt).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TextBox nameTxt;
        private Label label3;
        private Label nameErrorLabel;
        private Label label8;
        private Label priceErrorLabel;
        private TextBox textBox2;
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
    }
}