namespace ims
{
    partial class Invoice
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
            ntnTxt = new TextBox();
            label14 = new Label();
            label13 = new Label();
            statusErrorLabel = new Label();
            addressTxt = new TextBox();
            label9 = new Label();
            addressErrorLabel = new Label();
            supplierDD = new ComboBox();
            label10 = new Label();
            categoryErrorLabel = new Label();
            productDD = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            textBox1 = new TextBox();
            label4 = new Label();
            label5 = new Label();
            loginButton = new Button();
            actionLeftPanel.SuspendLayout();
            leftPanel.SuspendLayout();
            panel1.SuspendLayout();
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
            formsHeadingLabel.Size = new Size(105, 21);
            formsHeadingLabel.Text = "Invoice Form";
            // 
            // leftPanel
            // 
            leftPanel.Controls.Add(loginButton);
            leftPanel.Controls.Add(label5);
            leftPanel.Controls.Add(label4);
            leftPanel.Controls.Add(textBox1);
            leftPanel.Controls.Add(productDD);
            leftPanel.Controls.Add(label2);
            leftPanel.Controls.Add(label3);
            leftPanel.Controls.Add(ntnTxt);
            leftPanel.Controls.Add(label14);
            leftPanel.Controls.Add(label13);
            leftPanel.Controls.Add(statusErrorLabel);
            leftPanel.Controls.Add(addressTxt);
            leftPanel.Controls.Add(label9);
            leftPanel.Controls.Add(addressErrorLabel);
            leftPanel.Controls.Add(supplierDD);
            leftPanel.Controls.Add(label10);
            leftPanel.Controls.Add(categoryErrorLabel);
            leftPanel.Controls.SetChildIndex(categoryErrorLabel, 0);
            leftPanel.Controls.SetChildIndex(label10, 0);
            leftPanel.Controls.SetChildIndex(supplierDD, 0);
            leftPanel.Controls.SetChildIndex(addressErrorLabel, 0);
            leftPanel.Controls.SetChildIndex(label9, 0);
            leftPanel.Controls.SetChildIndex(addressTxt, 0);
            leftPanel.Controls.SetChildIndex(statusErrorLabel, 0);
            leftPanel.Controls.SetChildIndex(label13, 0);
            leftPanel.Controls.SetChildIndex(label14, 0);
            leftPanel.Controls.SetChildIndex(ntnTxt, 0);
            leftPanel.Controls.SetChildIndex(panel1, 0);
            leftPanel.Controls.SetChildIndex(actionLeftPanel, 0);
            leftPanel.Controls.SetChildIndex(label3, 0);
            leftPanel.Controls.SetChildIndex(label2, 0);
            leftPanel.Controls.SetChildIndex(productDD, 0);
            leftPanel.Controls.SetChildIndex(textBox1, 0);
            leftPanel.Controls.SetChildIndex(label4, 0);
            leftPanel.Controls.SetChildIndex(label5, 0);
            leftPanel.Controls.SetChildIndex(loginButton, 0);
            // 
            // ntnTxt
            // 
            ntnTxt.Location = new Point(12, 268);
            ntnTxt.Margin = new Padding(3, 2, 3, 2);
            ntnTxt.Name = "ntnTxt";
            ntnTxt.Size = new Size(206, 23);
            ntnTxt.TabIndex = 47;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(12, 249);
            label14.Name = "label14";
            label14.Size = new Size(78, 15);
            label14.TabIndex = 46;
            label14.Text = "Per Unit Price";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(11, 298);
            label13.Name = "label13";
            label13.Size = new Size(53, 15);
            label13.TabIndex = 43;
            label13.Text = "Quantity";
            // 
            // statusErrorLabel
            // 
            statusErrorLabel.AutoSize = true;
            statusErrorLabel.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            statusErrorLabel.ForeColor = Color.LightCoral;
            statusErrorLabel.Location = new Point(63, 293);
            statusErrorLabel.Name = "statusErrorLabel";
            statusErrorLabel.Size = new Size(22, 30);
            statusErrorLabel.TabIndex = 44;
            statusErrorLabel.Text = "*";
            statusErrorLabel.Visible = false;
            // 
            // addressTxt
            // 
            addressTxt.Location = new Point(12, 220);
            addressTxt.Margin = new Padding(3, 2, 3, 2);
            addressTxt.Name = "addressTxt";
            addressTxt.Size = new Size(206, 23);
            addressTxt.TabIndex = 41;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(12, 201);
            label9.Name = "label9";
            label9.Size = new Size(50, 15);
            label9.TabIndex = 40;
            label9.Text = "Barcode";
            // 
            // addressErrorLabel
            // 
            addressErrorLabel.AutoSize = true;
            addressErrorLabel.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            addressErrorLabel.ForeColor = Color.LightCoral;
            addressErrorLabel.Location = new Point(59, 197);
            addressErrorLabel.Name = "addressErrorLabel";
            addressErrorLabel.Size = new Size(22, 30);
            addressErrorLabel.TabIndex = 42;
            addressErrorLabel.Text = "*";
            addressErrorLabel.Visible = false;
            // 
            // supplierDD
            // 
            supplierDD.DropDownStyle = ComboBoxStyle.DropDownList;
            supplierDD.FormattingEnabled = true;
            supplierDD.Location = new Point(12, 124);
            supplierDD.Margin = new Padding(3, 2, 3, 2);
            supplierDD.Name = "supplierDD";
            supplierDD.Size = new Size(205, 23);
            supplierDD.TabIndex = 49;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(11, 106);
            label10.Name = "label10";
            label10.Size = new Size(50, 15);
            label10.TabIndex = 48;
            label10.Text = "Supplier";
            // 
            // categoryErrorLabel
            // 
            categoryErrorLabel.AutoSize = true;
            categoryErrorLabel.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            categoryErrorLabel.ForeColor = Color.LightCoral;
            categoryErrorLabel.Location = new Point(62, 102);
            categoryErrorLabel.Name = "categoryErrorLabel";
            categoryErrorLabel.Size = new Size(22, 30);
            categoryErrorLabel.TabIndex = 50;
            categoryErrorLabel.Text = "*";
            categoryErrorLabel.Visible = false;
            // 
            // productDD
            // 
            productDD.DropDownStyle = ComboBoxStyle.DropDownList;
            productDD.FormattingEnabled = true;
            productDD.Location = new Point(12, 172);
            productDD.Margin = new Padding(3, 2, 3, 2);
            productDD.Name = "productDD";
            productDD.Size = new Size(205, 23);
            productDD.TabIndex = 52;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(11, 154);
            label2.Name = "label2";
            label2.Size = new Size(49, 15);
            label2.TabIndex = 51;
            label2.Text = "Product";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.LightCoral;
            label3.Location = new Point(59, 150);
            label3.Name = "label3";
            label3.Size = new Size(22, 30);
            label3.TabIndex = 53;
            label3.Text = "*";
            label3.Visible = false;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 316);
            textBox1.Margin = new Padding(3, 2, 3, 2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(206, 23);
            textBox1.TabIndex = 54;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 346);
            label4.Name = "label4";
            label4.Size = new Size(79, 15);
            label4.TabIndex = 55;
            label4.Text = "Total Amount";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(12, 361);
            label5.Name = "label5";
            label5.Size = new Size(50, 25);
            label5.TabIndex = 56;
            label5.Text = "0.00";
            // 
            // loginButton
            // 
            loginButton.FlatAppearance.BorderSize = 2;
            loginButton.FlatStyle = FlatStyle.Flat;
            loginButton.Location = new Point(13, 400);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(204, 30);
            loginButton.TabIndex = 57;
            loginButton.Text = "Add to Cart";
            loginButton.UseVisualStyleBackColor = true;
            // 
            // Invoice
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Name = "Invoice";
            Text = "Invoice";
            Load += Invoice_Load;
            actionLeftPanel.ResumeLayout(false);
            actionLeftPanel.PerformLayout();
            leftPanel.ResumeLayout(false);
            leftPanel.PerformLayout();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TextBox ntnTxt;
        private Label label14;
        private Label label13;
        private Label statusErrorLabel;
        private TextBox addressTxt;
        private Label label9;
        private Label addressErrorLabel;
        private ComboBox supplierDD;
        private Label label10;
        private Label categoryErrorLabel;
        private ComboBox productDD;
        private Label label2;
        private Label label3;
        private Label label5;
        private Label label4;
        private TextBox textBox1;
        private Button loginButton;
    }
}