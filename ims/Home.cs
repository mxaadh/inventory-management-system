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
    public partial class Home : Base
    {
        public Home()
        {
            InitializeComponent();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            auth_usr_name.Text = Retrieval.usr_name;
            MDI.logoutToolStripMenuItem.Enabled = true;
        }

        private void userButton_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            User user = new User();
            Main.showWindow(user, home, MDI.ActiveForm);
        }

        private void productButton_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            Product product = new Product();
            Main.showWindow(product, home, MDI.ActiveForm);
        }

        private void categoryButton_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            Category category = new Category();
            Main.showWindow(category, home, MDI.ActiveForm);
        }
    }
}
