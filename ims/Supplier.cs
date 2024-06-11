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
    public partial class Supplier : Action
    {
        private int edit;
        private Retrieval retrieval = new Retrieval();
        private int supID;

        public Supplier()
        {
            InitializeComponent();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            Main.showWindow(home, this, MDI.ActiveForm);
        }

        private void Supplier_Load(object sender, EventArgs e)
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
            contectPersonErrorLabel.Visible = (contectPersonTxt.Text == "") ? true : false;
            phone1ErrorLabel.Visible = (phone1Txt.Text == "") ? true : false;
            addressErrorLabel.Visible = (addressTxt.Text == "") ? true : false;
            statusErrorLabel.Visible = (statusDD.SelectedIndex == -1) ? true : false;

            if (nameErrorLabel.Visible || contectPersonErrorLabel.Visible || phone1ErrorLabel.Visible || addressErrorLabel.Visible || statusErrorLabel.Visible)
            {
                Main.ShowMSG("Fields with * are medatory", "Stop", "Error");
            }
            else
            {
                short status = (short)((statusDD.SelectedIndex == 0) ? 1 : 0);
                string? phone2Txt_Text = (phone2Txt.Text == string.Empty) ? null : phone2Txt.Text;
                string? ntnTxt_Text = (ntnTxt.Text == string.Empty) ? null : ntnTxt.Text;

                if (edit == 0)
                {
                    // Insert Data
                    Insertion insertion = new Insertion();
                    insertion.InsertSupplier(nameTxt.Text, contectPersonTxt.Text, phone1Txt.Text, addressTxt.Text, status, phone2Txt_Text, ntnTxt_Text);
                    retrieval.showSupplier(dataGridView1, supIDGV, supNameGV, supContectPersonGV, supPhone1GV, supPhone2GV, supAddressGV, supNTNGV, supStatusGV);
                    Main.disable_reset(leftPanel);
                }
                else if (edit == 1)
                {
                    DialogResult dr = MessageBox.Show("Are you sure you want to update record?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dr == DialogResult.Yes)
                    {
                        // Update Data
                        Updation updation = new Updation();
                        updation.UpdateSupplier(supID, nameTxt.Text, contectPersonTxt.Text, phone1Txt.Text, addressTxt.Text, status, phone2Txt_Text, ntnTxt_Text); ;
                        retrieval.showSupplier(dataGridView1, supIDGV, supNameGV, supContectPersonGV, supPhone1GV, supPhone2GV, supAddressGV, supNTNGV, supStatusGV);
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
                    deletion.Delete("st_deleteSuppliers", "@_id", supID);
                    retrieval.showSupplier(dataGridView1, supIDGV, supNameGV, supContectPersonGV, supPhone1GV, supPhone2GV, supAddressGV, supNTNGV, supStatusGV);
                    Main.disable_reset(leftPanel);
                }
            }
        }

        public override void viewBtn_Click(object sender, EventArgs e)
        {
            retrieval.showSupplier(dataGridView1,supIDGV,supNameGV,supContectPersonGV,supPhone1GV,supPhone2GV,supAddressGV,supNTNGV,supStatusGV);
        }

        public override void searchBox_TextChanged(object sender, EventArgs e)
        {
            if (searchBox.Text != string.Empty)
            {
                retrieval.showSupplier(dataGridView1, supIDGV, supNameGV, supContectPersonGV, supPhone1GV, supPhone2GV, supAddressGV, supNTNGV, supStatusGV, searchBox.Text);

            }
            else
            {
                retrieval.showSupplier(dataGridView1, supIDGV, supNameGV, supContectPersonGV, supPhone1GV, supPhone2GV, supAddressGV, supNTNGV, supStatusGV);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Main.disable(leftPanel);

            if (e.RowIndex != -1 && e.ColumnIndex != -1)
            {
                edit = 1;
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                supID = Convert.ToInt32(row.Cells["supIDGV"].Value.ToString());
                nameTxt.Text = row.Cells["supNameGV"].Value.ToString();
                contectPersonTxt.Text = row.Cells["supContectPersonGV"].Value.ToString();
                phone1Txt.Text = row.Cells["supPhone1GV"].Value.ToString();
                phone2Txt.Text = row.Cells["supPhone2GV"].Value.ToString();
                addressTxt.Text = row.Cells["supAddressGV"].Value.ToString();
                ntnTxt.Text = row.Cells["supNTNGV"].Value.ToString();
                statusDD.SelectedItem = row.Cells["supStatusGV"].Value.ToString();
            }
        }
    }
}
