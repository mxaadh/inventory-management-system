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
    public partial class Product : Action
    {
        private int edit;
        private Retrieval retrieval = new Retrieval();
        private int proID;

        public Product()
        {
            InitializeComponent();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            Main.showWindow(home, this, MDI.ActiveForm);
        }

        private void Product_Load(object sender, EventArgs e)
        {
            Main.disable(leftPanel);
            edit = 0;
            retrieval.getDropDownList("st_getCategoyList", categoryDD);
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
            barcodeErrorLabel.Visible = (barcodeTxt.Text == "") ? true : false;
            if (expiryDateTxt.Value < DateTime.Now)
            {
                expiryDateErrorLabel.Text = "Invali Date";
                expiryDateErrorLabel.Visible = true;
            }
            else
            {
                expiryDateErrorLabel.Text = "*";
                expiryDateErrorLabel.Visible = false;
            }
            if (expiryDateTxt.Value.Date == DateTime.Now.Date)
            {
                expiryDateErrorLabel.Visible = false;
            }
            priceErrorLabel.Visible = (priceTxt.Text == "") ? true : false;
            categoryErrorLabel.Visible = (categoryDD.SelectedIndex == -1) ? true : false;
            statusErrorLabel.Visible = (statusDD.SelectedIndex == -1) ? true : false;

            if (nameErrorLabel.Visible || barcodeErrorLabel.Visible || expiryDateErrorLabel.Visible || priceErrorLabel.Visible || categoryErrorLabel.Visible || statusErrorLabel.Visible)
            {
                Main.ShowMSG("Fields with * are medatory", "Stop", "Error");
            }
            else
            {
                short status = (short)((statusDD.SelectedIndex == 0) ? 1 : 0);
                DateTime? expiryDate = (expiryDateTxt.Value.Date == DateTime.Now.Date) ? null : expiryDateTxt.Value;

                if (edit == 0)
                {
                    // Insert Data
                    Insertion insertion = new Insertion();
                    insertion.InsertProduct(Convert.ToInt32(categoryDD.SelectedValue), nameTxt.Text, barcodeTxt.Text, Convert.ToSingle(priceTxt.Text), status, expiryDate);
                    retrieval.showProduct(dataGridView1, proIDGV, catIDGV, NameGV, BarcodeGV, ExpiryDateGV, PriceGV, CategoryGV, StatusGV);
                    Main.disable_reset(leftPanel);
                }
                else if (edit == 1)
                {
                    DialogResult dr = MessageBox.Show("Are you sure you want to update record?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dr == DialogResult.Yes)
                    {
                        // Update Data
                        Updation updation = new Updation();
                        updation.UpdateProduct(proID, Convert.ToInt32(categoryDD.SelectedValue), nameTxt.Text, barcodeTxt.Text, Convert.ToSingle(priceTxt.Text), status, expiryDate);
                        retrieval.showProduct(dataGridView1, proIDGV, catIDGV, NameGV, BarcodeGV, ExpiryDateGV, PriceGV, CategoryGV, StatusGV);
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
                    deletion.Delete("st_deleteProducts", "@_id", proID);
                    retrieval.showProduct(dataGridView1, proIDGV, catIDGV, NameGV, BarcodeGV, ExpiryDateGV, PriceGV, CategoryGV, StatusGV);
                    Main.disable_reset(leftPanel);
                }
            }
        }

        public override void viewBtn_Click(object sender, EventArgs e)
        {
            retrieval.showProduct(dataGridView1, proIDGV, catIDGV, NameGV, BarcodeGV, ExpiryDateGV, PriceGV, CategoryGV, StatusGV);
        }

        public override void searchBox_TextChanged(object sender, EventArgs e)
        {
            if (searchBox.Text != string.Empty)
            {
                retrieval.showProduct(dataGridView1, proIDGV, catIDGV, NameGV, BarcodeGV, ExpiryDateGV, PriceGV, CategoryGV, StatusGV, searchBox.Text);
            }
            else
            {
                retrieval.showProduct(dataGridView1, proIDGV, catIDGV, NameGV, BarcodeGV, ExpiryDateGV, PriceGV, CategoryGV, StatusGV);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Main.disable(leftPanel);

            if (e.RowIndex != -1 && e.ColumnIndex != -1)
            {
                edit = 1;
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                proID = Convert.ToInt32(row.Cells["proIDGV"].Value.ToString());
                nameTxt.Text = row.Cells["NameGV"].Value.ToString();
                barcodeTxt.Text = row.Cells["BarcodeGV"].Value.ToString();
                expiryDateTxt.Value = (row.Cells["ExpiryDateGV"].Value.ToString() != string.Empty) ? Convert.ToDateTime(row.Cells["ExpiryDateGV"].Value.ToString()) : DateTime.Now;
                priceTxt.Value = Convert.ToInt32(row.Cells["PriceGV"].Value);
                categoryDD.SelectedValue= row.Cells["catIDGV"].Value.ToString();
                statusDD.SelectedItem = row.Cells["StatusGV"].Value.ToString();
            }
        }
    }
}
