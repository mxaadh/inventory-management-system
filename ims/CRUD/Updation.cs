using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ims.CRUD
{
    internal class Updation
    {
        public Updation() => Main.con.Open();
        ~Updation() => Main.con.Close();

        public bool UpdateUser(int id, string name, string username, string password, string email, string phone)
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
                cmd.Parameters.AddWithValue("@_id", id);
                cmd.ExecuteNonQuery();
                Main.ShowMSG("User Updated Successfully", "Success", "Success");
                return true;
            }
            catch (Exception ex)
            {
                Main.ShowMSG("Error While Updating User. " + ex.Message, "Error", "Error");
            }

            return false; 
        }
    }
}
