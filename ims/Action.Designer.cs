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
            actionRightpanel = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            saveBtn = new Button();
            deleteBtn = new Button();
            addBtn = new Button();
            editBtn = new Button();
            groupBox1 = new GroupBox();
            searchBox = new TextBox();
            viewBtn = new Button();
            backBtn = new Button();
            actionLeftPanel = new Panel();
            formsHeadingLabel = new Label();
            leftPanel.SuspendLayout();
            rightPanel.SuspendLayout();
            panel1.SuspendLayout();
            actionRightpanel.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            groupBox1.SuspendLayout();
            actionLeftPanel.SuspendLayout();
            SuspendLayout();
            // 
            // leftPanel
            // 
            leftPanel.Controls.Add(actionLeftPanel);
            leftPanel.Controls.SetChildIndex(panel1, 0);
            leftPanel.Controls.SetChildIndex(actionLeftPanel, 0);
            // 
            // rightPanel
            // 
            rightPanel.Controls.Add(actionRightpanel);
            rightPanel.Controls.SetChildIndex(actionRightpanel, 0);
            // 
            // panel1
            // 
            panel1.Controls.Add(backBtn);
            panel1.Controls.SetChildIndex(backBtn, 0);
            // 
            // actionRightpanel
            // 
            actionRightpanel.Controls.Add(tableLayoutPanel1);
            actionRightpanel.Dock = DockStyle.Top;
            actionRightpanel.Location = new Point(0, 67);
            actionRightpanel.Margin = new Padding(3, 4, 3, 4);
            actionRightpanel.Name = "actionRightpanel";
            actionRightpanel.Size = new Size(652, 67);
            actionRightpanel.TabIndex = 1;
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
            tableLayoutPanel1.Controls.Add(saveBtn, 0, 0);
            tableLayoutPanel1.Controls.Add(deleteBtn, 0, 0);
            tableLayoutPanel1.Controls.Add(addBtn, 0, 0);
            tableLayoutPanel1.Controls.Add(editBtn, 0, 0);
            tableLayoutPanel1.Controls.Add(groupBox1, 5, 0);
            tableLayoutPanel1.Controls.Add(viewBtn, 4, 0);
            tableLayoutPanel1.Dock = DockStyle.Top;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 67F));
            tableLayoutPanel1.Size = new Size(652, 67);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // saveBtn
            // 
            saveBtn.BackColor = SystemColors.MenuHighlight;
            saveBtn.Dock = DockStyle.Fill;
            saveBtn.FlatAppearance.BorderColor = SystemColors.Highlight;
            saveBtn.FlatAppearance.BorderSize = 2;
            saveBtn.FlatStyle = FlatStyle.Flat;
            saveBtn.Location = new Point(219, 4);
            saveBtn.Margin = new Padding(3, 4, 3, 4);
            saveBtn.Name = "saveBtn";
            saveBtn.Size = new Size(102, 59);
            saveBtn.TabIndex = 3;
            saveBtn.Text = "Save";
            saveBtn.UseVisualStyleBackColor = false;
            saveBtn.Click += saveBtn_Click;
            // 
            // deleteBtn
            // 
            deleteBtn.BackColor = SystemColors.MenuHighlight;
            deleteBtn.Dock = DockStyle.Fill;
            deleteBtn.FlatAppearance.BorderColor = SystemColors.Highlight;
            deleteBtn.FlatAppearance.BorderSize = 2;
            deleteBtn.FlatStyle = FlatStyle.Flat;
            deleteBtn.Location = new Point(327, 4);
            deleteBtn.Margin = new Padding(3, 4, 3, 4);
            deleteBtn.Name = "deleteBtn";
            deleteBtn.Size = new Size(102, 59);
            deleteBtn.TabIndex = 2;
            deleteBtn.Text = "Detele";
            deleteBtn.UseVisualStyleBackColor = false;
            deleteBtn.Click += deleteBtn_Click;
            // 
            // addBtn
            // 
            addBtn.BackColor = SystemColors.MenuHighlight;
            addBtn.Dock = DockStyle.Fill;
            addBtn.FlatAppearance.BorderColor = SystemColors.Highlight;
            addBtn.FlatAppearance.BorderSize = 2;
            addBtn.FlatStyle = FlatStyle.Flat;
            addBtn.Location = new Point(3, 4);
            addBtn.Margin = new Padding(3, 4, 3, 4);
            addBtn.Name = "addBtn";
            addBtn.Size = new Size(102, 59);
            addBtn.TabIndex = 1;
            addBtn.Text = "Add";
            addBtn.UseVisualStyleBackColor = false;
            addBtn.Click += addBtn_Click;
            // 
            // editBtn
            // 
            editBtn.BackColor = SystemColors.MenuHighlight;
            editBtn.Dock = DockStyle.Fill;
            editBtn.FlatAppearance.BorderColor = SystemColors.Highlight;
            editBtn.FlatAppearance.BorderSize = 2;
            editBtn.FlatStyle = FlatStyle.Flat;
            editBtn.Location = new Point(111, 4);
            editBtn.Margin = new Padding(3, 4, 3, 4);
            editBtn.Name = "editBtn";
            editBtn.Size = new Size(102, 59);
            editBtn.TabIndex = 0;
            editBtn.Text = "Edit";
            editBtn.UseVisualStyleBackColor = false;
            editBtn.Click += editBtn_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(searchBox);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Location = new Point(543, 4);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(106, 59);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Search";
            // 
            // searchBox
            // 
            searchBox.Dock = DockStyle.Bottom;
            searchBox.Location = new Point(3, 28);
            searchBox.Margin = new Padding(3, 4, 3, 4);
            searchBox.Name = "searchBox";
            searchBox.Size = new Size(100, 27);
            searchBox.TabIndex = 0;
            searchBox.TextChanged += searchBox_TextChanged;
            // 
            // viewBtn
            // 
            viewBtn.BackColor = SystemColors.MenuHighlight;
            viewBtn.Dock = DockStyle.Fill;
            viewBtn.FlatAppearance.BorderColor = SystemColors.HotTrack;
            viewBtn.FlatAppearance.BorderSize = 2;
            viewBtn.FlatStyle = FlatStyle.Flat;
            viewBtn.Location = new Point(435, 3);
            viewBtn.Name = "viewBtn";
            viewBtn.Size = new Size(102, 61);
            viewBtn.TabIndex = 5;
            viewBtn.Text = "View";
            viewBtn.UseVisualStyleBackColor = false;
            viewBtn.Click += viewBtn_Click;
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
            backBtn.Margin = new Padding(3, 4, 3, 4);
            backBtn.Name = "backBtn";
            backBtn.Size = new Size(57, 67);
            backBtn.TabIndex = 2;
            backBtn.UseVisualStyleBackColor = false;
            // 
            // actionLeftPanel
            // 
            actionLeftPanel.Controls.Add(formsHeadingLabel);
            actionLeftPanel.Dock = DockStyle.Top;
            actionLeftPanel.Location = new Point(0, 67);
            actionLeftPanel.Name = "actionLeftPanel";
            actionLeftPanel.Size = new Size(262, 67);
            actionLeftPanel.TabIndex = 13;
            // 
            // formsHeadingLabel
            // 
            formsHeadingLabel.AutoSize = true;
            formsHeadingLabel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            formsHeadingLabel.Location = new Point(12, 16);
            formsHeadingLabel.Name = "formsHeadingLabel";
            formsHeadingLabel.Size = new Size(151, 28);
            formsHeadingLabel.TabIndex = 22;
            formsHeadingLabel.Text = "Forms Heading";
            // 
            // Action
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Margin = new Padding(3, 5, 3, 5);
            Name = "Action";
            leftPanel.ResumeLayout(false);
            rightPanel.ResumeLayout(false);
            panel1.ResumeLayout(false);
            actionRightpanel.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            actionLeftPanel.ResumeLayout(false);
            actionLeftPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel actionRightpanel;
        private TableLayoutPanel tableLayoutPanel1;
        private Button editBtn;
        private Button saveBtn;
        private Button deleteBtn;
        private Button addBtn;
        protected Button backBtn;
        private GroupBox groupBox1;
        protected TextBox searchBox;
        private Button viewBtn;
        protected Panel actionLeftPanel;
        protected Label formsHeadingLabel;
    }
}