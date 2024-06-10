using ims.CRUD;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ims
{
    public partial class Category : Action
    {
        private int edit = 0;
        private Retrieval retrieval = new Retrieval();
        private int catID;

        public Category()
        {
            InitializeComponent();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            Main.showWindow(home, this, MDI.ActiveForm);
        }

        private void Category_Load(object sender, EventArgs e)
        {
            Main.disable(leftPanel);
        }

        public override void addBtn_Click(object sender, EventArgs e)
        {
            Main.enable_reset(leftPanel);
            edit = 0;
        }

        public override void editBtn_Click(object sender, EventArgs e)
        {
            Main.enable(leftPanel);
            edit = 1;
        }

        public override void saveBtn_Click(object sender, EventArgs e)
        {
            nameErrorLabel.Visible = (nameTxt.Text == "") ? true : false;
            statusErrorLabel.Visible = (statusDD.SelectedIndex == -1) ? true : false;

            if (nameErrorLabel.Visible || statusErrorLabel.Visible)
            {
                Main.ShowMSG("Fields with * are medatory", "Stop", "Error");
            }
            else
            {
                short status = (short)((statusDD.SelectedIndex == 0) ? 1 : 0);

                if (edit == 0)
                {
                    // Insert Data
                    Insertion insertion = new Insertion();
                    insertion.InsertCategory(nameTxt.Text, status);
                    retrieval.showCategory(dataGridView1, catIDGV, catNameGV, catStatusGV);
                    Main.disable_reset(leftPanel);
                }
                else if (edit == 1)
                {
                    DialogResult dr = MessageBox.Show("Are you sure you want to update record?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dr == DialogResult.Yes)
                    {
                        // Update Data
                        Updation updation = new Updation();
                        updation.UpdateCategory(catID, nameTxt.Text, status);
                        retrieval.showCategory(dataGridView1, catIDGV, catNameGV, catStatusGV);
                        Main.disable_reset(leftPanel);
                    }
                }
            }
        }

        public override void deleteBtn_Click(object sender, EventArgs e)
        {
            if (edit == 1)
            {
                DialogResult dr = MessageBox.Show("Are you sure you want to delete record?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    Deletion deletion = new Deletion();
                    deletion.Delete("st_deleteCategoies", "@_id", catID);
                    retrieval.showCategory(dataGridView1, catIDGV, catNameGV, catStatusGV);
                    Main.disable_reset(leftPanel);
                }
            }
        }

        public override void viewBtn_Click(object sender, EventArgs e)
        {
            retrieval.showCategory(dataGridView1, catIDGV, catNameGV, catStatusGV);
        }

        public override void searchBox_TextChanged(object sender, EventArgs e)
        {
            if (searchBox.Text != string.Empty)
            {
                retrieval.showCategory(dataGridView1, catIDGV, catNameGV, catStatusGV, searchBox.Text);
            }
            else
            {
                retrieval.showCategory(dataGridView1, catIDGV, catNameGV, catStatusGV);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Main.disable(leftPanel);

            if (e.RowIndex != -1)
            {
                edit = 1;
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                catID = Convert.ToInt32(row.Cells["catIDGV"].Value.ToString());
                nameTxt.Text = row.Cells["catNameGV"].Value.ToString();
                statusDD.SelectedItem = row.Cells["catStatusGV"].Value.ToString();
            }
        }
    }
}
