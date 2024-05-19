using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ims
{
    public partial class Settings : Base
    {
        public Settings()
        {
            InitializeComponent();
        }

        private void isIntegratedSecurity_CheckedChanged(object sender, EventArgs e)
        {
            if (isIntegratedSecurity.Checked)
            {
                textBoxUsername.Enabled = false;
                textBoxPassword.Enabled = false;
                textBoxUsername.Text = string.Empty;
                textBoxPassword.Text = string.Empty;
            }
            else
            {
                textBoxUsername.Enabled = true;
                textBoxPassword.Enabled = true;
            }
        }

        private void saveSettings_Click(object sender, EventArgs e)
        {
            string connectionString, server, database, username, password;
            connectionString = string.Empty;
            server = textBoxServer.Text;        // DESKTOP - 3201465\\MSSQLSERVER01
            database = textBoxDatabase.Text;    // AdventureWorksLT2017
            username = textBoxUsername.Text;
            password = textBoxPassword.Text;

            if (server == string.Empty && database == string.Empty)
            {
                MessageBox.Show("Invalid Configration.");
                return;
            }

            if (isIntegratedSecurity.Checked)
            {
                connectionString = "Data Source = " + server + "; Initial Catalog = " + database + "; Integrated Security = True; Trust Server Certificate = True";
            }
            else
            {
                if (username != string.Empty && password != string.Empty)
                {
                    connectionString = "Data Source = " + server + "; Initial Catalog = " + database + "; User ID = " + username + "; Password = " + password + "; Trust Server Certificate = True";
                }
                else
                {
                    MessageBox.Show("Invalid User & Password.");
                }
            }

            string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string filePath = path+"\\connect";
            File.WriteAllText(filePath, connectionString);
            DialogResult result = MessageBox.Show("Setting Save Successfully.");
            if (result == DialogResult.OK)
            {
                Login login = new Login();
                Main.showWindow(login, this, MDI.ActiveForm);
            }
            else
            {
                MessageBox.Show("Error While Creating File");
            }
        }
    }
}
