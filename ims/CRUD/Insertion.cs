using System.Data;
using System.Data.SqlClient;

namespace ims.CRUD
{
    internal class Insertion
    {
        public Insertion() => Main.con.Open();
        ~Insertion() => Main.con.Close();

        public bool InsertUser(string name, string username, string password, string email, string phone)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_insertUsers", Main.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@_usr_name", name);
                cmd.Parameters.AddWithValue("@_usr_username", username);
                cmd.Parameters.AddWithValue("@_usr_password", password);
                cmd.Parameters.AddWithValue("@_usr_phone", email);
                cmd.Parameters.AddWithValue("@_usr_email", phone);
                cmd.ExecuteNonQuery();
                Main.ShowMSG("User Inserted Successfully", "Success", "Success");
                return true;
            }
            catch (Exception ex)
            {
                Main.ShowMSG("Error While Inserting User. " + ex.Message, "Error", "Error");
            }

            return false;
        }
    }
}
