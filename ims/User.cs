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
            MessageBox.Show("user loaded");
        }

        public override void addBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("user add btn click");
        }

        public override void editBtn_Click(object sender, EventArgs e)
        {

        }

        public override void saveBtn_Click(object sender, EventArgs e)
        {

        }

        public override void deleteBtn_Click(object sender, EventArgs e)
        {

        }

        public override void searchBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
