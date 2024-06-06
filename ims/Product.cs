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
        }

        public override void addBtn_Click(object sender, EventArgs e)
        {
            Main.enable_reset(leftPanel);
            edit = 0;
            retrieval.getDropDownList("st_getCategoyList", categoryDD);
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

                if (edit == 0)
                {
                    // Insert Data
                    Insertion insertion = new Insertion();
                    insertion.InsertProduct(Convert.ToInt32(categoryDD.SelectedValue), nameTxt.Text, barcodeTxt.Text, expiryDateTxt.Value, Convert.ToSingle(priceTxt.Text), status);
                    retrieval.showProduct(dataGridView1, proIDGV, NameGV, BarcodeGV, ExpiryDateGV, PriceGV, CategoryGV, StatusGV);
                    Main.disable_reset(leftPanel);
                }
                else if (edit == 1)
                {
                    DialogResult dr = MessageBox.Show("Are you sure you want to update record?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dr == DialogResult.Yes)
                    {
                        // Update Data
                        Updation updation = new Updation();
                        // updation.UpdateUser(userID, nameTxt.Text, usernameTxt.Text, passwordTxt.Text, emailTxt.Text, phoneTxt.Text, status);
                        // retrieval.showUser(dataGridView1, userIDGV, NameGV, UserNameGV, PassGV, EmailGV, PhoneGV, StatusGV);
                        Main.disable_reset(leftPanel);
                    }
                }
            }
        }

        public override void deleteBtn_Click(object sender, EventArgs e)
        {

        }

        public override void viewBtn_Click(object sender, EventArgs e)
        {
            retrieval.showProduct(dataGridView1, proIDGV, NameGV, BarcodeGV, ExpiryDateGV, PriceGV, CategoryGV, StatusGV);
        }

        public override void searchBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
