using ims.CRUD;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ims
{
    public partial class Invoice : Action
    {
        private int edit;
        private Retrieval retrieval = new Retrieval();
        private int invID;

        public Invoice()
        {
            InitializeComponent();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            Main.showWindow(home, this, MDI.ActiveForm);
        }

        private void Invoice_Load(object sender, EventArgs e)
        {
            Main.disable(leftPanel);
            edit = 0;
            retrieval.getDropDownList("st_getSupplierList", supplierDD);
            retrieval.getDropDownList("st_getProductList", productDD);
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

        }

        public override void deleteBtn_Click(object sender, EventArgs e)
        {
            if (edit == 1)
            {
                DialogResult dr = MessageBox.Show("Are you sure you want to delete record?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    Deletion deletion = new Deletion();
                    deletion.Delete("st_deleteCategoies", "@_id", invID);
                    // retrieval.showCategory(dataGridView1, catIDGV, catNameGV, catStatusGV);
                    Main.disable_reset(leftPanel);
                }
            }
        }
        public override void viewBtn_Click(object sender, EventArgs e)
        {
            // retrieval.showCategory(dataGridView1, catIDGV, catNameGV, catStatusGV);
        }

        public override void searchBox_TextChanged(object sender, EventArgs e)
        {
            Main.disable(leftPanel);

            /*if (e.RowIndex != -1)
            {
                edit = 1;
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                catID = Convert.ToInt32(row.Cells["catIDGV"].Value.ToString());
                nameTxt.Text = row.Cells["catNameGV"].Value.ToString();
                statusDD.SelectedItem = row.Cells["catStatusGV"].Value.ToString();
            }*/
        }

    }
}
