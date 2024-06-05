using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Xml.Linq;

namespace ims.CRUD
{
    internal class Updation
    {
        public Updation() => Main.con.Open();
        // ~Updation() => Main.con.Close();

        public void UpdateUser(int id, string name, string username, string password, string email, string phone, Int16 status)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_updateUsers", Main.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@_usr_name", name);
                cmd.Parameters.AddWithValue("@_usr_username", username);
                cmd.Parameters.AddWithValue("@_usr_password", password);
                cmd.Parameters.AddWithValue("@_usr_phone", email);
                cmd.Parameters.AddWithValue("@_usr_email", phone);
                cmd.Parameters.AddWithValue("@_usr_status", status);
                cmd.Parameters.AddWithValue("@_id", id);
                cmd.ExecuteNonQuery();
                Main.con.Close();
                Main.ShowMSG("User Updated Successfully", "Success", "Success");
            }
            catch (Exception ex)
            {
                Main.ShowMSG("Error While Updating User. " + ex.Message, "Error", "Error");
            }
        }

        public void UpdateCategory(int id, string name, Int16 status)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_updateCategories", Main.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@_cat_name", name);
                cmd.Parameters.AddWithValue("@_cat_status", status);
                cmd.Parameters.AddWithValue("@_id", id);
                cmd.ExecuteNonQuery();
                Main.con.Close();
                Main.ShowMSG("Category Updated Successfully", "Success", "Success");
            }
            catch (Exception ex)
            {
                Main.ShowMSG("Error While Updating Category. " + ex.Message, "Error", "Error");
            }
        }
    }
}
