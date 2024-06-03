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
        int edit = 0; 
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
            edit = 1;
        }

        public override void saveBtn_Click(object sender, EventArgs e)
        {
            nameErrorLabel.Visible = (nameTxt.Text == "") ? true : false;
            usernameErrorLabel.Visible = (usernameTxt.Text == "") ? true : false;
            passwordErrorLabel.Visible = (passwordTxt.Text == "") ? true : false;
            emailErrorLabel.Visible = (emailTxt.Text == "") ? true : false;
            phoneErrorLabel.Visible = (phoneTxt.Text == "") ? true : false;

            if (nameErrorLabel.Visible || usernameErrorLabel.Visible || passwordErrorLabel.Visible || emailErrorLabel.Visible || phoneErrorLabel.Visible)
            {
                Main.ShowMSG("Fields with * are medatory", "Stop", "Error");
            }
            else
            {
                if (edit == 0)
                {
                    // Insert Data
                    // DialogResult dialogResult = MessageBox.Show(Main.con.State);
                    Insertion insertion = new Insertion();
                    insertion.InsertUser(nameTxt.Text, usernameTxt.Text, passwordTxt.Text, emailTxt.Text, phoneTxt.Text);
                }
                else if (edit == 1)
                {
                    // Update Data
                    // Updation updation = new Updation();
                    // updation.UpdateUser(0, nameTxt.Text, usernameTxt.Text, passwordTxt.Text, emailTxt.Text, phoneTxt.Text);
                }
            }
        }

        public override void deleteBtn_Click(object sender, EventArgs e)
        {
            // Deletion deletion = new Deletion();
            // deletion.Delete("st_deleteUsers", "@_id", 0);
        }

        public override void searchBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
