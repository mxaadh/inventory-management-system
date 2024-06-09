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
    public partial class Login : Base
    {
        public Login()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            usernameErrorLabel.Visible = (usernametext.Text == string.Empty) ? true : false;
            passwordErrorLabel.Visible = (passwordText.Text == string.Empty) ? true : false;

            if (usernameErrorLabel.Visible || passwordErrorLabel.Visible)
            {
                Main.ShowMSG("Fields with * are medatory", "Stop", "Error");
            }
            else
            {
                if (Retrieval.authUser(usernametext.Text, passwordText.Text))
                {
                    Login login = new Login();
                    Home home = new Home();
                    Main.showWindow(home, login, MDI.ActiveForm);
                }
            }

        }

        private void usernametext_TextChanged(object sender, EventArgs e)
        {
            usernameErrorLabel.Visible = (usernametext.Text == string.Empty) ? true : false;
        }

        private void passwordText_TextChanged(object sender, EventArgs e)
        {
            passwordErrorLabel.Visible = (passwordText.Text == string.Empty) ? true : false;
        }
    }
}
