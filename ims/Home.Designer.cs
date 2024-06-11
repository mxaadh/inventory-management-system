namespace ims
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            tableLayoutPanel1 = new TableLayoutPanel();
            invoiceButton = new Button();
            stockButton = new Button();
            productButton = new Button();
            userButton = new Button();
            salesButton = new Button();
            categoryButton = new Button();
            supplierButton = new Button();
            leftPanel.SuspendLayout();
            rightPanel.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // leftPanel
            // 
            leftPanel.Margin = new Padding(3, 5, 3, 5);
            // 
            // rightPanel
            // 
            rightPanel.Controls.Add(tableLayoutPanel1);
            rightPanel.Margin = new Padding(3, 5, 3, 5);
            rightPanel.Size = new Size(571, 450);
            rightPanel.Controls.SetChildIndex(tableLayoutPanel1, 0);
            // 
            // panel1
            // 
            panel1.Margin = new Padding(3, 5, 3, 5);
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.Controls.Add(invoiceButton, 3, 0);
            tableLayoutPanel1.Controls.Add(stockButton, 2, 0);
            tableLayoutPanel1.Controls.Add(productButton, 1, 0);
            tableLayoutPanel1.Controls.Add(userButton, 0, 0);
            tableLayoutPanel1.Controls.Add(salesButton, 0, 1);
            tableLayoutPanel1.Controls.Add(categoryButton, 1, 1);
            tableLayoutPanel1.Controls.Add(supplierButton, 2, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 50);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.Size = new Size(571, 400);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // invoiceButton
            // 
            invoiceButton.BackColor = SystemColors.MenuHighlight;
            invoiceButton.Dock = DockStyle.Fill;
            invoiceButton.FlatAppearance.BorderColor = SystemColors.Highlight;
            invoiceButton.FlatAppearance.BorderSize = 4;
            invoiceButton.FlatStyle = FlatStyle.Flat;
            invoiceButton.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            invoiceButton.Image = Properties.Resources.invoice;
            invoiceButton.Location = new Point(429, 3);
            invoiceButton.Name = "invoiceButton";
            invoiceButton.Size = new Size(139, 74);
            invoiceButton.TabIndex = 3;
            invoiceButton.Text = "Invoice";
            invoiceButton.TextImageRelation = TextImageRelation.TextBeforeImage;
            invoiceButton.UseVisualStyleBackColor = false;
            invoiceButton.Click += invoiceButton_Click;
            // 
            // stockButton
            // 
            stockButton.BackColor = SystemColors.MenuHighlight;
            stockButton.Dock = DockStyle.Fill;
            stockButton.FlatAppearance.BorderColor = SystemColors.Highlight;
            stockButton.FlatAppearance.BorderSize = 4;
            stockButton.FlatStyle = FlatStyle.Flat;
            stockButton.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            stockButton.Image = Properties.Resources.stock;
            stockButton.Location = new Point(287, 3);
            stockButton.Name = "stockButton";
            stockButton.Size = new Size(136, 74);
            stockButton.TabIndex = 2;
            stockButton.Text = "Stock";
            stockButton.TextImageRelation = TextImageRelation.TextBeforeImage;
            stockButton.UseVisualStyleBackColor = false;
            stockButton.Click += stockButton_Click;
            // 
            // productButton
            // 
            productButton.BackColor = SystemColors.MenuHighlight;
            productButton.Dock = DockStyle.Fill;
            productButton.FlatAppearance.BorderColor = SystemColors.Highlight;
            productButton.FlatAppearance.BorderSize = 4;
            productButton.FlatStyle = FlatStyle.Flat;
            productButton.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            productButton.Image = Properties.Resources.prodcuct;
            productButton.Location = new Point(145, 3);
            productButton.Name = "productButton";
            productButton.Size = new Size(136, 74);
            productButton.TabIndex = 1;
            productButton.Text = "Product";
            productButton.TextImageRelation = TextImageRelation.TextBeforeImage;
            productButton.UseVisualStyleBackColor = false;
            productButton.Click += productButton_Click;
            // 
            // userButton
            // 
            userButton.BackColor = SystemColors.MenuHighlight;
            userButton.Dock = DockStyle.Fill;
            userButton.FlatAppearance.BorderColor = SystemColors.Highlight;
            userButton.FlatAppearance.BorderSize = 4;
            userButton.FlatStyle = FlatStyle.Flat;
            userButton.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            userButton.Image = Properties.Resources.user;
            userButton.Location = new Point(3, 3);
            userButton.Name = "userButton";
            userButton.Size = new Size(136, 74);
            userButton.TabIndex = 0;
            userButton.Text = "User";
            userButton.TextImageRelation = TextImageRelation.TextBeforeImage;
            userButton.UseVisualStyleBackColor = false;
            userButton.Click += userButton_Click;
            // 
            // salesButton
            // 
            salesButton.BackColor = SystemColors.MenuHighlight;
            salesButton.Dock = DockStyle.Fill;
            salesButton.FlatAppearance.BorderColor = SystemColors.Highlight;
            salesButton.FlatAppearance.BorderSize = 4;
            salesButton.FlatStyle = FlatStyle.Flat;
            salesButton.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            salesButton.Image = Properties.Resources.sales;
            salesButton.Location = new Point(3, 83);
            salesButton.Name = "salesButton";
            salesButton.Size = new Size(136, 74);
            salesButton.TabIndex = 4;
            salesButton.Text = "Sales";
            salesButton.TextImageRelation = TextImageRelation.TextBeforeImage;
            salesButton.UseVisualStyleBackColor = false;
            salesButton.Click += salesButton_Click;
            // 
            // categoryButton
            // 
            categoryButton.BackColor = SystemColors.MenuHighlight;
            categoryButton.Dock = DockStyle.Fill;
            categoryButton.FlatAppearance.BorderColor = SystemColors.Highlight;
            categoryButton.FlatAppearance.BorderSize = 4;
            categoryButton.FlatStyle = FlatStyle.Flat;
            categoryButton.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            categoryButton.Image = Properties.Resources.category;
            categoryButton.Location = new Point(145, 83);
            categoryButton.Name = "categoryButton";
            categoryButton.Size = new Size(136, 74);
            categoryButton.TabIndex = 5;
            categoryButton.Text = "Category";
            categoryButton.TextImageRelation = TextImageRelation.TextBeforeImage;
            categoryButton.UseVisualStyleBackColor = false;
            categoryButton.Click += categoryButton_Click;
            // 
            // supplierButton
            // 
            supplierButton.BackColor = SystemColors.MenuHighlight;
            supplierButton.Dock = DockStyle.Fill;
            supplierButton.FlatAppearance.BorderColor = SystemColors.Highlight;
            supplierButton.FlatAppearance.BorderSize = 4;
            supplierButton.FlatStyle = FlatStyle.Flat;
            supplierButton.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            supplierButton.Image = (Image)resources.GetObject("supplierButton.Image");
            supplierButton.Location = new Point(287, 83);
            supplierButton.Name = "supplierButton";
            supplierButton.Size = new Size(136, 74);
            supplierButton.TabIndex = 6;
            supplierButton.Text = "Supplier";
            supplierButton.TextImageRelation = TextImageRelation.TextBeforeImage;
            supplierButton.UseVisualStyleBackColor = false;
            supplierButton.Click += supplierButton_Click;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Home";
            Text = "Home";
            Load += Home_Load;
            leftPanel.ResumeLayout(false);
            rightPanel.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Button userButton;
        private Button invoiceButton;
        private Button stockButton;
        private Button productButton;
        private Button salesButton;
        private Button categoryButton;
        private Button supplierButton;
    }
}