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

        private void supplierButton_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            Supplier supplier = new Supplier();
            Main.showWindow(supplier, home, MDI.ActiveForm);
        }

        private void stockButton_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            Stock stock = new Stock();
            Main.showWindow(stock, home, MDI.ActiveForm);
        }

        private void invoiceButton_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            Invoice invoice = new Invoice();
            Main.showWindow(invoice, home, MDI.ActiveForm);
        }

        private void salesButton_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            Sales sales = new Sales();
            Main.showWindow(sales, home, MDI.ActiveForm);
        }
    }
}
