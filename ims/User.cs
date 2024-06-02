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
                }
                else if (edit == 1)
                {
                    // Update Data
                }
            }
        }

        public override void deleteBtn_Click(object sender, EventArgs e)
        {

        }

        public override void searchBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
