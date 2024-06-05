using System.Data;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace ims.CRUD
{
    internal class Insertion
    {
        public Insertion() => Main.con.Open();
        // ~Insertion()
        // {
        //     Main.con.Close();
        //     MessageBox.Show("destructor called");
        // }

        public void InsertUser(string name, string username, string password, string email, string phone, Int16 status)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_insertUsers", Main.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@_usr_name", name);
                cmd.Parameters.AddWithValue("@_usr_username", username);
                cmd.Parameters.AddWithValue("@_usr_password", password);
                cmd.Parameters.AddWithValue("@_usr_phone", phone);
                cmd.Parameters.AddWithValue("@_usr_email", email);
                cmd.Parameters.AddWithValue("@_usr_status", status);
                cmd.ExecuteNonQuery();
                Main.con.Close();
                Main.ShowMSG("User Inserted Successfully", "Success", "Success");
            }
            catch (Exception ex)
            {
                Main.ShowMSG("Error While Inserting User. " + ex.Message, "Error", "Error");
            }
        }

        public void InsertCategory(string name, Int16 status)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_insertCategorie", Main.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@_cat_name", name);
                cmd.Parameters.AddWithValue("@_cat_status", status);
                cmd.ExecuteNonQuery();
                Main.con.Close();
                Main.ShowMSG("Category Inserted Successfully", "Success", "Success");
            }
            catch (Exception ex)
            {
                Main.ShowMSG("Error While Inserting Category. " + ex.Message, "Error", "Error");
            }
        }
    }
}
