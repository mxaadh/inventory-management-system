using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ims.CRUD;

namespace ims
{
    public partial class User : Action
    {
        private int edit = 0;
        private Retrieval retrieval = new Retrieval();
        private int userID;

        public User()
        {
            InitializeComponent();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            Main.showWindow(home, this, MDI.ActiveForm);
        }

        private void User_Load(object sender, EventArgs e)
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
            usernameErrorLabel.Visible = (usernameTxt.Text == "") ? true : false;
            passwordErrorLabel.Visible = (passwordTxt.Text == "") ? true : false;
            emailErrorLabel.Visible = (emailTxt.Text == "") ? true : false;
            phoneErrorLabel.Visible = (phoneTxt.Text == "") ? true : false;
            statusErrorLabel.Visible = (statusDD.SelectedIndex == -1) ? true : false;

            if (nameErrorLabel.Visible || usernameErrorLabel.Visible || passwordErrorLabel.Visible || emailErrorLabel.Visible || phoneErrorLabel.Visible || statusErrorLabel.Visible)
            {
                Main.ShowMSG("Fields with * are medatory", "Stop", "Error");
            }
            else
            {
                short status = (short)((statusDD.SelectedIndex == 0) ? 1 : 0);

                if (edit == 0)
                {
                    // Insert Data
                    // using (Insertion insertion = new Insertion())
                    // {
                    Insertion insertion = new Insertion();
                    insertion.InsertUser(nameTxt.Text, usernameTxt.Text, passwordTxt.Text, emailTxt.Text, phoneTxt.Text, status);
                    // }
                    retrieval.showUser(dataGridView1, userIDGV, NameGV, UserNameGV, PassGV, EmailGV, PhoneGV, StatusGV);
                    Main.disable_reset(leftPanel);
                }
                else if (edit == 1)
                {
                    DialogResult dr = MessageBox.Show("Are you sure you want to update record?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dr == DialogResult.Yes)
                    {
                        // Update Data
                        Updation updation = new Updation();
                        updation.UpdateUser(userID, nameTxt.Text, usernameTxt.Text, passwordTxt.Text, emailTxt.Text, phoneTxt.Text, status);
                        retrieval.showUser(dataGridView1, userIDGV, NameGV, UserNameGV, PassGV, EmailGV, PhoneGV, StatusGV);
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
                    deletion.Delete("st_deleteUsers", "@_id", userID);
                    retrieval.showUser(dataGridView1, userIDGV, NameGV, UserNameGV, PassGV, EmailGV, PhoneGV, StatusGV);
                }
            }
        }

        public override void viewBtn_Click(object sender, EventArgs e)
        {
            retrieval.showUser(dataGridView1, userIDGV, NameGV, UserNameGV, PassGV, EmailGV, PhoneGV, StatusGV);
        }

        public override void searchBox_TextChanged(object sender, EventArgs e)
        {
            if (searchBox.Text != string.Empty)
            {
                MessageBox.Show(searchBox.Text);
                retrieval.showUser(dataGridView1, userIDGV, NameGV, UserNameGV, PassGV, EmailGV, PhoneGV, StatusGV, searchBox.Text);
            }
            else
            {
                retrieval.showUser(dataGridView1, userIDGV, NameGV, UserNameGV, PassGV, EmailGV, PhoneGV, StatusGV);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Main.disable(leftPanel);

            if (e.RowIndex != -1)
            {
                edit = 1;
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                userID = Convert.ToInt32(row.Cells["userIDGV"].Value.ToString());
                nameTxt.Text = row.Cells["NameGV"].Value.ToString();
                usernameTxt.Text = row.Cells["UserNameGV"].Value.ToString();
                passwordTxt.Text = row.Cells["PassGV"].Value.ToString();
                emailTxt.Text = row.Cells["EmailGV"].Value.ToString();
                phoneTxt.Text = row.Cells["PhoneGV"].Value.ToString();
                statusDD.SelectedItem = row.Cells["StatusGV"].Value.ToString();
            }
        }
    }
}
