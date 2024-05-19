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
            button2 = new Button();
            userButton = new Button();
            button5 = new Button();
            rightPanel.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // rightPanel
            // 
            rightPanel.Controls.Add(tableLayoutPanel1);
            rightPanel.Controls.SetChildIndex(tableLayoutPanel1, 0);
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 5;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.Controls.Add(button4, 3, 0);
            tableLayoutPanel1.Controls.Add(button3, 2, 0);
            tableLayoutPanel1.Controls.Add(button2, 1, 0);
            tableLayoutPanel1.Controls.Add(userButton, 0, 0);
            tableLayoutPanel1.Controls.Add(button5, 4, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 48);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.Size = new Size(600, 402);
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
            button4.Location = new Point(363, 3);
            button4.Name = "button4";
            button4.Size = new Size(114, 74);
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
            button3.Location = new Point(243, 3);
            button3.Name = "button3";
            button3.Size = new Size(114, 74);
            button3.TabIndex = 2;
            button3.Text = "Stock";
            button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.MenuHighlight;
            button2.Dock = DockStyle.Fill;
            button2.FlatAppearance.BorderColor = SystemColors.Highlight;
            button2.FlatAppearance.BorderSize = 4;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(123, 3);
            button2.Name = "button2";
            button2.Size = new Size(114, 74);
            button2.TabIndex = 1;
            button2.Text = "Product";
            button2.UseVisualStyleBackColor = false;
            // 
            // userButton
            // 
            userButton.BackColor = SystemColors.MenuHighlight;
            userButton.Dock = DockStyle.Fill;
            userButton.FlatAppearance.BorderColor = SystemColors.Highlight;
            userButton.FlatAppearance.BorderSize = 4;
            userButton.FlatStyle = FlatStyle.Flat;
            userButton.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            userButton.Location = new Point(3, 3);
            userButton.Name = "userButton";
            userButton.Size = new Size(114, 74);
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
            button5.Location = new Point(483, 3);
            button5.Name = "button5";
            button5.Size = new Size(114, 74);
            button5.TabIndex = 4;
            button5.Text = "Sales";
            button5.UseVisualStyleBackColor = false;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Name = "Home";
            Text = "Home";
            rightPanel.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Button userButton;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button5;
    }
}