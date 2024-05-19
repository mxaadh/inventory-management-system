namespace ims
{
    partial class Action
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
            panel3 = new Panel();
            panel4 = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            saveButton = new Button();
            deleteButton = new Button();
            button1 = new Button();
            editButton = new Button();
            groupBox1 = new GroupBox();
            textBox1 = new TextBox();
            backBtn = new Button();
            leftPanel.SuspendLayout();
            rightPanel.SuspendLayout();
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // leftPanel
            // 
            leftPanel.Controls.Add(panel3);
            leftPanel.Controls.SetChildIndex(panel1, 0);
            leftPanel.Controls.SetChildIndex(panel3, 0);
            // 
            // rightPanel
            // 
            rightPanel.Controls.Add(panel4);
            rightPanel.Controls.SetChildIndex(panel4, 0);
            // 
            // panel1
            // 
            panel1.Controls.Add(backBtn);
            panel1.Controls.SetChildIndex(backBtn, 0);
            // 
            // panel3
            // 
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 50);
            panel3.Name = "panel3";
            panel3.Size = new Size(200, 50);
            panel3.TabIndex = 1;
            // 
            // panel4
            // 
            panel4.Controls.Add(tableLayoutPanel1);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(0, 50);
            panel4.Name = "panel4";
            panel4.Size = new Size(600, 50);
            panel4.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 6;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.Controls.Add(saveButton, 0, 0);
            tableLayoutPanel1.Controls.Add(deleteButton, 0, 0);
            tableLayoutPanel1.Controls.Add(button1, 0, 0);
            tableLayoutPanel1.Controls.Add(editButton, 0, 0);
            tableLayoutPanel1.Controls.Add(groupBox1, 4, 0);
            tableLayoutPanel1.Dock = DockStyle.Top;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(600, 50);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // saveButton
            // 
            saveButton.BackColor = SystemColors.MenuHighlight;
            saveButton.Dock = DockStyle.Fill;
            saveButton.FlatAppearance.BorderColor = SystemColors.Highlight;
            saveButton.FlatAppearance.BorderSize = 2;
            saveButton.FlatStyle = FlatStyle.Flat;
            saveButton.Location = new Point(203, 3);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(94, 44);
            saveButton.TabIndex = 3;
            saveButton.Text = "Save";
            saveButton.UseVisualStyleBackColor = false;
            // 
            // deleteButton
            // 
            deleteButton.BackColor = SystemColors.MenuHighlight;
            deleteButton.Dock = DockStyle.Fill;
            deleteButton.FlatAppearance.BorderColor = SystemColors.Highlight;
            deleteButton.FlatAppearance.BorderSize = 2;
            deleteButton.FlatStyle = FlatStyle.Flat;
            deleteButton.Location = new Point(303, 3);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(94, 44);
            deleteButton.TabIndex = 2;
            deleteButton.Text = "Detele";
            deleteButton.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.MenuHighlight;
            button1.Dock = DockStyle.Fill;
            button1.FlatAppearance.BorderColor = SystemColors.Highlight;
            button1.FlatAppearance.BorderSize = 2;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(3, 3);
            button1.Name = "button1";
            button1.Size = new Size(94, 44);
            button1.TabIndex = 1;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = false;
            // 
            // editButton
            // 
            editButton.BackColor = SystemColors.MenuHighlight;
            editButton.Dock = DockStyle.Fill;
            editButton.FlatAppearance.BorderColor = SystemColors.Highlight;
            editButton.FlatAppearance.BorderSize = 2;
            editButton.FlatStyle = FlatStyle.Flat;
            editButton.Location = new Point(103, 3);
            editButton.Name = "editButton";
            editButton.Size = new Size(94, 44);
            editButton.TabIndex = 0;
            editButton.Text = "Edit";
            editButton.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            tableLayoutPanel1.SetColumnSpan(groupBox1, 2);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Location = new Point(403, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(194, 44);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Search";
            // 
            // textBox1
            // 
            textBox1.Dock = DockStyle.Bottom;
            textBox1.Location = new Point(3, 18);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(188, 23);
            textBox1.TabIndex = 0;
            // 
            // backBtn
            // 
            backBtn.BackColor = SystemColors.HotTrack;
            backBtn.Dock = DockStyle.Left;
            backBtn.FlatAppearance.BorderSize = 0;
            backBtn.FlatStyle = FlatStyle.Flat;
            backBtn.ForeColor = Color.Transparent;
            backBtn.Image = Properties.Resources.back_icon;
            backBtn.Location = new Point(0, 0);
            backBtn.Name = "backBtn";
            backBtn.Size = new Size(50, 50);
            backBtn.TabIndex = 2;
            backBtn.UseVisualStyleBackColor = false;
            // 
            // Action
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Name = "Action";
            leftPanel.ResumeLayout(false);
            rightPanel.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel4.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel3;
        private Panel panel4;
        private TableLayoutPanel tableLayoutPanel1;
        private Button editButton;
        private Button saveButton;
        private Button deleteButton;
        private Button button1;
        protected Button backBtn;
        private GroupBox groupBox1;
        private TextBox textBox1;
    }
}