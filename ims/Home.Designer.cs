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
            tableLayoutPanel1 = new TableLayoutPanel();
            button4 = new Button();
            button3 = new Button();
            productButton = new Button();
            userButton = new Button();
            button5 = new Button();
            categoryButton = new Button();
            leftPanel.SuspendLayout();
            rightPanel.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // leftPanel
            // 
            leftPanel.Margin = new Padding(3, 5, 3, 5);
            leftPanel.Size = new Size(262, 600);
            // 
            // rightPanel
            // 
            rightPanel.Controls.Add(tableLayoutPanel1);
            rightPanel.Location = new Point(262, 0);
            rightPanel.Margin = new Padding(3, 5, 3, 5);
            rightPanel.Size = new Size(652, 600);
            rightPanel.Controls.SetChildIndex(tableLayoutPanel1, 0);
            // 
            // panel1
            // 
            panel1.Margin = new Padding(3, 5, 3, 5);
            panel1.Size = new Size(262, 89);
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.Controls.Add(button4, 3, 0);
            tableLayoutPanel1.Controls.Add(button3, 2, 0);
            tableLayoutPanel1.Controls.Add(productButton, 1, 0);
            tableLayoutPanel1.Controls.Add(userButton, 0, 0);
            tableLayoutPanel1.Controls.Add(button5, 0, 1);
            tableLayoutPanel1.Controls.Add(categoryButton, 1, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 89);
            tableLayoutPanel1.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.Size = new Size(652, 511);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // button4
            // 
            button4.BackColor = SystemColors.MenuHighlight;
            button4.Dock = DockStyle.Fill;
            button4.FlatAppearance.BorderColor = SystemColors.Highlight;
            button4.FlatAppearance.BorderSize = 4;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.Location = new Point(492, 4);
            button4.Margin = new Padding(3, 4, 3, 4);
            button4.Name = "button4";
            button4.Size = new Size(157, 94);
            button4.TabIndex = 3;
            button4.Text = "Invoice";
            button4.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.MenuHighlight;
            button3.Dock = DockStyle.Fill;
            button3.FlatAppearance.BorderColor = SystemColors.Highlight;
            button3.FlatAppearance.BorderSize = 4;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.Location = new Point(329, 4);
            button3.Margin = new Padding(3, 4, 3, 4);
            button3.Name = "button3";
            button3.Size = new Size(157, 94);
            button3.TabIndex = 2;
            button3.Text = "Stock";
            button3.UseVisualStyleBackColor = false;
            // 
            // productButton
            // 
            productButton.BackColor = SystemColors.MenuHighlight;
            productButton.Dock = DockStyle.Fill;
            productButton.FlatAppearance.BorderColor = SystemColors.Highlight;
            productButton.FlatAppearance.BorderSize = 4;
            productButton.FlatStyle = FlatStyle.Flat;
            productButton.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            productButton.Location = new Point(166, 4);
            productButton.Margin = new Padding(3, 4, 3, 4);
            productButton.Name = "productButton";
            productButton.Size = new Size(157, 94);
            productButton.TabIndex = 1;
            productButton.Text = "Product";
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
            userButton.Location = new Point(3, 4);
            userButton.Margin = new Padding(3, 4, 3, 4);
            userButton.Name = "userButton";
            userButton.Size = new Size(157, 94);
            userButton.TabIndex = 0;
            userButton.Text = "User";
            userButton.UseVisualStyleBackColor = false;
            userButton.Click += userButton_Click;
            // 
            // button5
            // 
            button5.BackColor = SystemColors.MenuHighlight;
            button5.Dock = DockStyle.Fill;
            button5.FlatAppearance.BorderColor = SystemColors.Highlight;
            button5.FlatAppearance.BorderSize = 4;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button5.Location = new Point(3, 106);
            button5.Margin = new Padding(3, 4, 3, 4);
            button5.Name = "button5";
            button5.Size = new Size(157, 94);
            button5.TabIndex = 4;
            button5.Text = "Sales";
            button5.UseVisualStyleBackColor = false;
            // 
            // categoryButton
            // 
            categoryButton.BackColor = SystemColors.MenuHighlight;
            categoryButton.Dock = DockStyle.Fill;
            categoryButton.FlatAppearance.BorderColor = SystemColors.Highlight;
            categoryButton.FlatAppearance.BorderSize = 4;
            categoryButton.FlatStyle = FlatStyle.Flat;
            categoryButton.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            categoryButton.Location = new Point(166, 106);
            categoryButton.Margin = new Padding(3, 4, 3, 4);
            categoryButton.Name = "categoryButton";
            categoryButton.Size = new Size(157, 94);
            categoryButton.TabIndex = 5;
            categoryButton.Text = "Category";
            categoryButton.UseVisualStyleBackColor = false;
            categoryButton.Click += categoryButton_Click;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Margin = new Padding(3, 5, 3, 5);
            Name = "Home";
            Text = "Home";
            leftPanel.ResumeLayout(false);
            rightPanel.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Button userButton;
        private Button button4;
        private Button button3;
        private Button productButton;
        private Button button5;
        private Button categoryButton;
    }
}