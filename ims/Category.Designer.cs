namespace ims
{
    partial class Category
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
            searchBox.Size = new Size(81, 27);
            // 
            // formsHeadingLabel
            // 
            formsHeadingLabel.Size = new Size(147, 28);
            formsHeadingLabel.Text = "Category Form";
            // 
            // leftPanel
            // 
            leftPanel.Size = new Size(262, 450);
            // 
            // rightPanel
            // 
            rightPanel.Size = new Size(538, 450);
            // 
            // Category
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Name = "Category";
            Text = "Category";
            actionLeftPanel.ResumeLayout(false);
            actionLeftPanel.PerformLayout();
            leftPanel.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
    }
}